using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Control
{
    class CtrlMecanico
    {
        private static CtrlMecanico ctrlMecanico = null;
        private List<Mecanico> lstMecanico { get; set; }

        private Mecanico mecanico;

        public Boolean noVacio(string nombre, string apellido, string cedula,
            string especialidad, double salario)
        {
            bool bnd = true;
            if (String.IsNullOrEmpty(nombre)
                || String.IsNullOrEmpty(apellido)
                || String.IsNullOrEmpty(cedula)
                || String.IsNullOrEmpty(especialidad)
                || salario < 0)
            {
                bnd = false;
            }
            else
            {
                bnd = true;
            }
            return bnd;
        }

        public void guardarMecanico(int id, string nombre, string apellido, string cedula,
            string especialidad, double salario)
        {
            mecanico = new Mecanico(id, nombre, apellido, cedula, especialidad, salario);
            lstMecanico.Add(mecanico);
            MessageBox.Show("Mecanico Registrado");
        }

        public CtrlMecanico()
        {
            this.lstMecanico = new List<Mecanico>();
        }

        public static CtrlMecanico GetCtrlMecanico()
        {
            if (ctrlMecanico == null)
            {
                ctrlMecanico = new CtrlMecanico();
            }
            return ctrlMecanico;
        }

        public void consultarListaMecanico()
        {
            foreach (Mecanico mech in lstMecanico)
            {
                MessageBox.Show(mech.obtenerDatos());
            }
        }

        public List<Mecanico> obtenerLista()
        {
            return lstMecanico;
        }


    }
}

