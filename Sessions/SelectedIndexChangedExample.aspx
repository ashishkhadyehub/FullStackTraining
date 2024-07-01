<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="SelectedIndexChangedExample.aspx.cs" Inherits="Sessions.SelectedIndexChangedExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
      <div class="row">
          <div class="col-md-6">
              <div class="form-group">
                  <label>Select City Code</label>
                  <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" runat="server" CssClass="form-control" ID="ddlCity">
                      <asp:ListItem Text="Select City Code" Value="Select"></asp:ListItem>
                      <asp:ListItem Text="KOP" Value="KOP"></asp:ListItem>
                      <asp:ListItem Text="PUN" Value="PUN"></asp:ListItem>
                      <asp:ListItem Text="DEL" Value="DEL"></asp:ListItem>
                  </asp:DropDownList>

              </div>
          </div>
          <div class="col-md-6">
              <div class="form-group">
                  <label>City is:</label>
                  <asp:TextBox runat="server" Enabled="false" CssClass="form-control"  ID="txtCity"></asp:TextBox>

              </div>
          </div>


      </div>
  </div>
</asp:Content>
