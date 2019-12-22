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
    public partial class frmCafeBar : Form
    {
        public frmCafeBar()
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




            } baglanti.Close();

            if (lblUyelik.Text=="HERSEY DAHİL")
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
                checkBox14.Enabled = false;
                checkBox15.Enabled = true;
                checkBox16.Enabled = true;
                checkBox17.Enabled = true;
                checkBox18.Enabled = true;
                checkBox19.Enabled = true;
                checkBox20.Enabled = true;
                checkBox21.Enabled = false;
                checkBox22.Enabled = false;
                checkBox23.Enabled = false;
                checkBox24.Enabled = false;


                checkBox25.Enabled = false;
                checkBox26.Enabled = false;
                checkBox27.Enabled = false;
                checkBox28.Enabled = false;
                checkBox29.Enabled = false;
                checkBox30.Enabled = false;
            }
            else if (lblUyelik.Text=="ULTRA HERSEY DAHİL")
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
                checkBox14.Enabled = false;
                checkBox15.Enabled = false;
                checkBox16.Enabled = false;
                checkBox17.Enabled = false;
                checkBox18.Enabled = false;
                checkBox19.Enabled = false;
                checkBox20.Enabled = false;
                checkBox21.Enabled = false;
                checkBox22.Enabled = false;
                checkBox23.Enabled = false;
                checkBox24.Enabled = false;


                checkBox25.Enabled = false;
                checkBox26.Enabled = false;
                checkBox27.Enabled = false;
                checkBox28.Enabled = false;
                checkBox29.Enabled = false;
                checkBox30.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
                checkBox13.Enabled = true;
                checkBox14.Enabled = true;
                checkBox15.Enabled = true;
                checkBox16.Enabled = true;
                checkBox17.Enabled = true;
                checkBox18.Enabled = true;
                checkBox19.Enabled = true;
                checkBox20.Enabled = true;
                checkBox21.Enabled = true;
                checkBox22.Enabled = true;
                checkBox23.Enabled = true;
                checkBox24.Enabled = true;


                checkBox25.Enabled = true;
                checkBox26.Enabled = true;
                checkBox27.Enabled = true;
                checkBox28.Enabled = true;
                checkBox29.Enabled = true;
                checkBox30.Enabled = true;
            }
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



            } baglanti.Close();
        }
        public int ham = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            txtyiyecek.Text = checkBox1.Text;
            ham = 15;
        }
        public int tost = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtyiyecek.Text = checkBox2.Text;
            tost = 10;
        }
        public int san = 0;
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            txtyiyecek.Text = checkBox3.Text;
            san = 10;
        }
        public int cips = 0;
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            txtyiyecek.Text = checkBox4.Text;
            cips = 8;
        }
        public int su, soda, fanta, kola, meyve = 0;
        public int yerli = 0;
        public int yabanci = 0;
        public int kok = 0;
        public int sicak = 0;

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            txtSoguk.Text = checkBox8.Text;
            su = 2;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            txtSoguk.Text = checkBox7.Text;
            soda=3;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            txtSoguk.Text = checkBox6.Text;
            kola = 7;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            txtSoguk.Text = checkBox5.Text;
            fanta = 7;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            txtSoguk.Text = checkBox9.Text;
            meyve = 7;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            txtYerli.Text = checkBox10.Text;
            yerli = 15;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            txtYerli.Text = checkBox11.Text;
            yerli = 15;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            txtYerli.Text = checkBox12.Text;
            yerli = 15;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            txtYerli.Text = checkBox13.Text;
            yerli = 15;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            txtYerli.Text = checkBox14.Text;
            yerli = 15;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            txtYabanci.Text = checkBox15.Text;
            yabanci = 20;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            txtYabanci.Text = checkBox16.Text;
            yabanci = 20;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            txtYabanci.Text = checkBox17.Text;
            yabanci = 20;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            txtYabanci.Text = checkBox18.Text;
            yabanci = 20;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            txtYabanci.Text = checkBox19.Text;
            yabanci = 20;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            txtYabanci.Text = checkBox20.Text;
            yabanci = 20;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            txtSicak.Text = checkBox24.Text;
            sicak = 12;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            txtSicak.Text = checkBox23.Text;
            sicak = 12;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            txtSicak.Text = checkBox22.Text;
            sicak = 12;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            txtSicak.Text = checkBox21.Text;
            sicak = 12;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            txtSicak.Text = checkBox25.Text;
            sicak = 12;
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            txtKokteyl.Text = checkBox29.Text;
            kok = 20;
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            txtKokteyl.Text = checkBox28.Text;
            kok = 20;
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            txtKokteyl.Text = checkBox27.Text;
            kok = 20;
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            txtKokteyl.Text = checkBox26.Text;
            kok = 20;
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            txtKokteyl.Text = checkBox30.Text;
            kok = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
                int yemek = 0;
                int yeadet = Convert.ToInt32(txtyiyecekadet.Text);
                yemek = (ham + tost + san + cips) * yeadet;

                int sogukicecek = 0;
                int icadet = Convert.ToInt32(txtsogukadet.Text);
                sogukicecek = (su + soda + kola + meyve + fanta) * icadet;

                int yrliadet = Convert.ToInt32(txtYerAdet.Text);
                int yabanciadet = Convert.ToInt32(txtYabadet.Text);
                int sicakadet = Convert.ToInt32(txtSicakAdet.Text);
                int kokadet = Convert.ToInt32(txtKokAdet.Text);
                int tutar = 0;
                tutar = (yabanci * yabanciadet) + yemek + sogukicecek + (yerli * yrliadet) + (sicak * sicakadet) + (kok * kokadet);
                txtTutar.Text = tutar.ToString();
            
          //  txtYerAdet.Text = "1";
          //  txtYabadet.Text = "1";
          //  txtsogukadet.Text = "1";
         //   txtyiyecekadet.Text = "1";
         //   txtSicakAdet.Text = "1";
        //    txtKokAdet.Text = "1";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                baglanti.Open();
                SqlCommand komutekle = new SqlCommand("insert into Sipariss (Rezervasyon_id,Yiyecek,İcecek,Soguk_icecek,Kokteyl,Yerli,Yabanci,Ucret) values ('" + txtRezervasyon.Text + "','" + txtyiyecek.Text + "','" + txtSicak.Text + "','" + txtSoguk.Text + "','" + txtKokteyl.Text + "','" + txtYerli.Text + "','" + txtYabanci.Text + "','" + txtTutar.Text + "')", baglanti);
                komutekle.ExecuteNonQuery();
                baglanti.Close();
            
            
        }
    }
}
