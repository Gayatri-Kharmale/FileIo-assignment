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
    public partial class Form5 : Form
    {
        FileStream fs;
        
        public Form5()
        {
            InitializeComponent();
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\TestFolder1";
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
                string path = @"F:\TestFolder1\First File1.txt";
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



        private void btnwritefile_Click(object sender, EventArgs e)
        {
            try
            {

                int Rollno = Convert.ToInt32(textrollno.Text);
                string Name = textname.Text;
                int Precentage = Convert.ToInt32(textPercenteges.Text);
                string City = textcity.Text;
                fs = new FileStream(@"F:\TestFolder1\FirstFile1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Rollno);
                bw.Write(Name);
                bw.Write(Precentage);

                bw.Write(City);
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

        private void btnreadform_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\TestFolder1\FirstFile1.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textrollno.Text = br.ReadInt32().ToString();
                textname.Text = br.ReadString();
                textPercenteges.Text = br.ReadInt32().ToString();
                textcity.Text = br.ReadString();
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
