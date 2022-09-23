using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinema_salonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte sayac = 1;
            for (byte i = 1; i <=8; i++)
                for(byte j = 1; j <=10; j++)
                {
                    Button buton = new Button();
                    buton.Size = new Size(50,50);
                    buton.BackColor = Color.SpringGreen;
                    buton.Location = new Point(j*50+174, i*50+20);
                    buton.Text = Convert.ToString(sayac);
                    buton.Name = Convert.ToString(sayac);
                    this.Controls.Add(buton);
                    buton.Click += Buton_Click;
                    sayac++;
                }
            
            label2.Text = parametre.set();
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            if ( ((Button)sender).BackColor == Color.SpringGreen )
                ((Button)sender).BackColor = Color.Red;
            else
                ((Button)sender).BackColor = Color.SpringGreen;
        }
    }
}
