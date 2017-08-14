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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FormTemplate1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormTemplate1
        '
        Me.FormTemplate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FormTemplate1.Controls.Add(Me.ComboBox1)
        Me.FormTemplate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormTemplate1.IsDialog = True
        Me.FormTemplate1.Location = New System.Drawing.Point(0, 0)
        Me.FormTemplate1.Name = "FormTemplate1"
        Me.FormTemplate1.Size = New System.Drawing.Size(484, 225)
        Me.FormTemplate1.TabIndex = 0
        Me.FormTemplate1.TitleText = "User Settings"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Online", "Idle", "AFK", "Do Not Disturb", "Invisible"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(159, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'UserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 225)
        Me.Controls.Add(Me.FormTemplate1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserSettings"
        Me.FormTemplate1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormTemplate1 As CrimCordTheme
    Friend WithEvents ComboBox1 As ComboBox
End Class
