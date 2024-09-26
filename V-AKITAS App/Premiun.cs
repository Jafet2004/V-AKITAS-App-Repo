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
            string query = "SELECT * FROM [Aumento de 1Kg por día] WHERE [Peso (Kg)] = @Peso";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Peso", comboBox1.Text);
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
    }
}
