Option Explicit On
#Disable Warning BC42105 'Functions don't return. Doesn't really matter as they don't need to here.
#Disable Warning BC42358 'Awaitable functions aren't awaited (Ignore warning from 'UpdateLatency())'

Imports Discord
Imports Discord.WebSocket

Public Class Main
    Private version As String = "1.0.8"

    Public WithEvents Discord As DiscordSocketClient = New DiscordSocketClient(New DiscordSocketConfig With {
                                                                               .WebSocketProvider = Net.Providers.WS4Net.WS4NetProvider.Instance,
                                                                               .MessageCacheSize = 100
                                                                               })

    Dim focussedServer As ULong
    Dim focussedChannel As ULong
    Dim voiceConnection As Audio.IAudioClient

    Public LogDeletions As Boolean = True
    Public DisplayHidden As Boolean = True

    Private HelperThread As Threading.Thread

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginDialog As New Login
        If loginDialog.ShowDialog() = DialogResult.OK Then
            Try
                If loginDialog.tokenType = "Bot" Then
                    Await Discord.LoginAsync(TokenType.Bot, loginDialog.token)
                    Await Discord.StartAsync()
                Else
                    Await Discord.LoginAsync(TokenType.User, loginDialog.token)
                    Await Discord.StartAsync()
                End If
                Button2.Enabled = True
            Catch ex As Exception
                Console.WriteLine($"Failed to login{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
                MsgBox("An invalid token was specified, or an error occurred.")
            End Try
        End If
    End Sub

    Private Async Sub SwitchServer(ByVal sender As Object, e As EventArgs)
        Dim pb = DirectCast(sender, PictureBox)
        If pb.Tag = focussedServer Then
            Exit Sub
        End If

        focussedServer = pb.Tag
        focussedChannel = 0

        If HelperThread IsNot Nothing Then
            HelperThread.Abort()
            HelperThread = Nothing
        End If

        MessageContainer.Controls.Clear()
        TextChannels.Controls.Clear()
        VoiceChannels.Controls.Clear()
        MembersList.Controls.Clear()

        Dim server As IGuild = Discord.GetGuild(focussedServer)
        ServerName.Text = server.Name

        Dim txtChannels = Await server.GetTextChannelsAsync()
        Dim vcChannels = Await server.GetVoiceChannelsAsync()

        Dim _member = Await server.GetCurrentUserAsync(CacheMode.AllowDownload)

        If (Not DisplayHidden) Then
            txtChannels = txtChannels _
                .Where(Function(channel) _member.GetPermissions(channel).ReadMessages) _
                .OrderByDescending(Function(channel) channel.Position).ToList()
        Else
            txtChannels = txtChannels _
                .OrderByDescending(Function(channel) channel.Position).ToList()
        End If

        vcChannels = vcChannels _
            .OrderByDescending(Function(channel) channel.Position).ToList()

        For Each c As ITextChannel In txtChannels
            Dim btn As New ThemedButton With {
                .Dock = DockStyle.Top,
                .Height = 30,
                .Text = c.Name,
                .Tag = c.Id,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Padding = New Padding(TextChannels.Width * 0.05, 0, 0, 0)
            }
            AddHandler btn.Click, AddressOf SwitchChannel
            TextChannels.Controls.Add(btn)
        Next

        For Each c As IVoiceChannel In vcChannels
            Dim btn As New ThemedButton With {
                .Enabled = _member.GetPermissions(c).Connect,
                .Dock = DockStyle.Top,
                .Height = 30,
                .Text = c.Name,
                .Tag = c.Id,
                .TextAlign = ContentAlignment.MiddleLeft,
                .Padding = New Padding(VoiceChannels.Width * 0.05, 0, 0, 0)
            }
            AddHandler btn.Click, AddressOf JoinVoiceChannel
            VoiceChannels.Controls.Add(btn)
        Next

        If (Await server.GetUsersAsync()).Count <= 300 Then
            HelperThread = New Threading.Thread(Sub() ImportMembers(server))
            HelperThread.Start()
        End If

    End Sub

    Private Async Sub SwitchChannel(ByVal sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If focussedChannel = btn.Tag Then
            Exit Sub
        End If
        focussedChannel = btn.Tag

        Dim channel As ITextChannel = Discord.GetChannel(focussedChannel)
        ChannelName.Text = channel.Name
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

        If Not _member.GetPermissions(channel).AttachFiles Then
            AttachFile.Visible = False
        Else
            AttachFile.Visible = True
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
                    AddMessage(m.Author, ResolveRestMentions(m), attachment, m)
                    Refresh()
                    Application.DoEvents()
                Catch ex As Exception
                    Console.WriteLine($"Failed to append message to container{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
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
            Catch ex As Exception
                Console.WriteLine($"Failed to send message to channel{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
            End Try
            MessageInput.Clear()
        End If
    End Sub

    Private Async Sub JoinVoiceChannel(sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        Dim channel = Discord.GetGuild(focussedServer).GetVoiceChannel(btn.Tag)

        VoiceStatus.Text = "Voice Connecting"
        VoiceName.Text = ""
        LatencyImage.Image = Nothing
        VoicePanel.Visible = True

        If (voiceConnection IsNot Nothing) Then
            voiceConnection.Dispose()
        End If

        Try
            voiceConnection = Await channel.ConnectAsync()
        Finally
            If voiceConnection.ConnectionState = ConnectionState.Connected Then
                VoiceStatus.Text = "Voice Connected"
                VoiceName.Text = channel.Name
                AddHandler voiceConnection.LatencyUpdated, AddressOf UpdateLatency
                UpdateLatency()
            Else
                VoiceStatus.Text = "Voice Disconnected"
                VoiceName.Text = channel.Name
                LatencyImage.Image = Nothing
            End If
        End Try
    End Sub

#Region "Client Events"

    Private Function OnReady() As Task Handles Discord.Ready

        Invoke(DirectCast(Sub()
                              Username.Text = Discord.CurrentUser.Username
                              UserAvatar.ImageLocation = Discord.CurrentUser.GetAvatarUrl
                              UserDiscrim.Text = $"#{Discord.CurrentUser.Discriminator}"
                          End Sub, MethodInvoker))

        If Discord.Guilds.Count > 16 Then
            Invoke(DirectCast(Sub()
                                  Servers.Width = 79
                                  UtilPanel.Width += 17
                              End Sub, MethodInvoker))
        End If

        For Each g As SocketGuild In Discord.Guilds
            Dim pb As New PictureBox With {
                .Dock = DockStyle.Top,
                .Height = 62,
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Tag = g.Id,
                .ContextMenuStrip = ContextMenuStrip1
            }
            If g.IconUrl IsNot Nothing Then
                pb.ImageLocation = g.IconUrl.Replace("jpg", "png")
            Else
                pb.Image = My.Resources.NoServer
                pb.SizeMode = PictureBoxSizeMode.Zoom
            End If
            AddHandler pb.Click, AddressOf SwitchServer
            AddServer(pb)
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
    End Function

    Private Function MessageReceived(msg As SocketMessage) As Task Handles Discord.MessageReceived
        If focussedChannel = msg.Channel.Id Then
            Dim attachment = ""
            If msg.Attachments.FirstOrDefault IsNot Nothing AndAlso msg.Attachments.FirstOrDefault.Url IsNot Nothing Then
                attachment = msg.Attachments.FirstOrDefault.Url
            End If
            If attachment.Length = 0 AndAlso msg.Content.Length = 0 Then
                Exit Function
            End If
            MessageContainer.Invoke(DirectCast(Sub() AddMessage(msg.Author, ResolveMentions(msg), attachment, msg), MethodInvoker))
        End If
    End Function

    Private Function Discord_MessageDeleted(msg As Cacheable(Of IMessage, ULong), channel As ISocketMessageChannel) As Task Handles Discord.MessageDeleted
        If Not focussedChannel = channel.Id Or Not LogDeletions Then
            Exit Function
        End If

        For Each ctrl As Message In MessageContainer.Controls
            If ctrl.Tag = msg.Id Then
                ctrl.Invoke(DirectCast(Sub() ctrl.Dispose(), MethodInvoker))
                Exit For
            End If
        Next
    End Function

    Private Function Discord_MessageUpdated(msg As Cacheable(Of IMessage, ULong), sMsg As SocketMessage, channel As ISocketMessageChannel) As Task Handles Discord.MessageUpdated
        If Not focussedChannel = channel.Id Then
            Exit Function
        End If

        For Each ctrl As Message In MessageContainer.Controls
            If ctrl.Tag = msg.Id Then
                ctrl.Invoke(DirectCast(Sub()
                                           ctrl.Label2.Text = ResolveMentions(sMsg)
                                           ctrl.EditedIcon.Visible = True
                                       End Sub, MethodInvoker))
                Exit For
            End If
        Next
    End Function

#End Region

#Region "Interface Management"

    Private Sub AddServer(ByVal server As PictureBox)
        Servers.Invoke(DirectCast(Sub() Servers.Controls.Add(server), MethodInvoker))
    End Sub

    Private Sub AddChannel(ByVal channel As Button)
        TextChannels.Invoke(DirectCast(Sub() TextChannels.Controls.Add(channel), MethodInvoker))
    End Sub

    Private Sub AddMessage(ByVal mUser As IUser, mText As String, mAttachment As String, m As IMessage)
        Dim container As New Message With {
            .Dock = DockStyle.Bottom,
            .Tag = m.Id
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

    Private Async Sub ImportMembers(ByVal g As IGuild)
        Dim members = Await g.GetUsersAsync(CacheMode.CacheOnly)
        Dim roles = g.Roles() _
            .Where(Function(role) (role.Position = 0 Or role.IsHoisted) AndAlso DirectCast(role, SocketRole).Members.Count > 0) _
            .OrderByDescending(Function(role) role.Position).ToList() ' @everyone role or custom

        Dim assigned As New List(Of ULong)

        For Each role In roles

            If DirectCast(role, SocketRole).Members.Where(Function(m) Not assigned.Contains(m.Id)).Count = 0 Then
                Continue For ' Ignore blank roles
            End If

            Dim rh As New RoleUserList
            With rh
                .RoleName.Text = role.Name
                .Dock = DockStyle.Top
            End With

            Try
                MembersList.Invoke(DirectCast(Sub() MembersList.Controls.Add(rh), MethodInvoker))
            Catch
                Exit Sub
            End Try

            For Each m As IGuildUser In DirectCast(role, SocketRole).Members.OrderBy(Function(mem) mem.Username)
                If assigned.Contains(m.Id) Then
                    Continue For
                End If

                assigned.Add(m.Id)
                Dim holder As New Member With {
                    .Dock = DockStyle.Bottom
                }
                holder.Avatar.ImageLocation = m.GetAvatarUrl()
                holder.Username.Text = DisplayName(m)
                holder.Username.ForeColor = GetRoleColour(m)
                holder.OnlineStatus.BackColor = GetStatusColour(m.Status)
                If m.Game.ToString().Length > 0 Then
                    holder.Playing.Text = "Playing " & m.Game.ToString()
                End If

                Try
                    rh.Invoke(DirectCast(Sub() rh.Controls.Add(holder), MethodInvoker))
                    rh.Invoke(DirectCast(Sub() rh.Height = (45 * rh.Controls.Count - 45) + 30, MethodInvoker))
                    Invoke(DirectCast(Sub() Refresh(), MethodInvoker))
                Catch ex As Exception
                    ' Do Nothing
                End Try
            Next
        Next
    End Sub

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

    Private Sub ChannelName_TextChanged(sender As Object, e As EventArgs) Handles ChannelName.TextChanged
        Using g As Graphics = ChannelName.CreateGraphics
            ChannelName.Width = g.MeasureString(ChannelName.Text, ChannelName.Font).Width + 10
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClientSettings.ShowDialog()
    End Sub

    Private Async Sub ThemedButton1_Click(sender As Object, e As EventArgs) Handles AttachFile.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "All Files|*.*",
            .Title = "Select File to Upload"
            }
        If ofd.ShowDialog = DialogResult.OK Then
            AttachmentPanel.Visible = True
            Try
                Await Discord.GetGuild(focussedServer).GetTextChannel(focussedChannel).SendFileAsync(ofd.FileName, MessageInput.Text, False)
                AttachmentPanel.Visible = False
            Catch ex As Exception
                Console.WriteLine($"Failed to send attachment to channel{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
                AttachmentStatus.Text = "Failed to send file"
                CloseAttachmentPanel.Visible = True
            End Try
            MessageInput.Clear()
        End If
    End Sub

    Private Sub ThemedButton2_Click(sender As Object, e As EventArgs) Handles CloseAttachmentPanel.Click
        AttachmentPanel.Visible = False
        CloseAttachmentPanel.Visible = False
        AttachmentStatus.Text = "File sending..."
    End Sub

    Private Sub CopyIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyIDToolStripMenuItem.Click
        Dim selected As PictureBox = DirectCast(ContextMenuStrip1.SourceControl, PictureBox)
        My.Computer.Clipboard.SetText(selected.Tag)
    End Sub

    Private Async Sub LeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveToolStripMenuItem.Click
        Dim selected As PictureBox = DirectCast(ContextMenuStrip1.SourceControl, PictureBox)
        Dim server As IGuild = Discord.GetGuild(selected.Tag)
        If server IsNot Nothing Then
            Await server.LeaveAsync()
        End If
        selected.Dispose()
    End Sub

    Private Async Sub ViewInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInfoToolStripMenuItem.Click
        Dim selected As PictureBox = DirectCast(ContextMenuStrip1.SourceControl, PictureBox)
        Dim server As IGuild = Discord.GetGuild(selected.Tag)
        If server Is Nothing Then
            selected.Dispose()
            MsgBox("Server not found")
            Exit Sub
        End If

        Dim owner As IGuildUser = Await server.GetOwnerAsync()
        Dim members = Await server.GetUsersAsync()

        Dim bots = members.Where(Function(member) member.IsBot).Count

        With New ServerOverview
            .ServerName.Text = $"{server.Name} ({server.Id})"
            .ServerIcon.ImageLocation = server.IconUrl
            .ServerOwner.Text = $"Owner: {owner.Username}#{owner.Discriminator} ({owner.Id})"
            .MemberInfo.Text = $"Bots: {bots} ({Math.Round(bots / members.Count * 100, 2)}%){vbNewLine}Total Members: {members.Count}"
            .ShowDialog()
        End With

    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim input = InputBox("Enter Server ID:")

        If Not ULong.TryParse(input, input) Then
            MsgBox("Unable to parse ID.")
            Exit Sub
        End If

        Dim server As IGuild = Discord.GetGuild(input)
        If server Is Nothing Then
            MsgBox("No servers found matching that ID")
        End If

        MsgBox(server.Name) ' TODO: Make this actually do something better
    End Sub

    Private Sub MembersList_ControlAdded(sender As Object, e As ControlEventArgs) Handles MembersList.ControlAdded
        e.Control.BringToFront()
    End Sub
End Class
