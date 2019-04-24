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
        Me.ThemedButton1 = New CrimsonCord.ThemedButton()
        Me.CrimCordTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrimCordTheme1
        '
        Me.CrimCordTheme1.AccentColor = System.Drawing.Color.White
        Me.CrimCordTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CrimCordTheme1.Controls.Add(Me.TextBox1)
        Me.CrimCordTheme1.Controls.Add(Me.Label1)
        Me.CrimCordTheme1.Controls.Add(Me.ThemedButton3)
        Me.CrimCordTheme1.Controls.Add(Me.ThemedButton1)
        Me.CrimCordTheme1.DisplayClose = False
        Me.CrimCordTheme1.DisplayTitleBar = False
        Me.CrimCordTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrimCordTheme1.Draggable = False
        Me.CrimCordTheme1.IsDialog = True
        Me.CrimCordTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CrimCordTheme1.Name = "CrimCordTheme1"
        Me.CrimCordTheme1.Size = New System.Drawing.Size(396, 98)
        Me.CrimCordTheme1.TabIndex = 0
        Me.CrimCordTheme1.TitleFont = New System.Drawing.Font("Open Sans Light", 9.75!)
        Me.CrimCordTheme1.TitleText = "Login"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(16, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(368, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Token"
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
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
        Me.ThemedButton3.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemedButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ThemedButton3.Location = New System.Drawing.Point(196, 64)
        Me.ThemedButton3.Name = "ThemedButton3"
        Me.ThemedButton3.Size = New System.Drawing.Size(84, 23)
        Me.ThemedButton3.TabIndex = 3
        Me.ThemedButton3.Text = "Exit"
        Me.ThemedButton3.UseVisualStyleBackColor = False
        '
        'ThemedButton1
        '
        Me.ThemedButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThemedButton1.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThemedButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ThemedButton1.Location = New System.Drawing.Point(286, 64)
        Me.ThemedButton1.Name = "ThemedButton1"
        Me.ThemedButton1.Size = New System.Drawing.Size(98, 23)
        Me.ThemedButton1.TabIndex = 1
        Me.ThemedButton1.Text = "Login as Bot"
        Me.ThemedButton1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 98)
        Me.Controls.Add(Me.CrimCordTheme1)
        Me.DoubleBuffered = True
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
    Friend WithEvents ThemedButton3 As ThemedButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
