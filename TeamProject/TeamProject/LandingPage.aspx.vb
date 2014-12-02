Public Class LandingPage

    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CustomerLoginVisible()
    End Sub

    Protected Sub lnkCustomerToggle_Click(sender As Object, e As EventArgs) Handles lnkCustomerToggle.Click
        CustomerLoginVisible()

    End Sub

    Protected Sub lnkEmployeeToggle_Click(sender As Object, e As EventArgs) Handles lnkEmployeeToggle.Click
        EmployeeLoginVisible()

    End Sub

    Protected Sub btnEmployeeLogin_Click(sender As Object, e As EventArgs) Handles btnEmployeeLogin.Click

        Dim strEmpID As String
        Dim strEmpPassword As String
        Dim Valid As New ClassValidate
        Dim EmpDB As New ClassEmployeeDB

        'check id for letters
        strEmpID = Valid.CheckDigits(txtEmpLoginID.Text)
        'if id contains letters then bad login
        If strEmpID = False Then
            lblMessage.Text = "Incorrect Employee ID or password"
            EmployeeLoginVisible()
            Exit Sub
        End If


        'validate username
        strEmpID = EmpDB.CheckEmpID(txtEmpLoginID.Text)
        'if username bad,
        If strEmpID = False Then
            ' message and exit
            lblMessage.Text = "Incorrect Employee username or password"
            EmployeeLoginVisible()
            Exit Sub
        End If

        'checkpassword
        strEmpPassword = EmpDB.CheckPassword(txtEmpLoginPassword.Text)
        'if password bad
        If strEmpPassword = False Then
            'message and exit
            lblMessage.Text = ("Incorrect Employee username or password")
            EmployeeLoginVisible()
            Exit Sub
        End If




        ''if good login ...
        'lblError.Text = ("good login")

        'Response.Redirect("WebForm2.aspx")

        ''if not good login
        ''add 1 to count 
        ''if 3 or greater then 
        ''   disable login 



        'create session EmpType and store this employee's information there for next form 
        Session("EmpType") = EmpDB.CustDataset.Tables("tblemployee").Rows(0).Item("EmpType").ToString 'you get this out of row zero in emp dataset
        'call next page (view customers)
        Response.Redirect("CusHome.aspx")
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        Response.Redirect("ForgotPassword.aspx")
    End Sub

    Protected Sub LinkButton3_Click(sender As Object, e As EventArgs) Handles LinkButton3.Click
        Response.Redirect("ForgotPassword.aspx")
    End Sub

    Public Sub CustomerLoginVisible()
        CustomerLoginPanel.Visible = True
        EmployeeLoginPanel.Visible = False

    End Sub

    Public Sub EmployeeLoginVisible()
        CustomerLoginPanel.Visible = False
        EmployeeLoginPanel.Visible = True
    End Sub

    Protected Sub btnCustomerLogin_Click(sender As Object, e As EventArgs) Handles btnCustomerLogin.Click
        Dim strCusID As String
        Dim strCusPassword As String
        Dim Valid As New ClassValidate
        Dim CusDB As New ClassCustomerDB


        'validate username
        strCusID = CusDB.CheckEmail(txtCusLoginID.Text)
        'if username bad,
        If strCusID = False Then
            ' message and exit
            lblCusLoginMessage.Text = "Incorrect E-mail ID or Password"
            CustomerLoginVisible()
            Exit Sub
        End If

        'checkpassword
        strCusPassword = CusDB.CheckPassword(txtCusLoginPassword.Text)
        'if password bad,
        If strCusPassword = False Then
            'message and exit
            lblCusLoginMessage.Text = ("Incorrect E-mail or Password")
            CustomerLoginVisible()
            Exit Sub
        End If




        ''if good login ...
        'lblError.Text = ("good login")

        'Response.Redirect("WebForm2.aspx")

        ''if not good login
        ''add 1 to count 
        ''if 3 or greater then 
        ''   disable login 



        'create session EmpType and store this employee's information there for next form 
        'Session("EmpType") = CusDB.CustDataset.Tables("tblCustomers").Rows(0).Item("EmpType").ToString 'you get this out of row zero in emp dataset
        'call next page (view customers)
        Response.Redirect("CusHome.aspx")
    End Sub
End Class