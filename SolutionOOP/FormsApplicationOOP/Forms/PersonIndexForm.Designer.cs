namespace FormsApplicationOOP.Forms
{
    partial class PersonIndexForm
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
            this.goback = new System.Windows.Forms.LinkLabel();
            this.personsList = new System.Windows.Forms.ListView();
            this.personEditBtn = new System.Windows.Forms.Button();
            this.personRemoveBtn = new System.Windows.Forms.Button();
            this.personAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goback
            // 
            this.goback.AutoSize = true;
            this.goback.Location = new System.Drawing.Point(12, 236);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(41, 13);
            this.goback.TabIndex = 1;
            this.goback.TabStop = true;
            this.goback.Text = "< Back";
            this.goback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.goback_LinkClicked);
            // 
            // personsList
            // 
            this.personsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personsList.FullRowSelect = true;
            this.personsList.GridLines = true;
            this.personsList.Location = new System.Drawing.Point(12, 12);
            this.personsList.MultiSelect = false;
            this.personsList.Name = "personsList";
            this.personsList.Size = new System.Drawing.Size(452, 208);
            this.personsList.TabIndex = 2;
            this.personsList.UseCompatibleStateImageBehavior = false;
            this.personsList.View = System.Windows.Forms.View.List;
            this.personsList.SelectedIndexChanged += new System.EventHandler(this.personsList_SelectedIndexChanged);
            // 
            // personEditBtn
            // 
            this.personEditBtn.Enabled = false;
            this.personEditBtn.Location = new System.Drawing.Point(470, 12);
            this.personEditBtn.Name = "personEditBtn";
            this.personEditBtn.Size = new System.Drawing.Size(75, 23);
            this.personEditBtn.TabIndex = 3;
            this.personEditBtn.Text = "Edit";
            this.personEditBtn.UseVisualStyleBackColor = true;
            this.personEditBtn.Click += new System.EventHandler(this.personEditBtn_Click);
            // 
            // personRemoveBtn
            // 
            this.personRemoveBtn.Enabled = false;
            this.personRemoveBtn.Location = new System.Drawing.Point(470, 41);
            this.personRemoveBtn.Name = "personRemoveBtn";
            this.personRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.personRemoveBtn.TabIndex = 4;
            this.personRemoveBtn.Text = "Remove";
            this.personRemoveBtn.UseVisualStyleBackColor = true;
            this.personRemoveBtn.Click += new System.EventHandler(this.personRemoveBtn_Click);
            // 
            // personAddBtn
            // 
            this.personAddBtn.Location = new System.Drawing.Point(416, 226);
            this.personAddBtn.Name = "personAddBtn";
            this.personAddBtn.Size = new System.Drawing.Size(129, 23);
            this.personAddBtn.TabIndex = 5;
            this.personAddBtn.Text = "Add";
            this.personAddBtn.UseVisualStyleBackColor = true;
            this.personAddBtn.Click += new System.EventHandler(this.personAddBtn_Click);
            // 
            // PersonIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 261);
            this.Controls.Add(this.personAddBtn);
            this.Controls.Add(this.personRemoveBtn);
            this.Controls.Add(this.personEditBtn);
            this.Controls.Add(this.personsList);
            this.Controls.Add(this.goback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonIndexForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel goback;
        private System.Windows.Forms.ListView personsList;
        private System.Windows.Forms.Button personEditBtn;
        private System.Windows.Forms.Button personRemoveBtn;
        private System.Windows.Forms.Button personAddBtn;
    }
}