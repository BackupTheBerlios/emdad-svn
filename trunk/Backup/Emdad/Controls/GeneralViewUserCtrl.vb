Public Class GeneralViewUserCtrl

    Private Sub GeneralViewUserCtrl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SelectPictureGrid1.PopulateGrid()
    End Sub
    ''' <summary>
    '''  Here you need to populate commands, sounds and picture by finger combination
    ''' 
    ''' </summary>
    ''' <param name="fingerCombination"></param>
    ''' <remarks></remarks>
    Public Sub PopulateControlByFingerCombination(ByVal fingerCombination As Integer)
        SelectPictureGrid1.PopulateGrid(fingerCombination)
        DrpCommandsCtrl1.Populatelistbyfingercombination(fingerCombination)
    End Sub

End Class
