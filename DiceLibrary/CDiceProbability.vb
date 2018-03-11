Public Class CDiceProbability

    Public Shared Function GetDiceMean(ByRef dice As CDice) As Decimal
        Dim decReturn As Decimal = 0.0

        decReturn = (dice.NumberOfSides + 1) / 2

        Return decReturn
    End Function

    Public Shared Function GetDiceVariance(ByRef dice As CDice) As Decimal
        Dim decReturn As Decimal = 0

        decReturn = (dice.NumberOfDice * (Math.Exp(dice.NumberOfSides) - 1)) / 12

        Return decReturn
    End Function

    Public Shared Function GetDiceStandardDeviation(ByRef dice As CDice) As Decimal
        Dim decReturn As Decimal = 0

        decReturn = Math.Sqrt(GetDiceVariance(dice))

        Return decReturn
    End Function

    Public Shared Function GetProbability(ByRef dice As CDice) As Decimal
        Dim decReturn As Decimal = 0

        decReturn = Math.Pow((dice.DesiredResult / dice.NumberOfSides), dice.NumberOfDice)

        Return decReturn
    End Function

    Public Shared Function GetRollingProbability(ByRef dice As CDice) As ArrayList

        Dim lst As New ArrayList
        Dim clsIntDec As CIntegerDecimalPair
        Dim decTemp As Decimal = 0

        For i As Integer = 1 To dice.NumberOfDice

            decTemp = Math.Pow((dice.DesiredResult / dice.NumberOfSides), i)
            clsIntDec = New CIntegerDecimalPair(i, decTemp)
            lst.Add(clsIntDec)

        Next

        Return lst

    End Function
End Class
