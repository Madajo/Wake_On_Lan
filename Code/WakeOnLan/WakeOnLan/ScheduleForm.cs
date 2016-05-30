using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WakeOnLan
{
    public partial class ScheduleForm : Form
    {
        public MainForm Mainform;
        public ListView listView;

        public ScheduleForm(MainForm mainform , ListView listview)
        {
            InitializeComponent();
            Mainform = mainform;
            listView = listview;
            
        }
        public void AddTasks(string[] tasks)
        {
            listViewTasks.Items.Clear();
            foreach (string task in tasks)
            {
                
                string[] details = task.Split('&');
                listViewTasks.Items.Add(new ListViewItem(details));
            }
        }

        private void listViewTasks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewTasks.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
        
        private void removeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string functype, comp, time;
            ListViewItem item = listViewTasks.SelectedItems[0];
            functype = item.SubItems[0].Text;
            comp = item.SubItems[1].Text;
            time = item.SubItems[2].Text;
            string[] RemoveTask = new string[3] { functype, comp, time };
            Mainform.RemoveTask(RemoveTask);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainform.ClearSchedule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreatTask(this, listView).ShowDialog();
        }
    }   

}
