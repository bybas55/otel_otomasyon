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
    public partial class frmSpaMasaj : Form
    {
        public frmSpaMasaj()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            int Ucret = 0;
            if (comboHizmet.Text == "SPA") {
                Ucret = 60;
                lblTutar.Text = Ucret.ToString();
            }
            if (comboHizmet.Text == "MASAJ")
            {
                Ucret = 80;
                lblTutar.Text =Ucret.ToString();
            }
            if (lblUyelik.Text=="ULTRA HERSEY DAHİL")
            {
                Ucret = 0;
               
            }
            
            baglanti.Open();
            SqlCommand komutekle = new SqlCommand("insert into Spa_Masaj (Rezervasyon_id,Ad,Soyad,OdaNo,HizmetTuru,Saat,Tarih,Ucret) values ('" + txtRezervasyon.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','"+txtOdano.Text+"','"+comboHizmet.Text+"','" + comboSaat.Text + "','" + dtpTarih.Value.ToString("yyyy-MM-dd") + "','" + lblTutar.Text + "')", baglanti);
            komutekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }
        private void temizle()
        {
            txtRezervasyon.Text="";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtOdano.Text = "";
            comboHizmet.Text = "";
            comboSaat.Text = "";
            dtpTarih.Text = "";
            lblTutar.Text = "";
            lblUyelik.Text = "";
        }
       
        private void frmSpaMasaj_Load(object sender, EventArgs e)
        {

            veri();
        }
        private void veri()
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='10.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader ok = kmt.ExecuteReader();

            while (ok.Read())
            { btn10.Text = ok["Ad"].ToString() + " " + ok["Soyad"].ToString(); }
            baglanti.Close();
            if (btn10.Text != "10.00")
            {

                btn10.Enabled = false;
                btn10.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='11.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            { btn11.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString(); }
            baglanti.Close();
            if (btn11.Text != "11.00")
            {

                btn11.Enabled = false;
                btn11.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='12.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            { btn12.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString(); }
            baglanti.Close();
            if (btn12.Text != "12.00")
            {

                btn12.Enabled = false;
                btn12.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='13.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            { btn13.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString(); }
            baglanti.Close();
            if (btn13.Text != "13.00")
            {

                btn13.Enabled = false;
                btn13.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='14.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            { btn14.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString(); }
            baglanti.Close();
            if (btn14.Text != "14.00")
            {

                btn14.Enabled = false;
                btn14.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='15.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            { btn15.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString(); }
            baglanti.Close();
            if (btn15.Text != "15.00")
            {

                btn15.Enabled = false;
                btn15.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='16.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            { btn16.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString(); }
            baglanti.Close();
            if (btn16.Text != "16.00")
            {

                btn16.Enabled = false;
                btn16.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='17.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            { btn17.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString(); }
            baglanti.Close();
            if (btn17.Text != "17.00")
            {

                btn17.Enabled = false;
                btn17.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='18.00' and HizmetTuru='SPA'", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            { btn18.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString(); }
            baglanti.Close();
            if (btn18.Text != "18.00")
            {

                btn18.Enabled = false;
                btn18.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut0 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='10.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku0 = komut0.ExecuteReader();

            while (oku0.Read())
            { mbtn10.Text = oku0["Ad"].ToString() + " " + oku0["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn10.Text != "10.00")
            {

                mbtn10.Enabled = false;
                mbtn10.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='11.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();

            while (oku11.Read())
            { mbtn11.Text = oku11["Ad"].ToString() + " " + oku11["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn11.Text != "11.00")
            {

                mbtn11.Enabled = false;
                mbtn11.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='12.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();

            while (oku12.Read())
            { mbtn12.Text = oku12["Ad"].ToString() + " " + oku12["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn12.Text != "12.00")
            {

                mbtn12.Enabled = false;
                mbtn12.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut13 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='13.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku13 = komut13.ExecuteReader();

            while (oku13.Read())
            { mbtn13.Text = oku13["Ad"].ToString() + " " + oku13["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn13.Text != "13.00")
            {

                mbtn13.Enabled = false;
                mbtn13.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut14 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='14.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku14 = komut14.ExecuteReader();

            while (oku14.Read())
            { mbtn14.Text = oku14["Ad"].ToString() + " " + oku14["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn14.Text != "14.00")
            {

                mbtn14.Enabled = false;
                mbtn14.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut15 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='15.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku15 = komut15.ExecuteReader();

            while (oku15.Read())
            { mbtn15.Text = oku15["Ad"].ToString() + " " + oku15["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn15.Text != "15.00")
            {

                mbtn15.Enabled = false;
                mbtn15.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut16 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='16.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku16 = komut16.ExecuteReader();

            while (oku16.Read())
            { mbtn16.Text = oku16["Ad"].ToString() + " " + oku16["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn16.Text != "16.00")
            {

                mbtn16.Enabled = false;
                mbtn16.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut17 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='17.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku17 = komut17.ExecuteReader();

            while (oku17.Read())
            { mbtn17.Text = oku17["Ad"].ToString() + " " + oku17["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn17.Text != "17.00")
            {

                mbtn17.Enabled = false;
                mbtn17.BackColor = Color.Transparent;
            }
            baglanti.Open();
            SqlCommand komut18 = new SqlCommand("select * from Spa_Masaj where  Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' and Saat='18.00' and HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku18 = komut18.ExecuteReader();

            while (oku18.Read())
            { mbtn18.Text = oku18["Ad"].ToString() + " " + oku18["Soyad"].ToString(); }
            baglanti.Close();
            if (mbtn18.Text != "18.00")
            {

                mbtn18.Enabled = false;
                mbtn18.BackColor = Color.Transparent;
            }
        }
        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Rezervasyon_id='" + txtRezervasyon.Text + "' and Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtRezervasyon.Text = oku["Rezervasyon_id"].ToString();
                txtAd.Text = oku["Ad"].ToString();
                txtSoyad.Text = oku["Soyad"].ToString();
                txtOdano.Text = oku["OdaNo"].ToString();
                lblUyelik.Text = oku["Uye_Tipi"].ToString();




            } baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Ad='" + txtAd.Text + "' and Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtRezervasyon.Text = oku["Rezervasyon_id"].ToString();
                txtAd.Text = oku["Ad"].ToString();
                txtSoyad.Text = oku["Soyad"].ToString();
                txtOdano.Text = oku["OdaNo"].ToString();
                lblUyelik.Text = oku["Uye_Tipi"].ToString();



            } baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Soyad='" + txtSoyad.Text + "' and Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtRezervasyon.Text = oku["Rezervasyon_id"].ToString();
                txtAd.Text = oku["Ad"].ToString();
                txtSoyad.Text = oku["Soyad"].ToString();
                txtOdano.Text = oku["OdaNo"].ToString();
                lblUyelik.Text = oku["Uye_Tipi"].ToString();



            } baglanti.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where OdaNo='" + txtOdano.Text + "' and Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtRezervasyon.Text = oku["Rezervasyon_id"].ToString();
                txtAd.Text = oku["Ad"].ToString();
                txtSoyad.Text = oku["Soyad"].ToString();
                txtOdano.Text = oku["OdaNo"].ToString();
                lblUyelik.Text = oku["Uye_Tipi"].ToString();



            } baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "10.00";
            comboHizmet.Text = "SPA";
            btn10.BackColor = Color.Transparent;
            btn10.Text = txtAd.Text + " " + txtSoyad.Text;
            btn10.Enabled = false;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "11.00";
            comboHizmet.Text = "SPA";
            btn11.BackColor = Color.Transparent;
            btn11.Text = txtAd.Text + " " + txtSoyad.Text;
            btn11.Enabled = false;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "12.00";
            comboHizmet.Text = "SPA";
            btn12.BackColor = Color.Transparent;
            btn12.Text = txtAd.Text + " " + txtSoyad.Text;
            btn12.Enabled = false;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "13.00";
            comboHizmet.Text = "SPA";
            btn13.BackColor = Color.Transparent;
            btn13.Text = txtAd.Text + " " + txtSoyad.Text;
            btn13.Text = txtAd.Text + " " + txtSoyad.Text;
            btn13.Enabled = false;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "14.00";
            comboHizmet.Text = "SPA";
            btn14.BackColor = Color.Transparent;
            btn14.Text = txtAd.Text + " " + txtSoyad.Text;
            btn14.Enabled = false;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "15.00";
            comboHizmet.Text = "SPA";
            btn15.BackColor = Color.Transparent;
            btn15.Text = txtAd.Text + " " + txtSoyad.Text;
            btn15.Enabled = false;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "16.00";
            comboHizmet.Text = "SPA";
            btn16.BackColor = Color.Transparent;
            btn16.Text = txtAd.Text + " " + txtSoyad.Text;
            btn16.Enabled = false;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "17.00";
            comboHizmet.Text = "SPA";
            btn17.BackColor = Color.Transparent;
            btn17.Text = txtAd.Text + " " + txtSoyad.Text;
            btn17.Enabled = false;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "18.00";
            comboHizmet.Text = "SPA";
            btn18.BackColor = Color.Transparent;
            btn18.Text = txtAd.Text + " " + txtSoyad.Text;
            btn18.Enabled = false;
        }

        private void mbtn10_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "10.00";
            comboHizmet.Text = "MASAJ";
            mbtn10.BackColor = Color.Transparent;
            mbtn10.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn10.Enabled = false;
        }

        private void mbtn11_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "11.00";
            comboHizmet.Text = "MASAJ";
            mbtn11.BackColor = Color.Transparent;
            mbtn11.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn11.Enabled = false;
        }

        private void mbtn12_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "12.00";
            comboHizmet.Text = "MASAJ";
            mbtn12.BackColor = Color.Transparent;
            mbtn12.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn12.Enabled = false;
        }

        private void mbtn13_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "13.00";
            comboHizmet.Text = "MASAJ";
            mbtn13.BackColor = Color.Transparent;
            mbtn13.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn13.Enabled = false;
        }

        private void mbtn14_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "14.00";
            comboHizmet.Text = "MASAJ";
            mbtn14.BackColor = Color.Transparent;
            mbtn14.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn14.Enabled = false;
        }

        private void mbtn15_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "15.00";
            comboHizmet.Text = "MASAJ";
            mbtn15.BackColor = Color.Transparent;
            mbtn15.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn15.Enabled = false;
        }

        private void mbtn16_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "16.00";
            comboHizmet.Text = "MASAJ";
            mbtn16.BackColor = Color.Transparent;
            mbtn16.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn16.Enabled = false;
        }

        private void mbtn17_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "17.00";
            comboHizmet.Text = "MASAJ";
            mbtn17.BackColor = Color.Transparent;
            mbtn17.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn17.Enabled = false;
        }

        private void mbtn18_Click(object sender, EventArgs e)
        {
            comboSaat.Text = "18.00";
            comboHizmet.Text = "MASAJ";
            mbtn18.BackColor = Color.Transparent;
            mbtn18.Text = txtAd.Text + " " + txtSoyad.Text;
            mbtn18.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btn10.BackColor = Color.DodgerBlue;
            btn11.BackColor = Color.DodgerBlue;
            btn12.BackColor = Color.DodgerBlue;
            btn13.BackColor = Color.DodgerBlue;
            btn14.BackColor = Color.DodgerBlue;
            btn15.BackColor = Color.DodgerBlue;
            btn16.BackColor = Color.DodgerBlue;
            btn17.BackColor = Color.DodgerBlue;
            btn18.BackColor = Color.DodgerBlue;
            mbtn10.BackColor = Color.Salmon;
            mbtn11.BackColor = Color.Salmon;
            mbtn12.BackColor = Color.Salmon;
            mbtn13.BackColor = Color.Salmon;
            mbtn14.BackColor = Color.Salmon;
            mbtn15.BackColor = Color.Salmon;
            mbtn16.BackColor = Color.Salmon;
            mbtn17.BackColor = Color.Salmon;
            mbtn18.BackColor = Color.Salmon;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Spa_Masaj where HizmetTuru='SPA'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Hizmet_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
               
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["HizmetTuru"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
               
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }
        private void verilerigostergenel()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Spa_Masaj", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Hizmet_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());

                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["HizmetTuru"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
               
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Spa_Masaj where HizmetTuru='MASAJ'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Hizmet_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());

                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["HizmetTuru"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
               
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }
        int i = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            i = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtRezervasyon.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            //  txtAd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtOdano.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboHizmet.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboSaat.Text = listView1.SelectedItems[0].SubItems[6].Text;
            
            

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verilerigostergenel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Spa_Masaj set  Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',OdaNo='" + txtOdano.Text + "',HizmetTuru='" + comboHizmet.Text + "',Saat='" + comboSaat.Text + "',Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "' where Hizmet_id=" + i + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigostergenel();
        }
    }
}
