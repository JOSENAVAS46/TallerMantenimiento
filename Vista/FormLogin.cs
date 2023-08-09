using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMantenimiento.Modelo;

namespace TallerMantenimiento.Vista
{
    public partial class FormLogin : Form
    {
        List<Usuario> lstUsuarios = new List<Usuario>();
        public FormLogin()
        {
            InitializeComponent();
            testUsers();
            MaximizeBox = false;
        }

        private void testUsers()
        {
            lstUsuarios.Add(new Usuario("admin", "admin", "ADMIN", "_ADMIN_"));
            lstUsuarios.Add(new Usuario("user", "user", "USER", "_USER_"));
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (Usuario usuario in lstUsuarios)
                {
                    if (usuario.Username == txtUsername.Text && usuario.Password == txtPassword.Text)
                    {
                        MessageBox.Show("Bienvenido " + usuario.Nombre + " " + usuario.Apellido, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPrincipal formMenu = new FormPrincipal(usuario);
                        formMenu.Show();
                        this.Hide();
                        return;
                    }
                }
            }
        }
    }
}
