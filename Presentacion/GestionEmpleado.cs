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
    public partial class GestionEmpleado : Form
    {

        private Empleado empleado = new Empleado();
        private Persona persona = new Persona();

        private string tipoGestion;

        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }
        public Empleado EmpleadoFrm { get => empleado; set => empleado = value; }
        public Persona PersonaFrm { get => persona; set => persona = value; }

        private PersonaCN _perCn = new PersonaCN();
        private EmpleadoCN _empCn = new EmpleadoCN();

        ValidacionYControles validacion = new ValidacionYControles();
        public GestionEmpleado()
        {
            InitializeComponent();
            CargarComboBoxCargos();
        }

        private void GestionEmpleado_Load(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    btnAccion.Text = "Guardar";
                    break;

                case "modi":
                    btnAccion.Text = "Editar";
                    EmpleadoFrm = _empCn.ObtenerEmpleadoPorId(EmpleadoFrm.idEmpleado);
                    CargarEmpleadoAFormulario();
                    txtLegajo.Enabled = false;

                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    EmpleadoFrm = _empCn.ObtenerEmpleadoPorId(EmpleadoFrm.idEmpleado);
                    CargarEmpleadoAFormulario();
                    txtLegajo.Enabled = false;
                    txtDni.Enabled = false;
                    txtApe.Enabled = false;
                    txtNom.Enabled = false;
                    txtFecha.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelefono.Enabled = false;
                    cbxCargo.Enabled = false;
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        _perCn.GuardarPersona(PersonaFrm);
                        EmpleadoFrm.Persona_idPersona = PersonaFrm.idPersona;
                        _empCn.GuardarEmpleado(EmpleadoFrm);
                        MessageBox.Show("Empleado registrado con exito");
                        this.Close();
                    }
                    break;

                case "modi":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        PersonaFrm.idPersona = EmpleadoFrm.Persona_idPersona;
                        _empCn.EditarEmpleado(EmpleadoFrm);
                        _perCn.EditarPersona(PersonaFrm);
                        MessageBox.Show("Cargo Modificado con exito");
                        this.Close();
                    }
                    break;

                case "baja":
                    PersonaFrm.idPersona = EmpleadoFrm.Persona_idPersona;
                    _empCn.EliminarEmpleado(EmpleadoFrm);
                    _perCn.EliminarPersona(PersonaFrm);
                    MessageBox.Show("Empleado Eliminado con exito");
                    this.Close();
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void CargarEmpleadoAFormulario()
        {
            txtLegajo.Text = Convert.ToString(EmpleadoFrm.Legajo);
            txtDni.Text = Convert.ToString(EmpleadoFrm.Persona.Dni);
            txtApe.Text = EmpleadoFrm.Persona.Apellidos;
            txtNom.Text = EmpleadoFrm.Persona.Nombres;
            txtFecha.Text = Convert.ToString(EmpleadoFrm.Persona.FechNac);
            txtDireccion.Text = EmpleadoFrm.Persona.Direccion;
            txtCorreo.Text = EmpleadoFrm.Persona.Correo;
            txtTelefono.Text = EmpleadoFrm.Persona.Telefono;
            cbxCargo.Text = EmpleadoFrm.Cargo.Descripcion;
        }

        private void ObtenerDatosDeFormulario()
        {
            EmpleadoFrm.Legajo = int.Parse(txtLegajo.Text);
            EmpleadoFrm.Cargo_idCargo = ((Cargo)cbxCargo.SelectedItem).idCargo;
            PersonaFrm.Dni = int.Parse(txtDni.Text);
            PersonaFrm.Apellidos = txtApe.Text;
            PersonaFrm.Nombres = txtNom.Text;
            PersonaFrm.FechNac = Convert.ToDateTime(txtFecha.Text);
            PersonaFrm.Direccion = txtDireccion.Text;
            PersonaFrm.Correo = txtCorreo.Text;
            PersonaFrm.Telefono = txtTelefono.Text;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboBoxCargos()
        {
            cbxCargo.SelectedValue = "idCargo";
            cbxCargo.DisplayMember = "Descripcion";
            cbxCargo.DataSource = _empCn.ObtenerTodosLosCargos();
        }

        private bool ValidarCampos()
        {
            List<TextBox> listaTextBox = new List<TextBox>();
            listaTextBox.Add(txtLegajo);
            listaTextBox.Add(txtDni);
            listaTextBox.Add(txtApe);
            listaTextBox.Add(txtNom);
            listaTextBox.Add(txtDireccion);
            listaTextBox.Add(txtCorreo);
            listaTextBox.Add(txtTelefono);
            return validacion.ControlCampoNoVacio(listaTextBox);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloLetra(sender, e);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloLetra(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }
    }
}
