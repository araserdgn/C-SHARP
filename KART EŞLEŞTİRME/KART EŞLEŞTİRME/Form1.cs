using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KART_EŞLEŞTİRME
{
    public partial class Form1 : Form
    {
        enum Tiklamalar
        {
            ilktiklama,ikincitiklama
        }
        #region GenelDEgeiskenler
        Tiklamalar tiklama = Tiklamalar.ilktiklama;
        PictureBox oncekiResim;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        void ResimleriGizle ()
        {
            foreach (PictureBox x in panel1.Controls) x.Image = ImgList.Images[0];

        }
        void ResimleriGöster()
        {
            foreach (PictureBox x in panel1.Controls) x.Image = ImgList.Images[(int)x.Tag];

        }
        void ResimleriDoldur()
        {
            ArrayList Tagler = new ArrayList();
            for(int i =0; i<(ImgList.Images.Count-1)*2; i++)Tagler.Add((i%10)+1);
            //listBox1.Items.AddRange(Tagler.ToArray());
            foreach(PictureBox x in panel1.Controls)
            {
                int sanslı = new Random().Next(Tagler.Count);
                x.Tag = Tagler[sanslı];
                Tagler.RemoveAt(sanslı);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
           
            ResimleriGizle();

        }

        private void pbBox_Click(object sender, EventArgs e)
        {
            PictureBox simdikiResim= sender as PictureBox;
            simdikiResim.Image = ImgList.Images[(int)simdikiResim.Tag];
            switch(tiklama)
            {
                case Tiklamalar.ilktiklama:
                    oncekiResim = simdikiResim;
                    tiklama = Tiklamalar.ikincitiklama;
                    break;
                case Tiklamalar.ikincitiklama:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResimleriDoldur();
            ResimleriGöster();
        }
    }
}
