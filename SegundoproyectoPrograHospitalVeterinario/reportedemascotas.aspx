<%@ Page Title="" Language="C#" MasterPageFile="~/menu2reportes.Master" AutoEventWireup="true" CodeBehind="reportedemascotas.aspx.cs" Inherits="SegundoproyectoPrograHospitalVeterinario.reportedemascotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
[0:04 a. m., 6/4/2024] +506 8314 9766: <div class="text-center">
        <h1>Reporte de Mascotas</h1>
    </div>

    <div>
        <table class="w-100">
            <tr>
                <td>
                    <br />
                    <asp:GridView ID="GridViewMascotas" runat="server" OnSelectedIndexChanged="GridViewMascotas_SelectedIndexChanged">
                    </asp:GridView>
                    <br />
                    Nombre de Mascota<br />
                    <br />
                    <asp:TextBox ID="txtNombreMascota" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Especie<br />
                    <asp:TextBox ID="txtEspecie" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Tipo de Comida Favorita<br />
                    <br />
                    <asp:TextBox ID="txtComidaFavorita" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <br />
                    ID Mascota<br />
                    <asp:TextBox ID="txtIdMascot" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Tipo de Mascota<br />
                    <asp:DropDownList ID="ddlTipoMascota" runat="server">
                        <asp:ListItem Text="Doméstica" Value="Domestica"></asp:ListItem>
                        <asp:ListItem Text="Rural" Value="Rural"></asp:ListItem>
                        <asp:ListItem Text="Exótica" Value="Exotica"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="btnAgregarMascota" runat="server" OnClick="btnAgregarMascota_Click" Text="Agregar" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnBorrarMascota" runat="server" OnClick="btnBorrarMascota_Click" Text="Borrar" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnModificarMascota" runat="server" OnClick="btnModificarMascota_Click" Text="Modificar" />
                    &nbsp;
                    <asp:Button ID="btnLimpiarMascota" runat="server" OnClick="btnLimpiarMascota_Click" Text="Limpiar" />
                    <br />
                    <br />
                    <br />
                    <br />
                    
                    
                </td>
            </tr>
        </table>
    </div>
    </div>
   
</asp:Content>