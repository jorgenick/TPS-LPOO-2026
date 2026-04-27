using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        public int Rol_Codigo { get; set; }
        public string Rol_Descripcion { get; set; }

        public Roles(int codigo, string descripcion)
        {
            this.Rol_Codigo = codigo;
            this.Rol_Descripcion = descripcion;
        }

        public static List<Roles> CargarRoles() {

            // creacion e instanciacion de lista de roles
            List<Roles> listaRoles = new List<Roles>();

            // instancia de roles
            Roles rol1 = new Roles(1, "Administrador");
            Roles rol2 = new Roles(2, "Operador");
            Roles rol3 = new Roles(3, "Auditor");

            // se agregan elementos a la lista de roles
            listaRoles.Add(rol1);
            listaRoles.Add(rol2);
            listaRoles.Add(rol3);

            return listaRoles;
        }

    }


}
