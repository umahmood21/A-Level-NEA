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
                Else
                    'If the current student id isn't = to -1 this means that they're attempting to edit an existing user.
                    sql.Connection = cn
                    sql.CommandText = "Update Student " & "Set Surname = @Surname, " & "FirstNames = @FirstNames, " & "DateOfBirth = @DateOfBirth, " & "PostCode = @PostCode " &
                        "Where StudentID = @CurrentStudentID"
                    sql.Parameters.AddWithValue("@Surname", txtSurname.Text)
                    sql.Parameters.AddWithValue("@FirstNames", txtFirstName.Text)
                    sql.Parameters.AddWithValue("@DateOfBirth", DatDOB.Value)
                    sql.Parameters.AddWithValue("@PostCode", txtPostCode.Text)
                    sql.Parameters.AddWithValue("@CurrentStudentID", CurrentStudentID)
                    sql.ExecuteNonQuery()
                End If
                cn.Close()
            End If
        Else
            MessageBox.Show("Please make sure all fields are filled before continuing.")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form_switch(3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(txtSearchID.Text) Then
            DisplayStudent(txtSearchID.Text)
        Else
            MessageBox.Show("Numerical value not detected, try again.")
        End If
    End Sub
End Class