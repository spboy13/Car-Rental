Public Class fillupForm

    Private Sub Fill_Up_FormBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fill_Up_FormBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Fill_Up_FormBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet1)

    End Sub

    Private Sub fillupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Fill_Up_Form' table. You can move, or remove it, as needed.
        Me.Fill_Up_FormTableAdapter.Fill(Me.Database1DataSet1.Fill_Up_Form)

    End Sub

    Private Sub License_IDTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles License_IDTextBox.KeyPress
        Dim allowedKeys = "0987654321" & vbBack
        e.Handled = Not allowedKeys.Contains(e.KeyChar)
    End Sub

    Private Sub Contact__TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Contact__TextBox.KeyPress
        Dim allowedKeys = "0987654321" & vbBack
        e.Handled = Not allowedKeys.Contains(e.KeyChar)
    End Sub

    Private Sub Vehicle_Reg___TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Vehicle_Reg___TextBox.KeyPress
        Dim allowedKeys = "0987654321" & vbBack
        e.Handled = Not allowedKeys.Contains(e.KeyChar)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Vehicle_modelTextBox.Text = ComboBox1.Text

        If ComboBox1.Text = "Mitsubishi Mirage" Then
            Rental_Fee_per_DayTextBox.Text = "2500"
            Me.BackgroundImage = Image.FromFile("C:\Users\ARTHUR E BETEZ\Desktop\prac_4\mirage.jpg")
        ElseIf ComboBox1.Text = "Toyota Vios" Then
            Rental_Fee_per_DayTextBox.Text = "2400"
            Me.BackgroundImage = Image.FromFile("C:\Users\ARTHUR E BETEZ\Desktop\prac_4\vios.jpg")
        ElseIf ComboBox1.Text = "Toyota Innova" Then
            Rental_Fee_per_DayTextBox.Text = "3000"
            Me.BackgroundImage = Image.FromFile("C:\Users\ARTHUR E BETEZ\Desktop\prac_4\innova.jpg")
        Else
            Me.BackgroundImage = Image.FromFile("C:\Users\ARTHUR E BETEZ\Desktop\prac_4\fillup.jpg")
        End If
    End Sub

    Private Sub Vehicle_modelTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vehicle_modelTextBox.TextChanged
        ComboBox1.Text = Vehicle_modelTextBox.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim date1 As Date = Convert.ToDateTime(Collect_DateDateTimePicker.Value)
        Dim date2 As Date = Convert.ToDateTime(Return_DateDateTimePicker.Value)
        Dim difference As TimeSpan = date2.Subtract(date1)

        No__of_DaysTextBox.Text = FormatNumber(difference.TotalDays, 0)
        Rental_AmountTextBox.Text = "P " & Val(Rental_Fee_per_DayTextBox.Text) * Val(No__of_DaysTextBox.Text)

        If Val(No__of_DaysTextBox.Text) < 0 Then
            MsgBox("error: return date earlier than collect date")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NameTextBox.Text = "" Or AddressTextBox.Text = "" Or License_IDTextBox.Text = "" Or Contact__TextBox.Text = "" Or Vehicle_modelTextBox.Text = "" Or Vehicle_Reg___TextBox.Text = "" Then
            MsgBox("please fill up everything")
        ElseIf Val(No__of_DaysTextBox.Text) < 0 Then
            MsgBox("error: return date earlier than collect date")
        Else
            Me.Hide()
            receiptForm.Show()
        End If
    End Sub

    
End Class