#Region "Imports"
Imports BusinessLayer
#End Region

''' <summary>
'''  Main form
''' </summary>
''' <remarks></remarks>
Public Class frmMain

#Region "Events"
    ''' <summary>
    '''  Form load event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    ''' <summary>
    '''  Button user click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUserLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        PopulateVisibility()

    End Sub
    ''' <summary>
    ''' Button Add pictures event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnViewPictures_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnViewPictures.Click
        PopulateVisibility()
    End Sub
#End Region

#Region "Functions"

    ''' <summary>
    '''  Populate visibility 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateVisibility()
        ' mainSplitter.Visible = True
    End Sub
#End Region
    ''' <summary>
    ''' button Custom pictures Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCustomCommands_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCustomCommands.Click
        Dim frm As New CustomCommandsFrm
        frm.ShowDialog()
        frm = Nothing
    End Sub


    Private Sub btnAddPictures_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddpictures.Click
        Dim frm As New AddPictureFrm
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub btnAddCommands_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddCommands.Click
        Dim frm As New CommandsEntryFrm
        frm.ShowDialog()
        frm = Nothing
    End Sub

    Private Sub btnCombinationDetailList_click(ByVal fingerCombination As Integer)
        ' GeneralViewUserCtrl1.PopulateControlByFingerCombination(fingerCombination)
    End Sub

    Private Sub btnCustomPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomPicture.Click
        Dim frm As New AddPictureFrm
        frm.IsCustom = True
        frm.ShowDialog()
        frm = Nothing
    End Sub
End Class
