Option Explicit On
#Disable Warning BC42105 'Functions don't return. Doesn't really matter as they don't need to here.

Imports Discord
Imports Discord.WebSocket

Public Class Main
    Public WithEvents Discord As DiscordSocketClient = New DiscordSocketClient(New DiscordSocketConfig With {
                                                                               .WebSocketProvider = Net.Providers.WS4Net.WS4NetProvider.Instance,
                                                                               .MessageCacheSize = 100
                                                                               })

    Dim focussedServer As ULong
    Dim focussedChannel As ULong
    Dim voiceConnection As Audio.IAudioClient

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForUpdates()
        CheckForIllegalCrossThreadCalls = False ' This is temporary... pls don't hurt me

        Dim loginDialog As New Login
        If loginDialog.ShowDialog() = DialogResult.OK Then
            Try
                If loginDialog.tokenType = "Bot" Then
                    Await Discord.LoginAsync(TokenType.Bot, loginDialog.token)
                    Await Discord.StartAsync()
                Else
                    ' TODO: Add user-login support
                End If
            Catch ex As Exception
                Console.WriteLine($"{ex.Message}{vbNewLine}{ex.StackTrace}")
                MsgBox("An invalid token was specified, or an error occurred.")
            End Try
        End If
    End Sub

    Private Async Sub SwitchServer(ByVal sender As Object, e As EventArgs)
        Dim pb = DirectCast(sender, PictureBox)
        Dim id As ULong = pb.Tag
        focussedServer = id
        focussedChannel = 0
        MessageContainer.Controls.Clear()

        TextChannels.Controls.Clear()
        VoiceChannels.Controls.Clear()

        Dim server As IGuild = Discord.GetGuild(id)
        Dim txtChannels = Await server.GetTextChannelsAsync()
        Dim vcChannels = Await server.GetVoiceChannelsAsync()

        txtChannels = txtChannels.OrderByDescending(Function(channel) channel.Position).ToList()
        vcChannels = vcChannels.OrderByDescending(Function(channel) channel.Position).ToList()

        ServerName.Text = server.Name

        For Each c As ITextChannel In txtChannels
            Dim btn As New ThemedButton
            With btn
                .Dock = DockStyle.Top
                .Height = 30
                .Text = c.Name
                .Tag = c.Id
            End With
            AddHandler btn.Click, AddressOf SwitchChannel
            TextChannels.Controls.Add(btn)
        Next

        For Each c As IVoiceChannel In vcChannels
            Dim btn As New ThemedButton
            With btn
                .Dock = DockStyle.Top
                .Height = 30
                .Text = c.Name
                .Tag = c.Id
            End With
            AddHandler btn.Click, AddressOf JoinVoiceChannel
            VoiceChannels.Controls.Add(btn)
        Next
    End Sub

    Private Async Sub SwitchChannel(ByVal sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If focussedChannel = btn.Tag Then
            Exit Sub
        End If
        focussedChannel = btn.Tag

        Dim channel As ITextChannel = Discord.GetChannel(focussedChannel)
        ChannelTopic.Text = channel.Topic

        Dim _member = Await channel.Guild.GetCurrentUserAsync(CacheMode.AllowDownload)
        If Not _member.GetPermissions(channel).SendMessages Then
            MessageInput.Enabled = False
            MessageInput.Text = "You cannot send messages to this channel."
            MessageInput.ForeColor = Drawing.Color.White

        Else
            MessageInput.Enabled = True
            MessageInput.Clear()
        End If

        MessageContainer.Controls.Clear()

        Try
            Dim msgs = Await channel.GetMessagesAsync(50, CacheMode.AllowDownload).Flatten()
            msgs = msgs.Reverse()

            For Each m In msgs
                Try
                    Dim attachment = Nothing
                    If (m.Attachments.Count > 0) Then
                        If Not m.Attachments(0).Url = Nothing Then
                            attachment = m.Attachments(0).Url
                        End If
                    End If
                    AddMessage(m.Author, m.Content, attachment, m)
                    Refresh()
                    Application.DoEvents()
                Catch ex As Exception
                    Console.WriteLine(ex.Message + vbNewLine + ex.StackTrace)
                End Try
            Next
        Catch
        End Try
    End Sub

    Private Async Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MessageInput.KeyDown
        If e.KeyValue = Keys.Enter AndAlso Not MessageInput.Text = "" Then
            e.SuppressKeyPress = True
            Try
                Await Discord.GetGuild(focussedServer).GetTextChannel(focussedChannel).SendMessageAsync(MessageInput.Text)
            Catch
            End Try
            MessageInput.Clear()
        End If
    End Sub

    Private Function MessageReceived(msg As SocketMessage) As Task Handles Discord.MessageReceived
        If focussedChannel = msg.Channel.Id Then
            Dim attachment = ""
            If msg.Attachments.FirstOrDefault IsNot Nothing AndAlso msg.Attachments.FirstOrDefault.Url IsNot Nothing Then
                attachment = msg.Attachments.FirstOrDefault.Url
            End If
            MessageContainer.Invoke(New addMessageCallback(AddressOf AddMessage), New Object() {msg.Author, ResolveMentions(msg), attachment, msg})
        End If
    End Function

    Delegate Sub addMessageCallback(ByVal mUser, mText, mAttachment, m)

    Private Sub AddMessage(ByVal mUser As IUser, mText As String, mAttachment As String, m As IMessage)
        Dim container As New Message With {
            .Dock = DockStyle.Bottom
        }

        If IsMentioned(m) Then
            container.BackColor = Drawing.Color.FromArgb(75, 75, 75)
        End If

        container.Label1.Text = mUser.Username
        container.Label1.Tag = mUser.Id
        container.Label2.Text = mText
        container.Timestamp.Text = ResolveTime(m.Timestamp)
        container.PictureBox1.ImageLocation = mUser.GetAvatarUrl

        If m.Attachments.FirstOrDefault IsNot Nothing AndAlso m.Attachments.FirstOrDefault.Url IsNot Nothing Then
            container.LinkLabel1.Tag = m.Attachments.FirstOrDefault.Url
            container.LinkLabel1.Visible = True
        End If

        Using g = container.CreateGraphics
            container.Height = g.MeasureString(mText, container.Label2.Font).Height + 70
            container.LinkLabel1.Top = container.Label2.Location.Y + IIf(mText.Length = 0, 5, 20)
        End Using

        MessageContainer.Controls.Add(container)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Async Sub JoinVoiceChannel(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim channel = Discord.GetGuild(focussedServer).GetVoiceChannel(btn.Tag)
        If voiceConnection IsNot Nothing Then
            voiceConnection.Dispose()
        End If
        Try
            voiceConnection = Await channel.ConnectAsync()
            If voiceConnection.ConnectionState = ConnectionState.Connected Then
                VoiceStatus.Text = "Voice Connected"
                VoiceName.Text = channel.Name
                Await UpdateLatency()
                AddHandler voiceConnection.LatencyUpdated, AddressOf UpdateLatency
                VoicePanel.Visible = True
            Else
                VoiceStatus.Text = "Voice Disconnected"
                VoiceName.Text = channel.Name
                LatencyImage.Image = Nothing
                VoicePanel.Visible = False
            End If
        Catch
        End Try
    End Sub

#Region "Client Events"

    Private Function OnReady() As Task Handles Discord.Ready

        Username.Text = Discord.CurrentUser.Username
        UserAvatar.ImageLocation = Discord.CurrentUser.GetAvatarUrl
        UserDiscrim.Text = $"#{Discord.CurrentUser.Discriminator}"

        For i As Integer = 0 To Discord.Guilds.Count - 1 Step 1
            Dim pb As New PictureBox With {
                .Dock = DockStyle.Top,
                .Height = 62,
                .SizeMode = PictureBoxSizeMode.Zoom,
                .ImageLocation = Discord.Guilds(i).IconUrl,
                .Tag = Discord.Guilds(i).Id
            }
            AddHandler pb.Click, AddressOf SwitchServer
            Dim trd As New AddServerIconCallback(AddressOf AddServerIcon)
            Servers.Invoke(trd, New Object() {pb})
        Next

        For i As Integer = 0 To Discord.DMChannels.Count - 1 Step 1
            Dim btn As New ThemedButton
            With btn
                .Dock = DockStyle.Top
                .Height = 30
                .Text = Discord.DMChannels(i).Recipient.Username
                .TextAlign = ContentAlignment.MiddleLeft
                .Tag = Discord.DMChannels(i).Id
            End With
            AddHandler btn.Click, AddressOf SwitchChannel
            Dim trd As New AddChannelCallback(AddressOf AddChannel)
            TextChannels.Invoke(trd, New Object() {btn})
        Next
    End Function

    Private Function UpdateLatency() As Task
        Select Case voiceConnection.Latency
            Case Is <= 50
                LatencyImage.Image = My.Resources.SIGNAL_3
            Case Is <= 100
                LatencyImage.Image = My.Resources.SIGNAL_2
            Case Else
                LatencyImage.Image = My.Resources.SIGNAL_1
        End Select
        Return Task.FromResult(True)
    End Function

#End Region

#Region "Interface Management"

    Delegate Sub AddServerIconCallback(ByVal server As PictureBox)

    Private Sub AddServerIcon(ByVal server As PictureBox)
        Servers.Controls.Add(server)
    End Sub

    Delegate Sub AddChannelCallback(ByVal channel As Button)

    Private Sub AddChannel(ByVal channel As Button)
        TextChannels.Controls.Add(channel)
    End Sub

    Private Sub TextChannels_ControlAdded(sender As Object, e As ControlEventArgs) Handles TextChannels.ControlAdded, VoiceChannels.ControlAdded, TextChannels.ControlRemoved, VoiceChannels.ControlRemoved
        Dim panel As Panel = DirectCast(sender, Panel)
        If panel.Name = "VoiceChannels" Then
            panel.Height = (30 * panel.Controls.Count)
        Else
            panel.Height = (30 * (panel.Controls.Count + 1))
        End If
    End Sub

    Private Sub MessageContainer_ControlAdded(sender As Object, e As ControlEventArgs) Handles MessageContainer.ControlAdded
        MessageContainer.AutoScrollPosition = New Point(0, MessageContainer.VerticalScroll.Maximum)
    End Sub

#End Region

#Region "Helpers"

    Private Function IsMentioned(ByVal m As IMessage)
        Return m.MentionedUserIds.Contains(Discord.CurrentUser.Id)
    End Function

#End Region

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles Disconnect.Click
        Try
            voiceConnection.Dispose()
        Finally
            VoiceStatus.Text = "Voice Disconnected"
            VoiceName.Text = ""
            LatencyImage.Image = Nothing
            VoicePanel.Visible = False
        End Try
    End Sub

    Private Async Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Await Discord.StopAsync()
        Await Discord.LogoutAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserSettings.ShowDialog()
    End Sub
End Class
