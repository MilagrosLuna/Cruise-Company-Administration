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
            this.usuarios = new List<User>();
            User u1 = new User("mili890m", "seguritix","milagros","luna",18,Sexo.Mujer);
            User u2 = new User("juanpedro90", "miabuelita1", "juan", "perez", 35, Sexo.NoBinario);
            User u3 = new User("martin89", "mundi2022", "martin", "sanchez", 28, Sexo.Hombre);
            User u4 = new User("vanesalopez", "coquitafria", "vanesa", "lopez", 42, Sexo.Mujer);

            User u5 = new User("a", "a", "milagros", "luna", 18, Sexo.Mujer);

            usuarios.Add(u1);
            usuarios.Add(u2);
            usuarios.Add(u3);
            usuarios.Add(u4);

            usuarios.Add(u5);
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                User aux = new User(textBox_User.Text, textBox_Pass.Text);
                foreach (User item in this.usuarios)
                {
                    if (item.Equals(aux))
                    {
                        this.bandera = 1;
                        this.Visible = false;
                        FormPrincipal frm = new FormPrincipal(item);  // consultar por 
                        frm.ShowDialog();
                        this.Close();
                    }
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
