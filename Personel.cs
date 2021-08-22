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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432;  Database= odev;user ID=postgres ; password=Merve.35");
        private void btnZamUygula_Click(object sender, EventArgs e)
        {
          baglan.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();


            string sql = null;

            sql = " select * from zamyap(:personel,:zamOrani)";
            cmd = new NpgsqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("personel", cmbBxPersonel.SelectedValue);
            cmd.Parameters.AddWithValue("zamOrani", int.Parse(txtBxZamOran.Text));


            cmd.ExecuteNonQuery();

            baglan.Close();
        }

        private void btnZamGecmisi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"zamKayit\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            
            baglan.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Calisanlar\"", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBxPersonel.DisplayMember = "adi";
            cmbBxPersonel.ValueMember = "personelNo";
            cmbBxPersonel.DataSource = dt;
      
           

            NpgsqlDataAdapter data = new NpgsqlDataAdapter("select * from \"urunKategori\"", baglan);
            DataTable dtt = new DataTable();
            data.Fill(dtt);
            cmbBxpersonelBölüm.DisplayMember = "personelKategori";
            cmbBxpersonelBölüm.ValueMember = "personelID";
            cmbBxpersonelBölüm.DataSource = dtt;
            baglan.Close();
        }

        private void btnPersonellerilistele_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"Calisanlar\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {

            //string sql = null;

            //sql = " select * from personelekle(:personelBolumID,:personelAdi,:soyadi,:bolumu,:maasi)";
            //cmd = new NpgsqlCommand(sql, baglan);
            //cmd.Parameters.AddWithValue("personelBolumID", cmbBxpersonelBölüm.SelectedValue);
            //cmd.Parameters.AddWithValue("personelAdi", txtBxPersonelAd.Text.ToString());
            //cmd.Parameters.AddWithValue("soyadi", txtBxPersonelSoyad.Text.ToString());
            //cmd.Parameters.AddWithValue("bolumu", cmbBxpersonelBölüm.Text.ToString());
            //cmd.Parameters.AddWithValue("maasi", int.Parse(txtBxPersonelMaas.Text));


            //cmd.ExecuteNonQuery();


            if ((int)cmbBxpersonelBölüm.SelectedValue == 1)
            {
                baglan.Open();              
                string sql = null;
               
                sql = " select * from depogorevlisi(:personelBolumID,:personelAdi,:soyadi,:bolumu,:maasi,:vard)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("personelBolumID", cmbBxpersonelBölüm.SelectedValue);
                cmd.Parameters.AddWithValue("personelAdi", txtBxPersonelAd.Text.ToString());
                cmd.Parameters.AddWithValue("soyadi", txtBxPersonelSoyad.Text.ToString());
                cmd.Parameters.AddWithValue("bolumu", cmbBxpersonelBölüm.Text.ToString());
                cmd.Parameters.AddWithValue("maasi", int.Parse(txtBxPersonelMaas.Text));
                cmd.Parameters.AddWithValue("vard", txtBxVardiya.Text.ToString());


                cmd.ExecuteNonQuery();


                txtBxPersonelAd.Clear();
                txtBxPersonelSoyad.Clear();
                txtBxPersonelMaas.Clear();
                txtBxVardiya.Clear();
        
                lblVardiya.Visible = false;
                txtBxVardiya.Visible = false;

                baglan.Close();
            }
            if ((int)cmbBxpersonelBölüm.SelectedValue == 2)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from sevkiyatci(:personelBolumID,:personelAdi,:soyadi,:bolumu,:maasi,:teslim)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("personelBolumID", cmbBxpersonelBölüm.SelectedValue);
                cmd.Parameters.AddWithValue("personelAdi", txtBxPersonelAd.Text.ToString());
                cmd.Parameters.AddWithValue("soyadi", txtBxPersonelSoyad.Text.ToString());
                cmd.Parameters.AddWithValue("bolumu", cmbBxpersonelBölüm.Text.ToString());
                cmd.Parameters.AddWithValue("maasi", int.Parse(txtBxPersonelMaas.Text));
                cmd.Parameters.AddWithValue("teslim", txtBxTeslimSehir.Text.ToString());


                cmd.ExecuteNonQuery();


                txtBxPersonelAd.Clear();
                txtBxPersonelSoyad.Clear();
                txtBxPersonelMaas.Clear();
                txtBxTeslimSehir.Clear();

                lblTeslimSehir.Visible = false;
                txtBxTeslimSehir.Visible = false;
                baglan.Close();

            }
            if ((int)cmbBxpersonelBölüm.SelectedValue == 3)
            {
                baglan.Open();
                string sql = null;

                sql = " select * from yonetici(:personelBolumID,:personelAdi,:soyadi,:bolumu,:maasi,:kullanici,:sifree)";
                cmd = new NpgsqlCommand(sql, baglan);
            
                cmd.Parameters.AddWithValue("personelBolumID", cmbBxpersonelBölüm.SelectedValue);
                cmd.Parameters.AddWithValue("personelAdi", txtBxPersonelAd.Text.ToString());
                cmd.Parameters.AddWithValue("soyadi", txtBxPersonelSoyad.Text.ToString());
                cmd.Parameters.AddWithValue("bolumu", cmbBxpersonelBölüm.Text.ToString());
                cmd.Parameters.AddWithValue("maasi", int.Parse(txtBxPersonelMaas.Text));
              
                cmd.Parameters.AddWithValue("sifree", txtBxSifre.Text.ToString());
                cmd.Parameters.AddWithValue("kullanici", txtBxKullanici.Text.ToString());


                cmd.ExecuteNonQuery();


                txtBxPersonelAd.Clear();
                txtBxPersonelSoyad.Clear();
                txtBxPersonelMaas.Clear();
                txtBxSifre.Clear();
                txtBxKullanici.Clear();

                lblKullanici.Visible = false;
                lblSifre.Visible = false;
                txtBxKullanici.Visible = false;
                txtBxSifre.Visible = false;

                baglan.Close();
            }

        }

        private void btnİstenCikarılanlar_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "select * from \"cikarilanlarKayit\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string sql = null;

            sql = " select * from personelcikar(:personelID)";
            cmd = new NpgsqlCommand(sql, baglan);
            cmd.Parameters.AddWithValue("personelID", int.Parse(txtBxPersonelSil.Text));
            


            cmd.ExecuteNonQuery();

            //    //int result = (int)cmd.ExecuteScalar();
            baglan.Close();
        }

        private void btnDepartSec_Click(object sender, EventArgs e)
        {
            if ((int)cmbBxpersonelBölüm.SelectedValue == 1)
            {
                lblVardiya.Visible = true;
                txtBxVardiya.Visible = true;
               

            }
            if ((int)cmbBxpersonelBölüm.SelectedValue == 2)
            {
                lblTeslimSehir.Visible = true;
                txtBxTeslimSehir.Visible = true;
               

            }
            if ((int)cmbBxpersonelBölüm.SelectedValue == 3)
            {
                lblKullanici.Visible = true;
                lblSifre.Visible = true;
                txtBxSifre.Visible = true;
                txtBxKullanici.Visible = true;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}