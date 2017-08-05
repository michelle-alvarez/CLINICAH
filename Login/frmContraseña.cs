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

namespace Login
{
    public partial class frmContraseña : Form
    {
        string cnxclinica = "Server=localhost; Port= 5432; Database=clinica; User Id=postgres; Password=Salmos665;";
        int flag = 1;
        string ID = "";

        public frmContraseña()
        {
            InitializeComponent();
        }

        private void frmContraseña_Load(object sender, EventArgs e)
        {
            txtcontraseña.Enabled = false;
            txtconfirmar.Enabled = false;

        }

        private void btn_recuperar_Click_1(object sender, EventArgs e)
        {

            if (flag == 1)
            {
                ID = txtid.Text;
                string email = txtemail.Text;
                string nom = txtnom.Text;

                string strSQL = "SELECT nombrecompleto, idmedico, email, pass FROM administracion.medicos WHERE idmedico = '" + ID + "'";
                try
                {
                    NpgsqlConnection conexion = new NpgsqlConnection(cnxclinica);
                    NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);
                    NpgsqlDataReader reader;
                    conexion.Open();
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (nom == reader.GetString(0) && email == reader.GetString(2))
                        {
                            btn_recuperar.Text = "Guardar";
                            txtcontraseña.Enabled = true;
                            txtconfirmar.Enabled = true;
                            txtemail.Enabled = false;
                            txtnom.Enabled = false;
                            txtid.Enabled = false;
                            flag = 2;
                            txtcontraseña.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Los datos no concuerdan con ninguna cuenta registrada.");
                        }
                    }
                    conexion.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }

            }
            else
            {
                if (txtcontraseña.Text == txtconfirmar.Text)
                {

                    string strSQL = "UPDATE administracion.medicos SET pass = @contra  WHERE idmedico = @idmed";
                    try
                    {
                        NpgsqlConnection conexion = new NpgsqlConnection(cnxclinica);
                        NpgsqlCommand comando = new NpgsqlCommand(strSQL, conexion);

                        conexion.Open();

                        comando.Parameters.AddWithValue("@contra", txtcontraseña.Text);
                        comando.Parameters.AddWithValue("@idmed", txtid.Text);

                        comando.ExecuteNonQuery();
                        flag = 1;
                        MessageBox.Show("Se cambio exitosamente su contraseña.");
                        this.Close();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
