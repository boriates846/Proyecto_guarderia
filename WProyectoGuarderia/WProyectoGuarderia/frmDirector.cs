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
    public partial class frmDirector : Form
    {
        public frmDirector()
        {
            InitializeComponent();
        }

        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro reg = new frmRegistro();
            reg.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro reg = new frmRegistro();
            reg.Show();
        }
    }
}
