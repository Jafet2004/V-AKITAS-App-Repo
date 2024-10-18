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
    public partial class VersionGratuita : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=TH3B4R4K\\MSSQLSERVER2022;Initial Catalog=V-AKITAS;Integrated Security=True");
        public VersionGratuita(bool mostrarAtras)
        {
            InitializeComponent();
            // CargarTodosLosDatos();
            btnAtras.Visible = mostrarAtras;
        }

        private void CargarTable()
        {
            string query = "SELECT * FROM [Recursos Alimentarios] WHERE [Muestra de Grano] = @Muestra";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Muestra", txtMuestra.Text);
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



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTable();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Gestion_Realizar GR = new Gestion_Realizar();
            this.Hide();
            GR.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio_de_Sesion F = new Inicio_de_Sesion();
            this.Hide();
            F.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes
                txtMuestra.Text = row.Cells["Muestra de Grano"].Value.ToString();
                txtHum.Text = row.Cells["% Humedad"].Value.ToString();
                txtMS.Text = row.Cells["% Materia Seca"].Value.ToString();
                txtCen.Text = row.Cells["% Ceniza"].Value.ToString();
                txtProt.Text = row.Cells["% Proteina"].Value.ToString();
                txtFibra.Text = row.Cells["% Fibra"].Value.ToString();
                txtGrasa.Text = row.Cells["% Grasa"].Value.ToString();
                txtCarbo.Text = row.Cells["% Carbohidratos"].Value.ToString();
            }
        }

        private void VersionGratuita_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMuestra.Clear();
            txtHum.Clear();
            txtMS.Clear();
            txtCen.Clear()  ;
            txtProt.Clear();
            txtFibra.Clear();
            txtGrasa.Clear();
            txtCarbo.Clear();
           // CargarTodosLosDatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Comentarios cm = new Comentarios();
            cm.Show();
        }

        private void txtMuestra_TextChanged(object sender, EventArgs e)
        {
            pnlLista.Visible = true;
        }

        public bool MostrarAtras
        {
            get { return btnAtras.Visible; }
            set { btnAtras.Visible = value; }
        }
    }
}
