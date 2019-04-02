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
    public partial class OtelAra : Form
    {
        public OtelAra()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayıtOl kayıtOl = new KayıtOl();
            kayıtOl.Show();
            this.Hide();
        }

        private void BtnOtelSehirAra_Click(object sender, EventArgs e)
        {

        }

        private void DgwOtelİsimleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OtelRezervasyon otelRezervasyon = new OtelRezervasyon();
            otelRezervasyon.Show();
            this.Hide();
        }
    }
}
