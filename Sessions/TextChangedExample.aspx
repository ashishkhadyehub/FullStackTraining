<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="TextChangedExample.aspx.cs" Inherits="Sessions.TextChangedExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label>Enter Id:</label>
                    <asp:TextBox runat="server" AutoPostBack="true" OnTextChanged="txtId_TextChanged" CssClass="form-control" placeholder="Enter Id" ID="txtId"></asp:TextBox>

                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label>Username is:</label>
                    <asp:TextBox runat="server" Enabled="false" CssClass="form-control"  ID="txtusername"></asp:TextBox>

                </div>
            </div>


        </div>
    </div>
</asp:Content>
