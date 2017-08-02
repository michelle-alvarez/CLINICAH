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
    public partial class frmMedicamentos : Form
    {
        string cnx = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=marathon1;";
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlMedicamentos = "SELECT * FROM administracion.medicamentos WHERE idmedicamentos LIKE @filtro OR nombre LIKE @filtro ORDER BY nombre";
        NpgsqlDataAdapter damedicamentos;

        public frmMedicamentos()
        {
            InitializeComponent();
            damedicamentos = new NpgsqlDataAdapter(sqlMedicamentos, cnx);
        }

        private void frmMedicamentos_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            //Asignamos las columnas del Grid
            DGMedicamentos.AutoGenerateColumns = false;
            DGMedicamentos.Columns[0].DataPropertyName = "idmedicamentos";
            DGMedicamentos.Columns[1].DataPropertyName = "nombre";
            DGMedicamentos.Columns[2].DataPropertyName = "cantidad";
            DGMedicamentos.Columns[3].DataPropertyName = "reorden";
            DGMedicamentos.Columns[4].DataPropertyName = "donadopor";
            DGMedicamentos.Columns[5].DataPropertyName = "tipo";
            DGMedicamentos.Columns[6].DataPropertyName = "campus";
            DGMedicamentos.Columns[7].DataPropertyName = "fechaven";

            //Asignamos los parametros de busqueda en vacio para que cargue todos los usuarios
            damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", "%%");
            //Llenamos el Dataset con los datos del Table Adapter
            damedicamentos.Fill(ds, "medicamentos");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            DGMedicamentos.DataSource = ds.Tables["medicamentos"];
            txtmedicamento.DataBindings.Add("text", ds.Tables["medicamentos"], "nombre");
            txtDonado.DataBindings.Add("text", ds.Tables["medicamentos"], "donadopor");
            txttipo.DataBindings.Add("text", ds.Tables["medicamentos"], "tipo");
            cmbreorden.DataBindings.Add("text", ds.Tables["medicamentos"], "reorden");
            cmbCampus.DataBindings.Add("text", ds.Tables["medicamentos"], "campus");
            dtpvencimiento.DataBindings.Add("text", ds.Tables["medicamentos"], "fechaven");

            activo(false); 
        }

        private void activo(bool condicion)
        {
            txtmedicamento.Enabled = condicion;
            txtDonado.Enabled = condicion;
            txttipo.Enabled = condicion;
            cmbCampus.Enabled = condicion;
            cmbreorden.Enabled = condicion;
            dtpvencimiento.Enabled = condicion;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            DGMedicamentos.ReadOnly = true;
            DGMedicamentos .Enabled = false;
            btneditar.Text = "Guardar";
            btnagregar.Enabled = false;
            btnDelete.Enabled = false;
            txttipo.Clear();
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
                DGMedicamentos.ReadOnly = true;
                DGMedicamentos.Enabled = false;
                btnagregar.Enabled = false;
                btnDelete.Enabled = false;
                btneditar.Text = "Guardar";
                statusForm = 2;
            }
            else
            {
                if (statusForm == 1)
                {
                    strSQL = "INSERT INTO administracion.medicamentos(nombre, reorden, donadopor, tipo, campus, fechaven) VALUES(@idmedico, @nombrecompleto, @genero, @campus, @especialidad, @celular, @aniocarrera, @estadocivil, @trimestre, @fechanac, @email, @direccion, @pass); ";
                    try
                    {
                        using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                        {
                            NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                            comando.Parameters.AddWithValue("@donadopor", txtDonado.Text);
                            comando.Parameters.AddWithValue("@reorden", Convert.ToDecimal(cmbreorden.Text));
                            comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                            comando.Parameters.AddWithValue("@tipo", txttipo.Text);
                            comando.Parameters.AddWithValue("@fechaven", Convert.ToDecimal(cmbreorden.Text));
                            comando.Parameters.AddWithValue("@nombre", txtmedicamento.Text);
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            activo(false);
                            dynamic filtro = "%" + txtbuscar.Text + "%";
                            damedicamentos.SelectCommand.Parameters.Clear();
                            damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                            ds.Tables["medicamentos"].Clear();
                            damedicamentos.Fill(ds, "medicamentos");
                            btnagregar.Enabled = true;
                            btnDelete.Enabled = true;
                            btneditar.Text = "Editar";
                            DGMedicamentos.ReadOnly = false;
                            DGMedicamentos.Enabled = true;
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
                        strSQL = "UPDATE administracion.medicos SET nombre = @nombre, donadopor = @donadopor, campus = @campus, tipo = @tipo, fechaven = @fechaven, reorden = @reorden  WHERE idmedicamentos = @idmedicamentos";
                        try
                        {
                            using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                            {
                                NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                                comando.Parameters.AddWithValue("@donadopor", txtDonado.Text);
                                comando.Parameters.AddWithValue("@reorden", Convert.ToDecimal(cmbreorden.Text));
                                comando.Parameters.AddWithValue("@campus", cmbCampus.Text);
                                comando.Parameters.AddWithValue("@tipo", txttipo.Text);
                                comando.Parameters.AddWithValue("@fechaven", Convert.ToDecimal(cmbreorden.Text));
                                comando.Parameters.AddWithValue("@nombre", txtmedicamento.Text);
                                conexion.Open();
                                comando.ExecuteNonQuery();
                                activo(false);
                                dynamic filtro = "%" + txtbuscar.Text + "%";
                                damedicamentos.SelectCommand.Parameters.Clear();
                                damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                                ds.Tables["medicamentos"].Clear();
                                damedicamentos.Fill(ds, "medicamentos");
                                btnagregar.Enabled = true;
                                btnDelete.Enabled = true;
                                btneditar.Text = "Editar";
                                DGMedicamentos.ReadOnly = false;
                                DGMedicamentos.Enabled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DGMedicamentos.RowCount > 0)
            {
                dynamic strSQL = "DELETE FROM administracion.medicamentos WHERE nombre = @nombre";
                dynamic nombre = DGMedicamentos.Rows[DGMedicamentos.CurrentRow.Index].Cells[1].Value;
                try
                {
                    using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        //Ejecucion de un Query de accion
                        DGMedicamentos.Rows.Remove(DGMedicamentos.CurrentRow);
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activo(false);
            btnagregar.Enabled = true;
            btneditar.Text = "Editar";
            btnDelete.Enabled = true;
            statusForm = 0;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dynamic filtro = "%" + txtbuscar.Text + "%";
                damedicamentos.SelectCommand.Parameters.Clear();
                damedicamentos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                ds.Tables["medicamentos"].Clear();
                damedicamentos.Fill(ds, "medicamentos");
            }
        }

 
    }
}
