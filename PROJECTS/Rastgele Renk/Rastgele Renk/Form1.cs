using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        Random random2 = new Random();
        int Random, Random2, RenkSirasi;
        int SoruSirası = 1;
        string[] RenkListesi = new string[] { "Red", "Yellow", "Blue", "Green", "Black","Maroon","Orange","Brown","White" ,"LawnGreen","Purple","DarkRed","LightBlue"};
        string[] RenkListesiTurkçe = new string[] { "Kırmızı", "Sarı", "Mavi", "Gri", "Siyah","Bordo","Turuncu","KahveRengi","Beyaz","Çim Yeşili", "Mor","Koyu Kırmızı","Açık Mavi"};

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.BackColor.Name==RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, doğru cevap.");
                if(SoruSirası <=13)
                {
                    SoruSirası++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm soruları cevapladın.");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm, soruları yanlış hesapladın");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, doğru cevap.");
                if (SoruSirası <= 13)
                {
                    SoruSirası++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm soruları cevapladın.");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm, soruları yanlış hesapladın");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, doğru cevap.");
                if (SoruSirası <= 13)
                {
                    SoruSirası++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm soruları cevapladın.");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm, soruları yanlış hesapladın");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor.Name == RenkListesi[RenkSirasi])
            {
                MessageBox.Show("Tebrikler, doğru cevap.");
                if (SoruSirası <= 13)
                {
                    SoruSirası++;
                    RenkCek();
                }
                else
                {
                    MessageBox.Show("Tüm soruları cevapladın.");
                }
            }
            else
            {
                MessageBox.Show("Üzgünüm, soruları yanlış hesapladın");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RenkCek();
        }
        public void RenkCek()
        {
            Random2 = random2.Next(0, 4);
            for (int i = 0; i < 4; i++)
            {
                Random = random.Next(0, 13);
                switch (i)
                {
                    case 0:
                        button1.BackColor = Color.FromName(RenkListesi[Random].ToString());
                        if(Random2 == 0)
                        {
                            label1.Text = "Aşağıdaki Renklerden Hangisi" + RenkListesiTurkçe[Random] + " ?";
                            RenkSirasi = Random;
                        }
                        break;
                    case 1:
                        button2.BackColor = Color.FromName(RenkListesi[Random].ToString());
                        if (Random2 == 1)
                        {
                            label1.Text = "Aşağıdaki Renklerden Hangisi" + RenkListesiTurkçe[Random] + " ?";
                            RenkSirasi = Random;
                        }
                        break;
                    case 2:
                        button3.BackColor = Color.FromName(RenkListesi[Random].ToString());
                        if (Random2 == 2)
                        {
                            label1.Text = "Aşağıdaki Renklerden Hangisi" + RenkListesiTurkçe[Random] + " ?";
                            RenkSirasi = Random;
                        }
                        break;
                    case 3:
                        button4.BackColor = Color.FromName(RenkListesi[Random].ToString());
                        if (Random2 == 3)
                        {
                            label1.Text = "Aşağıdaki Renklerden Hangisi" + RenkListesiTurkçe[Random] + " ?";
                            RenkSirasi = Random;
                        }
                        break;
                }

            }
        }
    }
}
