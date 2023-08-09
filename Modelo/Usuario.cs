using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMantenimiento.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public Usuario(string username, string password, string nombre, string apellido)
        {
            Username = username;
            Password = password;
            Nombre = nombre;
            Apellido = apellido;
        }
    }

}
