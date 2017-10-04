Public Class ServerManagement
    Private Sub ThemedButton1_Click(sender As Object, e As EventArgs) Handles ThemedButton1.Click
        HideAllPanels()
        OverviewTab.Visible = True
        DirectCast(sender, ThemedButton).BackColor = Color.FromArgb(60, 60, 60)
    End Sub

    Private Sub HideAllPanels()
        For Each pan As Panel In CrimCordTheme1.Controls.OfType(Of Panel).Where(Function(p) p.Name.EndsWith("Tab"))
            pan.Visible = False
        Next
    End Sub

    Private Sub ResetAllButtons()
        For Each btn As ThemedButton In TabSelectionOptions.Controls.OfType(Of ThemedButton)
            btn.BackColor = Color.FromArgb(70, 70, 70)
        Next
    End Sub
End Class