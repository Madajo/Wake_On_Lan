#region ----- USING -----
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
#endregion ----- USING -----
namespace WakeOnLan
{
    public partial class MainForm : Form
    {
        public PythonListener pythonListener;
        public ScheduleForm scheduleform;

        public MainForm()
        {
            InitializeComponent();
            pythonListener = new PythonListener(this);
        }

        public void AddComps(string[] computers)
        {
            ListViewComps.Items.Clear();
            ListViewGroup OnlineGroup = new ListViewGroup("ONLINE");
            ListViewComps.Groups.Add(OnlineGroup);
            ListViewGroup OfflineGroup = new ListViewGroup("OFFLINE");
            ListViewComps.Groups.Add(OfflineGroup);
            foreach (string comp in computers)
            {
                
                string[] details = comp.Split('&');
                if (details.Length == 3)
                {
                    if (details[2] == "Online")
                    {
                        ListViewComps.Items.Add(new ListViewItem(details, OnlineGroup));
                    }
                    if (details[2] == "Offline")
                    {
                        ListViewComps.Items.Add(new ListViewItem(details, OfflineGroup));
                    }
                }
                
            }
        }

        public void CompStatus(string msg)
        {
            WOL_Status.Text = msg;
        }

        private void ListViewComps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(1000);
            pythonListener.Send("GetDB");
        }



        private void Refresh_Click(object sender, EventArgs e)
        {
            pythonListener.Send("UpdateDB");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pythonListener.Close();
        }

        private void ListViewComps_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ListViewComps.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);

                    
                }


            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ListViewItem item = ListViewComps.SelectedItems[0];
            string status = item.SubItems[2].Text;
            if (status == "Online")
            {
                wakeUpToolStripMenuItem.Visible = false;
                shutdownToolStripMenuItem.Visible = true;
                remoteDesktopToolStripMenuItem.Visible = true;
            }
            if (status == "Offline")
            {
                wakeUpToolStripMenuItem.Visible = true;
                shutdownToolStripMenuItem.Visible = false;
                remoteDesktopToolStripMenuItem.Visible = false;
            }
        }

        private void wakeUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = ListViewComps.SelectedItems[0];
            string ip = item.SubItems[0].Text;
            string mac = item.SubItems[1].Text;
            pythonListener.Send("WakeUpComp#" + ip + "#" + mac);
        }

        private void remoteDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = ListViewComps.SelectedItems[0];
            string ip = item.SubItems[0].Text;
            pythonListener.Send("RemoteDesktop#" + ip);
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = ListViewComps.SelectedItems[0];
            ShutDownForm shutdownform = new ShutDownForm(this, pythonListener, item);
            shutdownform.ShowDialog();
        }

        private void WakeUpAll_Click(object sender, EventArgs e)
        {
            pythonListener.Send("WakeUpAll#");
        }

        private void ShutDownAll_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("All");
            item.SubItems.Add("All");
            ShutDownForm shutdownform = new ShutDownForm(this, pythonListener, item);
            shutdownform.ShowDialog();

        }


        public void RemoveTask(string[] task)
        {
            pythonListener.Send("RemoveFromSchedule#" + task[0] + "#" + task[1] + "#" + task[2]);
        
        }
        public void SendTasks(string[] tasks)
        {
            scheduleform.AddTasks(tasks);
        }

        public void ClearSchedule()
        {
            pythonListener.Send("ClearSchedule#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pythonListener.Send("GetSchedule#");
            scheduleform = new ScheduleForm(this, ListViewComps);
            scheduleform.ShowDialog();
        }

    }
}
