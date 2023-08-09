
using TallerMantenimiento.Modelo;

namespace TallerMantenimiento.Vista
{
    public partial class FormIntegrantes : Form
    {
        public FormIntegrantes()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void FormIntegrantes_Load(object sender, EventArgs e)
        {
            string rutaImagenPilamunga = Path.Combine(Application.StartupPath, "..", "..", "..", "Assets", "Imagenes", "Pilamunga.png");
            string rutaImagenParrales = Path.Combine(Application.StartupPath, "..", "..", "..", "Assets", "Imagenes", "Parrales.png");
            string rutaImagenArellano = Path.Combine(Application.StartupPath, "..", "..", "..", "Assets", "Imagenes", "Arellano.png");

            List<Integrante> lstIntegrantes = new List<Integrante>();
            lstIntegrantes.Add(new Integrante("Edison", "Pilamunga", "edison.pilamunga@ug.edu.ec", rutaImagenPilamunga));
            lstIntegrantes.Add(new Integrante("Esaias", "Parrales", "esaias.parrales@ug.edu.ec", rutaImagenParrales));
            lstIntegrantes.Add(new Integrante("Jeremy", "Arellano", "jeremy.arellano@ug.edu.ec", rutaImagenArellano));

            flpTarjetas.FlowDirection = FlowDirection.TopDown; // Alinear las tarjetas de arriba hacia abajo
            flpTarjetas.AutoScroll = true; // Habilitar el scroll si hay muchas tarjetas

            foreach (Integrante integrante in lstIntegrantes)
            {
                FlowLayoutPanel cardPanel = CreateCard(integrante);
                flpTarjetas.Controls.Add(cardPanel);
            }

        }

        private FlowLayoutPanel CreateCard(Integrante integ)
        {
            FlowLayoutPanel cardPanel = new FlowLayoutPanel();
            cardPanel.FlowDirection = FlowDirection.LeftToRight;
            cardPanel.AutoSize = true;
            cardPanel.Margin = new Padding(10, 10, 10, 0); // Margen de 10 unidades arriba, 10 unidades en los lados y 0 unidades abajo

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = System.Drawing.Image.FromFile(integ.RutaImagen);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Width = 100;
            pictureBox.Height = 100;
            cardPanel.Controls.Add(pictureBox);

            Label nameLabel = new Label();
            nameLabel.Text = integ.NombreCompleto.ToUpper();
            nameLabel.AutoSize = true;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter; // Centrar verticalmente el texto
            nameLabel.Font = new Font(nameLabel.Font, FontStyle.Bold); // Aplicar negrita
            nameLabel.Font = new Font(nameLabel.Font.FontFamily, 16); // Cambiar tamaño de fuente
            cardPanel.Controls.Add(nameLabel);

            Label emailLabel = new Label();
            emailLabel.Text = integ.Correo;
            emailLabel.AutoSize = true;
            emailLabel.TextAlign = ContentAlignment.MiddleCenter; // Centrar verticalmente el texto
            emailLabel.Font = new Font(emailLabel.Font.FontFamily, 12); // Cambiar tamaño de fuente
            cardPanel.Controls.Add(emailLabel);

            return cardPanel;
        }

    }
}
