Public Class TextAndValueInCombo
    Public DisplayText As String
    Public ItemValue As String
    Public Sub New(ByVal NewItemValue As String, ByVal NewDisplayText As String)
        DisplayText = NewDisplayText
        ItemValue = NewItemValue
    End Sub
    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class
