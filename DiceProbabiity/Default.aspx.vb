Imports DiceLibrary

Public Class _Default
    Inherits System.Web.UI.Page

    Protected m_lstDice As New ArrayList
    Protected m_lstRolling As New ArrayList

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsNothing(Session("Dice")) Then
            m_lstDice = CType(Session("Dice"), ArrayList)
        End If

    End Sub

    Private Sub btnAddDiceToPool_Click(sender As Object, e As EventArgs) Handles btnAddDiceToPool.Click
        Dim clsDice As New CDice(txtNumberOfDice.Text, txtNumberOfDesiredResults.Text, txtNumberOFSides.Text)
        m_lstDice.Add(clsDice)
        m_lstRolling = CDiceProbability.GetRollingProbability(clsDice)
        Session("Dice") = m_lstDice
    End Sub
End Class