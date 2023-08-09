using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Modelo;

namespace TallerMantenimiento.Control
{
    class CtrlMantenimiento
    {
        private static CtrlMantenimiento ctrlMantenimiento = null;
        private List<Mantenimiento> lstMantenimientos { get; set; }
        private Mantenimiento mnt = null;

        public CtrlMantenimiento()
        {
            this.lstMantenimientos = new List<Mantenimiento>();
        }


        public Boolean noVacio(Cliente cliente,
            Mecanico mecanico,
            Vehiculo vehiculo,
            DateTime fecha,
            string diagnostico,
            string tipo)
        {
            bool bnd = true;
            if (cliente != null ||
                mecanico != null ||
                vehiculo != null ||
                String.IsNullOrEmpty(diagnostico) ||
                String.IsNullOrEmpty(tipo)
                )
            {
                bnd = true;
            }
            else
            {
                bnd = false;
            }
            return bnd;
        }

        public void guardarMantenimiento(Cliente cliente,
            Mecanico mecanico,
            Vehiculo vehiculo,
            DateTime fecha,
            string diagnostico, string tipo,
            List<Repuesto> listaRespuesto,
            List<Servicio> listaServicio)
        {
            try
            {
                mnt = new Mantenimiento(cliente, mecanico, vehiculo, fecha, diagnostico, tipo, listaRespuesto, listaServicio);
                this.lstMantenimientos.Add(mnt);
                MessageBox.Show("Mantenimiento Registrado Exitosamente.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Ingrese todos los campos solicitados.");
            }
        }


        public static CtrlMantenimiento GetCtrlMantenimiento()
        {
            if (ctrlMantenimiento ==  null)
            {
                ctrlMantenimiento = new CtrlMantenimiento();
            }
            return ctrlMantenimiento;
        }

        public List<Mantenimiento> obtenerLista()
        {
            return this.lstMantenimientos;
        }
    }
}
