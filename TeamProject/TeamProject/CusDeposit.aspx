<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CusDeposit.aspx.vb" Inherits="TeamProject.CusDeposit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style2
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span class="auto-style2"><strong>Make a Deposit</strong></span><br /><strong>
    <br />Choose Account:<asp:DropDownList ID="ddlAccount" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    Deposit Amount: </strong>$<asp:TextBox ID="txtDeposit" runat="server"></asp:TextBox>
    <strong>
    <br />
    <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
    <br />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
    <br /></strong>
</asp:Content>
