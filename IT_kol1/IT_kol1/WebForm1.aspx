<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT_kol1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt-3">

        <asp:Image ID="Image1" runat="server" ImageUrl="~/finki-logo.jpg" />

    </div>

    <div class="row mt-3">

        <asp:Label ID="lbl1" runat="server" Text="Добредојдовте на ФИНКИ"></asp:Label>

    </div>

    <div class="row mt-3">
        Корисничко име
        <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Внесете корисничко име" ControlToValidate="tbUsername" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Неправилен внес за корисничко име" ControlToValidate="tbUsername" CssClass="text-danger" ValidationExpression="(?=(\S*[a-z]){2,})(?=(\S*[A-Z]){2,})(?=(\S*[0-9]){2,}).+[a-zA-Z0-9!]{7,}"></asp:RegularExpressionValidator>
    </div>

    <div class="row mt-3">
        Лозинка
        <asp:TextBox type="password" ID="tbPass" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Внесете лозинка име" ControlToValidate="tbPass" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Неправилен внес за лозинка" CssClass="text-danger" ControlToValidate="tbPass" ValidationExpression="(?=(\S*[a-z]){2,})(?=(\S*[A-Z]){2,})(?=(\S*[0-9]){2,})(?=(\S*[!]){2,}).+[a-zA-Z0-9!]{7,}"></asp:RegularExpressionValidator>
    </div>

    <div class="row mt-3">
        Потврдете лозинка
        <asp:TextBox type="password" ID="tbPassConf" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Потврдете ја лозинката" ControlToValidate="tbPassConf" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Лозинките не се совпаѓаат" CssClass="text-danger" ControlToCompare="tbPass" ControlToValidate="tbPassConf"></asp:CompareValidator>

    </div>

    <div class="row mt-3">
        Е-пошта
        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Внесете е-пошта" ControlToValidate="tbEmail" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Неправилен внес за е-пошта" ValidationExpression="\S+\d+@\S+\.\S+" ControlToValidate="tbEmail" CssClass="text-danger"></asp:RegularExpressionValidator>

    </div>

    <div class="row mt-3">
        Телефон
        <asp:TextBox ID="tbPhone" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Внесете телефон" ControlToValidate="tbPhone" CssClass="text-danger"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="Неправилен внес за телефон" CssClass="text-danger" ControlToValidate="tbPhone" ValidationExpression="[+]*[0|3][8]*[9]*[7][0-9][\s\/\+\-]*\d{3}[\s\/\-]*\d{3}"></asp:RegularExpressionValidator>
    </div>

    <div class="row mt-3">

        <asp:Button ID="btnLogin" runat="server" Text="Најава" OnClick="btnLogin_Click" />

    </div>

</asp:Content>
