<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CusTransfer.aspx.vb" Inherits="TeamProject.CusTransfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">



        .auto-style2
        {
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span class="auto-style2"><strong>Make a Transfer</strong></span><br /><strong>
    <br />Transfer From:<asp:DropDownList ID="ddlFrom" runat="server">
    </asp:DropDownList>
    <br />Transfer Amount: </strong>$<asp:TextBox ID="txtTransfer" runat="server"></asp:TextBox>
    <strong>
    <br />
    Date for Transfer: <asp:TextBox ID="txtTraDat" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    Transfer To:<asp:DropDownList ID="ddlTo" runat="server">
    </asp:DropDownList>
    <br />
    <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
    </strong>
</asp:Content>
