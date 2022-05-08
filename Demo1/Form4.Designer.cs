namespace Demo1
{
    partial class Form4
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
            this.textId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnFolder = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.btnwrites = new System.Windows.Forms.Button();
            this.btnreads = new System.Windows.Forms.Button();
            this.btnwritex = new System.Windows.Forms.Button();
            this.btnreadx = new System.Windows.Forms.Button();
            this.btnwrites1 = new System.Windows.Forms.Button();
            this.btnreads2 = new System.Windows.Forms.Button();
            this.btnwritej = new System.Windows.Forms.Button();
            this.btnreadj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Location";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(280, 42);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(280, 97);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 4;
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(280, 158);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(100, 20);
            this.textLocation.TabIndex = 5;
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(203, 252);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(75, 23);
            this.BtnWrite.TabIndex = 6;
            this.BtnWrite.Text = "Write to File";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(334, 252);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 7;
            this.BtnRead.Text = "Read From File";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnFolder
            // 
            this.BtnFolder.Location = new System.Drawing.Point(203, 317);
            this.BtnFolder.Name = "BtnFolder";
            this.BtnFolder.Size = new System.Drawing.Size(87, 23);
            this.BtnFolder.TabIndex = 8;
            this.BtnFolder.Text = "Create Folder";
            this.BtnFolder.UseVisualStyleBackColor = true;
            this.BtnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.Location = new System.Drawing.Point(334, 317);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(75, 23);
            this.BtnFile.TabIndex = 9;
            this.BtnFile.Text = "Create File";
            this.BtnFile.UseVisualStyleBackColor = true;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // btnwrites
            // 
            this.btnwrites.Location = new System.Drawing.Point(563, 61);
            this.btnwrites.Name = "btnwrites";
            this.btnwrites.Size = new System.Drawing.Size(75, 23);
            this.btnwrites.TabIndex = 10;
            this.btnwrites.Text = "Binary Write";
            this.btnwrites.UseVisualStyleBackColor = true;
            this.btnwrites.Click += new System.EventHandler(this.btnwrites_Click);
            // 
            // btnreads
            // 
            this.btnreads.Location = new System.Drawing.Point(674, 61);
            this.btnreads.Name = "btnreads";
            this.btnreads.Size = new System.Drawing.Size(75, 23);
            this.btnreads.TabIndex = 11;
            this.btnreads.Text = "Binary Read";
            this.btnreads.UseVisualStyleBackColor = true;
            this.btnreads.Click += new System.EventHandler(this.btnreads_Click);
            // 
            // btnwritex
            // 
            this.btnwritex.Location = new System.Drawing.Point(563, 197);
            this.btnwritex.Name = "btnwritex";
            this.btnwritex.Size = new System.Drawing.Size(75, 23);
            this.btnwritex.TabIndex = 12;
            this.btnwritex.Text = "xml write";
            this.btnwritex.UseVisualStyleBackColor = true;
            this.btnwritex.Click += new System.EventHandler(this.btnwritex_Click_1);
            // 
            // btnreadx
            // 
            this.btnreadx.Location = new System.Drawing.Point(684, 197);
            this.btnreadx.Name = "btnreadx";
            this.btnreadx.Size = new System.Drawing.Size(75, 23);
            this.btnreadx.TabIndex = 13;
            this.btnreadx.Text = "xml read";
            this.btnreadx.UseVisualStyleBackColor = true;
            this.btnreadx.Click += new System.EventHandler(this.btnreadx_Click);
            // 
            // btnwrites1
            // 
            this.btnwrites1.Location = new System.Drawing.Point(563, 252);
            this.btnwrites1.Name = "btnwrites1";
            this.btnwrites1.Size = new System.Drawing.Size(75, 23);
            this.btnwrites1.TabIndex = 14;
            this.btnwrites1.Text = "soap write";
            this.btnwrites1.UseVisualStyleBackColor = true;
            this.btnwrites1.Click += new System.EventHandler(this.btnwrites1_Click);
            // 
            // btnreads2
            // 
            this.btnreads2.Location = new System.Drawing.Point(684, 261);
            this.btnreads2.Name = "btnreads2";
            this.btnreads2.Size = new System.Drawing.Size(75, 23);
            this.btnreads2.TabIndex = 15;
            this.btnreads2.Text = "soap  read";
            this.btnreads2.UseVisualStyleBackColor = true;
            this.btnreads2.Click += new System.EventHandler(this.btnreads2_Click);
            // 
            // btnwritej
            // 
            this.btnwritej.Location = new System.Drawing.Point(563, 300);
            this.btnwritej.Name = "btnwritej";
            this.btnwritej.Size = new System.Drawing.Size(75, 23);
            this.btnwritej.TabIndex = 16;
            this.btnwritej.Text = "json write";
            this.btnwritej.UseVisualStyleBackColor = true;
            this.btnwritej.Click += new System.EventHandler(this.btnwritej_Click);
            // 
            // btnreadj
            // 
            this.btnreadj.Location = new System.Drawing.Point(684, 300);
            this.btnreadj.Name = "btnreadj";
            this.btnreadj.Size = new System.Drawing.Size(75, 23);
            this.btnreadj.TabIndex = 17;
            this.btnreadj.Text = "json read";
            this.btnreadj.UseVisualStyleBackColor = true;
            this.btnreadj.Click += new System.EventHandler(this.btnreadj_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreadj);
            this.Controls.Add(this.btnwritej);
            this.Controls.Add(this.btnreads2);
            this.Controls.Add(this.btnwrites1);
            this.Controls.Add(this.btnreadx);
            this.Controls.Add(this.btnwritex);
            this.Controls.Add(this.btnreads);
            this.Controls.Add(this.btnwrites);
            this.Controls.Add(this.BtnFile);
            this.Controls.Add(this.BtnFolder);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnFolder;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button btnwrites;
        private System.Windows.Forms.Button btnreads;
        private System.Windows.Forms.Button btnwritex;
        private System.Windows.Forms.Button btnreadx;
        private System.Windows.Forms.Button btnwrites1;
        private System.Windows.Forms.Button btnreads2;
        private System.Windows.Forms.Button btnwritej;
        private System.Windows.Forms.Button btnreadj;
    }
}