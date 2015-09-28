namespace Profilometer_Keyence
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textbox_commandport = new System.Windows.Forms.TextBox();
            this.textbox_frequency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_ipaddress4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_ipaddress3 = new System.Windows.Forms.TextBox();
            this.textbox_ipaddress1 = new System.Windows.Forms.TextBox();
            this.textbox_ipaddress2 = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.textbox_filename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textbox_size = new System.Windows.Forms.TextBox();
            this.checkbox_sizelimit = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkbox_datetimelimit = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radiobutton_combined = new System.Windows.Forms.RadioButton();
            this.radiobutton_individual = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.timerSizeLimit = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textbox_commandport);
            this.groupBox1.Controls.Add(this.textbox_frequency);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textbox_ipaddress4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textbox_ipaddress3);
            this.groupBox1.Controls.Add(this.textbox_ipaddress1);
            this.groupBox1.Controls.Add(this.textbox_ipaddress2);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(507, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethernet Settings";
            // 
            // textbox_commandport
            // 
            this.textbox_commandport.Location = new System.Drawing.Point(386, 18);
            this.textbox_commandport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_commandport.Multiline = true;
            this.textbox_commandport.Name = "textbox_commandport";
            this.textbox_commandport.Size = new System.Drawing.Size(98, 20);
            this.textbox_commandport.TabIndex = 12;
            // 
            // textbox_frequency
            // 
            this.textbox_frequency.Location = new System.Drawing.Point(386, 47);
            this.textbox_frequency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_frequency.Multiline = true;
            this.textbox_frequency.Name = "textbox_frequency";
            this.textbox_frequency.Size = new System.Drawing.Size(98, 20);
            this.textbox_frequency.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Frequency";
            // 
            // textbox_ipaddress4
            // 
            this.textbox_ipaddress4.Location = new System.Drawing.Point(196, 46);
            this.textbox_ipaddress4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_ipaddress4.Multiline = true;
            this.textbox_ipaddress4.Name = "textbox_ipaddress4";
            this.textbox_ipaddress4.Size = new System.Drawing.Size(46, 20);
            this.textbox_ipaddress4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // textbox_ipaddress3
            // 
            this.textbox_ipaddress3.Location = new System.Drawing.Point(143, 46);
            this.textbox_ipaddress3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_ipaddress3.Multiline = true;
            this.textbox_ipaddress3.Name = "textbox_ipaddress3";
            this.textbox_ipaddress3.Size = new System.Drawing.Size(46, 20);
            this.textbox_ipaddress3.TabIndex = 6;
            // 
            // textbox_ipaddress1
            // 
            this.textbox_ipaddress1.Location = new System.Drawing.Point(143, 18);
            this.textbox_ipaddress1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_ipaddress1.Multiline = true;
            this.textbox_ipaddress1.Name = "textbox_ipaddress1";
            this.textbox_ipaddress1.Size = new System.Drawing.Size(46, 20);
            this.textbox_ipaddress1.TabIndex = 4;
            // 
            // textbox_ipaddress2
            // 
            this.textbox_ipaddress2.Location = new System.Drawing.Point(199, 18);
            this.textbox_ipaddress2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_ipaddress2.Multiline = true;
            this.textbox_ipaddress2.Name = "textbox_ipaddress2";
            this.textbox_ipaddress2.Size = new System.Drawing.Size(46, 20);
            this.textbox_ipaddress2.TabIndex = 5;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(409, 18);
            this.button_browse.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(66, 23);
            this.button_browse.TabIndex = 4;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textbox_filename
            // 
            this.textbox_filename.Location = new System.Drawing.Point(94, 21);
            this.textbox_filename.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_filename.Name = "textbox_filename";
            this.textbox_filename.Size = new System.Drawing.Size(308, 20);
            this.textbox_filename.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "File Name";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(10, 23);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(87, 37);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(10, 69);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(87, 38);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_status);
            this.groupBox3.Location = new System.Drawing.Point(14, 213);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox3.Size = new System.Drawing.Size(395, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(7, 23);
            this.textBox_status.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_status.Size = new System.Drawing.Size(383, 91);
            this.textBox_status.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_connect);
            this.groupBox4.Controls.Add(this.button_disconnect);
            this.groupBox4.Location = new System.Drawing.Point(416, 213);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox4.Size = new System.Drawing.Size(108, 123);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(14, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(507, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textbox_size);
            this.groupBox8.Controls.Add(this.checkbox_sizelimit);
            this.groupBox8.Location = new System.Drawing.Point(349, 64);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox8.Size = new System.Drawing.Size(153, 44);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // textbox_size
            // 
            this.textbox_size.Location = new System.Drawing.Point(94, 18);
            this.textbox_size.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textbox_size.Multiline = true;
            this.textbox_size.Name = "textbox_size";
            this.textbox_size.Size = new System.Drawing.Size(52, 20);
            this.textbox_size.TabIndex = 5;
            // 
            // checkbox_sizelimit
            // 
            this.checkbox_sizelimit.Location = new System.Drawing.Point(10, 18);
            this.checkbox_sizelimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbox_sizelimit.Name = "checkbox_sizelimit";
            this.checkbox_sizelimit.Size = new System.Drawing.Size(78, 21);
            this.checkbox_sizelimit.TabIndex = 1;
            this.checkbox_sizelimit.Text = "Size Limit";
            this.checkbox_sizelimit.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkbox_datetimelimit);
            this.groupBox7.Location = new System.Drawing.Point(213, 64);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(132, 44);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // checkbox_datetimelimit
            // 
            this.checkbox_datetimelimit.Location = new System.Drawing.Point(10, 18);
            this.checkbox_datetimelimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkbox_datetimelimit.Name = "checkbox_datetimelimit";
            this.checkbox_datetimelimit.Size = new System.Drawing.Size(115, 21);
            this.checkbox_datetimelimit.TabIndex = 0;
            this.checkbox_datetimelimit.Text = "Date Time Limit";
            this.checkbox_datetimelimit.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radiobutton_combined);
            this.groupBox5.Controls.Add(this.radiobutton_individual);
            this.groupBox5.Location = new System.Drawing.Point(8, 64);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(199, 44);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Storage Type";
            // 
            // radiobutton_combined
            // 
            this.radiobutton_combined.Location = new System.Drawing.Point(108, 18);
            this.radiobutton_combined.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_combined.Name = "radiobutton_combined";
            this.radiobutton_combined.Size = new System.Drawing.Size(80, 21);
            this.radiobutton_combined.TabIndex = 1;
            this.radiobutton_combined.TabStop = true;
            this.radiobutton_combined.Text = "Combined";
            this.radiobutton_combined.UseVisualStyleBackColor = true;
            this.radiobutton_combined.CheckedChanged += new System.EventHandler(this.radiobutton_combined_CheckedChanged);
            // 
            // radiobutton_individual
            // 
            this.radiobutton_individual.Location = new System.Drawing.Point(17, 18);
            this.radiobutton_individual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radiobutton_individual.Name = "radiobutton_individual";
            this.radiobutton_individual.Size = new System.Drawing.Size(78, 21);
            this.radiobutton_individual.TabIndex = 0;
            this.radiobutton_individual.TabStop = true;
            this.radiobutton_individual.Text = "Individual";
            this.radiobutton_individual.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.button_browse);
            this.groupBox6.Controls.Add(this.textbox_filename);
            this.groupBox6.Location = new System.Drawing.Point(8, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(493, 53);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "File Path";
            // 
            // timerSizeLimit
            // 
            this.timerSizeLimit.Tick += new System.EventHandler(this.timerSizeLimit_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 343);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profilometer - Keyence";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_ipaddress4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_ipaddress3;
        private System.Windows.Forms.TextBox textbox_ipaddress1;
        private System.Windows.Forms.TextBox textbox_ipaddress2;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.TextBox textbox_frequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_filename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textbox_commandport;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textbox_size;
        private System.Windows.Forms.CheckBox checkbox_sizelimit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkbox_datetimelimit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radiobutton_combined;
        private System.Windows.Forms.RadioButton radiobutton_individual;
        private System.Windows.Forms.Timer timerSizeLimit;
    }
}

