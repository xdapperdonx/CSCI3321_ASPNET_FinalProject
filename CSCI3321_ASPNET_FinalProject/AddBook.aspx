<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h3>Add Books</h3>
        </div>
    </div>
        <div class="row">
        <div class ="col-md-3">
            Book ID:
        </div>
        <div class ="col-md-9">            
            <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>            
        </div>
        <div class ="col-md-3">            
            Title:
        </div>
        <div class ="col-md-9">        
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>            
        </div>
        <div class ="col-md-3">
            Author ID:
        </div>
        <div class ="col-md-9">            
            <asp:DropDownList ID="drpAuthorID" runat="server" DataSourceID="sdsAuthorID" DataTextField="AuthorID" DataValueField="AuthorID"></asp:DropDownList>            
            <asp:SqlDataSource ID="sdsAuthorID" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT AuthorID FROM Authors"></asp:SqlDataSource>
        </div>
        <div class ="col-md-3">
            Price:
        </div>
        <div class ="col-md-9">            
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>            
        </div>
        <div class ="col-md-3">
            Publish Date:
        </div>
        <div class ="col-md-9">            
            <asp:TextBox ID="txtPublishDate" runat="server"></asp:TextBox>            
        </div>
        <div class ="col-md-3">
            Publisher ID:
        </div>
        <div class ="col-md-9">            
            <asp:DropDownList ID="drpPublisherID" runat="server" DataSourceID="sdsPublisherID" DataTextFormatString="PublisherID" DataValueField="PublisherID"></asp:DropDownList>            
            <asp:SqlDataSource ID="sdsPublisherID" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT PublisherID FROM Publishers"></asp:SqlDataSource>
        </div>
        <div class ="col-md-3">
            Genre ID:
        </div>
        <div class ="col-md-9">              
            <asp:DropDownList ID="drpGenreID" runat="server" DataSourceID="sdsGenreID" DataTextField="GenreID" DataValueField="GenreID"></asp:DropDownList>            
            <asp:SqlDataSource ID="sdsGenreID" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT GenreID FROM Genres"></asp:SqlDataSource>
        </div>
        <div class ="col-md-3">
            Word Count:
        </div>
        <div class ="col-md-9">              
            <asp:TextBox ID="txtWordCount" runat="server"></asp:TextBox>            
        </div>
        <div class="col-md-12">
            <asp:Button ID="btnAddBook" runat="server" Text="Add Book" OnClick="btnAddBook_Click" />
        </div>
    </div>
</asp:Content>
