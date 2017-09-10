<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerOverview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrimCordTheme1 = New CrimsonCord.CrimCordTheme()
        Me.MemberInfo = New System.Windows.Forms.Label()
        Me.ServerOwner = New System.Windows.Forms.Label()
        Me.ServerName = New System.Windows.Forms.Label()
        Me.ServerIcon = New CrimsonCord.CircularPictureBox()
        Me.CrimCordTheme1.SuspendLayout()
        CType(Me.ServerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrimCordTheme1
        '
        Me.CrimCordTheme1.AccentColor = System.Drawing.Color.White
        Me.CrimCordTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CrimCordTheme1.Controls.Add(Me.MemberInfo)
        Me.CrimCordTheme1.Controls.Add(Me.ServerOwner)
        Me.CrimCordTheme1.Controls.Add(Me.ServerName)
        Me.CrimCordTheme1.Controls.Add(Me.ServerIcon)
        Me.CrimCordTheme1.DisplayClose = True
        Me.CrimCordTheme1.DisplayTitleBar = True
        Me.CrimCordTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrimCordTheme1.Draggable = True
        Me.CrimCordTheme1.IsDialog = False
        Me.CrimCordTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CrimCordTheme1.Name = "CrimCordTheme1"
        Me.CrimCordTheme1.Size = New System.Drawing.Size(467, 143)
        Me.CrimCordTheme1.TabIndex = 0
        Me.CrimCordTheme1.TitleFont = New System.Drawing.Font("Open Sans Light", 9.75!)
        Me.CrimCordTheme1.TitleText = "Server Overview"
        '
        'MemberInfo
        '
        Me.MemberInfo.AutoEllipsis = True
        Me.MemberInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.MemberInfo.ForeColor = System.Drawing.Color.White
        Me.MemberInfo.Location = New System.Drawing.Point(109, 83)
        Me.MemberInfo.Name = "MemberInfo"
        Me.MemberInfo.Size = New System.Drawing.Size(347, 44)
        Me.MemberInfo.TabIndex = 4
        Me.MemberInfo.Text = "Bots: 0 (0%)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Members: 0"
        '
        'ServerOwner
        '
        Me.ServerOwner.AutoEllipsis = True
        Me.ServerOwner.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.ServerOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ServerOwner.Location = New System.Drawing.Point(109, 61)
        Me.ServerOwner.Name = "ServerOwner"
        Me.ServerOwner.Size = New System.Drawing.Size(347, 24)
        Me.ServerOwner.TabIndex = 3
        Me.ServerOwner.Text = "Owner:"
        '
        'ServerName
        '
        Me.ServerName.AutoEllipsis = True
        Me.ServerName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ServerName.ForeColor = System.Drawing.Color.White
        Me.ServerName.Location = New System.Drawing.Point(108, 37)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(347, 29)
        Me.ServerName.TabIndex = 2
        Me.ServerName.Text = "Server Name"
        '
        'ServerIcon
        '
        Me.ServerIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ServerIcon.Location = New System.Drawing.Point(12, 37)
        Me.ServerIcon.Name = "ServerIcon"
        Me.ServerIcon.Size = New System.Drawing.Size(90, 90)
        Me.ServerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ServerIcon.TabIndex = 1
        Me.ServerIcon.TabStop = False
        '
        'ServerOverview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 143)
        Me.Controls.Add(Me.CrimCordTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServerOverview"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ServerOverview"
        Me.CrimCordTheme1.ResumeLayout(False)
        CType(Me.ServerIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrimCordTheme1 As CrimCordTheme
    Friend WithEvents ServerIcon As CircularPictureBox
    Friend WithEvents MemberInfo As Label
    Friend WithEvents ServerOwner As Label
    Friend WithEvents ServerName As Label
End Class
