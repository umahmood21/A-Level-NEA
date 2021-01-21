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

End Module