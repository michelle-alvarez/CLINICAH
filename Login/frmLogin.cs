using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;


namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //0501197303294

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes); 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
        
        private string cnxclinica = Login.Properties.Settings.Default.clinicasCnx;


        private void Login_Load(object sender, EventArgs e)
        {
            if (txtIDmedico.Text == "")
            {
                btn_Aceptar.Enabled = false;
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtIDmedico.Text == "")
            {
                btn_Aceptar.Enabled = false;
            }
            else
                btn_Aceptar.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            bool block = Resources.Propiedades.flag;

            block = Resources.Propiedades.flag;
            if (block == false)
            {
                evaluar();
                txtIDmedico.Focus();
            }


        }

        private void evaluar()
        {
            string password = txtPassword.Text;
            string idmedi = txtIDmedico.Text;
            string strerror = "";
            password = SHA512(password);
            if (txtIDmedico.Text != "" && txtPassword.Text != "")
            {
                //el select nos mostrara la llave o contraseña de la tabla de usuarios donde la ID sea igual al ID del textbox               
                string strSQL = "SELECT pass, nombrecompleto FROM administracion.medicos WHERE idmedico = '" + idmedi + "'";
                try
                {
                    //se define la conexion como una nueva conexcion de postgres y le asignamos el valor de la variable string que tiene los datos de
                    //conexion
                    PgSqlConnection conexion = new PgSqlConnection(cnxclinica);
                    //definimos la variable de comando donde le asignamos el string que contiene el select y la conexion
                    PgSqlCommand comando = new PgSqlCommand(strSQL, conexion);
                    //comando.Parameters.AddWithValue("@idusuario", usuario);
                    PgSqlDataReader reader;
                    conexion.Open();
                    reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string dbpassw = reader.GetString(0);
                        string nombre = reader.GetString(1);
                        dbpassw = SHA512(dbpassw);

                        if (password == dbpassw)
                        {
                            MessageBox.Show("Bienvenido '" + nombre + "'");
                            categoria(idmedi);
                            this.Close();
                            Resources.Propiedades.flag = true;
                            Resources.Propiedades.nombre_ingreso = reader.GetString(1);

                        }
                        else
                        {
                            
                            strerror = "Password Incorrecto";
                        }
                    }
                    else
                    {
                        strerror = "No existe ningun usuario con ese nombre";
                    }

                    conexion.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(strerror + err.ToString());
                }
            }
            else
            {
                strerror = "Ingrese los datos de usuario y contraseña";
            }

            if (strerror != "")
            {
                MessageBox.Show(strerror);
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void categoria(string ID)
        {
            string strSQL = "SELECT tipomedico FROM administracion.tipomedico WHERE idmedico = '" + ID + "'";
            try
            {
                PgSqlConnection conexion = new PgSqlConnection(cnxclinica);
                PgSqlCommand comando = new PgSqlCommand(strSQL, conexion);
                PgSqlDataReader reader;
                conexion.Open();
                reader = comando.ExecuteReader();
                if (reader.HasRows)

                {
                    reader.Read();
                    Resources.Propiedades.categoria = reader.GetInt32(0);
                   
                }
                conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }


        }
    }
}