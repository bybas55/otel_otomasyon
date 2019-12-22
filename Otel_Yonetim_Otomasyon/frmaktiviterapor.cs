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
    public partial class frmaktiviterapor : Form
    {
        public frmaktiviterapor()
        {
            InitializeComponent();
        }

        private void frmaktiviterapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet3.AktiviteTablosu' table. You can move, or remove it, as needed.
            this.AktiviteTablosuTableAdapter.Fill(this.otelDataSet3.AktiviteTablosu);

            this.reportViewer1.RefreshReport();
        }
    }
}
