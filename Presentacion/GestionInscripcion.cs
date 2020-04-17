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
    public partial class GestionInscripcion : Form
    {
        private Alumno alumnoFrm = new Alumno();
        private Inscripcion inscripcion = new Inscripcion();
        private Usuario userSession = new Usuario();
        private string tipoGestion;

        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }
        public Inscripcion InscripcionFrm { get => inscripcion; set => inscripcion = value; }
        public Usuario UserSession { get => userSession; set => userSession = value; }




        private AlumnoCN _aluCN = new AlumnoCN();
        private InscripcionCN _insCN = new InscripcionCN();
        private PersonaCN _perCN = new PersonaCN();
        private PlanDeEstudioCN _plaCN = new PlanDeEstudioCN();
        private CursosCN _cuCN = new CursosCN();

        ValidacionYControles validacion = new ValidacionYControles();

        public GestionInscripcion()
        {
            InitializeComponent();

        }

        private void GestionInscripcion_Load(object sender, EventArgs e)
        {

            switch (tipoGestion)
            {
                case "alta":
                    CargarComboBoxCursos();
                    btnAccion.Text = "Guardar";
                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    break;


                default:
                    Console.WriteLine("default");
                    break;
            }

        }

        private void CargarInsAFormulario()
        {
            cbxCursos.Text = InscripcionFrm.Curso.PlanDeEstudio.Nombre;
            txtDni.Text = Convert.ToString(InscripcionFrm.Alumno.Persona.Dni);
            txtLegajo.Text = Convert.ToString(InscripcionFrm.Alumno.Legajo);
            txtApellNom.Text = InscripcionFrm.Alumno.Persona.Apellidos + ", " + InscripcionFrm.Alumno.Persona.Nombres;
            txtFecha.Text = Convert.ToString(InscripcionFrm.Fecha);

        }

        private void ObtenerDatosDeFormularioAltaIns()
        {
            InscripcionFrm.Curso_idCursos = ((vw_CursoPlanDeEstudio)cbxCursos.SelectedItem).id;
            //InscripcionFrm.Usuario_idUsuario = InscripcionFrm.Usuario_idUsuario;
            //InscripcionFrm.Alumno.Persona.Dni= int.Parse(txtDni.Text);
            InscripcionFrm.Fecha = DateTime.Now;
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            alumnoFrm = _aluCN.ObtenerAlumnoPorDocumento(int.Parse(txtDni.Text));
            InscripcionFrm.Alumno_idAlumno = alumnoFrm.idAlumno;
            txtLegajo.Text = Convert.ToString(alumnoFrm.Legajo);
            txtApellNom.Text = alumnoFrm.Persona.Apellidos + "," + alumnoFrm.Persona.Nombres;
        }

        private void CargarComboBoxCursos()
        {
            cbxCursos.SelectedValue = "id";
            cbxCursos.DisplayMember = "Detalle";
            cbxCursos.DataSource = _cuCN.ObtenerCursosConPlanDeEstudio();// CORREGIR METODO 
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormularioAltaIns();
                        InscripcionFrm.Usuario_idUsuario = userSession.idUsuario;
                        _insCN.GuardarInsc(InscripcionFrm);
                        MessageBox.Show("Inscripcion registrada con exito");
                        this.Close();
                    }
                    break;

                case "baja":
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private bool ValidarCampos()
        {
            List<TextBox> listaTextBox = new List<TextBox>();
            listaTextBox.Add(txtDni);
            listaTextBox.Add(txtLegajo);
            listaTextBox.Add(txtApellNom);
           
            return validacion.ControlCampoNoVacio(listaTextBox);
        }

        private void cbxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtApellNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }
    }


    
}
