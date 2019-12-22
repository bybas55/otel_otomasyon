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
    public partial class frmkullanicigiris : Form
    {
        public frmkullanicigiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=otel;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
           
            try
            {
                baglanti.Open();
                string sql = "select * from Kullanici_Giris where KullaniciAdi=@Kullanici AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullanici", txtKullanici.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    frmAnaform fr = new frmAnaform();
                    fr.yetkidurumu = Convert.ToInt32(dt.Rows[0]["Yetki"].ToString());
                    fr.kim = Convert.ToInt32(dt.Rows[0]["Kullanici_id"].ToString());
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmkullanicigiris_Load(object sender, EventArgs e)
        {

        }
    }
}
