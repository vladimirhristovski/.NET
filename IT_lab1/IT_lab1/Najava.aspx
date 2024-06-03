<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="IT_lab1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt-3">
        Име<asp:TextBox ID="tbName" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" ErrorMessage="Внесете име" ControlToValidate="tbName"></asp:RequiredFieldValidator>
    </div>

    <div class="row mt-3">
        Лозинка<asp:TextBox ID="tbPassword" type="password" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="text-danger" ErrorMessage="Внесете лозинка" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
    </div>

    <div class="row mt-3">
        е-адреса<asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="text-danger" ErrorMessage="Внесете е-адреса" ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
    </div>

    <div class="row mt-3">
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" CssClass="text-danger" runat="server" ErrorMessage="Невалиден формат" ControlToValidate="tbEmail" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnLogin" runat="server" Text="Најавете се" OnClick="btnLogin_Click" />
    </div>

</asp:Content>
