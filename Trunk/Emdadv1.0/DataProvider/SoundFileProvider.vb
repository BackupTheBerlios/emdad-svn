Imports BusinessLayer
Imports System.Collections.Generic
Imports System.Data


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
    'Public Function SetSound(ByVal opicObject As SoundFile) As Boolean
    '    SetSound = False
    '    Dim commandText As String = "Insert Into SoundFile(SoundFileId,SoundFileName,SoundX,FingerCombination,IsCustom) Values(@SoundFileId,@SoundFileName,@SoundX,@FingerCombination,@IsCustom)"
    '    Dim com As New SqlClient.SqlCommand(commandText)
    '    com.Parameters.Add("@SoundFileId", SqlDbType.UniqueIdentifier)
    '    com.Parameters.Add("@SoundFileName", SqlDbType.NVarChar, 50)
    '    com.Parameters.Add("@SoundX", SqlDbType.Binary)
    '    com.Parameters.Add("@FingerCombination", SqlDbType.Int)
    '    com.Parameters.Add("@IsCustom", SqlDbType.Bit)

    '    com.Parameters("@SoundFileId").Value = opicObject.SoundFileId
    '    com.Parameters("@SoundFileName").Value = opicObject.SoundFileName
    '    com.Parameters("@SoundX").Value = opicObject.SoundX
    '    com.Parameters("@FingerCombination").Value = 2
    '    com.Parameters("@IsCustom").Value = True
    '    SqlConnectionHelper.SetData(com)
    'End Function
End Class

