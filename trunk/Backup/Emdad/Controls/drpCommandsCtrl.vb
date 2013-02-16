Imports BusinessLayer
Imports DataProvider
''' <summary>
''' 
''' drpCommandCtrl usercontrol is used to get retrieve the command table values from database and display it in the combobox
''' </summary>
''' <remarks></remarks>
Public Class drpCommandsCtrl

    ''' <summary>
    '''  Populate drop down 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PopulateControl()
        Dim comProvider As New CommandsProvider
        drpCommands.DataSource = comProvider.GetListofAllCommands()
        drpCommands.ValueMember = "CommandId"
        drpCommands.DisplayMember = "CommandText"
    End Sub
    ''' <summary>
    ''' load drpcommandCtrl 
    ''' </summary>
    Private Sub drpCommandsCtrl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'PopulateControl()
    End Sub

    ''' <summary>
    '''  Populate drop down 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Populatelistbyfingercombination(ByVal fc As Integer)
        Dim comProvider As New CommandsProvider
        Dim lst As IList(Of Commands) = comProvider.GetListofAllCommands()
        If Not IsNothing(lst) Then
            drpCommands.DataSource = lst.Where(Function(x) x.FingerCombination = fc)
            drpCommands.ValueMember = "CommandId"
            drpCommands.DisplayMember = "CommandText"
        Else
            drpCommands.DataSource = Nothing
        End If
       
    End Sub
End Class
