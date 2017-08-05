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

namespace Medicamentos_y_Suministros
{
    public partial class frmSuministros : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=unicah;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlsuministros = "SELECT * FROM administracion.suministros WHERE nombre LIKE @filtro ORDER BY nombre";
        NpgsqlDataAdapter dasuministros;
        public frmSuministros()
        {
            InitializeComponent();
            dasuministros = new NpgsqlDataAdapter(sqlsuministros, cnx);
        }

        private void frmSuministros_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            //Asignamos las columnas del Grid
            DGSuministros.AutoGenerateColumns = false;
            DGSuministros.Columns[0].DataPropertyName = "idsuministros";
            DGSuministros.Columns[1].DataPropertyName = "nombre";
            DGSuministros.Columns[2].DataPropertyName = "cantidad";
            DGSuministros.Columns[3].DataPropertyName = "reorden";
            DGSuministros.Columns[4].DataPropertyName = "donadopor";
            DGSuministros.Columns[6].DataPropertyName = "campus";
            DGSuministros.Columns[7].DataPropertyName = "fechaven";

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            dasuministros.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            dasuministros.Fill(ds, "suministros");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            DGSuministros.DataSource = ds.Tables["suministros"];
            txtmedicamento.DataBindings.Add("text", ds.Tables["suministros"], "nombre");
            txtDonado.DataBindings.Add("text", ds.Tables["suministros"], "donadopor");
            cmbreorden.DataBindings.Add("text", ds.Tables["suministros"], "reorden");
            cmbCampus.DataBindings.Add("text", ds.Tables["suministros"], "campus");
            dtpvencimiento.DataBindings.Add("text", ds.Tables["suministros"], "fechaven");

            activo(false);
        }

        private void activo(bool condicion)
        {
            txtmedicamento.Enabled = condicion;
            txtDonado.Enabled = condicion;
            cmbCampus.Enabled = condicion;
            cmbreorden.Enabled = condicion;
            dtpvencimiento.Enabled = condicion;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DGSuministros.ReadOnly = true;
            DGSuministros.Enabled = false;
            btneditar.Text = "Guardar";
            btnagregar.Enabled = false;
            btndelete.Enabled = false;
            txtDonado.Clear();
            txtmedicamento.Clear();
            cmbCampus.SelectedItem = 1;
            cmbreorden.Value = 0;
            dtpvencimiento.Value = DateTime.Now;
            statusForm = 1;
            txtmedicamento.Focus();
            activo(true);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            if (statusForm == 0)
            {
                activo(true);
                DGSuministros.ReadOnly = true;
                DGSuministros.Enabled = false;
                btnagregar.Enabled = false;
                btndelete.Enabled = false;
                btneditar.Text = "Guardar";
                statusForm = 2;
            }
            else
            {
                if (statusForm == 1)
                {
                    strSQL = "INSERT INTO administracion.suministros(nombre, reorden, donadopor, campus, fechaven) VALUES(@nombre, @reorden, @donadopor, @campus, @fechaven); ";
                    try
                    {
                        using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                        {
                            NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                            comando.Parameters.AddWithValue("@donadopor", txtDonado.Text);
                            comando.Parameters.AddWithValue("@reorden", Convert.ToDecimal(cmbreorden.Text));
                            comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                            comando.Parameters.AddWithValue("@fechaven", Convert.ToDecimal(cmbreorden.Text));
                            comando.Parameters.AddWithValue("@nombre", txtmedicamento.Text);
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            activo(false);
                            dynamic filtro = "%" + txtbuscar.Text + "%";
                            dasuministros.SelectCommand.Parameters.Clear();
                            dasuministros.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                            ds.Tables["suministros"].Clear();
                            dasuministros.Fill(ds, "suministros");
                            btnagregar.Enabled = true;
                            btndelete.Enabled = true;
                            btneditar.Text = "Editar";
                            DGSuministros.ReadOnly = false;
                            DGSuministros.Enabled = true;
                            statusForm = 0;
                            conexion.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (statusForm == 2)
                    {
                        strSQL = "UPDATE administracion.medicos SET nombre = @nombre, donadopor = @donadopor, campus = @campus, tipo = @tipo, fechaven = @fechaven, reorden = @reorden  WHERE idsuministros = @idsuministros";
                        try
                        {
                            using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                            {
                                NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                                comando.Parameters.AddWithValue("@donadopor", txtDonado.Text);
                                comando.Parameters.AddWithValue("@reorden", Convert.ToDecimal(cmbreorden.Text));
                                comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                                comando.Parameters.AddWithValue("@fechaven", Convert.ToDecimal(cmbreorden.Text));
                                comando.Parameters.AddWithValue("@nombre", txtmedicamento.Text);
                                conexion.Open();
                                comando.ExecuteNonQuery();
                                activo(false);
                                dynamic filtro = "%" + txtbuscar.Text + "%";
                                dasuministros.SelectCommand.Parameters.Clear();
                                dasuministros.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                                ds.Tables["suministros"].Clear();
                                dasuministros.Fill(ds, "suministros");
                                btnagregar.Enabled = true;
                                btndelete.Enabled = true;
                                btneditar.Text = "Editar";
                                DGSuministros.ReadOnly = false;
                                DGSuministros.Enabled = true;
                                statusForm = 0;
                                conexion.Close();
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (DGSuministros.RowCount > 0)
            {
                dynamic strSQL = "DELETE FROM administracion.suministros WHERE nombre = @nombre";
                dynamic nombre = DGSuministros.Rows[DGSuministros.CurrentRow.Index].Cells[1].Value;
                try
                {
                    using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        //Ejecucion de un Query de accion
                        DGSuministros.Rows.Remove(DGSuministros.CurrentRow);
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            activo(false);
            btnagregar.Enabled = true;
            btneditar.Text = "Editar";
            btndelete.Enabled = true;
            statusForm = 0;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dynamic filtro = "%" + txtbuscar.Text + "%";
                dasuministros.SelectCommand.Parameters.Clear();
                dasuministros.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                ds.Tables["suministros"].Clear();
                dasuministros.Fill(ds, "suministros");
            }
        }
    }
}
