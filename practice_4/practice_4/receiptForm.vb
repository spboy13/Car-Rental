Public Class receiptForm

    Private Sub receiptForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = fillupForm.NameTextBox.Text
        TextBox2.Text = fillupForm.License_IDTextBox.Text
        TextBox3.Text = fillupForm.Vehicle_modelTextBox.Text
        TextBox4.Text = fillupForm.Rental_AmountTextBox.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        fillupForm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("than you for using Car Rental")
        End
    End Sub
End Class