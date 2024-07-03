<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="GV.aspx.cs" Inherits="Sessions.GV" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:50px">
        <h2 style="text-align:center">Gridview Example - insert,update,delete</h2>

<asp:GridView ID="gvdata" runat="server" CssClass="table table-striped" AutoGenerateColumns="false" DataKeyNames="Srno"
        OnRowEditing="gvdata_RowEditing" OnRowCancelingEdit="gvdata_RowCancelingEdit"
    OnRowUpdating="gvdata_RowUpdating" OnRowDeleting="gvdata_RowDeleting" EmptyDataText="No data found">
    <Columns>
        <asp:TemplateField HeaderText="Student Name" ItemStyle-Width="150">
            <ItemTemplate>
                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txteName" runat="server" Text='<%# Eval("Name") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="City" ItemStyle-Width="150">
            <ItemTemplate>
                <asp:Label ID="lblCountry" runat="server" Text='<%# Eval("City") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="txteCountry" runat="server" Text='<%# Eval("City") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true"
            ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
<table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
    <tr>
        <td style="width: 150px">
            Name:<br />
            <asp:TextBox ID="txtname" runat="server" Width="140" />
        </td>
        <td style="width: 150px">
            City:<br />
            <asp:TextBox ID="txtcity" runat="server" Width="140" />
        </td>
        <td style="width: 100px">
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        </td>
    </tr>
</table>
    </div>
</asp:Content>
