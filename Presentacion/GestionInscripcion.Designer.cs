namespace Presentacion
{
    partial class GestionInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.dni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellNom = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // cbxCursos
            // 
            this.cbxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(104, 32);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(288, 21);
            this.cbxCursos.TabIndex = 1;
            this.cbxCursos.SelectedIndexChanged += new System.EventHandler(this.cbxCursos_SelectedIndexChanged);
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(37, 65);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(61, 13);
            this.dni.TabIndex = 2;
            this.dni.Text = "Dni Alumno";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(104, 62);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(167, 20);
            this.txtDni.TabIndex = 3;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(287, 59);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAlumno.TabIndex = 4;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Legajo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alumno";
            // 
            // txtApellNom
            // 
            this.txtApellNom.Enabled = false;
            this.txtApellNom.Location = new System.Drawing.Point(104, 124);
            this.txtApellNom.Name = "txtApellNom";
            this.txtApellNom.Size = new System.Drawing.Size(258, 20);
            this.txtApellNom.TabIndex = 8;
            this.txtApellNom.TextChanged += new System.EventHandler(this.txtApellNom_TextChanged);
            this.txtApellNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellNom_KeyPress);
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(104, 92);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(167, 20);
            this.txtLegajo.TabIndex = 9;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(358, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(265, 193);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 23);
            this.btnAccion.TabIndex = 12;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(104, 154);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(125, 20);
            this.txtFecha.TabIndex = 14;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // GestionInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 237);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtApellNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.label1);
            this.Name = "GestionInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Inscripciones";
            this.Load += new System.EventHandler(this.GestionInscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellNom;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}