namespace WindowsFormsApplication4
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
            this.process_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.reports_button = new System.Windows.Forms.Button();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.xsmall_radio = new System.Windows.Forms.RadioButton();
            this.small_radio = new System.Windows.Forms.RadioButton();
            this.medium_radio = new System.Windows.Forms.RadioButton();
            this.large_radio = new System.Windows.Forms.RadioButton();
            this.xlarge_radio = new System.Windows.Forms.RadioButton();
            this.ShirtlistBox = new System.Windows.Forms.ListBox();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.shirt_textBox = new System.Windows.Forms.TextBox();
            this.shirt_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // process_button
            // 
            this.process_button.Location = new System.Drawing.Point(144, 360);
            this.process_button.Margin = new System.Windows.Forms.Padding(2);
            this.process_button.Name = "process_button";
            this.process_button.Size = new System.Drawing.Size(81, 28);
            this.process_button.TabIndex = 0;
            this.process_button.Text = "process order";
            this.process_button.UseVisualStyleBackColor = true;
            this.process_button.Click += new System.EventHandler(this.process_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(296, 359);
            this.update_button.Margin = new System.Windows.Forms.Padding(2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(90, 28);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "update order";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // reports_button
            // 
            this.reports_button.Location = new System.Drawing.Point(485, 360);
            this.reports_button.Margin = new System.Windows.Forms.Padding(2);
            this.reports_button.Name = "reports_button";
            this.reports_button.Size = new System.Drawing.Size(76, 28);
            this.reports_button.TabIndex = 2;
            this.reports_button.Text = "view reports";
            this.reports_button.UseVisualStyleBackColor = true;
            this.reports_button.Click += new System.EventHandler(this.reports_button_Click);
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(55, 30);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(123, 20);
            this.id_textbox.TabIndex = 3;
        
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(262, 30);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(159, 20);
            this.name_textbox.TabIndex = 4;
       
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(497, 30);
            this.address_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(121, 20);
            this.address_textbox.TabIndex = 5;
     
            // 
            // xsmall_radio
            // 
            this.xsmall_radio.AutoSize = true;
            this.xsmall_radio.Location = new System.Drawing.Point(32, 123);
            this.xsmall_radio.Margin = new System.Windows.Forms.Padding(2);
            this.xsmall_radio.Name = "xsmall_radio";
            this.xsmall_radio.Size = new System.Drawing.Size(74, 17);
            this.xsmall_radio.TabIndex = 6;
            this.xsmall_radio.TabStop = true;
            this.xsmall_radio.Text = "extra small";
            this.xsmall_radio.UseVisualStyleBackColor = true;
            // 
            // small_radio
            // 
            this.small_radio.AutoSize = true;
            this.small_radio.Location = new System.Drawing.Point(152, 123);
            this.small_radio.Margin = new System.Windows.Forms.Padding(2);
            this.small_radio.Name = "small_radio";
            this.small_radio.Size = new System.Drawing.Size(48, 17);
            this.small_radio.TabIndex = 7;
            this.small_radio.TabStop = true;
            this.small_radio.Text = "small";
            this.small_radio.UseVisualStyleBackColor = true;
            // 
            // medium_radio
            // 
            this.medium_radio.AutoSize = true;
            this.medium_radio.Location = new System.Drawing.Point(253, 122);
            this.medium_radio.Margin = new System.Windows.Forms.Padding(2);
            this.medium_radio.Name = "medium_radio";
            this.medium_radio.Size = new System.Drawing.Size(61, 17);
            this.medium_radio.TabIndex = 8;
            this.medium_radio.TabStop = true;
            this.medium_radio.Text = "medium";
            this.medium_radio.UseVisualStyleBackColor = true;
            // 
            // large_radio
            // 
            this.large_radio.AutoSize = true;
            this.large_radio.Location = new System.Drawing.Point(375, 123);
            this.large_radio.Margin = new System.Windows.Forms.Padding(2);
            this.large_radio.Name = "large_radio";
            this.large_radio.Size = new System.Drawing.Size(48, 17);
            this.large_radio.TabIndex = 9;
            this.large_radio.TabStop = true;
            this.large_radio.Text = "large";
            this.large_radio.UseVisualStyleBackColor = true;
            // 
            // xlarge_radio
            // 
            this.xlarge_radio.AutoSize = true;
            this.xlarge_radio.Location = new System.Drawing.Point(478, 122);
            this.xlarge_radio.Margin = new System.Windows.Forms.Padding(2);
            this.xlarge_radio.Name = "xlarge_radio";
            this.xlarge_radio.Size = new System.Drawing.Size(74, 17);
            this.xlarge_radio.TabIndex = 10;
            this.xlarge_radio.TabStop = true;
            this.xlarge_radio.Text = "extra large";
            this.xlarge_radio.UseVisualStyleBackColor = true;
            // 
            // ShirtlistBox
            // 
            this.ShirtlistBox.FormattingEnabled = true;
            this.ShirtlistBox.Location = new System.Drawing.Point(24, 163);
            this.ShirtlistBox.Margin = new System.Windows.Forms.Padding(2);
            this.ShirtlistBox.Name = "ShirtlistBox";
            this.ShirtlistBox.Size = new System.Drawing.Size(594, 160);
            this.ShirtlistBox.TabIndex = 11;
    
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(22, 30);
            this.id_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 12;
            this.id_label.Text = "ID:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(208, 30);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(38, 13);
            this.name_label.TabIndex = 13;
            this.name_label.Text = "Name:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(445, 33);
            this.address_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(48, 13);
            this.address_label.TabIndex = 14;
            this.address_label.Text = "Address:";
            // 
            // shirt_textBox
            // 
            this.shirt_textBox.Location = new System.Drawing.Point(144, 78);
            this.shirt_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.shirt_textBox.Name = "shirt_textBox";
            this.shirt_textBox.Size = new System.Drawing.Size(102, 20);
            this.shirt_textBox.TabIndex = 15;
                  // 
            // shirt_label
            // 
            this.shirt_label.AutoSize = true;
            this.shirt_label.Location = new System.Drawing.Point(52, 82);
            this.shirt_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shirt_label.Name = "shirt_label";
            this.shirt_label.Size = new System.Drawing.Size(84, 13);
            this.shirt_label.TabIndex = 16;
            this.shirt_label.Text = "number of shirts:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 447);
            this.Controls.Add(this.shirt_label);
            this.Controls.Add(this.shirt_textBox);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.ShirtlistBox);
            this.Controls.Add(this.xlarge_radio);
            this.Controls.Add(this.large_radio);
            this.Controls.Add(this.medium_radio);
            this.Controls.Add(this.small_radio);
            this.Controls.Add(this.xsmall_radio);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.reports_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.process_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button process_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button reports_button;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.RadioButton xsmall_radio;
        private System.Windows.Forms.RadioButton small_radio;
        private System.Windows.Forms.RadioButton medium_radio;
        private System.Windows.Forms.RadioButton large_radio;
        private System.Windows.Forms.RadioButton xlarge_radio;
        private System.Windows.Forms.ListBox ShirtlistBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox shirt_textBox;
        private System.Windows.Forms.Label shirt_label;
    }
}

