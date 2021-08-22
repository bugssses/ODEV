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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432;  Database= odev;user ID=postgres ; password=Merve.35");
        private void UrunEkle_Load(object sender, EventArgs e)
        {
            // NpgsqlConnection baglann = new NpgsqlConnection();
            NpgsqlConnection baglan = new NpgsqlConnection("server=localHost; port=5432;  Database= odev;user ID=postgres ; password=Merve.35");
            baglan.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"urunKategori\"", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbBxUrun.DisplayMember = "kategori";
            cmbBxUrun.ValueMember = "id";
            cmbBxUrun.DataSource = dt;

            NpgsqlDataAdapter dat = new NpgsqlDataAdapter("select * from \"tedarikciler\"", baglan);
            DataTable data = new DataTable();
            dat.Fill(data);
            cmbBxTedarikci.DisplayMember = "firmaİsmi";
            cmbBxTedarikci.ValueMember = "firmaNo";
            cmbBxTedarikci.DataSource = data;
            // baglann.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        NpgsqlCommand cmd = new NpgsqlCommand();
        private void button1_Click(object sender, EventArgs e) {

            if ((int)cmbBxUrun.SelectedValue == 1)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from bis(:urunNamee,:urunID,:tedarikciNoo,:adett,:birimFiyatt,:ces,:gram)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("urunNamee", cmbBxUrun.Text.ToString());
                cmd.Parameters.AddWithValue("tedarikciNoo", cmbBxTedarikci.SelectedValue);
                cmd.Parameters.AddWithValue("adett", int.Parse(txtBoxAdet.Text));
                cmd.Parameters.AddWithValue("birimFiyatt", int.Parse(txtBoxBirim.Text));
                cmd.Parameters.AddWithValue("urunID", cmbBxUrun.SelectedValue);
                cmd.Parameters.AddWithValue("ces", txtbxBisCesit.Text.ToString());
                cmd.Parameters.AddWithValue("gram", txtBxBisGramaj.Text.ToString());

                cmd.ExecuteNonQuery();
               
                txtBoxAdet.Clear();
                txtBoxBirim.Clear();
                lblBisCesit.Visible = false;
                lblBisGramaj.Visible = false;
                txtbxBisCesit.Visible = false;
                txtBxBisGramaj.Visible = false;
                txtbxBisCesit.Clear();
                txtBxBisGramaj.Clear();
                baglan.Close();
            }
            if ((int)cmbBxUrun.SelectedValue == 2)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from cikolata(:urunNamee,:urunID,:tedarikciNoo,:adett,:birimFiyatt,:ces,:markaa)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("urunNamee", cmbBxUrun.Text.ToString());
                cmd.Parameters.AddWithValue("tedarikciNoo", cmbBxTedarikci.SelectedValue);
                cmd.Parameters.AddWithValue("adett", int.Parse(txtBoxAdet.Text));
                cmd.Parameters.AddWithValue("birimFiyatt", int.Parse(txtBoxBirim.Text));
                cmd.Parameters.AddWithValue("urunID", cmbBxUrun.SelectedValue);
                cmd.Parameters.AddWithValue("ces", txtbxBisCesit.Text.ToString());
                cmd.Parameters.AddWithValue("markaa", txtbxMarka.Text.ToString());

                cmd.ExecuteNonQuery();

                txtBoxAdet.Clear();
                txtBoxBirim.Clear();
                lblBisCesit.Visible = false;
                lblMarka.Visible = false;
                txtbxBisCesit.Visible = false;
                txtbxMarka.Visible = false;
                txtbxBisCesit.Clear();
                txtbxMarka.Clear();
                txtBxBisGramaj.Clear();
                baglan.Close();

            }
            if ((int)cmbBxUrun.SelectedValue == 3)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from pirinc(:urunNamee,:urunID,:tedarikciNoo,:adett,:birimFiyatt,:ces,:agirlik,:uretim)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("urunNamee", cmbBxUrun.Text.ToString());
                cmd.Parameters.AddWithValue("tedarikciNoo", cmbBxTedarikci.SelectedValue);
                cmd.Parameters.AddWithValue("adett", int.Parse(txtBoxAdet.Text));
                cmd.Parameters.AddWithValue("birimFiyatt", int.Parse(txtBoxBirim.Text));
                cmd.Parameters.AddWithValue("urunID", cmbBxUrun.SelectedValue);
                cmd.Parameters.AddWithValue("ces", txtbxBisCesit.Text.ToString());
                cmd.Parameters.AddWithValue("agirlik", txtBxPaketAgirlik.Text.ToString());
                cmd.Parameters.AddWithValue("uretim", txtBoxUretimYeri.Text.ToString());

                cmd.ExecuteNonQuery();

                txtBoxAdet.Clear();
                txtBoxBirim.Clear();
                lblBisCesit.Visible = false;
                lblPaketAgirlik.Visible = false;
                lblUretimYeri.Visible = false;
                txtbxBisCesit.Visible = false;
                txtBxPaketAgirlik.Visible = false;
                txtBoxUretimYeri.Visible = false;

                baglan.Close();
            }
            if ((int)cmbBxUrun.SelectedValue == 4)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from cips(:urunNamee,:urunID,:tedarikciNoo,:adett,:birimFiyatt,:ces,:agirlik)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("urunNamee", cmbBxUrun.Text.ToString());
                cmd.Parameters.AddWithValue("tedarikciNoo", cmbBxTedarikci.SelectedValue);
                cmd.Parameters.AddWithValue("adett", int.Parse(txtBoxAdet.Text));
                cmd.Parameters.AddWithValue("birimFiyatt", int.Parse(txtBoxBirim.Text));
                cmd.Parameters.AddWithValue("urunID", cmbBxUrun.SelectedValue);
                cmd.Parameters.AddWithValue("ces", txtbxBisCesit.Text.ToString());
                cmd.Parameters.AddWithValue("agirlik", txtBxBisGramaj.Text.ToString());

                cmd.ExecuteNonQuery();

                txtBoxAdet.Clear();
                txtBoxBirim.Clear();
                lblBisCesit.Visible = false;
                lblBisGramaj.Visible = false;
                txtbxBisCesit.Visible = false;
                txtBxBisGramaj.Visible = false;
                txtBxBisGramaj.Clear();
                txtbxBisCesit.Clear();
                baglan.Close();

            }
            if ((int)cmbBxUrun.SelectedValue == 5)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from mercimek(:urunNamee,:urunID,:tedarikciNoo,:adett,:birimFiyatt,:ces,:agirlik,:uretim)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("urunNamee", cmbBxUrun.Text.ToString());
                cmd.Parameters.AddWithValue("tedarikciNoo", cmbBxTedarikci.SelectedValue);
                cmd.Parameters.AddWithValue("adett", int.Parse(txtBoxAdet.Text));
                cmd.Parameters.AddWithValue("birimFiyatt", int.Parse(txtBoxBirim.Text));
                cmd.Parameters.AddWithValue("urunID", cmbBxUrun.SelectedValue);
                cmd.Parameters.AddWithValue("ces", txtbxBisCesit.Text.ToString());
                cmd.Parameters.AddWithValue("agirlik", txtBxPaketAgirlik.Text.ToString());
                cmd.Parameters.AddWithValue("uretim", txtBoxUretimYeri.Text.ToString());

                cmd.ExecuteNonQuery();

                txtBoxAdet.Clear();
                txtBoxBirim.Clear();
                lblBisCesit.Visible = false;
                lblPaketAgirlik.Visible = false;
                lblUretimYeri.Visible = false;
                txtbxBisCesit.Visible = false;
                txtBxPaketAgirlik.Visible = false;
                txtBoxUretimYeri.Visible = false;
                txtbxBisCesit.Clear();
                txtBoxUretimYeri.Clear();
                txtBxPaketAgirlik.Clear();
                baglan.Close();

            }
            if ((int)cmbBxUrun.SelectedValue == 6)
            {
                string sql = null;
                baglan.Open();
                sql = " select * from kola(:urunNamee,:urunID,:tedarikciNoo,:adett,:birimFiyatt,:markaa,:litre)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("urunNamee", cmbBxUrun.Text.ToString());
                cmd.Parameters.AddWithValue("tedarikciNoo", cmbBxTedarikci.SelectedValue);
                cmd.Parameters.AddWithValue("adett", int.Parse(txtBoxAdet.Text));
                cmd.Parameters.AddWithValue("birimFiyatt", int.Parse(txtBoxBirim.Text));
                cmd.Parameters.AddWithValue("urunID", cmbBxUrun.SelectedValue);
                cmd.Parameters.AddWithValue("markaa", txtbxMarka.Text.ToString());
                cmd.Parameters.AddWithValue("litre", txtBxLitre.Text.ToString());

                cmd.ExecuteNonQuery();

                txtBoxAdet.Clear();
                txtBoxBirim.Clear();
                lblMarka.Visible = false;
                lblLitre.Visible = false;
                txtbxMarka.Visible = false;
                txtBxLitre.Visible = false;
                txtbxMarka.Clear();
                txtBxLitre.Clear();
                baglan.Close();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBxTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"urun\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu,baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
         
        }

        private void btnUrunAra_Click(object sender, EventArgs e)
        {
            int urun =int.Parse(txtBoxUrnAdAra.Text);
       
            string sorgu = "select * from \"public\".\"urunbul\"("+ urun +");";
        
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //   string sql = null;

            //   sql = @" select * from urunbul(:urunAd)";
            //   cmd = new NpgsqlCommand(sql, baglan);
            // cmd.Parameters.AddWithValue("urunAd", "%"+txtBoxUrnAdAra.Text.ToString()+"%");

            ////    NpgsqlDataAdapter data = new NpgsqlDataAdapter(sql, baglan);
            ////    DataSet ds = new DataSet();
            ////    data.Fill(ds);
            //   dataGridView1.DataSource = sql;
        }

        private void btnSatisGecmisi_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"satisKaydi\"";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if ((int)cmbBxUrun.SelectedValue==1)
            {
                lblBisCesit.Visible = true;
                lblBisGramaj.Visible = true;
                txtbxBisCesit.Visible = true;
                txtBxBisGramaj.Visible = true;
             
            }
            if ((int)cmbBxUrun.SelectedValue == 2)
            {
                lblBisCesit.Visible = true;
                lblMarka.Visible = true;
                txtbxBisCesit.Visible = true;
                txtbxMarka.Visible = true;

            }
            if ((int)cmbBxUrun.SelectedValue == 3)
            {
                lblBisCesit.Visible = true;
                lblPaketAgirlik.Visible = true;
                lblUretimYeri.Visible = true;
                txtbxBisCesit.Visible = true;
                txtBxPaketAgirlik.Visible = true;
                txtBoxUretimYeri.Visible = true;

            }
            if ((int)cmbBxUrun.SelectedValue == 4)
            {
                lblBisCesit.Visible = true;
                lblBisGramaj.Visible = true;
          
                txtbxBisCesit.Visible = true;
                txtBxBisGramaj.Visible = true;
       

            }
            if ((int)cmbBxUrun.SelectedValue == 5)
            {
                lblBisCesit.Visible = true;
                lblPaketAgirlik.Visible = true;
                lblUretimYeri.Visible = true;
                txtbxBisCesit.Visible = true;
                txtBxPaketAgirlik.Visible = true;
                txtBoxUretimYeri.Visible = true;

            }
            if ((int)cmbBxUrun.SelectedValue == 6)
            {
                lblMarka.Visible = true;
                lblLitre.Visible = true;
                
                txtbxMarka.Visible = true;
                txtBxLitre.Visible = true;

            }
        }
        NpgsqlCommand cmdd = new NpgsqlCommand();
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sql = null;

            sql = " select * from biskuvidetay(:cesitt,:gram)";
            cmdd = new NpgsqlCommand(sql, baglan);
            cmdd.Parameters.AddWithValue("cesitt", txtbxBisCesit.Text.ToString());
            cmdd.Parameters.AddWithValue("gram", txtBxBisGramaj.Text.ToString());


            cmdd.ExecuteNonQuery();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();

        }
    }
}
