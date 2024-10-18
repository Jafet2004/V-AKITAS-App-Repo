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
    public partial class Gestion_Realizar : Form
    {
        public Gestion_Realizar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Premiun premiun = new Premiun();
            this.Hide();
            premiun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VersionGratuita version = new VersionGratuita(true);

            this.Hide();
            version.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoV_akitas info = new InfoV_akitas();
            this.Hide();
            info.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio_de_Sesion In = new Inicio_de_Sesion();
            this.Hide();
            In.Show();
        }
    }
}
