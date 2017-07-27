using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Pacientes
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        private void busqueda()
        {   
            string parametros = "Server=localhost;Port=5432;User Id=postgres;Password=hola;Database=Clinica";
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");
                string x;
                if(txtbusqueda.Text == "")
                {
                    x = "XXXXXXXXXX";
                }
                else
                {
                    x = txtbusqueda.Text.ToString();
                }
                string strSQL = "SELECT nombre FROM pacientes.paciente WHERE nombre LIKE '" + x + "%' OR nombre LIKE '% " + x + "%' ";
                NpgsqlCommand Comando = new NpgsqlCommand(strSQL, Cnx);
                NpgsqlDataReader Reg;
                Reg = Comando.ExecuteReader();
                //MessageBox.Show(strSQL);
                datagridx.Rows.Clear();
                while (Reg.Read())
                {
                    string nombre2 = Reg.GetString(0);
                    datagridx.Rows.Add(nombre2);
                }
                Cnx.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void cargardatos()
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            busqueda();
        }

        private void datagridx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string parametros = "Server=localhost;Port=5432;User Id=postgres;Password=hola;Database=Clinica";
            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");
                DataGridViewRow row = this.datagridx.Rows[e.RowIndex];
                string persona = row.Cells[0].Value.ToString();
                string strSQL = "SELECT idpaciente, carreras.nombre as carrera, tiposangre, telefono, email, peso, altura, etnia, genero, paciente.nombre as persona, fechanac, idtipo FROM pacientes.paciente INNER JOIN pacientes.carreras ON paciente.idcarrera = carreras.idcarrera WHERE paciente.nombre ='"+persona+"'";
                NpgsqlCommand Comando = new NpgsqlCommand(strSQL, Cnx);
                NpgsqlDataReader Reg;
                Reg = Comando.ExecuteReader();
                //MessageBox.Show(strSQL);
                while (Reg.Read())
                {
                    txtcodigo.Text = Reg["idpaciente"].ToString();
                    txtnombre.Text = Reg["persona"].ToString();
                    combocarrera.Text = Reg["carrera"].ToString();
                    dateTimePicker1.Text = Reg["fechanac"].ToString();
                    combosangre.Text = Reg["tiposangre"].ToString();
                    txtpeso.Text = Reg["peso"].ToString();
                    txtaltura.Text = Reg["altura"].ToString();
                    txttelefono.Text = Reg["telefono"].ToString();
                    txtemail.Text = Reg["email"].ToString();

                }
                Cnx.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void datagridx_SelectionChanged(object sender, EventArgs e)
        {

        }

        /* "Codigo Suelto"
        ---------------------------------------------------------------------------------------------
        if(e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.datagridx.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtnombre.Text = row.Cells[0].Value.ToString();
            }

         ---------------------------------------------------------------------------------------------
           /*string parametros = "Server=localhost;Port=5432;User Id=postgres;Password=hola;Database=Clinica";
            NpgsqlConnection Cnx = new NpgsqlConnection();
           // DataTable DT = new DataTable();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                MessageBox.Show("-BIENVENIDO-");
                string strSQL = "SELECT nombre FROM public." + '\u0022' + "Paciente" + '\u0022';
                NpgsqlCommand Comando = new NpgsqlCommand(strSQL, Cnx);
                NpgsqlDataReader Reg;
                Reg = Comando.ExecuteReader();
                while(Reg.Read())
                {
                    string nombre2 = Reg.GetString(0);
                    dataGridView1.Rows.Add(nombre2);
                }
                Cnx.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        ---------------------------------------------------------------------------------------------
        */
    }
}
