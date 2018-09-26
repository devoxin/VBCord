Imports System.Drawing.Drawing2D

Public Class CircularPictureBox : Inherits PictureBox

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
        e.Graphics.CompositingQuality = CompositingQuality.HighQuality
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using gp As New GraphicsPath()
            gp.AddEllipse(0, 0, Width, Height)
            e.Graphics.SetClip(gp)
        End Using

        ' This isn't anti-aliased :/

        MyBase.OnPaint(e)
    End Sub
End Class
