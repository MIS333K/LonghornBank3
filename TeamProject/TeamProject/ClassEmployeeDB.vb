Imports System.Data
Imports System.Data.SqlClient

'author: Susie Kim
'date : 10/9/2014
'purpose: connect db to project




Public Class ClassEmployeeDB
    'these module variables are internal to object
    Dim mDatasetEmployee As New DataSet
    Dim mstrQuery As String
    Dim mdbDataAdapter As New SqlDataAdapter
    Dim mdbConn As SqlConnection
    Dim mstrConnection As String = "workstation id=COMPUTER;packet size=4096;data source=MISSQL.mccombs.utexas.edu;integrated security=False;initial catalog=mis333k_msbcn308;user id=msbcn308;password=ZHHiOmZhe0E9"
    'define a public read only property for the outside world to access the dataset filled by the class
    Public ReadOnly Property CustDataset() As DataSet
        Get
            'return dataset to user
            Return mDatasetEmployee
        End Get
    End Property




    'author: Susie Kim
    'date : 10/9/2014
    'purpose: run select query

    'define a public sub that will handle running any select query

    Public Sub SelectQuery(strQuery As String)
        'purpose: run any select query and fill dataset
        Try
            'define data connection and data adapter
            mdbConn = New SqlConnection(mstrConnection)
            mdbDataAdapter = New SqlDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear the dataset before filling
            mDatasetEmployee.Clear()

            'fill the dataset
            mdbDataAdapter.Fill(mDatasetEmployee, "tblemployee")

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Public Function CheckEmpID(strEmpID As String) As Boolean
        'purpose: to check username
        'inputs: none
        'outputs: none directly, but it opens and fills the dataset
        'with all the records in tblCustomers
        ' check username
        ' run a query with username
        mstrQuery = "select * from tblemployee where EmpID = '" & strEmpID & "'"
        SelectQuery(mstrQuery)
        ' check number of rows in dataset.
        If mDatasetEmployee.Tables("tblemployee").Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function


    Public Function CheckPassword(strPassword As String) As Boolean
        'author: Susie Kim
        'date : 9/25/2014
        'purpose: validate password with db
        'returns: true/false


        ' do not run a query here!
        'GetAllCustomers()
        'simple compare the password on the form to the password in row zero of the dataset

        If mDatasetEmployee.Tables("tblemployee").Rows(0).Item("password").ToString = strPassword Then
            'if it matches
            Return True
        Else
            Return False
        End If

    End Function


End Class
