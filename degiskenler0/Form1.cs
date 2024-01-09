using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace degiskenler0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad, yas, meslek, cinsiyet;
            adsoyad = textBox1.Text;
            label5.Text = adsoyad;
            yas = maskedTextBox1.Text;
            label6.Text = yas;
            meslek = textBox2.Text;
            label7.Text = meslek;
            cinsiyet = textBox3.Text;
            label8.Text = cinsiyet;
            
            listBox1 .Items.Add(label5.Text + " " + label6.Text + " " + label7.Text + " " + label8.Text);
        }
    }
}
