using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text =("Tebrikler TOplam puanınız su an "+" "+Convert.ToString(i)+".");

            if(i<10)
            {
                i++;
            }
            else if(i>10)
            {
                label2.Text = "Oyun bitti Agaaa..";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            button1.Left = Convert.ToInt32(random.Next(Size.Width-button1.Size.Width));
            button1.Top= Convert.ToInt32(random.Next(Size.Height-(label2.Height+label3.Height)));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text+" "+"Beni yakala dostum";
        }
    }
}
