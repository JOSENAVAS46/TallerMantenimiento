using TallerMantenimiento.Control;
using TallerMantenimiento.Modelo;

namespace TallerMantenimiento.Vista
{
    public partial class FormCliente : Form
    {
        CtrlCliente ctrlC = CtrlCliente.GetCtrlCliente();
        private int idMant = 0;
        public FormCliente()
        {
            InitializeComponent();
            llenarDataGridView();
            MaximizeBox = false;
        }

        private void llenarDataGridView()
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("clmId","ID");
            dgvClientes.Columns.Add("clmNombre", "Nombre");
            dgvClientes.Columns.Add("clmApellido", "Apellido");
            dgvClientes.Columns.Add("clmCedula", "Cédula");
            dgvClientes.Columns.Add("clmCorreo", "Correo");
            dgvClientes.Columns.Add("clmTelefono", "Teléfono");

            List<Cliente> lstClientes = ctrlC.ObtenerClientes();
            foreach (Cliente c in lstClientes)
            {
                dgvClientes.Rows.Add(c.Id, c.Nombre, c.Apellido, c.Cedula, c.Correo, c.Telefono);
            }

            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1;
            }

        }

        
        private void limpiarDatos()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtCedula.Text = null;
            txtCorreo.Text = null;
            txtTelefono.Text = null;
        }


        


        private void bttRegistrar_Click(object sender, EventArgs e)
        {
            string
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                cedula = txtCedula.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                telefono = txtTelefono.Text.Trim();
            if (ctrlC.noVacio(nombre, apellido, cedula, correo, telefono))
            {
                if (ctrlC.IsValidEmail(correo))
                {
                    ctrlC.AgregarCliente(nombre, apellido, cedula, correo, telefono);
                    limpiarDatos();
                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("Ingrese un correo Valido.");
                    txtCorreo.Text = null;
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados.");
            }
        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtCedula.Text.Length >= 10))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtTelefono.Text.Length >= 10))
            {
                e.Handled = true;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvClientes.Rows[e.RowIndex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["clmId"].Value);

                Cliente selectedCliente = ctrlC.ObtenerClientePorID(selectedId);
                if (selectedCliente != null)
                {
                    LlenarCamposMantCliente(selectedCliente);
                    idMant = selectedCliente.Id;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void LlenarCamposMantCliente(Cliente cliente)
        {
            txtNombreMant.Text = cliente.Nombre;
            txtApellidoMant.Text = cliente.Apellido;
            txtCedulaMant.Text = cliente.Cedula;
            txtCorreoMant.Text = cliente.Correo;
            txtTelefonoMant.Text = cliente.Telefono;
        }

        private void EditarClientePorId(int id, Cliente nuevoCliente)
        {
            Cliente clienteExistente = ctrlC.ObtenerClientePorID(id);

            if (clienteExistente != null)
            {
                ctrlC.ActualizarCliente(id, nuevoCliente.Nombre, nuevoCliente.Apellido, nuevoCliente.Cedula, nuevoCliente.Correo, nuevoCliente.Telefono);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            string
                nombre = txtNombreMant.Text.Trim(),
                apellido = txtApellidoMant.Text.Trim(),
                cedula = txtCedulaMant.Text.Trim(),
                correo = txtCorreoMant.Text.Trim(),
                telefono = txtTelefonoMant.Text.Trim();
            if (ctrlC.IsValidEmail(correo))
            {
                Cliente clienteEditado = new Cliente(idMant, nombre, apellido, cedula, correo, telefono);
                EditarClientePorId(idMant, clienteEditado);
                llenarDataGridView();
                LimpiarCamposMantCliente();
            }
            else
            {
                MessageBox.Show("Ingrese un correo Valido.");
                txtCorreoMant.Text = null;
            }
        }

        private void EliminarClientePorId(int id)
        {
            Cliente clienteAEliminar = ctrlC.ObtenerClientePorID(id);

            if (clienteAEliminar != null)
            {
                ctrlC.EliminarCliente(id);
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarClientePorId(idMant);
            llenarDataGridView();
            LimpiarCamposMantCliente();
        }

        private void LimpiarCamposMantCliente()
        {
            txtNombreMant.Text = "";
            txtApellidoMant.Text = "";
            txtCedulaMant.Text = "";
            txtCorreoMant.Text = "";
            txtTelefonoMant.Text = "";
        }

        private void txtNombreMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedulaMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtCedulaMant.Text.Length >= 10))
            {
                e.Handled = true;
            }

        }



        private void txtTelefonoMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) || txtTelefonoMant.Text.Length >= 10))
            {
                e.Handled = true;
            }

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
