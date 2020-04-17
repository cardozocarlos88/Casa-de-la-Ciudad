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
    public partial class GestionAlumno : Form
    {
        private Alumno alumno = new Alumno();
        private Persona persona = new Persona();
        private string tipoGestion;

        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }
        public Alumno AlumnoFrm { get => alumno; set => alumno = value; }
        public Persona PersonaFrm { get => persona; set => persona = value; }

        private PersonaCN _perCn = new PersonaCN();
        private AlumnoCN _aluCn = new AlumnoCN();

        ValidacionYControles validacion = new ValidacionYControles();

        public GestionAlumno()
        {
            InitializeComponent();
        }

        private void GestionAlumno_Load(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    btnAccion.Text = "Guardar";
                    break;

                case "modi":
                    btnAccion.Text = "Editar";
                    AlumnoFrm = _aluCn.ObtenerAlumnoPorId(AlumnoFrm.idAlumno);
                    CargarAlumnoAFormulario();
                    txtLegajo.Enabled = false;

                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    AlumnoFrm = _aluCn.ObtenerAlumnoPorId(AlumnoFrm.idAlumno);
                    CargarAlumnoAFormulario();
                    txtLegajo.Enabled = false;
                    txtDni.Enabled = false;
                    txtApe.Enabled = false;
                    txtNom.Enabled = false;
                    txtFecha.Enabled = false;
                    txtDireccion.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtTelefono.Enabled = false;
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void BtnAccion_Click(object sender, EventArgs e)
        {

            switch (tipoGestion)
            {
                case "alta":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        _perCn.GuardarPersona(PersonaFrm);
                        AlumnoFrm.Persona_idPersona = PersonaFrm.idPersona;
                        _aluCn.GuardarAlumno(AlumnoFrm);
                        MessageBox.Show("Alumno registrado con exito");
                        this.Close();
                    }
                    break;
                case "modi":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        PersonaFrm.idPersona = AlumnoFrm.Persona_idPersona;
                        _aluCn.EditarAlumno(AlumnoFrm);
                        _perCn.EditarPersona(PersonaFrm);
                        MessageBox.Show("Alumno Modificado con exito");
                        this.Close();
                    }
                    break;
                case "baja":
                    PersonaFrm.idPersona = AlumnoFrm.Persona_idPersona;
                    _aluCn.EliminarAlumno(AlumnoFrm);
                    _perCn.EliminarPersona(PersonaFrm);
                    MessageBox.Show("Alumno Eliminado con exito");
                    this.Close();
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void CargarAlumnoAFormulario()
        {
            txtLegajo.Text = Convert.ToString(AlumnoFrm.Legajo);
            txtDni.Text = Convert.ToString(AlumnoFrm.Persona.Dni);
            txtApe.Text = AlumnoFrm.Persona.Apellidos;
            txtNom.Text = AlumnoFrm.Persona.Nombres;
            txtFecha.Text = Convert.ToString(AlumnoFrm.Persona.FechNac);
            txtDireccion.Text = AlumnoFrm.Persona.Direccion;
            txtCorreo.Text = AlumnoFrm.Persona.Correo;
            txtTelefono.Text = AlumnoFrm.Persona.Telefono;
        }

        private void ObtenerDatosDeFormulario()
        {
            AlumnoFrm.Legajo = int.Parse(txtLegajo.Text);
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

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloLetra(sender, e);
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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void dtimeFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
