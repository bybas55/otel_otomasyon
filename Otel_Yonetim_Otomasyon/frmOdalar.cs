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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");
        private void frmOdalar_Load(object sender, EventArgs e)
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
                
                btn309.BackColor = Color.Transparent;
            }
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            if (btn101.Text == "101")
            { lblAd.Text="Boş";
            }
            else
            {
                lblAd.Text = btn101.Text;
            }

            lblOda.Text = "101";
            lblAlan.Text = "40 metrekare";
            
            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            if (btn102.Text == "102")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn102.Text;
            }

            lblOda.Text = "102";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            if (btn103.Text == "103")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn103.Text;
            }

            lblOda.Text = "103";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            if (btn104.Text == "104")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn104.Text;
            }

            lblOda.Text = "104";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            if (btn105.Text == "105")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn105.Text;
            }

            lblOda.Text = "105";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            if (btn106.Text == "106")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn106.Text;
            }

            lblOda.Text = "106";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            if (btn107.Text == "107")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn107.Text;
            }

            lblOda.Text = "107";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            if (btn108.Text == "108")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn108.Text;
            }

            lblOda.Text = "108";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            if (btn109.Text == "109")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn109.Text;
            }

            lblOda.Text = "109";
            lblAlan.Text = "40 metrekare";

            lblTip.Text = "STANDART";
            lblKat.Text = "1.Kat";
            resimStandart.Visible = true;
            resimDeluxe.Visible = false;
            resimSuit.Visible = false;
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            if (btn201.Text == "201")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn201.Text;
            }

            lblOda.Text = "201";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            if (btn202.Text == "202")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn202.Text;
            }

            lblOda.Text = "202";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            if (btn203.Text == "203")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn203.Text;
            }

            lblOda.Text = "203";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            if (btn204.Text == "204")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn204.Text;
            }

            lblOda.Text = "204";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            if (btn205.Text == "205")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn205.Text;
            }

            lblOda.Text = "205";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn206_Click(object sender, EventArgs e)
        {
            if (btn206.Text == "206")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn206.Text;
            }

            lblOda.Text = "201";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn207_Click(object sender, EventArgs e)
        {
            if (btn207.Text == "207")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn207.Text;
            }

            lblOda.Text = "207";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn208_Click(object sender, EventArgs e)
        {
            if (btn208.Text == "208")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn201.Text;
            }

            lblOda.Text = "208";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn209_Click(object sender, EventArgs e)
        {
            if (btn209.Text == "209")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn209.Text;
            }

            lblOda.Text = "209";
            lblAlan.Text = "60 metrekare";

            lblTip.Text = "SUIT";
            lblKat.Text = "2.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = false;
            resimSuit.Visible = true;
        }

        private void btn301_Click(object sender, EventArgs e)
        {
            if (btn301.Text == "301")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn301.Text;
            }

            lblOda.Text = "301";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn302_Click(object sender, EventArgs e)
        {
            if (btn302.Text == "302")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn302.Text;
            }

            lblOda.Text = "302";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn303_Click(object sender, EventArgs e)
        {
            if (btn303.Text == "303")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn303.Text;
            }

            lblOda.Text = "303";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn304_Click(object sender, EventArgs e)
        {
            if (btn304.Text == "304")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn304.Text;
            }

            lblOda.Text = "304";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn305_Click(object sender, EventArgs e)
        {
            if (btn305.Text == "305")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn305.Text;
            }

            lblOda.Text = "305";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn306_Click(object sender, EventArgs e)
        {
            if (btn306.Text == "306")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn306.Text;
            }

            lblOda.Text = "306";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn307_Click(object sender, EventArgs e)
        {
            if (btn307.Text == "307")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn307.Text;
            }

            lblOda.Text = "307";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn308_Click(object sender, EventArgs e)
        {
            if (btn308.Text == "308")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn308.Text;
            }

            lblOda.Text = "308";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }

        private void btn309_Click(object sender, EventArgs e)
        {
            if (btn309.Text == "309")
            {
                lblAd.Text = "Boş";
            }
            else
            {
                lblAd.Text = btn309.Text;
            }

            lblOda.Text = "309";
            lblAlan.Text = "80 metrekare";

            lblTip.Text = "DELUXE";
            lblKat.Text = "3.Kat";
            resimStandart.Visible = false;
            resimDeluxe.Visible = true;
            resimSuit.Visible = false;
        }
    }
}
