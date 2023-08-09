using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMantenimiento.Control;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Vista
{
    public partial class FormPrincipal : Form
    {

        CtrlCliente ctrlC = CtrlCliente.GetCtrlCliente();
        CtrlMecanico ctrlM = CtrlMecanico.GetCtrlMecanico();
        CtrlMantenimiento ctrlMant = CtrlMantenimiento.GetCtrlMantenimiento();
        CtrlVehiculo ctrlV = CtrlVehiculo.GetCtrlVehiculo();
        Usuario usuarioActual = null;

        public FormPrincipal()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        public FormPrincipal(Usuario _user)
        {
            InitializeComponent();
            this.usuarioActual = _user;
            MaximizeBox = false;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //test();
        }

        /*
        public void test()
        {
            ctrlC.obtenerLista().Add(new Cliente(1,"Esaias","Ortega","0987654321", "esaias.ortega@gmail.com", "0999261352"));
            ctrlC.obtenerLista().Add(new Cliente(2,"Erick", "Mendoza", "7894561230", "erick.mendoza@hotmail.com", "0875421931"));
            ctrlM.obtenerLista().Add(new Mecanico(1,"Jose","Rivas","0875451222",""+Especialidad.General,526.5));
            ctrlM.obtenerLista().Add(new Mecanico(2,"Pepe", "Perez", "7894553126", ""+Especialidad.Electromecánico, 550.25));

            Cliente cliente1 = new Cliente(3,"Juan", "Pérez", "1234567890", "juan@example.com", "555-123-4567");
            Mecanico mecanico1 = new Mecanico(3,"Luis", "García", "9876543210", ""+Especialidad.Vulcanizador, 1500);
            Vehiculo vehiculo1 = new Vehiculo("ABC-123", ""+Marca.Toyota, "Corolla", ""+ColorCarro.Rojo);
            List<Repuesto> repuestos1 = new List<Repuesto>();
            repuestos1.Add(new Repuesto("Filtro de aceite", 15.99));
            repuestos1.Add(new Repuesto("Bujías", 8.5));
            List<Servicio> servicios1 = new List<Servicio>();
            servicios1.Add(new Servicio("Cambio de aceite", 25.0));
            servicios1.Add(new Servicio("Alineación", 40.0));
            Mantenimiento mantenimiento1 = new Mantenimiento(cliente1, mecanico1, vehiculo1, new DateTime(2023, 8, 15), "Revisión general", "Correctivo", repuestos1, servicios1);

            Cliente cliente2 = new Cliente(4,"María", "López", "2345678901", "maria@example.com", "555-987-6543");
            Mecanico mecanico2 = new Mecanico(4,"Ana", "Martínez", "8765432109", ""+Especialidad.Chapa, 1800);
            Vehiculo vehiculo2 = new Vehiculo("XYZ-789", ""+Marca.Honda, "Civic", ""+ColorCarro.Azul);
            List<Servicio> servicios2 = new List<Servicio>();
            servicios2.Add(new Servicio("Lavado exterior", 10.0));
            servicios2.Add(new Servicio("Balanceo de llantas", 20.0));
            Mantenimiento mantenimiento2 = new Mantenimiento(cliente2, mecanico2, vehiculo2, new DateTime(2023, 8, 1), "Mantenimiento preventivo", "Preventivo", new List<Repuesto>(), servicios2);

            //Agregamos los vehiculos a la lista de vehiculos
            ctrlV.obtenerLista().Add(vehiculo1);
            ctrlV.obtenerLista().Add(vehiculo2);

            //Agregamos los mecanicos a la lista de mecanicos
            ctrlM.obtenerLista().Add(mecanico1);
            ctrlM.obtenerLista().Add(mecanico2);

            //Agregamos los clientes a la lista de clientes
            ctrlC.obtenerLista().Add(cliente1);
            ctrlC.obtenerLista().Add(cliente2);

            //Agregamos los mantenimientos a la lista de mantenimientos
            ctrlMant.obtenerLista().Add(mantenimiento1);
            ctrlMant.obtenerLista().Add(mantenimiento2);


        }
        */


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente();

            frmCliente.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frmCliente);
            frmCliente.Dock = DockStyle.None;

            frmCliente.Show();

        }

        private void pbMecanico_Click(object sender, EventArgs e)
        {
            FormMecanico frmMecanico = new FormMecanico();
            frmMecanico.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frmMecanico);
            frmMecanico.Dock = DockStyle.None;

            frmMecanico.Show();
        }

        private void pbMantVeh_Click(object sender, EventArgs e)
        {
            if (ctrlM.obtenerLista().Count > 0 && ctrlC.ObtenerClientes().Count > 0)
            {
                FormRegMantenimiento frmRegMantenimiento = new FormRegMantenimiento();
                frmRegMantenimiento.TopLevel = false;
                pnlPrincipal.Controls.Clear();
                pnlPrincipal.Controls.Add(frmRegMantenimiento);
                frmRegMantenimiento.Dock = DockStyle.None;

                frmRegMantenimiento.Show();

            }
            else
            {
                MessageBox.Show("No existen Clientes o Mecanicos" +
                    "\nRegistre uno.");
            }
        }

        private void pbConsultarGral_Click(object sender, EventArgs e)
        {
            if (ctrlMant.obtenerLista().Count > 0)
            {
                FormConsultaMantenimientoVeh frmMantenimiento = new FormConsultaMantenimientoVeh();
                frmMantenimiento.TopLevel = false;
                pnlPrincipal.Controls.Clear();
                pnlPrincipal.Controls.Add(frmMantenimiento);
                frmMantenimiento.Dock = DockStyle.None;

                frmMantenimiento.Show();
            }
            else
            {
                MessageBox.Show("No existen Mantenimientos" +
                                       "\nRegistre uno.");
            }
        }

        private void pbConsultaFecha_Click(object sender, EventArgs e)
        {
            if (ctrlMant.obtenerLista().Count > 0)
            {
                FormConsultaMantenimientoVehFecha frmMantenimiento =
                    new FormConsultaMantenimientoVehFecha();
                frmMantenimiento.TopLevel = false;
                pnlPrincipal.Controls.Clear();
                pnlPrincipal.Controls.Add(frmMantenimiento);
                frmMantenimiento.Dock = DockStyle.None;
                frmMantenimiento.Show();
            }
            else
            {
                MessageBox.Show("No existen Mantenimientos" +
                                       "\nRegistre uno.");
            }
        }

        private void pbIntegrantes_Click(object sender, EventArgs e)
        {
            FormIntegrantes formIntegrantes = new FormIntegrantes();
            formIntegrantes.TopLevel = false;
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(formIntegrantes);
            formIntegrantes.Dock = DockStyle.None;
            formIntegrantes.Show();

        }
    }
}
