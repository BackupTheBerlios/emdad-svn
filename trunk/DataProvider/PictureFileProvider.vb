Imports BusinessLayer
Imports System.Collections.Generic
Imports System.Data


Public Class PictureFileProvider
    ' Function To retrieve pictures from the table Picture from database

    Public Function GetListofAllPictures() As IList(Of PictureFile)
        GetListofAllPictures = Nothing
        Dim ds As DataSet = SqlConnectionHelper.GetData("Select * from PictureFile")
        If Not SqlConnectionHelper.IsDataSetEmpty(ds) Then
            GetListofAllPictures = New List(Of PictureFile)
            For Each oitem As DataRow In ds.Tables(0).Rows
                Dim oPictureFile As New PictureFile
                If Not IsNothing(oitem.Item(0)) Then oPictureFile.PictureFileId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(1)) Then oPictureFile.PictureFileName = (oitem.Item(1).ToString)
                If Not IsNothing(oitem.Item(2)) Then oPictureFile.PicturePath = oitem.Item(2).ToString
                If Not IsNothing(oitem.Item(3)) Then oPictureFile.PictureImage = oitem.Item(3)
                If Not IsNothing(oitem.Item(4)) Then oPictureFile.FingerCombination = Convert.ToInt32(oitem.Item(4))
                GetListofAllPictures.Add(oPictureFile)
            Next
        End If
    End Function
    'Insert Picture in to the table picture in database

    Public Function SetPicture(ByVal opicObject As PictureFile) As Boolean
        SetPicture = False
        Dim commandText As String = "Insert Into PictureFile(PictureFileId,PictureName,PicturePath,img,FingerCombination) Values(@PictureFileId,@PictureName,@PicturePath,@image,@FingerCombination)"
        Dim com As New SqlClient.SqlCommand(commandText)
        com.Parameters.Add("@PictureFileId", SqlDbType.UniqueIdentifier)
        com.Parameters.Add("@PictureName", SqlDbType.NVarChar, 50)
        com.Parameters.Add("@PicturePath", SqlDbType.NVarChar, 50)
        com.Parameters.Add("@image", SqlDbType.Image)
        com.Parameters.Add("@FingerCombination", SqlDbType.Int, 4)

        com.Parameters("@PictureFileId").Value = opicObject.PictureFileId
        com.Parameters("@PictureName").Value = opicObject.PictureFileName
        com.Parameters("@PicturePath").Value = opicObject.PicturePath
        com.Parameters("@image").Value = opicObject.PictureImage
        com.Parameters("@FingerCombination").Value = opicObject.FingerCombination
        SqlConnectionHelper.SetData(com)
    End Function
End Class
