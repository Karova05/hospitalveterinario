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
    public partial class ReporteDeControlDeCitas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
                LlenarGridCitasFuturas();
            }
        }

        protected void LlenarGridCitasFuturas()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("SELECT m.nombremascota, c.proximafecha, me.nombre FROM citas c INNER JOIN mascotas m ON c.idmascota = m.idmascota INNER JOIN medico me ON c.idmedico = me.idmedico WHERE c.proximafecha >= CAST(GETDATE() AS Date) ORDER BY c.proximafecha DESC", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridViewCitasFuturas.DataSource = dt;
                            GridViewCitasFuturas.DataBind();
                        }
                    }
                }
            }
        }



        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT m.nombremascota, c.proximafecha, c.idmedico FROM citas c INNER JOIN mascotas m ON c.idmascota = m.idmascota"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridViewCitas.DataSource = dt;
                            GridViewCitas.DataBind();
                        }
                    }
                }
            }
        }

        protected void btnAgregarCita_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO citas (idmascota, proximafecha, idmedico) VALUES (@IdMascota, @ProximaFecha, @IdMedico)", con);
                cmd.Parameters.AddWithValue("@IdMascota", txtNombreMascota.Text);
                cmd.Parameters.AddWithValue("@ProximaFecha", txtFechaCita.Text);
                cmd.Parameters.AddWithValue("@IdMedico", txtIdDoctor.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LlenarGrid();
            }
        }

        protected void btnEliminarCita_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM citas WHERE idmascota = @IdMascota", con);
                cmd.Parameters.AddWithValue("@IdMascota", txtNombreMascota.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LlenarGrid();
            }
        }

        protected void btnModificarCita_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE citas SET proximafecha = @ProximaFecha, idmedico = @IdMedico WHERE idmascota = @IdMascota", con);
                cmd.Parameters.AddWithValue("@ProximaFecha", txtFechaCita.Text);
                cmd.Parameters.AddWithValue("@IdMedico", txtIdDoctor.Text);
                cmd.Parameters.AddWithValue("@IdMascota", txtNombreMascota.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                LlenarGrid();
            }
        }

        protected void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreMascota.Text = "";
            txtFechaCita.Text = "";
            txtIdDoctor.Text = "";
        }
    }
}