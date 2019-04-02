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
    public partial class OtelRezervasyon : Form
    {
        public OtelRezervasyon()
        {
            InitializeComponent();
        }

        private void t_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnYorum_Click(object sender, EventArgs e)
        {
            Yorumlar yorumlar = new Yorumlar();
            yorumlar.Show();
            this.Hide();
        }

        private void BtnRezervasyon_Click(object sender, EventArgs e)
        {
            RezervasyonTamam rezervasyonTamam = new RezervasyonTamam();
            rezervasyonTamam.Show();
            this.Hide();
        }
    }
}
