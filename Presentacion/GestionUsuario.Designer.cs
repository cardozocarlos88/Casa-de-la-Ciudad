namespace Presentacion
{
    partial class GestionUsuario
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
            this.cbxPerfil = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.txtLegApeNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPerfil.FormattingEnabled = true;
            this.cbxPerfil.Location = new System.Drawing.Point(116, 121);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Size = new System.Drawing.Size(185, 21);
            this.cbxPerfil.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 126);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Perfil de Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(116, 56);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(185, 20);
            this.txtClave.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Clave";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(212, 158);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 30);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Salir";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Empleado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 48;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Usuario";
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(127, 158);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(71, 30);
            this.btnAccion.TabIndex = 46;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(116, 89);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(185, 21);
            this.cbxEmp.TabIndex = 66;
            this.cbxEmp.SelectedIndexChanged += new System.EventHandler(this.cbxEmp_SelectedIndexChanged);
            // 
            // txtLegApeNom
            // 
            this.txtLegApeNom.Location = new System.Drawing.Point(116, 89);
            this.txtLegApeNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegApeNom.Name = "txtLegApeNom";
            this.txtLegApeNom.Size = new System.Drawing.Size(185, 20);
            this.txtLegApeNom.TabIndex = 67;
            this.txtLegApeNom.Visible = false;
            // 
            // GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 227);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.txtLegApeNom);
            this.Name = "GestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Usuario";
            this.Load += new System.EventHandler(this.GestionUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPerfil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.TextBox txtLegApeNom;
    }
}