Imports System.Data.OleDb
Public Class frmCourse
    Public CurrentCourseID As Integer = -1

    Private Sub butNew_Click(sender As Object, e As EventArgs) Handles butNew.Click
        CurrentCourseID = -1
        txtCourse.Text = ""
        txtHead.Text = ""
    End Sub

    Private Sub butSave_Click(sender As Object, e As EventArgs) Handles butSave.Click
        If is_valid_course(txtCourse.Text, txtHead.Text) Then
            If DbConnect() Then
                Dim sql As New OleDbCommand
                If CurrentCourseID = -1 Then
                    sql.Connection = cn
                    sql.CommandText = "Insert into Course (CourseTitle, HeadOfDepartment) " & "Values (@Title, @Head)"
                    sql.Parameters.AddWithValue("@Title", txtCourse.Text)
                    sql.Parameters.AddWithValue("@Head", txtHead.Text)
                    sql.ExecuteNonQuery()

                    sql.CommandText = "Select @@Identity"
                    CurrentCourseID = sql.ExecuteScalar
                    lblCourseID.Text = CurrentCourseID
                End If
            End If
        Else
            MessageBox.Show("Please make sure all fields are filled before continuing.")
        End If
    End Sub
End Class