using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimientos
{
    public partial class frmProcedimientos : Form
    {
        int statusform = 0; // Define el estado del formulario, 0 = visual, 1 = agregando, 2 = editando

        string parametros = "Server=localhost;Port=5432;User Id=postgres;Password=unicah;Database=clinica";
        string sqlSumiUso = "SELECT administracion.suministros.idsuministros, administracion.suministros.nombre FROM administracion.suministros INNER JOIN atencion.procedimientossuministros ON administracion.suministros.idsuministros = atencion.procedimientossuministros.idsuministros";
        string sqlNoSumiUso = "Select administracion.suministros.idsuministros, administracion.suministros.nombre FROM administracion.suministros WHERE idsuministros NOT IN(SELECT administracion.suministros.idsuministros FROM administracion.suministros INNER JOIN atencion.procedimientossuministros ON administracion.suministros.idsuministros = atencion.procedimientossuministros.idsuministros)";
        string sqlcategorias = "SELECT categoriaid, nombrecat FROM atencion.categoriaprocedimiento";
        DataSet dsprocedimiento = new DataSet();
        DataTable tableproc;


        NpgsqlDataAdapter TableAdap = new NpgsqlDataAdapter();
        NpgsqlDataAdapter daProceSumi = new NpgsqlDataAdapter();
        NpgsqlDataAdapter daNoProceSumi = new NpgsqlDataAdapter();
        NpgsqlDataAdapter dacategorias = new NpgsqlDataAdapter();
      //  DataSet daProceSumi = new DataSet();
        DataSet daNoproceSumi = new DataSet();


        public frmProcedimientos()
        {
            InitializeComponent();
        }

        private void dtgProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProcedimientos_Load(object sender, EventArgs e)
        {
            cargardatagrid();
           
        }

        private void cargardatagrid()

        {

            dtgProcedimientos.AutoGenerateColumns = false;
            dtgProcedimientos.Columns[0].DataPropertyName = "procid";
            dtgProcedimientos.Columns[1].DataPropertyName = "nombre";
            dtgProcedimientos.Columns[2].DataPropertyName = "descripcion";
            dtgProcedimientos.Columns[3].DataPropertyName = "nombrecat";


            NpgsqlConnection Cnx = new NpgsqlConnection();
            Cnx.ConnectionString = parametros;
            try
            {
                Cnx.Open();
                //MessageBox.Show("-BIENVENIDO-");

                string strSQL = "SELECT procid, atencion.procedimientos.nombre, atencion.procedimientos.descripcion, atencion.categoriaprocedimiento.nombrecat FROM atencion.categoriaprocedimiento INNER JOIN atencion.procedimientos ON atencion.procedimientos.categoriaid = atencion.procedimientos.categoriaid";
                NpgsqlDataAdapter TableAdap = new NpgsqlDataAdapter(strSQL, Cnx);
                NpgsqlDataAdapter daProceSumi = new NpgsqlDataAdapter(sqlSumiUso, Cnx);
                NpgsqlDataAdapter daNoProceSumi = new NpgsqlDataAdapter(sqlNoSumiUso, Cnx);
                //NpgsqlDataAdapter categorias = new NpgsqlDataAdapter(sqlcategorias, Cnx);


                TableAdap.Fill(dsprocedimiento, "procedimientos");

                daProceSumi.Fill(dsprocedimiento, "suministros");
                daProceSumi.Fill(dsprocedimiento, "Nosuministros");

                //dacategorias.Fill(dsprocedimiento, "categorias");

                dtgProcedimientos.DataSource = dsprocedimiento.Tables["procedimientos"];

                //cmbcategoria.DataBindings.Add("text", dsprocedimiento.Tables["categorias"], "nombre");
                tbprocedimiento.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "procid");
                tbDescrip.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "descripcion");
                // tbtiempo.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "tiempo");


                ////Listbox llenado con los datos
                ////lstusuarios.DataBindings.Add("DisplayMember", ds.Tables("perfilesusuarios"), "idusuario")
                //lstusados.DataSource = dsprocedimiento.Tables["suministros"];
                //lstusados.ValueMember = "idsuministros";
                //lstusados.DisplayMember = "nombre";

                //lstdispo.DataSource = dsprocedimiento.Tables["Nosuministros"];
                //lstdispo.ValueMember = "idusuario";
                //lstdispo.DisplayMember = "idusuario";


            }
            catch
            {

            }


        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            dtgProcedimientos.Enabled = false;
            dtgProcedimientos.ReadOnly = true;
            btnagregar.Enabled = false;
          //  btneditar.Text = "Guardar";
            //tbDescrip.ReadOnly = false;
            //tbtiempo.ReadOnly = false;
            // tbprocedimiento.ReadOnly = false;
            //tbprocedimiento.Text = "";
            //tbtiempo.Text = "";
            //tbDescrip.Text = "";

            //
            statusform = 1; // pasamos a modo agregar

        }

        private void btneditar_Click(object sender, EventArgs e)
        {


            if (statusform == 0)
            {
            //    dtgProcedimientos.Enabled = false;
            //    dtgProcedimientos.ReadOnly = true;
            //    btnagregar.Enabled = false;
            //   // btneditar.Text = "Guardar";
            //    tbDescrip.ReadOnly = false;
            //    tbtiempo.ReadOnly = false;
            //    tbprocedimiento.ReadOnly = false;
            //    //
            //    statusform = 2; // pasamos a modo agregar

            }
            else if (statusform == 1) // si esta en modo agregar
            {


                NpgsqlConnection Cnx = new NpgsqlConnection();
                Cnx.ConnectionString = parametros;
                try
                {
                    string strSQL = "INSERT INTO atencion.procedimientos (procid, nombre, tiempo) VALUES (@procid, @descrip, @tiempo)";
                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, Cnx);

                    comando.Parameters.AddWithValue("@procid", tbprocedimiento.Text);
                    comando.Parameters.AddWithValue("@descrip", tbDescrip.Text);
                    //comando.Parameters.AddWithValue("@tiempo", System.Convert.ToInt32 (tbtiempo.Text));

                    Cnx.Open();

                    comando.ExecuteNonQuery();
                    btnagregar.Enabled = true;
                 //   btneditar.Text = "Editar";
                    dtgProcedimientos.ReadOnly = false;
                    dtgProcedimientos.Enabled = true;
                    dsprocedimiento.Clear();
                    cargardatagrid();


                    //tbprocedimiento.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "procid");
                    //tbDescrip.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "descripcion");
                    //tbtiempo.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "tiempo");
                    MessageBox.Show("Procedimiento agregado exitosamente.");
                    Cnx.Close();

                    statusform = 0;


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
            else if (statusform == 2)
            {
                NpgsqlConnection Cnx = new NpgsqlConnection();
                Cnx.ConnectionString = parametros;
                try
                {
                    string strSQL = "UPDATE atencion.procedimientos SET procid = @procid, descripcion = @descrip, tiempo = @tiempo WHERE procid = @procid";
                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, Cnx);

                    comando.Parameters.AddWithValue("@procid", tbprocedimiento.Text);
                    comando.Parameters.AddWithValue("@descrip", tbDescrip.Text);
                    //comando.Parameters.AddWithValue("@tiempo", System.Convert.ToInt32(tbtiempo.Text));

                    Cnx.Open();

                    comando.ExecuteNonQuery();
                    btnagregar.Enabled = true;
                    btneditar.Text = "Editar";
                    dtgProcedimientos.ReadOnly = false;
                    dtgProcedimientos.Enabled = true;
                    dsprocedimiento.Clear();
                    cargardatagrid();


                    //tbprocedimiento.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "procid");
                    //tbDescrip.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "descripcion");
                    //tbtiempo.DataBindings.Add("text", dsprocedimiento.Tables["procedimientos"], "tiempo");
                    MessageBox.Show("Procedimiento modificado exitosamente.");
                    Cnx.Close();

                    statusform = 0;



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (dtgProcedimientos.RowCount > 0)
            {
                string strSQL = "DELETE FROM atencion.procedimientos WHERE procid = @procid";
       
                try
                {
                    using (NpgsqlConnection conexion = new NpgsqlConnection(parametros))
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                        comando.Parameters.AddWithValue("@procid", tbprocedimiento.Text);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        //Ejecucion de un Query de accion
                        dtgProcedimientos.Rows.Remove(dtgProcedimientos.CurrentRow);
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string strSQL = "DELETE FROM atencion.procedimientossuministros WHERE idsuministros = @idsum AND procid = @procid";
            //Query sujeto a revisión

            try
            {
                using (NpgsqlConnection conexion = new NpgsqlConnection(parametros))
                {
                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);

                    string idperfil = dtgProcedimientos.CurrentCell.ToString();

                    //NpgsqlDataAdapter Tabla = new NpgsqlDataAdapter();

                    //comando.Parameters.AddWithValue("@idsum", lstdispo.SelectedValue);
                    //comando.Parameters.AddWithValue("@idperfil", idperfil);
                    //conexion.Open();
                    //comando.ExecuteNonQuery();
                    //Ejecucion de un Query de accion




                    //daProceSumi.SelectCommand.Parameters.Clear();
                    //daNoProceSumi.SelectCommand.Parameters.Clear();

                    //daNoProceSumi.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                    //daProceSumi.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                    //dsprocedimiento.Tables("perfiles").Clear()
                    //daPerfiles.Fill(ds, "perfiles");




                    //Tabla.Fill(dsprocedimiento, "procedimientossuministros");



                    ////Listbox llenado con los datos
                    //lstusados.DataSource = dsprocedimiento.Tables["suministros"];
                    //lstusados.ValueMember = "idsuministros";
                    //lstusados.DisplayMember = "nombre";

                    //lstdispo.DataSource = dsprocedimiento.Tables["Nosuministros"];
                    //lstdispo.ValueMember = "idsuministros";
                    //lstdispo.DisplayMember = "nombre";



                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            //string UserAnswer = Microsoft.VisualBasic.Interaction.InputBox("¿Que cantidad de " + lstdispo.DisplayMember + " requiere el procedimiento de " + dtgProcedimientos.CurrentCell.ToString() + " ?", "Cantidad", "Default Response");

            ////.Show("Que cantidad de " + lstdispo.DisplayMember + " requiere el procedimiento de " + dtgProcedimientos.CurrentCell.ToString() + "?", );

            //string strSQL = "INSERT INTO atencion.procedimientossuministros  idsuministros = @idsum AND procid = @procid";
            ////Query sujeto a revisión

            //try
            //{
            //    using (NpgsqlConnection conexion = new NpgsqlConnection(parametros))
            //    {
            //        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);

            //        string idperfil = dtgProcedimientos.CurrentCell.ToString();

            //        comando.Parameters.AddWithValue("@idsum", lstdispo.SelectedValue);
            //        comando.Parameters.AddWithValue("@idperfil", idperfil);
            //        comando.Parameters.AddWithValue("@cantidad", idperfil);

            //        conexion.Open();
            //        comando.ExecuteNonQuery();
            //        //Ejecucion de un Query de accion

            //        daProceSumi.Fill(dsprocedimiento, "procedimientossuministros");
            //        daNoProceSumi.Fill(dsprocedimiento, "noprocedimientossuministros");

            //        //Listbox llenado con los datos



            //        //lstusados.DataSource = dsprocedimiento.Tables["suministros"];
            //        //lstusados.ValueMember = "idsuministros";
            //        //lstusados.DisplayMember = "nombre";

            //        //lstdispo.DataSource = dsprocedimiento.Tables["Nosuministros"];
            //        //lstdispo.ValueMember = "idsuministros";
            //        //lstdispo.DisplayMember = "nombre";


            //        //conexion.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
