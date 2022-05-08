namespace Demo1
{
    partial class Form5
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
            this.textrollno = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textPercenteges = new System.Windows.Forms.TextBox();
            this.textstream = new System.Windows.Forms.TextBox();
            this.textcity = new System.Windows.Forms.TextBox();
            this.btnwritefile = new System.Windows.Forms.Button();
            this.btnreadform = new System.Windows.Forms.Button();
            this.btnfolder = new System.Windows.Forms.Button();
            this.btnfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rollno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percenteges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stream";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // textrollno
            // 
            this.textrollno.Location = new System.Drawing.Point(373, 52);
            this.textrollno.Name = "textrollno";
            this.textrollno.Size = new System.Drawing.Size(100, 20);
            this.textrollno.TabIndex = 5;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(373, 109);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 6;
            // 
            // textPercenteges
            // 
            this.textPercenteges.Location = new System.Drawing.Point(373, 159);
            this.textPercenteges.Name = "textPercenteges";
            this.textPercenteges.Size = new System.Drawing.Size(100, 20);
            this.textPercenteges.TabIndex = 7;
            // 
            // textstream
            // 
            this.textstream.Location = new System.Drawing.Point(373, 207);
            this.textstream.Name = "textstream";
            this.textstream.Size = new System.Drawing.Size(100, 20);
            this.textstream.TabIndex = 8;
            // 
            // textcity
            // 
            this.textcity.Location = new System.Drawing.Point(373, 262);
            this.textcity.Name = "textcity";
            this.textcity.Size = new System.Drawing.Size(100, 20);
            this.textcity.TabIndex = 9;
            // 
            // btnwritefile
            // 
            this.btnwritefile.Location = new System.Drawing.Point(651, 59);
            this.btnwritefile.Name = "btnwritefile";
            this.btnwritefile.Size = new System.Drawing.Size(75, 23);
            this.btnwritefile.TabIndex = 10;
            this.btnwritefile.Text = "Write  to file";
            this.btnwritefile.UseVisualStyleBackColor = true;
            this.btnwritefile.Click += new System.EventHandler(this.btnwritefile_Click);
            // 
            // btnreadform
            // 
            this.btnreadform.Location = new System.Drawing.Point(651, 116);
            this.btnreadform.Name = "btnreadform";
            this.btnreadform.Size = new System.Drawing.Size(75, 23);
            this.btnreadform.TabIndex = 11;
            this.btnreadform.Text = "Read file";
            this.btnreadform.UseVisualStyleBackColor = true;
            this.btnreadform.Click += new System.EventHandler(this.btnreadform_Click);
            // 
            // btnfolder
            // 
            this.btnfolder.Location = new System.Drawing.Point(651, 186);
            this.btnfolder.Name = "btnfolder";
            this.btnfolder.Size = new System.Drawing.Size(94, 23);
            this.btnfolder.TabIndex = 12;
            this.btnfolder.Text = "Create Folder";
            this.btnfolder.UseVisualStyleBackColor = true;
            this.btnfolder.Click += new System.EventHandler(this.btnfolder_Click);
            // 
            // btnfile
            // 
            this.btnfile.Location = new System.Drawing.Point(651, 272);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(75, 23);
            this.btnfile.TabIndex = 13;
            this.btnfile.Text = "Create File";
            this.btnfile.UseVisualStyleBackColor = true;
            this.btnfile.Click += new System.EventHandler(this.btnfile_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.btnfolder);
            this.Controls.Add(this.btnreadform);
            this.Controls.Add(this.btnwritefile);
            this.Controls.Add(this.textcity);
            this.Controls.Add(this.textstream);
            this.Controls.Add(this.textPercenteges);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textrollno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "STUDENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textrollno;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textPercenteges;
        private System.Windows.Forms.TextBox textstream;
        private System.Windows.Forms.TextBox textcity;
        private System.Windows.Forms.Button btnwritefile;
        private System.Windows.Forms.Button btnreadform;
        private System.Windows.Forms.Button btnfolder;
        private System.Windows.Forms.Button btnfile;
    }
}