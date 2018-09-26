<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Message
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Message))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EditedIcon = New System.Windows.Forms.PictureBox()
        Me.Timestamp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New CrimsonCord.CircularPictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.EditedIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(461, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Body"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 50)
        Me.Panel1.TabIndex = 3
        '
        'EditedIcon
        '
        Me.EditedIcon.BackgroundImage = CType(resources.GetObject("EditedIcon.BackgroundImage"), System.Drawing.Image)
        Me.EditedIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditedIcon.Dock = System.Windows.Forms.DockStyle.Right
        Me.EditedIcon.Location = New System.Drawing.Point(436, 0)
        Me.EditedIcon.Name = "EditedIcon"
        Me.EditedIcon.Size = New System.Drawing.Size(25, 25)
        Me.EditedIcon.TabIndex = 3
        Me.EditedIcon.TabStop = False
        Me.EditedIcon.Visible = False
        '
        'Timestamp
        '
        Me.Timestamp.Cursor = System.Windows.Forms.Cursors.Default
        Me.Timestamp.Dock = System.Windows.Forms.DockStyle.Left
        Me.Timestamp.Font = New System.Drawing.Font("Open Sans Light", 9.0!)
        Me.Timestamp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Timestamp.Location = New System.Drawing.Point(95, 0)
        Me.Timestamp.Name = "Timestamp"
        Me.Timestamp.Size = New System.Drawing.Size(87, 25)
        Me.Timestamp.TabIndex = 2
        Me.Timestamp.Text = "Today at 00:00"
        Me.Timestamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(40, 50)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Timestamp)
        Me.Panel3.Controls.Add(Me.EditedIcon)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(40, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(461, 25)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(404, 50)
        Me.Name = "Message"
        Me.Size = New System.Drawing.Size(501, 50)
        Me.Panel1.ResumeLayout(False)
        CType(Me.EditedIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timestamp As System.Windows.Forms.Label
    Friend WithEvents EditedIcon As PictureBox
    Friend WithEvents PictureBox1 As CircularPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
