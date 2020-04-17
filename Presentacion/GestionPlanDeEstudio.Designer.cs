namespace Presentacion
{
    partial class GestionPlanDeEstudio
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
            this.txtRango = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRango
            // 
            this.txtRango.Location = new System.Drawing.Point(99, 65);
            this.txtRango.Margin = new System.Windows.Forms.Padding(2);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(185, 20);
            this.txtRango.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Rango de Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(99, 33);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 49;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 33);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 48;
            this.label.Text = "Nombre";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(193, 100);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(71, 30);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "Salir";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(108, 100);
            this.btnAccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(71, 30);
            this.btnAccion.TabIndex = 46;
            this.btnAccion.Text = "Aceptar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // GestionPlanDeEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 166);
            this.Controls.Add(this.txtRango);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAccion);
            this.Name = "GestionPlanDeEstudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Plan de Estudio";
            this.Load += new System.EventHandler(this.GestionPlanDeEstudio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAccion;
    }
}