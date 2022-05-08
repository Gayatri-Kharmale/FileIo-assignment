using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Demo1
{
    public partial class Form8 : Form
    {
        FileStream fs;
        public Form8()
        {
            InitializeComponent();
        }

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"F:\Book";
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
                string path = @"F:\Book\FirstFile3.txt";
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
                string Aname=textaname.Text;
                int Price = Convert.ToInt32(textprice.Text);

                fs = new FileStream(@"F:\Book\FirstFile3.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Id);
                bw.Write(Name);
                bw.Write(Aname);
                bw.Write(Price);
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
                FileStream fs = new FileStream(@"F:\Book\FirstFile3.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textid.Text = br.ReadInt32().ToString();
                textname.Text = br.ReadString();
                textaname.Text = br.ReadString();
                textprice.Text = br.ReadInt32().ToString();
                

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

        private void btnbinaryw_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(textid.Text);
                book.Name = textname.Text;
                book.Aname = textaname.Text;
                book.Price = Convert.ToInt32(textprice.Text);
                fs = new FileStream(@"F:\Book\book", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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

        private void btnbinaryr_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"F:\Book\book", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book = (Book)binary.Deserialize(fs);
                textid.Text = book.Id.ToString();
                textname.Text = book.Name;
                textaname.Text = book.Aname;
                textprice.Text = book.Price.ToString();
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

        private void btnxmlw_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.Id = Convert.ToInt32(textid.Text);
                book.Name = textname.Text;
                book.Aname = textaname.Text;
                book.Price = Convert.ToInt32(textprice.Text);
                fs = new FileStream(@"F:\Book\Book1", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs, book);
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

        private void btnxmlr_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"F:\Book\Book1", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
              book = (Book)xml.Deserialize(fs);
                textid.Text = book.Id.ToString();
                textname.Text = book.Name;
                textaname.Text = book.Aname;
                textprice.Text = book.Price.ToString();
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
                Book book = new Book();
                book.Id = Convert.ToInt32(textid.Text);
                book.Name = textname.Text;
                book.Aname = textaname.Text;

                book.Price = Convert.ToInt32(textprice.Text);
                fs = new FileStream(@"F:\Book\Book2", FileMode.Create, FileAccess.Write);
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, book);
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
                Book book = new Book();
                fs = new FileStream(@"F:\Book\Book2", FileMode.Open, FileAccess.Read);
                SoapFormatter soap = new SoapFormatter();
                book = (Book)soap.Deserialize(fs);
                textid.Text =book.Id.ToString();
                textname.Text = book.Name;
                textaname.Text= book.Aname;
                textprice.Text = book.Price.ToString();
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
                Book book = new Book();
                book.Id = Convert.ToInt32(textid.Text);
                book.Name = textname.Text;
                book.Aname = textaname.Text;
                book.Price = Convert.ToInt32(textprice.Text);
                fs = new FileStream(@"F:\Book\Book2", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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
                Book book = new Book();

                fs = new FileStream(@"F:\Book\Book2", FileMode.Open, FileAccess.Read);
                book = JsonSerializer.Deserialize<Book>(fs);
                textid.Text = book.Id.ToString();
                textname.Text =book.Name;
                textaname.Text =book.Aname;
                textprice.Text = book.Price.ToString();
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
