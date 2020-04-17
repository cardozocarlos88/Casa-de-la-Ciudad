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
    public partial class GestionUsuario : Form

    { 
        private Usuario usuario = new Usuario();
       

        private string tipoGestion;

        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }
        public Usuario UsuarioFrm { get => usuario; set => usuario = value; }



        private UsuarioNC _userCn = new UsuarioNC();
        private EmpleadoCN _empCn = new EmpleadoCN();
        private PersonaCN _perCN = new PersonaCN();

        ValidacionYControles validacion = new ValidacionYControles();

        public GestionUsuario()
        {
            InitializeComponent();
            CargarComboBoxPerfil();
        }

        private void GestionUsuario_Load(object sender, EventArgs e)
        {

            switch (tipoGestion)
            {
                case "alta":
                    btnAccion.Text = "Guardar";
                    CargarComboBoxEmpleados();
                    break;

                case "modi":
                    btnAccion.Text = "Editar";
                    UsuarioFrm = _userCn.ObtenerUsuarioPorId(UsuarioFrm.idUsuario);
                    CargarUsuarioAFormulario();
                    txtNombre.Enabled = false;

                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    UsuarioFrm = _userCn.ObtenerUsuarioPorId(UsuarioFrm.idUsuario);
                    CargarUsuarioAFormulario();
                    txtNombre.Enabled = false;
                    txtClave.Enabled = false;
                    cbxEmp.Enabled = false;
                    cbxPerfil.Enabled = false;
                  

                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }


        }

        private void CargarUsuarioAFormulario()
        {
            UsuarioFrm.Empleado.Persona =  _perCN.ObtenerPersonaPorId(UsuarioFrm.Empleado.Persona_idPersona);

            txtNombre.Text = UsuarioFrm.Nombre;
            txtClave.Text =  UsuarioFrm.Clave;
            cbxEmp.Text = Convert.ToString(UsuarioFrm.Empleado.idEmpleado);
            cbxPerfil.Text = UsuarioFrm.Perfil.Descripcion;
            txtLegApeNom.Visible = true;
            txtLegApeNom.Text = Convert.ToString(UsuarioFrm.Empleado.Legajo) + " - " + UsuarioFrm.Empleado.Persona.Apellidos + ", " + UsuarioFrm.Empleado.Persona.Nombres;
            txtLegApeNom.Enabled = false;
            cbxEmp.Visible = false;
        }


        private void ObtenerDatosDeFormularioAlta()
        {
            UsuarioFrm.Nombre = txtNombre.Text;
            UsuarioFrm.Clave = txtClave.Text;
            UsuarioFrm.Perfil_idPerfil = ((Perfil)cbxPerfil.SelectedItem).idPerfil;
            UsuarioFrm.Empleado_idEmpleado = ((vw_EmpleadosSinUsuario)cbxEmp.SelectedItem).id;
        }

        private void ObtenerDatosDeFormulario()
        {
            UsuarioFrm.Clave = txtClave.Text;
            UsuarioFrm.Perfil_idPerfil = ((Perfil)cbxPerfil.SelectedItem).idPerfil;
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboBoxPerfil()
        {
            cbxPerfil.SelectedValue = "idPerfil";
            cbxPerfil.DisplayMember = "Descripcion";
            cbxPerfil.DataSource = _userCn.ObtenerTodosLosPerfiles();
        }

      
        private void CargarComboBoxEmpleados()
        {
            var aux = TipoGestion;
            cbxEmp.SelectedValue = "id";
            cbxEmp.DisplayMember = "apeNom";
            cbxEmp.DataSource = _empCn.ObtenerEmpleadosSinUsuario();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormularioAlta();
                        var aux = UsuarioFrm;
                        _userCn.GuardarUsuario(UsuarioFrm);
                        MessageBox.Show("Usuario registrado con exito");
                        this.Close();
                    }
                    break;

                case "modi":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        _userCn.EditarUsuario(UsuarioFrm);
                        MessageBox.Show("Usuario Modificado con exito");
                        this.Close();
                    }
                    break;

                case "baja":
                    _userCn.EliminarUsuario(UsuarioFrm);
                    MessageBox.Show("Usuario Desabilitado con exito");
                    this.Close();
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            List<TextBox> listaTextBox = new List<TextBox>();
            listaTextBox.Add(txtNombre);
            listaTextBox.Add(txtClave);
            return validacion.ControlCampoNoVacio(listaTextBox);
        }
    }
}
