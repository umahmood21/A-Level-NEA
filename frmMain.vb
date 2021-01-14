Imports System.Data.OleDb

Public Class frmMain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DbConnect() Then
            Dim SQLCmd As New OleDbCommand
            SQLCmd.Connection = cn
            SQLCmd.CommandText = "INSERT into Student (Surname, FirstNames, DateOfBirth, PostCode)" & "Values (test, test2, test3, test4)"
            SQLCmd.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
