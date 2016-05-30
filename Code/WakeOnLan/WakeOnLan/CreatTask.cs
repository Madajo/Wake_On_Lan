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

namespace WakeOnLan
{
    public partial class CreatTask : Form
    {
        public ScheduleForm scheduleform;
        public ListView listView;

        public CreatTask(ScheduleForm form, ListView view)
        {
            InitializeComponent();
            scheduleform = form;
            listView = view;
            
            int i = 1;
            ComboBox.ObjectCollection Macs = new ComboBox.ObjectCollection(Computers);
            Macs.Insert(0, "");
            foreach(ListViewItem item in view.Items)
            {
                if (i != view.Items.Count)
                {
                    Macs.Insert(i, item.SubItems[1].Text);
                    i++;
                }
                
            }
            Computers.DataSource = Macs;

            
        }

        private void CreatTask_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            Sunday.Visible = false;
            Monday.Visible = false;
            Tuesday.Visible = false;
            Wednesday.Visible = false;
            Thursday.Visible = false;
            Friday.Visible = false;
            Saturday.Visible = false;
            comboBoxHours.Visible = true;
            comboBoxMin.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            Sunday.Visible = true;
            Monday.Visible = true;
            Tuesday.Visible = true;
            Wednesday.Visible = true;
            Thursday.Visible = true;
            Friday.Visible = true;
            Saturday.Visible = true;
            comboBoxHours.Visible = true;
            comboBoxMin.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }
    }
}
