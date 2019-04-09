using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WProyectoGuarderia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro frmabrir = new frmRegistro();
            frmabrir.Show();
        }

        private void listaDeUtilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void horariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cConexion c = new cConexion();
        }

        private void btnApoderado_Click(object sender, EventArgs e)
        {
            frmApoderado apor = new frmApoderado();
            apor.Show();
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            frmDirector direc = new frmDirector();
            direc.Show();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            frmDocente doc = new frmDocente();
            doc.Show();
        }
    }
}
