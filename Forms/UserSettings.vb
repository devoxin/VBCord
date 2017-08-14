Imports SelfUserEditor.Editor

Public Class UserSettings

    Private Async Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not (ComboBox1.SelectedIndex + 1) = Main.Discord.CurrentUser.Status Then
            Await Main.Discord.SetStatusAsync(ComboBox1.SelectedIndex + 1)
        End If
    End Sub

    Private Sub UserSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.SelectedIndex = Main.Discord.CurrentUser.Status
        CircularPictureBox1.ImageLocation = Main.Discord.CurrentUser.GetAvatarUrl()
    End Sub

    Private Async Sub ThemedButton1_Click(sender As Object, e As EventArgs) Handles ThemedButton1.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "PNG|*.png",
            .Title = "Select Avatar"
            }

        If ofd.ShowDialog = DialogResult.OK Then
            Dim res As Boolean = Await EditUser(Main.Discord.CurrentUser, ofd.FileName, Nothing)
            If (res) Then
                CircularPictureBox1.ImageLocation = Main.Discord.CurrentUser.GetAvatarUrl()
                Main.UserAvatar.ImageLocation = Main.Discord.CurrentUser.GetAvatarUrl()
                Application.DoEvents()
            End If
        End If
    End Sub

    Private Async Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim res As Boolean = Await EditUser(Main.Discord.CurrentUser, Nothing, TextBox1.Text)
            If (res) Then
                Main.Username.Text = Main.Discord.CurrentUser.Username
                Main.UserDiscrim.Text = Main.Discord.CurrentUser.Discriminator
                Application.DoEvents()
            End If
        End If
    End Sub
End Class