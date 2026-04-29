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
    public partial class AltaObraSocial : Form
    {
        public AltaObraSocial()
        {
            InitializeComponent();
        }

        private void btnAltaObraSocial_Click(object sender, EventArgs e)
        {
            string cuit = txtCIUT.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            string razonS = txtRazonSocial.Text;

            var save = MessageBox.Show("desea guardar estos cambios?", "Atencion", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {

                MessageBox.Show("CUIT: "+cuit+"\nDIRECCION: "+direccion+"\nRAZON SOCIAL : "+razonS+"\nTELEFONO : "+telefono);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("se agrega un boton de prueba1");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("se crea otro boton de alta de obra social");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("botones de alta de obra social ");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("botones de alta de obra social ");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("Se agrega un boton de prueba 2");
            Console.WriteLine("botones de alta de obra social ");

        }
    }
}
