Imports BusinessLayer
Imports DataProvider

''' <summary>
''' Custom control for picture 
''' </summary>
''' <remarks></remarks>
Public Class SelectPictureGrid
    Private _isConfigured As Boolean = False
    ''' <summary>
    ''' Configure grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigureGrid()
        pictureGrid.AutoGenerateColumns = False
        ' add columns to grid
        'AddColumns("PictureFileName", "Picture Name")
        'AddColumns("PicturePath", "Picture Path")
        _isConfigured = True
        Dim img As New DataGridViewImageColumn()
        'Dim inImg As Image = Image.FromFile("Image Path")
        'img.Image = inImg   
        img.HeaderText = "Image"
        'img.Name = "DrawingImage"
        img.DataPropertyName = "DrawingImage"
        pictureGrid.Columns.Add(img)
    End Sub

    ''' <summary>
    ''' Add Columns in the grid
    ''' </summary>
    ''' <param name="PropertyName"></param>
    ''' <param name="HeaderText"></param>
    ''' <remarks></remarks>
    Private Sub AddColumns(ByVal PropertyName As String, ByVal HeaderText As String)
        Dim col As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        col.DataPropertyName = PropertyName
        col.HeaderText = HeaderText
        ' add custom column to grid
        pictureGrid.Columns.Add(col)
    End Sub
    ''' <summary>
    ''' Populate Grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PopulateGrid()
        If Not _isConfigured Then ConfigureGrid()
        Dim picProvider As New PictureFileProvider()
        pictureGrid.DataSource = picProvider.GetListofAllPictures()
    End Sub
    ''' <summary>
    ''' Populate Grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PopulateGrid(ByVal fingerCombination As Integer)
        If Not _isConfigured Then ConfigureGrid()
        Dim picProvider As New PictureFileProvider()

        pictureGrid.DataSource = picProvider.GetListofAllPictures().Where(Function(x) x.FingerCombination = fingerCombination).ToList()
    End Sub
   

End Class
