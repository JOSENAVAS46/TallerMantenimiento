using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMantenimiento.Modelo
{
    public class Integrante
    {
        public int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        public string Correo { get; set; }
        public string RutaImagen { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public Integrante(string nombre, string apellido, string correo, string rutaImagen)
        {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            RutaImagen = rutaImagen;
        }

    }
}
