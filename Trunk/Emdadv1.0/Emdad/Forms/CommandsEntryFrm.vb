Imports System.IO
Imports BusinessLayer.SoundFile
''' <summary>
''' this form is used to insert the command and sound into the database.
''' </summary>
''' <remarks></remarks>
Public Class CommandsEntryFrm
    Private _filePath As String
    ''' <summary>
    ''' button ok is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If ValidateControl() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK

        End If
    End Sub
    ''' <summary>
    ''' Validate function is used to check whether the datas inserted in to the database are genuine
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidateControl() As Boolean
        ValidateControl = True
        If Len(txtCommands.Text) < 1 Then
            MsgBox("Please enter valid command!")
            txtCommands.Focus()
            ValidateControl = False
            Exit Function
        End If
        If Len(_filePath) < 1 Then
            'ValidateControl = False
            ' Exit Function
        End If
        If DrpFingerCombination1.drpFingerCombinationList.SelectedValue = String.Empty Then
            'ValidateControl = False
            'Exit Function
        End If
    End Function
    ''' <summary>
    ''' Button Cancel Event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    ''' <summary>
    ''' configure Sound
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigureControls()
        BrowseFileCtrl1.FileType = "*.mp3|*.wma|*.amr|*.wav"
        BrowseFileCtrl1.Title = "Select Sound File."
    End Sub
    ''' <summary>
    ''' populate sound and command
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateObject()
        _filePath = BrowseFileCtrl1.FilePath
        If Len(_filePath) > 0 Then
            Try
                Dim fs As New FileStream(_filePath, FileMode.Open, FileAccess.Read)
                Dim oSoundFile As New BusinessLayer.SoundFile
                oSoundFile.soundFileId = Guid.NewGuid()
                oSoundFile.SoundFileName = ""
                oSoundFile.SoundX = ImageToByte(Image.FromStream(fs))
                Dim oCommand As New BusinessLayer.Commands
                oCommand.CommandId = Guid.NewGuid()
                oCommand.CommandText = txtCommands.Text
                oCommand.FingerCombination = DrpFingerCombination1.drpFingerCombinationList.SelectedItem
                fs = Nothing
            Catch ex As Exception

            End Try

        End If
    End Sub
    ''' <summary>
    ''' Load form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CommandEntryFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ConfigureControls()

    End Sub

End Class