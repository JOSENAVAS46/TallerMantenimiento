using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMantenimiento.Modelo
{
    class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Servicio(string nombreServicio, double precioServicio)
        {
            this.Nombre = nombreServicio;
            this.Precio = precioServicio;
        }
        public override string ToString()
        {
            return string.Format("{0} | ${1}", 
                this.Nombre, 
                this.Precio);
        }
    }
}
