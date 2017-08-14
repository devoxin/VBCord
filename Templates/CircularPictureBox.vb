Public Class CircularPictureBox : Inherits PictureBox

    Sub New()

    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)

        Using gp = New Drawing2D.GraphicsPath
            gp.AddEllipse(0, 0, Width - 1, Height - 1)
            Region = New Region(gp)
        End Using

        MyBase.OnPaint(pe)

    End Sub

End Class
