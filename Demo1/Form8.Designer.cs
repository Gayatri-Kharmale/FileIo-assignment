namespace Demo1
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textaname = new System.Windows.Forms.TextBox();
            this.textprice = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btnbinaryw = new System.Windows.Forms.Button();
            this.btnbinaryr = new System.Windows.Forms.Button();
            this.btnxmlw = new System.Windows.Forms.Button();
            this.btnxmlr = new System.Windows.Forms.Button();
            this.btnsoapw = new System.Windows.Forms.Button();
            this.btnsoapr = new System.Windows.Forms.Button();
            this.btnjsonw = new System.Windows.Forms.Button();
            this.btnjsonr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(210, 29);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 4;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(210, 68);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 5;
            // 
            // textaname
            // 
            this.textaname.Location = new System.Drawing.Point(210, 102);
            this.textaname.Name = "textaname";
            this.textaname.Size = new System.Drawing.Size(100, 20);
            this.textaname.TabIndex = 6;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(210, 142);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 7;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(144, 269);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 8;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(296, 269);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(144, 335);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(94, 23);
            this.btncreatefolder.TabIndex = 10;
            this.btncreatefolder.Text = "Create Folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(296, 335);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(75, 23);
            this.btncreatefile.TabIndex = 11;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btnbinaryw
            // 
            this.btnbinaryw.Location = new System.Drawing.Point(533, 65);
            this.btnbinaryw.Name = "btnbinaryw";
            this.btnbinaryw.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryw.TabIndex = 12;
            this.btnbinaryw.Text = "Binary Write";
            this.btnbinaryw.UseVisualStyleBackColor = true;
            this.btnbinaryw.Click += new System.EventHandler(this.btnbinaryw_Click);
            // 
            // btnbinaryr
            // 
            this.btnbinaryr.Location = new System.Drawing.Point(671, 61);
            this.btnbinaryr.Name = "btnbinaryr";
            this.btnbinaryr.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryr.TabIndex = 13;
            this.btnbinaryr.Text = "Binary Read";
            this.btnbinaryr.UseVisualStyleBackColor = true;
            this.btnbinaryr.Click += new System.EventHandler(this.btnbinaryr_Click);
            // 
            // btnxmlw
            // 
            this.btnxmlw.Location = new System.Drawing.Point(533, 135);
            this.btnxmlw.Name = "btnxmlw";
            this.btnxmlw.Size = new System.Drawing.Size(75, 23);
            this.btnxmlw.TabIndex = 14;
            this.btnxmlw.Text = "Xml Write";
            this.btnxmlw.UseVisualStyleBackColor = true;
            this.btnxmlw.Click += new System.EventHandler(this.btnxmlw_Click);
            // 
            // btnxmlr
            // 
            this.btnxmlr.Location = new System.Drawing.Point(671, 140);
            this.btnxmlr.Name = "btnxmlr";
            this.btnxmlr.Size = new System.Drawing.Size(75, 23);
            this.btnxmlr.TabIndex = 15;
            this.btnxmlr.Text = "Xml Read";
            this.btnxmlr.UseVisualStyleBackColor = true;
            this.btnxmlr.Click += new System.EventHandler(this.btnxmlr_Click);
            // 
            // btnsoapw
            // 
            this.btnsoapw.Location = new System.Drawing.Point(533, 197);
            this.btnsoapw.Name = "btnsoapw";
            this.btnsoapw.Size = new System.Drawing.Size(75, 23);
            this.btnsoapw.TabIndex = 16;
            this.btnsoapw.Text = "Soap Write";
            this.btnsoapw.UseVisualStyleBackColor = true;
            this.btnsoapw.Click += new System.EventHandler(this.btnsoapw_Click);
            // 
            // btnsoapr
            // 
            this.btnsoapr.Location = new System.Drawing.Point(671, 197);
            this.btnsoapr.Name = "btnsoapr";
            this.btnsoapr.Size = new System.Drawing.Size(75, 23);
            this.btnsoapr.TabIndex = 17;
            this.btnsoapr.Text = "Soap Read";
            this.btnsoapr.UseVisualStyleBackColor = true;
            this.btnsoapr.Click += new System.EventHandler(this.btnsoapr_Click);
            // 
            // btnjsonw
            // 
            this.btnjsonw.Location = new System.Drawing.Point(533, 278);
            this.btnjsonw.Name = "btnjsonw";
            this.btnjsonw.Size = new System.Drawing.Size(75, 23);
            this.btnjsonw.TabIndex = 18;
            this.btnjsonw.Text = "Json Write";
            this.btnjsonw.UseVisualStyleBackColor = true;
            this.btnjsonw.Click += new System.EventHandler(this.btnjsonw_Click);
            // 
            // btnjsonr
            // 
            this.btnjsonr.Location = new System.Drawing.Point(671, 278);
            this.btnjsonr.Name = "btnjsonr";
            this.btnjsonr.Size = new System.Drawing.Size(75, 23);
            this.btnjsonr.TabIndex = 19;
            this.btnjsonr.Text = "Json Read";
            this.btnjsonr.UseVisualStyleBackColor = true;
            this.btnjsonr.Click += new System.EventHandler(this.btnjsonr_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonr);
            this.Controls.Add(this.btnjsonw);
            this.Controls.Add(this.btnsoapr);
            this.Controls.Add(this.btnsoapw);
            this.Controls.Add(this.btnxmlr);
            this.Controls.Add(this.btnxmlw);
            this.Controls.Add(this.btnbinaryr);
            this.Controls.Add(this.btnbinaryw);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textaname);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textaname;
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btnbinaryw;
        private System.Windows.Forms.Button btnbinaryr;
        private System.Windows.Forms.Button btnxmlw;
        private System.Windows.Forms.Button btnxmlr;
        private System.Windows.Forms.Button btnsoapw;
        private System.Windows.Forms.Button btnsoapr;
        private System.Windows.Forms.Button btnjsonw;
        private System.Windows.Forms.Button btnjsonr;
    }
}