Public Class UserSettings

    Private Async Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not (ComboBox1.SelectedIndex + 1) = Main.Discord.CurrentUser.Status Then
            Await Main.Discord.SetStatusAsync(ComboBox1.SelectedIndex + 1)
        End If
    End Sub

    Private Sub UserSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.SelectedIndex = Main.Discord.CurrentUser.Status
        PictureBox1.ImageLocation = Main.Discord.CurrentUser.GetAvatarUrl()
    End Sub

End Class