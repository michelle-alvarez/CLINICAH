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
    public partial class frmSearch : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=marathon1;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        //string sqlPaciente = "SELECT idpaciente,paciente FROM pacientes.paciente WHERE idpaciente LIKE @filtro";
        string sqlPaciente = "SELECT idpaciente,cast(paciente as text) FROM pacientes.paciente";
        NpgsqlDataAdapter daPaciente;

        public frmSearch()
        {
            InitializeComponent();
            daPaciente = new NpgsqlDataAdapter(sqlPaciente, cnx);
            


        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            Resources.Propiedades.pacienteenconsulta = "";
            ds = new DataSet();
            //Asignamos las columnas del Grid
            

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "idpaciente";
            dataGridView1.Columns[1].DataPropertyName = "paciente";

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            daPaciente.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            daPaciente.Fill(ds, "pacientes");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            dataGridView1.DataSource = ds.Tables["pacientes"];
            txtCuenta.DataBindings.Add("text",ds.Tables["pacientes"],"idpaciente");
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resources.Propiedades.pacienteenconsulta = txtCuenta.Text;

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Resources.Propiedades.pacienteenconsulta = "";
        }

        
    }
}
