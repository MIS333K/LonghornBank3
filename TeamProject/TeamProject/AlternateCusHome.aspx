<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="AlternateCusHome.aspx.vb" Inherits="TeamProject.CusHome" %>
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
    View Accounts<br />
    <br />
    <br />
    View All Accounts<br />
    <asp:GridView ID="gvViewAll" runat="server">
    </asp:GridView>
    <br />
    <br />
    Checking Accounts<br />
    <asp:GridView ID="gvCheAcc" runat="server">
    </asp:GridView>
    <br />
    <br />
    Savings Accounts<br />
    <asp:GridView ID="gvSavAcc" runat="server">
    </asp:GridView>
    <br />
    <br />
    Individual Retirement Accounts<br />
    <asp:GridView ID="gvIRAS" runat="server">
    </asp:GridView>
    <br />
    <br />
    Stock Portfolio<br />
    <asp:GridView ID="gvStoPor" runat="server">
    </asp:GridView>
    </strong>
</asp:Content>
