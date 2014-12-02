<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CusHome.aspx.vb" Inherits="TeamProject.CusHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span class="auto-style2"><strong>Customer Home</strong></span><br />
    <strong>
    <br />
    Services<br />
    <asp:LinkButton ID="lnkDeposit0" runat="server" PostBackUrl="~/CusDeposit.aspx">Make a Deposit</asp:LinkButton>
    <br />
    <asp:LinkButton ID="lnkTransfer" runat="server" PostBackUrl="~/CusTransfer.aspx">Make a Transfer</asp:LinkButton>
    <br />
    <asp:LinkButton ID="lnkPayment" runat="server" PostBackUrl="~/CusPayment.aspx">Make a Payment</asp:LinkButton>
    <br />
    <asp:LinkButton ID="lnkNewAcc" runat="server" PostBackUrl="~/CusNewAcc.aspx">New Account</asp:LinkButton>
    <br />
    <asp:LinkButton ID="lnkModify" runat="server" PostBackUrl="~/CusModify.aspx">Manage Accounts</asp:LinkButton>
    <br />
    <br />
    View Accounts<br />
    Sort By:
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="ddlSortDate">Date of Activity</asp:ListItem>
        <asp:ListItem Value="ddlSortNam">Account Name</asp:ListItem>
        <asp:ListItem Value="ddlSortChe">Checking Accounts</asp:ListItem>
        <asp:ListItem Value="ddlSortSav">Savings Accounts</asp:ListItem>
        <asp:ListItem Value="ddlSortIRAS">IRAS</asp:ListItem>
        <asp:ListItem Value="ddlSortSto">Stock Portfolio</asp:ListItem>
        <asp:ListItem Value="ddlSortDef">Default</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSort" runat="server" Text="Sort" />
    <br />
    Search:
    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSearch" runat="server" Text="Search" />
    <br />
    <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="gvViewAll" runat="server">
    </asp:GridView>
    </strong>
</asp:Content>
