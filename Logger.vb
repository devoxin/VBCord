Imports System.IO

Public Class Logger

    Private writer As StreamWriter

    Sub New()
        writer = New StreamWriter("vbcord-log.txt") With {
            .AutoFlush = True
        }
    End Sub

    Public Sub Log(ByVal level As LogLevel, ByVal content As String)
        Dim currentTime = Date.Now.ToString("dd-MM-yyyy HH:mm")
        Dim lvl = level.ToString().PadRight(5)
        Dim output = $"[{currentTime}] [{lvl}] {content}"

        Console.WriteLine(output)
        writer.WriteLine(output)
    End Sub

    Public Sub Close()
        writer.Flush()
        writer.Close()
    End Sub

    Public Enum LogLevel
        DEBUG
        INFO
        WARN
        FATAL
    End Enum

End Class
