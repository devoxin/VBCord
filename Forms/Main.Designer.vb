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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CrimCordTheme1 = New CrimsonCord.CrimCordTheme()
        Me.MessageContainer = New System.Windows.Forms.Panel()
        Me.AttachmentPanel = New System.Windows.Forms.Panel()
        Me.AttachmentStatus = New System.Windows.Forms.Label()
        Me.MessageControls = New System.Windows.Forms.Panel()
        Me.MessageInput = New System.Windows.Forms.TextBox()
        Me.ChannelInfoContainer = New System.Windows.Forms.Panel()
        Me.ChannelTopic = New System.Windows.Forms.Label()
        Me.ChannelName = New System.Windows.Forms.Label()
        Me.UtilPanel = New System.Windows.Forms.Panel()
        Me.ChannelContainer = New System.Windows.Forms.Panel()
        Me.VoiceChannels = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextChannels = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ServerName = New System.Windows.Forms.Label()
        Me.Servers = New System.Windows.Forms.Panel()
        Me.VoicePanel = New System.Windows.Forms.Panel()
        Me.VoiceName = New System.Windows.Forms.Label()
        Me.VoiceStatus = New System.Windows.Forms.Label()
        Me.UserInfo = New System.Windows.Forms.Panel()
        Me.UserDiscrim = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.MembersList = New System.Windows.Forms.Panel()
        Me.ViewInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAttachmentPanel = New CrimsonCord.ThemedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AttachFile = New CrimsonCord.ThemedButton()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.LatencyImage = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserAvatar = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.CrimCordTheme1.SuspendLayout()
        Me.AttachmentPanel.SuspendLayout()
        Me.MessageControls.SuspendLayout()
        Me.ChannelInfoContainer.SuspendLayout()
        Me.UtilPanel.SuspendLayout()
        Me.ChannelContainer.SuspendLayout()
        Me.VoicePanel.SuspendLayout()
        Me.UserInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LatencyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewInfoToolStripMenuItem, Me.CopyIDToolStripMenuItem, Me.ToolStripSeparator1, Me.LeaveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 98)
        '
        'CopyIDToolStripMenuItem
        '
        Me.CopyIDToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.CopyIDToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CopyIDToolStripMenuItem.Name = "CopyIDToolStripMenuItem"
        Me.CopyIDToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyIDToolStripMenuItem.Text = "Copy ID"
        '
        'LeaveToolStripMenuItem
        '
        Me.LeaveToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.LeaveToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem"
        Me.LeaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LeaveToolStripMenuItem.Text = "Leave"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'CrimCordTheme1
        '
        Me.CrimCordTheme1.AccentColor = System.Drawing.Color.White
        Me.CrimCordTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CrimCordTheme1.Controls.Add(Me.MessageContainer)
        Me.CrimCordTheme1.Controls.Add(Me.AttachmentPanel)
        Me.CrimCordTheme1.Controls.Add(Me.MessageControls)
        Me.CrimCordTheme1.Controls.Add(Me.ChannelInfoContainer)
        Me.CrimCordTheme1.Controls.Add(Me.UtilPanel)
        Me.CrimCordTheme1.Controls.Add(Me.MembersList)
        Me.CrimCordTheme1.DisplayClose = True
        Me.CrimCordTheme1.DisplayTitleBar = True
        Me.CrimCordTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrimCordTheme1.Draggable = True
        Me.CrimCordTheme1.IsDialog = False
        Me.CrimCordTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CrimCordTheme1.Name = "CrimCordTheme1"
        Me.CrimCordTheme1.Size = New System.Drawing.Size(1232, 736)
        Me.CrimCordTheme1.TabIndex = 6
        Me.CrimCordTheme1.TitleFont = New System.Drawing.Font("Lato", 10.0!)
        Me.CrimCordTheme1.TitleText = "VBCord | Developed by Devoxin#0387"
        '
        'MessageContainer
        '
        Me.MessageContainer.AutoScroll = True
        Me.MessageContainer.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.MessageContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MessageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageContainer.Location = New System.Drawing.Point(240, 61)
        Me.MessageContainer.Name = "MessageContainer"
        Me.MessageContainer.Size = New System.Drawing.Size(786, 583)
        Me.MessageContainer.TabIndex = 5
        '
        'AttachmentPanel
        '
        Me.AttachmentPanel.Controls.Add(Me.CloseAttachmentPanel)
        Me.AttachmentPanel.Controls.Add(Me.AttachmentStatus)
        Me.AttachmentPanel.Controls.Add(Me.PictureBox1)
        Me.AttachmentPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AttachmentPanel.Location = New System.Drawing.Point(240, 644)
        Me.AttachmentPanel.Name = "AttachmentPanel"
        Me.AttachmentPanel.Size = New System.Drawing.Size(786, 46)
        Me.AttachmentPanel.TabIndex = 12
        Me.AttachmentPanel.Visible = False
        '
        'AttachmentStatus
        '
        Me.AttachmentStatus.AutoSize = True
        Me.AttachmentStatus.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.AttachmentStatus.ForeColor = System.Drawing.Color.White
        Me.AttachmentStatus.Location = New System.Drawing.Point(52, 12)
        Me.AttachmentStatus.Name = "AttachmentStatus"
        Me.AttachmentStatus.Size = New System.Drawing.Size(103, 20)
        Me.AttachmentStatus.TabIndex = 1
        Me.AttachmentStatus.Text = "File sending..."
        '
        'MessageControls
        '
        Me.MessageControls.Controls.Add(Me.MessageInput)
        Me.MessageControls.Controls.Add(Me.AttachFile)
        Me.MessageControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MessageControls.Location = New System.Drawing.Point(240, 690)
        Me.MessageControls.Name = "MessageControls"
        Me.MessageControls.Size = New System.Drawing.Size(786, 46)
        Me.MessageControls.TabIndex = 11
        '
        'MessageInput
        '
        Me.MessageInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MessageInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MessageInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageInput.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MessageInput.ForeColor = System.Drawing.Color.White
        Me.MessageInput.Location = New System.Drawing.Point(46, 0)
        Me.MessageInput.Multiline = True
        Me.MessageInput.Name = "MessageInput"
        Me.MessageInput.Size = New System.Drawing.Size(740, 46)
        Me.MessageInput.TabIndex = 3
        '
        'ChannelInfoContainer
        '
        Me.ChannelInfoContainer.Controls.Add(Me.ChannelTopic)
        Me.ChannelInfoContainer.Controls.Add(Me.ChannelName)
        Me.ChannelInfoContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChannelInfoContainer.Location = New System.Drawing.Point(240, 27)
        Me.ChannelInfoContainer.Name = "ChannelInfoContainer"
        Me.ChannelInfoContainer.Size = New System.Drawing.Size(786, 34)
        Me.ChannelInfoContainer.TabIndex = 9
        '
        'ChannelTopic
        '
        Me.ChannelTopic.AutoEllipsis = True
        Me.ChannelTopic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChannelTopic.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.ChannelTopic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ChannelTopic.Location = New System.Drawing.Point(93, 0)
        Me.ChannelTopic.Name = "ChannelTopic"
        Me.ChannelTopic.Size = New System.Drawing.Size(693, 34)
        Me.ChannelTopic.TabIndex = 8
        Me.ChannelTopic.Text = "No Channel Selected."
        Me.ChannelTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChannelName
        '
        Me.ChannelName.AutoEllipsis = True
        Me.ChannelName.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChannelName.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.ChannelName.ForeColor = System.Drawing.Color.White
        Me.ChannelName.Location = New System.Drawing.Point(0, 0)
        Me.ChannelName.MaximumSize = New System.Drawing.Size(300, 0)
        Me.ChannelName.Name = "ChannelName"
        Me.ChannelName.Size = New System.Drawing.Size(93, 0)
        Me.ChannelName.TabIndex = 9
        Me.ChannelName.Text = "No Channel"
        Me.ChannelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UtilPanel
        '
        Me.UtilPanel.Controls.Add(Me.ChannelContainer)
        Me.UtilPanel.Controls.Add(Me.ServerName)
        Me.UtilPanel.Controls.Add(Me.Servers)
        Me.UtilPanel.Controls.Add(Me.VoicePanel)
        Me.UtilPanel.Controls.Add(Me.UserInfo)
        Me.UtilPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.UtilPanel.Location = New System.Drawing.Point(0, 27)
        Me.UtilPanel.Name = "UtilPanel"
        Me.UtilPanel.Size = New System.Drawing.Size(240, 709)
        Me.UtilPanel.TabIndex = 7
        '
        'ChannelContainer
        '
        Me.ChannelContainer.Controls.Add(Me.VoiceChannels)
        Me.ChannelContainer.Controls.Add(Me.Label2)
        Me.ChannelContainer.Controls.Add(Me.TextChannels)
        Me.ChannelContainer.Controls.Add(Me.Label1)
        Me.ChannelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChannelContainer.Location = New System.Drawing.Point(62, 34)
        Me.ChannelContainer.Name = "ChannelContainer"
        Me.ChannelContainer.Size = New System.Drawing.Size(178, 583)
        Me.ChannelContainer.TabIndex = 2
        '
        'VoiceChannels
        '
        Me.VoiceChannels.Dock = System.Windows.Forms.DockStyle.Top
        Me.VoiceChannels.Location = New System.Drawing.Point(0, 56)
        Me.VoiceChannels.Name = "VoiceChannels"
        Me.VoiceChannels.Size = New System.Drawing.Size(178, 0)
        Me.VoiceChannels.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Voice Channels"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextChannels
        '
        Me.TextChannels.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextChannels.Location = New System.Drawing.Point(0, 28)
        Me.TextChannels.Name = "TextChannels"
        Me.TextChannels.Size = New System.Drawing.Size(178, 0)
        Me.TextChannels.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Text Channels"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ServerName
        '
        Me.ServerName.Dock = System.Windows.Forms.DockStyle.Top
        Me.ServerName.Font = New System.Drawing.Font("Open Sans", 11.0!)
        Me.ServerName.ForeColor = System.Drawing.Color.White
        Me.ServerName.Location = New System.Drawing.Point(62, 0)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(178, 34)
        Me.ServerName.TabIndex = 7
        Me.ServerName.Text = "Select a Server"
        Me.ServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Servers
        '
        Me.Servers.AutoScroll = True
        Me.Servers.Dock = System.Windows.Forms.DockStyle.Left
        Me.Servers.Location = New System.Drawing.Point(0, 0)
        Me.Servers.Name = "Servers"
        Me.Servers.Size = New System.Drawing.Size(62, 617)
        Me.Servers.TabIndex = 6
        '
        'VoicePanel
        '
        Me.VoicePanel.Controls.Add(Me.Disconnect)
        Me.VoicePanel.Controls.Add(Me.LatencyImage)
        Me.VoicePanel.Controls.Add(Me.VoiceName)
        Me.VoicePanel.Controls.Add(Me.VoiceStatus)
        Me.VoicePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VoicePanel.Location = New System.Drawing.Point(0, 617)
        Me.VoicePanel.Name = "VoicePanel"
        Me.VoicePanel.Size = New System.Drawing.Size(240, 46)
        Me.VoicePanel.TabIndex = 9
        Me.VoicePanel.Visible = False
        '
        'VoiceName
        '
        Me.VoiceName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VoiceName.AutoEllipsis = True
        Me.VoiceName.Font = New System.Drawing.Font("Open Sans", 8.0!)
        Me.VoiceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.VoiceName.Location = New System.Drawing.Point(41, 23)
        Me.VoiceName.Name = "VoiceName"
        Me.VoiceName.Size = New System.Drawing.Size(158, 16)
        Me.VoiceName.TabIndex = 2
        '
        'VoiceStatus
        '
        Me.VoiceStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VoiceStatus.AutoEllipsis = True
        Me.VoiceStatus.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.VoiceStatus.ForeColor = System.Drawing.Color.White
        Me.VoiceStatus.Location = New System.Drawing.Point(41, 7)
        Me.VoiceStatus.Name = "VoiceStatus"
        Me.VoiceStatus.Size = New System.Drawing.Size(158, 16)
        Me.VoiceStatus.TabIndex = 1
        Me.VoiceStatus.Text = "Voice Disconnected"
        '
        'UserInfo
        '
        Me.UserInfo.Controls.Add(Me.Button1)
        Me.UserInfo.Controls.Add(Me.Button2)
        Me.UserInfo.Controls.Add(Me.UserDiscrim)
        Me.UserInfo.Controls.Add(Me.Username)
        Me.UserInfo.Controls.Add(Me.UserAvatar)
        Me.UserInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserInfo.Location = New System.Drawing.Point(0, 663)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(240, 46)
        Me.UserInfo.TabIndex = 8
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
        Me.Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Username.AutoEllipsis = True
        Me.Username.Font = New System.Drawing.Font("Open Sans", 9.0!)
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(44, 7)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(193, 16)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'MembersList
        '
        Me.MembersList.AutoScroll = True
        Me.MembersList.AutoScrollMinSize = New System.Drawing.Size(10, 10)
        Me.MembersList.Dock = System.Windows.Forms.DockStyle.Right
        Me.MembersList.Location = New System.Drawing.Point(1026, 27)
        Me.MembersList.Name = "MembersList"
        Me.MembersList.Size = New System.Drawing.Size(206, 709)
        Me.MembersList.TabIndex = 13
        '
        'ViewInfoToolStripMenuItem
        '
        Me.ViewInfoToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.ViewInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewInfoToolStripMenuItem.Name = "ViewInfoToolStripMenuItem"
        Me.ViewInfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewInfoToolStripMenuItem.Text = "Overview"
        '
        'CloseAttachmentPanel
        '
        Me.CloseAttachmentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CloseAttachmentPanel.BackgroundImage = CType(resources.GetObject("CloseAttachmentPanel.BackgroundImage"), System.Drawing.Image)
        Me.CloseAttachmentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseAttachmentPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseAttachmentPanel.FlatAppearance.BorderSize = 0
        Me.CloseAttachmentPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.CloseAttachmentPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.CloseAttachmentPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseAttachmentPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.CloseAttachmentPanel.Location = New System.Drawing.Point(740, 0)
        Me.CloseAttachmentPanel.Name = "CloseAttachmentPanel"
        Me.CloseAttachmentPanel.Size = New System.Drawing.Size(46, 46)
        Me.CloseAttachmentPanel.TabIndex = 2
        Me.CloseAttachmentPanel.UseVisualStyleBackColor = False
        Me.CloseAttachmentPanel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AttachFile
        '
        Me.AttachFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.AttachFile.BackgroundImage = CType(resources.GetObject("AttachFile.BackgroundImage"), System.Drawing.Image)
        Me.AttachFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AttachFile.Dock = System.Windows.Forms.DockStyle.Left
        Me.AttachFile.FlatAppearance.BorderSize = 0
        Me.AttachFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AttachFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.AttachFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttachFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.AttachFile.Location = New System.Drawing.Point(0, 0)
        Me.AttachFile.Name = "AttachFile"
        Me.AttachFile.Size = New System.Drawing.Size(46, 46)
        Me.AttachFile.TabIndex = 10
        Me.AttachFile.UseVisualStyleBackColor = False
        '
        'Disconnect
        '
        Me.Disconnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Disconnect.BackgroundImage = CType(resources.GetObject("Disconnect.BackgroundImage"), System.Drawing.Image)
        Me.Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Disconnect.FlatAppearance.BorderSize = 0
        Me.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Disconnect.Location = New System.Drawing.Point(205, 7)
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(199, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(221, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(16, 16)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1232, 736)
        Me.Controls.Add(Me.CrimCordTheme1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "VBCord"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.CrimCordTheme1.ResumeLayout(False)
        Me.AttachmentPanel.ResumeLayout(False)
        Me.AttachmentPanel.PerformLayout()
        Me.MessageControls.ResumeLayout(False)
        Me.MessageControls.PerformLayout()
        Me.ChannelInfoContainer.ResumeLayout(False)
        Me.UtilPanel.ResumeLayout(False)
        Me.ChannelContainer.ResumeLayout(False)
        Me.VoicePanel.ResumeLayout(False)
        Me.UserInfo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LatencyImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChannelContainer As System.Windows.Forms.Panel
    Friend WithEvents MessageInput As System.Windows.Forms.TextBox
    Friend WithEvents MessageContainer As System.Windows.Forms.Panel
    Friend WithEvents Servers As System.Windows.Forms.Panel
    Friend WithEvents UserInfo As System.Windows.Forms.Panel
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents UserAvatar As System.Windows.Forms.PictureBox
    Friend WithEvents UserDiscrim As System.Windows.Forms.Label
    Friend WithEvents ChannelTopic As System.Windows.Forms.Label
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
    Friend WithEvents CrimCordTheme1 As CrimCordTheme
    Friend WithEvents ChannelInfoContainer As Panel
    Friend WithEvents ChannelName As Label
    Friend WithEvents UtilPanel As Panel
    Friend WithEvents ServerName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MessageControls As Panel
    Friend WithEvents AttachFile As ThemedButton
    Friend WithEvents AttachmentPanel As Panel
    Friend WithEvents CloseAttachmentPanel As ThemedButton
    Friend WithEvents AttachmentStatus As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MembersList As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CopyIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewInfoToolStripMenuItem As ToolStripMenuItem
End Class
