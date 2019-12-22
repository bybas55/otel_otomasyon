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
    public partial class frmMesajlar : Form
    {
        public frmMesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Mesajlar (Ad,Soyad,Mesaj,Tarih) values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + richTextBox1.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesaj Kaydı Yapıldı");
            verilerigoster();
        }
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesaj_id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());

                listView1.Items.Add(ekle);


            } baglanti.Close();

        }

        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Mesajlar set  Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',Mesaj='" + richTextBox1.Text + "',Tarih='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' where Mesaj_id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }
        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Mesajlar where Mesaj_id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Mesajlar where Ad='" + txtAd.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesaj_id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());


                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;

            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmmesajrapor fr = new frmmesajrapor();
            fr.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmmesajrapor fr = new frmmesajrapor();
            fr.Show();
        }
    }
}
