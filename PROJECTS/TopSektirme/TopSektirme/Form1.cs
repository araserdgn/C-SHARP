using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int topy = 1;
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sayi<=50)
            {
                top.Top += topy;
                if(top.Top>=140) {
                    topy *= -1;
                        }
                else if(top.Top<=100)
                {
                    topy *= -1;
                }

                if (top.Top==140)
                {
                    sayi++;

                   textBox2.Text =sayi.ToString();
                }

            }
            else
            {
                timer1.Stop();

                textBox2.Text=sayi.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox2.Text=(sayi.ToString()+" Kere Top Sekti.");
            MessageBox.Show("Şimdi Sonuçları Karşılaştırabilirsin.");
        }
    }
}
