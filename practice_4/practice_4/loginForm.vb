Public Class loginForm

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.PasswordChar = ""
        Else
            password.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        SplashScreen1.Show()

    End Sub

    Dim attempts As Integer = 3
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If username.Text = "admin" And password.Text = "admin" Or username.Text = signupForm.username2.Text And password.Text = signupForm.password2.Text Then
            Me.Close()
            fillupForm.Show()
        Else
            attempts = attempts - 1
            MsgBox("access denied! attempts left: " & attempts)

            username.Text = ""
            password.Text = ""

            If attempts = 0 Then
                MsgBox("maximum attempts reached")
                Me.Close()
                SplashScreen1.Show()
            End If
        End If
    End Sub

    Private Sub Button2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.DoubleClick
        If username.Text = "admin" And password.Text = "admin" Or username.Text = signupForm.username2.Text And password.Text = signupForm.password2.Text Then
            Me.Close()
            fillupForm.Show()
        Else
            attempts = attempts - 1
            MsgBox("access denied! attempts left: " & attempts)

            username.Text = ""
            password.Text = ""

            If attempts = 0 Then
                MsgBox("maximum attempts reached")
                Me.Close()
                SplashScreen1.Show()
            End If
        End If
    End Sub
End Class