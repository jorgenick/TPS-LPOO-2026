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
    public partial class Principal : Form
    {

        private Usuario usuarioLog;

        public Principal(Usuario usuLogueado)
        {
            InitializeComponent();
            usuarioLog = usuLogueado;
        }


        // Boton ALTA CLIENTE
        private void button1_Click(object sender, EventArgs e)
        {
            AltaCliente altaCliente = new AltaCliente();
            altaCliente.Show();
        }

        // Boton ALTA PRODUCTO
        private void button2_Click(object sender, EventArgs e)
        {

            AltaProducto altaProducto = new AltaProducto();
            altaProducto.Show();
        }

        // Boton ALTA OBRA SOCIAL
        private void button3_Click(object sender, EventArgs e)
        {
            AltaObraSocial altaObraSocial = new AltaObraSocial();
            altaObraSocial.Show();

        }


        private void Principal_Load(object sender, EventArgs e)
        {

            etiquetaBienvenida.Text = "HOLA JORGE "+usuarioLog.Usu_ApellidoNombre;
        }




    }
}
