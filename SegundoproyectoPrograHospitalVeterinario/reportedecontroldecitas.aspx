<%@ Page Title="" Language="C#" MasterPageFile="~/menu2reportes.Master" AutoEventWireup="true" CodeBehind="reportedecontroldecitas.aspx.cs" Inherits="SegundoproyectoPrograHospitalVeterinario.reportedecontroldecitas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <div>
        <img src="IMG/u_hispa%20(1).png" width="125" height="125" style="position: absolute; top: 0; right: 0;"/>
    </div>
    <div class="text-center">
        <h1>Reporte de Control de Citas</h1>
    </div>
    <div>
        <table class="w-100">
            <tr>
                <td>
                    <br />
                    <asp:GridView ID="GridViewCitas" runat="server" Width="467px">
                    </asp:GridView>
    <asp:GridView ID="GridViewCitasFuturas" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="proximafecha" HeaderText="Fecha" SortExpression="proximafecha" />
            <asp:BoundField DataField="nombremascota" HeaderText="Mascota" SortExpression="nombremascota" />
            <asp:BoundField DataField="nombremedico" HeaderText="Doctor" SortExpression="nombremedico" />
        </Columns>
    </asp:GridView>
                    <br />
                    Nombre de la mascota:<br />
                    <asp:TextBox ID="txtNombreMascota" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    Fecha de la cita:<br />
                    <asp:TextBox ID="txtFechaCita" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    ID del doctor:<br />
                    <asp:TextBox ID="txtIdDoctor" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="btnAgregarCita" runat="server" OnClick="btnAgregarCita_Click" Text="Agregar" />
                    <asp:Button ID="btnEliminarCita" runat="server" OnClick="btnEliminarCita_Click" Text="Eliminar" />
                    <asp:Button ID="btnModificarCita" runat="server" OnClick="btnModificarCita_Click" Text="Modificar" />
                    <asp:Button ID="btnLimpiarCampos" runat="server" OnClick="btnLimpiarCampos_Click" Text="Limpiar Campos" />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    </div>
    <div style="float: right; height: 10px; overflow-y: scroll; border: 1px solid #000;">
</div>

</asp:Content>