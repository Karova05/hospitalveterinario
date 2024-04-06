<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="salir.aspx.cs" Inherits="SegundoproyectoPrograHospitalVeterinario.salir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
    
    <h1> Salir </h1>
        <p> ¿ Esta seguro que quiere salir ?</p>
        <p> 
            <asp:Button ID="Button1" runat="server" Text="Si" Width="37px" />
        </p>
        <p> 
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="No" />
        </p>

</div>

</asp:Content>
