Imports System.Text.RegularExpressions

Public Class Message

    Private LinkMatcher As Regex = New Regex("https?://(www.)?\S+\.\w{2,6}(/(\S+)?)?", RegexOptions.IgnoreCase)

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Main.MessageInput.Text += $" <@{Label1.Tag}> "
        Main.MessageInput.Focus()
        SendKeys.Send("{END}")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label2.LinkClicked
        Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub Timestamp_TextChanged(sender As Object, e As EventArgs) Handles Timestamp.TextChanged
        EditedIcon.Left = Timestamp.Location.X + Timestamp.Width
    End Sub

    Public Sub IdentifyLinks(ByVal text As String)
        Label2.Links.Clear()
        Dim matches As MatchCollection = LinkMatcher.Matches(text)

        For Each match As Match In matches
            Dim g = match.Groups(0)
            Label2.Links.Add(g.Index, g.Length, g.Value)
        Next
    End Sub
End Class
