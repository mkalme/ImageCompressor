using System;

namespace ImageCompressor {
    public interface IFolderCompressor {
        void Compress(string[] folders, string outputBaseFolder);
    }
}
