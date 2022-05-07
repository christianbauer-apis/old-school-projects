namespace WindowsFormsApplication5
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
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.sfText = new System.Windows.Forms.TextBox();
            this.flooringBox = new System.Windows.Forms.ListBox();
            this.install = new System.Windows.Forms.RadioButton();
            this.noinstall = new System.Windows.Forms.RadioButton();
            this.install_Date = new System.Windows.Forms.DateTimePicker();
            this.Process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(56, 27);
            this.idText.Margin = new System.Windows.Forms.Padding(2);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(76, 20);
            this.idText.TabIndex = 0;
            this.idText.TextChanged += new System.EventHandler(this.idText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(221, 29);
            this.nameText.Margin = new System.Windows.Forms.Padding(2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(76, 20);
            this.nameText.TabIndex = 1;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // sfText
            // 
            this.sfText.Location = new System.Drawing.Point(417, 29);
            this.sfText.Margin = new System.Windows.Forms.Padding(2);
            this.sfText.Name = "sfText";
            this.sfText.Size = new System.Drawing.Size(76, 20);
            this.sfText.TabIndex = 2;
            this.sfText.TextChanged += new System.EventHandler(this.sfText_TextChanged);
            // 
            // flooringBox
            // 
            this.flooringBox.FormattingEnabled = true;
            this.flooringBox.Items.AddRange(new object[] {
            "Hardwood",
            "Carpet",
            "Laminate",
            "Tile"});
            this.flooringBox.Location = new System.Drawing.Point(56, 124);
            this.flooringBox.Margin = new System.Windows.Forms.Padding(2);
            this.flooringBox.Name = "flooringBox";
            this.flooringBox.Size = new System.Drawing.Size(91, 69);
            this.flooringBox.TabIndex = 3;
            this.flooringBox.SelectedIndexChanged += new System.EventHandler(this.flooringBox_SelectedIndexChanged);
            // 
            // install
            // 
            this.install.AutoSize = true;
            this.install.Location = new System.Drawing.Point(212, 124);
            this.install.Margin = new System.Windows.Forms.Padding(2);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(75, 17);
            this.install.TabIndex = 4;
            this.install.TabStop = true;
            this.install.Text = "Installation";
            this.install.UseVisualStyleBackColor = true;
            this.install.CheckedChanged += new System.EventHandler(this.install_CheckedChanged);
            // 
            // noinstall
            // 
            this.noinstall.AutoSize = true;
            this.noinstall.Location = new System.Drawing.Point(212, 161);
            this.noinstall.Margin = new System.Windows.Forms.Padding(2);
            this.noinstall.Name = "noinstall";
            this.noinstall.Size = new System.Drawing.Size(92, 17);
            this.noinstall.TabIndex = 5;
            this.noinstall.TabStop = true;
            this.noinstall.Text = "No Installation";
            this.noinstall.UseVisualStyleBackColor = true;
            this.noinstall.CheckedChanged += new System.EventHandler(this.noinstall_CheckedChanged);
            // 
            // install_Date
            // 
            this.install_Date.Location = new System.Drawing.Point(368, 124);
            this.install_Date.Margin = new System.Windows.Forms.Padding(2);
            this.install_Date.Name = "install_Date";
            this.install_Date.Size = new System.Drawing.Size(151, 20);
            this.install_Date.TabIndex = 6;
            this.install_Date.Visible = false;
            this.install_Date.ValueChanged += new System.EventHandler(this.install_Date_ValueChanged);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(56, 291);
            this.Process.Margin = new System.Windows.Forms.Padding(2);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(91, 32);
            this.Process.TabIndex = 7;
            this.Process.Text = "Process Sale";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "square feet";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(221, 291);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(90, 32);
            this.Report.TabIndex = 11;
            this.Report.Text = "Sales Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(414, 291);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(165, 32);
            this.Display.TabIndex = 12;
            this.Display.Text = "Display Installation Orders";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(368, 161);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(459, 108);
            this.Results.TabIndex = 13;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.install_Date);
            this.Controls.Add(this.noinstall);
            this.Controls.Add(this.install);
            this.Controls.Add(this.flooringBox);
            this.Controls.Add(this.sfText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Flooring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox sfText;
        private System.Windows.Forms.ListBox flooringBox;
        private System.Windows.Forms.RadioButton install;
        private System.Windows.Forms.RadioButton noinstall;
        private System.Windows.Forms.DateTimePicker install_Date;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.ListBox Results;
    }
}

