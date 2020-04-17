using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Login : Form
    {
        private UsuarioNC _userCn = new UsuarioNC();
        private PersonaCN _perCn = new PersonaCN();

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario userNew = _userCn.ComprobarLogin(txtName.Text, txtClave.Text);
            if (userNew != null)
            {
                userNew.Empleado.Persona = _perCn.ObtenerPersonaPorId(userNew.Empleado.Persona_idPersona);
                this.Visible = false;
                MenuPrincipal mp = new MenuPrincipal();
                mp.UserSession = userNew;
                mp.Show();
            }
            else
            {
                MessageBox.Show("Usuario no registrado o inactivo", "Error");
            }

            
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
