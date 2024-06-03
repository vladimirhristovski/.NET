<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="IT_lab1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt-3">
        <img src="finki-logo.jpg" />
    </div>

    <div class="row mt-3">
        <asp:Label ID="lblProfesor" runat="server" Text="Изберете предмет"></asp:Label>
    </div>

    <div class="row mt-3">
        <asp:ListBox ID="lbPredmeti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged"></asp:ListBox>
    </div>

    <div class="row mt-3">
        <asp:ListBox ID="lbKrediti" runat="server" EnableTheming="True"></asp:ListBox>
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnVote" runat="server" Text="Гласајте" OnClick="btnVote_Click" />
    </div>

    <div class="row mt-3">
        Предмет:<asp:TextBox ID="tbSubject" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        Професор:<asp:TextBox ID="tbProfesor" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        Кредити:<asp:TextBox ID="tbCredits" runat="server"></asp:TextBox>
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnAdd" runat="server" Text="Додади" OnClick="btnAdd_Click" />
    </div>

    <div class="row mt-3">
        <asp:Button ID="btnDelete" runat="server" Text="Избриши" OnClick="btnDelete_Click" />
    </div>

</asp:Content>
