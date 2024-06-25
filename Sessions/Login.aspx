<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sessions.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
    <h2>Login</h2>

    
     <div class="form-group">
        <label>Email:</label>
        <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" placeholder="Enter Email" ID="txtEmail"></asp:TextBox>

    </div>
        <div class="form-group">
        <label>Password:</label>
        <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter Password" ID="txtPassword"></asp:TextBox>

    </div>
     
    
    <asp:Button OnClientClick="return validform()" runat="server" ID="btnSubmit" Text="Submit" CssClass="btn btn-primary" />
    

</div>
</asp:Content>
