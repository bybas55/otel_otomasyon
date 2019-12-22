using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Yonetim_Otomasyon
{
    public partial class frmAnaform : Form
    {
        public frmAnaform()
        {
            InitializeComponent();
        }
        public int yetkidurumu;
        public int kim;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if(yetkidurumu==0 || yetkidurumu==2)
            {frmYeniMusteri fr=new frmYeniMusteri();
            fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(yetkidurumu==0 || yetkidurumu==3)
            {frmAktiviteler fr = new frmAktiviteler();
            fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            }

        

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0 || yetkidurumu == 1 || yetkidurumu==2)
            {
                frmOdalar fr = new frmOdalar();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0 || yetkidurumu == 1 || yetkidurumu == 2)
            {
                frmMusteriler fr = new frmMusteriler();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0 || yetkidurumu == 1 || yetkidurumu == 2)
            {
                frmStoklar fr = new frmStoklar();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0 || yetkidurumu == 1)
            {
                frmMuhasebe fr = new frmMuhasebe();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0 || yetkidurumu == 5)
            {
                frmCafeBar fr = new frmCafeBar();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0 || yetkidurumu == 4)
            {
                frmSpaMasaj fr = new frmSpaMasaj();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (yetkidurumu == 0)
            {
                frmKullaniciislemleri fr = new frmKullaniciislemleri();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Bu menüyü açmaya yetkili değilsiniz");
            } 

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMesajlar fr = new frmMesajlar();
            fr.Show();

        }

        private void frmAnaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmkullanicigiris fr = new frmkullanicigiris();
            fr.Show();
            this.Hide();
        }
    }
}
