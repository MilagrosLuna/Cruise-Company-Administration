﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesParcial;
namespace FrmParcial
{
    public partial class FormPrincipal : Form
    {
        private FrmInicioVenta frmVenta;
       
        private FrmViajesDisponibles frmViajesDisponibles; 

        private FrmCreaViaje frmCreaViaje;

        private FrmEstadisticas frmEstadisticas;

        private FrmAgregaCrucero agregaCrucero;

        public FormPrincipal(User user)
        {
            InitializeComponent();
            this.frmVenta = new FrmInicioVenta();
            this.frmViajesDisponibles = new FrmViajesDisponibles();
            this.frmCreaViaje = new FrmCreaViaje();
            this.frmEstadisticas = new FrmEstadisticas();
            this.agregaCrucero = new FrmAgregaCrucero();
            this.textBox1.Text = user.NombreCompeto;
            User aux = null;

            foreach (User item in Compañia.usuarios)
            {
                if (item.Nombre == "Sara" )
                {
                    aux = item;
                    break;
                }
            }
            this.button_crearCrucero.Enabled = false;
            this.textBox_admin.Text = "No es admin";
            if (user==aux)
            {
                this.button_crearCrucero.Enabled = true;
                this.textBox_admin.Text = "Es admin";
            }
            

        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.textBox2.Text = DateTime.Today.ToShortDateString();
            this.agregaCrucero.Text = "Agrega Crucero";
            this.frmVenta.Text = "Venta Pasaje";
            this.frmCreaViaje.Text = "Crear Viaje";
            this.frmViajesDisponibles.Text = "Viajes Disponibles";
            this.frmEstadisticas.Text = "Estadisticas historicas";
        }

        private void button_ventaPasaje_Click(object sender, EventArgs e)
        {
            frmVenta.ShowDialog();
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir de la aplicacion?", "atencion!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button_ViajesDisponibles_Click(object sender, EventArgs e)
        {
            
            frmViajesDisponibles.ShowDialog();
        }

        private void button_crearViaje_Click(object sender, EventArgs e)
        {
            frmCreaViaje.ShowDialog();
        }

        private void button_verPasajeros_Click(object sender, EventArgs e)
        {
            FrmVistaPasajeros vistaPasajeros = new FrmVistaPasajeros();
            vistaPasajeros.ShowDialog();
        }

        private void button_estadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas.ShowDialog();
        }

        private void button_crearCrucero_Click(object sender, EventArgs e)
        {
            agregaCrucero.ShowDialog();
        }
    }
}
