using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace SegundoproyectoPrograHospitalVeterinario
{
    public partial class reportedemascotas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGridMascotas();
            }

        }

        protected void btnAgregarMascota_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Mascotas (nombre, especie, comida_favorita, tipo_mascota) " +
                               "VALUES (@Nombre, @Especie, @ComidaFavorita, @TipoMascota)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtNombreMascota.Text);
                    command.Parameters.AddWithValue("@Especie", txtEspecie.Text);
                    command.Parameters.AddWithValue("@ComidaFavorita", txtComidaFavorita.Text);
                    command.Parameters.AddWithValue("@TipoMascota", ddlTipoMascota.SelectedValue);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            LlenarGridMascotas();
        }

        protected void btnBorrarMascota_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Mascotas WHERE idmascota = @IdMascota";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdMascota", int.Parse(txtIdMascot.Text)); // Corregido el nombre del control

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            LlenarGridMascotas();
        }

        protected void btnModificarMascota_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Mascotas SET nombre = @Nombre, especie = @Especie, comida_favorita = @ComidaFavorita, tipo_mascota = @TipoMascota WHERE idmascota = @IdMascota";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", txtNombreMascota.Text);
                    command.Parameters.AddWithValue("@Especie", txtEspecie.Text);
                    command.Parameters.AddWithValue("@ComidaFavorita", txtComidaFavorita.Text);
                    command.Parameters.AddWithValue("@TipoMascota", ddlTipoMascota.SelectedValue);
                    command.Parameters.AddWithValue("@IdMascota", int.Parse(txtIdMascot.Text)); // Corregido el nombre del control

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            LlenarGridMascotas();
        }

        protected void btnLimpiarMascota_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LlenarGridMascotas()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT idmascota, nombre, especie, comida_favorita, tipo_mascota FROM Mascotas";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridViewMascotas.DataSource = dt;
                    GridViewMascotas.DataBind();
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombreMascota.Text = "";
            txtEspecie.Text = "";
            txtComidaFavorita.Text = "";
            ddlTipoMascota.SelectedIndex = 0;
            txtIdMascot.Text = ""; // Limpiar también el campo de ID de mascota
        }
        protected void GridViewMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
