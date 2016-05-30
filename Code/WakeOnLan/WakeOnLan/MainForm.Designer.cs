namespace WakeOnLan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListViewComps = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WOL_Status = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wakeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewComps
            // 
            this.ListViewComps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.MAC,
            this.STATUS});
            this.ListViewComps.FullRowSelect = true;
            this.ListViewComps.Location = new System.Drawing.Point(15, 67);
            this.ListViewComps.MultiSelect = false;
            this.ListViewComps.Name = "ListViewComps";
            this.ListViewComps.Size = new System.Drawing.Size(376, 292);
            this.ListViewComps.TabIndex = 0;
            this.ListViewComps.UseCompatibleStateImageBehavior = false;
            this.ListViewComps.View = System.Windows.Forms.View.Details;
            this.ListViewComps.SelectedIndexChanged += new System.EventHandler(this.ListViewComps_SelectedIndexChanged);
            this.ListViewComps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewComps_MouseClick);
            // 
            // IP
            // 
            this.IP.Text = "IP";
            // 
            // MAC
            // 
            this.MAC.Text = "Mac";
            this.MAC.Width = 120;
            // 
            // STATUS
            // 
            this.STATUS.Text = "Status";
            // 
            // WOL_Status
            // 
            this.WOL_Status.AutoSize = true;
            this.WOL_Status.ForeColor = System.Drawing.Color.Red;
            this.WOL_Status.Location = new System.Drawing.Point(12, 375);
            this.WOL_Status.Name = "WOL_Status";
            this.WOL_Status.Size = new System.Drawing.Size(121, 13);
            this.WOL_Status.TabIndex = 1;
            this.WOL_Status.Text = "Wake On Lan App Start";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(397, 336);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wakeUpToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.remoteDesktopToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // wakeUpToolStripMenuItem
            // 
            this.wakeUpToolStripMenuItem.Name = "wakeUpToolStripMenuItem";
            this.wakeUpToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.wakeUpToolStripMenuItem.Text = "WakeUp";
            this.wakeUpToolStripMenuItem.Click += new System.EventHandler(this.wakeUpToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // remoteDesktopToolStripMenuItem
            // 
            this.remoteDesktopToolStripMenuItem.Name = "remoteDesktopToolStripMenuItem";
            this.remoteDesktopToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.remoteDesktopToolStripMenuItem.Text = "Remote Desktop";
            this.remoteDesktopToolStripMenuItem.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.WOL_Status);
            this.Controls.Add(this.ListViewComps);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewComps;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader MAC;
        private System.Windows.Forms.ColumnHeader STATUS;
        private System.Windows.Forms.Label WOL_Status;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wakeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

