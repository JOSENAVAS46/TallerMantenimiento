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

namespace TallerMantenimiento.Vista
{
    public partial class FormConsultaMantenimientoVehFecha : Form
    {
        CtrlMantenimiento ctrlMant = CtrlMantenimiento.GetCtrlMantenimiento();

        public FormConsultaMantenimientoVehFecha()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadMantenimientos();
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

            foreach (DataGridViewColumn column in dgvMantenimientos.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.FillWeight = 1;
            }
        }

        private void LoadMantenimientos()
        {
            FillDataGridView(ctrlMant.ObtenerMantenimientos());
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

        public void busquedaMantEntreFechas(DateTime desde, DateTime hasta)
        {

            List<Mantenimiento> resultados = new List<Mantenimiento>();

            foreach (Mantenimiento mantenimiento in ctrlMant.ObtenerMantenimientos())
            {
                if (mantenimiento.FechaMantenimiento >= desde && mantenimiento.FechaMantenimiento <= hasta)
                {
                    resultados.Add(mantenimiento);
                }
            }

            FillDataGridView(resultados);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;

            busquedaMantEntreFechas(fechaDesde, fechaHasta);
        }

        private void dgvMantenimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvMantenimientos.Columns[e.ColumnIndex].Name == "clmDetalles") // Utilizamos el nombre de la columna
                {
                    DataGridViewRow selectedRow = dgvMantenimientos.Rows[e.RowIndex];
                    string selectedCodigo = selectedRow.Cells["clmCodigo"].Value.ToString(); // Utilizamos el nombre de columna "clmCodigo"

                    Mantenimiento selectedMantenimiento = ctrlMant.ObtenerMantenimientos().Find(mantenimiento => mantenimiento.Codigo == selectedCodigo);

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
