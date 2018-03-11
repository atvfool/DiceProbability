Public Class CDice
    Public Property NumberOfDice As Integer
    Public Property DesiredResult As Integer
    Public Property NumberOfSides As Integer

    Public Sub New(ByRef intNumDice As Integer, ByRef intDesiredResult As Integer, ByRef intNumSides As Integer)
        NumberOfDice = intNumDice
        DesiredResult = intDesiredResult
        NumberOfSides = intNumSides
    End Sub
End Class
