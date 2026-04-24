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
            var salir = MessageBox.Show("desea guardar estos cambios?", "Atencion", MessageBoxButtons.YesNo);

            if (salir == DialogResult.Yes)
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

        }




    }
}
