Public Class CustomCommandsFrm
    ''' <summary>
    ''' Show commandEntryForm is a function to Display CommandEntryForm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
#Region "Events"
    Private Sub AddCommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        ShowCommandEntryForm()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
    End Sub
#End Region


    Private Sub ShowCommandEntryForm()
        Dim frm As New CommandsEntryFrm
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
        End If
        frm = Nothing
    End Sub
    ''' <summary>
    ''' when button Close is Clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class