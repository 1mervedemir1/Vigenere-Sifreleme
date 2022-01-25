using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtAnahtarKelime.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAnahtarKelime.Text != "" && txtYaziSifre.Text != "")
            {
                Vigenere_Sifreleme vigenere = new Vigenere_Sifreleme(txtAnahtarKelime.Text, txtYaziSifre.Text);
                
                if (vigenere.Alfabetik_sorgu())
                {
                    txtSifrelenenYazi.Text = vigenere.Sifrele();
                }
                else
                {
                    MessageBox.Show("Yalnızca İngilizce kabul eder");
                }
            }
            else
            {
                MessageBox.Show(" kutuları boş bırakmayınız.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAnahtarKelime.Clear();
            txtYaziSifre.Clear();
            txtSifrelenenYazi.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtAnahtarKelime.Text != "" && txtYaziSifre.Text != "")
            {
                Vigenere_Sifreleme vigenere1 = new Vigenere_Sifreleme(txtAnahtarKelime.Text, txtSifrelenenYazi.Text);
                txtDesifreYazi.Text = vigenere1.DesifreEt();
            }
            else
            {
                MessageBox.Show(" kutuları boş bırakmayınız.");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtDesifreYazi.Clear();
        }
    }
}
