<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="IT_kol1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt-3">
        Внеси број 3-8
        <asp:TextBox ID="tbRange" runat="server" ValidationGroup="g1"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Внесете број" CssClass="text-danger" ControlToValidate="tbRange"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Погрешен внес" CssClass="text-danger" ControlToValidate="tbRange" MaximumValue="8" MinimumValue="3" ValidationGroup="g1"></asp:RangeValidator>
    </div>

    <div class="row mt-3">
        <asp:ListBox ID="lbValuti" runat="server" AutoPostBack="True"></asp:ListBox>
    </div>

    <div class="row mt-3">
        <asp:ListBox ID="lbVoD" runat="server"></asp:ListBox>
    </div>

    <div class="row mt-3">
        <asp:Label ID="lblPretvori" runat="server" Text=""></asp:Label>
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnTransfer" runat="server" Text="Pretvori" OnClick="btnTransfer_Click" ValidationGroup="g1" />
    </div>

    <div class="row mt-3">
        Валута 
        <asp:TextBox ID="tbValuta" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        Вредност
        <asp:TextBox ID="tbVoD" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnAdd" runat="server" Text="Додади" OnClick="btnAdd_Click" ValidationGroup="g2" />
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnRemove" runat="server" Text="Избриши" OnClick="btnRemove_Click" ValidationGroup="g2" />
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" ValidationGroup="g3" />
    </div>

</asp:Content>
