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


        // boton aceptar de Login
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Roles> listaRoles = new List<Roles>();

            Roles rol1 = new Roles(1, "ADMINISTRADOR");
            Roles rol2 = new Roles(1, "OPERADOR");
            Roles rol3 = new Roles(1, "AUDITOR");

            listaRoles.Add(rol1);
            listaRoles.Add(rol2);
            listaRoles.Add(rol3);

            string user = txtUsuario.Text; //asigancion a variables de user y contraseña
            string pass = txtContrasenia.Text;

            Usuario u = UserService.Login(user, pass);

            if (u != null)
            {

                MessageBox.Show("BIENVENIDO "+u.Usu_NombreUsuario+"\nUSUARIO : "+u.Rol_Codigo);
                Principal home = new Principal();
                home.Show();

                this.Hide();
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
