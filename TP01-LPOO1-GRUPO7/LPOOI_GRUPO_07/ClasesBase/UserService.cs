using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class UserService
    {

        public static Usuario Login(string usuario, string pass)
        {
            // instancia de roles
            Roles rol1 = new Roles(1, "Administrador");
            Roles rol2 = new Roles(2, "Operador");
            Roles rol3 = new Roles(3, "Auditor");

            // creacion de 3 usuarios para prueba
            Usuario usu1 = new Usuario(1, "jorge", "123", "tolaba", 1);
            Usuario usu2 = new Usuario(1, "juan", "123", "toconas", 2);
            Usuario usu3 = new Usuario(1, "pablo", "123", "perez", 3);

            var usuarios = new List<Usuario> { usu1, usu2, usu3 };

            return usuarios.FirstOrDefault(u => u.Usu_NombreUsuario == usuario && u.Usu_Contrasenia == pass);
        }

    }
}
