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

        // Boton Alta Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            var save = MessageBox.Show("desea guardar estos cambios?", "Atencion", MessageBoxButtons.YesNo);
            if (save == DialogResult.Yes)
            {

                string nombre = txtNombreUsuario.Text;
                string apellido = txtApellidoUsuario.Text;
                string dni = txtDniUsuario.Text;
                string direccion = txtDireccion.Text;
                string cuit = txtCuit.Text;
                string nCarnet = txtCarnet.Text;

                MessageBox.Show("USUARIO REGISTRADO! \nNOMBRE: " + nombre + "\nAPELLIDO: " + apellido +
                    "\nDNI: " + dni + "\nDIRECCION: " + direccion + "\nCUIT: " + cuit
                     + "\nNº DE CARNET : " + nCarnet);
            }

        }

        // Boton Atras
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
