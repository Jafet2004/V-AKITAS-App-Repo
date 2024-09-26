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
    public partial class Premiun : Form
    {
        public Premiun()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Inicio In = new Inicio();
            this.Hide();
            In.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            Comentarios cm = new Comentarios();
            cm.Show();
        }
    }
}
