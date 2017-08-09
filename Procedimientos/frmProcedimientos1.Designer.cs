namespace Procedimientos
{
    partial class frmProcedimientos1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcedimientos1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgProcedimientos = new System.Windows.Forms.DataGridView();
            this.procid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgSuministros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantsuministro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSuministro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescrip = new System.Windows.Forms.TextBox();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcedimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuministros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProcedimientos
            // 
            this.dtgProcedimientos.AllowUserToAddRows = false;
            this.dtgProcedimientos.AllowUserToDeleteRows = false;
            this.dtgProcedimientos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProcedimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procid,
            this.nombre,
            this.descripcion,
            this.nombrecat});
            this.dtgProcedimientos.Location = new System.Drawing.Point(18, 24);
            this.dtgProcedimientos.Name = "dtgProcedimientos";
            this.dtgProcedimientos.ReadOnly = true;
            this.dtgProcedimientos.Size = new System.Drawing.Size(266, 370);
            this.dtgProcedimientos.TabIndex = 44;
            this.dtgProcedimientos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProcedimientos_CellClick_1);
            // 
            // procid
            // 
            this.procid.HeaderText = "ID";
            this.procid.Name = "procid";
            this.procid.ReadOnly = true;
            this.procid.Width = 50;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Visible = false;
            this.descripcion.Width = 250;
            // 
            // nombrecat
            // 
            this.nombrecat.HeaderText = "Categoría";
            this.nombrecat.Name = "nombrecat";
            this.nombrecat.ReadOnly = true;
            this.nombrecat.Width = 75;
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(177, 409);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(41, 37);
            this.btneliminar.TabIndex = 43;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btPlus);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dgSuministros);
            this.groupBox1.Controls.Add(this.cbSuministro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDescrip);
            this.groupBox1.Controls.Add(this.cmbcategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(293, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 430);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(341, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 56);
            this.button2.TabIndex = 43;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.Location = new System.Drawing.Point(341, 157);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(99, 56);
            this.btPlus.TabIndex = 42;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(203, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(41, 37);
            this.btnGuardar.TabIndex = 41;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // dgSuministros
            // 
            this.dgSuministros.AllowUserToAddRows = false;
            this.dgSuministros.AllowUserToDeleteRows = false;
            this.dgSuministros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSuministros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSuministros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSuministros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idNombre,
            this.cantsuministro});
            this.dgSuministros.Location = new System.Drawing.Point(13, 136);
            this.dgSuministros.Name = "dgSuministros";
            this.dgSuministros.ReadOnly = true;
            this.dgSuministros.Size = new System.Drawing.Size(307, 169);
            this.dgSuministros.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // idNombre
            // 
            this.idNombre.HeaderText = "Nombre";
            this.idNombre.Name = "idNombre";
            this.idNombre.ReadOnly = true;
            // 
            // cantsuministro
            // 
            this.cantsuministro.HeaderText = "Cantidad";
            this.cantsuministro.Name = "cantsuministro";
            this.cantsuministro.ReadOnly = true;
            // 
            // cbSuministro
            // 
            this.cbSuministro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuministro.FormattingEnabled = true;
            this.cbSuministro.Location = new System.Drawing.Point(130, 325);
            this.cbSuministro.Margin = new System.Windows.Forms.Padding(2);
            this.cbSuministro.Name = "cbSuministro";
            this.cbSuministro.Size = new System.Drawing.Size(128, 21);
            this.cbSuministro.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Categoria:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(76, 26);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(154, 20);
            this.tbNombre.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nombre:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(340, 325);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(76, 20);
            this.tbCantidad.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad:";
            // 
            // tbDescrip
            // 
            this.tbDescrip.Location = new System.Drawing.Point(76, 60);
            this.tbDescrip.Multiline = true;
            this.tbDescrip.Name = "tbDescrip";
            this.tbDescrip.Size = new System.Drawing.Size(263, 62);
            this.tbDescrip.TabIndex = 21;
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(314, 26);
            this.cmbcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(128, 21);
            this.cmbcategoria.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Agregar Suministro";
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.Location = new System.Drawing.Point(75, 409);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(41, 37);
            this.btnagregar.TabIndex = 42;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click_1);
            // 
            // frmProcedimientos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 458);
            this.Controls.Add(this.dtgProcedimientos);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnagregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcedimientos1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedimientos";
            this.Load += new System.EventHandler(this.frmProcedimientos1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcedimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuministros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProcedimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn procid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecat;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgSuministros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantsuministro;
        private System.Windows.Forms.ComboBox cbSuministro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescrip;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnagregar;
    }
}