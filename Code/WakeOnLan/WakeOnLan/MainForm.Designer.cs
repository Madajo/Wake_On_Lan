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
            this.WakeUpAll = new System.Windows.Forms.Button();
            this.ShutDownAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
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
            this.Refresh.Location = new System.Drawing.Point(418, 336);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(84, 23);
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
            // WakeUpAll
            // 
            this.WakeUpAll.BackColor = System.Drawing.Color.SpringGreen;
            this.WakeUpAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WakeUpAll.Location = new System.Drawing.Point(418, 198);
            this.WakeUpAll.Name = "WakeUpAll";
            this.WakeUpAll.Size = new System.Drawing.Size(95, 23);
            this.WakeUpAll.TabIndex = 3;
            this.WakeUpAll.Text = "Wake Up All";
            this.WakeUpAll.UseVisualStyleBackColor = false;
            this.WakeUpAll.Click += new System.EventHandler(this.WakeUpAll_Click);
            // 
            // ShutDownAll
            // 
            this.ShutDownAll.BackColor = System.Drawing.Color.DeepPink;
            this.ShutDownAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutDownAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShutDownAll.Location = new System.Drawing.Point(418, 238);
            this.ShutDownAll.Name = "ShutDownAll";
            this.ShutDownAll.Size = new System.Drawing.Size(95, 23);
            this.ShutDownAll.TabIndex = 4;
            this.ShutDownAll.Text = "Shut Down All";
            this.ShutDownAll.UseVisualStyleBackColor = false;
            this.ShutDownAll.Click += new System.EventHandler(this.ShutDownAll_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(30, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Schedule";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(525, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShutDownAll);
            this.Controls.Add(this.WakeUpAll);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.WOL_Status);
            this.Controls.Add(this.ListViewComps);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button WakeUpAll;
        private System.Windows.Forms.Button ShutDownAll;
        private System.Windows.Forms.Button button1;
    }
}

