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
    public partial class frmAktiviteler : Form
    {
        public frmAktiviteler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void verilerigoster1()
        {
            listView2.Visible = true;
            listView1.Visible = false;
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Rezervasyon_id"].ToString();
                ekle.SubItems.Add(oku["Tc"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Uyruk"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Tel"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Oda_Tipi"].ToString());
                ekle.SubItems.Add(oku["Uye_Tipi"].ToString());
                ekle.SubItems.Add(oku["Giris_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Cikis_Tarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Durum"].ToString());


                listView2.Items.Add(ekle);


            } baglanti.Close();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            verilerigoster1();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verilerigoster1();
            listView2.Visible = true;
            listView1.Visible = false;
        }
        int id = 0;
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
         // txtRezervasyon.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAd.Text = listView2.SelectedItems[0].SubItems[2].Text;
          //  txtAd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSoyad.Text = listView2.SelectedItems[0].SubItems[3].Text;
            
            label1.Text= listView2.SelectedItems[0].SubItems[10].Text;
            txtRezervasyon.Text = id.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           if (lblUcret.Text != "")
           {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into AktiviteTablosu (Rezervasyon_id,Aktivite_Turu,Ad,Soyad,Saat,Tarih,Kisi,Ucret) values ('" + txtRezervasyon.Text + "','" + comboAktivite.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboSaat.Text + "','" + dtpTarih.Value.ToString("yyyy-MM-dd") + "','" + txtKisi.Text + "','" + lblUcret.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Aktivite Kaydı Yapıldı");
           }
           else
           {
              MessageBox.Show("Ücret Hesaplayınız");
           }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AktiviteTablosu where Tarih='"+dtpTarih.Value.ToString("yyyy-MM-dd")+"'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aktivite_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["Aktivite_Turu"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                


                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verilerigoster2();
            listView1.Visible = true;
            listView2.Visible = false;
        }
        private void verilerigoster2()
        {
            //listView1.Visible = true;
            //listView2.Visible = false;
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AktiviteTablosu", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aktivite_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["Aktivite_Turu"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AktiviteTablosu where Aktivite_Turu='Atv Turu'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aktivite_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["Aktivite_Turu"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AktiviteTablosu where Aktivite_Turu='Tüplü Dalıs'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aktivite_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["Aktivite_Turu"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AktiviteTablosu where Aktivite_Turu='Tekne Turu'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aktivite_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["Aktivite_Turu"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from AktiviteTablosu where Aktivite_Turu='Yamac Parasütü'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Aktivite_id"].ToString();
                ekle.SubItems.Add(oku["Rezervasyon_id"].ToString());
                ekle.SubItems.Add(oku["Aktivite_Turu"].ToString());
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Kisi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());



                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtKisi.Text);
            int atv = 0;
            int tekne = 0;
            int yamac = 0;
            int tup = 0;
            int sonuc = 0;
            if (comboAktivite.Text == "Atv Turu") {
                atv = 40;
            }
            if (comboAktivite.Text == "Tüplü Dalıs")
            { tup = 100; }
            if (comboAktivite.Text == "Tekne Turu")
            { tekne = 60; }
            if (comboAktivite.Text == "Yamac Parasütü")
            {
                yamac = 200; 
            }
            sonuc = (atv + yamac + tekne + tup) * sayi;
            lblUcret.Text = sonuc.ToString();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmaktiviterapor fr = new frmaktiviterapor();
            fr.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmaktiviterapor fr = new frmaktiviterapor();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from AktiviteTablosu where Aktivite_id='" + i + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster2();
        }

        private void frmAktiviteler_Load(object sender, EventArgs e)
        {

        }
int i=0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            i = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtRezervasyon.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboAktivite.Text=listView1.SelectedItems[0].SubItems[2].Text;
            txtAd.Text = listView1.SelectedItems[0].SubItems[3].Text;
            //  txtAd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboSaat.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtKisi.Text = listView1.SelectedItems[0].SubItems[7].Text;
          
            
          //  txtRezervasyon.Text = id.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AktiviteTablosu set Aktivite_Turu='" + comboAktivite.Text + "',Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Saat='" + comboSaat.Text + "',Tarih='" + dtpTarih.Value.ToString("yyyy-MM-dd") + "',Kisi='" + txtKisi.Text + "' where Aktivite_id=" + i + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster2();
        }
    }
}
//Atv Turu
//Tüplü Dalıs
//Tekne Turu
//Yamac Parasütü