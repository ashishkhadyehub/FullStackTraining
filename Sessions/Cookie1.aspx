<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Cookie1.aspx.cs" Inherits="Sessions.Cookie1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="container">
    

    <div class="form-group">
        <label>Name:</label>
        <asp:TextBox runat="server" CssClass="form-control" placeholder="Enter Name" ID="txtName"></asp:TextBox>

    </div>
    <div class="form-group">
        <label>Contact:</label>
        <asp:TextBox runat="server" CssClass="form-control" TextMode="Number" placeholder="Enter Contact" ID="txtContact"></asp:TextBox>

    </div>
    
    
    <asp:Button  runat="server" OnClick="btnSubmit_Click" ID="btnSubmit" Text="Confirm Details" CssClass="btn btn-primary" />
    

</div>
</asp:Content>
