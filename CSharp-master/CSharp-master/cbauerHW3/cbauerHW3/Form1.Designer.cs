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
            this.Process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.ListBox();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.salesDB1 = new WindowsFormsApplication5.SalesDB();
            this.SalesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sale ID:";
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
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(221, 291);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(90, 32);
            this.Update_Button.TabIndex = 11;
            this.Update_Button.Text = "Update Sale Order";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(355, 291);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(118, 32);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Delete Sale Order";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(368, 54);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(459, 108);
            this.Results.TabIndex = 13;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // ReportBtn
            // 
            this.ReportBtn.Location = new System.Drawing.Point(550, 291);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(115, 31);
            this.ReportBtn.TabIndex = 14;
            this.ReportBtn.Text = "Sales Report";
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // salesDB1
            // 
            this.salesDB1.DataSetName = "SalesDB";
            this.salesDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesGrid
            // 
            this.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGrid.Location = new System.Drawing.Point(368, 168);
            this.SalesGrid.Name = "SalesGrid";
            this.SalesGrid.Size = new System.Drawing.Size(459, 106);
            this.SalesGrid.TabIndex = 15;
            this.SalesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.SalesGrid);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Process);
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
            ((System.ComponentModel.ISupportInitialize)(this.salesDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).EndInit();
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
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button ReportBtn;
        private SalesDB salesDB1;
        private System.Windows.Forms.DataGridView SalesGrid;
    }
}

