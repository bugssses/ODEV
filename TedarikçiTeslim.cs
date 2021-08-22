using Npgsql;
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
    public partial class TedarikçiTeslim : Form
    {
        public TedarikçiTeslim()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432;  Database= odev;user ID=postgres ; password=Merve.35");
     
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();          
            string sql = null;

            sql = " select * from tedarikciekle(:firma,:sehir,:adres)";
            cmd = new NpgsqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("firma", txtFirma.Text.ToString());
            cmd.Parameters.AddWithValue("sehir", txtbxTedarikciSehir.Text.ToString());
            cmd.Parameters.AddWithValue("adres", txtBxTedarikciAdres.Text.ToString()); ;
           

            cmd.ExecuteNonQuery();
            txtFirma.Clear();
            txtbxTedarikciSehir.Clear();
            txtBxTedarikciAdres.Clear();
            baglan.Close();
        }

        private void btnTeslimNokEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string sql = null;

            sql = " select * from teslimatnoktaekle(:teslimYer,:sehir,:adres)";
            cmd = new NpgsqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("teslimYer",txtTeslimYer. Text.ToString());
            cmd.Parameters.AddWithValue("sehir", txtBxTeslimSehir.Text.ToString());
            cmd.Parameters.AddWithValue("adres", txtBxTeslimAdres.Text.ToString()); ;


            cmd.ExecuteNonQuery();
            txtTeslimYer.Clear();
            txtBxTeslimSehir.Clear();
            txtBxTeslimAdres.Clear();
            baglan.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"tedarikciler\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"teslimatNoktalari\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void TedarikçiTeslim_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
