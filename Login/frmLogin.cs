using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool continuar = false;
        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (txt_IDusuario.Text == "")
            {
                btn_Aceptar.Enabled = false;
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_IDusuario.Text == "")
            {
                btn_Aceptar.Enabled = false;
            }
            else
                btn_Aceptar.Enabled = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
