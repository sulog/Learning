
namespace LogTailer
{
    public class LogWatcherEventArgs
    {
        public string contents;

        public LogWatcherEventArgs(string contents)
        {
            this.contents = contents;
        }
    }
}
