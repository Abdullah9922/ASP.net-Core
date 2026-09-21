using System;
using System.Collections.Generic;
using System.Text;

namespace DownloadEventArgs__Practice_
{
    public class DownloadEventArgs : EventArgs
    {
        public string FileName { get; }
        public string UserName { get; }
        public double FileSize { get; }

        public DownloadEventArgs(string fileName, string userName, double fileSize)
        {
            FileName = fileName;
            UserName = userName;
            FileSize = fileSize;
        }
    }
}
