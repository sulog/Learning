using System;
using System.IO;
using System.Windows.Forms;

namespace LogTailer
{
    public partial class Form1 : Form
    {
        LogFileWatcher watcher;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            string fileName = txtLogFilePath.Text;

            if (fileName == string.Empty)
                MessageBox.Show("Please provide the log file path to watch :)");
            else
            {
                if (watcher == null)
                {
                    watcher = new LogFileWatcher(fileName);
                    watcher.Path = Path.GetDirectoryName(fileName);
                    watcher.NotifyFilter = (NotifyFilters.LastWrite | NotifyFilters.Size);
                    watcher.Filter = Path.GetFileName(fileName);
                    watcher.TextChanged += new LogFileWatcher.LogWatcherEventHandler(Watcher_Changed);
                    watcher.EnableRaisingEvents = true;
                }
                else
                {
                    watcher.TextChanged += new LogFileWatcher.LogWatcherEventHandler(Watcher_Changed);
                }
            }
        }

        void Watcher_Changed(object sender, LogWatcherEventArgs e)
        {
            if (rtbLogContent.InvokeRequired) this.Invoke(new Action(delegate () { AppendText(e.contents); }));
            else AppendText(e.contents);
        }

        private void AppendText(string Text)
        {
            rtbLogContent.Text += Text;
            rtbLogContent.SelectionStart = rtbLogContent.Text.Length;
            rtbLogContent.SelectionLength = 0;
            rtbLogContent.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbLogContent.Clear();
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (watcher == null)
                MessageBox.Show("No watchers to stop :(");
            else
                watcher.TextChanged -= new LogFileWatcher.LogWatcherEventHandler(Watcher_Changed);
        }
    }
}
