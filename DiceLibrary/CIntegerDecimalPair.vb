Public Class CIntegerDecimalPair

    Public Property Number As Integer
    Public Property Percentage As Decimal

    Public Sub New(ByRef intNum As Integer, ByRef decPercent As Decimal)
        Number = intNum
        Percentage = decPercent
    End Sub

End Class
