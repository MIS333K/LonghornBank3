<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CusSavAcc.aspx.vb" Inherits="TeamProject.CusSavAcc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style2
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style2">
        <strong>Savings Account Transactions</strong></p>
    <strong>Listing Transactions for Account:
    <asp:DropDownList ID="ddlAccounts" runat="server">
    </asp:DropDownList>
    <br />
&nbsp;&nbsp;&nbsp; Account Name:<asp:TextBox ID="txtAccNam" runat="server" Enabled="False"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp; Account Number:<asp:TextBox ID="txtAccNum" runat="server" Enabled="False"></asp:TextBox>
    <br />
    <br />
    Search Options:&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp; Description:
    <asp:TextBox ID="txtSerDes" runat="server"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp; Transaction Number:<asp:TextBox ID="txtSerNum" runat="server"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp; Transaction Type:
    <asp:DropDownList ID="ddlSerTyp" runat="server">
        <asp:ListItem Value="ddlSerAll">All Types</asp:ListItem>
        <asp:ListItem Value="ddlSerDep">Deposit</asp:ListItem>
        <asp:ListItem Value="ddlSerWit">Withdrawal</asp:ListItem>
        <asp:ListItem Value="ddlSerTra">Transfer</asp:ListItem>
        <asp:ListItem Value="ddlSerBil">Bill</asp:ListItem>
    </asp:DropDownList>
    <br />
&nbsp;&nbsp;&nbsp; Amount:
    <asp:DropDownList ID="ddlSerAmo" runat="server">
        <asp:ListItem Value="ddlSerUnsAmo">Unspecified</asp:ListItem>
        <asp:ListItem Value="ddlSer100">0-$100</asp:ListItem>
        <asp:ListItem Value="ddlSer200">101-$200</asp:ListItem>
        <asp:ListItem Value="ddlSer300">201-$300</asp:ListItem>
        <asp:ListItem Value="ddlSer301">$301+</asp:ListItem>
        <asp:ListItem Value="ddlSerCusAmo">Custom Amount</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblFroAmo" runat="server" Text="From" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtSerLowAmo" runat="server" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblToAmo" runat="server" Text="To" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSerToAmo" runat="server" Visible="False"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp; Date:
    <asp:DropDownList ID="ddlSerDat" runat="server">
        <asp:ListItem Value="ddlSerAllDat">All Available</asp:ListItem>
        <asp:ListItem Value="ddlSer15">Last 15 Days</asp:ListItem>
        <asp:ListItem Value="ddlSer30">Last 30 Days</asp:ListItem>
        <asp:ListItem Value="ddlSer60">Last 60 Days</asp:ListItem>
        <asp:ListItem Value="ddlSerCusDat">Custom Date Range</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblFroDat" runat="server" Text="From" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtSerLowDat" runat="server" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblToDat" runat="server" Text="To" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSerToDat" runat="server" Visible="False"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSearch" runat="server" Text="Search" />
    <br />
    <br />
    <asp:Button ID="btnHome" runat="server" Text="Return Home" />
    <br />
    <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
    Sort By: <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="ddlSorAll">View All</asp:ListItem>
        <asp:ListItem Value="ddlSorNum">Number</asp:ListItem>
        <asp:ListItem Value="ddlSorNam">Name</asp:ListItem>
        <asp:ListItem Value="ddlSorAmo">Amount</asp:ListItem>
        <asp:ListItem Value="ddlSorDat">Date</asp:ListItem>
        <asp:ListItem Value="ddlSorWit">Withdrawals</asp:ListItem>
        <asp:ListItem Value="ddlSorDep">Deposit</asp:ListItem>
        <asp:ListItem Value="ddlSorTra">Transfer</asp:ListItem>
        <asp:ListItem Value="ddlSorBil">Bill</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:GridView ID="gvSavAccTraAll" runat="server">
    </asp:GridView>
    </strong>
</asp:Content>
