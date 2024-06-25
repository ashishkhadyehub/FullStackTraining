<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Sessions.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.7.1/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>

    <%--sweetalert references--%>
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.0/sweetalert.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/sweetalert/1.1.0/sweetalert.min.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <h2>ASP.NET Web Form</h2>

                <div class="form-group">
                    <label>Name:</label>
                    <asp:TextBox runat="server" CssClass="form-control" placeholder="Enter Name" ID="txtName"></asp:TextBox>

                </div>
                <div class="form-group">
                    <label>Contact:</label>
                    <asp:TextBox runat="server" CssClass="form-control" TextMode="Number" placeholder="Enter Contact" ID="txtContact"></asp:TextBox>

                </div>
                 <div class="form-group">
                    <label>Email:</label>
                    <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" placeholder="Enter Email" ID="txtEmail"></asp:TextBox>

                </div>
                 <div class="form-group">
                    <label>Select City:</label>
                   <asp:DropDownList CssClass="form-control" runat="server" ID="ddlCities">
                       <asp:ListItem Text="Select City" Value="Select"></asp:ListItem>
                       <asp:ListItem Text="Pune" Value="Pune"></asp:ListItem>
                       <asp:ListItem Text="Mumbai" Value="Mumbai"></asp:ListItem>
                   </asp:DropDownList>

                </div>
                
                <asp:Button OnClientClick="return validform()" runat="server" ID="btnSubmit" Text="Submit" CssClass="btn btn-primary" />
                

            </div>
        </div>
    </form>
    <script>
        function validform() {
            let name = document.getElementById('<%= this.txtName.ClientID %>').value;
            let contact = document.getElementById('<%= this.txtContact.ClientID %>').value;
            let email = document.getElementById('<%= this.txtEmail.ClientID %>').value;
            let city = document.getElementById('<%= this.ddlCities.ClientID %>').value;
            let mobilecon = /^\d{10}$/;
            let emailcon = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/;


            if (name == "" || contact == "" || email == "" || city == "Select") {
                swal("Please fill all details..!","","warning");
                return false;
            }

            if (contact != '') {
                if (!contact.match(mobilecon)) {
                    swal("Invalid contact number..!", "", "warning");
                    return false;
                }
            }

            if (email != '') {
                if (!email.match(emailcon)) {
                    swal("Invalid email-Id..!", "", "warning");
                    return false;
                }
            }

            return true;
        }
    </script>
</body>
</html>
