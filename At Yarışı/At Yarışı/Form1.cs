using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Horse1LefttWay, Horse2LefttWay,Horse3LeftWay; // atların soldan uzaklıkları için

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Horse1Width = pictureBox1.Width; // genişliği atın , ilerlemesi yani 
            int Horse2Width = pictureBox2.Width;
            int Horse3Width = pictureBox3.Width;

            int FinishWay = label5.Left;
            

            pictureBox1.Left = pictureBox1.Left + random.Next(5, 15); // atların hareketleri verildi
            pictureBox2.Left = pictureBox2.Left + random.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + random.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left && pictureBox1.Left>pictureBox3.Left) // hangi at önde götürüyo onun bilgisini kontrol ediyoz
            {
                label6.Text = "ŞAHBATUR horse is running ahead.";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left) // hangi at önde götürüyo onun bilgisini kontrol ediyoz
            {
                label6.Text = "SARI TUTKU horse is running ahead.";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left) // hangi at önde götürüyo onun bilgisini kontrol ediyoz
            {
                label6.Text = "BEYAZ SARAY horse is running ahead.";
            }

            if (Horse1Width+pictureBox1.Left >=FinishWay) // sırayla atların hangisi 1. olcak onu kontrol ediyoz
            {
                timer1.Enabled=false;
                MessageBox.Show("The winner of the race is the name ŞAHBATUR.");
            }
            if (Horse2Width + pictureBox2.Left >= FinishWay)
            {
                timer1.Enabled = false;
                MessageBox.Show("The winner of the race is the name SARI TUTKU.");
            }
            if (Horse3Width + pictureBox3.Left >= FinishWay)
            {
                timer1.Enabled = false;
                MessageBox.Show("The winner of the race is the name BEYAZ SARAY.");
            }
        }

        Random random =new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            Horse1LefttWay = pictureBox1.Left;
            Horse2LefttWay = pictureBox2.Left;
            Horse3LeftWay = pictureBox3.Left;
        }
    }
}
