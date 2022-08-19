using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonu
{
    public partial class Form6 : Form
    {
        int sepet_tut = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sepet_tut=sepet_tut+2;
            label1.Text = sepet_tut.ToString()+" TL";
            listBox1.Items.Add("Su");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sepet_tut = sepet_tut + 10; 
            label1.Text = sepet_tut.ToString()+" TL";
            listBox1.Items.Add("Vitamin Bar");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sepet_tut = sepet_tut + 7;
            label1.Text = sepet_tut.ToString()+" TL";
            listBox1.Items.Add("Enerji İçeceği");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sepet_tut = sepet_tut + 20;
            label1.Text = sepet_tut.ToString() +" TL";
            listBox1.Items.Add("Protein Tozu");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("---İşlem Sonu---");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            sepet_tut = sepet_tut + Convert.ToInt32(textBox2.Text);
            label1.Text = sepet_tut.ToString() + " TL";
            listBox1.Items.Add(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
