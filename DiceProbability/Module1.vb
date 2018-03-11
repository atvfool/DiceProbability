Module Module1

    Sub Main()
        Dim intNumberOfSide As Integer = 0
        Dim intNumberOfDice As Integer = 0
        Dim intNumberOfDesiredResults As Integer = 0
        Dim strBuffer As String = String.Empty

        GetInput("Enter Number Of Sides: ", intNumberOfSide)
        GetInput("Enter Number Of Dice: ", intNumberOfDice)
        GetInput("Enter Number Of Desired Results: ", intNumberOfDesiredResults)

        Dim clsDice As New CDice(intNumberOfDice, intNumberOfDesiredResults, intNumberOfSide)

        Console.WriteLine("Dice Mean is " & CDiceProbability.GetDiceMean(clsDice))

        Console.WriteLine("Dice Variance is " & CDiceProbability.GetDiceVariance(clsDice))

        Console.WriteLine("Dice Deciation is " & CDiceProbability.GetDiceStandardDeviation(clsDice))

        Console.WriteLine("Dice Probability: " & CDiceProbability.GetProbability(clsDice))

        Console.ReadKey()

    End Sub

    Private Sub GetInput(ByRef strPrompt As String, ByRef intReturn As Integer)

        Dim strBuffer As String = String.Empty

        Do

            Console.WriteLine(strPrompt)
            strBuffer = Console.ReadLine

        Loop While Not Integer.TryParse(strBuffer, intReturn)

    End Sub

End Module
