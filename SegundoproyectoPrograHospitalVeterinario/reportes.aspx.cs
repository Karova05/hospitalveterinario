using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace SegundoproyectoPrograHospitalVeterinario
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                LlenarGrid(); 
            
            }
            
        }

        protected void bingresar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            // SqlCommand comando = new SqlCommand(" INSERT INTO mascota VALUES('" + tid.Text + "')", conexion);
            // comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM mascotas"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            // GridView1.DataSource = dt;
                            // GridView1.DataBind(); // refrescar la tabla
                        }
                    }
                }
            }
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            // SqlCommand comando = new SqlCommand("DELETE mascota WHERE ID = '" + tid.Text + "'", conexion);
            // comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        protected void bmodificar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            // SqlCommand comando = new SqlCommand("UPDATE mascota SET id = '" + tid.Text + "' , nombre = '", conexion);
            // comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }
    }
}