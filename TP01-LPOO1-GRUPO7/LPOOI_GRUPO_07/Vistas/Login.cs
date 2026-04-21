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
        Roles rol1 = new Roles(1, "Administrador");
        Roles rol2 = new Roles(2, "Operador");
        Roles rol3 = new Roles(3, "Auditor");

        Usuario oUsu = new Usuario(1, "jorge", "123", "tolaba", 2);



        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContrasenia.Text;

            if (user == "jorge" && pass == "123")
            {
                MessageBox.Show("Usuario y contraseña ingresada correctamente!");
                Principal principal = new Principal();
                principal.Show();

            }
            else {

                MessageBox.Show("ERROR AL INGRESAR USUARIO/CONTRASEÑA");
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
