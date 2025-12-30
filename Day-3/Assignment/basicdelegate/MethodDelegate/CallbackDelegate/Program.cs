public delegate void DownLoadCompletedCallback(string fileName);

class FileDownloader
{
    public void DownloadFile(string url, DownLoadCompletedCallback callback)
    {
        Console.WriteLine($"Starting download from {url}...");

        System.Threading.Thread.Sleep(5000); // Simulate download time

        string filename = "file.txt"; // Simulated downloaded file name

        Console.WriteLine($"Download completed: {filename}");

        callback(filename);
    }
}

public class  Program
{
    static void OnDownLoadComplete(string filename)
    {
        Console.WriteLine($"Processing downloaded file: {filename}");
    }

    public static void Main(string[] args)
    {
        FileDownloader downloader = new FileDownloader();
        downloader.DownloadFile("http://example.com/file.txt", OnDownLoadComplete);
    }
}
