using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        // boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text; //asigancion a variables de user y contraseña
            string pass = txtContrasenia.Text;


            Usuario u = UserService.Login(user, pass);

            if (u != null)
            {
                Principal home = new Principal();
                home.Show();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var salir = MessageBox.Show("desea salir?", "Atencion", MessageBoxButtons.YesNo);

            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
