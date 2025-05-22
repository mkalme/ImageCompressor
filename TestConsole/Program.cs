using System;
using System.Threading.Tasks;
using CustomDialogs;

namespace TestConsole {
    class Program {
        private static IPasswordGenerator _first = new PasswordGeneratorFirst();
        private static IPasswordGenerator _second = new PasswordGeneratorSecond();

        private static int _length = 5;
        private static int _repeat = 1000000;

        static void Main() {
            long[] averages = new long[_repeat]; 

            Parallel.For(0, _repeat, i => {
                long count = CrackPassword(_first.Generate(_length));
                
                averages[i] = count;
            });

            long average = 0;
            for (int i = 0; i < _repeat; i++) {
                average += averages[i];
            }

            Console.WriteLine(average / (double)_repeat);
            Console.ReadLine();
        }

        private static long CrackPassword(string password) {
            long count = 0;

            do {
                count++;
            } while (_second.Generate(_length) != password);

            return count;
        }
    }

    public class PasswordGeneratorFirst : IPasswordGenerator {
        public bool SetLength => false;
        public string Format => "ASCII Format";

        public string Characters { get; set; } = "ab";

        public string Generate(int length) {
            char[] output = new char[length];

            byte[] bytes = PasswordGenerator.GenerateBytes(length);
            for (int i = 0; i < length; i++) {
                output[i] = Characters[bytes[i] % Characters.Length];
            }

            return new string(output);
        }
    }

    public class PasswordGeneratorSecond : IPasswordGenerator {
        public bool SetLength => false;
        public string Format => "ASCII Format";

        public string Characters { get; set; } = "ab";

        public string Generate(int length) {
            char[] output = new char[length];
            int index = 0;

            while (index < length) { 
                byte b = PasswordGenerator.GenerateBytes(1)[0];
                //if (b == 255) continue;

                output[index++] = b < 255 ? Characters[0] : Characters[1];
            }

            return new string(output);
        }
    }
}
