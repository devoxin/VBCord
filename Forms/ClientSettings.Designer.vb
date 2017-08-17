<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientSettings
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.FormTemplate1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormTemplate1
        '
        Me.FormTemplate1.AccentColor = System.Drawing.Color.White
        Me.FormTemplate1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FormTemplate1.Controls.Add(Me.CheckBox2)
        Me.FormTemplate1.Controls.Add(Me.CheckBox1)
        Me.FormTemplate1.DisplayClose = True
        Me.FormTemplate1.DisplayTitleBar = True
        Me.FormTemplate1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormTemplate1.Draggable = True
        Me.FormTemplate1.IsDialog = True
        Me.FormTemplate1.Location = New System.Drawing.Point(0, 0)
        Me.FormTemplate1.Name = "FormTemplate1"
        Me.FormTemplate1.Size = New System.Drawing.Size(484, 168)
        Me.FormTemplate1.TabIndex = 0
        Me.FormTemplate1.TitleFont = New System.Drawing.Font("Lato", 10.0!)
        Me.FormTemplate1.TitleText = "Client Settings"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(12, 39)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Display Hidden Channels"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(12, 62)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.Text = "Log Message Deletions"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ClientSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 168)
        Me.Controls.Add(Me.FormTemplate1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ClientSettings"
        Me.FormTemplate1.ResumeLayout(False)
        Me.FormTemplate1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormTemplate1 As CrimCordTheme
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
