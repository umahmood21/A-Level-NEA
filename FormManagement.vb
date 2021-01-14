Module FormManagement


    ' Function to switch from frmMain => frmStudent or reverse depending on numerical value provided.
    Public Function form_switch(mode) As Boolean
        Select Case mode
            Case 0
                Try
                    frmMain.Hide()
                    frmStudent.ShowDialog()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("[0] An error has occured whilst trying to manage forms: " & ex.Message)
                    Return False
                End Try
            Case 1
                Try
                    frmStudent.Dispose()
                    frmStudent.Close()
                    frmMain.ShowDialog()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("[1] An error has occured whilst trying to manage forms: " & ex.Message)
                    Return False
                End Try
            Case 2
                Try
                    frmMain.Hide()
                    frmCourse.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show("[2] An error has occured whilst trying to manage forms: " & ex.Message)
                    Return False
                End Try
            Case Else
                MessageBox.Show("You did not supply either 0 or 1 in function call.")
        End Select

        Return False
    End Function

End Module