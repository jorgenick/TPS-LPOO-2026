using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Producto
    {

        public string Prod_Codigo { get; set; }
        public string Prod_Categoria { get; set; }
        public string Prod_Descripcion { get; set; }
        public decimal Prod_Precio { get; set; }

        public Producto(string codigo, string categoria, string descripcion, decimal precio)
        {
            this.Prod_Codigo = codigo;
            this.Prod_Categoria = categoria;
            this.Prod_Descripcion = descripcion;
            this.Prod_Precio = precio;
        }
    }
}
