namespace Medicos
{
    partial class frmMedicos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trimestreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechanacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniocarreraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoinicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnofinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtidentidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcarrera = new System.Windows.Forms.ComboBox();
            this.labelyear = new System.Windows.Forms.Label();
            this.cmbyear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbtrimestre = new System.Windows.Forms.ComboBox();
         
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
         
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trimestreDataGridViewTextBoxColumn,
            this.nombrecompletoDataGridViewTextBoxColumn,
            this.idmedicoDataGridViewTextBoxColumn,
            this.generoDataGridViewCheckBoxColumn,
            this.fechanacDataGridViewTextBoxColumn,
            this.estadocivilDataGridViewTextBoxColumn,
            this.especialidadDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.aniocarreraDataGridViewTextBoxColumn,
            this.campusDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.turnoinicialDataGridViewTextBoxColumn,
            this.turnofinalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // trimestreDataGridViewTextBoxColumn
            // 
            this.trimestreDataGridViewTextBoxColumn.DataPropertyName = "trimestre";
            this.trimestreDataGridViewTextBoxColumn.HeaderText = "trimestre";
            this.trimestreDataGridViewTextBoxColumn.Name = "trimestreDataGridViewTextBoxColumn";
            // 
            // nombrecompletoDataGridViewTextBoxColumn
            // 
            this.nombrecompletoDataGridViewTextBoxColumn.DataPropertyName = "nombrecompleto";
            this.nombrecompletoDataGridViewTextBoxColumn.HeaderText = "nombrecompleto";
            this.nombrecompletoDataGridViewTextBoxColumn.Name = "nombrecompletoDataGridViewTextBoxColumn";
            // 
            // idmedicoDataGridViewTextBoxColumn
            // 
            this.idmedicoDataGridViewTextBoxColumn.DataPropertyName = "idmedico";
            this.idmedicoDataGridViewTextBoxColumn.HeaderText = "idmedico";
            this.idmedicoDataGridViewTextBoxColumn.Name = "idmedicoDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewCheckBoxColumn
            // 
            this.generoDataGridViewCheckBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewCheckBoxColumn.HeaderText = "genero";
            this.generoDataGridViewCheckBoxColumn.Name = "generoDataGridViewCheckBoxColumn";
            // 
            // fechanacDataGridViewTextBoxColumn
            // 
            this.fechanacDataGridViewTextBoxColumn.DataPropertyName = "fechanac";
            this.fechanacDataGridViewTextBoxColumn.HeaderText = "fechanac";
            this.fechanacDataGridViewTextBoxColumn.Name = "fechanacDataGridViewTextBoxColumn";
            // 
            // estadocivilDataGridViewTextBoxColumn
            // 
            this.estadocivilDataGridViewTextBoxColumn.DataPropertyName = "estadocivil";
            this.estadocivilDataGridViewTextBoxColumn.HeaderText = "estadocivil";
            this.estadocivilDataGridViewTextBoxColumn.Name = "estadocivilDataGridViewTextBoxColumn";
            // 
            // especialidadDataGridViewTextBoxColumn
            // 
            this.especialidadDataGridViewTextBoxColumn.DataPropertyName = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.HeaderText = "especialidad";
            this.especialidadDataGridViewTextBoxColumn.Name = "especialidadDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // aniocarreraDataGridViewTextBoxColumn
            // 
            this.aniocarreraDataGridViewTextBoxColumn.DataPropertyName = "aniocarrera";
            this.aniocarreraDataGridViewTextBoxColumn.HeaderText = "aniocarrera";
            this.aniocarreraDataGridViewTextBoxColumn.Name = "aniocarreraDataGridViewTextBoxColumn";
            // 
            // campusDataGridViewTextBoxColumn
            // 
            this.campusDataGridViewTextBoxColumn.DataPropertyName = "campus";
            this.campusDataGridViewTextBoxColumn.HeaderText = "campus";
            this.campusDataGridViewTextBoxColumn.Name = "campusDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // turnoinicialDataGridViewTextBoxColumn
            // 
            this.turnoinicialDataGridViewTextBoxColumn.DataPropertyName = "turnoinicial";
            this.turnoinicialDataGridViewTextBoxColumn.HeaderText = "turnoinicial";
            this.turnoinicialDataGridViewTextBoxColumn.Name = "turnoinicialDataGridViewTextBoxColumn";
            // 
            // turnofinalDataGridViewTextBoxColumn
            // 
            this.turnofinalDataGridViewTextBoxColumn.DataPropertyName = "turnofinal";
            this.turnofinalDataGridViewTextBoxColumn.HeaderText = "turnofinal";
            this.turnofinalDataGridViewTextBoxColumn.Name = "turnofinalDataGridViewTextBoxColumn";
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "medicos";
            
            // 
            // dSmedicos
            // 
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(79, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(757, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // txtidentidad
            // 
            this.txtidentidad.Location = new System.Drawing.Point(125, 224);
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(287, 20);
            this.txtidentidad.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(125, 254);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(768, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(125, 337);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(768, 20);
            this.txtemail.TabIndex = 5;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(125, 363);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(768, 49);
            this.txtdireccion.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(125, 418);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(353, 20);
            this.txtpassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número Identidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dirección:";
            // 
            // cmbgenero
            // 
            this.cmbgenero.FormattingEnabled = true;
            this.cmbgenero.Location = new System.Drawing.Point(125, 283);
            this.cmbgenero.Name = "cmbgenero";
            this.cmbgenero.Size = new System.Drawing.Size(140, 21);
            this.cmbgenero.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Especialidad:";
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.FormattingEnabled = true;
            this.cmbcarrera.Location = new System.Drawing.Point(358, 281);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(140, 21);
            this.cmbcarrera.TabIndex = 16;
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.Location = new System.Drawing.Point(504, 286);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(81, 13);
            this.labelyear.TabIndex = 17;
            this.labelyear.Text = "Año de Carrera:";
            // 
            // cmbyear
            // 
            this.cmbyear.FormattingEnabled = true;
            this.cmbyear.Location = new System.Drawing.Point(588, 281);
            this.cmbyear.Name = "cmbyear";
            this.cmbyear.Size = new System.Drawing.Size(103, 21);
            this.cmbyear.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha Nacimiento:";
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnacimiento.Location = new System.Drawing.Point(781, 306);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(112, 20);
            this.dtpnacimiento.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Celular:";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(317, 309);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(140, 20);
            this.txtcelular.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 421);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Confirmar:";
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.Location = new System.Drawing.Point(540, 418);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.Size = new System.Drawing.Size(353, 20);
            this.txtconfirmacion.TabIndex = 25;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 448);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 49);
            this.btnagregar.TabIndex = 26;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(93, 448);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 49);
            this.btneditar.TabIndex = 27;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(761, 448);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 49);
            this.btnsalir.TabIndex = 28;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Campus:";
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(125, 310);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(140, 21);
            this.cmbCampus.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(469, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Estado Civil:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)"});
            this.cmbEstado.Location = new System.Drawing.Point(536, 308);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(140, 21);
            this.cmbEstado.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(698, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Trimestre:";
            // 
            // cmbtrimestre
            // 
            this.cmbtrimestre.FormattingEnabled = true;
            this.cmbtrimestre.Location = new System.Drawing.Point(754, 281);
            this.cmbtrimestre.Name = "cmbtrimestre";
            this.cmbtrimestre.Size = new System.Drawing.Size(140, 21);
            this.cmbtrimestre.TabIndex = 34;
            // 
            // medicosTableAdapter
            // 
         
            // 
            // frmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 509);
            this.Controls.Add(this.cmbtrimestre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbCampus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbyear);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.cmbcarrera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbgenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidentidad);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Médicos";
            this.Load += new System.EventHandler(this.frmMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtidentidad;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbgenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcarrera;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.ComboBox cmbyear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbtrimestre;
       
        private System.Windows.Forms.BindingSource medicosBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn trimestreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn generoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniocarreraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoinicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnofinalDataGridViewTextBoxColumn;
    }
}

