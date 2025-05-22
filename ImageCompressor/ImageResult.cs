using System;
using System.Drawing;
using System.IO;

namespace ImageCompressor {
    public class ImageResult : IDisposable {
        public string Path { get; set; }
        public Image Image { get; set; } = null;
        public bool Successfull { get; set; } = false;

        public Stream CompressedImage { get; set; }

        public ImageResult(string path) {
            Path = path;
        }
        public ImageResult(Image image, string path) {
            Image = image;
            Path = path;
            Successfull = true;
        }

        public void Dispose() {
            Image?.Dispose();
            CompressedImage?.Dispose();
        }
    }
}
