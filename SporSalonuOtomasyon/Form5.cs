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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

     
        OleDbDataAdapter veri_adapter;
        DataSet veri_seti;
        OleDbCommand veri_komutu;
        OleDbDataReader veri_oku;
        private void Form5_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
            veri_adapter = new OleDbDataAdapter("select* from üye", bag);
            veri_seti = new DataSet();
            bag.Open();
            veri_adapter.Fill(veri_seti, "üye");
            dataGridView1.DataSource = veri_seti.Tables["üye"];
            bag.Close();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
            veri_komutu = new OleDbCommand();
            bag.Open();
            veri_komutu.Connection = bag;
            veri_komutu.CommandText = "Insert into üye(ad_soyad,baslangiç,üye_cesidi,besin_prog,özel_koc,Kimlik) values (" + "'" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','"+textBox2.Text+"')";
            veri_komutu.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kayıt Başarılı");
            veri_listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        void veri_listele()
        {

            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
            veri_adapter = new OleDbDataAdapter("Select * from üye", bag);
            veri_seti = new DataSet();
            bag.Open();

            veri_adapter.Fill(veri_seti, "üye");
            dataGridView1.DataSource = veri_seti.Tables["üye"];
            bag.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
            veri_komutu = new OleDbCommand();
            bag.Open();
            veri_komutu.Connection = bag;

            veri_komutu.CommandText="Update üye Set ad_soyad='"+textBox1.Text+"',baslangiç='"+dateTimePicker1.Text+"',üye_cesidi='"+comboBox2.Text+"',besin_prog='"+textBox5.Text+"',özel_koc='"+comboBox1.Text+ "' where Kimlik='"+textBox2.Text+"'";

            veri_komutu.ExecuteNonQuery();
            bag.Close();
            veri_listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=veritabani.accdb");
            veri_komutu = new OleDbCommand();
            bag.Open();
            veri_komutu.Connection = bag;

            veri_komutu.CommandText = "Delete from üye where Kimlik='"+textBox2.Text+"'";

            veri_komutu.ExecuteNonQuery();
            bag.Close();
            veri_listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();
        }
    }
}
