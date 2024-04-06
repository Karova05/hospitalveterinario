<%@ Page Title="" Language="C#" MasterPageFile="~/menu2reportes.Master" AutoEventWireup="true" CodeBehind="reportedeusuarios.aspx.cs" Inherits="SegundoproyectoPrograHospitalVeterinario.reportedeusuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="text-center">
    
    <h1> reporte de usuarios </h1>
        

</div>

    <div>


        <table class="w-100">
            <tr>
                <td>
                    <br />
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                    <br />
                    loginusuario<br />
                    <br />
                    <asp:TextBox ID="tlogin" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    claveusuario<br />
                    <asp:TextBox ID="tclave" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    nombreusuario<br />
                    <br />
                    <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="tagregar" runat="server" OnClick="tagregar_Click" Text="agregar" />
&nbsp;&nbsp;
                    <asp:Button ID="tborrar" runat="server" OnClick="tborrar_Click" Text="borrar" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="tmodificar" runat="server" OnClick="tmodificar_Click" Text="modificar" />
                    &nbsp;
                    <asp:Button ID="blimpiar" runat="server" OnClick="blimpiar_Click" Text="limpiar" />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>


    </div>


</asp:Content>
