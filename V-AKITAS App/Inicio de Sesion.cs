using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_AKITAS_App
{
    public partial class Inicio_de_Sesion : Form
    {
        private string connectionString;
        public Inicio_de_Sesion()
        {
            InitializeComponent();
            connectionString = "Server=TH3B4R4K\\MSSQLSERVER2022; Database=V-AKITAS; User Id=V-AKITASPremium; Password=V-AKITAS2024;";
            txtUsuario.KeyDown += new KeyEventHandler(this.Form_KeyDown);
            txtPass.KeyDown += new KeyEventHandler(this.Form_KeyDown);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick(); // Simula un clic en el botón Ingresar
                e.SuppressKeyPress = true; // Evita el sonido "ding" al presionar Enter
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "V-AKITASPremium" && password == "V-AKITAS2024")
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Abre Gestion_Realizar después del inicio de sesión correcto
                Gestion_Realizar gestion = new Gestion_Realizar();
                gestion.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtPass.Focus();
            }
        }

        private void Verpass_Click_1(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0'; // Muestra la contraseña sin máscara
            Verpass.Visible = false;
            NoVerpass.Visible = true;
        }

        private void NoVerpass_Click_1(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*'; // Oculta la contraseña
            Verpass.Visible = true;
            NoVerpass.Visible = false;
        }

        public void Limpiar()
        {
            txtUsuario.Clear();
            txtPass.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnVersionGra_Click(object sender, EventArgs e)
        {
            VersionGratuita version = new VersionGratuita(false);
            this.Hide();
            version.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void txtPass_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
    
}
