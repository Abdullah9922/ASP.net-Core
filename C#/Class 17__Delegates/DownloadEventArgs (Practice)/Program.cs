
using DownloadEventArgs__Practice_;

FileDownload fd = new FileDownload();

fd.handler += (x) =>
{
    Console.WriteLine("Download complite: ");
    Console.WriteLine($"File Name : {x.FileName}");
    Console.WriteLine($"User Name : {x.UserName}");
    Console.WriteLine($"Size : {x.FileSize}");
};

fd.DownloadCompleted("korim", "rohim", 25);
