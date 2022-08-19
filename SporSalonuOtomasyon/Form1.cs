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
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar1.Value = sayac;
            if (sayac == 5)

            {
                frm.Show();
                this.Hide();
                timer1.Stop();
               
            }
        }
    }
}
