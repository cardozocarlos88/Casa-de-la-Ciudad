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
    public partial class ListadoAlumnos : Form
    {

        private AlumnoCN _aluCn = new AlumnoCN();

        public ListadoAlumnos()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            CargarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            dataGridAlumnos.Rows.Clear();
            dataGridAlumnos.ColumnCount = 10;
            dataGridAlumnos.Columns[0].Name = "Id";
            dataGridAlumnos.Columns[0].ReadOnly = true;
            dataGridAlumnos.Columns[0].Visible = false;
            dataGridAlumnos.Columns[1].Name = "Legajo";
            dataGridAlumnos.Columns[1].ReadOnly = true;
            dataGridAlumnos.Columns[2].Name = "Id-Persona";
            dataGridAlumnos.Columns[2].ReadOnly = true;
            dataGridAlumnos.Columns[2].Visible = false;
            dataGridAlumnos.Columns[3].Name = "Apellidos";
            dataGridAlumnos.Columns[3].ReadOnly = true;
            dataGridAlumnos.Columns[4].Name = "Nombres";
            dataGridAlumnos.Columns[4].ReadOnly = true;
            dataGridAlumnos.Columns[5].Name = "Dni";
            dataGridAlumnos.Columns[5].ReadOnly = true;
            dataGridAlumnos.Columns[6].Name = "Nacimiento";
            dataGridAlumnos.Columns[6].ReadOnly = true;
            dataGridAlumnos.Columns[7].Name = "Direccion";
            dataGridAlumnos.Columns[7].ReadOnly = true;
            dataGridAlumnos.Columns[8].Name = "Telefono";
            dataGridAlumnos.Columns[8].ReadOnly = true;
            dataGridAlumnos.Columns[9].Name = "Correo";
            dataGridAlumnos.Columns[9].ReadOnly = true;
        }

        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridAlumnos.Rows.Clear();
            foreach (Alumno alu in _aluCn.obtenerTodosLosAlumnos())
            {
                renglon = dataGridAlumnos.Rows.Add();
                dataGridAlumnos.Rows[renglon].Cells["Id"].Value = alu.idAlumno;
                dataGridAlumnos.Rows[renglon].Cells["Legajo"].Value = alu.Legajo;
                dataGridAlumnos.Rows[renglon].Cells["Id-Persona"].Value = alu.Persona_idPersona;
                dataGridAlumnos.Rows[renglon].Cells["Apellidos"].Value = alu.Persona.Apellidos;
                dataGridAlumnos.Rows[renglon].Cells["Nombres"].Value = alu.Persona.Nombres;
                dataGridAlumnos.Rows[renglon].Cells["Dni"].Value = alu.Persona.Dni;
                dataGridAlumnos.Rows[renglon].Cells["Nacimiento"].Value = alu.Persona.FechNac;
                dataGridAlumnos.Rows[renglon].Cells["Direccion"].Value = alu.Persona.Direccion;
                dataGridAlumnos.Rows[renglon].Cells["Telefono"].Value = alu.Persona.Telefono;
                dataGridAlumnos.Rows[renglon].Cells["Correo"].Value = alu.Persona.Correo;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            
            GestionAlumno ga = new GestionAlumno();
            ga.TipoGestion = "alta";
            ga.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            GestionAlumno ga = new GestionAlumno();
            ga.AlumnoFrm.idAlumno = (int)dataGridAlumnos.CurrentRow.Cells["Id"].Value;
            ga.TipoGestion = "modi";
            ga.Show(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GestionAlumno ga = new GestionAlumno();
            ga.AlumnoFrm.idAlumno = (int)dataGridAlumnos.CurrentRow.Cells["Id"].Value;
            ga.TipoGestion = "baja";
            ga.Show();
        }

        private void ListadoAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void dataGridAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }
    }
}
