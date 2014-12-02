<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="LandingPage.aspx.vb" Inherits="TeamProject.LandingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr /> 
    <div id="login">
    <div id="toggle">
       
    <asp:LinkButton ID="lnkCustomerToggle" runat="server">Customer Login</asp:LinkButton>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="lnkEmployeeToggle" runat="server">Employee Login</asp:LinkButton>
    </div>
        <asp:Panel ID="CustomerLoginPanel" runat="server">
            
            <div id="customer_login">
                <h3>Customer Login</h3>
                <asp:Label ID="Label1" runat="server" Text="Customer ID"></asp:Label>
                <br /><asp:TextBox ID="txtCusLoginID" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                <br /><asp:TextBox ID="CusLoginPassword" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="btnCustomerLogin" runat="server" Text="Login" />
                <br /><br />
                <asp:LinkButton ID="LinkButton1" runat="server">Forgot Password?</asp:LinkButton>
                <br />
                <asp:LinkButton ID="LinkButton2" runat="server">Activate New Account</asp:LinkButton>
            </div>
        </asp:Panel>


    <asp:Panel ID="EmployeeLoginPanel" runat="server">
            
            <div id="employee_login">
                <h3>Employee Login</h3>
                <asp:Label ID="Label3" runat="server" Text="Employee ID"></asp:Label>
                <br /><asp:TextBox ID="txtEmpLoginID" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
                <br /><asp:TextBox ID="txtEmpLoginPassword" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Button ID="btnEmployeeLogin" runat="server" Text="Login" />
                <br /><br />
                <asp:LinkButton ID="LinkButton3" runat="server">Forgot Password?</asp:LinkButton>
                <br />
                <br />
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                <br />
            </div>
        </asp:Panel>
</div>    
</asp:Content>
