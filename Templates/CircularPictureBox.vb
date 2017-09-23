Public Class CircularPictureBox : Inherits PictureBox

    Sub New()

    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)

        'Using bmp As New Bitmap(Width, Height)

        '    Using grp As Graphics = Graphics.FromImage(Image)

        '        grp.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        '        Using tb As New TextureBrush(Image)

        '            tb.TranslateTransform(0, 0)

        '            Using gp As New Drawing2D.GraphicsPath

        '                gp.AddEllipse(0, 0, Width, Height)

        '                grp.FillPath(tb, gp)

        '            End Using

        '        End Using

        '    End Using

        '    Image = bmp

        'End Using

        Using gp = New Drawing2D.GraphicsPath
            gp.AddEllipse(0, 0, Width, Height)
            Region = New Region(gp)
        End Using

        MyBase.OnPaint(pe)

    End Sub

End Class
