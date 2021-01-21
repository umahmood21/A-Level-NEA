Imports System.Data.OleDb

Public Class frmStudent
    Public CurrentStudentID As Integer = -1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form_switch(1)
    End Sub

    Private Sub butNew_Click(sender As Object, e As EventArgs) Handles butNew.Click
        CurrentStudentID = -1
        lblStudentID.Text = "Automatically generated."
        txtSurname.Text = ""
        txtFirstName.Text = ""
        txtPostCode.Text = ""
        DatDOB.Value = Now.AddYears(-18)
    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click
        If is_valid_student(txtSurname.Text, txtFirstName.Text, DatDOB.Value.Date, txtPostCode.Text) Then
            If DbConnect() Then
                Dim sql As New OleDbCommand
                If CurrentStudentID = -1 Then
                    sql.Connection = cn
                    sql.CommandText = "Insert into Student (Surname, FirstNames, DateOfBirth, PostCode) " & "Values (@Surname, @FirstNames, @DateOfBirth, @PostCode)"
                    sql.Parameters.AddWithValue("@Surname", txtSurname.Text)
                    sql.Parameters.AddWithValue("@FirstNames", txtFirstName.Text)
                    sql.Parameters.AddWithValue("@DateOfBirth", DatDOB.Value.Date)
                    sql.Parameters.AddWithValue("@PostCode", txtPostCode.Text)
                    sql.ExecuteNonQuery()

                    sql.CommandText = "Select @@Identity"
                    CurrentStudentID = sql.ExecuteScalar
                    lblStudentID.Text = CurrentStudentID
                End If
            End If
        Else
            MessageBox.Show("Please make sure all fields are filled before continuing.")
        End If

    End Sub
End Class