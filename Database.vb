Imports System.Data.OleDb

' Module which will be used to connect to the database.
Module ModMain
    Public Const DataBasePath As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Usman Mahmood\Documents\collegeSystem.mdb';Persist Security Info=False"
    Public cn As OleDbConnection

    Public Function DbConnect() As Boolean
        Try
            cn = New OleDbConnection(DataBasePath)
            cn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show("Unable to open the database: " & ex.Message)
            Return False
        End Try
    End Function
End Module
