using System;
using System.Drawing;
using System.IO;

namespace ImageCompressor {
    public interface ICompressor {
        Stream Compress(Image image);
    }
}
