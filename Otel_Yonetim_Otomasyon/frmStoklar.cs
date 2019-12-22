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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");
        int id = 0;
        private void BtnBilgiler_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stok (StokAdi,Cinsi,StokAdetKilo,Odenen,StokTarihi,Personel) values ('" + txtstokadi.Text + "','" + txtcinsi.Text + "','" + txtadet.Text + "','" + txtodenen.Text + "','" + dtptarih.Value.ToString("yyyy-MM-dd") + "','" + txtpersonel.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Stok Kaydı Yapıldı");
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtstokadi.Text = "";
            txtcinsi.Text = "";
            txtadet.Text = "";
            txtodenen.Text = "";
            dtptarih.Text = "";
            txtpersonel.Text = "";
        }
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stok", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Stokid"].ToString();
                ekle.SubItems.Add(oku["StokAdi"].ToString());
                ekle.SubItems.Add(oku["Cinsi"].ToString());
                ekle.SubItems.Add(oku["StokAdetKilo"].ToString());
                ekle.SubItems.Add(oku["Odenen"].ToString());
                ekle.SubItems.Add(oku["StokTarihi"].ToString());
                ekle.SubItems.Add(oku["Personel"].ToString());


                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtstokadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtcinsi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtadet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtodenen.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dtptarih.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtpersonel.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Stok where Stokid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stok where StokAdi like '%" + txtstokara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Stokid"].ToString();
                ekle.SubItems.Add(oku["StokAdi"].ToString());
                ekle.SubItems.Add(oku["Cinsi"].ToString());
                ekle.SubItems.Add(oku["StokAdetKilo"].ToString());
                ekle.SubItems.Add(oku["Odenen"].ToString());
                ekle.SubItems.Add(oku["StokTarihi"].ToString());
                ekle.SubItems.Add(oku["Personel"].ToString());


                listView1.Items.Add(ekle);


            } baglanti.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Stok set StokAdi='" + txtstokadi.Text + "',Cinsi='" + txtcinsi.Text + "',StokAdetKilo='" + txtadet.Text + "',Odenen='" + txtodenen.Text + "',StokTarihi='" + dtptarih.Value.ToString("yyyy-MM-dd") + "',Personel='" + txtpersonel.Text + "' where Stokid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmstokrapor fr = new frmstokrapor();
            fr.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            frmstokrapor fr = new frmstokrapor();
            fr.Show();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stok where StokTarihi between  '" + dtp1.Value.ToString("yyyy-MM-dd") + "' and '" + dtp2.Value.ToString("yyyy-MM-dd") + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Stokid"].ToString();
                ekle.SubItems.Add(oku["StokAdi"].ToString());
                ekle.SubItems.Add(oku["Cinsi"].ToString());
                ekle.SubItems.Add(oku["StokAdetKilo"].ToString());
                ekle.SubItems.Add(oku["Odenen"].ToString());
                ekle.SubItems.Add(oku["StokTarihi"].ToString());
                ekle.SubItems.Add(oku["Personel"].ToString());


                listView1.Items.Add(ekle);


            } baglanti.Close();
        }
    }
}
