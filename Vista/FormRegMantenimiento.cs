using TallerMantenimiento.Control;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Vista
{
    public partial class FormRegMantenimiento : Form
    {
        CtrlMantenimiento ctrlMnt = CtrlMantenimiento.GetCtrlMantenimiento();
        CtrlCliente ctrlC = CtrlCliente.GetCtrlCliente();
        CtrlMecanico ctrlM = CtrlMecanico.GetCtrlMecanico();
        CtrlVehiculo ctrlV = CtrlVehiculo.GetCtrlVehiculo();
        List<Repuesto> lstRepuesto;
        Repuesto rep;
        string auxTipo = "Preventivo";

        private List<Servicio> lstServicios { get; set; }
        public FormRegMantenimiento()
        {
            InitializeComponent();
            lstRepuesto = new List<Repuesto>();
            MaximizeBox = false;
        }

        private void FormRegMantenimiento_Load(object sender, EventArgs e)
        {
            dtpFechaMantenimiento.Value = DateTime.Now;
            llenarCheckBoxList();
            llenarComboBoxClientes();
            llenarComboBoxMecanicos();
            llenarComboBoxVehiculos();
        }

        public void llenarCheckBoxList()
        {
            lstServicios = new List<Servicio>();
            lstServicios.Add(new Servicio("Lavado", 5));
            lstServicios.Add(new Servicio("Cambio de Aceite", 30));
            lstServicios.Add(new Servicio("Alineacion", 10));
            lstServicios.Add(new Servicio("Balanceo", 15));
            lstServicios.Add(new Servicio("Limpieza de Inyectores", 20));

            foreach (Servicio srv in lstServicios)
            {
                chkLstBxServicios.Items.Add(srv);
            }
        }

        public void llenarComboBoxClientes()
        {
            try
            {
                foreach (Cliente clt in ctrlC.ObtenerClientes())
                {
                    cmbClientes.Items.Add(clt);
                }
                cmbClientes.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No existen Clientes Registrados. " +
                    "\nRegistre Uno.");
            }

        }

        public void llenarComboBoxVehiculos()
        {
            try
            {
                cmbVehiculos.Items.Clear();
                foreach (Vehiculo veh in ctrlV.ObtenerVehiculos())
                {
                    cmbVehiculos.Items.Add(veh);
                }
                cmbVehiculos.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No existen Vehiculos Registrados. " +
                                       "\nRegistre Uno.");
            }
        }

        public void llenarComboBoxMecanicos()
        {
            try
            {
                foreach (Mecanico meca in ctrlM.ObtenerMecanicos())
                {
                    cmbMecanicos.Items.Add(meca);
                }
                cmbMecanicos.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No existen Mecanicos Registrados. " +
                    "\nRegistre Uno.");

            }
        }

        public void configurarFecha()
        {
            this.dtpFechaMantenimiento.Value = DateTime.Now;
        }

        private void rbCorrectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCorrectivo.Checked)
            {
                gbRepuestos.Enabled = true;
                dgvRepuestos.Enabled = true;
                this.auxTipo = rbCorrectivo.Text;
            }
        }

        private void rbPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPreventivo.Checked)
            {
                gbRepuestos.Enabled = false;
                dgvRepuestos.Enabled = false;
                this.auxTipo = rbPreventivo.Text;
                dgvRepuestos.Rows.Clear();
                lstRepuesto.Clear();
            }
        }

        private void btnAñadirRepuesto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                double precio = Double.Parse(txtPrecio.Text.Trim());
                if (!String.IsNullOrEmpty(nombre) || precio < 0)
                {
                    dgvRepuestos.Rows.Clear();
                    rep = new Repuesto(nombre, precio);
                    lstRepuesto.Add(rep);
                    añadirRepuestosDGV(rep);
                    txtPrecio.Text = null;
                    txtNombre.Text = null;
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos solicitados.");
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ingrese un precio valido.");
            }
        }

        private void añadirRepuestosDGV(Repuesto rep)
        {
            int fila = 0;
            foreach (Repuesto item in lstRepuesto)
            {
                llenarFilas(fila, item);
                fila++;
            }
        }

        private void llenarFilas(int fila, Repuesto repuesto)
        {
            dgvRepuestos.Rows.Add(1);
            dgvRepuestos.Rows[fila].Cells[0].Value = repuesto.Nombre;
            dgvRepuestos.Rows[fila].Cells[1].Value = "$ " + repuesto.Precio;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private List<Servicio> obtenerServicios()
        {
            List<Servicio> lstServicioSeleccionados = new List<Servicio>();
            lstServicioSeleccionados.Clear();
            for (int i = 0; i < chkLstBxServicios.CheckedItems.Count; i++)
            {
                lstServicioSeleccionados.Add((Servicio)chkLstBxServicios.CheckedItems[i]);
            }
            return lstServicioSeleccionados;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string
                diagnostico = rtbDiagnostico.Text.Trim();
            Cliente clt = (Cliente)this.cmbClientes.SelectedItem;
            Mecanico mech = (Mecanico)this.cmbMecanicos.SelectedItem;
            Vehiculo veh = (Vehiculo)this.cmbVehiculos.SelectedItem;
            DateTime fecha = dtpFechaMantenimiento.Value;
            if (ctrlMnt.noVacio(clt, mech, veh, fecha, diagnostico, auxTipo))
            {
                Mantenimiento mnt = new Mantenimiento(clt, mech, veh, fecha, diagnostico, auxTipo, lstRepuesto, obtenerServicios());
                ctrlMnt.GuardarMantenimiento(mnt);
            }
            else{
                MessageBox.Show("Ingrese todos los datos Solicitados.");
            }
        }

        private void btnAñadirVeh_Click(object sender, EventArgs e)
        {
            FormRegVehiculo formRegVehiculo = new FormRegVehiculo();
            formRegVehiculo.ShowDialog();
            llenarComboBoxVehiculos();
        }
    }
}
