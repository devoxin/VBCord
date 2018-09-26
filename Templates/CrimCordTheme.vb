Public Class CrimCordTheme : Inherits Panel

    Private WithEvents TitleBar As New Panel
    Private WithEvents TitleLabel As New Label
    Private CloseButton As New ThemedButton
    Private Accent As New Panel

    Private DialogMode = False
    Private AllowDrag = True

    Private MDown As Point

    Sub New()

        With titlebar
            .BackColor = Color.Transparent
            .Dock = DockStyle.Top
            .Height = 27
        End With

        With titlelabel
            .BackColor = Color.Transparent
            .Text = "New Form"
            .Dock = DockStyle.Left
            .ForeColor = Color.White
            .Font = New Font("Open Sans Light", 10)
            .TextAlign = ContentAlignment.MiddleLeft
            .AutoSize = False
            .Padding = New Padding(5, 0, 0, 0)
        End With

        With closebutton
            .BackColor = Color.Transparent
            .BackgroundImage = My.Resources.CloseWhite
            .BackgroundImageLayout = ImageLayout.Zoom
            .Dock = DockStyle.Right
            .Width = 23
        End With


        With accent
            .BackColor = Color.DodgerBlue
            .Dock = DockStyle.Bottom
            .Height = 2
        End With

        TitleBar.Controls.AddRange({TitleLabel, CloseButton, Accent})
        TitleBar.SendToBack()

        With Me
            .BackColor = Color.FromArgb(50, 50, 50)
            .Controls.Add(TitleBar)
            .Dock = DockStyle.Fill
        End With

        AddHandler closebutton.Click, AddressOf CloseClicked

    End Sub

    Private Sub CloseClicked()
        Parent.Dispose()
    End Sub

    Private Sub CrimCordTheme_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, titlebar.MouseDown, titlelabel.MouseDown
        mdown = e.Location
    End Sub

    Private Sub CrimCordTheme_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, titlebar.MouseMove, titlelabel.MouseMove
        If e.Button = MouseButtons.Left AndAlso AllowDrag Then
            Parent.Location += e.Location - mdown
        End If
    End Sub

    Private Sub CrimCordTheme_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        TitleBar.SendToBack()
    End Sub

    Property TitleText As String
        Get
            Return TitleLabel.Text
        End Get
        Set(value As String)
            TitleLabel.Text = value
        End Set
    End Property

    Property TitleFont As Font
        Get
            Return TitleLabel.Font
        End Get
        Set(value As Font)
            TitleLabel.Font = value
        End Set
    End Property

    Property IsDialog As Boolean
        Get
            Return DialogMode
        End Get
        Set(value As Boolean)
            DialogMode = value
            If DialogMode Then
                BackColor = Color.FromArgb(65, 65, 65)
            Else
                BackColor = Color.FromArgb(50, 50, 50)
            End If
        End Set
    End Property

    Property DisplayClose As Boolean
        Get
            Return closebutton.Visible
        End Get
        Set(value As Boolean)
            closebutton.Visible = value
        End Set
    End Property

    Property AccentColor As Color
        Get
            Return accent.BackColor
        End Get
        Set(value As Color)
            accent.BackColor = value
        End Set
    End Property

    Property DisplayTitleBar As Boolean
        Get
            Return titlebar.Visible
        End Get
        Set(value As Boolean)
            titlebar.Visible = value
        End Set
    End Property

    Property Draggable As Boolean
        Get
            Return AllowDrag
        End Get
        Set(value As Boolean)
            AllowDrag = value
        End Set
    End Property

End Class
