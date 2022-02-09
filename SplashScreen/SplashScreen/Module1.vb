Imports System
Imports System.Data.OleDb
Imports System.IO
Module Module1
    Public connectionString As String
    Public cc As New OleDbConnection
    Public cmd As New OleDbCommand
    Public connectionStrings As String
    Public cons As New OleDbConnection
    Public cmds As New OleDbCommand
    Public dataBaseName As String
    Public dataBaseNames As String
    Public rs As OleDbDataReader

    'Declaring connect Function For connect To Database
    Function Connect()
        dataBaseName = "F:\Msms1.mdb "
        If cc.State = ConnectionState.Open Then cc.Close()
        connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + dataBaseName + ";"
        cc.ConnectionString = connectionString
        'cc.Open()
        'objcommand.ExecuteNonQuery()
        cmd.Connection = cc
        cc.Close()
        cmd.Cancel()
        Return 0
    End Function
End Module
