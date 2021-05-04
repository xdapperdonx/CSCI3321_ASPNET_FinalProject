<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAuthors.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="row">
        <div class="col-md-12">
            <h3>Add Authors</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            Author ID:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtAuthorID" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Last Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            First Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Gender:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Birth Date:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-12">
            <asp:Button ID="btnAddAuthor" runat="server" Text="Add Author" OnClick="btnAddAuthor_Click" />
        </div>
    </div>
</asp:Content>
