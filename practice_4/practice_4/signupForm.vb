Public Class signupForm

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password2.PasswordChar = ""
        Else
            password2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        SplashScreen1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If username2.Text = "" Or password2.Text = "" Then
            MsgBox("please fill up everything")
        Else
            MsgBox("sign up successful")
            Me.Hide()
            SplashScreen1.Show()
        End If
    End Sub

    Private Sub signupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username2.Text = ""
        password2.Text = ""
    End Sub
End Class