<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="IT_kol1.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt-3">

        <asp:Label ID="lblPlus" runat="server" Text="0"></asp:Label>

    </div>
    <div class="row mt-3">
        <asp:Button ID="btnAdd" runat="server" Text="Button" OnClick="btnAdd_Click" />
    </div>

    <div class="row mt-3">
        <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
    </div>

    <div class="row mt-3">
        <asp:Label ID="lbl2" runat="server" Text="Label"></asp:Label>
    </div>

    <div class="row mt-3">
        <asp:ListBox ID="lb11" runat="server"></asp:ListBox>
    </div>
    <div class="row mt-3">
    </div>
    <div class="row mt-3">
    </div>
    <div class="row mt-3">
    </div>

</asp:Content>
