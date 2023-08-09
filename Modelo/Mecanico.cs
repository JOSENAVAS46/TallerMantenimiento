using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Modelo
{
    class Mecanico : Persona
    {
        public string Especialidad { get; set; }
        public double Salario { get; set; }

        public Mecanico(int id,string nombre, string apellido, string cedula,
            string especialidad, double salario) :
            base(id, nombre, apellido, cedula)
        {
            Especialidad = especialidad;
            Salario = salario;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} | {2}",
            this.Nombre,
            this.Apellido,
            this.Especialidad);
        }

        public string obtenerDatos()
        {
            return string.Format(
                "\nNombre: {0} " +
                "\nApellido: {1}" +
                "\nCedula: {2}" +
                "\nEspecialidad: {3}" +
                "\nSalario: {4}",
                this.Nombre,
                this.Apellido,
                this.Cedula,
                this.Especialidad,
                this.Salario
                );
        }

    }
}
