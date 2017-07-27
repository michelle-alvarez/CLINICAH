namespace Pacientes
{
    partial class FrmPacientes
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbfemenino = new System.Windows.Forms.RadioButton();
            this.rdbmasculino = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combocarrera = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboetnia = new System.Windows.Forms.ComboBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.datagridx = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.combosangre = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.TabAP = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbxalergias = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxpade = new System.Windows.Forms.ListBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnagregarnuevoap = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtnuevo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridx)).BeginInit();
            this.TabAP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(111, 186);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(250, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Nacimiento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combotipo
            // 
            this.combotipo.Enabled = false;
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(106, 298);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(249, 21);
            this.combotipo.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbfemenino);
            this.groupBox1.Controls.Add(this.rdbmasculino);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 44);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genero";
            // 
            // rdbfemenino
            // 
            this.rdbfemenino.AutoSize = true;
            this.rdbfemenino.Location = new System.Drawing.Point(99, 16);
            this.rdbfemenino.Name = "rdbfemenino";
            this.rdbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbfemenino.TabIndex = 1;
            this.rdbfemenino.TabStop = true;
            this.rdbfemenino.Text = "Femenino";
            this.rdbfemenino.UseVisualStyleBackColor = true;
            // 
            // rdbmasculino
            // 
            this.rdbmasculino.AutoSize = true;
            this.rdbmasculino.Location = new System.Drawing.Point(3, 16);
            this.rdbmasculino.Name = "rdbmasculino";
            this.rdbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbmasculino.TabIndex = 0;
            this.rdbmasculino.TabStop = true;
            this.rdbmasculino.Text = "Masculino";
            this.rdbmasculino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Carrera:";
            // 
            // combocarrera
            // 
            this.combocarrera.Enabled = false;
            this.combocarrera.FormattingEnabled = true;
            this.combocarrera.Location = new System.Drawing.Point(106, 330);
            this.combocarrera.Name = "combocarrera";
            this.combocarrera.Size = new System.Drawing.Size(249, 21);
            this.combocarrera.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboetnia);
            this.groupBox2.Controls.Add(this.txtaltura);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtpeso);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 89);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripcion Fisica";
            // 
            // comboetnia
            // 
            this.comboetnia.Enabled = false;
            this.comboetnia.Location = new System.Drawing.Point(74, 58);
            this.comboetnia.Name = "comboetnia";
            this.comboetnia.Size = new System.Drawing.Size(266, 21);
            this.comboetnia.TabIndex = 2;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(233, 26);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.ReadOnly = true;
            this.txtaltura.Size = new System.Drawing.Size(107, 20);
            this.txtaltura.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Etnia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Altura:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(74, 26);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.ReadOnly = true;
            this.txtpeso.Size = new System.Drawing.Size(79, 20);
            this.txtpeso.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Peso:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.txttelefono);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 452);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(74, 61);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(213, 20);
            this.txtemail.TabIndex = 1;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(73, 26);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.ReadOnly = true;
            this.txttelefono.Size = new System.Drawing.Size(213, 20);
            this.txttelefono.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefono:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtbusqueda);
            this.groupBox4.Location = new System.Drawing.Point(12, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(6, 19);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(337, 20);
            this.txtbusqueda.TabIndex = 0;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // datagridx
            // 
            this.datagridx.AllowUserToAddRows = false;
            this.datagridx.AllowUserToDeleteRows = false;
            this.datagridx.AllowUserToResizeColumns = false;
            this.datagridx.AllowUserToResizeRows = false;
            this.datagridx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.datagridx.Location = new System.Drawing.Point(12, 73);
            this.datagridx.Name = "datagridx";
            this.datagridx.ReadOnly = true;
            this.datagridx.Size = new System.Drawing.Size(349, 81);
            this.datagridx.TabIndex = 9;
            this.datagridx.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridx_CellContentClick);
            this.datagridx.SelectionChanged += new System.EventHandler(this.datagridx_SelectionChanged);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 306;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 3;
           
            this.button3.Location = new System.Drawing.Point(301, 664);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 48);
            this.button3.TabIndex = 17;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.Location = new System.Drawing.Point(162, 664);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 48);
            this.button2.TabIndex = 16;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Location = new System.Drawing.Point(10, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 48);
            this.button1.TabIndex = 15;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tipo de Sangre:";
            // 
            // combosangre
            // 
            this.combosangre.Enabled = false;
            this.combosangre.FormattingEnabled = true;
            this.combosangre.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.combosangre.Location = new System.Drawing.Point(289, 229);
            this.combosangre.Name = "combosangre";
            this.combosangre.Size = new System.Drawing.Size(72, 21);
            this.combosangre.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(216, 580);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(139, 21);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.Visible = false;
            // 
            // TabAP
            // 
            this.TabAP.Controls.Add(this.tabPage1);
            this.TabAP.Controls.Add(this.tabPage2);
            this.TabAP.Location = new System.Drawing.Point(10, 558);
            this.TabAP.Name = "TabAP";
            this.TabAP.SelectedIndex = 0;
            this.TabAP.Size = new System.Drawing.Size(200, 100);
            this.TabAP.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxalergias);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alergias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxalergias
            // 
            this.lbxalergias.Enabled = false;
            this.lbxalergias.FormattingEnabled = true;
            this.lbxalergias.Items.AddRange(new object[] {
            "Opcion\t",
            "Opcion\t",
            "Opcion"});
            this.lbxalergias.Location = new System.Drawing.Point(0, 3);
            this.lbxalergias.Name = "lbxalergias";
            this.lbxalergias.Size = new System.Drawing.Size(189, 69);
            this.lbxalergias.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxpade);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Padecimientos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxpade
            // 
            this.lbxpade.Enabled = false;
            this.lbxpade.FormattingEnabled = true;
            this.lbxpade.Items.AddRange(new object[] {
            "Opcion\t",
            "Opcion\t",
            "Opcion"});
            this.lbxpade.Location = new System.Drawing.Point(0, 3);
            this.lbxpade.Name = "lbxpade";
            this.lbxpade.Size = new System.Drawing.Size(189, 69);
            this.lbxpade.TabIndex = 1;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(111, 160);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(250, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Codigo:";
            // 
            // btnagregarnuevoap
            // 
            this.btnagregarnuevoap.Location = new System.Drawing.Point(242, 607);
            this.btnagregarnuevoap.Name = "btnagregarnuevoap";
            this.btnagregarnuevoap.Size = new System.Drawing.Size(28, 23);
            this.btnagregarnuevoap.TabIndex = 12;
            this.btnagregarnuevoap.Text = "+";
            this.btnagregarnuevoap.UseVisualStyleBackColor = true;
            this.btnagregarnuevoap.Visible = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(276, 607);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 23);
            this.btnnuevo.TabIndex = 13;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Visible = false;
            // 
            // txtnuevo
            // 
            this.txtnuevo.Location = new System.Drawing.Point(216, 636);
            this.txtnuevo.Name = "txtnuevo";
            this.txtnuevo.Size = new System.Drawing.Size(133, 20);
            this.txtnuevo.TabIndex = 14;
            this.txtnuevo.Visible = false;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(373, 724);
            this.Controls.Add(this.txtnuevo);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnagregarnuevoap);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TabAP);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.combosangre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagridx);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combocarrera);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridx)).EndInit();
            this.TabAP.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbfemenino;
        private System.Windows.Forms.RadioButton rdbmasculino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combocarrera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridView datagridx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combosangre;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TabControl TabAP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxalergias;
        private System.Windows.Forms.ListBox lbxpade;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboetnia;
        private System.Windows.Forms.Button btnagregarnuevoap;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtnuevo;
    }
}