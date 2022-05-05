namespace Demo1
{
    partial class reg
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
            this.LName = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LContact = new System.Windows.Forms.Label();
            this.LAddress = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textContact = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(145, 41);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(106, 24);
            this.LName.TabIndex = 0;
            this.LName.Text = "Full Name";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(145, 88);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(85, 24);
            this.LEmail.TabIndex = 1;
            this.LEmail.Text = "Email Id";
            // 
            // LContact
            // 
            this.LContact.AutoSize = true;
            this.LContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContact.Location = new System.Drawing.Point(145, 145);
            this.LContact.Name = "LContact";
            this.LContact.Size = new System.Drawing.Size(113, 24);
            this.LContact.TabIndex = 2;
            this.LContact.Text = "Contact No";
            // 
            // LAddress
            // 
            this.LAddress.AutoSize = true;
            this.LAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddress.Location = new System.Drawing.Point(145, 206);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(87, 24);
            this.LAddress.TabIndex = 3;
            this.LAddress.Text = "Address";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(345, 46);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(362, 20);
            this.textName.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(345, 88);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(362, 20);
            this.textEmail.TabIndex = 5;
            this.textEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textContact
            // 
            this.textContact.Location = new System.Drawing.Point(345, 145);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(362, 20);
            this.textContact.TabIndex = 6;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(345, 206);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(362, 20);
            this.textAddress.TabIndex = 7;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(179, 292);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(94, 44);
            this.btnshow.TabIndex = 8;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(490, 292);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(109, 44);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(378, 412);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(0, 20);
            this.Display.TabIndex = 11;
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textContact);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.LContact);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LName);
            this.Name = "reg";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LContact;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Display;
    }
}