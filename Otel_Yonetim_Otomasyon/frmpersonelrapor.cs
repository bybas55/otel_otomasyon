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
    public partial class frmpersonelrapor : Form
    {
        public frmpersonelrapor()
        {
            InitializeComponent();
        }

        private void frmpersonelrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet4.Personel' table. You can move, or remove it, as needed.
            this.PersonelTableAdapter.Fill(this.otelDataSet4.Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
