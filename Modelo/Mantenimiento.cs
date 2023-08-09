using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMantenimiento.Modelo
{
    class Mantenimiento
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string Diagnostico { get; set; }
        public string Tipo { get; set; }
        public List<Repuesto> ListaRespuesto { get; set; }
        public List<Servicio> ListaServicio { get; set; }
        public double Precio { get; set; }

        private double PrecioMantenimiento = 50;

        public Mantenimiento(
            Cliente cliente,
            Mecanico mecanico,
            Vehiculo vehiculo,
            DateTime fecha,
            string diagnostico,
            string tipo,
            List<Repuesto> listaRespuesto,
            List<Servicio> listaServicio
            )
        {
            Cliente = cliente;
            Mecanico = mecanico;
            Vehiculo = vehiculo;
            Diagnostico = diagnostico;
            FechaMantenimiento = fecha;
            Tipo = tipo;
            ListaRespuesto = listaRespuesto;
            ListaServicio = listaServicio;
            Precio = obtenerPrecioTotal(12, (this.PrecioMantenimiento + sumaPreciosRespuesto() + sumaPreciosServicios()));
            Codigo = generarCodigo();
        }

        public string generarCodigo()
        {
            try
            {
                return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}"
                , this.Vehiculo.Placa.Substring(0, 3)
                , this.Vehiculo.Marca.Substring(0, 2)
                , this.Vehiculo.Modelo.Substring(0, 2)
                , this.Vehiculo.Color.Substring(0, 2)
                , this.Cliente.Nombre.Substring(0, 1)
                , this.Cliente.Apellido.Substring(0, 1)
                , this.Mecanico.Nombre.Substring(0, 1)
                , this.Mecanico.Apellido.Substring(0, 1)).ToUpper();
            } catch (Exception)
            {
                return "N/A";
            }
        }


        public double sumaPreciosServicios()
        {
            return ListaServicio.Sum(Servicio => Servicio.Precio);
        }

        public double sumaPreciosRespuesto()
        {
            return ListaRespuesto.Sum(Respuesto => Respuesto.Precio);
        }

        public string servicios()
        {
            StringBuilder sb = new StringBuilder();
            if (this.ListaServicio.Count > 0)
            {
                foreach (Servicio item in this.ListaServicio)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            else
            {
                sb.AppendLine("N/A");
            }
            return sb.ToString();
        }
        public string repuestos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Repuesto item in this.ListaRespuesto)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            string strMantenimiento = "";
            if (this.Tipo == "Correctivo")
            {
                strMantenimiento =
                    string.Format(
                "--Mantenimiento--" +
                "\nCodigo: {0}" +
                "\nDatos del Cliente {1}" +
                "\nMecanico: {2}" +
                "\nDatos del Vehiculo: {3}" +
                "\nFecha: {4}" +
                "\nDiagnostico: {5}" +
                "\nTipo: {6}" +
                "\n\n--Servicios-- \n{7}" +
                "\n\n--Repuestos-- \n{8}" +
                "\nPrecio Mantenimiento : ${9}" +
                "\nPrecio Total : ${10}"+
                "\n***Precio Total Incluido IVA (12%)***",
                this.Codigo
                , this.Cliente.obtenerDatos()
                , this.Mecanico.ToString()
                , this.Vehiculo.ToString()
                , this.FechaMantenimiento
                , this.Diagnostico
                , this.Tipo
                , servicios()
                , repuestos()
                , this.PrecioMantenimiento
                , this.Precio);
            }
            else if (this.Tipo == "Preventivo")
            {
                strMantenimiento =
                    string.Format(
                "--Mantenimiento--" +
                "\nCodigo: {0}" +
                "\nDatos del Cliente {1}" +
                "\nMecanico: {2}" +
                "\nDatos del Vehiculo: {3}" +
                "\nFecha: {4}" +
                "\nDiagnostico: {5}" +
                "\nTipo: {6}" +
                "\n\n--Servicios-- \n{7}" +
                "\nPrecio Mantenimiento : ${8}"+
                "\nPrecio Total : ${9}" +
                "\n***Precio Total Incluido IVA (12%)***",
                this.Codigo
                , this.Cliente.obtenerDatos()
                , this.Mecanico.ToString()
                , this.Vehiculo.ToString()
                , this.FechaMantenimiento
                , this.Diagnostico
                , this.Tipo
                , servicios()
                , this.PrecioMantenimiento
                , this.Precio);
            }

            return strMantenimiento;
        }

        public double obtenerPrecioTotal(double porcentaje, double precio)
        {
            return precio + (precio * (porcentaje / 100));
        }



    }
}
