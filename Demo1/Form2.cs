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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            String Name=textName.Text;
            String EmailId = textEmail .Text;
            String Address=textAddress .Text;
            String ContactNo = textContact.Text;
            int Contact = Convert.ToInt32(ContactNo);
            Display.Text= Name +  EmailId +  Address +  ContactNo;
            

        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textAddress.Clear();
            textEmail.Clear();
            textContact.Clear();
        }
    }
}
