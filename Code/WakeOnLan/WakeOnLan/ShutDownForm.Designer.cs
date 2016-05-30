namespace WakeOnLan
{
    partial class ShutDownForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxForce = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxReboot = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_mac = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxTimeout = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShutDown Form";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(75, 221);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(197, 20);
            this.textBoxMessage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timeout";
            // 
            // checkBoxForce
            // 
            this.checkBoxForce.AutoSize = true;
            this.checkBoxForce.Location = new System.Drawing.Point(255, 116);
            this.checkBoxForce.Name = "checkBoxForce";
            this.checkBoxForce.Size = new System.Drawing.Size(15, 14);
            this.checkBoxForce.TabIndex = 5;
            this.checkBoxForce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Force Shutdown";
            // 
            // checkBoxReboot
            // 
            this.checkBoxReboot.AutoSize = true;
            this.checkBoxReboot.Location = new System.Drawing.Point(255, 146);
            this.checkBoxReboot.Name = "checkBoxReboot";
            this.checkBoxReboot.Size = new System.Drawing.Size(15, 14);
            this.checkBoxReboot.TabIndex = 7;
            this.checkBoxReboot.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reboot";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "ShutDown";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "IP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "MAC:";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(57, 57);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(0, 13);
            this.label_ip.TabIndex = 12;
            // 
            // label_mac
            // 
            this.label_mac.AutoSize = true;
            this.label_mac.Location = new System.Drawing.Point(179, 57);
            this.label_mac.Name = "label_mac";
            this.label_mac.Size = new System.Drawing.Size(0, 13);
            this.label_mac.TabIndex = 13;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(12, 286);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 14;
            // 
            // comboBoxTimeout
            // 
            this.comboBoxTimeout.FormattingEnabled = true;
            this.comboBoxTimeout.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.comboBoxTimeout.Location = new System.Drawing.Point(75, 117);
            this.comboBoxTimeout.Name = "comboBoxTimeout";
            this.comboBoxTimeout.Size = new System.Drawing.Size(49, 21);
            this.comboBoxTimeout.TabIndex = 15;
            // 
            // ShutDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 308);
            this.Controls.Add(this.comboBoxTimeout);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label_mac);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxReboot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxForce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label1);
            this.Name = "ShutDownForm";
            this.Text = "ShutDownForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxForce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxReboot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_mac;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ComboBox comboBoxTimeout;
    }
}