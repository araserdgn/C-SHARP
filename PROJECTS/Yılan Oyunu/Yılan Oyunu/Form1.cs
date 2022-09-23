using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılan_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        YılanOyunu mySnack;
        PictureBox[] PbSnackParts;
        yonu yonum;
        bool YemKontrol=false;
        PictureBox PbYem;
        Random rastgele = new Random();
        int skor = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAgainGame.Enabled = false;
            TekrarOyna();
        }

        private void TekrarOyna()
        {
            yonum = new yonu(-10, 0);
            mySnack = new YılanOyunu();
            PbSnackParts = new PictureBox[0]; // yılan boyu 0
            for (int i = 0; i < 3; i++)
            {
                Array.Resize(ref PbSnackParts, PbSnackParts.Length + 1);
                PbSnackParts[i] = PbAdd();
            }
            
        btnAgainGame.Enabled = false;
        timer1.Start();
        }

        private PictureBox PbAdd()
        {
            
            PictureBox pb = new PictureBox();
            pb.Size = new Size(10, 10);
            pb.BackColor = Color.DarkBlue; // yılanın parça rengi beyaz
            pb.Location = mySnack.pozisyon(PbSnackParts.Length - 1); // yılan konumunu bulduk
            panel1.Controls.Add(pb);
            return pb;
        }
        private void Guncelle()
        {
            for (int i = 0; i < PbSnackParts.Length; i++)
            {
                PbSnackParts[i].Location = mySnack.pozisyon(i);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // yön tusları ile hareket
        {
            if(e.KeyCode == Keys.Up || e.KeyCode==Keys.W)
            {
                if (yonum.Direction_y != 10) // yılan aniden geri dönemeyecek onun kontrolu
                {
                    yonum = new yonu(0, -10);
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (yonum.Direction_y != -10)
                {
                    yonum = new yonu(0, 10);
                }
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (yonum.Direction_x != 10)
                {
                    yonum = new yonu(-10, 0);
               }
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
               if (yonum.Direction_x != -10)
                {
                    yonum = new yonu(10,-0);
                }
            }
        }
        public void Yem()
        {
            if(!YemKontrol) // yem var mı yok mu
            {
                
                PictureBox Pb = new PictureBox();
                Pb.BackColor = Color.Red;
                Pb.Size = new Size(10, 10); // 10 ar 10 ar pixellerle ilerleyecek düzgün görünüm için
                Pb.Location = new Point(rastgele.Next(panel1.Width/10)*10,rastgele.Next(panel1.Height/10)*10);
                PbYem = Pb;
                YemKontrol = true;
                panel1.Controls.Add(Pb);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSkor.Text="Skor: "+skor.ToString();
            mySnack.SnackGo(yonum);
            Guncelle();
            Yem();
            YemiYe();
            DuvaraCarptı();
        }
        public void YemiYe()
        {
            if(mySnack.pozisyon(0)==PbYem.Location)
            {
                skor += 10;
                mySnack.SnackSize();
                Array.Resize(ref PbSnackParts,PbSnackParts.Length+1);
                PbSnackParts[PbSnackParts.Length - 1] = PbAdd();
                YemKontrol = false;
                panel1.Controls.Remove(PbYem);

            }
        }
        public void DuvaraCarptı()
        {
            Point Pz = mySnack.pozisyon(0);
            if(Pz.X<0 || Pz.X > panel1.Width-10 || Pz.Y < 0 || Pz.Y > panel1.Width-20) // -10 dememizin sebebi yılan 10 10 eklendğ içn
            {
                
                timer1.Stop();
                MessageBox.Show("Oyun Bitti Kaybettiniz..");
                btnAgainGame.Enabled = true;
                panel1.Controls.Clear();
                

            }

        }

        private void btnAgainGame_Click(object sender, EventArgs e)
        {
            TekrarOyna();
           
        }
    }
}
