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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
        private void verilerigoster2()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler", baglanti);
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
        private void button4_Click(object sender, EventArgs e)
        {
            verilerigoster2();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
          //  txtRezervasyon.Text=listView1.SelectedItems[0].SubItems[1].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAd.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[3].Text;
            comboUyruk.Text = listView1.SelectedItems[0].SubItems[4].Text;
            comboCinsiyet.Text = listView1.SelectedItems[0].SubItems[5].Text;
            maskedTel.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtOdano.Text = listView1.SelectedItems[0].SubItems[8].Text;
            comboOdaTuru.Text = listView1.SelectedItems[0].SubItems[9].Text;
            comboUyelik.Text = listView1.SelectedItems[0].SubItems[10].Text;
            lblUyelikyazdir.Text = listView1.SelectedItems[0].SubItems[10].Text;
            txtRezervasyon.Text = id.ToString();

           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            txtAd.Text = "";
            txtMail.Text = "";
            txtOdano.Text = "";
            txtRezervasyon.Text = "";
            txtTc.Text = "";
            txtSoyad.Text = "";
            comboCinsiyet.Text = "";
            comboOdaTuru.Text = "";
            comboUyruk.Text = "";
            comboUyelik.Text = "";
            lblUyelikyazdir.Text = "";
            maskedTel.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Ad= '"+txtAd.Text+"' or OdaNo='"+txtOdano.Text+"' or Tc='"+txtTc.Text+"' or Rezervasyon_id='"+txtRezervasyon.Text+"'", baglanti);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Musteriler where Rezervasyon_id='"+txtRezervasyon.Text+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster1();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Musteriler set Tc='" + txtTc.Text + "', Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Uyruk='" + comboUyruk.Text + "',Cinsiyet='" + comboCinsiyet.Text + "',Tel='" + maskedTel.Text + "',Mail='" + txtMail.Text + "',OdaNo='" + txtOdano.Text + "',Oda_Tipi='"+comboOdaTuru.Text+"',Uye_Tipi='"+comboUyelik.Text+"' where Rezervasyon_id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster1();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmMusteriRapor fr = new frmMusteriRapor();
            fr.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmMusteriRapor fr = new frmMusteriRapor();
            fr.Show();
        }

        private void comboUyelik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Musteriler where Giris_Tarihi between '" + dtp1.Value.ToString("yyyy-MM-dd") + "' and '" + dtp2.Value.ToString("yyyy-MM-dd") + "'", baglanti);
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
    }
}
