Public Class ClientSettings

    Private Sub ClientSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckBox1.Checked = Main.DisplayHidden
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Main.DisplayHidden = CheckBox1.Checked
    End Sub

End Class