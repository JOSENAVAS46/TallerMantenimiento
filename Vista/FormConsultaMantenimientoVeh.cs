using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMantenimiento.Control;
using TallerMantenimiento.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace TallerMantenimiento.Vista
{
    public partial class FormConsultaMantenimientoVeh : Form
    {
        CtrlMantenimiento ctrlMant = CtrlMantenimiento.GetCtrlMantenimiento();

        public FormConsultaMantenimientoVeh()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadMantenimientos();  // Cargar los mantenimientos desde tu fuente de datos
            MaximizeBox = false;
        }

        private void InitializeDataGridView()
        {
            dgvMantenimientos.Columns.Add("clmCodigo", "Código");
            dgvMantenimientos.Columns.Add("clmCliente", "Cliente");
            dgvMantenimientos.Columns.Add("clmMecanico", "Mecánico");
            dgvMantenimientos.Columns.Add("clmFecha", "Fecha");
            dgvMantenimientos.Columns.Add("clmTipo", "Tipo");
            dgvMantenimientos.Columns.Add("clmPrecio", "Precio Total");
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "clmDetalles";
            btnColumn.HeaderText = "Detalles";
            btnColumn.Text = "...";
            btnColumn.UseColumnTextForButtonValue = true;
            dgvMantenimientos.Columns.Add(btnColumn);



            dgvMantenimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbTipoBusq.Items.Add("Código");
            cmbTipoBusq.Items.Add("Cliente");
            cmbTipoBusq.Items.Add("Mecánico");
            cmbTipoBusq.Items.Add("Placa"); 
            cmbTipoBusq.SelectedIndex = 0;

            foreach (DataGridViewColumn column in dgvMantenimientos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1;
            }

        }


        private void LoadMantenimientos()
        {
            FillDataGridView(ctrlMant.obtenerLista());
        }

        private void FillDataGridView(List<Mantenimiento> mantenimientos)
        {
            dgvMantenimientos.Rows.Clear();

            foreach (Mantenimiento mantenimiento in mantenimientos)
            {
                dgvMantenimientos.Rows.Add(
                    mantenimiento.Codigo,
                    $"{mantenimiento.Cliente.Nombre} {mantenimiento.Cliente.Apellido}",
                    $"{mantenimiento.Mecanico.Nombre} {mantenimiento.Mecanico.Apellido}",
                    mantenimiento.FechaMantenimiento,
                    mantenimiento.Tipo,
                    mantenimiento.Precio);
            }
        }


        private void PerformSearch()
        {
            string columnaBusqueda = cmbTipoBusq.SelectedItem.ToString();
            string valorBusqueda = txtBusqueda.Text.Trim().ToLower(); 

            List<Mantenimiento> resultados = new List<Mantenimiento>();

            switch (columnaBusqueda)
            {
                case "Código":
                    resultados = ctrlMant.obtenerLista().FindAll(mantenimiento => mantenimiento.Codigo.ToLower().Contains(valorBusqueda)); 
                    break;
                case "Cliente":
                    resultados = ctrlMant.obtenerLista().FindAll(mantenimiento => $"{mantenimiento.Cliente.Nombre} {mantenimiento.Cliente.Apellido}".ToLower().Contains(valorBusqueda));
                    break;
                case "Mecánico":
                    resultados = ctrlMant.obtenerLista().FindAll(mantenimiento => $"{mantenimiento.Mecanico.Nombre} {mantenimiento.Mecanico.Apellido}".ToLower().Contains(valorBusqueda)); 
                    break;
                case "Placa":
                    resultados = ctrlMant.obtenerLista().FindAll(mantenimiento => mantenimiento.Vehiculo.Placa.ToLower().Contains(valorBusqueda));
                    break;
            }
            FillDataGridView(resultados);
        }

        private void cmbTipoBusq_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void dgvMantenimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvMantenimientos.Columns[e.ColumnIndex].Name == "clmDetalles") // Utilizamos el nombre de la columna
                {
                    DataGridViewRow selectedRow = dgvMantenimientos.Rows[e.RowIndex];
                    string selectedCodigo = selectedRow.Cells["clmCodigo"].Value.ToString(); // Utilizamos el nombre de columna "clmCodigo"

                    Mantenimiento selectedMantenimiento = ctrlMant.obtenerLista().Find(mantenimiento => mantenimiento.Codigo == selectedCodigo);

                    if (selectedMantenimiento != null)
                    {
                        // Mostrar información detallada del mantenimiento
                        MessageBox.Show(selectedMantenimiento.ToString(), "Detalles del Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
