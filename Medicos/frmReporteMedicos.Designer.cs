namespace Medicos
{
    partial class frmReporteMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMedicos));
            this.datagridResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmtrimestre = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcampus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbcarrera = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridResultados
            // 
            this.datagridResultados.AllowUserToAddRows = false;
            this.datagridResultados.AllowUserToDeleteRows = false;
            this.datagridResultados.AllowUserToOrderColumns = true;
            this.datagridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridResultados.Location = new System.Drawing.Point(12, 82);
            this.datagridResultados.Name = "datagridResultados";
            this.datagridResultados.ReadOnly = true;
            this.datagridResultados.Size = new System.Drawing.Size(908, 302);
            this.datagridResultados.TabIndex = 0;
            this.datagridResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridResultados_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(762, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trimestre";
            // 
            // cbmtrimestre
            // 
            this.cbmtrimestre.FormattingEnabled = true;
            this.cbmtrimestre.Location = new System.Drawing.Point(297, 45);
            this.cbmtrimestre.Name = "cbmtrimestre";
            this.cbmtrimestre.Size = new System.Drawing.Size(121, 21);
            this.cbmtrimestre.TabIndex = 6;
            this.cbmtrimestre.SelectedIndexChanged += new System.EventHandler(this.cbmtrimestre_SelectedIndexChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(69, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(620, 20);
            this.txtnombre.TabIndex = 7;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Campus";
            // 
            // cmbcampus
            // 
            this.cmbcampus.FormattingEnabled = true;
            this.cmbcampus.Location = new System.Drawing.Point(63, 45);
            this.cmbcampus.Name = "cmbcampus";
            this.cmbcampus.Size = new System.Drawing.Size(121, 21);
            this.cmbcampus.TabIndex = 9;
            this.cmbcampus.SelectedIndexChanged += new System.EventHandler(this.cmbcampus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Especialidad";
            // 
            // cmbcarrera
            // 
            this.cmbcarrera.FormattingEnabled = true;
            this.cmbcarrera.Location = new System.Drawing.Point(501, 45);
            this.cmbcarrera.Name = "cmbcarrera";
            this.cmbcarrera.Size = new System.Drawing.Size(188, 21);
            this.cmbcarrera.TabIndex = 11;
            this.cmbcarrera.SelectedIndexChanged += new System.EventHandler(this.cmbcarrera_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(762, -1);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exportar EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReporteMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbcarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbcampus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.cbmtrimestre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.datagridResultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Médicos";
            this.Load += new System.EventHandler(this.frmReporteMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmtrimestre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcampus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbcarrera;

        private System.Windows.Forms.BindingSource medicosBindingSource;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}