<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPublishers.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="row">
        <div class="col-md-12">
            <h3>Add Publishers</h3>
        </div>
    </div>
    <div class="row">
        <div class="col-md-3">
            Publisher Id:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherID" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Publisher Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherName" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
         <div class="col-md-3">
             Publisher Address:
         </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherAddress" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Publisher City:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherCity" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Publisher Postal Code:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherPostal" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Publisher Country:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherCountry" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-3">
            Publisher Phone Number:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublisherNumber" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-12">           
            <asp:Button ID="btnAddPublisher" runat="server" Text="Add Publisher" OnClick="btnAddPublisher_Click"/>           
        </div>
    </div>
</asp:Content>
