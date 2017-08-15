Public Class Login

    Public token As String
    Public tokenType As String

    Private Sub ThemedButton3_Click(sender As Object, e As EventArgs) Handles ThemedButton3.Click
        Application.Exit()
    End Sub

    Private Sub ThemedButton1_Click(sender As Object, e As EventArgs) Handles ThemedButton1.Click
        token = TextBox1.Text
        tokenType = "Bot"
        DialogResult = DialogResult.OK
    End Sub

    Private Sub ThemedButton2_Click(sender As Object, e As EventArgs) Handles ThemedButton2.Click
        token = TextBox1.Text
        tokenType = "User"
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub
End Class