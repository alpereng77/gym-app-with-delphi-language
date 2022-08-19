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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbDataAdapter veri_adapter;
        DataSet veri_seti;
        OleDbCommand veri_komutu;
        OleDbDataReader veri_oku;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {

                OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
                veri_komutu = new OleDbCommand();
                bag.Open();
                veri_komutu.Connection = bag;
                veri_komutu.CommandText = "Insert into giris(adi,sifre) values (" + "'" + textBox1.Text + "','" + textBox2.Text + "')";
                veri_komutu.ExecuteNonQuery();
                bag.Close();
                MessageBox.Show("Kayıt Başarılı");

            }
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Kullanıcı sözleşmesini onaylayınız.");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mevzuat.gov.tr/mevzuat?MevzuatNo=6698&MevzuatTur=1&MevzuatTertip=5");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
