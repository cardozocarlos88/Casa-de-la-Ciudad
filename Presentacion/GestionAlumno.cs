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
        private Persona persona = new Persona();
        private Alumno alumno = new Alumno();
        private string tipoGestion;

        public Persona Persona { get => persona; set => persona = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }

        private PersonaCN _perCn = new PersonaCN();
        private AlumnoCN _aluCn = new AlumnoCN();

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
                    alumno = _aluCn.ObtenerAlumnoPorId(alumno.idAlumno);
                    CargarAlumnoAFormulario();
                    //txtLegajo.Enabled = false;
                    txtDni.Enabled = false;
                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    alumno = _aluCn.ObtenerAlumnoPorId(alumno.idAlumno);
                    CargarAlumnoAFormulario();
                    txtLegajo.Enabled = false;
                    txtDni.Enabled = false;
                    txtApe.Enabled = false;
                    txtNom.Enabled = false;
                    txtFechaNac.Enabled = false;
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
                    ObtenerDatosDeFormulario();
                    _perCn.GuardarPersona(persona);
                    alumno.Persona_idPersona = persona.idPersona;
                    _aluCn.GuardarAlumno(alumno);
                    break;
                case "modi":
                    ObtenerDatosDeFormulario();
                    _aluCn.EditarAlumno(alumno);
                    break;
                case "baja":
                    _aluCn.EliminarAlumno(alumno);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void CargarAlumnoAFormulario()
        {
            txtLegajo.Text = Convert.ToString(alumno.Legajo);
            //alumno.Activo = "S";  // a este hay q pasarlo a un combo
            txtDni.Text = Convert.ToString(alumno.Persona.Dni);
            txtApe.Text = alumno.Persona.Apellidos;
            txtNom.Text = alumno.Persona.Nombres;
            txtFechaNac.Text = Convert.ToString(alumno.Persona.FechNac);
            txtDireccion.Text = alumno.Persona.Direccion;
            txtCorreo.Text = alumno.Persona.Correo;
            txtTelefono.Text = alumno.Persona.Telefono;
        }

        private void ObtenerDatosDeFormulario()
        {
            alumno.Legajo = int.Parse(txtLegajo.Text);
            alumno.Activo = "S"; // a este hay q traerlo de la vista
            persona.Dni = int.Parse(txtDni.Text);
            persona.Apellidos = txtApe.Text;
            persona.Nombres = txtNom.Text;
            persona.FechNac = DateTime.Now;
            persona.Direccion = txtDireccion.Text;
            persona.Correo = txtCorreo.Text;
            persona.Telefono = txtTelefono.Text;
        }
        
    }
}
