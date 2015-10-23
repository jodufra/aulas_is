namespace XMLHandler
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
            this.btn_xml = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_xsd = new System.Windows.Forms.Button();
            this.btn_validate = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tb_xpath = new System.Windows.Forms.TextBox();
            this.tb_xpathresult = new System.Windows.Forms.RichTextBox();
            this.btnExecuteXPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_xml
            // 
            this.btn_xml.Location = new System.Drawing.Point(12, 12);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(75, 23);
            this.btn_xml.TabIndex = 0;
            this.btn_xml.Text = "XML";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "<none>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "<none>";
            // 
            // btn_xsd
            // 
            this.btn_xsd.Location = new System.Drawing.Point(12, 41);
            this.btn_xsd.Name = "btn_xsd";
            this.btn_xsd.Size = new System.Drawing.Size(75, 23);
            this.btn_xsd.TabIndex = 2;
            this.btn_xsd.Text = "XSD";
            this.btn_xsd.UseVisualStyleBackColor = true;
            this.btn_xsd.Click += new System.EventHandler(this.btn_xsd_Click);
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(502, 70);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(291, 23);
            this.btn_validate.TabIndex = 4;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 167);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tb_xpath
            // 
            this.tb_xpath.Location = new System.Drawing.Point(12, 312);
            this.tb_xpath.Name = "tb_xpath";
            this.tb_xpath.Size = new System.Drawing.Size(678, 20);
            this.tb_xpath.TabIndex = 7;
            // 
            // tb_xpathresult
            // 
            this.tb_xpathresult.Location = new System.Drawing.Point(12, 338);
            this.tb_xpathresult.Name = "tb_xpathresult";
            this.tb_xpathresult.Size = new System.Drawing.Size(781, 174);
            this.tb_xpathresult.TabIndex = 8;
            this.tb_xpathresult.Text = "";
            // 
            // btnExecuteXPath
            // 
            this.btnExecuteXPath.Location = new System.Drawing.Point(696, 309);
            this.btnExecuteXPath.Name = "btnExecuteXPath";
            this.btnExecuteXPath.Size = new System.Drawing.Size(97, 23);
            this.btnExecuteXPath.TabIndex = 9;
            this.btnExecuteXPath.Text = "Execute";
            this.btnExecuteXPath.UseVisualStyleBackColor = true;
            this.btnExecuteXPath.Click += new System.EventHandler(this.btnExecuteXPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 524);
            this.Controls.Add(this.btnExecuteXPath);
            this.Controls.Add(this.tb_xpathresult);
            this.Controls.Add(this.tb_xpath);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_xsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xml);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_xsd;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tb_xpath;
        private System.Windows.Forms.RichTextBox tb_xpathresult;
        private System.Windows.Forms.Button btnExecuteXPath;
    }
}

