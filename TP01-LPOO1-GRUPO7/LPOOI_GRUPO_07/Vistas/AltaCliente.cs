using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreUsuario.Text;
            string apellido = txtApellidoUsuario.Text;
            string dni = txtDniUsuario.Text;

            MessageBox.Show("USUARIO REGISTRADO \n nombre: "+nombre+"\napellido: "+apellido+"\nDNI: "+dni);


        }

    }
}
