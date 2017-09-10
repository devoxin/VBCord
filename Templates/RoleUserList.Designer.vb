<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoleUserList
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
        Me.RoleName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RoleName
        '
        Me.RoleName.AutoEllipsis = True
        Me.RoleName.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RoleName.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoleName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleName.ForeColor = System.Drawing.Color.White
        Me.RoleName.Location = New System.Drawing.Point(0, 0)
        Me.RoleName.Name = "RoleName"
        Me.RoleName.Size = New System.Drawing.Size(218, 30)
        Me.RoleName.TabIndex = 0
        Me.RoleName.Text = "RoleName"
        Me.RoleName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RoleUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Controls.Add(Me.RoleName)
        Me.Name = "RoleUserList"
        Me.Size = New System.Drawing.Size(218, 45)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RoleName As Label
End Class
