using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmParcial
{
    public partial class FrmVistaPasajeros : Form
    {
        private FrmMdiPasajeros pasajerosRegionales;
        private FrmMdiPasajeros pasajerosExtraRegionales;
        public FrmVistaPasajeros()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            pasajerosRegionales = new FrmMdiPasajeros(true);
            pasajerosRegionales.MdiParent = this;
            pasajerosExtraRegionales = new FrmMdiPasajeros(false);
            pasajerosExtraRegionales.MdiParent = this;
        }

        private void viajeRegionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasajerosRegionales.Show();
            pasajerosExtraRegionales.Hide();
        }

        private void viajeExtraRegionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasajerosExtraRegionales.Show();
            pasajerosRegionales.Hide();
        }
    }
}
