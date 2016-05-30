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
    public partial class ShutDownForm : Form
    {
        public MainForm Mainform;
        public PythonListener Pythonlistener;


        public ShutDownForm(MainForm mainform, PythonListener pythonlistener, ListViewItem item)
        {
            InitializeComponent();
            Mainform = mainform;
            Pythonlistener = pythonlistener;
            label_ip.Text = item.SubItems[0].Text;
            label_mac.Text = item.SubItems[1].Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Text = "Shutting Down..";
            string msg = textBoxMessage.Text;
            string timeout = comboBoxTimeout.Text;
            bool force = checkBoxForce.Checked;
            int forcenum;
            if (force == true)
            {
                forcenum = 1;
            }
            else
            {
                forcenum = 0;
            }
            bool reboot = checkBoxReboot.Checked;
            int rebootnum;
            if (reboot == true)
            {
                rebootnum = 1;
            }
            else
            {
                rebootnum = 0;
            }
            if (timeout == "")
            {
                labelError.Text = "You have to choose a timeout number ";
            }
            if (msg == "")
            {
                labelError.Text = "You have to send a ShutDown Message";
            }
            if (timeout != "" && msg != "")
            {
                if (label_ip.Text == "All" && label_mac.Text == "All")
                {
                    Pythonlistener.Send("ShutDownAll#" + msg + "#" + timeout + "#" + forcenum.ToString() + "#" + rebootnum.ToString());
                    this.Close();
                }
                else
                {
                    Pythonlistener.Send("ShutDownComp#" + label_ip.Text + "#" + msg + "#" + timeout + "#" + forcenum.ToString() + "#" + rebootnum.ToString());
                    this.Close();
                }

                
    
            }

        }
    }
}
