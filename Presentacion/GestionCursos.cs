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
    public partial class GestionCursos : Form
    {
        
        private Curso curso = new Curso();


        private string tipoGestion;

        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }
        public Curso CursoFrm { get => curso; set => curso = value; }



        private CursosCN _cuCN = new CursosCN();
        private EmpleadoCN _empCN = new EmpleadoCN();
        private PersonaCN _perCN = new PersonaCN();
        private PlanDeEstudioCN _plaCN = new PlanDeEstudioCN();

        ValidacionYControles validacion = new ValidacionYControles();



        public GestionCursos()
        {
            InitializeComponent();
           


        }

        private void GestionCursos_Load(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    btnAccion.Text = "Guardar";
                    CargarComboBoxEmpleados();
                    CargarComboBoxPlan();
                    break;

                case "modi":
                    btnAccion.Text = "Editar";
                    CursoFrm = _cuCN.ObtenerCursoPorId(CursoFrm.idCursos);
                    CargarComboBoxPlan();
                    CargarCursosAFormulario();
                    cbxPlan.Enabled = false;
                    cbxEmp.Enabled = false;
                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    CursoFrm = _cuCN.ObtenerCursoPorId(CursoFrm.idCursos);
                    CargarComboBoxPlan();
                    CargarCursosAFormulario();
                    cbxPlan.Enabled = false;
                    txtInicial.Enabled = false;
                    txtFinal.Enabled = false;
                    txtCmax.Enabled = false;
                    cbxEmp.Enabled = false;
                    txtLegApll.Enabled = false;

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
                        ObtenerDatosDeFormularioAlta();
                        _cuCN.GuardarCursos(CursoFrm);
                        MessageBox.Show("Curso registrado con exito");
                        this.Close();
                    }
               break;

                    case "modi":
                    if (ValidarCampos() == true)
                    { 
                        ObtenerDatosDeFormularioParaModif();
                        _cuCN.EditarCursos(CursoFrm);
                        MessageBox.Show("Curso Modificado con exito");
                        this.Close();
                    }
                    break;

                    case "baja":
                        _cuCN.EliminarCursos(CursoFrm);
                        MessageBox.Show("Curso eliminado con exito");
                        this.Close();
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
            }
        }

        private void CargarCursosAFormulario()
        {

            CursoFrm.Empleado.Persona = _perCN.ObtenerPersonaPorId(CursoFrm.Empleado.Persona_idPersona);
            cbxPlan.Text = CursoFrm.PlanDeEstudio.Nombre;
            txtInicial.Text = Convert.ToString(CursoFrm.FechaIncial);
            txtFinal.Text = Convert.ToString(CursoFrm.FechaFinal);
            txtCmax.Text = Convert.ToString(CursoFrm.CupoMax);
            txtLegApll.Visible = true;
            txtLegApll.Text = CursoFrm.Empleado.Persona.Apellidos + ", " + CursoFrm.Empleado.Persona.Nombres;
            txtLegApll.Enabled = false;
            cbxEmp.Visible = false;
            
        }


        private void ObtenerDatosDeFormularioAlta()
        {
            
            CursoFrm.PlanDeEstudio_idPlanDeEstudio = ((PlanDeEstudio)cbxPlan.SelectedItem).idPlanDeEstudio;
            CursoFrm.FechaIncial = Convert.ToDateTime(txtInicial.Text);  
            CursoFrm.FechaFinal = Convert.ToDateTime(txtFinal.Text);
            CursoFrm.CupoMax = int.Parse(txtCmax.Text);
            CursoFrm.Empleado_idEmpleado = ((vw_EmpleadoProfesor)cbxEmp.SelectedItem).id;
            
        }

        private void ObtenerDatosDeFormularioParaModif()
        {
            CursoFrm.FechaIncial = Convert.ToDateTime(txtInicial.Text);
            CursoFrm.FechaFinal = Convert.ToDateTime(txtFinal.Text);
            CursoFrm.CupoMax = int.Parse(txtCmax.Text);
        }


        private void CargarComboBoxPlan()
        {
            cbxPlan.SelectedValue = "idPlanDeEstudio";
            cbxPlan.DisplayMember = "Nombre";
            cbxPlan.DataSource = _plaCN.obtenerTodosLosPlanes();
        }


        private void CargarComboBoxEmpleados()
        {
            
            cbxEmp.SelectedValue = "id";
            cbxEmp.DisplayMember = "apeNom";
            cbxEmp.DataSource = _empCN.ObtenerEmpleadosProfesor();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void cbxPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            List<TextBox> listaTextBox = new List<TextBox>();
           // listaTextBox.Add(txtLegApll);
            listaTextBox.Add(txtCmax);
            return validacion.ControlCampoNoVacio(listaTextBox);
        }

        private void txtCmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtFfinal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }

        private void txtFfinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloNumero(sender, e);
        }
    }


}
