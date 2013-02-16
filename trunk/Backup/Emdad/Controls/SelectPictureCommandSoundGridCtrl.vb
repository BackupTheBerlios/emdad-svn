Imports BusinessLayer
Imports DataProvider
Public Class SelectPictureCommandSoundGridCtrl
    Private _isConfigured As Boolean
   

    ''' <summary>
    ''' Configure grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigureGrid()
        dataGrid.AutoGenerateColumns = False
        AddColumns("Commands.CommandText", "Command")
        Dim img As New DataGridViewImageColumn()
        dataGrid.Columns.Add(img)
        img.HeaderText = "Image"
        img.Name = "PictureFile.DrawingImage"
        _isConfigured = True

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="PropertyName"></param>
    ''' <param name="HeaderText"></param>
    ''' <remarks></remarks>
    Private Sub AddColumns(ByVal PropertyName As String, ByVal HeaderText As String)
        Dim col As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        col.DataPropertyName = PropertyName
        col.HeaderText = HeaderText
        ' add custom column to grid
        dataGrid.Columns.Add(col)
    End Sub



    Public Sub PopulateGrid(ByVal fingerCombination As Integer)
        If Not _isConfigured Then ConfigureGrid()
        dataGrid.DataSource = Picture_Commands_SoundProvider.GetListDetailsByFingerCombination(fingerCombination)
    End Sub



    Private Sub SelectPictureCommandSoundGridCtrl_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If Not _isConfigured Then ConfigureGrid()
    End Sub
End Class
