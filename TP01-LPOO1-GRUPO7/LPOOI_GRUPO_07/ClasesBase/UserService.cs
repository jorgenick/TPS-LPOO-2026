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
            // creacion de 3 usuarios para prueba
            Usuario usu1 = new Usuario(1, "jorge", "123", "TOLABA", 1);
            Usuario usu2 = new Usuario(1, "juan", "123", "TOCONAS", 2);
            Usuario usu3 = new Usuario(1, "pablo", "123", "PEREZ", 3);

            var usuarios = new List<Usuario> { usu1, usu2, usu3 };

            return usuarios.FirstOrDefault(u => u.Usu_NombreUsuario == usuario && u.Usu_Contrasenia == pass);
        }

    }
}
