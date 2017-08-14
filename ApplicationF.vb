Imports System.Net

Module ApplicationF

    Public Sub CheckForUpdates()

        Try
            Dim version As String = New WebClient().DownloadString(New Uri("https://raw.githubusercontent.com/Devoxin/VBCord/master/version.txt"))
            If version > My.Settings.version Then
                If MsgBox($"Version {version} is available. Open the GitHub Repository?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Process.Start("https://github.com/Devoxin/VBCord/")
                End If
            End If
        Catch
            MsgBox("Failed to retrieve update information", MsgBoxStyle.Exclamation)
        End Try

    End Sub

End Module
