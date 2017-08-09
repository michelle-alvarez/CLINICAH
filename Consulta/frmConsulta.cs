using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;




namespace Consulta
{
    public partial class btnCancelar : Form
    {
        int flagdeestado = 0; // 0 haciendo nada, 1 consultando

        string cnx = "Server=localhost; Port= 5432; Database=clinicas; User Id=postgres; Password=unicah;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlMedicamentosCombo = "SELECT idmedicamentos,nombre,cantidad FROM administracion.medicamentos ORDER BY idmedicamentos ASC ";
        //string sqlMedicamentosCant = "SELECT idmedicamentos,nombre,cantidad FROM administracion.medicamentos ORDER BY idmedicamentos ASC ";
        string sqlPaciente = "SELECT idpaciente, nombre,(current_date- fechanac)/365 as edad, altura, peso, tiposangre FROM pacientes.paciente where idpaciente LIKE @paciente";

        string sqlAlergias = "select paciente.idpaciente, alegrias.nombre from pacientes.paciente inner join pacientes.alergias on paciente.idpaciente = alergias.idpaciente inner join administracion.lista_alergias as alegrias on alergias.idalergia = alegrias.idalergia where paciente.idpaciente LIKE  @paciente";
        string sqlPadecimientos = "select paciente.idpaciente, sscm.nombre from pacientes.paciente inner join pacientes.padecimientos on paciente.idpaciente = padecimientos.idpaciente inner join administracion.lista_padecimientos as sscm on sscm.idpadecimiento = padecimientos.idpadecimiento where paciente.idpaciente LIKE @paciente";
        string sqlProcedimientos = "SELECT procid,nombre FROM atencion.procedimientos ORDER BY procid ASC";

        NpgsqlDataAdapter dapaciente;
        NpgsqlDataAdapter damedicamentoscombo;
        NpgsqlDataAdapter daalergias;
        NpgsqlDataAdapter dapadecimientos;
        NpgsqlDataAdapter daprocedimientos;

        public btnCancelar()
        {
            InitializeComponent();
            dapaciente = new NpgsqlDataAdapter(sqlPaciente, cnx);
            damedicamentoscombo = new NpgsqlDataAdapter(sqlMedicamentosCombo, cnx);
            daalergias = new NpgsqlDataAdapter(sqlAlergias, cnx);
            dapadecimientos = new NpgsqlDataAdapter(sqlPadecimientos, cnx);
            daprocedimientos = new NpgsqlDataAdapter(sqlProcedimientos, cnx);
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Consulta.frmSearch serch = new Consulta.frmSearch();

            serch.ShowDialog();
            txtCuenta.Text = Resources.Propiedades.pacienteenconsulta;
            if (txtCuenta.Text != "")
            {
                activar();
                btnBusqueda.Enabled = false;
                aftersearch();
                flagdeestado = 1;
            }
        }

        private void aftersearch()
        {
            string consultado = Resources.Propiedades.pacienteenconsulta;
            ds = new DataSet();
            ////////////////////////////////////////////////////////////////////////////////////////
            ///                             pacientes dataset                                    ///
            ////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                dapaciente.SelectCommand.Parameters.AddWithValue("@paciente", consultado);
                dapaciente.Fill(ds, "pacientes");
                txtNombre.DataBindings.Add("text", ds.Tables["pacientes"], "nombre");
                txtEdad.DataBindings.Add("text", ds.Tables["pacientes"], "edad");
                txtAltura.DataBindings.Add("text", ds.Tables["pacientes"], "altura");
                txtPeso.DataBindings.Add("text", ds.Tables["pacientes"], "peso");
                txtTipoS.DataBindings.Add("text", ds.Tables["pacientes"], "tiposangre");
                //idpaciente, nombre,(current_date- fechanac)/365 as edad, altura, peso, tiposangre FROM pacientes.paciente
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            ////////////////////////////////////////////////////////////////////////////////////////
            ///                             medicamentos dataset                                 ///
            ////////////////////////////////////////////////////////////////////////////////////////            
            try
            {
                damedicamentoscombo.Fill(ds, "medicamentos");
                cmbMed.DataSource = ds.Tables["medicamentos"];
                cmbMed.DisplayMember = "nombre";
                cmbMed.ValueMember = "idmedicamentos";
                textBox1.DataBindings.Add("text", ds.Tables["medicamentos"], "cantidad");

                //idpaciente, paciente,(current_date- fechanac)/365, altura, peso, tiposangre

            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            ////////////////////////////////////////////////////////////////////////////////////////
            ///                             alergias dataset                                     ///
            ////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                daalergias.SelectCommand.Parameters.AddWithValue("@paciente", consultado);
                daalergias.Fill(ds, "alergiass");
                lstAler.DataSource = ds.Tables["alergiass"];
                lstAler.DisplayMember = "nombre";
                lstAler.ValueMember = "nombre";
                //paciente.idpaciente, alegrias.nombre
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }

            ////////////////////////////////////////////////////////////////////////////////////////
            ///                             patologias dataset                                   ///
            ////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                dapadecimientos.SelectCommand.Parameters.AddWithValue("@paciente", consultado);
                dapadecimientos.Fill(ds, "patologias");
                lstPato.DataSource = ds.Tables["patologias"];
                lstPato.DisplayMember = "nombre";
                lstPato.ValueMember = "nombre";
                //select paciente.idpaciente, sscm.nombre
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }

            ////////////////////////////////////////////////////////////////////////////////////////
            ///                             procedimientos dataset                               ///
            ////////////////////////////////////////////////////////////////////////////////////////
            try
            {
                daprocedimientos.Fill(ds, "procedimientos");
                cmbProd.DataSource = ds.Tables["procedimientos"];
                cmbProd.DisplayMember = "nombre";
                cmbProd.ValueMember = "procid";
                //paciente.idpaciente, alergias.descripcionprocid
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            ////////////////////////////////////////////////////////////////////////////////////////
        }

        private void cleansbindings()
        {
            foreach(Control c in this.Controls)
            {
            c.DataBindings.Clear();
            }
            lstPato.DataSource = null;
            lstAler.DataSource = null;
            lstAler.Items.Clear();
            lstPato.Items.Clear();
        }

        public void activar()
        {
            //Control ctrl = default(Control);

	        foreach ( Control ctrl in this.Controls) {
		        if (ctrl is Button || ctrl is TextBox || ctrl is ComboBox || ctrl is GroupBox) {
			        ctrl.Enabled = true;
		        }
	        }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flagdeestado == 0)
            {
                this.Close();
            }
            else {
                DialogResult result = MessageBox.Show("¿Está seguro de que quiere cancelar la consulta?", "Consulta", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = "";
                        }
                        if (ctrl is Button || ctrl is TextBox || ctrl is ComboBox || ctrl is GroupBox)
                        {
                            ctrl.Enabled = false;
                        }
                    }
                    btnBusqueda.Enabled = true;
                    txtCuenta.Enabled = true;
                    btnCancel.Enabled = true;
                    flagdeestado = 0;
                    cleansbindings();
                }

                else if (result == DialogResult.Cancel) { 
                }
            } 
        }

        private void limpiezapasillo5()
        { 
        foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = "";
                        }
                        if (ctrl is Button || ctrl is TextBox || ctrl is ComboBox || ctrl is GroupBox)
                        {
                            ctrl.Enabled = false;
                        }
                    }
                    btnBusqueda.Enabled = true;
                    txtCuenta.Enabled = true;
                    btnCancel.Enabled = true;
                    flagdeestado = 0;
                    cleansbindings();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string consultado = Resources.Propiedades.pacienteenconsulta;
            if (flagdeestado == 1)
            {
                if ((txtPresion.Text != "") && (txtMoti.Text != "") && (txtObs.Text != ""))
                {
                    DialogResult result = MessageBox.Show("¿Esta seguro que desea guardar la consulta?", "Consulta", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        string strSQL = "INSERT INTO pacientes.consulta(idpaciente, idmedico, observacion, idcampus, procid, presion, motivovisita, fecha, idmedicamento, cantidad) VALUES (@consultado, @medico, @observacion, @campus, @procedimiento, @presion, @motivo, now(), @medicamento, @canttmed)";
                        try
                        {
                            using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                            {
                                //idpaciente, idmedico, observacion, idcampus, procid, presion, motivovisita, fecha, idmedicamento, cantidad) 
                                //(@consultado, @medico, @observacion, @campus, @procedimiento, @presion, @motivo, now(), @medicamento, @canttmed)
                                int big = cmbProd.Items.Count;
                                
                                
                                NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                                comando.Parameters.AddWithValue("@consultado", consultado);
                                comando.Parameters.AddWithValue("@medico", Resources.Propiedades.ID_ingreso);
                                comando.Parameters.AddWithValue("@observacion", txtObs.Text);
                                comando.Parameters.AddWithValue("@campus", 4);
                                comando.Parameters.AddWithValue("@procedimiento", big);
                                comando.Parameters.AddWithValue("@presion", txtPresion.Text);
                                comando.Parameters.AddWithValue("@motivo", txtMoti.Text);
                                comando.Parameters.AddWithValue("@medicamento", cmbMed.Items.Count);
                                comando.Parameters.AddWithValue("@canttmed", txtCant.Text);
                                conexion.Open();
                                comando.ExecuteNonQuery();
                                conexion.Close();
                                limpiezapasillo5();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
        }  
    }
}

