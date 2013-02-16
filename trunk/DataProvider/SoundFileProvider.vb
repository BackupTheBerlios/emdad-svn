Imports BusinessLayer
Imports System.Collections.Generic
Imports System.Data
'SoundFileProvider class is used to retrieve and insert values in to the table sound in database.
Public Class SoundFileProvider
    Public Function GetListofAllSounds() As IList(Of SoundFile)
        GetListofAllSounds = Nothing
        Dim ds As DataSet = SqlConnectionHelper.GetData("Select * from SoundFile")
        If Not SqlConnectionHelper.IsDataSetEmpty(ds) Then
            GetListofAllSounds = New List(Of SoundFile)
            For Each oitem As DataRow In ds.Tables(0).Rows
                Dim oSoundFile As New SoundFile
                If Not IsNothing(oitem.Item(0)) Then oSoundFile.SoundFileId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(1)) Then oSoundFile.SoundFileName = (oitem.Item(1).ToString)
                If Not IsNothing(oitem.Item(2)) Then oSoundFile.SoundX = oitem.Item(2)
                GetListofAllSounds.Add(oSoundFile)
            Next
        End If
    End Function
    
    'Insert Sound file into database
    Public Function SetSound(ByVal opicObject As SoundFile) As Boolean
        SetSound = False
        Dim commandText As String = "Insert Into SoundFile(SoundFileId,SoundName,SoundX,FingerCombination) Values(@SoundFileId,@SoundName,'@SoundX',@FingerCombination)"
        Dim com As New SqlClient.SqlCommand(commandText)
        com.Parameters.Add("@SoundFileId", SqlDbType.UniqueIdentifier)
        com.Parameters.Add("@SoundName", SqlDbType.NVarChar, 50)
        com.Parameters.Add("@SoundX", SqlDbType.Binary, opicObject.SoundX.Length)
        com.Parameters.Add("@FingerCombination", SqlDbType.Int)
        com.Parameters("@SoundFileId").Value = opicObject.SoundFileId
        com.Parameters("@SoundName").Value = opicObject.SoundFileName
        com.Parameters("@SoundX").Value = opicObject.SoundX
        com.Parameters("@FingerCombination").Value = opicObject.FingerCombination
        SqlConnectionHelper.SetData(com)
    End Function
End Class

