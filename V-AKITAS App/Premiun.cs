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

namespace V_AKITAS_App
{
    public partial class Premiun : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TH3B4R4K\\MSSQLSERVER2022;Initial Catalog=V-AKITAS;Integrated Security=True");
        public Premiun()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            string query = "SELECT * FROM ["+ comboBox2.Text + "] WHERE [Peso (Kg)] = @Peso";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Peso", comboBox1.Text);
            //da.SelectCommand.Parameters.AddWithValue("@Plan", comboBox2.Text);
            DataTable dt = new DataTable();


            try
            {
                conn.Open();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            Comentarios cm = new Comentarios();
            cm.Show();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Gestion_Realizar GR = new Gestion_Realizar();
            this.Hide();
            GR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio_de_Sesion IS = new Inicio_de_Sesion();
            this.Hide();
            IS.Show();
        }
    }
}
