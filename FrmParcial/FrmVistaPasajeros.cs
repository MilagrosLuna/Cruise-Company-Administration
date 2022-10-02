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
        private FrmPasajeroFiltrado pasajeroFiltrado;
        public FrmVistaPasajeros()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            pasajerosRegionales = new FrmMdiPasajeros(true);
            pasajerosRegionales.MdiParent = this;
            pasajerosExtraRegionales = new FrmMdiPasajeros(false);
            pasajerosExtraRegionales.MdiParent = this;
            pasajeroFiltrado = new FrmPasajeroFiltrado();
            pasajeroFiltrado.MdiParent = this;
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

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasajeroFiltrado.CambiarBandera(0);
            pasajeroFiltrado.Show();
        }

        private void pasaporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasajeroFiltrado.CambiarBandera(1);
            pasajeroFiltrado.Show();
        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasajeroFiltrado.CambiarBandera(2);
            pasajeroFiltrado.Show();
        }

        private void apellidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasajeroFiltrado.CambiarBandera(3);
            pasajeroFiltrado.Show();
        }

    }
}
