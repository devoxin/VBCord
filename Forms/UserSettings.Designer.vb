<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSettings
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
        Me.FormTemplate1 = New CrimsonCord.CrimCordTheme()
        Me.CircularPictureBox1 = New CrimsonCord.CircularPictureBox()
        Me.ThemedButton1 = New CrimsonCord.ThemedButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FormTemplate1.SuspendLayout()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormTemplate1
        '
        Me.FormTemplate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FormTemplate1.Controls.Add(Me.CircularPictureBox1)
        Me.FormTemplate1.Controls.Add(Me.ThemedButton1)
        Me.FormTemplate1.Controls.Add(Me.TextBox1)
        Me.FormTemplate1.Controls.Add(Me.Label2)
        Me.FormTemplate1.Controls.Add(Me.Label1)
        Me.FormTemplate1.Controls.Add(Me.ComboBox1)
        Me.FormTemplate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormTemplate1.IsDialog = True
        Me.FormTemplate1.Location = New System.Drawing.Point(0, 0)
        Me.FormTemplate1.Name = "FormTemplate1"
        Me.FormTemplate1.Size = New System.Drawing.Size(484, 168)
        Me.FormTemplate1.TabIndex = 0
        Me.FormTemplate1.TitleText = "User Settings"
        '
        'CircularPictureBox1
        '
        Me.CircularPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CircularPictureBox1.Location = New System.Drawing.Point(382, 39)
        Me.CircularPictureBox1.Name = "CircularPictureBox1"
        Me.CircularPictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.CircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CircularPictureBox1.TabIndex = 7
        Me.CircularPictureBox1.TabStop = False
        '
        'ThemedButton1
        '
        Me.ThemedButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.BorderSize = 0
        Me.ThemedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ThemedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ThemedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ThemedButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ThemedButton1.Location = New System.Drawing.Point(382, 133)
        Me.ThemedButton1.Name = "ThemedButton1"
        Me.ThemedButton1.Size = New System.Drawing.Size(90, 23)
        Me.ThemedButton1.TabIndex = 6
        Me.ThemedButton1.Text = "Change..."
        Me.ThemedButton1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(15, 58)
        Me.TextBox1.MaxLength = 32
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato", 9.749999!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username Changer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato", 9.749999!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Status Changer"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Online", "Idle", "AFK", "Do Not Disturb", "Invisible"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'UserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 168)
        Me.Controls.Add(Me.FormTemplate1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserSettings"
        Me.FormTemplate1.ResumeLayout(False)
        Me.FormTemplate1.PerformLayout()
        CType(Me.CircularPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormTemplate1 As CrimCordTheme
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ThemedButton1 As ThemedButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CircularPictureBox1 As CircularPictureBox
End Class
