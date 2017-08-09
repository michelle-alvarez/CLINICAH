namespace Medicos
{
    partial class frmPrivilegios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrivilegios));
            this.DGPrivilegios = new System.Windows.Forms.DataGridView();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipomedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cmbidentidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGPrivilegios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGPrivilegios
            // 
            this.DGPrivilegios.AllowUserToAddRows = false;
            this.DGPrivilegios.AllowUserToDeleteRows = false;
            this.DGPrivilegios.AllowUserToOrderColumns = true;
            this.DGPrivilegios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPrivilegios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipo,
            this.idmedico,
            this.tipomedico});
            this.DGPrivilegios.Location = new System.Drawing.Point(12, 12);
            this.DGPrivilegios.Name = "DGPrivilegios";
            this.DGPrivilegios.ReadOnly = true;
            this.DGPrivilegios.RowHeadersWidth = 20;
            this.DGPrivilegios.Size = new System.Drawing.Size(260, 150);
            this.DGPrivilegios.TabIndex = 0;
            // 
            // idtipo
            // 
            this.idtipo.HeaderText = "Tipo Medico";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Visible = false;
            // 
            // idmedico
            // 
            this.idmedico.HeaderText = "usuario";
            this.idmedico.Name = "idmedico";
            this.idmedico.ReadOnly = true;
            // 
            // tipomedico
            // 
            this.tipomedico.HeaderText = "Tipo Privilegio";
            this.tipomedico.Name = "tipomedico";
            this.tipomedico.ReadOnly = true;
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbtipo.Location = new System.Drawing.Point(168, 213);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(104, 21);
            this.cmbtipo.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Tipo de Seguridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Número Identidad:";
            // 
            // button1
            // 
            this.button1.Image = global::Medicos.Properties.Resources.if_meanicons_24_197210;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(59, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Medicos.Properties.Resources.userdelete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(186, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Medicos.Properties.Resources.exit;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(140, 295);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 49);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Medicos.Properties.Resources.if_Compose_2190985;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditar.Location = new System.Drawing.Point(105, 240);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 49);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click_1);
            // 
            // btnagregar
            // 
            this.btnagregar.Image = global::Medicos.Properties.Resources.adduser3;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(24, 240);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 49);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // cmbidentidad
            // 
            this.cmbidentidad.FormattingEnabled = true;
            this.cmbidentidad.Location = new System.Drawing.Point(16, 186);
            this.cmbidentidad.Name = "cmbidentidad";
            this.cmbidentidad.Size = new System.Drawing.Size(256, 21);
            this.cmbidentidad.TabIndex = 0;
            // 
            // frmPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 356);
            this.Controls.Add(this.cmbidentidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGPrivilegios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrivilegios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Privilegios";
            this.Load += new System.EventHandler(this.frmPrivilegios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGPrivilegios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGPrivilegios;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cmbidentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipomedico;
    }
}