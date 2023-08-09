using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMantenimiento.Modelo
{
    class Repuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Repuesto(string nombreRepuesto, double precioRepuesto)
        {
            this.Nombre = nombreRepuesto;
            this.Precio = precioRepuesto;
        }

        public override string ToString()
        {
            return string.Format("{0} | ${1} ",
                this.Nombre,
                this.Precio);
        }

    }


}
