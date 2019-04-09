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
    public partial class frmRegistro : Form
    {
        cConexion c = new cConexion();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//boton insertar
        {
            c.insertar(txtIdNiño.Text, txtNombre.Text,txtApellidos.Text,int.Parse(txtEdad.Text));         
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            c.Eliminar(txtIdNiño.Text);
        }
    }
}
