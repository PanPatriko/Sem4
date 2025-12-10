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

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba os = new Osoba(textBoxImie.Text, Convert.ToDateTime(maskedTextBoxData.Text), float.Parse(textBoxWaga.Text), char.Parse(textBoxPlec.Text));
                listBox1.Items.Add(os);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Niepoprawne dane");
            }
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileStream f = new FileStream(saveFileDialog1.FileName,FileMode.Create);
            using (BinaryWriter bw = new BinaryWriter(f))
            {
                bw.Write(listBox1.Items.Count);
                foreach(Osoba zapisz in listBox1.Items)
                {
                    bw.Write(zapisz.Imie);
                    bw.Write(zapisz.Data.ToBinary());
                    bw.Write(zapisz.Waga);
                    bw.Write(zapisz.Plec);
                }
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                FileStream f = new FileStream(openFileDialog1.FileName, FileMode.Open);
                using (BinaryReader br = new BinaryReader(f))
                {
                    int count = br.ReadInt32();
                    for(int y=0;y<count;y++)
                    {
                        Osoba wczytaj = new Osoba();
                        wczytaj.Imie = br.ReadString();
                        wczytaj.Data = DateTime.FromBinary(br.ReadInt64());
                        wczytaj.Waga = br.ReadDouble();
                        wczytaj.Plec = (char)br.ReadByte();
                        listBox1.Items.Add(wczytaj);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Prawie zepsułeś program");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                Osoba zapisz = (Osoba)listBox1.SelectedItem;
                textBoxImie.Text = zapisz.Imie;
                textBoxPlec.Text = zapisz.Plec.ToString();
                textBoxWaga.Text = zapisz.Waga.ToString();
                maskedTextBoxData.Text = zapisz.Data.ToString();
            }

        }


    }
}
