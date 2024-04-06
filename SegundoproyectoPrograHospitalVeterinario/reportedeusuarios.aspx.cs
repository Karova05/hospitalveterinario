using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoproyectoPrograHospitalVeterinario
{
    public partial class reportedeusuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

          
        {

            LlenarGrid();

    }

        protected void tagregar_Click(object sender, EventArgs e)
        {

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand(" INSERT INTO usuarios VALUES('" + tlogin.Text + "', '" + tclave.Text + "', '" + tnombre.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();


        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM usuarios")) // Para liberar datos 
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind(); // refrescar la tabla
                        }
                    }
                }
            }
        }
    


        protected void tborrar_Click(object sender, EventArgs e)
        {

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("DELETE usuarios WHERE loginusuario = '" + tlogin.Text + "'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();


        }

        protected void tmodificar_Click(object sender, EventArgs e)
        {

            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE usuarios SET nombreusuario = '" + tnombre.Text + "' , nombreusuario = '", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();


        }
                
        protected void blimpiar_Click(object sender, EventArgs e)
        {

            tlogin.Text = "";
            tclave.Text = " ";
            tnombre.Text = " ";

        }
    }
}