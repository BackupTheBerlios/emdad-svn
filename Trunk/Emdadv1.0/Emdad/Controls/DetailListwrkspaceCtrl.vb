Public Class DetailListwrkspaceCtrl

    Private Sub FingerCombinationListCtrl1_SelectedFingerCombination(ByVal fingerCombination As Integer) Handles FingerCombinationListCtrl1.SelectedFingerCombination
        populatecontrols(fingerCombination)
    End Sub

    Private Sub populatecontrols(ByVal fingercombination As Integer)
        GeneralViewUserCtrl1.PopulateControlByFingerCombination(fingercombination)
        SelectPictureCommandSoundGridCtrl1.PopulateGrid(fingercombination)
    End Sub




End Class
