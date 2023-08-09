using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Modelo
{
    class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Vehiculo(string placa, string marca, string modelo, string color)
        {
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }

        public override string ToString()
        {
            return String.Format("{0} | {1} | {2}",
                this.Placa, 
                this.Marca, 
                this.Modelo);
        }

        public string obtenerDatos()
        {
            return String.Format(
                "\nPlaca: {0}" +
                "\nMarca: {1}" +
                "\nModelo {2}" +
                "\nColor: {3}"
                ,this.Placa
                ,this.Marca
                ,this.Modelo
                ,this.Color); 
        }

    }
}
