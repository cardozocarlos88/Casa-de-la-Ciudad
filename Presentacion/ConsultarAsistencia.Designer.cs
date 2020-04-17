namespace Presentacion
{
    partial class ConsultarAsistencia
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
            this.cbxTraer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridCon = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxTraer
            // 
            this.cbxTraer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTraer.FormattingEnabled = true;
            this.cbxTraer.Location = new System.Drawing.Point(87, 27);
            this.cbxTraer.Name = "cbxTraer";
            this.cbxTraer.Size = new System.Drawing.Size(346, 21);
            this.cbxTraer.TabIndex = 0;
            this.cbxTraer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // dataGridCon
            // 
            this.dataGridCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCon.Location = new System.Drawing.Point(31, 96);
            this.dataGridCon.Name = "dataGridCon";
            this.dataGridCon.Size = new System.Drawing.Size(434, 208);
            this.dataGridCon.TabIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(31, 322);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(78, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(387, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(87, 54);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(166, 20);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha ";
            // 
            // ConsultarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(509, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dataGridCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTraer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ConsultarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Asistencia";
            this.Load += new System.EventHandler(this.ConsultarAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTraer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridCon;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
    }
}