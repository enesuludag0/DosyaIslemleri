using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DosyaIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void bttnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }

        private void bttnSaveFileDialog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        string belgeYolu, belgeAdi;

        private void bttnDosyaOlustur_Click(object sender, EventArgs e)
        {
            belgeAdi = txtBelgeAdi.Text;
            StreamWriter sw = File.CreateText(belgeYolu + "\\" + belgeAdi + ".txt");
            MessageBox.Show("Belgeniz başarıyla oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnOku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                listBox1.Items.Clear();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void bttnYazdir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyası |*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("Metin belgesine kayıt yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnKonumSec_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeYolu = folderBrowserDialog1.SelectedPath;
                txtBelgeYolu.Text = belgeYolu;
            }
        }
    }
}
