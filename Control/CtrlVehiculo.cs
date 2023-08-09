using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Modelo;

namespace TallerMantenimiento.Control
{
    class CtrlVehiculo
    {
        private static CtrlVehiculo ctrlVehiculo = null;
        private List<Vehiculo> lstVehiculos { get; set; }
        private Vehiculo veh = null;

        public CtrlVehiculo()
        {
            this.lstVehiculos = new List<Vehiculo>();
        }

        //Metodo no vacio para Vehiculo
        public Boolean noVacio(string placa, string marca, 
            string modelo, string color)
        {
            bool bnd = true;
            if (String.IsNullOrEmpty(placa) ||
                String.IsNullOrEmpty(marca) ||
                String.IsNullOrEmpty(modelo) ||
                String.IsNullOrEmpty(color))
            {
                bnd = false;
            }
            else
            {
                bnd = true;
            }
            return bnd;
        }

        //Metodo para guardar Vehiculo
        public void guardarVehiculo(string placa, string marca,
                       string modelo, string color)
        {
            veh = new Vehiculo(placa, marca, modelo, color);
            lstVehiculos.Add(veh);
            MessageBox.Show("Vehiculo Registrado");
        }

        public static CtrlVehiculo GetCtrlVehiculo()
        {
            if (ctrlVehiculo == null)
            {
                ctrlVehiculo = new CtrlVehiculo();
            }
            return ctrlVehiculo;
        }


        //Metodo para obtener lista de Vehiculos
        public List<Vehiculo> obtenerLista()
        {
            return lstVehiculos;
        }

    }
}
