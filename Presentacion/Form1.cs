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
    public partial class Form1 : Form
    {

        private AlumnoCN _aluCn = new AlumnoCN();

        public Form1()
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
            dataGridAlumnos.Columns[3].Name = "Apellido";
            dataGridAlumnos.Columns[3].ReadOnly = true;
            dataGridAlumnos.Columns[4].Name = "Nombre";
            dataGridAlumnos.Columns[4].ReadOnly = true;
            dataGridAlumnos.Columns[5].Name = "Dni";
            dataGridAlumnos.Columns[5].ReadOnly = true;
            dataGridAlumnos.Columns[6].Name = "Nacimiento";
            dataGridAlumnos.Columns[6].ReadOnly = true;
            dataGridAlumnos.Columns[7].Name = "Direccion";
            dataGridAlumnos.Columns[7].ReadOnly = true;
            dataGridAlumnos.Columns[8].Name = "Telefono";
            dataGridAlumnos.Columns[8].ReadOnly = true;
            dataGridAlumnos.Columns[9].Name = "Correro";
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
                dataGridAlumnos.Rows[renglon].Cells["apellido"].Value = alu.Persona.Apellidos;
                dataGridAlumnos.Rows[renglon].Cells["nombre"].Value = alu.Persona.Nombres;
                dataGridAlumnos.Rows[renglon].Cells["Dni"].Value = alu.Persona.Dni;
                dataGridAlumnos.Rows[renglon].Cells["Nacimiento"].Value = alu.Persona.FechNac;
                dataGridAlumnos.Rows[renglon].Cells["Direccion"].Value = alu.Persona.Direccion;
                dataGridAlumnos.Rows[renglon].Cells["Telefono"].Value = alu.Persona.Telefono;
                dataGridAlumnos.Rows[renglon].Cells["Correro"].Value = alu.Persona.Correo;
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
            ga.Alumno.idAlumno = (int)dataGridAlumnos.CurrentRow.Cells["Id"].Value;
            ga.TipoGestion = "modi";
            ga.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GestionAlumno ga = new GestionAlumno();
            ga.Alumno.idAlumno = (int)dataGridAlumnos.CurrentRow.Cells["Id"].Value;
            ga.TipoGestion = "baja";
            ga.Show();
        }
    }
}
