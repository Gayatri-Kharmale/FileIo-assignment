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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

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
                string path = @"F:\TestFolder";
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
                string path = @"F:\TestFolder\First File.txt";
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

        private void btnwrites_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(textId.Text);
                dept.Name = textName.Text;
                dept.Location = textLocation.Text;
                fs =new FileStream(@"F:\TestFolder\Dept",FileMode.Create, FileAccess.Write);
                BinaryFormatter binary=new BinaryFormatter();
                binary.Serialize(fs,dept);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close ();
            }
        }

        private void btnreads_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                fs = new FileStream(@"F:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept=(Department) binary.Deserialize(fs);
                textId.Text = dept.Id.ToString();
                textName.Text = dept.Name;
                textLocation.Text = dept.Location;
                MessageBox.Show("Done");
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

        

        private void btnreadx_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                fs = new FileStream(@"F:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                textId.Text = dept.Id.ToString();
                textName.Text = dept.Name;
                textLocation.Text = dept.Location;
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

        private void btnwritex_Click_1(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(textId.Text);
                dept.Name = textName.Text;
                dept.Location = textLocation.Text;
                fs = new FileStream(@"F:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
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

        private void btnwrites1_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(textId.Text);
                dept.Name = textName.Text;
                dept.Location = textLocation.Text;
                fs = new FileStream(@"F:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
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

        private void btnreads2_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                fs = new FileStream(@"F:\TestFolder\Dept1", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                dept = (Department)soap.Deserialize(fs);
                textId.Text = dept.Id.ToString();
                textName.Text = dept.Name;
                textLocation.Text = dept.Location;
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

        private void btnwritej_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(textId.Text);
                dept.Name = textName.Text;
                dept.Location = textLocation.Text;
                fs = new FileStream(@"F:\TestFolder\Dept1", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, dept);
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

        private void btnreadj_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                
               fs = new FileStream(@"F:\TestFolder\Dept1", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                textId.Text = dept.Id.ToString();
                textName.Text = dept.Name;
                textLocation.Text = dept.Location;

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
