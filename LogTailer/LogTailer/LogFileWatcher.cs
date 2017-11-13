using System.IO;

namespace LogTailer
{
    public class LogFileWatcher : FileSystemWatcher
    {
        internal string FileName = string.Empty;
        private FileStream Stream;
        private StreamReader Reader;

        public LogFileWatcher(string fileName)
        {
            Changed += OnChanged;
            FileName = fileName;

            Stream = new FileStream
                (FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            Reader = new StreamReader(Stream);

            Stream.Position = Stream.Length;
        }

        public void OnChanged(object o, FileSystemEventArgs e)
        {
            string Contents = Reader.ReadToEnd();

            LogWatcherEventArgs args = new LogWatcherEventArgs(Contents);
            TextChanged?.Invoke(this, args);
        }

        public delegate void LogWatcherEventHandler(object sender, LogWatcherEventArgs e);

        public event LogWatcherEventHandler TextChanged;
    }
}
