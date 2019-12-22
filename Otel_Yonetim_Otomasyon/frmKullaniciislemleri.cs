using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Yonetim_Otomasyon
{
    public partial class frmKullaniciislemleri : Form
    {
        public frmKullaniciislemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");

        private void button6_Click(object sender, EventArgs e)
        {
            frmkullanicigiris fr = new frmkullanicigiris();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            comboYetki.Text = "";
            txtSifre.Text = "";
            txtKullanici.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kullanici_Giris (KullaniciAdi,Sifre,Yetki) values ('" + txtKullanici.Text + "','" + txtSifre.Text + "','" + comboYetki.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Kaydı Yapıldı");
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kullanici_Giris where KullaniciAdi='" + txtKullanici.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Silindi");
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanici_Giris where KullaniciAdi='" + txtKullanici.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtKullanici.Text = oku["KullaniciAdi"].ToString();
                txtSifre.Text = oku["Sifre"].ToString();
                comboYetki.Text = oku["Yetki"].ToString();




            } baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kullanici_Giris set Sifre='" + txtSifre.Text + "',Yetki='" + comboYetki.Text + "' where KullaniciAdi='" + txtKullanici.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
