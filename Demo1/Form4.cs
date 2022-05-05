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
    
    public partial class Form4 : Form
    {
        FileStream fs;
        
        public Form4()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F\Test Folder";
                if(Directory.Exists(path))
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

        private void BtnFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F\Test Folder\First File.txt";
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

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textId.Text);
                string Name = textName.Text;
                string Location = textLocation.Text;
                fs = new FileStream(@"F:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(Location);
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

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
              BinaryReader br = new BinaryReader(fs);
               textId.Text = br.ReadInt32().ToString();
                textName.Text = br.ReadString();
                textLocation.Text = br.ReadString();
                br.Close();
            }
            catch(Exception ex)
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
