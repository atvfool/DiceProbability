Module Module1

    Sub Main()
        Dim intNumberOfSide As Integer = 0
        Dim intNumberOfDice As Integer = 0
        Dim strBuffer As String = String.Empty

        GetInput("Enter Number Of Sides: ", intNumberOfSide)
        GetInput("Enter Number Of Dice: ", intNumberOfDice)

        Console.WriteLine("Dice Mean is " & GetDiceMean(intNumberOfSide))


    End Sub

    Private Sub GetInput(ByRef strPrompt As String, ByRef intReturn As Integer)

        Dim strBuffer As String = String.Empty

        Do

            Console.WriteLine(strPrompt)
            strBuffer = Console.ReadLine

        Loop While Not Integer.TryParse(strBuffer, intReturn)

    End Sub

    Private Function GetDiceMean(ByRef intNumberOfSides As Integer) As Decimal
        Dim decReturn As Decimal = 0.0

        decReturn = (intNumberOfSides + 1) / 2

        Return decReturn
    End Function

End Module
