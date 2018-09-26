<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Username = New System.Windows.Forms.Label()
        Me.Playing = New System.Windows.Forms.Label()
        Me.Avatar = New CrimsonCord.CircularPictureBox()
        Me.OnlineStatus = New CrimsonCord.CircularPictureBox()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnlineStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.AutoEllipsis = True
        Me.Username.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(41, 3)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(141, 20)
        Me.Username.TabIndex = 0
        Me.Username.Text = "Username"
        '
        'Playing
        '
        Me.Playing.AutoEllipsis = True
        Me.Playing.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!)
        Me.Playing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Playing.Location = New System.Drawing.Point(42, 19)
        Me.Playing.Name = "Playing"
        Me.Playing.Size = New System.Drawing.Size(140, 19)
        Me.Playing.TabIndex = 2
        Me.Playing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Avatar
        '
        Me.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Avatar.Location = New System.Drawing.Point(3, 3)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(36, 36)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Avatar.TabIndex = 4
        Me.Avatar.TabStop = False
        '
        'OnlineStatus
        '
        Me.OnlineStatus.Location = New System.Drawing.Point(31, 31)
        Me.OnlineStatus.Name = "OnlineStatus"
        Me.OnlineStatus.Size = New System.Drawing.Size(8, 8)
        Me.OnlineStatus.TabIndex = 5
        Me.OnlineStatus.TabStop = False
        '
        'Member
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Controls.Add(Me.OnlineStatus)
        Me.Controls.Add(Me.Playing)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Avatar)
        Me.Name = "Member"
        Me.Size = New System.Drawing.Size(206, 45)
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnlineStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Username As Label
    Friend WithEvents Playing As Label
    Friend WithEvents Avatar As CircularPictureBox
    Friend WithEvents OnlineStatus As CircularPictureBox
End Class
