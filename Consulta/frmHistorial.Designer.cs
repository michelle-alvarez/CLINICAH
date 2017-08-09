namespace Consulta
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdDetalle = new System.Windows.Forms.DataGridView();
            this.idconsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtFenotipo = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lbxPato = new System.Windows.Forms.ListBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Historial = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbxAlergias = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 363);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 121;
            this.label5.Text = "Alergias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Observaciones:";
            // 
            // GrdDetalle
            // 
            this.GrdDetalle.AllowUserToAddRows = false;
            this.GrdDetalle.AllowUserToDeleteRows = false;
            this.GrdDetalle.AllowUserToOrderColumns = true;
            this.GrdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconsulta,
            this.fecha,
            this.nombre,
            this.campus,
            this.medico,
            this.precedimiento,
            this.observacion});
            this.GrdDetalle.Location = new System.Drawing.Point(12, 25);
            this.GrdDetalle.Name = "GrdDetalle";
            this.GrdDetalle.ReadOnly = true;
            this.GrdDetalle.Size = new System.Drawing.Size(1100, 334);
            this.GrdDetalle.TabIndex = 100;
            // 
            // idconsulta
            // 
            this.idconsulta.HeaderText = "Código";
            this.idconsulta.Name = "idconsulta";
            this.idconsulta.ReadOnly = true;
            this.idconsulta.Visible = false;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Paciente";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // campus
            // 
            this.campus.HeaderText = "Campus";
            this.campus.Name = "campus";
            this.campus.ReadOnly = true;
            this.campus.Width = 150;
            // 
            // medico
            // 
            this.medico.HeaderText = "Médico";
            this.medico.Name = "medico";
            this.medico.ReadOnly = true;
            this.medico.Width = 150;
            // 
            // precedimiento
            // 
            this.precedimiento.HeaderText = "Procedimiento";
            this.precedimiento.Name = "precedimiento";
            this.precedimiento.ReadOnly = true;
            this.precedimiento.Width = 150;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Width = 150;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(419, 427);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(128, 20);
            this.txtPeso.TabIndex = 119;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(370, 429);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(34, 13);
            this.Label12.TabIndex = 118;
            this.Label12.Text = "Peso:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(75, 422);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.ReadOnly = true;
            this.txtAltura.Size = new System.Drawing.Size(128, 20);
            this.txtAltura.TabIndex = 117;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(23, 425);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(37, 13);
            this.Label11.TabIndex = 116;
            this.Label11.Text = "Altura:";
            // 
            // txtFenotipo
            // 
            this.txtFenotipo.Location = new System.Drawing.Point(419, 398);
            this.txtFenotipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFenotipo.Name = "txtFenotipo";
            this.txtFenotipo.ReadOnly = true;
            this.txtFenotipo.Size = new System.Drawing.Size(128, 20);
            this.txtFenotipo.TabIndex = 104;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(321, 401);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(83, 13);
            this.Label10.TabIndex = 115;
            this.Label10.Text = "Tipo de Sangre:";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(75, 366);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.ReadOnly = true;
            this.txtCarrera.Size = new System.Drawing.Size(472, 20);
            this.txtCarrera.TabIndex = 103;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(13, 488);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(534, 116);
            this.txtObservacion.TabIndex = 113;
            // 
            // lbxPato
            // 
            this.lbxPato.FormattingEnabled = true;
            this.lbxPato.Location = new System.Drawing.Point(794, 383);
            this.lbxPato.Margin = new System.Windows.Forms.Padding(4);
            this.lbxPato.Name = "lbxPato";
            this.lbxPato.Size = new System.Drawing.Size(197, 212);
            this.lbxPato.TabIndex = 112;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(791, 363);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(112, 13);
            this.Label7.TabIndex = 111;
            this.Label7.Text = "Patologias Conocidas:";
            // 
            // Historial
            // 
            this.Historial.AutoSize = true;
            this.Historial.Location = new System.Drawing.Point(13, 9);
            this.Historial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(84, 13);
            this.Historial.TabIndex = 110;
            this.Historial.Text = "Historial medico:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(11, 369);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 13);
            this.Label6.TabIndex = 109;
            this.Label6.Text = "Carrera:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(75, 394);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(128, 20);
            this.txtEdad.TabIndex = 102;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(23, 395);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 108;
            this.Label3.Text = "Edad:";
            // 
            // lbxAlergias
            // 
            this.lbxAlergias.FormattingEnabled = true;
            this.lbxAlergias.Location = new System.Drawing.Point(566, 383);
            this.lbxAlergias.Margin = new System.Windows.Forms.Padding(4);
            this.lbxAlergias.Name = "lbxAlergias";
            this.lbxAlergias.Size = new System.Drawing.Size(220, 212);
            this.lbxAlergias.TabIndex = 105;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Consulta.Properties.Resources.salir;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(1022, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 57);
            this.btnExit.TabIndex = 149;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 617);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdDetalle);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtFenotipo);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lbxPato);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lbxAlergias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial del Paciente";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdDetalle;
        internal System.Windows.Forms.TextBox txtPeso;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtAltura;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtFenotipo;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtCarrera;
        internal System.Windows.Forms.TextBox txtObservacion;
        internal System.Windows.Forms.ListBox lbxPato;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Historial;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtEdad;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox lbxAlergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn campus;
        private System.Windows.Forms.DataGridViewTextBoxColumn medico;
        private System.Windows.Forms.DataGridViewTextBoxColumn precedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.Button btnExit;
    }
}