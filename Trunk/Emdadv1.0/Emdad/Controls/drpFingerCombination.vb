''' <summary>
''' usercontrol to display the finger combination in a combobox
''' </summary>
''' <remarks></remarks>
Public Class drpFingerCombination
    ''' <summary>
    ''' populate fingerCombination
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Populate()
        For i As Integer = 1 To 5
            drpFingerCombinationList.Items.Add(i)
        Next
    End Sub

    Private Sub drpFingerCombination_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Populate()
    End Sub
End Class
