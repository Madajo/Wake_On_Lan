namespace WakeOnLan
{
    partial class CreatTask
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
            this.Computers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFuncType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Sunday = new System.Windows.Forms.CheckBox();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Saturday = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.Creatask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Computers
            // 
            this.Computers.FormattingEnabled = true;
            this.Computers.Location = new System.Drawing.Point(76, 62);
            this.Computers.Name = "Computers";
            this.Computers.Size = new System.Drawing.Size(121, 21);
            this.Computers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Create Task Form";
            // 
            // comboBoxFuncType
            // 
            this.comboBoxFuncType.FormattingEnabled = true;
            this.comboBoxFuncType.Items.AddRange(new object[] {
            "WakeUp",
            "Shutdown",
            "WakeAll",
            "ShutDownAll"});
            this.comboBoxFuncType.Location = new System.Drawing.Point(298, 61);
            this.comboBoxFuncType.Name = "comboBoxFuncType";
            this.comboBoxFuncType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFuncType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FuncType";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "On Specific Date";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 199);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Any Day of the Week";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(28, 222);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(62, 17);
            this.Sunday.TabIndex = 10;
            this.Sunday.Text = "Sunday";
            this.Sunday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(117, 222);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(64, 17);
            this.Monday.TabIndex = 11;
            this.Monday.Text = "Monday";
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(210, 222);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(67, 17);
            this.Tuesday.TabIndex = 12;
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(298, 222);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(83, 17);
            this.Wednesday.TabIndex = 13;
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(75, 245);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(70, 17);
            this.Thursday.TabIndex = 14;
            this.Thursday.Text = "Thursday";
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(189, 245);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(54, 17);
            this.Friday.TabIndex = 15;
            this.Friday.Text = "Friday";
            this.Friday.UseVisualStyleBackColor = true;
            this.Friday.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(298, 245);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(68, 17);
            this.Saturday.TabIndex = 16;
            this.Saturday.Text = "Saturday";
            this.Saturday.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hours/Min/Sec:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "23"});
            this.comboBoxHours.Location = new System.Drawing.Point(172, 303);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(38, 21);
            this.comboBoxHours.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = ":";
            // 
            // comboBoxMin
            // 
            this.comboBoxMin.FormattingEnabled = true;
            this.comboBoxMin.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "59"});
            this.comboBoxMin.Location = new System.Drawing.Point(235, 304);
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(34, 21);
            this.comboBoxMin.TabIndex = 20;
            // 
            // Creatask
            // 
            this.Creatask.Location = new System.Drawing.Point(172, 355);
            this.Creatask.Name = "Creatask";
            this.Creatask.Size = new System.Drawing.Size(75, 23);
            this.Creatask.TabIndex = 21;
            this.Creatask.Text = "Create Task";
            this.Creatask.UseVisualStyleBackColor = true;
            // 
            // CreatTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 390);
            this.Controls.Add(this.Creatask);
            this.Controls.Add(this.comboBoxMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFuncType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Computers);
            this.Name = "CreatTask";
            this.Text = "CreatTask";
            this.Load += new System.EventHandler(this.CreatTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Computers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFuncType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox Sunday;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Saturday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMin;
        private System.Windows.Forms.Button Creatask;
    }
}