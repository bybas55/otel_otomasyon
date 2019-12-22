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
    public partial class frmgiderler : Form
    {
        public frmgiderler()
        {
            InitializeComponent();
        }

        private void frmgiderler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet5.Giderler' table. You can move, or remove it, as needed.
            this.GiderlerTableAdapter.Fill(this.otelDataSet5.Giderler);

            this.reportViewer1.RefreshReport();
        }
    }
}
