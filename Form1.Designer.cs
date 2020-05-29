namespace FolderWatcher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripChooseFolderButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripFolderLabel = new System.Windows.Forms.ToolStripLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 16;
            this.listBoxLog.Location = new System.Drawing.Point(0, 27);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(800, 423);
            this.listBoxLog.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripClearButton,
            this.toolStripChooseFolderButton,
            this.toolStripFolderLabel,
            this.toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripClearButton
            // 
            this.toolStripClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripClearButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClearButton.Image")));
            this.toolStripClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearButton.Name = "toolStripClearButton";
            this.toolStripClearButton.Size = new System.Drawing.Size(47, 24);
            this.toolStripClearButton.Text = "Clear";
            this.toolStripClearButton.Click += new System.EventHandler(this.ToolStripClearButton_Click);
            // 
            // toolStripChooseFolderButton
            // 
            this.toolStripChooseFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripChooseFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripChooseFolderButton.Image")));
            this.toolStripChooseFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChooseFolderButton.Name = "toolStripChooseFolderButton";
            this.toolStripChooseFolderButton.Size = new System.Drawing.Size(108, 24);
            this.toolStripChooseFolderButton.Text = "Choose Folder";
            this.toolStripChooseFolderButton.Click += new System.EventHandler(this.ToolStripChooseFolderButton_Click);
            // 
            // toolStripFolderLabel
            // 
            this.toolStripFolderLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFolderLabel.Name = "toolStripFolderLabel";
            this.toolStripFolderLabel.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(0, 24);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Folder Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripClearButton;
        private System.Windows.Forms.ToolStripButton toolStripChooseFolderButton;
        private System.Windows.Forms.ToolStripLabel toolStripFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
    }
}

