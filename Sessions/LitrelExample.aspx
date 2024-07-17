<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="LitrelExample.aspx.cs" Inherits="Sessions.LitrelExample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <link href="https://fonts.googleapis.com/css?family=Droid+Sans:400,700" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" />
    <link href="css/fluid-gallery.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container gallery-container">

        <h2 style="text-align: center">ASP Literal Example</h2>
        <div class="tz-gallery" style="padding: 0">

            <div class="row">


                <asp:Literal runat="server" ID="lgallery"></asp:Literal>

            </div>

        </div>

    </div>

    <script src = "https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js" ></script>
    <script>
            baguetteBox.run('.tz-gallery');
    </script>
</asp:Content>
