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
    public partial class frmstokrapor : Form
    {
        public frmstokrapor()
        {
            InitializeComponent();
        }

        private void frmstokrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet6.Stok' table. You can move, or remove it, as needed.
            this.StokTableAdapter.Fill(this.otelDataSet6.Stok);
            // TODO: This line of code loads data into the 'otelDataSet2.Stoklar' table. You can move, or remove it, as needed.
            this.StoklarTableAdapter.Fill(this.otelDataSet2.Stoklar);

            this.reportViewer1.RefreshReport();
        }
    }
}
