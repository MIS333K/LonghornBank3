Option Strict On
Imports System.Data
Imports System.Data.SqlClient

Public Class CusCreate

    Inherits System.Web.UI.Page
    Dim DBcus As New ClassCustomerDB
    Dim DBvalid As New ClassValidate
    Dim strRecordID As String
    Dim strClientID As String
    Dim intClientIDCount As Integer
    Dim mstrQuery As String

    Protected Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        NoBlanks()
        Validations()
        'assigns new client ID
        intClientIDCount = 1000000001 + DBcus.CusView.Count
        strClientID = intClientIDCount.ToString

        'mstrQuery
        DBcus.AddCustomer(strClientID, txtFirstName.Text, txtInitial.Text, txtLastName.Text, txtPassword.Text, txtAddress.Text, txtZip.Text, txtEmail.Text, txtPhone.Text, txtBirth.Text)
        DBcus.UpdateDB(mstrQuery)

        'returns a message
        'lblMsg.Text = "Added!"
        Response.Redirect("CusNewAcc.aspx")
    End Sub

    '***************Subs***********
    Private Sub NoBlanks()
        If DBvalid.CheckBlank(txtFirstName.Text) = False Then
            lblMsg.Text = "First Name Cannot be Empty"
            Exit Sub
        ElseIf DBvalid.CheckBlank(txtLastName.Text) = False Then
            lblMsg.Text = "Last Name Cannot be Empty"
            Exit Sub
        ElseIf DBvalid.CheckBlank(txtBirth.Text) = False Then
            lblMsg.Text = "Birthdate Cannot be Empty"
            Exit Sub
        ElseIf DBvalid.CheckBlank(txtPhone.Text) = False Then
            lblMsg.Text = "Phone Number Cannot be Empty"
            Exit Sub
        ElseIf DBvalid.CheckBlank(txtEmail.Text) = False Then
            lblMsg.Text = "Email Address Cannot be Empty"
            Exit Sub
        ElseIf DBvalid.CheckBlank(txtPassword.Text) = False Then
            lblMsg.Text = "Password Cannot be Empty"
            Exit Sub
        ElseIf DBvalid.CheckBlank(txtConfirmPass.Text) = False Then
            lblMsg.Text = "Please Confirm Your Password"
            Exit Sub
        End If
    End Sub

    Private Sub Validations()
        If DBvalid.CheckLetters(txtFirstName.Text) = False Then
            lblMsg.Text = "First Name Must be Composed of Letters"
            Exit Sub
        End If

        If DBvalid.CheckLetters(txtLastName.Text) = False Then
            lblMsg.Text = "Last Name Must be Composed of Letters"
            Exit Sub
        End If


        'if username is bad then,
        If DBcus.CheckEmail(txtEmail.Text) = True Then
            ' message and exit
            lblMsg.Text = "Email address already exists! Please put in a new email."
            Exit Sub
        End If
        'required fields and emails are handled by built in validators

        'Validations:
        'Middle Initials must be 1 letter
        If DBvalid.CheckLetters(txtInitial.Text) = False Then
            lblMsg.Text = "Middle Initial Must be a Letter"
            Exit Sub
        ElseIf DBvalid.CheckMI(txtInitial.Text) = False Then
            lblMsg.Text = "Middle Initial Must be 1 Letter"
            Exit Sub
        End If

        'Address must be either number or letters
        If txtAddress.Text <> "" Then
            If DBvalid.CheckDigitsAndLetters(txtAddress.Text) = False Then
                lblMsg.Text = "Address cannot have special characters"
                Exit Sub
            End If
        End If


        'Zip Code must be 5 numbers
        If txtZip.Text <> "" Then
            If DBvalid.CheckDigits(txtZip.Text) = False Then
                lblMsg.Text = "Zip Code Must be Numbers"
                Exit Sub
            ElseIf DBvalid.CheckZip(txtZip.Text) = False Then
                lblMsg.Text = "Zip Code Must be 5 Numbers"
                Exit Sub
                '****** ADD A DBZIP CODE TO CHECK FOR EXISTING ZIP
            End If
        End If

        'Phone number must be 10 numbers
        If DBvalid.CheckDigits(txtPhone.Text) = False Then
            lblMsg.Text = "Phone Number Must be Numbers"
            Exit Sub
        ElseIf DBvalid.CheckPhone(txtPhone.Text) = False Then
            lblMsg.Text = "Phone Must be 10 Numbers"
            Exit Sub
        End If

        'Password must be either number or letters
        If DBvalid.CheckDigitsAndLetters(txtPassword.Text) = False Then
            lblMsg.Text = "Password cannot have special characters"
            Exit Sub
        End If

        If DBvalid.CheckPassword(txtPassword.Text, txtConfirmPass.Text) = False Then
            lblMsg.Text = "Password does not Match "
            Exit Sub
        End If
    End Sub

    Sub Clear()
        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtInitial.Text = ""
        txtAddress.Text = ""
        txtBirth.Text = ""
        txtCity.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtConfirmPass.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtPhone.Text = ""

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '**********return back to login screen 
        Clear()
    End Sub

    '*******make so if they haven't created a new bank account they return back home
End Class
