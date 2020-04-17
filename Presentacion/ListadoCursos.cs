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
    
    public partial class ListadoCursos : Form
    {

        private CursosCN _cuCN = new CursosCN();
        private PersonaCN _perCN = new PersonaCN();
        private EmpleadoCN _empCN = new EmpleadoCN();
        public ListadoCursos()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            CargarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            dataGridCurso.Rows.Clear();
            dataGridCurso.ColumnCount = 8;
            dataGridCurso.Columns[0].Name = "Id";
            dataGridCurso.Columns[0].ReadOnly = true;
            dataGridCurso.Columns[0].Visible = false;
            dataGridCurso.Columns[1].Name = "Id-PlanDeEstudio";
            dataGridCurso.Columns[1].ReadOnly = true;
            dataGridCurso.Columns[1].Visible = false;
            dataGridCurso.Columns[2].Name = "PlandeEstudio";
            dataGridCurso.Columns[2].ReadOnly = true;
            dataGridCurso.Columns[3].Name = "Fecha Inicial";
            dataGridCurso.Columns[3].ReadOnly = true;
            dataGridCurso.Columns[4].Name = "Fecha Final";
            dataGridCurso.Columns[4].ReadOnly = true;
            dataGridCurso.Columns[5].Name = "Cupo";
            dataGridCurso.Columns[5].ReadOnly = true;
            dataGridCurso.Columns[6].Name = "Id-Empleado";
            dataGridCurso.Columns[6].ReadOnly = true;
            dataGridCurso.Columns[6].Visible = false;
            dataGridCurso.Columns[7].Name = "Profesor";
            dataGridCurso.Columns[7].ReadOnly = true;  
        }

        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridCurso.Rows.Clear();
            var lista = _cuCN.obtenerTodosLosCursos();
            foreach (Curso cursos in _cuCN.obtenerTodosLosCursos())
            {
                cursos.Empleado.Persona = _perCN.ObtenerPersonaPorId(cursos.Empleado.Persona_idPersona);
                renglon = dataGridCurso.Rows.Add();


                dataGridCurso.Rows[renglon].Cells["Id"].Value = cursos.idCursos;

                dataGridCurso.Rows[renglon].Cells["Id-PlanDeEstudio"].Value = cursos.PlanDeEstudio_idPlanDeEstudio;
                dataGridCurso.Rows[renglon].Cells["PlandeEstudio"].Value = cursos.PlanDeEstudio.Nombre;

                dataGridCurso.Rows[renglon].Cells["Fecha Inicial"].Value = cursos.FechaIncial;
                dataGridCurso.Rows[renglon].Cells["Fecha Final"].Value = cursos.FechaFinal;
                
                dataGridCurso.Rows[renglon].Cells["Cupo"].Value = cursos.CupoMax;

                dataGridCurso.Rows[renglon].Cells["Id-Empleado"].Value = cursos.Empleado_idEmpleado;
                dataGridCurso.Rows[renglon].Cells["Profesor"].Value = cursos.Empleado.Persona.Apellidos + ", " + cursos.Empleado.Persona.Nombres;

            }
        }

        private void ListadoCursos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GestionCursos cu = new GestionCursos();
            cu.TipoGestion = "alta";
            cu.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            GestionCursos cu = new GestionCursos();
            cu.CursoFrm.idCursos = (int)dataGridCurso.CurrentRow.Cells["Id"].Value;
            cu.TipoGestion = "modi";
            cu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestionCursos cu = new GestionCursos();
            cu.CursoFrm.idCursos = (int)dataGridCurso.CurrentRow.Cells["Id"].Value;
            cu.TipoGestion = "baja";
            cu.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }
    }
}
