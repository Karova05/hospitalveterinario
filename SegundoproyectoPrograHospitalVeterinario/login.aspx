<%@ Page Title="" Language="C#" MasterPageFile="~/menu.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SegundoproyectoPrograHospitalVeterinario.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center">
    
    <h1> logueo </h1>
        

</div>

    <p>
        &nbsp;</p>
    <p>
        usuario
    </p>
    <p>
        <asp:TextBox ID="tusuario" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        contrasena</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:TextBox ID="tcontrasena" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <asp:Button ID="bingresar" runat="server" OnClick="bingresar_Click" Text="ingresar" />
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
