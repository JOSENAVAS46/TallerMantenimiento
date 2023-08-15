
using TallerMantenimiento.Control;
using TallerMantenimiento.Modelo.Enums;

namespace TallerMantenimiento.Vista
{
    public partial class FormRegVehiculo : Form
    {
        private CtrlVehiculo ctrlVehiculo = CtrlVehiculo.GetCtrlVehiculo();
        public FormRegVehiculo()
        {
            InitializeComponent();
            llenarCmbBoxColor();
            llenarCmbBoxMarca();
            MaximizeBox = false;
        }

        //Llenar ComboBox de Marca
        public void llenarCmbBoxMarca()
        {
            foreach (string marca in Enum.GetNames(typeof(Marca)))
            {
                cmbMarca.Items.Add(marca);
                cmbMarca.SelectedIndex = 0;

            }
        }

        //Llenar ComboBox de Color
        public void llenarCmbBoxColor()
        {
            foreach (string color in Enum.GetNames(typeof(ColorCarro)))
            {
                cmbColor.Items.Add(color);
                cmbColor.SelectedIndex = 0;
            }
        }


        //Metodo para registrar Vehiculo
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = mskTxtPlaca.Text.Trim(),
                marca = cmbMarca.Text.Trim(),
                modelo = txtModelo.Text.Trim(),
                color = cmbColor.Text.Trim();
            if (ctrlVehiculo.noVacio(placa,marca,modelo,color))
            {
                ctrlVehiculo.AgregarVehiculo(placa, marca, modelo, color);
                limpiarCampos();

            } else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void limpiarCampos()
        {
            mskTxtPlaca.Text = "";
            cmbColor.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            txtModelo.Text = "";
            this.Dispose();
        }
    }
    



}
