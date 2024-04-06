using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoproyectoPrograHospitalVeterinario
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bingresar_Click(object sender, EventArgs e)
        {

            CLSusuario.usuario = tusuario.Text;
            CLSusuario.clave = tcontrasena.Text;
            Response.Redirect("pagina.aspx");

        }
    }
}