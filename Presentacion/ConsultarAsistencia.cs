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
    public partial class ConsultarAsistencia : Form

    {
        private PersonaCN _perCN = new PersonaCN();
        private PlanDeEstudioCN _plaCN = new PlanDeEstudioCN();
        private CursosCN _cuCN = new CursosCN();
        private InscripcionCN _inCN = new InscripcionCN();



        public ConsultarAsistencia()
        {
            InitializeComponent();
        }

        private void ConsultarAsistencia_Load(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(DateTime.Now);
            ConfigurarDataGrid();
            CargarComboBoxTraer();
        }

        private void ConfigurarDataGrid()
        {
            dataGridCon.Rows.Clear();
            dataGridCon.ColumnCount = 6;
            dataGridCon.Columns[0].Name = "Id";
            dataGridCon.Columns[0].ReadOnly = true;
            dataGridCon.Columns[0].Visible = false;
            dataGridCon.Columns[1].Name = "Id-Alumno";
            dataGridCon.Columns[1].ReadOnly = true;
            dataGridCon.Columns[1].Visible = false;
            dataGridCon.Columns[2].Name = "Legajo";
            dataGridCon.Columns[2].ReadOnly = true;
            dataGridCon.Columns[3].Name = "DNI";
            dataGridCon.Columns[3].ReadOnly = true;
            dataGridCon.Columns[4].Name = "Alumno";
            dataGridCon.Columns[4].ReadOnly = true;
            dataGridCon.Columns[5].Name = "Asistencia";
            dataGridCon.Columns[5].ReadOnly = true;

        }

        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridCon.Rows.Clear();
            int idCurso = ((vw_CursosConInscripcion)cbxTraer.SelectedItem).id;
            var lista = _inCN.ObtenerListadosDeInscipcionesPorCurso(idCurso);
            foreach (Inscripcion inscripcion in lista)
            {
                inscripcion.Alumno.Persona = _perCN.ObtenerPersonaPorId(inscripcion.Alumno.Persona_idPersona);
                renglon = dataGridCon.Rows.Add();
                dataGridCon.Rows[renglon].Cells["Id"].Value = inscripcion.idInscripcion;
                dataGridCon.Rows[renglon].Cells["Id-Alumno"].Value = inscripcion.Alumno.idAlumno;
                dataGridCon.Rows[renglon].Cells["Legajo"].Value = inscripcion.Alumno.Legajo;
                dataGridCon.Rows[renglon].Cells["DNI"].Value = inscripcion.Alumno.Persona.Dni;
                dataGridCon.Rows[renglon].Cells["Alumno"].Value = inscripcion.Alumno.Persona.Apellidos + ", " + inscripcion.Alumno.Persona.Nombres;
                dataGridCon.Rows[renglon].Cells["Asistencia"].Value = "    ";
            }
        }

        private void CargarComboBoxTraer()
        {

            cbxTraer.SelectedValue = "id";
            cbxTraer.DisplayMember = "detalle";
            List<vw_CursosConInscripcion> lista = new List<vw_CursosConInscripcion>();
            lista = _cuCN.ObtenerCursosConInscripcion();
            lista.Add(new vw_CursosConInscripcion() { id = 0, detalle = "- seleccione el curso-" });
            cbxTraer.DataSource = lista.OrderBy(x => x.id).ToList();

        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            txtFecha.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCurso = ((vw_CursosConInscripcion)cbxTraer.SelectedItem).id;
            CargarDataGrid();
        }
    }
}
