using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageCompressor {
    public class Compressor : ICompressor {
        public long Level { get; set; }

        public Stream Compress(Image image) {
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, Level);

            ImageCodecInfo imageCodecInfo = GetEncoderInfo("image/jpeg");

            MemoryStream ms = new MemoryStream();
            image.Save(ms, imageCodecInfo, encoderParams);

            return ms;
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType) {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();

            for (int i = 0; i <= encoders.Length; i++) {
                if (encoders[i].MimeType == mimeType) return encoders[i];
            }

            return null;
        }
    }
}
