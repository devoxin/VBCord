Public Class ClientSettings

    Private Sub ClientSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        CheckBox1.Checked = Main.DisplayHidden
        CheckBox2.Checked = Main.LogDeletions
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Main.DisplayHidden = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Main.LogDeletions = CheckBox2.Checked
    End Sub
End Class