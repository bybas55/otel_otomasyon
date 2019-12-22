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
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmYeniMusteri_Load(object sender, EventArgs e)
        {
            //101
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Odalar where OdaNo like '101'", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            { btn101.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString(); }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.Text = "101";
                btn101.Enabled = false;
                btn101.BackColor = Color.Transparent;
            }
            //102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Odalar where OdaNo like '102'", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            { btn102.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString(); }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.Text = "102";
                btn102.Enabled = false;
                btn102.BackColor = Color.Transparent;
            }
            
            //103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Odalar where OdaNo like '103'", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            { btn103.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString(); }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn103.Text = "103";
                btn103.Enabled = false;
                btn103.BackColor = Color.Transparent;
            }
            //104
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Odalar where OdaNo like '104'", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            { btn104.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString(); }
            baglanti.Close();
            if (btn104.Text != "104")
            {
                btn104.Text = "104";
                btn104.Enabled = false;
                btn104.BackColor = Color.Transparent;
            }
            //105
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Odalar where OdaNo like '105'", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            { btn105.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString(); }
            baglanti.Close();
            if (btn105.Text != "105")
            {
                btn105.Text = "105";
                btn105.Enabled = false;
                btn105.BackColor = Color.Transparent;
            }
            //106
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Odalar where OdaNo like '106'", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            { btn106.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString(); }
            baglanti.Close();
            if (btn106.Text != "106")
            {
                btn106.Text = "106";
                btn106.Enabled = false;
                btn106.BackColor = Color.Transparent;
            }
            //107
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Odalar where OdaNo like '107'", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            { btn107.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString(); }
            baglanti.Close();
            if (btn107.Text != "107")
            {
                btn107.Text = "107";
                btn107.Enabled = false;
                btn107.BackColor = Color.Transparent;
            }
            //108
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Odalar where OdaNo like '108'", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            { btn108.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString(); }
            baglanti.Close();
            if (btn108.Text != "108")
            {
                btn108.Text = "108";
                btn108.Enabled = false;
                btn108.BackColor = Color.Transparent;
            }
            //109
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Odalar where OdaNo like '109'", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            { btn109.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString(); }
            baglanti.Close();
            if (btn109.Text != "109")
            {
                btn109.Text = "109";
                btn109.Enabled = false;
                btn109.BackColor = Color.Transparent;
            }

            //201
            baglanti.Open();
            SqlCommand komut21 = new SqlCommand("select * from Odalar where OdaNo like '201'", baglanti);
            SqlDataReader oku21 = komut21.ExecuteReader();

            while (oku21.Read())
            { btn201.Text = oku21["Ad"].ToString() + " " + oku21["Soyad"].ToString(); }
            baglanti.Close();
            if (btn201.Text != "201")
            {
                btn201.Text = "201";
                btn201.Enabled = false;
                btn201.BackColor = Color.Transparent;
            }
            //202
            baglanti.Open();
            SqlCommand komut22 = new SqlCommand("select * from Odalar where OdaNo like '202'", baglanti);
            SqlDataReader oku22 = komut22.ExecuteReader();

            while (oku22.Read())
            { btn202.Text = oku22["Ad"].ToString() + " " + oku22["Soyad"].ToString(); }
            baglanti.Close();
            if (btn202.Text != "202")
            {
                btn202.Text = "202";
                btn202.Enabled = false;
                btn202.BackColor = Color.Transparent;
            }

            //203
            baglanti.Open();
            SqlCommand komut23 = new SqlCommand("select * from Odalar where OdaNo like '203'", baglanti);
            SqlDataReader oku23 = komut23.ExecuteReader();

            while (oku23.Read())
            { btn203.Text = oku23["Ad"].ToString() + " " + oku23["Soyad"].ToString(); }
            baglanti.Close();
            if (btn203.Text != "203")
            {
                btn203.Text = "203";
                btn203.Enabled = false;
                btn203.BackColor = Color.Transparent;
            }
            //204
            baglanti.Open();
            SqlCommand komut24 = new SqlCommand("select * from Odalar where OdaNo like '204'", baglanti);
            SqlDataReader oku24 = komut24.ExecuteReader();

            while (oku24.Read())
            { btn204.Text = oku24["Ad"].ToString() + " " + oku24["Soyad"].ToString(); }
            baglanti.Close();
            if (btn204.Text != "204")
            {
                btn204.Text = "204";
                btn204.Enabled = false;
                btn204.BackColor = Color.Transparent;
            }
            //205
            baglanti.Open();
            SqlCommand komut25 = new SqlCommand("select * from Odalar where OdaNo like '205'", baglanti);
            SqlDataReader oku25 = komut25.ExecuteReader();

            while (oku25.Read())
            { btn205.Text = oku25["Ad"].ToString() + " " + oku25["Soyad"].ToString(); }
            baglanti.Close();
            if (btn205.Text != "205")
            {
                btn205.Text = "205";
                btn205.Enabled = false;
                btn205.BackColor = Color.Transparent;
            }
            //206
            baglanti.Open();
            SqlCommand komut26 = new SqlCommand("select * from Odalar where OdaNo like '206'", baglanti);
            SqlDataReader oku26 = komut26.ExecuteReader();

            while (oku26.Read())
            { btn206.Text = oku26["Ad"].ToString() + " " + oku26["Soyad"].ToString(); }
            baglanti.Close();
            if (btn206.Text != "206")
            {
                btn206.Text = "206";
                btn206.Enabled = false;
                btn206.BackColor = Color.Transparent;
            }
            //207
            baglanti.Open();
            SqlCommand komut27 = new SqlCommand("select * from Odalar where OdaNo like '207'", baglanti);
            SqlDataReader oku27 = komut27.ExecuteReader();

            while (oku27.Read())
            { btn207.Text = oku27["Ad"].ToString() + " " + oku27["Soyad"].ToString(); }
            baglanti.Close();
            if (btn207.Text != "207")
            {
                btn207.Text = "207";
                btn207.Enabled = false;
                btn207.BackColor = Color.Transparent;
            }
            //208
            baglanti.Open();
            SqlCommand komut28 = new SqlCommand("select * from Odalar where OdaNo like '208'", baglanti);
            SqlDataReader oku28 = komut28.ExecuteReader();

            while (oku28.Read())
            { btn208.Text = oku28["Ad"].ToString() + " " + oku28["Soyad"].ToString(); }
            baglanti.Close();
            if (btn208.Text != "208")
            {
                btn208.Text = "208";
                btn208.Enabled = false;
                btn208.BackColor = Color.Transparent;
            }
            //209
            baglanti.Open();
            SqlCommand komut29 = new SqlCommand("select * from Odalar where OdaNo like '209'", baglanti);
            SqlDataReader oku29 = komut29.ExecuteReader();

            while (oku29.Read())
            { btn209.Text = oku29["Ad"].ToString() + " " + oku29["Soyad"].ToString(); }
            baglanti.Close();
            if (btn209.Text != "209")
            {
                btn209.Text = "209";
                btn209.Enabled = false;
                btn209.BackColor = Color.Transparent;
            }
            //301
            baglanti.Open();
            SqlCommand komut31 = new SqlCommand("select * from Odalar where OdaNo like '301'", baglanti);
            SqlDataReader oku31 = komut31.ExecuteReader();

            while (oku31.Read())
            { btn301.Text = oku31["Ad"].ToString() + " " + oku31["Soyad"].ToString(); }
            baglanti.Close();
            if (btn301.Text != "301")
            {
                btn301.Text = "301";
                btn301.Enabled = false;
                btn301.BackColor = Color.Transparent;
            }
            //302
            baglanti.Open();
            SqlCommand komut32 = new SqlCommand("select * from Odalar where OdaNo like '302'", baglanti);
            SqlDataReader oku32 = komut32.ExecuteReader();

            while (oku32.Read())
            { btn302.Text = oku32["Ad"].ToString() + " " + oku32["Soyad"].ToString(); }
            baglanti.Close();
            if (btn302.Text != "302")
            {
                btn302.Text = "302";
                btn302.Enabled = false;
                btn302.BackColor = Color.Transparent;
            }

            //303
            baglanti.Open();
            SqlCommand komut33 = new SqlCommand("select * from Odalar where OdaNo like '303'", baglanti);
            SqlDataReader oku33 = komut33.ExecuteReader();

            while (oku33.Read())
            { btn303.Text = oku33["Ad"].ToString() + " " + oku33["Soyad"].ToString(); }
            baglanti.Close();
            if (btn303.Text != "303")
            {
                btn303.Text = "303";
                btn303.Enabled = false;
                btn303.BackColor = Color.Transparent;
            }
            //304
            baglanti.Open();
            SqlCommand komut34 = new SqlCommand("select * from Odalar where OdaNo like '304'", baglanti);
            SqlDataReader oku34 = komut4.ExecuteReader();

            while (oku34.Read())
            { btn304.Text = oku34["Ad"].ToString() + " " + oku34["Soyad"].ToString(); }
            baglanti.Close();
            if (btn304.Text != "304")
            {
                btn304.Text = "304";
                btn304.Enabled = false;
                btn304.BackColor = Color.Transparent;
            }
            //305
            baglanti.Open();
            SqlCommand komut35 = new SqlCommand("select * from Odalar where OdaNo like '305'", baglanti);
            SqlDataReader oku35 = komut35.ExecuteReader();

            while (oku35.Read())
            { btn305.Text = oku35["Ad"].ToString() + " " + oku35["Soyad"].ToString(); }
            baglanti.Close();
            if (btn305.Text != "305")
            {
                btn305.Text = "305";
                btn305.Enabled = false;
                btn305.BackColor = Color.Transparent;
            }
            //306
            baglanti.Open();
            SqlCommand komut36 = new SqlCommand("select * from Odalar where OdaNo like '306'", baglanti);
            SqlDataReader oku36 = komut36.ExecuteReader();

            while (oku36.Read())
            { btn306.Text = oku36["Ad"].ToString() + " " + oku36["Soyad"].ToString(); }
            baglanti.Close();
            if (btn306.Text != "306")
            {
                btn306.Text = "306";
                btn306.Enabled = false;
                btn306.BackColor = Color.Transparent;
            }
            //307
            baglanti.Open();
            SqlCommand komut37 = new SqlCommand("select * from Odalar where OdaNo like '307'", baglanti);
            SqlDataReader oku37 = komut37.ExecuteReader();

            while (oku37.Read())
            { btn307.Text = oku37["Ad"].ToString() + " " + oku37["Soyad"].ToString(); }
            baglanti.Close();
            if (btn307.Text != "307")
            {
                btn307.Text = "307";
                btn307.Enabled = false;
                btn307.BackColor = Color.Transparent;
            }
            //308
            baglanti.Open();
            SqlCommand komut38 = new SqlCommand("select * from Odalar where OdaNo like '308'", baglanti);
            SqlDataReader oku38 = komut38.ExecuteReader();

            while (oku38.Read())
            { btn308.Text = oku38["Ad"].ToString() + " " + oku38["Soyad"].ToString(); }
            baglanti.Close();
            if (btn308.Text != "308")
            {
                btn308.Text = "308";
                btn308.Enabled = false;
                btn308.BackColor = Color.Transparent;
            }
            //309
            baglanti.Open();
            SqlCommand komut39 = new SqlCommand("select * from Odalar where OdaNo like '309'", baglanti);
            SqlDataReader oku39 = komut39.ExecuteReader();

            while (oku39.Read())
            { btn309.Text = oku39["Ad"].ToString() + " " + oku39["Soyad"].ToString(); }
            baglanti.Close();
            if (btn309.Text != "309")
            {
                btn309.Text = "309";
                btn309.Enabled = false;
                btn309.BackColor = Color.Transparent;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Musteriler (Tc,Ad,Soyad,Uyruk,Cinsiyet,Tel,Mail,OdaNo,Oda_Tipi,Uye_Tipi,Giris_Tarihi,Cikis_Tarihi,Ucret,Durum) values ('" + txtTc.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','"+comboUyruk.Text+"','" + comboCinsiyet.Text + "','" + maskedTel.Text + "','" + txtMail.Text + "','" + txtOdano.Text + "','" + comboOdaTuru.Text + "','" + comboUyelik.Text + "','" + dtpGiris.Value.ToString("yyyy-MM-dd") + "','" + dtpCikis.Value.ToString("yyyy-MM-dd") + "','" + lblTotal.Text + "','" + lblAktif.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kaydı Yapıldı");
            }
            else {
                MessageBox.Show("Ücret Hesaplayınız");
            }

            
            temizle();
        }
        private void temizle()
        {
            txtAd.Text = "";
            txtMail.Text = "";
            txtOdano.Text = "";
            txtOdaUcreti.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            comboCinsiyet.Text = "";
            comboOdaTuru.Text = "";
            comboUyelik.Text = "";
            comboUyruk.Text = "";
            maskedTel.Text = "";
            dtpCikis.Text = "";
            dtpGiris.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int ucret;
           int fiyat = Convert.ToInt32(txtOdaUcreti.Text);
            
            DateTime KucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikis.Text);
            TimeSpan fark;
            fark = BuyukTarih - KucukTarih;
            lblGun.Text = fark.TotalDays.ToString();
            ucret = Convert.ToInt32(lblGun.Text) * fiyat;
            lblTotal.Text = ucret.ToString();
          //  MessageBox.Show("Ödenecek Tutar=" + ucret + " Tl");
        }

        private void btnUcrethesapla_Click(object sender, EventArgs e)
        {
          //  STANDART
//SUIT
//DELUXE
           // ODA KAHVALTI
//HERSEY DAHİL
//ULTRA HERSEY DAHİL

           
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('"+txtOdano.Text+"','"+txtAd.Text+"','"+txtSoyad.Text+"','"+comboOdaTuru.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "STANDART";
            txtOdano.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "201";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "202";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "203";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "204";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "205";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn206_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "206";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn207_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "207";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn208_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "208";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn209_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "SUIT";
            txtOdano.Text = "209";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "301";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "302";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "303";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn304_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "304";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn305_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "305";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn306_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "306";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn307_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "307";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn308_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "308";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btn309_Click(object sender, EventArgs e)
        {
            comboOdaTuru.Text = "DELUXE";
            txtOdano.Text = "309";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Odalar (OdaNo,Ad,Soyad,Tipi) values ('" + txtOdano.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + comboOdaTuru.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int fiyat = 0;
            if (comboOdaTuru.Text == "STANDART" && comboUyelik.Text == "ODA KAHVALTI")
            {
                fiyat = 100;
            }
            if (comboOdaTuru.Text == "STANDART" && comboUyelik.Text == "HERSEY DAHİL")
            {
                fiyat = 150;
            }
            if (comboOdaTuru.Text == "STANDART" && comboUyelik.Text == "ULTRA HERSEY DAHİL")
            {
                fiyat = 200;
            }
            if (comboOdaTuru.Text == "SUIT" && comboUyelik.Text == "ODA KAHVALTI")
            {
                fiyat = 150;
            }
            if (comboOdaTuru.Text == "SUIT" && comboUyelik.Text == "HERSEY DAHİL")
            {
                fiyat = 200;
            }
            if (comboOdaTuru.Text == "SUIT" && comboUyelik.Text == "ULTRA HERSEY DAHİL")
            {
                fiyat = 250;
            }
            if (comboOdaTuru.Text == "DELUXE" && comboUyelik.Text == "ODA KAHVALTI")
            {
                fiyat = 250;
            }
            if (comboOdaTuru.Text == "DELUXE" && comboUyelik.Text == "HERSEY DAHİL")
            {
                fiyat = 300;
            }
            if (comboOdaTuru.Text == "DELUXE" && comboUyelik.Text == "ULTRA HERSEY DAHİL")
            {
                fiyat = 400;
            }
            int ucret;

            DateTime KucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikis.Text);
            TimeSpan fark;
            fark = BuyukTarih - KucukTarih;
            lblGun.Text = fark.TotalDays.ToString();
            int uc = Convert.ToInt32(lblGun.Text);
            ucret = uc * fiyat;
            lblTotal.Text = ucret.ToString();
        }
    }
}
 /*int fiyat = 0;
           if(comboOdaTuru.Text=="STANDART" && comboUyelik.Text=="ODA KAHVALTI")
           {fiyat=100;
           }
            if(comboOdaTuru.Text=="STANDART" && comboUyelik.Text=="HERSEY DAHİL")
            {
                fiyat = 150;
           }
            if (comboOdaTuru.Text == "STANDART" && comboUyelik.Text == "ULTRA HERSEY DAHİL")
            {
                fiyat = 200;
           }
            if (comboOdaTuru.Text == "SUIT" && comboUyelik.Text == "ODA KAHVALTI")
            {
                fiyat = 150;
           }
            if (comboOdaTuru.Text == "SUIT" && comboUyelik.Text == "HERSEY DAHİL")
            {
                fiyat = 200;
           }
            if (comboOdaTuru.Text == "SUIT" && comboUyelik.Text == "ULTRA HERSEY DAHİL")
            {
                fiyat = 250;
           }
            if (comboOdaTuru.Text == "DELUXE" && comboUyelik.Text == "ODA KAHVALTI")
            {
                fiyat = 250;
           }
            if (comboOdaTuru.Text == "DELUXE" && comboUyelik.Text == "HERSEY DAHİL")
            {
                fiyat = 300;
            }
            if (comboOdaTuru.Text == "DELUXE" && comboUyelik.Text == "ULTRA HERSEY DAHİL")
            {
                fiyat = 400;
            }
           int ucret;

            DateTime KucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikis.Text);
            TimeSpan fark;
            fark = BuyukTarih - KucukTarih;
            lblGun.Text = fark.TotalDays.ToString();
            int uc = Convert.ToInt32(lblGun.Text);
            ucret = uc * fiyat;
            lblTotal.Text = ucret.ToString(); */