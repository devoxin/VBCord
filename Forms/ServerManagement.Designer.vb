<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerManagement
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
        Me.OverviewTab = New System.Windows.Forms.Panel()
        Me.ServerIcon = New CrimsonCord.CircularPictureBox()
        Me.ServerName = New System.Windows.Forms.Label()
        Me.MemberInfo = New System.Windows.Forms.Label()
        Me.ServerOwner = New System.Windows.Forms.Label()
        Me.TabSelectionOptions = New System.Windows.Forms.Panel()
        Me.ThemedButton1 = New CrimsonCord.ThemedButton()
        Me.CrimCordTheme1.SuspendLayout()
        Me.OverviewTab.SuspendLayout()
        CType(Me.ServerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSelectionOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrimCordTheme1
        '
        Me.CrimCordTheme1.AccentColor = System.Drawing.Color.White
        Me.CrimCordTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CrimCordTheme1.Controls.Add(Me.OverviewTab)
        Me.CrimCordTheme1.Controls.Add(Me.TabSelectionOptions)
        Me.CrimCordTheme1.DisplayClose = True
        Me.CrimCordTheme1.DisplayTitleBar = True
        Me.CrimCordTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrimCordTheme1.Draggable = True
        Me.CrimCordTheme1.IsDialog = False
        Me.CrimCordTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CrimCordTheme1.Name = "CrimCordTheme1"
        Me.CrimCordTheme1.Size = New System.Drawing.Size(1232, 736)
        Me.CrimCordTheme1.TabIndex = 0
        Me.CrimCordTheme1.TitleFont = New System.Drawing.Font("Open Sans Light", 9.75!)
        Me.CrimCordTheme1.TitleText = "Server Overview"
        '
        'OverviewTab
        '
        Me.OverviewTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.OverviewTab.Controls.Add(Me.ServerIcon)
        Me.OverviewTab.Controls.Add(Me.ServerName)
        Me.OverviewTab.Controls.Add(Me.MemberInfo)
        Me.OverviewTab.Controls.Add(Me.ServerOwner)
        Me.OverviewTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OverviewTab.Location = New System.Drawing.Point(200, 27)
        Me.OverviewTab.Name = "OverviewTab"
        Me.OverviewTab.Size = New System.Drawing.Size(1032, 709)
        Me.OverviewTab.TabIndex = 6
        Me.OverviewTab.Visible = False
        '
        'ServerIcon
        '
        Me.ServerIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ServerIcon.Location = New System.Drawing.Point(3, 3)
        Me.ServerIcon.Name = "ServerIcon"
        Me.ServerIcon.Size = New System.Drawing.Size(128, 128)
        Me.ServerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ServerIcon.TabIndex = 1
        Me.ServerIcon.TabStop = False
        '
        'ServerName
        '
        Me.ServerName.AutoEllipsis = True
        Me.ServerName.Font = New System.Drawing.Font("Segoe UI Semilight", 13.0!)
        Me.ServerName.ForeColor = System.Drawing.Color.White
        Me.ServerName.Location = New System.Drawing.Point(137, 3)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(892, 29)
        Me.ServerName.TabIndex = 2
        Me.ServerName.Text = "Server Name"
        '
        'MemberInfo
        '
        Me.MemberInfo.AutoEllipsis = True
        Me.MemberInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.MemberInfo.ForeColor = System.Drawing.Color.White
        Me.MemberInfo.Location = New System.Drawing.Point(138, 87)
        Me.MemberInfo.Name = "MemberInfo"
        Me.MemberInfo.Size = New System.Drawing.Size(891, 44)
        Me.MemberInfo.TabIndex = 4
        Me.MemberInfo.Text = "Bots: 0 (0%)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Members: 0"
        '
        'ServerOwner
        '
        Me.ServerOwner.AutoEllipsis = True
        Me.ServerOwner.Font = New System.Drawing.Font("Segoe UI Semilight", 11.0!)
        Me.ServerOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ServerOwner.Location = New System.Drawing.Point(138, 32)
        Me.ServerOwner.Name = "ServerOwner"
        Me.ServerOwner.Size = New System.Drawing.Size(891, 24)
        Me.ServerOwner.TabIndex = 3
        Me.ServerOwner.Text = "Owner:"
        '
        'TabSelectionOptions
        '
        Me.TabSelectionOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabSelectionOptions.Controls.Add(Me.ThemedButton1)
        Me.TabSelectionOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabSelectionOptions.Location = New System.Drawing.Point(0, 27)
        Me.TabSelectionOptions.Name = "TabSelectionOptions"
        Me.TabSelectionOptions.Size = New System.Drawing.Size(200, 709)
        Me.TabSelectionOptions.TabIndex = 5
        '
        'ThemedButton1
        '
        Me.ThemedButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ThemedButton1.FlatAppearance.BorderSize = 0
        Me.ThemedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThemedButton1.Font = New System.Drawing.Font("Sansation", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemedButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ThemedButton1.Location = New System.Drawing.Point(0, 0)
        Me.ThemedButton1.Name = "ThemedButton1"
        Me.ThemedButton1.Size = New System.Drawing.Size(200, 39)
        Me.ThemedButton1.TabIndex = 0
        Me.ThemedButton1.Text = "Overview"
        Me.ThemedButton1.UseVisualStyleBackColor = False
        '
        'ServerManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 736)
        Me.Controls.Add(Me.CrimCordTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ServerManagement"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ServerOverview"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.CrimCordTheme1.ResumeLayout(False)
        Me.OverviewTab.ResumeLayout(False)
        CType(Me.ServerIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSelectionOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrimCordTheme1 As CrimCordTheme
    Friend WithEvents ServerIcon As CircularPictureBox
    Friend WithEvents MemberInfo As Label
    Friend WithEvents ServerOwner As Label
    Friend WithEvents ServerName As Label
    Friend WithEvents TabSelectionOptions As Panel
    Friend WithEvents ThemedButton1 As ThemedButton
    Friend WithEvents OverviewTab As Panel
End Class
