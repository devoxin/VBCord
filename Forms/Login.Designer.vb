<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThemedButton3 = New CrimsonCord.ThemedButton()
        Me.ThemedButton2 = New CrimsonCord.ThemedButton()
        Me.ThemedButton1 = New CrimsonCord.ThemedButton()
        Me.CrimCordTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrimCordTheme1
        '
        Me.CrimCordTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CrimCordTheme1.Controls.Add(Me.TextBox1)
        Me.CrimCordTheme1.Controls.Add(Me.Label1)
        Me.CrimCordTheme1.Controls.Add(Me.ThemedButton3)
        Me.CrimCordTheme1.Controls.Add(Me.ThemedButton2)
        Me.CrimCordTheme1.Controls.Add(Me.ThemedButton1)
        Me.CrimCordTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrimCordTheme1.IsDialog = True
        Me.CrimCordTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CrimCordTheme1.Name = "CrimCordTheme1"
        Me.CrimCordTheme1.Size = New System.Drawing.Size(396, 139)
        Me.CrimCordTheme1.TabIndex = 0
        Me.CrimCordTheme1.TitleText = "Login"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(16, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(368, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Token"
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login to Discord"
        '
        'ThemedButton3
        '
        Me.ThemedButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ThemedButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemedButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThemedButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ThemedButton3.Location = New System.Drawing.Point(120, 104)
        Me.ThemedButton3.Name = "ThemedButton3"
        Me.ThemedButton3.Size = New System.Drawing.Size(84, 23)
        Me.ThemedButton3.TabIndex = 3
        Me.ThemedButton3.Text = "Exit"
        Me.ThemedButton3.UseVisualStyleBackColor = False
        '
        'ThemedButton2
        '
        Me.ThemedButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ThemedButton2.Enabled = False
        Me.ThemedButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ThemedButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThemedButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ThemedButton2.Location = New System.Drawing.Point(210, 104)
        Me.ThemedButton2.Name = "ThemedButton2"
        Me.ThemedButton2.Size = New System.Drawing.Size(84, 23)
        Me.ThemedButton2.TabIndex = 2
        Me.ThemedButton2.Text = "Login as User"
        Me.ThemedButton2.UseVisualStyleBackColor = False
        '
        'ThemedButton1
        '
        Me.ThemedButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThemedButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ThemedButton1.Location = New System.Drawing.Point(300, 104)
        Me.ThemedButton1.Name = "ThemedButton1"
        Me.ThemedButton1.Size = New System.Drawing.Size(84, 23)
        Me.ThemedButton1.TabIndex = 1
        Me.ThemedButton1.Text = "Login as Bot"
        Me.ThemedButton1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 139)
        Me.Controls.Add(Me.CrimCordTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.CrimCordTheme1.ResumeLayout(False)
        Me.CrimCordTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrimCordTheme1 As CrimCordTheme
    Friend WithEvents ThemedButton1 As ThemedButton
    Friend WithEvents ThemedButton2 As ThemedButton
    Friend WithEvents ThemedButton3 As ThemedButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
