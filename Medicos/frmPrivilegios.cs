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
    public partial class frmPrivilegios : Form
    {
        string cnx;
        DataSet ds;
        public int statusForm = 0; //0 = Consultando; 1=Agregando; 2=Editando
        string sqlPrivilegios = "Select * FROM administracion.tipomedico";
        string strSQLfillId = "Select DISTINCT idmedico FROM administracion.medicos";
        NpgsqlDataAdapter daprivilegios;
        NpgsqlDataAdapter daId;

        public frmPrivilegios(string cnx)
        {
            InitializeComponent();
            this.cnx = cnx;
            daprivilegios = new NpgsqlDataAdapter(sqlPrivilegios, cnx);
            daId = new NpgsqlDataAdapter(strSQLfillId, cnx);
        }

        private void frmPrivilegios_Load(object sender, EventArgs e)
        {
            ds = new DataSet();

            //Asignamos las columnas del Grid
            DGPrivilegios.AutoGenerateColumns = false;
            DGPrivilegios.Columns[0].DataPropertyName = "idtipo";
            DGPrivilegios.Columns[1].DataPropertyName = "idmedico";
            DGPrivilegios.Columns[2].DataPropertyName = "tipomedico";

            //Llenamos el Dataset con los datos del Table Adapter
            daprivilegios.Fill(ds, "usuarios");
            daId.Fill(ds, "id");

            //Asignar la fuente de datos al DataGrid con la table adapter creada anteriormente
            DGPrivilegios.DataSource = ds.Tables["usuarios"];
            cmbtipo.DataBindings.Add("text", ds.Tables["usuarios"], "tipomedico");

            cmbidentidad.DataSource = ds.Tables["id"];
            cmbidentidad.DisplayMember = ("idmedico");
            //activo(false);
        }

        private void activo(bool condicion)
        {
            cmbidentidad.Enabled = condicion;
            cmbtipo.Enabled = condicion;
        }

        //private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        dynamic filtro = "%" + txtbuscar.Text + "%";
        //        damedicos.SelectCommand.Parameters.Clear();
        //        damedicos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
        //        ds.Tables["usuarios"].Clear();
        //        damedicos.Fill(ds, "usuarios");
        //    }
        //}

        private void btnagregar_Click_1(object sender, EventArgs e)
        {
            DGPrivilegios.ReadOnly = true;
            DGPrivilegios.Enabled = false;
            btneditar.Text = "Guardar";
            btnagregar.Enabled = false;
            btnDelete.Enabled = false;
            cmbtipo.SelectedItem = 1;
            cmbidentidad.SelectedItem = 0;
            statusForm = 1;
            activo(true);
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            string strSQL = "";
            string strPrivilegios = "";
            if (statusForm == 0)
            {
                activo(true);
                DGPrivilegios.ReadOnly = true;
                DGPrivilegios.Enabled = false;
                btnagregar.Enabled = false;
                btnDelete.Enabled = false;
                btneditar.Text = "Guardar";
                statusForm = 2;
            }
            else
            {
                if (statusForm == 1)
                {
                    strPrivilegios = "INSERT INTO administracion.tipomedico(idmedico, tipomedico) VALUES(@idmedico, @tipo);";
                    try
                    {
                        using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                        {
                            NpgsqlCommand comando = new NpgsqlCommand(strPrivilegios, conexion);
                            comando.Parameters.AddWithValue("@idmedico", cmbidentidad.Text);
                            comando.Parameters.AddWithValue("@tipo", Convert.ToDecimal(cmbtipo.Text));
                            conexion.Open();
                            comando.ExecuteNonQuery();
                            activo(false);
                            daprivilegios.SelectCommand.Parameters.Clear();
                            ds.Tables["usuarios"].Clear();
                            daprivilegios.Fill(ds, "usuarios");
                            btnagregar.Enabled = true;
                            btnDelete.Enabled = true;
                            cmbidentidad.Enabled = false; ;
                            btneditar.Text = "Editar";
                            DGPrivilegios.ReadOnly = false;
                            DGPrivilegios.Enabled = true;
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
                        strPrivilegios = "UPDATE administracion.tipomedico SET tipomedico = @tipo WHERE idmedico = @idmedico";
                        try
                        {
                            using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                            {
                                NpgsqlCommand privilegios = new NpgsqlCommand(strPrivilegios, conexion);
                                privilegios.Parameters.AddWithValue("@idmedico", cmbidentidad.Text);
                                privilegios.Parameters.AddWithValue("@tipo", Convert.ToDecimal(cmbtipo.Text));
                                conexion.Open();
                                privilegios.ExecuteNonQuery();
                                activo(false);
                                daprivilegios.SelectCommand.Parameters.Clear();
                                ds.Tables["usuarios"].Clear();
                                daprivilegios.Fill(ds, "usuarios");
                                btnagregar.Enabled = true;
                                btnDelete.Enabled = true;
                                cmbidentidad.Enabled = false;
                                btneditar.Text = "Editar";
                                DGPrivilegios.ReadOnly = false;
                                DGPrivilegios.Enabled = true;
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (DGPrivilegios.RowCount > 0)
            {
                dynamic strSQL = "DELETE FROM administracion.tipomedico WHERE idmedico = @idmedico";
                dynamic idmedico = DGPrivilegios.Rows[DGPrivilegios.CurrentRow.Index].Cells[1].Value;
                try
                {
                    using (NpgsqlConnection conexion = new NpgsqlConnection(cnx))
                    {
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                        comando.Parameters.AddWithValue("@idmedico", idmedico);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        //Ejecucion de un Query de accion
                        DGPrivilegios.Rows.Remove(DGPrivilegios.CurrentRow);
                        conexion.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            activo(false);
            btnagregar.Enabled = true;
            btneditar.Text = "Editar";
            btnDelete.Enabled = true;
            statusForm = 0;
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
