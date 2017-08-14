Public Class CrimCordTheme : Inherits Panel

    Private titlelabel As New Label

    Private DialogMode = False

    Sub New()

        Dim titlebar As New Panel With {
            .BackColor = Color.Transparent,
            .Dock = DockStyle.Top,
            .Height = 27
            }

        With titlelabel
            .BackColor = Color.Transparent
            .Text = "New Form"
            .Dock = DockStyle.Left
            .ForeColor = Color.White
            .Font = New Font("Open Sans Light", 9.75)
            .TextAlign = ContentAlignment.MiddleLeft
        End With

        Dim close As New ThemedButton With {
            .BackColor = Color.Transparent,
            .BackgroundImage = My.Resources.CloseWhite,
            .BackgroundImageLayout = ImageLayout.Zoom,
            .Dock = DockStyle.Right,
            .Width = 23
            }

        Dim accent As New Panel With {
            .BackColor = Color.DodgerBlue,
            .Dock = DockStyle.Bottom,
            .Height = 2
            }

        titlebar.Controls.AddRange({titlelabel, close, accent})

        With Me
            .BackColor = Color.FromArgb(50, 50, 50)
            .Controls.Add(titlebar)
        End With

        AddHandler close.Click, AddressOf CloseClicked

    End Sub

    Property TitleText As String
        Get
            Return titlelabel.Text
        End Get
        Set(value As String)
            titlelabel.Text = value
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

    Private Sub CloseClicked()
        Parent.Dispose()
    End Sub

End Class
