using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_AKITAS_App
{
    public partial class Comentarios : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["V-AKITASConnectionString"].ConnectionString;

        public Comentarios()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string titular = txtTitular.Text;
            string comentario = txtMensaje.Text;

            // Asegúrate de que el cuerpo del mensaje combine los valores de los TextBox
            string body = $"Titular: {titular}\nComentario: {comentario}";

            // Ejecutar el procedimiento almacenado con el cuerpo dinámico
            EnviarSugerencia(body);
            this.Hide();
        }

        private void EnviarSugerencia(string body)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Sugerencias", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                 //Pasar el contenido del cuerpo dinámico como parámetro
                cmd.Parameters.AddWithValue("@Body", body);

                 //Ejecutar el procedimiento
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sugerencia enviada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }   
    }
}
