using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SporSalonu
{
    public partial class Form2 : Form
    {
        Form3 frm2 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
            bag.Open();
            OleDbCommand giris = new OleDbCommand("select *from giris where adi=@adi and sifre=@sifre", bag);
            giris.Parameters.Add("adi", textBox1.Text);
            giris.Parameters.Add("sifre", textBox2.Text);
            OleDbDataReader oku = giris.ExecuteReader();

            if (oku.Read())
            {
                Form4 ac = new Form4();
                ac.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            bag.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
