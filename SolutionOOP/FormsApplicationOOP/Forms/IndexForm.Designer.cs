namespace FormsApplicationOOP
{
    partial class IndexForm
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
            this.customersIndex = new System.Windows.Forms.Button();
            this.employeesIndex = new System.Windows.Forms.Button();
            this.managersIndex = new System.Windows.Forms.Button();
            this.programmersIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customersIndex
            // 
            this.customersIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customersIndex.Location = new System.Drawing.Point(12, 12);
            this.customersIndex.Name = "customersIndex";
            this.customersIndex.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.customersIndex.Size = new System.Drawing.Size(109, 34);
            this.customersIndex.TabIndex = 0;
            this.customersIndex.Text = "Customers";
            this.customersIndex.UseVisualStyleBackColor = true;
            this.customersIndex.Click += new System.EventHandler(this.customersIndex_Click);
            // 
            // employeesIndex
            // 
            this.employeesIndex.Location = new System.Drawing.Point(12, 52);
            this.employeesIndex.Name = "employeesIndex";
            this.employeesIndex.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.employeesIndex.Size = new System.Drawing.Size(109, 34);
            this.employeesIndex.TabIndex = 1;
            this.employeesIndex.Text = "Employees";
            this.employeesIndex.UseVisualStyleBackColor = true;
            this.employeesIndex.Click += new System.EventHandler(this.employeesIndex_Click);
            // 
            // managersIndex
            // 
            this.managersIndex.Location = new System.Drawing.Point(12, 92);
            this.managersIndex.Name = "managersIndex";
            this.managersIndex.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.managersIndex.Size = new System.Drawing.Size(109, 34);
            this.managersIndex.TabIndex = 2;
            this.managersIndex.Text = "Managers";
            this.managersIndex.UseVisualStyleBackColor = true;
            this.managersIndex.Click += new System.EventHandler(this.managersIndex_Click);
            // 
            // programmersIndex
            // 
            this.programmersIndex.Location = new System.Drawing.Point(12, 132);
            this.programmersIndex.Name = "programmersIndex";
            this.programmersIndex.Padding = new System.Windows.Forms.Padding(12, 5, 12, 5);
            this.programmersIndex.Size = new System.Drawing.Size(109, 34);
            this.programmersIndex.TabIndex = 3;
            this.programmersIndex.Text = "Programmers";
            this.programmersIndex.UseVisualStyleBackColor = true;
            this.programmersIndex.Click += new System.EventHandler(this.programmersIndex_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(134, 180);
            this.Controls.Add(this.programmersIndex);
            this.Controls.Add(this.managersIndex);
            this.Controls.Add(this.employeesIndex);
            this.Controls.Add(this.customersIndex);
            this.Name = "IndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customersIndex;
        private System.Windows.Forms.Button employeesIndex;
        private System.Windows.Forms.Button managersIndex;
        private System.Windows.Forms.Button programmersIndex;
    }
}

