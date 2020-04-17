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
    public partial class GestionPlanDeEstudio : Form
    {

        private PlanDeEstudio planDeEstudio = new PlanDeEstudio();


        private string tipoGestion;

        public string TipoGestion { get => tipoGestion; set => tipoGestion = value; }
        public PlanDeEstudio PlanDeEstudioFrm { get => planDeEstudio; set => planDeEstudio = value; }

        private PlanDeEstudioCN _plaCn = new PlanDeEstudioCN();

        ValidacionYControles validacion = new ValidacionYControles();

        public GestionPlanDeEstudio()
        {
            InitializeComponent();
            
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void GestionPlanDeEstudio_Load(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    btnAccion.Text = "Guardar";
                    break;

                case "modi":
                    btnAccion.Text = "Editar";
                    PlanDeEstudioFrm = _plaCn.ObtenerPlanPorId(planDeEstudio.idPlanDeEstudio);
                    CargarPlanAFormulario();

                    break;

                case "baja":
                    btnAccion.Text = "Eliminar";
                    PlanDeEstudioFrm = _plaCn.ObtenerPlanPorId(planDeEstudio.idPlanDeEstudio);
                    CargarPlanAFormulario();
                    txtNombre.Enabled = false;
                    txtRango.Enabled = false; 
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }


        }

        private void CargarPlanAFormulario()
        {
       
            txtNombre.Text = PlanDeEstudioFrm.Nombre;
            txtRango.Text = PlanDeEstudioFrm.RandoEdad;
           
        }

        private void ObtenerDatosDeFormulario()
        {
            PlanDeEstudioFrm.Nombre = txtNombre.Text;
            PlanDeEstudioFrm.RandoEdad = txtRango.Text;
            

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (tipoGestion)
            {
                case "alta":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        _plaCn.GuardarPlan(PlanDeEstudioFrm);
                        MessageBox.Show("Plan de Estudio registrado con exito");
                        this.Close();
                    }
                    break;

                case "modi":
                    if (ValidarCampos() == true)
                    {
                        ObtenerDatosDeFormulario();
                        _plaCn.EditarPlan(PlanDeEstudioFrm);
                        MessageBox.Show("Plan de Estudio Modificado con exito");
                        this.Close();
                    }
                    break;

                case "baja":
                    _plaCn.EliminarPlan(PlanDeEstudioFrm);
                    MessageBox.Show("Plan de Estudio Eliminado");
                    this.Close();
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.GenericValidarDatoSoloLetra(sender, e);
        }

        private bool ValidarCampos()
        {
            List<TextBox> listaTextBox = new List<TextBox>();

            listaTextBox.Add(txtNombre);
            listaTextBox.Add(txtRango);
            return validacion.ControlCampoNoVacio(listaTextBox);
        }
    }
}
