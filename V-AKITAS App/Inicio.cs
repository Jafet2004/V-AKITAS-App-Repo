using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace V_AKITAS_App
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = "Server=TH3B4R4K\\MSSQLSERVER2022; Database=V-AKITAS; User Id=V-AKITASPremium; Password=V-AKITAS2024";
            txtUsuario.KeyDown += new KeyEventHandler(this.Form_KeyDown);
            txtPass.KeyDown += new KeyEventHandler(this.Form_KeyDown);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void VerPass_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0'; // No hay carácter de máscara

            // Actualiza la visibilidad de los botones
            VerPass.Visible = false;
            NoVerPass.Visible = true;
        }

        private void NoVerPass_Click(object sender, EventArgs e)
        {
            // Oculta el texto de la contraseña
            txtPass.PasswordChar = '*'; // Establece el carácter de máscara

            // Actualiza la visibilidad de los botones
            VerPass.Visible = true;
            NoVerPass.Visible = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.SuppressKeyPress = true; // Evita el sonido "ding" al presionar Enter
            }
        }



        private void PerformLogin()
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPass.Text;

            // Validaciones
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar credenciales (hardcoded para este ejemplo)
            if (username == "V-AKITASPremium" && password == "V-AKITAS2024")
            {
                // Inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Premiun form = new Premiun(); // Cambia al siguiente formulario
                form.Show();
            }
            else
            {
                // Credenciales incorrectas
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void btnIngresar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
                e.SuppressKeyPress = true; // Evita el sonido "ding" al presionar Enter
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick(); // Simula un clic en el botón Ingresar
                e.SuppressKeyPress = true; // Evita el sonido "ding" al presionar Enter
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPass.Text;

            // Validaciones
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar credenciales (hardcoded para este ejemplo)
            if (username == "V-AKITASPremium" && password == "V-AKITAS2024")
            {
                // Inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Premiun form = new Premiun(); // Cambia al siguiente formulario
                form.Show();
            }
            else
            {
                // Credenciales incorrectas
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Premiun Version = new Premiun();
            this.Hide();
            Version.Show();
        }
    }

}
