Imports System.Data.OleDb

Module FormManagement


    ' Function to switch from frmMain => frmStudent or reverse depending on numerical value provided.
    Public Sub form_switch(mode)
        Select Case mode
            Case 0
                Try
                    frmMain.Hide()
                    frmStudent.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show("[0] An error has occured whilst trying to manage forms: " & ex.Message)
                End Try
            Case 1
                Try
                    frmStudent.Dispose()
                    frmStudent.Close()
                    frmMain.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show("[1] An error has occured whilst trying to manage forms: " & ex.Message)
                End Try
            Case 2
                Try
                    frmMain.Hide()
                    frmCourse.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show("[2] An error has occured whilst trying to manage forms: " & ex.Message)
                End Try
            Case 3
                Try
                    frmStudent.txtSearchID.Clear()
                    frmStudent.txtSearchID.Focus()
                Catch ex As Exception
                    MessageBox.Show("[3] An error has occured whilst trying to manage forms: " & ex.Message)
                End Try
            Case Else
                MessageBox.Show("You did not supply either 0, 1 or 2 in function call.")
        End Select
    End Sub

    Public Function is_valid_student(surname, firstname, dob, postocde) As Boolean
        If surname = "" Or firstname = "" Or IsNothing(dob) Or postocde = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function is_valid_course(name, head) As Boolean
        If name = "" Or head = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub DisplayStudent(id)
        If DbConnect() Then
            Dim sql As New OleDbCommand
            sql.Connection = cn
            sql.CommandText = "SELECT * From Student Where StudentID = @SearchID"
            sql.Parameters.AddWithValue("@SearchID", id)
            Dim rs As OleDbDataReader = sql.ExecuteReader()

            If rs.Read Then
                frmStudent.CurrentStudentID = id
                frmStudent.lblStudentID.Text = rs("StudentID")
                frmStudent.txtSurname.Text = rs("Surname")
                frmStudent.txtFirstName.Text = rs("FirstNames")
                frmStudent.DatDOB.Value = rs("DateOfBirth")
                frmStudent.txtPostCode.Text = rs("PostCode")
            Else
                MessageBox.Show("Unable to find a student with ID " & id, "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            rs.Close()
            cn.Close()
        End If
    End Sub
End Module