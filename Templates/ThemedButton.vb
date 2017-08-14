Public Class ThemedButton : Inherits Button

    Sub New()
        With Me
            .BackColor = Color.FromArgb(50, 50, 50)
            .ForeColor = Color.FromArgb(150, 150, 150)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90)
            .FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70)
            .TextAlign = ContentAlignment.MiddleLeft
        End With
    End Sub

End Class
