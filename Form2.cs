using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabaniProje
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UrunEkle().Show();
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TedarikçiTeslim().Show();
        }

        private void btnTeslimatolustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Teslimat().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Personel().Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}


