using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Stream s;
        RijndaelManaged Crypto = new RijndaelManaged();
        byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        private void buttonPrzeg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void buttonOtw_Click(object sender, EventArgs e)
        {
            try
            {
                using (s = new FileStream(textBoxSciezka.Text, FileMode.Open))
                {                 
                        if (checkBoxSzyfr.Checked == true)
                        {

                            s = new CryptoStream(s, Crypto.CreateDecryptor(Key, IV), CryptoStreamMode.Read);                                                                              
                        }
                        if (checkBoxKompresja.Checked == true)
                        {
                            s = new GZipStream(s, CompressionMode.Decompress);
                        }
                        StreamReader sr = new StreamReader(s);
                        textBoxNotepad.Text = sr.ReadToEnd();
                        sr.Close();                
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Niepoprawna ścieżka");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Pusta ścieżka");
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Taki plik nie istnieje");
            }
            catch (InvalidDataException)
            {
                MessageBox.Show("Ten plik nie jest skompresowany");
            }
          catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Ten plik nie jest zaszyfrowany");
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                using (s = new FileStream(textBoxSciezka.Text, FileMode.Create))
                {
                    if (checkBoxKompresja.Checked == true)
                    {
                        s = new GZipStream(s, CompressionMode.Compress);
                    }
                    if (checkBoxSzyfr.Checked == true)
                        {
                            s = new CryptoStream(s, Crypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write);
                        }

                        StreamWriter sw = new StreamWriter(s);
                        sw.Write(textBoxNotepad.Text);
                        sw.Close();
                }

            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("Pusta ścieżka");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Niepoprawna ścieżka");
            }
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxSciezka.Text = openFileDialog1.FileName;
        }

    }
}
