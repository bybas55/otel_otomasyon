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
    public partial class frmMuhasebe : Form
    {
        public frmMuhasebe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Rezervasyon_id='" + txtRezervasyon.Text + "' and Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtRezervasyon.Text = oku["Rezervasyon_id"].ToString();
                lblAd.Text = oku["Ad"].ToString();
                lblSoyad.Text = oku["Soyad"].ToString();
                txtOdano.Text = oku["OdaNo"].ToString();
                lblUyelik.Text = oku["Uye_Tipi"].ToString();
                lblOdaUcreti.Text = oku["Ucret"].ToString();




            } baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from AktiviteTablosu where Rezervasyon_id='" + txtRezervasyon.Text + "' ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                
                lblAktivite.Text = oku1["Ucret"].ToString();




            } baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Spa_Masaj where Rezervasyon_id='" + txtRezervasyon.Text + "' ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {

                lblSpa.Text = oku2["Ucret"].ToString();




            } baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Sipariss where Rezervasyon_id='" + txtRezervasyon.Text + "' ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {

                lblCafe.Text= oku3["Ucret"].ToString();




            } baglanti.Close();

            int ak = 0;
            int spa = 0;
            int cafe = 0;
            int oda = 0;
            int toplam=0;
            ak = Convert.ToInt32(lblAktivite.Text);
            spa = Convert.ToInt32(lblSpa.Text);
            cafe = Convert.ToInt32(lblCafe.Text);
            oda = Convert.ToInt32(lblOdaUcreti.Text);
           toplam=ak+spa+cafe+oda;
           lblToplam.Text = toplam.ToString();


        }

        private void button21_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where OdaNo='" + txtOdano.Text + "' and Durum='Aktif'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                txtRezervasyon.Text = oku["Rezervasyon_id"].ToString();
                lblAd.Text = oku["Ad"].ToString();
                lblSoyad.Text = oku["Soyad"].ToString();
                txtOdano.Text = oku["OdaNo"].ToString();
                lblUyelik.Text = oku["Uye_Tipi"].ToString();
                lblOdaUcreti.Text = oku["Ucret"].ToString();




            } baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           baglanti.Open();
           SqlCommand komut = new SqlCommand("update Musteriler set Durum='Pasif' where Rezervasyon_id=" + txtRezervasyon.Text + "", baglanti);
           komut.ExecuteNonQuery();
           baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("delete from Odalar where OdaNo='" + txtOdano.Text + "'", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            
            verilerigoster1();
        }
        private void verilerigoster1()
        {
            listView1.Items.Clear();
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


                listView1.Items.Add(ekle);


            } baglanti.Close();

        }

        private void frmMuhasebe_Load(object sender, EventArgs e)
        {
            verilerigoster1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel (Unvan,PersonelAdi,PersonelSoyadi,Tc,Cinsiyet,Uyruk,Tel,Mail,Dogum_tarihi,Medeni_Durum,Cocuk_Sayisi,Maas) values ('" +comboUnvan.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTc.Text + "','" + comboCinsiyet.Text + "','" +comboUyruk.Text + "','" + maskedTextBox1.Text + "','" + txtMail.Text + "','" + txtDogum.Text + "','" + comboMedeni.Text + "','" + comboCocuk.Text + "','" + txtMaas.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Kaydı Yapıldı");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            comboUnvan.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            txtDogum.Text = "";
            txtMaas.Text = "";
            txtMail.Text = "";
            maskedTextBox1.Text = "";
            comboUyruk.Text = "";
            comboMedeni.Text = "";
            comboCocuk.Text = "";
            comboCinsiyet.Text = "";
        }
        private void verilerigoster2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komutlis2 = new SqlCommand("select * from Personel", baglanti);
            SqlDataReader okulis2 = komutlis2.ExecuteReader();

            while (okulis2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okulis2["Personel_id"].ToString();
                ekle.SubItems.Add(okulis2["Unvan"].ToString());
                ekle.SubItems.Add(okulis2["PersonelAdi"].ToString());
                ekle.SubItems.Add(okulis2["PersonelSoyadi"].ToString());
                ekle.SubItems.Add(okulis2["Tc"].ToString());
                ekle.SubItems.Add(okulis2["Cinsiyet"].ToString());
                ekle.SubItems.Add(okulis2["Uyruk"].ToString());
                ekle.SubItems.Add(okulis2["Tel"].ToString());
                ekle.SubItems.Add(okulis2["Mail"].ToString());
                ekle.SubItems.Add(okulis2["Dogum_tarihi"].ToString());
                ekle.SubItems.Add(okulis2["Medeni_Durum"].ToString());
                ekle.SubItems.Add(okulis2["Cocuk_Sayisi"].ToString());
                ekle.SubItems.Add(okulis2["Maas"].ToString());



                listView2.Items.Add(ekle);


            } baglanti.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            verilerigoster2();

        }
        int id = 0;
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            //  txtRezervasyon.Text=listView1.SelectedItems[0].SubItems[1].Text;
            comboUnvan.Text = listView2.SelectedItems[0].SubItems[1].Text;

            txtAd.Text = listView2.SelectedItems[0].SubItems[2].Text;
            txtSoyad.Text = listView2.SelectedItems[0].SubItems[3].Text;
            txtTc.Text = listView2.SelectedItems[0].SubItems[4].Text;
            comboCinsiyet.Text = listView2.SelectedItems[0].SubItems[5].Text;
         
            comboUyruk.Text = listView2.SelectedItems[0].SubItems[6].Text;
            
            maskedTextBox1.Text = listView2.SelectedItems[0].SubItems[7].Text;
            txtMail.Text = listView2.SelectedItems[0].SubItems[8].Text;
            
            txtDogum.Text = listView2.SelectedItems[0].SubItems[9].Text;
            
            comboMedeni.Text = listView2.SelectedItems[0].SubItems[10].Text;
           comboCocuk.Text = listView2.SelectedItems[0].SubItems[11].Text;
           txtMaas.Text = listView2.SelectedItems[0].SubItems[12].Text;
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel set Unvan='" + comboUnvan.Text + "',PersonelAdi='" + txtAd.Text + "',PersonelSoyadi='" + txtSoyad.Text + "',Tc='" + txtTc.Text + "',Cinsiyet='" + comboCinsiyet.Text + "',Uyruk='" + comboUyruk.Text + "',Tel='" + maskedTextBox1.Text + "',Mail='" + txtMail.Text + "',Dogum_tarihi='" + txtDogum.Text + "',Medeni_Durum='" + comboMedeni.Text + "',Cocuk_Sayisi='" + comboCocuk.Text + "',Maas='" + txtMaas.Text + "' where Personel_id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster2();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personel where Personel_id='" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster2();
            temizle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where Unvan='" + comboUnvan.Text + "' ", baglanti);
            SqlDataReader okulis2 = komut.ExecuteReader();

            while (okulis2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okulis2["Personel_id"].ToString();
                ekle.SubItems.Add(okulis2["Unvan"].ToString());
                ekle.SubItems.Add(okulis2["PersonelAdi"].ToString());
                ekle.SubItems.Add(okulis2["PersonelSoyadi"].ToString());
                ekle.SubItems.Add(okulis2["Tc"].ToString());
                ekle.SubItems.Add(okulis2["Cinsiyet"].ToString());
                ekle.SubItems.Add(okulis2["Uyruk"].ToString());
                ekle.SubItems.Add(okulis2["Tel"].ToString());
                ekle.SubItems.Add(okulis2["Mail"].ToString());
                ekle.SubItems.Add(okulis2["Dogum_tarihi"].ToString());
                ekle.SubItems.Add(okulis2["Medeni_Durum"].ToString());
                ekle.SubItems.Add(okulis2["Cocuk_Sayisi"].ToString());
                ekle.SubItems.Add(okulis2["Maas"].ToString());



                listView2.Items.Add(ekle);




            } baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where PersonelAdi='" + txtAd.Text + "' ", baglanti);
            SqlDataReader okulis2 = komut.ExecuteReader();

            while (okulis2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okulis2["Personel_id"].ToString();
                ekle.SubItems.Add(okulis2["Unvan"].ToString());
                ekle.SubItems.Add(okulis2["PersonelAdi"].ToString());
                ekle.SubItems.Add(okulis2["PersonelSoyadi"].ToString());
                ekle.SubItems.Add(okulis2["Tc"].ToString());
                ekle.SubItems.Add(okulis2["Cinsiyet"].ToString());
                ekle.SubItems.Add(okulis2["Uyruk"].ToString());
                ekle.SubItems.Add(okulis2["Tel"].ToString());
                ekle.SubItems.Add(okulis2["Mail"].ToString());
                ekle.SubItems.Add(okulis2["Dogum_tarihi"].ToString());
                ekle.SubItems.Add(okulis2["Medeni_Durum"].ToString());
                ekle.SubItems.Add(okulis2["Cocuk_Sayisi"].ToString());
                ekle.SubItems.Add(okulis2["Maas"].ToString());



                listView2.Items.Add(ekle);




            } baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Personel where PersonelSoyadi='" + txtSoyad.Text + "' ", baglanti);
            SqlDataReader okulis2 = komut.ExecuteReader();

            while (okulis2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okulis2["Personel_id"].ToString();
                ekle.SubItems.Add(okulis2["Unvan"].ToString());
                ekle.SubItems.Add(okulis2["PersonelAdi"].ToString());
                ekle.SubItems.Add(okulis2["PersonelSoyadi"].ToString());
                ekle.SubItems.Add(okulis2["Tc"].ToString());
                ekle.SubItems.Add(okulis2["Cinsiyet"].ToString());
                ekle.SubItems.Add(okulis2["Uyruk"].ToString());
                ekle.SubItems.Add(okulis2["Tel"].ToString());
                ekle.SubItems.Add(okulis2["Mail"].ToString());
                ekle.SubItems.Add(okulis2["Dogum_tarihi"].ToString());
                ekle.SubItems.Add(okulis2["Medeni_Durum"].ToString());
                ekle.SubItems.Add(okulis2["Cocuk_Sayisi"].ToString());
                ekle.SubItems.Add(okulis2["Maas"].ToString());



                listView2.Items.Add(ekle);




            } baglanti.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmpersonelrapor fr = new frmpersonelrapor();
            fr.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmpersonelrapor fr = new frmpersonelrapor();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Giderler (Gider_Adi,Gider_Turu,Tarih,Tutar) values ('" + txtGider.Text + "','" + txtGiderturu.Text + "','" + dtptarih.Value.ToString("yyyy-MM-dd") + "','" + txttutar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Gider Kaydı Yapıldı");
            verilerigoster3();
        }
        private void verilerigoster3()
    {
        listView3.Items.Clear();
        baglanti.Open();
        SqlCommand komutlis3 = new SqlCommand("select * from Giderler", baglanti);
        SqlDataReader okulis3 = komutlis3.ExecuteReader();

        while (okulis3.Read())
        {
            ListViewItem ekle = new ListViewItem();
            ekle.Text = okulis3["Gider_id"].ToString();
            ekle.SubItems.Add(okulis3["Gider_Adi"].ToString());
            ekle.SubItems.Add(okulis3["Gider_Turu"].ToString());
            ekle.SubItems.Add(okulis3["Tarih"].ToString());
           
            ekle.SubItems.Add(okulis3["Tutar"].ToString());



            listView3.Items.Add(ekle);


        } baglanti.Close();
    
    }
        private void button11_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Giderler set Gider_Adi='" + txtGider.Text + "',Gider_Turu='" + txtGiderturu.Text + "',Tarih='" + dtptarih.Value.ToString("yyyy-MM-dd") + "',Tutar='" + txttutar.Text + "' where Gider_id=" + i + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster3();
        }
        int i = 0;
        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            i = int.Parse(listView3.SelectedItems[0].SubItems[0].Text);
            txtGider.Text = listView3.SelectedItems[0].SubItems[1].Text;
            txtGiderturu.Text = listView3.SelectedItems[0].SubItems[2].Text;
            dtptarih.Text = listView3.SelectedItems[0].SubItems[3].Text;     
            txttutar.Text = listView3.SelectedItems[0].SubItems[4].Text;

           
           
        }
        private void temizlegider()
        {
            txtGider.Text = "";
            txtGiderturu.Text = "";
            dtptarih.Text = "";
            txttutar.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Giderler where Gider_id='" + i + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster3();
            temizlegider();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temizlegider();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            verilerigoster3();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            baglanti.Open();
            SqlCommand komutlis3 = new SqlCommand("select * from Giderler where Tarih between '" + dtp1.Value.ToString("yyyy-MM-dd") + "' and '" + dtp2.Value.ToString("yyyy-MM-dd") + "' ", baglanti);
            SqlDataReader okulis3 = komutlis3.ExecuteReader();

            while (okulis3.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okulis3["Gider_id"].ToString();
                ekle.SubItems.Add(okulis3["Gider_Adi"].ToString());
                ekle.SubItems.Add(okulis3["Gider_Turu"].ToString());
                ekle.SubItems.Add(okulis3["Tarih"].ToString());

                ekle.SubItems.Add(okulis3["Tutar"].ToString());



                listView3.Items.Add(ekle);


            } baglanti.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmgiderler fr = new frmgiderler();
            fr.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            frmgiderler fr = new frmgiderler();
            fr.Show();
        }
    }
}
