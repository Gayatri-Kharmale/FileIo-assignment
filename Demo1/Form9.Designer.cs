namespace Demo1
{
    partial class Form9
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textstartdate = new System.Windows.Forms.TextBox();
            this.textenddate = new System.Windows.Forms.TextBox();
            this.textlocation = new System.Windows.Forms.TextBox();
            this.texttname = new System.Windows.Forms.TextBox();
            this.btnwriteb = new System.Windows.Forms.Button();
            this.btnreadb = new System.Windows.Forms.Button();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TName";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(126, 23);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 6;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(126, 54);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 7;
            // 
            // textstartdate
            // 
            this.textstartdate.Location = new System.Drawing.Point(126, 85);
            this.textstartdate.Name = "textstartdate";
            this.textstartdate.Size = new System.Drawing.Size(100, 20);
            this.textstartdate.TabIndex = 8;
            // 
            // textenddate
            // 
            this.textenddate.Location = new System.Drawing.Point(126, 138);
            this.textenddate.Name = "textenddate";
            this.textenddate.Size = new System.Drawing.Size(100, 20);
            this.textenddate.TabIndex = 9;
            // 
            // textlocation
            // 
            this.textlocation.Location = new System.Drawing.Point(126, 192);
            this.textlocation.Name = "textlocation";
            this.textlocation.Size = new System.Drawing.Size(100, 20);
            this.textlocation.TabIndex = 10;
            // 
            // texttname
            // 
            this.texttname.Location = new System.Drawing.Point(126, 238);
            this.texttname.Name = "texttname";
            this.texttname.Size = new System.Drawing.Size(100, 20);
            this.texttname.TabIndex = 11;
            // 
            // btnwriteb
            // 
            this.btnwriteb.Location = new System.Drawing.Point(361, 117);
            this.btnwriteb.Name = "btnwriteb";
            this.btnwriteb.Size = new System.Drawing.Size(75, 23);
            this.btnwriteb.TabIndex = 12;
            this.btnwriteb.Text = "Write";
            this.btnwriteb.UseVisualStyleBackColor = true;
            this.btnwriteb.Click += new System.EventHandler(this.btnwriteb_Click);
            // 
            // btnreadb
            // 
            this.btnreadb.Location = new System.Drawing.Point(530, 117);
            this.btnreadb.Name = "btnreadb";
            this.btnreadb.Size = new System.Drawing.Size(75, 23);
            this.btnreadb.TabIndex = 13;
            this.btnreadb.Text = "Read";
            this.btnreadb.UseVisualStyleBackColor = true;
            this.btnreadb.Click += new System.EventHandler(this.btnreadb_Click);
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Location = new System.Drawing.Point(361, 182);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(103, 23);
            this.btncreatefolder.TabIndex = 14;
            this.btncreatefolder.Text = "Create Folder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btncreatefile
            // 
            this.btncreatefile.Location = new System.Drawing.Point(530, 182);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(75, 23);
            this.btncreatefile.TabIndex = 15;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = true;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.btnreadb);
            this.Controls.Add(this.btnwriteb);
            this.Controls.Add(this.texttname);
            this.Controls.Add(this.textlocation);
            this.Controls.Add(this.textenddate);
            this.Controls.Add(this.textstartdate);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Batch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textstartdate;
        private System.Windows.Forms.TextBox textenddate;
        private System.Windows.Forms.TextBox textlocation;
        private System.Windows.Forms.TextBox texttname;
        private System.Windows.Forms.Button btnwriteb;
        private System.Windows.Forms.Button btnreadb;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btncreatefile;
    }
}