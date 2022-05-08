using System;
using System.IO;
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
    public partial class Form6 : Form
    {
        FileStream fs;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\TestFolder2";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder already exits");

                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnfile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\TestFolder2\FirstFile2.txt2";
                if (File.Exists(path))
                {
                    MessageBox.Show("Folder already exits");

                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textid.Text);
                string Name = textname.Text;
                string Designation = textdesignation.Text;
                int Salary = Convert.ToInt32(textsalary.Text);
                string Dep = textdep.Text;
                fs = new FileStream(@"F:\TestFolder2\FirstFile2.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(Designation);
                bw.Write(Salary);
                bw.Write(Dep);
                bw.Close();
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\TestFolder2\FirstFile2.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textid.Text = br.ReadInt32().ToString();
                textname.Text = br.ReadString();
                textdesignation.Text = br.ReadString();
                textsalary.Text=br.ReadInt32().ToString();
                textdep.Text = br.ReadString();
                br.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
             finally
            {
                fs.Close();
            }
        }
    }
}
