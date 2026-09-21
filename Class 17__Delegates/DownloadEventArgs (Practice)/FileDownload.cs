using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DownloadEventArgs__Practice_
{
    public delegate void DownloadHandler(DownloadEventArgs x);
    public class FileDownload
    {
        public event DownloadHandler? handler;

        public void DownloadCompleted(string fileName, string userName, double fileSize)
        {
            //Console.WriteLine($"File Name : {fileName}");
            //Console.WriteLine($"User Name : {userName}");
            //Console.WriteLine($"Size : {fileSize}");

            DownloadEventArgs data = new DownloadEventArgs( fileName, userName, fileSize );
            handler?.Invoke(data);
        }
    }
}
