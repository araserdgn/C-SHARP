using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Info=new ProcessStartInfo("kişi.exe",textBox1.Text); // " " içine dosya ismini tanımladım, alandaki exeyi alıp DEBUG içine atınca ismini tırnak içindeki yap
            Process.Start(Info); 
        }
    }
}
