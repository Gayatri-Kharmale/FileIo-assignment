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
    public partial class Form7 : Form
    {
        FileStream fs;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnfolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\Product";
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
                string path = @"F:\Product\FirstFile2.txt";
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

        private void btnwritep_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textid.Text);
                string Name = textname.Text;
                int Price = Convert.ToInt32(textprice.Text);

                string Category = textcategory.Text;
                fs = new FileStream(@"F:\Product\FirstFile2.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(Price);
                bw.Write(Category);
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

        private void btnreadp_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\Product\FirstFile2.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textid.Text = br.ReadInt32().ToString();
                textname.Text = br.ReadString();
                textprice.Text = br.ReadInt32().ToString();
                textcategory.Text = br.ReadString();

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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void btnwriteb_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(textid.Text);
                prod.Name = textname.Text;
                prod.Price= Convert.ToInt32(textprice.Text);
                prod.Category = textcategory.Text;
                fs = new FileStream(@"F:\Product\Prod", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
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
                Product prod = new Product();
                fs = new FileStream(@"F:\Product\Prod",FileMode.Open,FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product)binary.Deserialize(fs);
                textid.Text = prod.Id.ToString();
                textname.Text = prod.Name;
                textprice.Text = prod.Price.ToString();
                textcategory.Text = prod.Category;
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

        private void btnwritex_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(textid.Text);
                prod.Name = textname.Text;
                prod.Price = Convert.ToInt32(textprice.Text);
                prod.Category = textcategory.Text;
                fs = new FileStream(@"F:\Product\Prod", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, prod);
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

        private void btnreadx_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"F:\Product\Prod",FileMode.Open,FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                textid.Text = prod.Id.ToString();
                textname.Text = prod.Name;
                textprice.Text = prod.Price.ToString();
                textcategory.Text = prod.Category;
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

        private void btnsoapw_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(textid.Text);
                prod.Name = textname.Text;
                prod.Price = Convert.ToInt32(textprice.Text);
                prod.Category = textcategory.Text;
                fs = new FileStream(@"F:\Product\Prod1", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, prod);
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

        private void btnsoapr_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"F:\Product\Prod1", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                prod = (Product)soap.Deserialize(fs);
                textid.Text = prod.Id.ToString();
                textname.Text = prod.Name;
                textprice.Text = prod.Price.ToString();
                textcategory.Text = prod.Category;
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

        private void btnjsonw_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(textid.Text);
                prod.Name = textname.Text;
                prod.Price = Convert.ToInt32(textprice.Text);
                prod.Category = textcategory.Text;
                fs = new FileStream(@"F:\Product\Prod1", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);
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

        private void btnjsonr_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();

                fs = new FileStream(@"F:\Product\Prod1", FileMode.Open, FileAccess.Read);
                prod = JsonSerializer.Deserialize<Product>(fs);
                textid.Text = prod.Id.ToString();
                textname.Text = prod.Name;
                textprice.Text = prod.Price.ToString();
                textcategory.Text = prod.Category;
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
    }
}
