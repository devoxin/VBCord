Public Class Login

    Public token As String

    Private Sub ThemedButton3_Click(sender As Object, e As EventArgs) Handles ThemedButton3.Click
        DialogResult = DialogResult.Cancel
        Application.Exit()
    End Sub

    Private Sub ThemedButton1_Click(sender As Object, e As EventArgs) Handles ThemedButton1.Click
        token = TextBox1.Text
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            ThemedButton1.PerformClick()
        End If
    End Sub
End Class