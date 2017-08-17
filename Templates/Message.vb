Public Class Message

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Main.MessageInput.Text += " <@" & Label1.Tag & "> "
        Main.MessageInput.Focus()
        SendKeys.Send("{END}")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Tag)
    End Sub

    Private Sub Timestamp_TextChanged(sender As Object, e As EventArgs) Handles Timestamp.TextChanged
        EditedIcon.Left = (Timestamp.Location.X + Timestamp.Width)
    End Sub

End Class
