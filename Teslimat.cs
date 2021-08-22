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
    public partial class Teslimat : Form
    {
        public Teslimat()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432;  Database= odev;user ID=postgres ; password=Merve.35");
        private void cmbxTeslimatNokta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Teslimat_Load(object sender, EventArgs e)
        {
            
            baglan.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"teslimatNoktalari\"", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbxTeslimatNokta.DisplayMember = "teslimYeri";
            cmbxTeslimatNokta.ValueMember = "noktaNo";
            cmbxTeslimatNokta.DataSource = dt;

            NpgsqlDataAdapter dat = new NpgsqlDataAdapter("select * from \"sevkiyatci\"", baglan);
            DataTable data = new DataTable();
            dat.Fill(data);
            cmbxSevkiyatci.DisplayMember = "personelNo";
            cmbxSevkiyatci.ValueMember = "personelNo";
            cmbxSevkiyatci.DataSource = data;
            baglan.Close();
        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        private void btnTeslimatUrunEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
    
            string sql = null;

            sql = " select * from hesaplasil(:urunID,:teslimNum)";
            cmd = new NpgsqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("urunID", int.Parse(txtBxUrunNo.Text));
            cmd.Parameters.AddWithValue("teslimNum", int.Parse(txtBxTeslimNum.Text));


            cmd.ExecuteNonQuery();

            //    //int result = (int)cmd.ExecuteScalar();
            baglan.Close();


           
        }

        private void btnTeslimatOlustur_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sql = null;

            sql = " select * from teslimatolustur(:teslimNumber,:personelNum,:noktaNum)";
            cmd = new NpgsqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("personelNum", cmbxSevkiyatci.SelectedValue);
            cmd.Parameters.AddWithValue("noktaNum", cmbxTeslimatNokta.SelectedValue);
            cmd.Parameters.AddWithValue("teslimNumber", int.Parse(txtBxTeslimNum.Text));


            cmd.ExecuteNonQuery();

            //    //int result = (int)cmd.ExecuteScalar();
            baglan.Close();
        }

        private void btnUrunGöster_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"urun\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void btnYeniTeslimat_Click(object sender, EventArgs e)
        {
            txtBxTeslimNum.Clear();
            txtBxUrunNo.Clear();
        }

        private void btnTeslimatGöster_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"teslimat\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
              new FormMainMenu().Show();
        }
    }
    }
    

