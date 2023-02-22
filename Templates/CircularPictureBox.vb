Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Net

Public Class CircularPictureBox : Inherits PictureBox

    Private WithEvents Client As New WebClient

    Sub SetImage(ByVal url As String)
        Task.Run(Sub() Client.DownloadDataAsync(New Uri(url))) ' This is a hack but without Task.Run, the DownloadDataCompleted handler never runs.
    End Sub

    Private Sub HandleImageBytes(sender As Object, e As DownloadDataCompletedEventArgs) Handles Client.DownloadDataCompleted
        Using Stream As New MemoryStream(e.Result)
            Dim img = Image.FromStream(Stream)
            Dim rounded = New Bitmap(img.Width, img.Height, img.PixelFormat)

            Using g = Graphics.FromImage(rounded)
                Using gp As New GraphicsPath
                    g.Clear(Color.Transparent)
                    g.SmoothingMode = SmoothingMode.AntiAlias
                    Dim brush As New TextureBrush(img)
                    gp.AddEllipse(0, 0, img.Width, img.Height)
                    g.FillPath(brush, gp)
                End Using
            End Using

            Image = rounded
        End Using
    End Sub

    'Protected Overrides Sub OnPaint(e As PaintEventArgs)
    '    'e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear
    '    'e.Graphics.CompositingQuality = CompositingQuality.HighQuality
    '    'e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
    '    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

    '    Using gp As New GraphicsPath()
    '        gp.AddEllipse(0, 0, Width, Height)
    '        e.Graphics.SetClip(gp)
    '    End Using

    '    ' This isn't anti-aliased :/

    '    MyBase.OnPaint(e)
    'End Sub
End Class
