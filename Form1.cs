using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace veritabaniProje
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            baglan = new NpgsqlConnection(constring);
        }
        NpgsqlDataAdapter data = new NpgsqlDataAdapter();
        DataTable ds = new DataTable();
        NpgsqlCommand cmd = new NpgsqlCommand();
        NpgsqlConnection baglan = new NpgsqlConnection();
        string constring=String.Format("server=localHost; port=5432;  Database= odev;user ID=postgres ; password=Merve.35");
        string sql = null;
        private void button1_Click(object sender, EventArgs e)
        {
           
           // string sorgu = "select \"kullaniciAdi,sifre\" from \"yonetici\"";
           
            try
            {
                baglan.Open();
                sql = @" select * from login(:username,:password)";
                cmd = new NpgsqlCommand(sql, baglan);
                cmd.Parameters.AddWithValue("username", textBoxKullanıcı.Text);
                cmd.Parameters.AddWithValue("password", textBoxSifre.Text);

                int result = (int)cmd.ExecuteScalar();
                baglan.Close();

                if (result == 1)
                {
                    this.Hide();
                    new FormMainMenu().Show();

                }
                else
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi kontrol ediniz..","Giriş başarısız oldu",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("HATA:" + ex.Message, "..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglan.Close();
            }
            
           
           
          
            baglan.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
