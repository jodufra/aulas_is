namespace FormsApplicationOOP.Forms
{
    partial class PersonDetailForm
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
            this.i_firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.i_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.l_address = new System.Windows.Forms.Label();
            this.i_address = new System.Windows.Forms.TextBox();
            this.i_lastname = new System.Windows.Forms.TextBox();
            this.i_salary = new System.Windows.Forms.MaskedTextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.l_allProgrammers = new System.Windows.Forms.ListBox();
            this.l_myProgrammers = new System.Windows.Forms.ListBox();
            this.b_add = new System.Windows.Forms.Button();
            this.b_remove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // i_firstname
            // 
            this.i_firstname.Location = new System.Drawing.Point(12, 29);
            this.i_firstname.Name = "i_firstname";
            this.i_firstname.Size = new System.Drawing.Size(333, 20);
            this.i_firstname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName";
            // 
            // i_birthdate
            // 
            this.i_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.i_birthdate.Location = new System.Drawing.Point(12, 79);
            this.i_birthdate.Name = "i_birthdate";
            this.i_birthdate.Size = new System.Drawing.Size(147, 20);
            this.i_birthdate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birthdate";
            // 
            // l_address
            // 
            this.l_address.AutoSize = true;
            this.l_address.Location = new System.Drawing.Point(12, 113);
            this.l_address.Name = "l_address";
            this.l_address.Size = new System.Drawing.Size(45, 13);
            this.l_address.TabIndex = 6;
            this.l_address.Text = "Address";
            // 
            // i_address
            // 
            this.i_address.Enabled = false;
            this.i_address.Location = new System.Drawing.Point(12, 129);
            this.i_address.Name = "i_address";
            this.i_address.Size = new System.Drawing.Size(671, 20);
            this.i_address.TabIndex = 7;
            // 
            // i_lastname
            // 
            this.i_lastname.Location = new System.Drawing.Point(351, 29);
            this.i_lastname.Name = "i_lastname";
            this.i_lastname.Size = new System.Drawing.Size(332, 20);
            this.i_lastname.TabIndex = 8;
            // 
            // i_salary
            // 
            this.i_salary.Enabled = false;
            this.i_salary.Location = new System.Drawing.Point(12, 179);
            this.i_salary.Mask = "00000.99";
            this.i_salary.Name = "i_salary";
            this.i_salary.Size = new System.Drawing.Size(147, 20);
            this.i_salary.TabIndex = 9;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(13, 163);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 10;
            this.Salary.Text = "Salary";
            // 
            // l_allProgrammers
            // 
            this.l_allProgrammers.Enabled = false;
            this.l_allProgrammers.FormattingEnabled = true;
            this.l_allProgrammers.Location = new System.Drawing.Point(15, 235);
            this.l_allProgrammers.Name = "l_allProgrammers";
            this.l_allProgrammers.Size = new System.Drawing.Size(315, 199);
            this.l_allProgrammers.TabIndex = 11;
            // 
            // l_myProgrammers
            // 
            this.l_myProgrammers.Enabled = false;
            this.l_myProgrammers.FormattingEnabled = true;
            this.l_myProgrammers.Location = new System.Drawing.Point(361, 235);
            this.l_myProgrammers.Name = "l_myProgrammers";
            this.l_myProgrammers.Size = new System.Drawing.Size(322, 199);
            this.l_myProgrammers.TabIndex = 12;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(336, 262);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(19, 23);
            this.b_add.TabIndex = 13;
            this.b_add.Text = ">";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_remove
            // 
            this.b_remove.Location = new System.Drawing.Point(336, 291);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(19, 23);
            this.b_remove.TabIndex = 14;
            this.b_remove.Text = "<";
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "All Programmers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "My Programmers";
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(608, 440);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 21);
            this.b_save.TabIndex = 17;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.AutoSize = true;
            this.b_cancel.Location = new System.Drawing.Point(562, 444);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(40, 13);
            this.b_cancel.TabIndex = 18;
            this.b_cancel.TabStop = true;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.b_cancel_LinkClicked);
            // 
            // PersonDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 473);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_remove);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.l_myProgrammers);
            this.Controls.Add(this.l_allProgrammers);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.i_salary);
            this.Controls.Add(this.i_lastname);
            this.Controls.Add(this.i_address);
            this.Controls.Add(this.l_address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.i_birthdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.i_firstname);
            this.Name = "PersonDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonDetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox i_firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker i_birthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_address;
        private System.Windows.Forms.TextBox i_address;
        private System.Windows.Forms.TextBox i_lastname;
        private System.Windows.Forms.MaskedTextBox i_salary;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.ListBox l_allProgrammers;
        private System.Windows.Forms.ListBox l_myProgrammers;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.LinkLabel b_cancel;
    }
}