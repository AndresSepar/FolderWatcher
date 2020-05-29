using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderWatcher
{
    public partial class MainForm : Form
    {
        FileSystemWatcher watcher;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            StartMonitoring();
        }

        private void StartMonitoring()
        {
            watcher = new FileSystemWatcher(toolStripLabel.Text)
            {
                IncludeSubdirectories = true,
                EnableRaisingEvents = true
            };
            watcher.Created += Watcher_Handler;
            watcher.Deleted += Watcher_Handler;
            watcher.Renamed += Watcher_Handler;
            watcher.Changed += Watcher_Handler;
        }

        private void Watcher_Handler(object sender, FileSystemEventArgs e)
        {
            Invoke(new Action(() =>
            {
                listBoxLog.Items.Add($"[{DateTime.Now}][{e.ChangeType}] {e.FullPath}");
            }));
        }

        private void ToolStripClearButton_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Clear();
        }

        private void ToolStripChooseFolderButton_Click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;
            folderBrowserDialog.SelectedPath = toolStripLabel.Text;
            var dlg = folderBrowserDialog.ShowDialog();
            
            if (dlg == DialogResult.OK)
            {
                string OldPath = toolStripLabel.Text;

                try
                {
                    watcher.Path = folderBrowserDialog.SelectedPath;
                    watcher.EnableRaisingEvents = true;
                } catch (FileNotFoundException ex)
                {
                    toolStripLabel.Text = OldPath;
                    watcher.Path = OldPath;

                    MessageBox.Show($"Seems you don't have permission to access folder {folderBrowserDialog.SelectedPath}. Try starting this app as Administrator\n\nDetails:\n{ex.Message}", "Error", MessageBoxButtons.OK);
                    watcher.EnableRaisingEvents = true;
                }
                toolStripLabel.Text = watcher.Path;
                
            }

        }
    }
}
