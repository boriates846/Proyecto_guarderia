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
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }
        public void Acceder()
        {
            string Usuario = "admin";
            string Contraseña = "123";
            if ((txtUsuario.Text == Usuario) && (txtContraseña.Text == Contraseña))
            {
                MessageBox.Show("Acceso permitido");
                this.Hide();
                //nombre del form a abrir
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {

                MessageBox.Show("Acceso denegado");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        private void frmSesion_Load(object sender, EventArgs e)
        {
            //cConexion c = new cConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = " ";
            txtContraseña.Text = " ";
        }
    }

}
   
