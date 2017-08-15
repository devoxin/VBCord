Imports System.Net
Imports System.Text.RegularExpressions
Imports Discord

Module ApplicationF

    Private MentionRX As Regex = New Regex("<@!?\d+>")

    Public Sub CheckForUpdates()

        Try
            Dim version As String = New WebClient().DownloadString(New Uri("https://raw.githubusercontent.com/Devoxin/VBCord/master/version.txt"))
            If version > My.Settings.version Then
                If MsgBox($"Version {version} is available. Open the GitHub Repository?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Process.Start("https://github.com/Devoxin/VBCord/")
                End If
            End If
        Catch
            MsgBox("Failed to retrieve update information", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Public Function ResolveUserMentions(ByVal msg As WebSocket.SocketMessage)

        Dim content As String = msg.Content
        Dim mentions = msg.MentionedUsers

        For Each m In mentions
            content = MentionRX.Replace(content, $"@{m.Username}")
        Next

        Return content

    End Function

    Public Function ResolveTime(ByVal time As DateTimeOffset)
        Dim localTime = time.ToLocalTime()

        Dim timestring As String = ""

        If localTime.Date = Date.Today.Date Then
            timestring += "Today at "
        Else
            timestring += localTime.Date
        End If

        timestring += $"{localTime.Hour}:{localTime.Minute}"

        Return timestring

    End Function

End Module
