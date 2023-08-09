using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMantenimiento.Modelo
{
    class Cliente : Persona
    {
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente(int id,string nombre, string apellido, string cedula, 
            string correo, string telefono) : 
            base(id,nombre, apellido, cedula)
        {
            Correo = correo;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}.",
            this.Nombre,
            this.Apellido);
        }

        public string obtenerDatos()
        {
            return string.Format(
                "\nNombre: {0} " +
                "\nApellido: {1}" +
                "\nCedula: {2}" +
                "\nCorreo: {3}" +
                "\nTelefono: {4}",
                this.Nombre,
                this.Apellido,
                this.Cedula,
                this.Correo,
                this.Telefono
                );
        }

    }
}
