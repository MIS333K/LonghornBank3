
'Author: Jee-Ho Kang
'Assignment: Longhorn Bank 
'Date: 11/26/14
'Program Description: accesses tblCustomers, and runs queries to fill in tables

Option Strict On
Imports System.Data
Imports System.Data.SqlClient

Public Class ClassAccountsDB

    'module level variables are internal to object
    Dim myView As New DataView
    Dim mDatasetAccounts As New DataSet
    Dim mstrQuery As String
    Dim mdbDataAdapter As New SqlDataAdapter
    Dim mdbConn As SqlConnection
    Dim dbCommand As New SqlCommand
    Dim mstrConnection As String = "workstation id=COMPUTER;packet size=4096;data source=MISSQL.mccombs.utexas.edu;integrated security=False;initial catalog=mis333k_msbcn308;user id=msbcn308;password=ZHHiOmZhe0E9"


    '*************Calls and Updates***********
    'define a public readonly property for the outside world to access the database filled by this class
    Public ReadOnly Property AccDataset() As DataSet
        Get
            'return dataset to user
            Return mDatasetAccounts
        End Get
    End Property

    Public ReadOnly Property AccView() As DataView
        Get
            Return myView
        End Get
    End Property

    Public Sub GetAllAccounts()
        Dim strQuery As String
        strQuery = "select * from tblAccount ORDER BY AccountID"
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
            mDatasetAccounts.Clear()
            'fill the dataset
            mdbDataAdapter.Fill(mDatasetAccounts, "tblAccount")
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
            Me.mDatasetAccounts.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            mdbDataAdapter.Fill(mDatasetAccounts, "tblAccount")
            'copy dataset to dataview
            myView.Table = mDatasetAccounts.Tables("tblAccount")
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
            Me.mDatasetAccounts.Clear()
            ' OPEN CONNECTION AND FILL DATASET
            objCommand.Fill(mDatasetAccounts, "tblAccount")
            'copy dataset to dataview
            AccView.Table = mDatasetAccounts.Tables("tblAccount")
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
            mDatasetAccounts.Clear()

            'run query
            dbCommand.ExecuteNonQuery()

            ' close the connection
            mdbConn.Close()

        Catch ex As Exception
            Throw New Exception("query is " & strQuery.ToString & "error is " & ex.Message)
        End Try

    End Sub

    '*******Need to find a way to see the number of specific accounts (IRAID, Stock Portfolio) per Account ID number
End Class
