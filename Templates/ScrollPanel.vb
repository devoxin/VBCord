Public Class CustomPanel
    Inherits Panel

    Protected Overrides Function ScrollToControl(ByVal activeControl As Control) As Point
        Return DisplayRectangle.Location
    End Function

End Class