Imports System.Text.RegularExpressions
Imports Discord

Module Helpers

    Public Function ResolveMentions(ByVal msg As WebSocket.SocketMessage)

        Dim content As String = msg.Content

        For Each u In msg.MentionedUsers
            content = New Regex($"<@!?{u.Id}>").Replace(content, $"@{u.Username}")
        Next

        For Each c In msg.MentionedChannels
            content = New Regex($"<#{c.Id}>").Replace(content, $"#{c.Name}")
        Next

        Return content

    End Function

    Public Function ResolveRestMentions(ByVal msg As IMessage)

        Dim content As String = msg.Content

        For Each u In msg.MentionedUserIds
            Dim user = Main.Discord.GetUser(u)
            content = New Regex($"<@!?{u}>").Replace(content, $"@{IIf(user IsNot Nothing, user.Username, "Invalid-User")}")
        Next

        For Each c In msg.MentionedChannelIds
            Dim channel = Main.Discord.GetChannel(c)
            content = New Regex($"<#{c}>").Replace(content, $"#{IIf(channel IsNot Nothing, DirectCast(channel, IGuildChannel).Name, "Invalid-Channel")}")
        Next

        Return content

    End Function

    Public Function IsMentioned(ByVal m As IMessage)
        Return m.MentionedUserIds.Contains(Main.Discord.CurrentUser.Id)
    End Function

    Public Function DisplayName(ByVal m As IGuildUser)
        If m.Nickname IsNot Nothing Then
            Return m.Nickname
        Else
            Return m.Username
        End If
    End Function

    Public Function GetRoleColour(ByVal m As IGuildUser)

        Dim roles As New List(Of IRole)

        For Each role In m.RoleIds
            roles.Add(m.Guild.GetRole(role))
        Next

        roles = roles _
            .Where(Function(role) Not role.Color.RawValue = 0) _
            .OrderByDescending(Function(role) role.Position).ToList()

        If roles.Count = 0 Then
            Return Drawing.Color.White
        End If

        Return Drawing.Color.FromArgb(roles.First().Color.R, roles.First().Color.G, roles.First().Color.B)

    End Function

    Public Function GetStatusColour(ByVal status As UserStatus)
        Select Case status
            Case UserStatus.Online
                Return Drawing.Color.FromArgb(87, 206, 64)
            Case UserStatus.AFK
                Return Drawing.Color.FromArgb(255, 204, 0)
            Case UserStatus.Idle
                Return Drawing.Color.FromArgb(255, 204, 0)
            Case UserStatus.DoNotDisturb
                Return Drawing.Color.FromArgb(249, 42, 27)
            Case UserStatus.Offline
                Return Drawing.Color.FromArgb(112, 110, 109)
            Case Else
                Return Drawing.Color.FromArgb(112, 110, 109)
        End Select
    End Function

    Public Function ResolveTime(ByVal time As DateTimeOffset)

        Dim localTime = time.ToLocalTime()
        Dim timestring As String = ""

        If localTime.Date = Date.Today.Date Then
            timestring += "Today at "
        Else
            timestring += $"{localTime.Date.ToShortDateString()} at "
        End If

        timestring += localTime.DateTime.ToString("HH:mm")

        Return timestring

    End Function

End Module
