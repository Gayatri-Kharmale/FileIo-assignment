namespace Demo1
{
    partial class Form7
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
            this.textprice = new System.Windows.Forms.TextBox();
            this.textcategory = new System.Windows.Forms.TextBox();
            this.btnwritep = new System.Windows.Forms.Button();
            this.btnreadp = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.btnwriteb = new System.Windows.Forms.Button();
            this.btnreadb = new System.Windows.Forms.Button();
            this.btnwritex = new System.Windows.Forms.Button();
            this.btnreadx = new System.Windows.Forms.Button();
            this.btnsoapw = new System.Windows.Forms.Button();
            this.btnsoapr = new System.Windows.Forms.Button();
            this.btnjsonw = new System.Windows.Forms.Button();
            this.btnjsonr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(310, 44);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 4;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(310, 103);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 5;
            // 
            // textprice
            // 
            this.textprice.Location = new System.Drawing.Point(310, 161);
            this.textprice.Name = "textprice";
            this.textprice.Size = new System.Drawing.Size(100, 20);
            this.textprice.TabIndex = 6;
            // 
            // textcategory
            // 
            this.textcategory.Location = new System.Drawing.Point(310, 213);
            this.textcategory.Name = "textcategory";
            this.textcategory.Size = new System.Drawing.Size(100, 20);
            this.textcategory.TabIndex = 7;
            // 
            // btnwritep
            // 
            this.btnwritep.Location = new System.Drawing.Point(176, 283);
            this.btnwritep.Name = "btnwritep";
            this.btnwritep.Size = new System.Drawing.Size(75, 23);
            this.btnwritep.TabIndex = 8;
            this.btnwritep.Text = "Write";
            this.btnwritep.UseVisualStyleBackColor = true;
            this.btnwritep.Click += new System.EventHandler(this.btnwritep_Click);
            // 
            // btnreadp
            // 
            this.btnreadp.Location = new System.Drawing.Point(289, 283);
            this.btnreadp.Name = "btnreadp";
            this.btnreadp.Size = new System.Drawing.Size(75, 23);
            this.btnreadp.TabIndex = 9;
            this.btnreadp.Text = "Read";
            this.btnreadp.UseVisualStyleBackColor = true;
            this.btnreadp.Click += new System.EventHandler(this.btnreadp_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(176, 352);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(90, 23);
            this.btnfolder.TabIndex = 10;
            this.btnfolder.Text = "Create Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(289, 352);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(75, 23);
            this.btnfile.TabIndex = 11;
            this.btnfile.Text = "Create File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // btnwriteb
            // 
            this.btnwriteb.Location = new System.Drawing.Point(520, 51);
            this.btnwriteb.Name = "btnwriteb";
            this.btnwriteb.Size = new System.Drawing.Size(75, 23);
            this.btnwriteb.TabIndex = 12;
            this.btnwriteb.Text = "Binary Write";
            this.btnwriteb.UseVisualStyleBackColor = true;
            this.btnwriteb.Click += new System.EventHandler(this.btnwriteb_Click);
            // 
            // btnreadb
            // 
            this.btnreadb.Location = new System.Drawing.Point(647, 51);
            this.btnreadb.Name = "btnreadb";
            this.btnreadb.Size = new System.Drawing.Size(75, 23);
            this.btnreadb.TabIndex = 13;
            this.btnreadb.Text = "Binary Read";
            this.btnreadb.UseVisualStyleBackColor = true;
            this.btnreadb.Click += new System.EventHandler(this.btnreadb_Click);
            // 
            // btnwritex
            // 
            this.btnwritex.Location = new System.Drawing.Point(520, 106);
            this.btnwritex.Name = "btnwritex";
            this.btnwritex.Size = new System.Drawing.Size(75, 23);
            this.btnwritex.TabIndex = 14;
            this.btnwritex.Text = "Xml Write";
            this.btnwritex.UseVisualStyleBackColor = true;
            this.btnwritex.Click += new System.EventHandler(this.btnwritex_Click);
            // 
            // btnreadx
            // 
            this.btnreadx.Location = new System.Drawing.Point(655, 103);
            this.btnreadx.Name = "btnreadx";
            this.btnreadx.Size = new System.Drawing.Size(75, 23);
            this.btnreadx.TabIndex = 15;
            this.btnreadx.Text = "Xml Read";
            this.btnreadx.UseVisualStyleBackColor = true;
            this.btnreadx.Click += new System.EventHandler(this.btnreadx_Click);
            // 
            // btnsoapw
            // 
            this.btnsoapw.Location = new System.Drawing.Point(520, 161);
            this.btnsoapw.Name = "btnsoapw";
            this.btnsoapw.Size = new System.Drawing.Size(75, 23);
            this.btnsoapw.TabIndex = 16;
            this.btnsoapw.Text = "Soap Write";
            this.btnsoapw.UseVisualStyleBackColor = true;
            this.btnsoapw.Click += new System.EventHandler(this.btnsoapw_Click);
            // 
            // btnsoapr
            // 
            this.btnsoapr.Location = new System.Drawing.Point(655, 158);
            this.btnsoapr.Name = "btnsoapr";
            this.btnsoapr.Size = new System.Drawing.Size(75, 23);
            this.btnsoapr.TabIndex = 17;
            this.btnsoapr.Text = "Soap Read";
            this.btnsoapr.UseVisualStyleBackColor = true;
            this.btnsoapr.Click += new System.EventHandler(this.btnsoapr_Click);
            // 
            // btnjsonw
            // 
            this.btnjsonw.Location = new System.Drawing.Point(520, 224);
            this.btnjsonw.Name = "btnjsonw";
            this.btnjsonw.Size = new System.Drawing.Size(75, 23);
            this.btnjsonw.TabIndex = 18;
            this.btnjsonw.Text = "Json Write";
            this.btnjsonw.UseVisualStyleBackColor = true;
            this.btnjsonw.Click += new System.EventHandler(this.btnjsonw_Click);
            // 
            // btnjsonr
            // 
            this.btnjsonr.Location = new System.Drawing.Point(664, 224);
            this.btnjsonr.Name = "btnjsonr";
            this.btnjsonr.Size = new System.Drawing.Size(75, 23);
            this.btnjsonr.TabIndex = 19;
            this.btnjsonr.Text = "Json Read";
            this.btnjsonr.UseVisualStyleBackColor = true;
            this.btnjsonr.Click += new System.EventHandler(this.btnjsonr_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonr);
            this.Controls.Add(this.btnjsonw);
            this.Controls.Add(this.btnsoapr);
            this.Controls.Add(this.btnsoapw);
            this.Controls.Add(this.btnreadx);
            this.Controls.Add(this.btnwritex);
            this.Controls.Add(this.btnreadb);
            this.Controls.Add(this.btnwriteb);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnreadp);
            this.Controls.Add(this.btnwritep);
            this.Controls.Add(this.textcategory);
            this.Controls.Add(this.textprice);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form7_Load);
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
        private System.Windows.Forms.TextBox textprice;
        private System.Windows.Forms.TextBox textcategory;
        private System.Windows.Forms.Button btnwritep;
        private System.Windows.Forms.Button btnreadp;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.Button btnwriteb;
        private System.Windows.Forms.Button btnreadb;
        private System.Windows.Forms.Button btnwritex;
        private System.Windows.Forms.Button btnreadx;
        private System.Windows.Forms.Button btnsoapw;
        private System.Windows.Forms.Button btnsoapr;
        private System.Windows.Forms.Button btnjsonw;
        private System.Windows.Forms.Button btnjsonr;
    }
}