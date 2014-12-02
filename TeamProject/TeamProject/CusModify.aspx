<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPage.Master" CodeBehind="CusModify.aspx.vb" Inherits="TeamProject.CusModify" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1
        {
            text-align: left;
        }
        .auto-style2
        {
            font-size: x-large;
        }
        .auto-style3
        {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
        <span class="auto-style2"><strong>Modify/Manage Account</strong></span><br />
        <strong>
        <br />
        View Personal Information<br /></strong>
        <asp:Label ID="Label15" runat="server" style="text-align: left" Text="Last Name: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewLastName" runat="server" ReadOnly="True" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label16" runat="server" Text="First Name: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewFirstName" runat="server" ReadOnly="True" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label17" runat="server" Text="Middle Initial: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewInitial" runat="server" MaxLength="1" ReadOnly="True" Width="19px" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label18" runat="server" Text="Address: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewAddress" runat="server" ReadOnly="True" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label19" runat="server" Text="City: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewCity" runat="server" ReadOnly="True" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label20" runat="server" Text="State: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewState" runat="server" ReadOnly="True" Width="19px" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label21" runat="server" Text="Zip: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewZip" runat="server" ReadOnly="True" Width="62px" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label22" runat="server" Text="Phone Number: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewPhone" runat="server" MaxLength="2" ReadOnly="True" TextMode="Phone" Width="97px" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br /></strong>
        <asp:Label ID="Label23" runat="server" Text="Email Address: "></asp:Label>
        <strong>
        <asp:TextBox ID="txtViewEmail" runat="server" MaxLength="9" ReadOnly="True" CssClass="auto-style3" Enabled="False"></asp:TextBox>
        <br />
        </strong>
        <asp:Label ID="Label27" runat="server" Text="Password:"></asp:Label>
        <strong>
        <asp:TextBox ID="txtPassword" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <br />
        Modify Personal Information</strong><br />
        <asp:Label ID="Label2" runat="server" style="text-align: left" Text="Last Name: "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="First Name: "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Middle Initial: "></asp:Label>
        <asp:TextBox ID="txtInitial" runat="server" MaxLength="1" ReadOnly="True" Width="19px"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Address: "></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="City: "></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" ReadOnly="True" Enabled="False" Width="126px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="State: "></asp:Label>
        <asp:TextBox ID="txtState" runat="server" ReadOnly="True" Width="19px" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Zip: "></asp:Label>
        <asp:TextBox ID="txtZip" runat="server" ReadOnly="True" Width="62px"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Phone Number: "></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" MaxLength="2" ReadOnly="True" TextMode="Phone" Width="97px"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Email Address: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" MaxLength="9" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <strong>Modify Password</strong><br />
        <asp:Label ID="Label11" runat="server" Text="Current Password: "></asp:Label>
        <asp:TextBox ID="txtCurrentPass" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="New Password: "></asp:Label>
        <asp:TextBox ID="txtNewPass" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label14" runat="server" Text="Confirm New Password: "></asp:Label>
        <asp:TextBox ID="txtConfirmCurrentPass" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <strong>Modify Bank Account Name</strong><br />
        <asp:Label ID="Label24" runat="server" Text="Select Account: "></asp:Label>
        <asp:DropDownList ID="ddlAccounts" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label26" runat="server" Text="Old Account Name: "></asp:Label>
        <asp:TextBox ID="txtOldAccName" runat="server" ReadOnly="True" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label25" runat="server" Text="New Account Name: "></asp:Label>
        <asp:TextBox ID="txtNewAccName" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        <br />
    </div>
    <br />
    <asp:Button ID="btnCancel" runat="server" CausesValidation="False" Text="Cancel" Visible="False" Width="135px" />
&nbsp;
        <asp:Button ID="btnSave" runat="server" CausesValidation="False" Text="Save Changes" Visible="False" Width="135px" />
</asp:Content>
