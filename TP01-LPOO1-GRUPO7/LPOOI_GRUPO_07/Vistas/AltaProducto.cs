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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {

            var save = MessageBox.Show("desea guardar estos cambios?", "Atencion", MessageBoxButtons.YesNo);

            if (save == DialogResult.Yes)
            {

                string codigo = txtCodigo.Text;
                string categoria = txtCategoria.Text;
                string descripcion = txtDescripcion.Text;
                string precio = txtPrecio.Text;

                MessageBox.Show("PRODUCTO REGISTRADO! \nCODIGO : " + codigo + "\nCATEGORIA : " + categoria + "\nDESCRIPCION : "+descripcion+"\nPRECIO: "+precio);
            }



        }

        private void btnCancelarAltaProducto_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }

   
}
