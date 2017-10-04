Public Class ThemedButton : Inherits Button

    Sub New()
        With Me
            .BackColor = Color.FromArgb(50, 50, 50)
            .ForeColor = Color.FromArgb(150, 150, 150)
            .FlatStyle = FlatStyle.Flat
            .Font = New Font("Sansation", 11)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 90, 90)
            .FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70)
        End With
    End Sub

End Class
