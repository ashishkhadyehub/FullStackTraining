<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UploadMedia.aspx.cs" Inherits="Sessions.UploadMedia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:40px">
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <asp:FileUpload runat="server" ID="fugallery" CssClass="form-control" Style="height: auto" AllowMultiple="true" />
                </div>
                <asp:Button runat="server" CssClass="btn btn-primary" OnClick="btnsubmit_Click" ID="btnsubmit"  BorderStyle="Double" Style="margin-top: 20px" Text="Upload Photos" />
            </div>
        </div>
    </div>
</asp:Content>
