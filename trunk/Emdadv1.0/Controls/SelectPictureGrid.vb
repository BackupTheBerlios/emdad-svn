Imports BusinessLayer
Imports DataProvider
Imports System.Collections.Generic





Public Class SelectPictureGrid
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PopulateGrid()

        Dim picProvider As New PictureFileProvider()

        pictureGrid.DataSource = picProvider.GetListofAllPictures()
        Dim picLIst As IList(Of PictureFile) = picProvider.GetListofAllPictures()

    End Sub

    ''' <summary>
    ''' Populate Grid
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PopulateGrid(ByVal fingerCombination As Integer)

        Dim picProvider As New PictureFileProvider()
        pictureGrid.DataSource = picProvider.GetListofAllPictures().Where(Function(x) x.FingerCombination = fingerCombination).ToList()
    End Sub

End Class
