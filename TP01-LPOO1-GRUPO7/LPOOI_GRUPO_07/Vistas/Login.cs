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
        // instancia de roles
        Roles rol1 = new Roles(1, "Administrador");
        Roles rol2 = new Roles(2, "Operador");
        Roles rol3 = new Roles(3, "Auditor");

        // creacion de 3 usuarios para prueba
        Usuario usu1 = new Usuario(1, "jorge", "123", "tolaba", 1);
        Usuario usu2 = new Usuario(1, "juan", "123", "toconas", 2);
        Usuario usu3 = new Usuario(1, "pablo", "123", "perez", 3);

        public Login()
        {
            InitializeComponent();
        }

        // boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text; //asigancion a variables de user y contraseña
            string pass = txtContrasenia.Text;


            //---PUNTO 6---
            // validacion de nombre y usuario 
            if (user == usu1.Usu_NombreUsuario && pass == usu1.Usu_Contrasenia)
            {
                MessageBox.Show("BIENVENIDO USUARIO ADMINISTRADOR!");
                Principal principal = new Principal();
                principal.Show(); //---PUNTO 7---

            }
            else if (user == usu2.Usu_NombreUsuario && pass == usu2.Usu_Contrasenia)
            {
                MessageBox.Show("BIENVENIDO USUARIO OPERADOR!");
                Principal principal = new Principal();
                principal.Show(); //---PUNTO 7---

            }
            else if (user == usu3.Usu_NombreUsuario && pass == usu3.Usu_Contrasenia)
            {
                MessageBox.Show("BIENVENIDO USUARIO AUDITOR!");
                Principal principal = new Principal();
                principal.Show(); //---PUNTO 7---
            }

            else
            {
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
