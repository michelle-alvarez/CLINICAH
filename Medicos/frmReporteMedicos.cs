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

namespace Medicos
{
    public partial class frmReporteMedicos : Form
    {
        string cnx;
        public frmReporteMedicos(string cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
        }


        string where = "";
        string nombrecompleto = "";
        string campus = "";
        string fechanac = "";
        string trimestre = "";
        string especialidad = "";
        string strSQL = "";
        NpgsqlConnection conexion;
        NpgsqlDataReader readForFill;
        ComboBox cboBox;
        bool debeRecortar = false;

        private void frmReporteMedicos_Load(object sender, EventArgs e)
        {

            //NpgsqlConnection conexion = new NpgsqlConnection("User Id=postgres;Password=unicah;Host=10.4.5.32;Database=clinicas;Initial Schema=administracion");

            try
            {
                conexion = new NpgsqlConnection(cnx);
            }
            catch
            {
                conexion = new NpgsqlConnection(Medicos.Properties.Settings.Default.clinicasConnectionString);
            }


            conexion.Open();
            strSQL = "SELECT nombrecompleto AS [Nombre Completo], campus AS Campus, fechanac AS [Fecha de nacimiento], trimestre as Trimestre, especialidad AS Especialidad FROM administracion.medicos";
            //definimos la variable de comando donde le asignamos el string que contiene el select y la conexion
            string strSQLfillEspecialidad = "Select DISTINCT especialidad FROM administracion.medicos";
            string strSQLfillCampus = "Select DISTINCT campus FROM administracion.medicos";
            string strSQLfilTrimestre = "Select DISTINCT trimestre FROM administracion.medicos";

            //Creamos comandos para llenar los combo boxes con datos validos existentes en la base de datos.
            NpgsqlCommand fillCboEspecialidad = new NpgsqlCommand(strSQLfillEspecialidad, conexion);
            NpgsqlCommand fillCboCampus = new NpgsqlCommand(strSQLfillCampus, conexion);
            NpgsqlCommand fillCboTri = new NpgsqlCommand(strSQLfilTrimestre, conexion);

            conexion.Close();


            //Bucle para llenar cada combo box.
            for (int i = 1; i <= 3; i++)
            {
                switch (i)
                {
                    case 1:
                        conexion.Open();
                        cboBox = cmbcarrera;
                        readForFill = fillCboEspecialidad.ExecuteReader();
                        break;
                    case 2:
                        conexion.Open();
                        cboBox = cmbcampus;
                        readForFill = fillCboCampus.ExecuteReader();
                        break;
                    case 3:
                        conexion.Open();
                        cboBox = cbmtrimestre;
                        readForFill = fillCboTri.ExecuteReader();
                        break;
                }

                while (readForFill.Read())
                {
                    cboBox.Items.Add(readForFill[0].ToString());
                }

                conexion.Close();
            }

            //comando.Parameters.AddWithValue("@idusuario", usuario);
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpyear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbmtrimestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcampus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Reiniciar variables al inicio de hacer click en el boton buscar.
            where = "";
            nombrecompleto = "";
            campus = "";
            fechanac = "";
            trimestre = "";
            especialidad = "";

            debeRecortar = false;
            strSQL = "SELECT nombrecompleto AS \"Nombre Completo\", campus AS Campus, fechanac AS \"Fecha de nacimiento\", trimestre as Trimestre, especialidad AS Especialidad FROM administracion.medicos";

            //Si algun campo de texto tiene texto adentro, agregar condiciones en consulta SQL.
            if (txtnombre.Text.Length > 0 ||
                 cmbcampus.Text.Length > 0 ||
                 (dtpyear.Text.Length > 0 && dtpyear.Text != "31/12/9998") ||
                 cbmtrimestre.Text.Length > 0 ||
                 cmbcarrera.Text.Length > 0
                )
            {
                where = " where ";
                debeRecortar = true;
            }
            //----------------------------------------------------------------------
            //Determinar cual subcadena añadir al query y el formato de la misma.
            //----------------------------------------------------------------------
            if (txtnombre.Text.Length > 0)
            {
                nombrecompleto = "nombrecompleto  LIKE '%" + txtnombre.Text + "%' and ";
            }

            if (cmbcampus.Text.Length > 0)
            {
                campus = "campus LIKE '%" + cmbcampus.Text + "%' and ";
            }

            if (dtpyear.Text.Length > 0 && dtpyear.Text != "31/12/9998")
            {
                fechanac = "fechanac = '" + dtpyear.Text + "' and ";
            }

            if (cbmtrimestre.Text.Length > 0)
            {
                trimestre = "trimestre = " + cbmtrimestre.Text + " and ";
            }

            if (cmbcarrera.Text.Length > 0)
            {
                especialidad = "especialidad LIKE '%" + cmbcarrera.Text + "%' and ";
            }

            //Concatenacion de subcadenas para formar el query.
            strSQL = "SELECT nombrecompleto AS \"Nombre Completo\", campus AS Campus, fechanac AS \"Fecha de nacimiento\", trimestre as Trimestre, especialidad AS Especialidad FROM administracion.medicos" + where + nombrecompleto + campus + fechanac + trimestre + especialidad;

            //Si hay algun texto en alguno de los campos de texto remover la ultima subcadena "and " para evitar errores de sql
            if (debeRecortar)
            {
                strSQL = strSQL.Remove(strSQL.Length - 4);
            }


            //messagebox para debuggear, descomentar de ser necesario
            //MessageBox.Show(strSQL);

            //--------------------------------------------------------
            //creaer el data adapater para mostrarlo en data grid
            //--------------------------------------------------------
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(strSQL, conexion);

            var ds = new DataSet();
            da.Fill(ds);

            datagridResultados.ReadOnly = true;
            datagridResultados.DataSource = ds.Tables[0];
        }

        private void datagridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            cmbcampus.Text = "";
            dtpyear.Text = "31/12/9998";
            cbmtrimestre.Text = "";
            cmbcarrera.Text = "";
        }
    }
}
