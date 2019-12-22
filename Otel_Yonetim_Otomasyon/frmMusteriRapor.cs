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
    public partial class frmMusteriRapor : Form
    {
        public frmMusteriRapor()
        {
            InitializeComponent();
        }

        private void frmMusteriRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.MusterilerTableAdapter.Fill(this.otelDataSet.Musteriler);

            this.reportViewer1.RefreshReport();
        }
    }
}
