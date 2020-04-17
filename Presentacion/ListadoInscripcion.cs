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
    public partial class ListadoInscripcion : Form
    {


        private PersonaCN _perCN = new PersonaCN();
        private PlanDeEstudioCN _plaCN = new PlanDeEstudioCN();
        private CursosCN _cuCN = new CursosCN();
        private InscripcionCN _inCN = new InscripcionCN();
        internal Usuario UserSession;

        public ListadoInscripcion()
        {
            InitializeComponent();
        }

        private void ListadoInscripcion_Load(object sender, EventArgs e)
        {
            ConfigurarDataGrid();
            CargarComboBoxTraer();
            CargarUsuarioSessionAFormulario();
        }

        private void ConfigurarDataGrid()
        {
            dataGridInsc.Rows.Clear();
            dataGridInsc.ColumnCount = 5;
            dataGridInsc.Columns[0].Name = "Id";
            dataGridInsc.Columns[0].ReadOnly = true;
            dataGridInsc.Columns[0].Visible = false;
            dataGridInsc.Columns[1].Name = "Id-Alumno";
            dataGridInsc.Columns[1].ReadOnly = true;
            dataGridInsc.Columns[1].Visible = false;
            dataGridInsc.Columns[2].Name = "Legajo";
            dataGridInsc.Columns[2].ReadOnly = true;
            dataGridInsc.Columns[3].Name = "Alumno";
            dataGridInsc.Columns[3].ReadOnly = true;
            dataGridInsc.Columns[4].Name = "Fecha de Insc";
            dataGridInsc.Columns[4].ReadOnly = true;
        }

        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridInsc.Rows.Clear();
            int idCurso = ((vw_CursosConInscripcion)cbxTraer.SelectedItem).id;
            var lista = _inCN.ObtenerListadosDeInscipcionesPorCurso(idCurso);
            foreach (Inscripcion inscripcion in lista)
            {
                inscripcion.Alumno.Persona = _perCN.ObtenerPersonaPorId(inscripcion.Alumno.Persona_idPersona);
                renglon = dataGridInsc.Rows.Add();
                dataGridInsc.Rows[renglon].Cells["Id"].Value = inscripcion.idInscripcion;
                dataGridInsc.Rows[renglon].Cells["Id-Alumno"].Value = inscripcion.Alumno.idAlumno;
                dataGridInsc.Rows[renglon].Cells["Legajo"].Value = inscripcion.Alumno.Legajo;
                dataGridInsc.Rows[renglon].Cells["Alumno"].Value = inscripcion.Alumno.Persona.Apellidos + ", " +inscripcion.Alumno.Persona.Nombres;
                dataGridInsc.Rows[renglon].Cells["Fecha de Insc"].Value = inscripcion.Fecha;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Realmente eliminar la inscripcion del Alumno?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                {
                    Inscripcion inscr = new Inscripcion();
                    int idInscr = 0;
                    try
                    {
                        idInscr = (int)dataGridInsc.CurrentRow.Cells["Id"].Value;
                        inscr = _inCN.ObtenerInscPorId(idInscr);
                        _inCN.EliminarInsc(inscr);
                        CargarDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("debe seleccioanr antes el curso");
                    }
                }
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestionInscripcion cu = new GestionInscripcion();
            cu.TipoGestion = "alta";
            cu.UserSession = UserSession;
            cu.Show(this);
        }

        private void CargarComboBoxTraer()
        {
           
            cbxTraer.SelectedValue = "id";
            cbxTraer.DisplayMember = "detalle";
            List<vw_CursosConInscripcion> lista = new List<vw_CursosConInscripcion>();
            lista = _cuCN.ObtenerCursosConInscripcion();
            lista.Add(new vw_CursosConInscripcion() { id = 0, detalle = "- seleccione -" });
            cbxTraer.DataSource = lista.OrderBy(x => x.id).ToList();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            int idCurso = ((vw_CursosConInscripcion)cbxTraer.SelectedItem).id;
            CargarDataGrid();


        }

       

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarUsuarioSessionAFormulario()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListadoInscripcion la = new ListadoInscripcion();
            la.Show();
            this.Close();
        }
    }
}
