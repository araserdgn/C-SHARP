using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucan_Top
{
    public partial class Form1 : Form
    {
        int yerX = 5, yerY = 5,can=3;

        private void Carpmaolayı()
        {
            // üst carpma 
            if (ball.Top <= üst.Bottom)
                yerY = yerY * -1; // burda top üste gelince ters yöne dogru gitsin der

            // cubuga çarpma
            if(ball.Top>= hareket.Top && ball.Left >=hareket.Left && ball.Right <=hareket.Right)
                yerY= yerY * -1;
            // sag tarafa çarpma
            if(ball.Right >= sağ.Left)
                yerX= yerX * -1;
            // sol tarafa çarpma
            else if (ball.Left <= sol.Right)
                yerX = yerX * -1;
        }
        
        private void YanmaOlayı(object sender,EventArgs e)
        {
            if(ball.Top >= sağ.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız kalan canınız >>" + can.ToString());
                    Form1_Load(sender, e);
                }
                else if(can==0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun bitti..", "", MessageBoxButtons.OK);
                    

                }

            }
            label4.Text=can.ToString();
        }

        private void TopBasa()
        {
            ball.Location = new Point(372,187); // yeni konumu
        }

            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            hareket.Left = e.X;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Carpmaolayı();
            YanmaOlayı(sender,e);
            ball.Location= new Point(ball.Location.X+yerX,ball.Location.Y+yerY);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TopBasa();
            timer1.Enabled = true;
        }
    }
}
