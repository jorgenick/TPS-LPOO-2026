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
            List<Roles> listaRolex = Roles.CargarRoles();

            string user = txtUsuario.Text; //asigancion a variables de user y contraseña
            string pass = txtContrasenia.Text;

            Usuario u = UserService.Login(user, pass);

            if (u != null)
            {
                MessageBox.Show("BIENVENIDO " + u.Usu_NombreUsuario + 
                    "\nUSUARIO : " + (listaRolex.FirstOrDefault(ro => ro.Rol_Codigo == u.Rol_Codigo).Rol_Descripcion));
                Principal home = new Principal(u);
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
