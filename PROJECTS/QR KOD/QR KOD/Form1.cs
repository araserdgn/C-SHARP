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
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace QR_KOD
{
    public partial class Form1 : Form
    {
        FilterInfoCollection wepcam; // pcde bütün KAMERALARA baglı yerleri tutan dizi
        VideoCaptureDevice cam; // bizim kullanacagımız kamera dizisi
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wepcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo dev in wepcam)
            {
                comboBox1.Items.Add(dev.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void cam_New(object sender,NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = ((Bitmap)eventArgs.Frame.Clone()); // BİTMAP kameradan gelen görüntü demek
                                                                   //Kameradan gelen gör. pictureBox atıyoruz
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(wepcam[comboBox1.SelectedIndex].MonikerString); // wepcam kameraları BOX içine at
            cam.NewFrame +=new NewFrameEventHandler(cam_New);

            cam.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true; // görüntü gürürse
            timer1.Start();   // basla
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barkod = new BarcodeReader(); // barkot sınıfını tnaımladık

            // picture box tarayacagız içi boş mu dolu mu

            if(pictureBox1.Image != null) // boş değilse yani görüntü varsa
            {
                Result res= barkod.Decode((Bitmap)pictureBox1.Image); // kameradaki görüntüyü oku
                try    // okunan kodu TEXTBOX göstermek için
                {
                    string dec = res.ToString().Trim(); // okuduk
                    if(dec !="") // okunan kod dogru ise
                    {
                        timer1.Stop();
                        textBox1.Text = dec;
                    }

                }
                catch(Exception ex) // kod yoksa aktar
                {

                }
                                                       
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)      //kamera içi boş değilse
                if (cam.IsRunning==true)// kamera çalıştır, okunan kod dogru ise kamera durduk.
                {
                    cam.Stop();
                } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 ekle = new Form2();
            ekle.Show();
            this.Hide();
        }


    }
}
