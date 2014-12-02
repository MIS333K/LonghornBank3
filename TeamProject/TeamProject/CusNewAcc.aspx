<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CusNewAcc.aspx.vb" Inherits="TeamProject.CusNewAcc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span class="auto-style2"><strong>New Account</strong></span><br />
    <br />
    <asp:Label ID="Label2" runat="server" style="text-align: left" Text="Select Account Type: "></asp:Label>
&nbsp;<asp:DropDownList ID="ddlAccTyp" runat="server">
        <asp:ListItem Value="ddlCheAcc">Checking Account</asp:ListItem>
        <asp:ListItem Value="ddlSavAcc">Savings Account</asp:ListItem>
        <asp:ListItem Value="ddlIRAS">Individual Retirement Account</asp:ListItem>
        <asp:ListItem Value="ddlStoPor">Stock Portfolio</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label3" runat="server" style="text-align: left" Text="Account Name: "></asp:Label>
    <asp:TextBox ID="txtAccName" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" style="text-align: left" Text="Account Number: "></asp:Label>
    <asp:TextBox ID="txtAccNum" runat="server" Enabled="False"></asp:TextBox>
    <br />
    <br />
    Initial Deposit: $<asp:TextBox ID="txtIniDep" runat="server"></asp:TextBox>
    <br />
    <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            <br />
        <br />
    <asp:Button ID="txtCancel" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="txtConfirm" runat="server" Text="Confirm" />
    <br />
</asp:Content>
