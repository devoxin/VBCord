﻿Imports System.Net
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
