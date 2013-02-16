Public Class FingerCombinationListCtrl
    Public Event SelectedFingerCombination(ByVal fingerCombination As Integer)
    Private Sub btnCombination1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCombination1.Click
        RaiseEvent SelectedFingerCombination(1)
    End Sub

    Private Sub btnCombination2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCombination2.Click
        RaiseEvent SelectedFingerCombination(2)
    End Sub

    Private Sub btnCombination3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCombination3.Click
        RaiseEvent SelectedFingerCombination(3)
    End Sub

    Private Sub btnCombination4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCombination4.Click
        RaiseEvent SelectedFingerCombination(4)
    End Sub
End Class
