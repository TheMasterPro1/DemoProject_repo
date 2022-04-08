namespace SQLDataAccessDemo
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FirstNameInsLabel = new System.Windows.Forms.Label();
            this.LastNameInsLabel = new System.Windows.Forms.Label();
            this.emailAdressInsLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsLabel = new System.Windows.Forms.Label();
            this.FirstNameInsText = new System.Windows.Forms.TextBox();
            this.LastNameInsText = new System.Windows.Forms.TextBox();
            this.emailAdressInsText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDInsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.Location = new System.Drawing.Point(85, 161);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(263, 277);
            this.peopleFoundListBox.TabIndex = 0;
            this.peopleFoundListBox.SelectedIndexChanged += new System.EventHandler(this.peopleFoundListBox_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(224, 53);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(112, 20);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(135, 53);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name: ";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(157, 100);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(146, 39);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FirstNameInsLabel
            // 
            this.FirstNameInsLabel.AutoSize = true;
            this.FirstNameInsLabel.Location = new System.Drawing.Point(482, 74);
            this.FirstNameInsLabel.Name = "FirstNameInsLabel";
            this.FirstNameInsLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameInsLabel.TabIndex = 4;
            this.FirstNameInsLabel.Text = "First Name:";
            // 
            // LastNameInsLabel
            // 
            this.LastNameInsLabel.AutoSize = true;
            this.LastNameInsLabel.Location = new System.Drawing.Point(482, 103);
            this.LastNameInsLabel.Name = "LastNameInsLabel";
            this.LastNameInsLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameInsLabel.TabIndex = 5;
            this.LastNameInsLabel.Text = "Last Name:";
            this.LastNameInsLabel.Click += new System.EventHandler(this.LastNameInsLabel_Click);
            // 
            // emailAdressInsLabel
            // 
            this.emailAdressInsLabel.AutoSize = true;
            this.emailAdressInsLabel.Location = new System.Drawing.Point(482, 131);
            this.emailAdressInsLabel.Name = "emailAdressInsLabel";
            this.emailAdressInsLabel.Size = new System.Drawing.Size(69, 13);
            this.emailAdressInsLabel.TabIndex = 6;
            this.emailAdressInsLabel.Text = "Email adress:";
            // 
            // phoneNumberInsLabel
            // 
            this.phoneNumberInsLabel.AutoSize = true;
            this.phoneNumberInsLabel.Location = new System.Drawing.Point(477, 157);
            this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
            this.phoneNumberInsLabel.Size = new System.Drawing.Size(84, 13);
            this.phoneNumberInsLabel.TabIndex = 7;
            this.phoneNumberInsLabel.Text = "Phone Number: ";
            // 
            // FirstNameInsText
            // 
            this.FirstNameInsText.Location = new System.Drawing.Point(566, 71);
            this.FirstNameInsText.Name = "FirstNameInsText";
            this.FirstNameInsText.Size = new System.Drawing.Size(132, 20);
            this.FirstNameInsText.TabIndex = 8;
            // 
            // LastNameInsText
            // 
            this.LastNameInsText.Location = new System.Drawing.Point(566, 100);
            this.LastNameInsText.Name = "LastNameInsText";
            this.LastNameInsText.Size = new System.Drawing.Size(132, 20);
            this.LastNameInsText.TabIndex = 9;
            // 
            // emailAdressInsText
            // 
            this.emailAdressInsText.Location = new System.Drawing.Point(566, 128);
            this.emailAdressInsText.Name = "emailAdressInsText";
            this.emailAdressInsText.Size = new System.Drawing.Size(132, 20);
            this.emailAdressInsText.TabIndex = 10;
            // 
            // phoneNumberInsText
            // 
            this.phoneNumberInsText.Location = new System.Drawing.Point(566, 154);
            this.phoneNumberInsText.Name = "phoneNumberInsText";
            this.phoneNumberInsText.Size = new System.Drawing.Size(132, 20);
            this.phoneNumberInsText.TabIndex = 11;
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(528, 210);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(146, 39);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(498, 50);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 13);
            this.IDLabel.TabIndex = 13;
            this.IDLabel.Text = "ID: ";
            // 
            // IDInsText
            // 
            this.IDInsText.Location = new System.Drawing.Point(566, 47);
            this.IDInsText.Name = "IDInsText";
            this.IDInsText.Size = new System.Drawing.Size(131, 20);
            this.IDInsText.TabIndex = 14;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDInsText);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.phoneNumberInsText);
            this.Controls.Add(this.emailAdressInsText);
            this.Controls.Add(this.LastNameInsText);
            this.Controls.Add(this.FirstNameInsText);
            this.Controls.Add(this.phoneNumberInsLabel);
            this.Controls.Add(this.emailAdressInsLabel);
            this.Controls.Add(this.LastNameInsLabel);
            this.Controls.Add(this.FirstNameInsLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FirstNameInsLabel;
        private System.Windows.Forms.Label LastNameInsLabel;
        private System.Windows.Forms.Label emailAdressInsLabel;
        private System.Windows.Forms.Label phoneNumberInsLabel;
        private System.Windows.Forms.TextBox FirstNameInsText;
        private System.Windows.Forms.TextBox LastNameInsText;
        private System.Windows.Forms.TextBox emailAdressInsText;
        private System.Windows.Forms.TextBox phoneNumberInsText;
        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDInsText;
    }
}

