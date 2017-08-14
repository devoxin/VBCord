<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.DividerTitle = New System.Windows.Forms.Panel()
        Me.ChannelContainer = New System.Windows.Forms.Panel()
        Me.VoiceChannels = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextChannels = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DividerChannel = New System.Windows.Forms.Panel()
        Me.MessageInput = New System.Windows.Forms.TextBox()
        Me.MessageContainer = New System.Windows.Forms.Panel()
        Me.Servers = New System.Windows.Forms.Panel()
        Me.ServerName = New System.Windows.Forms.Label()
        Me.UserInfo = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserDiscrim = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.UserAvatar = New System.Windows.Forms.PictureBox()
        Me.ChannelTopic = New System.Windows.Forms.Label()
        Me.InfoHolder = New System.Windows.Forms.Panel()
        Me.VoicePanel = New System.Windows.Forms.Panel()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.LatencyImage = New System.Windows.Forms.PictureBox()
        Me.VoiceName = New System.Windows.Forms.Label()
        Me.VoiceStatus = New System.Windows.Forms.Label()
        Me.TitleBar.SuspendLayout()
        Me.ChannelContainer.SuspendLayout()
        Me.UserInfo.SuspendLayout()
        CType(Me.UserAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoHolder.SuspendLayout()
        Me.VoicePanel.SuspendLayout()
        CType(Me.LatencyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.Transparent
        Me.TitleBar.Controls.Add(Me.Button1)
        Me.TitleBar.Controls.Add(Me.Title)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(1232, 27)
        Me.TitleBar.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1209, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 27)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.Dock = System.Windows.Forms.DockStyle.Left
        Me.Title.Font = New System.Drawing.Font("Open Sans Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(0, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(92, 27)
        Me.Title.TabIndex = 0
        Me.Title.Text = "CrimsonCord"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DividerTitle
        '
        Me.DividerTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.DividerTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.DividerTitle.Location = New System.Drawing.Point(0, 27)
        Me.DividerTitle.Name = "DividerTitle"
        Me.DividerTitle.Size = New System.Drawing.Size(1232, 2)
        Me.DividerTitle.TabIndex = 1
        '
        'ChannelContainer
        '
        Me.ChannelContainer.Controls.Add(Me.VoiceChannels)
        Me.ChannelContainer.Controls.Add(Me.Label2)
        Me.ChannelContainer.Controls.Add(Me.TextChannels)
        Me.ChannelContainer.Controls.Add(Me.Label1)
        Me.ChannelContainer.Controls.Add(Me.DividerChannel)
        Me.ChannelContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChannelContainer.Location = New System.Drawing.Point(64, 0)
        Me.ChannelContainer.Name = "ChannelContainer"
        Me.ChannelContainer.Size = New System.Drawing.Size(135, 615)
        Me.ChannelContainer.TabIndex = 2
        '
        'VoiceChannels
        '
        Me.VoiceChannels.Dock = System.Windows.Forms.DockStyle.Top
        Me.VoiceChannels.Location = New System.Drawing.Point(0, 56)
        Me.VoiceChannels.Name = "VoiceChannels"
        Me.VoiceChannels.Size = New System.Drawing.Size(133, 0)
        Me.VoiceChannels.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Voice Channels"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextChannels
        '
        Me.TextChannels.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextChannels.Location = New System.Drawing.Point(0, 28)
        Me.TextChannels.Name = "TextChannels"
        Me.TextChannels.Size = New System.Drawing.Size(133, 0)
        Me.TextChannels.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Text Channels"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DividerChannel
        '
        Me.DividerChannel.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.DividerChannel.Dock = System.Windows.Forms.DockStyle.Right
        Me.DividerChannel.Location = New System.Drawing.Point(133, 0)
        Me.DividerChannel.Name = "DividerChannel"
        Me.DividerChannel.Size = New System.Drawing.Size(2, 615)
        Me.DividerChannel.TabIndex = 0
        '
        'MessageInput
        '
        Me.MessageInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MessageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageInput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MessageInput.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MessageInput.ForeColor = System.Drawing.Color.White
        Me.MessageInput.Location = New System.Drawing.Point(210, 690)
        Me.MessageInput.Multiline = True
        Me.MessageInput.Name = "MessageInput"
        Me.MessageInput.Size = New System.Drawing.Size(1022, 46)
        Me.MessageInput.TabIndex = 3
        '
        'MessageContainer
        '
        Me.MessageContainer.AutoScroll = True
        Me.MessageContainer.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.MessageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageContainer.Location = New System.Drawing.Point(210, 95)
        Me.MessageContainer.Name = "MessageContainer"
        Me.MessageContainer.Size = New System.Drawing.Size(1022, 595)
        Me.MessageContainer.TabIndex = 5
        '
        'Servers
        '
        Me.Servers.AutoScroll = True
        Me.Servers.Dock = System.Windows.Forms.DockStyle.Left
        Me.Servers.Location = New System.Drawing.Point(0, 0)
        Me.Servers.Name = "Servers"
        Me.Servers.Size = New System.Drawing.Size(64, 615)
        Me.Servers.TabIndex = 6
        '
        'ServerName
        '
        Me.ServerName.Dock = System.Windows.Forms.DockStyle.Top
        Me.ServerName.Font = New System.Drawing.Font("Open Sans", 14.0!)
        Me.ServerName.ForeColor = System.Drawing.Color.White
        Me.ServerName.Location = New System.Drawing.Point(210, 29)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(1022, 39)
        Me.ServerName.TabIndex = 7
        Me.ServerName.Text = "Server Name"
        Me.ServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserInfo
        '
        Me.UserInfo.Controls.Add(Me.Button2)
        Me.UserInfo.Controls.Add(Me.UserDiscrim)
        Me.UserInfo.Controls.Add(Me.Username)
        Me.UserInfo.Controls.Add(Me.UserAvatar)
        Me.UserInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserInfo.Location = New System.Drawing.Point(0, 661)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(210, 46)
        Me.UserInfo.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(188, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 16)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UserDiscrim
        '
        Me.UserDiscrim.AutoEllipsis = True
        Me.UserDiscrim.Font = New System.Drawing.Font("Open Sans", 8.0!)
        Me.UserDiscrim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.UserDiscrim.Location = New System.Drawing.Point(44, 23)
        Me.UserDiscrim.Name = "UserDiscrim"
        Me.UserDiscrim.Size = New System.Drawing.Size(62, 16)
        Me.UserDiscrim.TabIndex = 2
        Me.UserDiscrim.Text = "#9999"
        '
        'Username
        '
        Me.Username.AutoEllipsis = True
        Me.Username.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(44, 7)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(160, 16)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'UserAvatar
        '
        Me.UserAvatar.Location = New System.Drawing.Point(6, 7)
        Me.UserAvatar.Name = "UserAvatar"
        Me.UserAvatar.Size = New System.Drawing.Size(32, 32)
        Me.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserAvatar.TabIndex = 0
        Me.UserAvatar.TabStop = False
        '
        'ChannelTopic
        '
        Me.ChannelTopic.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChannelTopic.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.ChannelTopic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ChannelTopic.Location = New System.Drawing.Point(210, 68)
        Me.ChannelTopic.Name = "ChannelTopic"
        Me.ChannelTopic.Size = New System.Drawing.Size(1022, 27)
        Me.ChannelTopic.TabIndex = 8
        Me.ChannelTopic.Text = "Channel Topic"
        Me.ChannelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoHolder
        '
        Me.InfoHolder.Controls.Add(Me.ChannelContainer)
        Me.InfoHolder.Controls.Add(Me.Servers)
        Me.InfoHolder.Controls.Add(Me.VoicePanel)
        Me.InfoHolder.Controls.Add(Me.UserInfo)
        Me.InfoHolder.Dock = System.Windows.Forms.DockStyle.Left
        Me.InfoHolder.Location = New System.Drawing.Point(0, 29)
        Me.InfoHolder.Name = "InfoHolder"
        Me.InfoHolder.Size = New System.Drawing.Size(210, 707)
        Me.InfoHolder.TabIndex = 9
        '
        'VoicePanel
        '
        Me.VoicePanel.Controls.Add(Me.Disconnect)
        Me.VoicePanel.Controls.Add(Me.LatencyImage)
        Me.VoicePanel.Controls.Add(Me.VoiceName)
        Me.VoicePanel.Controls.Add(Me.VoiceStatus)
        Me.VoicePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VoicePanel.Location = New System.Drawing.Point(0, 615)
        Me.VoicePanel.Name = "VoicePanel"
        Me.VoicePanel.Size = New System.Drawing.Size(210, 46)
        Me.VoicePanel.TabIndex = 9
        Me.VoicePanel.Visible = False
        '
        'Disconnect
        '
        Me.Disconnect.BackgroundImage = CType(resources.GetObject("Disconnect.BackgroundImage"), System.Drawing.Image)
        Me.Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Disconnect.FlatAppearance.BorderSize = 0
        Me.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Disconnect.Location = New System.Drawing.Point(172, 7)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(32, 32)
        Me.Disconnect.TabIndex = 4
        Me.Disconnect.UseVisualStyleBackColor = True
        '
        'LatencyImage
        '
        Me.LatencyImage.Location = New System.Drawing.Point(3, 7)
        Me.LatencyImage.Name = "LatencyImage"
        Me.LatencyImage.Size = New System.Drawing.Size(32, 32)
        Me.LatencyImage.TabIndex = 3
        Me.LatencyImage.TabStop = False
        '
        'VoiceName
        '
        Me.VoiceName.AutoEllipsis = True
        Me.VoiceName.Font = New System.Drawing.Font("Open Sans", 8.0!)
        Me.VoiceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.VoiceName.Location = New System.Drawing.Point(41, 23)
        Me.VoiceName.Name = "VoiceName"
        Me.VoiceName.Size = New System.Drawing.Size(120, 20)
        Me.VoiceName.TabIndex = 2
        '
        'VoiceStatus
        '
        Me.VoiceStatus.AutoEllipsis = True
        Me.VoiceStatus.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.VoiceStatus.ForeColor = System.Drawing.Color.White
        Me.VoiceStatus.Location = New System.Drawing.Point(41, 7)
        Me.VoiceStatus.Name = "VoiceStatus"
        Me.VoiceStatus.Size = New System.Drawing.Size(120, 16)
        Me.VoiceStatus.TabIndex = 1
        Me.VoiceStatus.Text = "Voice Disconnected"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1232, 736)
        Me.Controls.Add(Me.MessageContainer)
        Me.Controls.Add(Me.ChannelTopic)
        Me.Controls.Add(Me.MessageInput)
        Me.Controls.Add(Me.ServerName)
        Me.Controls.Add(Me.InfoHolder)
        Me.Controls.Add(Me.DividerTitle)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "DITHCORD PANEL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TitleBar.ResumeLayout(False)
        Me.ChannelContainer.ResumeLayout(False)
        Me.UserInfo.ResumeLayout(False)
        CType(Me.UserAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoHolder.ResumeLayout(False)
        Me.VoicePanel.ResumeLayout(False)
        CType(Me.LatencyImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleBar As System.Windows.Forms.Panel
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents DividerTitle As System.Windows.Forms.Panel
    Friend WithEvents ChannelContainer As System.Windows.Forms.Panel
    Friend WithEvents MessageInput As System.Windows.Forms.TextBox
    Friend WithEvents DividerChannel As System.Windows.Forms.Panel
    Friend WithEvents MessageContainer As System.Windows.Forms.Panel
    Friend WithEvents Servers As System.Windows.Forms.Panel
    Friend WithEvents ServerName As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserInfo As System.Windows.Forms.Panel
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents UserAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents UserDiscrim As System.Windows.Forms.Label
    Friend WithEvents ChannelTopic As System.Windows.Forms.Label
    Friend WithEvents InfoHolder As System.Windows.Forms.Panel
    Friend WithEvents VoiceChannels As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextChannels As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VoicePanel As System.Windows.Forms.Panel
    Friend WithEvents VoiceName As System.Windows.Forms.Label
    Friend WithEvents VoiceStatus As System.Windows.Forms.Label
    Friend WithEvents LatencyImage As System.Windows.Forms.PictureBox
    Friend WithEvents Disconnect As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
End Class
