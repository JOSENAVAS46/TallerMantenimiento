using TallerMantenimiento.Control;
using TallerMantenimiento.Modelo;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Vista
{
    public partial class FormMecanico : Form
    {
        CtrlMecanico ctrlM = CtrlMecanico.GetCtrlMecanico();
        private int idMant = 0;

        public FormMecanico()
        {
            InitializeComponent();
            llenarCmbEspecialidad();
            llenarDataGridView();
            MaximizeBox = false;
        }
        private void llenarDataGridView()
        {
            dgvMecanicos.Rows.Clear();
            dgvMecanicos.Columns.Clear();
            dgvMecanicos.Columns.Add("clmId", "ID");
            dgvMecanicos.Columns.Add("clmNombre", "Nombre");
            dgvMecanicos.Columns.Add("clmApellido", "Apellido");
            dgvMecanicos.Columns.Add("clmCedula", "Cédula");
            dgvMecanicos.Columns.Add("clmEspecialidad", "Especialidad");
            dgvMecanicos.Columns.Add("clmSalario", "Salario");

            List<Mecanico> lstMecanicos = ctrlM.ObtenerMecanicos();
            foreach (Mecanico m in lstMecanicos)
            {
                dgvMecanicos.Rows.Add(m.Id, m.Nombre, m.Apellido, m.Cedula, m.Especialidad, m.Salario);
            }

            foreach (DataGridViewColumn column in dgvMecanicos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string
                    nombre = txtNombre.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    cedula = txtCedula.Text.Trim(),
                    especialidad = cmbEspecialidad.Text.Trim();
                double salario = Double.Parse(txtSalario.Text.Trim());

                if (ctrlM.noVacio(nombre, apellido, cedula, especialidad, salario))
                {
                    ctrlM.AgregarMecanico(nombre, apellido, cedula, especialidad, salario);
                    limpiarDatos();
                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("Ingrese todos los datos solicitados.");
                }
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ingrese un salario valido.");
            }

        }

        public void llenarCmbEspecialidad()
        {
            cmbEspecialidad.Items.AddRange(Enum.GetNames(typeof(Especialidad)));
            cmbEspecialidad.SelectedIndex = 0;
            cmbEspecialidadMant.Items.AddRange(Enum.GetNames(typeof(Especialidad)));
            cmbEspecialidadMant.SelectedIndex = 0;
        }

        private void limpiarDatos()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtCedula.Text = null;
            cmbEspecialidad.SelectedIndex = 0;
            txtSalario.Text = null;
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvMecanicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvMecanicos.Rows[e.RowIndex];
                int selectedId = Convert.ToInt32(selectedRow.Cells["clmId"].Value);

                Mecanico selectedMecanico = ctrlM.ObtenerMecanicoPorID(selectedId);
                if (selectedMecanico != null)
                {
                    LlenarCamposMantMecanico(selectedMecanico);
                    idMant = selectedMecanico.Id;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila.");
            }

        }
        private void LlenarCamposMantMecanico(Mecanico mecanico)
        {
            txtNombreMant.Text = mecanico.Nombre;
            txtApellidoMant.Text = mecanico.Apellido;
            txtCedulaMant.Text = mecanico.Cedula;
            for (int i = 0; i < cmbEspecialidadMant.Items.Count; i++)
            {
                if (mecanico.Especialidad == cmbEspecialidadMant.Items[i].ToString())
                {
                    cmbEspecialidadMant.SelectedIndex = i;
                    break;
                }
            }
            txtSalarioMant.Text = mecanico.Salario.ToString();
        }

        private void EditarMecanicoPorId(int id, Mecanico nuevoMecanico)
        {
            Mecanico mecanicoExistente =    ctrlM.ObtenerMecanicoPorID(id);

            if (mecanicoExistente != null)
            {
                ctrlM.ActualizarMecanico(id, nuevoMecanico.Nombre, nuevoMecanico.Apellido, nuevoMecanico.Cedula, nuevoMecanico.Especialidad, nuevoMecanico.Salario);
            }
            else
            {
                MessageBox.Show("Mecanico no encontrado.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string
            nombre = txtNombreMant.Text.Trim(),
            apellido = txtApellidoMant.Text.Trim(),
            cedula = txtCedulaMant.Text.Trim(),
            especialidad = cmbEspecialidadMant.Text.Trim();

            double salario = Double.Parse(txtSalarioMant.Text.Trim());

            Mecanico mecanicoEditado = new Mecanico(idMant, nombre, apellido, cedula, especialidad, salario);
            EditarMecanicoPorId(idMant, mecanicoEditado);
            llenarDataGridView();  // Vuelve a llenar el DataGridView con los datos actualizados
            LimpiarCamposMantMecanico();

        }


        private void EliminarMecanicoPorId(int id)
        {
            Mecanico mecanicoAEliminar = ctrlM.ObtenerMecanicoPorID(id);

            if (mecanicoAEliminar != null)
            {
                ctrlM.EliminarMecanicoPorId(mecanicoAEliminar.Id);
            }
            else
            {
                MessageBox.Show("Mecánico no encontrado.");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMecanicoPorId(idMant);
            llenarDataGridView();  // Vuelve a llenar el DataGridView con los datos actualizados
            LimpiarCamposMantMecanico();

        }

        private void LimpiarCamposMantMecanico()
        {
            txtNombreMant.Text = "";
            txtApellidoMant.Text = "";
            txtCedulaMant.Text = "";
            cmbEspecialidadMant.SelectedIndex = 0;
            txtSalarioMant.Text = "";
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

        private void txtSalarioMant_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
