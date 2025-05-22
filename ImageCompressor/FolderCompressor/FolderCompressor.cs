using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;

namespace ImageCompressor {
    public class FolderCompressor : IFolderCompressor {
        public ICompressor Compressor { get; set; }
        public int Threads { get; set; } = Environment.ProcessorCount;

        public void Compress(string[] folders, string outputBaseFolder) {
            List<(string, string[])> allFiles = new List<(string, string[])>();
            foreach (var folder in folders) {
                allFiles.Add((Path.GetDirectoryName(folder), Directory.GetFiles(folder, "*", SearchOption.AllDirectories)));

                CreateAllDirectories(folder, outputBaseFolder, Directory.GetDirectories(folder, "*", SearchOption.AllDirectories));
            }

            CreateAllFiles(allFiles, outputBaseFolder);
        }

        private void CreateAllDirectories(string baseDirectory, string destination, IEnumerable<string> directories) {
            Directory.CreateDirectory($"{destination}\\{Path.GetFileName(baseDirectory)}");
            string baseParent = Path.GetDirectoryName(baseDirectory);

            foreach (string folder in directories) {
                string dest = GetDestination(folder, baseParent, destination);
                Directory.CreateDirectory(dest);
            }
        }
        private void CreateAllFiles(List<(string, string[])> files, string destination) {
            foreach (var bundle in files) {
                ForEachUtilities.SplitForEach(bundle.Item2, Threads, f => {
                    IEnumerable<ImageResult> images = LoadImages(f);

                    Parallel.ForEach(images, image => {
                        if(image.Successfull) image.CompressedImage = Compressor.Compress(image.Image);
                    });

                    new Thread(() => {
                        foreach (var image in images) {
                            string dest = GetDestination(image.Path, bundle.Item1, destination);

                            if (image.Successfull) {
                                using (FileStream fs = File.Create(dest)) {
                                    image.CompressedImage.Position = 0;
                                    image.CompressedImage.CopyTo(fs);
                                }
                            } else {
                                File.Copy(image.Path, dest);
                            }

                            image.Dispose();
                        }
                    }).Start();
                });
            }
        }

        private IEnumerable<ImageResult> LoadImages(IEnumerable<string> files) {
            List<ImageResult> images = new List<ImageResult>();
            
            foreach (var file in files) {
                try {
                    Image image = Image.FromFile(file);
                    images.Add(new ImageResult(image, file));
                } catch {
                    images.Add(new ImageResult(file));
                }
            }

            return images;
        }

        private static string GetDestination(string main, string baseDirectory, string destination) {
            return $"{destination}\\{GetUncommonString(main, baseDirectory)}";
        }
        private static string GetUncommonString(string main, string baseString) {
            if (main == baseString) return main;

            StringBuilder builder = new StringBuilder(main);

            int min = Math.Min(main.Length, baseString.Length);
            for (int i = 0; i < min; i++) {
                if (main[i] != baseString[i]) {
                    return builder.ToString();
                }

                builder.Remove(0, 1);
            }

            return builder.ToString();
        }
    }
}
