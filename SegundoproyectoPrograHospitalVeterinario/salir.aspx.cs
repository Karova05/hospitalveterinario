using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoproyectoPrograHospitalVeterinario
{
    public partial class salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Cierra la página actual y muestra un mensaje de agradecimiento.
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ClosePageScript", "alert('Gracias por usar nuestros servicios'); window.close();", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Redirige al usuario al formulario inicio.aspx
            Response.Redirect("inicio.aspx");
        }
    }
}