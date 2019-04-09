using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WProyectoGuarderia
{
    class cConexion
    {
        SqlConnection cn;
        SqlCommand cmd;//sentencias para agregar, eliminar,...
        SqlDataReader dr;
        public cConexion()
        {
            try
            {
                cn = new SqlConnection("Data Source =VLAD-PC; Initial Catalog = Guarderia; Integrated Security = True");
                //Data Source=VLAD-PC;Initial Catalog=Guarderia;Integrated Security=True
                cn.Open();
                //MessageBox.Show("conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se conecto: " + ex.ToString());
            }
        }
        public string insertar(string id, string Nombres, string Apellidos, int Edad)
        {
            string salida = "se inserto";
            try
            {
                cmd = new SqlCommand("Insert into TNiños(IdNiño,Nombres,Apellidos,Edad) values('"+id+"','" + Nombres + "','" + Apellidos + "'," + Edad + ")", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "no se conecto: " + ex.ToString();
            }
            return salida;
        }
        public void Eliminar(string id)
        {
            cmd = new SqlCommand(string.Format("delete from TNiños where IdNiño= {0}", id), cn);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("Niño Eliminado correctamente");
        }
    }
}
