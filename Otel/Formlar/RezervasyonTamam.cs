using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.Formlar
{
    public partial class RezervasyonTamam : Form
    {
        public RezervasyonTamam()
        {
            InitializeComponent();
        }

        private void BtnTamamla_Click(object sender, EventArgs e)
        {
            OdemeIslemi odemeIslemi = new OdemeIslemi();
            odemeIslemi.Show();
            this.Hide();
        }
    }
}
