using System;
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
    public partial class FrmLogin : Form
    {
        private List<User> usuarios;
        private int bandera=0;


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.usuarios = Compañia.usuarios;
           
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            int correcto = 0;
            if (Validar())
            {
                User aux = new User(textBox_User.Text, textBox_Pass.Text);
                foreach (User item in this.usuarios)
                {
                    if (item.Equals(aux))
                    {
                        correcto = 1;
                        this.bandera = 1;
                        this.Visible = false;
                        FormPrincipal frm = new FormPrincipal(item);  // consultar por 
                        frm.ShowDialog();
                        this.Close();
                    }
      
                }
                if(correcto==0)
                {
                    MessageBox.Show("datos no validos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(textBox_User.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Usuario");
            }

            if (string.IsNullOrWhiteSpace(textBox_Pass.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Contraseña");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bandera == 0)
            {
                if (MessageBox.Show("¿Esta seguro de salir de la aplicacion?", "atencion!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        
    }
}
