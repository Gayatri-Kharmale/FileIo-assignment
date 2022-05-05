using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text =="admin "&& txtPass.Text =="adamin123")
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Success");
            }
        }

        private void LPassword_Click(object sender, EventArgs e)
        {

        }

        private void LName_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }
    }
}
