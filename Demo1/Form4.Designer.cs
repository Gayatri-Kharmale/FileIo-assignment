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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Dept Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Dept Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Location";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Text = "File IO";
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
    }
}