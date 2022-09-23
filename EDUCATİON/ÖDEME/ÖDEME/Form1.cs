using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelAD.Text = textBox1.Text;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelNO.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAY.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAY.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            labelCV.Text=maskedTextBox2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ay, yıl;

            for(ay=1;ay<13;ay++)
            {
                comboBox1.Items.Add(ay);
            }

            for(yıl=21;ay<31;yıl++)
            {
                comboBox2.Items.Add(yıl);
            }
        }
    }
}
