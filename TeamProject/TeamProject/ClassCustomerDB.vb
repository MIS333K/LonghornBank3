'Author: Jee-Ho Kang
'Assignment: Longhorn Bank 
'Date: 11/26/14
'Program Description: accesses tblCustomers, and runs queries to fill in tables

Option Strict On
Imports System.Data
Imports System.Data.SqlClient

Public Class ClassCustomerDB

    'module level variables are internal to object
    Dim myView As New DataView
    Dim mDatasetCustomers As New DataSet
    Dim mstrQuery As String
    Dim mdbDataAdapter As New SqlDataAdapter
    Dim mdbConn As SqlConnection
    Dim dbCommand As New SqlCommand
    Dim mstrConnection As String = "workstation id=COMPUTER;packet size=4096;data source=MISSQL.mccombs.utexas.edu;integrated security=False;initial catalog=mis333k_msbcn308;user id=msbcn308;password=ZHHiOmZhe0E9"


    '*************Calls and Updates***********
    'define a public readonly property for the outside world to access the database filled by this class
    Public ReadOnly Property CustDataset() As DataSet
        Get
            'return dataset to user
            Return mDatasetCustomers
        End Get
    End Property

    Public ReadOnly Property CusView() As DataView
        Get
            Return myView
        End Get
    End Property

    Public Sub GetAllCustomers()
        Dim strQuery As String
        strQuery = "select * from tblClients ORDER BY LastName"
        SelectQuery(strQuery)

    End Sub

    Public Sub SelectQuery(ByVal strQuery As String)
        'Purpose: run any select query and fill dataset
        'Arguments: none
        'Returns: none
        'Author: Jee-Ho Kang
        'Date: 10/10/14
        Try
            'define data connection and adapter
            mdbConn = New SqlConnection(mstrConnection)
            mdbDataAdapter = New SqlDataAdapter(strQuery, mdbConn)
            'open the connection and dataset
            mdbConn.Open()
            'clear the dataset before filling
            mDatasetCustomers.Clear()
            'fill the dataset
            mdbDataAdapter.Fill(mDatasetCustomers, "tblClients")
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & " error is " & ex.Message)
        End Try
    End Sub

    Public Sub RunProcedure(ByVal strName As String)
        'CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)
        'Tell SQL server the naem of the stored procedure you will be executing
        Dim mdbDataAdapter As New SqlDataAdapter(strName, objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            mdbDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            ' clear dataset
            Me.mDatasetCustomers.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetCustomers, "tblClients")
            'copy dataset to dataview
            myView.Table = mDatasetCustomers.Tables("tblClients")
        Catch ex As Exception
            Throw New Exception("stored procedure is " & strName.ToString & " error is " & ex.Message)
        End Try
    End Sub

    Public Sub RunSPWithOneParam(ByVal strSPName As String, ByVal strParamName As String, ByVal strParamValue As String)
        'CREATES INSTANCES OF THE CONNECTION AND COMMAND OBJECT
        Dim objConnection As New SqlConnection(mstrConnection)
        'Tell SQL server the naem of the stored procedure you will be executing
        Dim objCommand As New SqlDataAdapter(strSPName, objConnection)
        Try
            ' SETS THE COMMAND TYPE TO "STORED PROCEDURE"
            objCommand.SelectCommand.CommandType = CommandType.StoredProcedure

            ' ADD PARAMETERS TO SPROC
            objCommand.SelectCommand.Parameters.Add(New SqlParameter(strParamName, strParamValue))
            ' clear dataset
            Me.mDatasetCustomers.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            objCommand.Fill(mDatasetCustomers, "tblClients")
            'copy dataset to dataview
            CusView.Table = mDatasetCustomers.Tables("tblClients")
        Catch ex As Exception
            Throw New Exception("params are " & strSPName.ToString & " " & strParamName.ToString & " " & strParamValue.ToString _
                                & " error is " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateDB(strQuery As String)
        'purpose: Rerun given query to update database
        'argument: String (any SQL statement)
        'return: Nothing
        'author: Jee-Ho Kang

        Try
            ' define data connection and data command
            mdbConn = New SqlConnection(mstrConnection)
            dbCommand = New SqlCommand(strQuery, mdbConn)

            ' open the connection and dataset 
            mdbConn.Open()

            ' clear the dataset before filling
            mDatasetCustomers.Clear()

            'run query
            dbCommand.ExecuteNonQuery()

            ' close the connection
            mdbConn.Close()

        Catch ex As Exception
            Throw New Exception("query is " & strQuery.ToString & "error is " & ex.Message)
        End Try

    End Sub


    '*************Procedures***********
    Public Sub ProcGetAllCustomers()
        'Purpose: run a query for all employees
        'Arguments: none
        'Returns: none
        'Author: Jee-Ho Kang
        'Date: 10/2/14

        RunProcedure("usp_Clients_Get_All")
    End Sub

    Public Function CheckEmail(strEmail As String) As Boolean
        'Purpose: Check Email to match database
        'author: Jee-Ho Kang
        'input:   string
        'returns: true or false
        mstrQuery = "select * from tblCustomers where EmailAddr='" & strEmail & "'"
        SelectQuery(mstrQuery)

        'check to see how many rows returned 
        If mDatasetCustomers.Tables("tblCustomers").Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CheckPassword(strPassword As String) As Boolean
        'purpose: test the password see if it matches the database password
        'author: Jee-Ho Kang

        'DO NOT RUN A QUERY
        'compare the password on the form to the passord in row zero of the dataset
        'if it matches, return True
        'if it doesn't, return False
        If strPassword = mDatasetCustomers.Tables("tblCustomers").Rows(0).Item("Password").ToString() Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub AddCustomer(strClientID As String, strFirstName As String, strMI As String, strLastName As String, strPassword As String, strAddress As String, strZipCode As String, strEmail As String, strPhone As String, strDOB As String)
        'purpose: add customer profiles to database
        'author: Jee-Ho Kang

        mstrQuery = "INSERT INTO tblClients (ClientID, FirstName, MI, LastName, Password, Address, ZipCode, Email, Phone, DOB) VALUES (" & _
       "'" & strClientID & "', " & _
       "'" & strFirstName & "', " & _
       "'" & strMI & "', " & _
       "'" & strLastName & "', " & _
       "'" & strPassword & "', " & _
       "'" & strAddress & "', " & _
       "'" & strZipCode & "', " & _
       "'" & strEmail & "', " & _
       "'" & strPhone & "', " & _
       "'" & strDOB & "')"

        UpdateDB(mstrQuery)
    End Sub


    '*************Sorts***********
    Public Sub DoSort(ByVal strSortValue As String)
        'Purpose: sorts the view by name, product
        'Arguments: none
        'Returns: none
        'Author: Jee-Ho Kang
        'Date: 10/20/14
        If strSortValue = "0" Then
            CusView.Sort = "LastName"
        Else
            CusView.Sort = "FirstName"
        End If
    End Sub

    '*************Searches***********

End Class
