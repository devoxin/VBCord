#Disable Warning BC42105 'Functions don't return. Doesn't really matter as they don't need to here.

Imports CrimsonCord.Logger
Imports Discord
Imports Discord.WebSocket

Public Class Main
    Private Logger As Logger = New Logger()

    Public WithEvents Discord As DiscordShardedClient = New DiscordShardedClient(
        New DiscordSocketConfig With {
        .MessageCacheSize = 100
        })

    Dim focussedServer As ULong
    Dim focussedChannel As ULong
    Dim voiceConnection As Audio.IAudioClient

    Public LogDeletions As Boolean = True
    Public DisplayHidden As Boolean = True

    Private HelperThread As Threading.Thread
    Private shouldShutdown = False

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginDialog As New Login
        If loginDialog.ShowDialog() = DialogResult.OK Then
            Try
                Await Discord.LoginAsync(TokenType.Bot, loginDialog.token)
                Await Discord.StartAsync()

                Logger.Log(LogLevel.INFO, $"Starting client with {Discord.Shards.Count} shards")
                Button2.Enabled = True
                shouldShutdown = True
            Catch ex As Exception
                Logger.Log(LogLevel.FATAL, $"Failed to login{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
                MsgBox("An invalid token was specified, or an error occurred.")
                Application.Exit()
            End Try
        End If
    End Sub

    Private Async Sub SwitchServer(ByVal sender As Object, e As EventArgs)
        Dim pb = DirectCast(sender, PictureBox)
        If CULng(pb.Tag) = focussedServer Then
            Exit Sub
        End If

        focussedServer = CULng(pb.Tag)
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
                .Where(Function(channel) _member.GetPermissions(channel).ViewChannel) _
                .OrderByDescending(Function(channel) channel.Position).ToList()
        Else
            txtChannels = txtChannels _
                .OrderByDescending(Function(channel) channel.Position).ToList()
        End If

        vcChannels = vcChannels _
            .OrderByDescending(Function(channel) channel.Position).ToList()

        TextChannels.SuspendLayout()
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
        TextChannels.ResumeLayout()

        VoiceChannels.SuspendLayout()
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
        VoiceChannels.ResumeLayout()

        If DirectCast(server.EveryoneRole, SocketRole).Members.Count <= 500 Then
            HelperThread = New Threading.Thread(Sub() ImportMembers(server))
            HelperThread.Start()
        End If

    End Sub

    Private Async Sub SwitchChannel(ByVal sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, Button)
        If focussedChannel = CULng(btn.Tag) Then
            Exit Sub
        End If
        focussedChannel = CULng(btn.Tag)

        Dim channel As ITextChannel = CType(Discord.GetChannel(focussedChannel), ITextChannel)
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
        MessageContainer.SuspendLayout()
        Try
            Dim msgs = Await channel.GetMessagesAsync(100, CacheMode.AllowDownload).FlattenAsync()
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
                Catch ex As Exception
                    Logger.Log(LogLevel.WARN, $"Failed to append message to container{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
                End Try
            Next
        Catch
        End Try
        MessageContainer.ResumeLayout()
        MessageContainer.VerticalScroll.Value = MessageContainer.VerticalScroll.Maximum
    End Sub

    Private Async Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MessageInput.KeyDown
        If e.KeyValue = Keys.Enter AndAlso Not MessageInput.Text = "" Then
            e.SuppressKeyPress = True
            Try
                Await Discord.GetGuild(focussedServer).GetTextChannel(focussedChannel).SendMessageAsync(MessageInput.Text)
            Catch ex As Exception
                Logger.Log(LogLevel.WARN, $"Failed to send message to channel{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
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
        Catch ex As TaskCanceledException
            ' REEEEEEEEEE
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

    Private Async Function OnReady(ByVal client As DiscordSocketClient) As Task Handles Discord.ShardConnected
        Logger.Log(LogLevel.INFO, $"Shard {client.ShardId}/{Discord.Shards.Count} ready")
        Await Task.Delay(2500)

        Dim readyShards = Discord.Shards.Where(
            Function(shard) shard.ConnectionState = ConnectionState.Connected
            ).Count

        If Not readyShards = Discord.Shards.Count Then
            Return 
        End If

        Invoke(DirectCast(Sub()
                              Username.Text = Discord.CurrentUser.Username
                              UserAvatar.ImageLocation = Discord.CurrentUser.GetAvatarUrl
                              UserDiscrim.Text = $"#{Discord.CurrentUser.Discriminator}"
                          End Sub, MethodInvoker))

        For Each g As SocketGuild In Discord.Guilds
            Dim pb As New CircularPictureBox With {
                    .Dock = DockStyle.Top,
                    .Height = 62,
                    .SizeMode = PictureBoxSizeMode.Zoom,
                    .Tag = g.Id,
                    .ContextMenuStrip = ContextMenuStrip1
                }
            If g.IconUrl IsNot Nothing Then
                pb.SetImage(g.IconUrl.Replace("jpg", "png"))
            Else
                pb.Image = My.Resources.NoServer
                pb.SizeMode = PictureBoxSizeMode.Zoom
            End If
            AddHandler pb.Click, AddressOf SwitchServer
            AddServer(pb)
        Next

        If Servers.VerticalScroll.Visible Then
            Invoke(DirectCast(Sub()
                                  Servers.Width = 79
                                  UtilPanel.Width += 17
                              End Sub, MethodInvoker))
        End If

    End Function

    Private Function UpdateLatency()
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

    Private Function Discord_MessageDeleted(msg As Cacheable(Of IMessage, ULong), channel As Cacheable(Of IMessageChannel, ULong)) As Task Handles Discord.MessageDeleted
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
                                           ctrl.IdentifyLinks(sMsg.Content)
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
        container.Timestamp.Text = CType(ResolveTime(m.Timestamp), String)
        container.PictureBox1.SetImage(mUser.GetAvatarUrl & "?size=512")

        If m.Attachments.FirstOrDefault IsNot Nothing AndAlso m.Attachments.FirstOrDefault.Url IsNot Nothing Then
            'container.LinkLabel1.Tag = m.Attachments.FirstOrDefault.Url
            'container.LinkLabel1.Visible = True
        End If

        Using g = container.CreateGraphics
            container.Height = CInt(g.MeasureString(mText, container.Label2.Font).Height + 50)
        End Using

        container.IdentifyLinks(mText)
        MessageContainer.Controls.Add(container)
    End Sub

    Private Sub TextChannels_ControlAdded(sender As Object, e As ControlEventArgs) Handles TextChannels.ControlAdded, VoiceChannels.ControlAdded, TextChannels.ControlRemoved, VoiceChannels.ControlRemoved
        Dim panel As Panel = DirectCast(sender, Panel)
        If panel.Name = "VoiceChannels" Then
            panel.Height = 30 * panel.Controls.Count
        Else
            panel.Height = 30 * (panel.Controls.Count + 1)
        End If
    End Sub

    Private Sub MessageContainer_ControlAdded(sender As Object, e As ControlEventArgs) Handles MessageContainer.ControlAdded
        MessageContainer.VerticalScroll.Value = MessageContainer.VerticalScroll.Maximum
    End Sub

    Private Async Sub ImportMembers(ByVal g As IGuild)
        Try
            Dim members = Await g.GetUsersAsync(CacheMode.AllowDownload)
            Dim roles = g.Roles() _
            .Where(Function(role) (role.Position = 0 Or role.IsHoisted) AndAlso DirectCast(role, SocketRole).Members.Count > 0) _
            .OrderByDescending(Function(role) role.Position) _
            .Cast(Of SocketRole) _
            .ToList()

            Dim assigned As New List(Of ULong)

            MembersList.Invoke(DirectCast(Sub() MembersList.SuspendLayout(), MethodInvoker))
            For Each role In roles

                If role.Members.Where(Function(m) Not assigned.Contains(m.Id)).Count = 0 Then
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

                rh.Invoke(DirectCast(Sub() rh.SuspendLayout(), MethodInvoker))
                For Each m As IGuildUser In role.Members.OrderBy(Function(mem) mem.Username)
                    If assigned.Contains(m.Id) Then
                        Continue For
                    End If

                    assigned.Add(m.Id)
                    Dim holder As New Member With {
                        .Dock = DockStyle.Bottom
                    }
                    holder.Avatar.SetImage(m.GetAvatarUrl())
                    holder.Username.Text = DisplayName(m)
                    holder.Username.ForeColor = GetRoleColour(m)
                    holder.OnlineStatus.BackColor = GetStatusColour(m.Status)
                    If m.Activities.Count > 0 Then
                        holder.Playing.Text = $"{m.Activities.First.Type} {m.Activities.First.Name}"
                    End If

                    Try
                        rh.Invoke(DirectCast(Sub() rh.Controls.Add(holder), MethodInvoker))
                        rh.Invoke(DirectCast(Sub() rh.Height = (45 * rh.Controls.Count - 45) + 30, MethodInvoker))
                    Catch ex As Exception
                        ' Do Nothing
                    End Try
                Next
                rh.Invoke(DirectCast(Sub() rh.ResumeLayout(), MethodInvoker))
            Next
            MembersList.Invoke(DirectCast(Sub() MembersList.ResumeLayout(), MethodInvoker))
        Catch
        End Try
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
        If shouldShutdown Then
            Await Discord.StopAsync()
            Await Discord.LogoutAsync()
        End If

        Logger.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserSettings.ShowDialog()
    End Sub

    Private Sub ChannelName_TextChanged(sender As Object, e As EventArgs) Handles ChannelName.TextChanged
        ChannelName.Width = TextRenderer.MeasureText(ChannelName.Text, ChannelName.Font).Width
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
                Logger.Log(LogLevel.WARN, $"Failed to send attachment to channel{vbNewLine}{ex.Message}{vbNewLine}{ex.StackTrace}")
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

        With New ServerManagement
            .ServerName.Text = $"{server.Name} ({server.Id})"
            .ServerIcon.ImageLocation = server.IconUrl
            .ServerOwner.Text = $"Owner: {owner.Username}#{owner.Discriminator} ({owner.Id})"
            .MemberInfo.Text = $"Bots: {bots} ({Math.Round(bots / members.Count * 100, 2)}%){vbNewLine}Total Members: {members.Count}"
            .ShowDialog()
        End With

    End Sub

    Private Sub MembersList_ControlAdded(sender As Object, e As ControlEventArgs) Handles MembersList.ControlAdded
        e.Control.BringToFront()
    End Sub
End Class
