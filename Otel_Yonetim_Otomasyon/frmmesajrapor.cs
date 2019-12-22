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
    public partial class frmmesajrapor : Form
    {
        public frmmesajrapor()
        {
            InitializeComponent();
        }

        private void frmmesajrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet1.Mesajlar' table. You can move, or remove it, as needed.
            this.MesajlarTableAdapter.Fill(this.otelDataSet1.Mesajlar);

            this.reportViewer1.RefreshReport();
        }
    }
}
