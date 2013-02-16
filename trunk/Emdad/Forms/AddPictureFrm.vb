Imports System.IO
Imports BusinessLayer.PictureFile
Imports DataProvider
''' <summary>
''' This form is used to add picture in to the database
''' </summary>
''' <remarks></remarks>
Public Class AddPictureFrm
    Private _filePath As String
    Private _slash As Integer
    Private _fileName As String
    Private _isCustom As Boolean = False
    Public Property IsCustom As Boolean
        Get
            Return _isCustom
        End Get
        Set(ByVal value As Boolean)
            _isCustom = value
        End Set
    End Property
    Private Sub ConfigureControls()
        BrowseFileCtrl1.FileType = "*.jpeg|*.jpg|*.JPG|*.JPEG"
        BrowseFileCtrl1.Title = "Select Picture File."
    End Sub
    ''' <summary>
    ''' populate control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub PopulateObject()
        _filePath = BrowseFileCtrl1.FilePath
        If Len(_filePath) > 0 Then
            Try
                Dim fs As New FileStream(_filePath, FileMode.Open, FileAccess.Read)
                Dim oPictureFile As New BusinessLayer.PictureFile
                oPictureFile.FingerCombination = DrpFingerCombination1.drpFingerCombinationList.SelectedItem
                oPictureFile.PictureFileId = Guid.NewGuid()
                oPictureFile.PictureFileName = _filePath.Substring(_filePath.LastIndexOf("\") + 1)
                oPictureFile.PictureImage = ImageToByte(Image.FromStream(fs))
                oPictureFile.PicturePath = _filePath
                Dim picprovider As New PictureFileProvider

                If picprovider.SetPicture(oPictureFile) Then
                End If
                fs.Close()
                fs = Nothing
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub FindFileName()
        _slash = _filePath.LastIndexOf("\")
        _fileName = _filePath.Substring(_slash + 1)
    End Sub
    ''' <summary>
    ''' Load Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddPictureFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ConfigureControls()
    End Sub
    ''' <summary>
    ''' Validate function is used to check whether the datas inserted in to the database are genuine
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidateControl() As Boolean
        ValidateControl = True
        If DrpFingerCombination1.drpFingerCombinationList.SelectedValue = String.Empty Then
            ValidateControl = False
            Exit Function
        End If
    End Function

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        PopulateObject()
        If ValidateControl() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class