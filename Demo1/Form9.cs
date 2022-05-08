using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form9 : Form
    {
        FileStream fs;
        public Form9()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\Batch";
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

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\Batch\FirstFile4.txt";
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
        private void btnwriteb_Click(object sender, EventArgs e)
        {

            try
            {
                int Id = Convert.ToInt32(textid.Text);
                string Name = textname.Text;
                int StartDate = Convert.ToInt32(textstartdate.Text);
                int EndDate = Convert.ToInt32(textenddate.Text);
                string Location = textlocation.Text;


                string Tname = texttname.Text;

                fs = new FileStream(@"F:\Batch\FirstFile4.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(StartDate);
                bw.Write(EndDate);
                bw.Write(Location);
                bw.Write(Tname);

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
        private void btnreadb_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\Batch\FirstFile4.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textid.Text = br.ReadInt32().ToString();
                textname.Text = br.ReadString();
                textstartdate.Text = br.ReadInt32().ToString();

                textenddate.Text = br.ReadInt32().ToString();
                textlocation.Text = br.ReadString();

                texttname.Text = br.ReadString();


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
