Imports BusinessLayer
Imports System.Collections.Generic
Imports System.Data


Public Class Picture_Commands_SoundProvider


    Public Shared Function GetListofAllPicture_Commands_Sound() As IList(Of Picture_Commands_Sound)
        GetListofAllPicture_Commands_Sound = Nothing
        Dim ds As DataSet = SqlConnectionHelper.GetData("Select * from Picture_Commands_Sound")
        If Not SqlConnectionHelper.IsDataSetEmpty(ds) Then
            GetListofAllPicture_Commands_Sound = New List(Of Picture_Commands_Sound)
            For Each oitem As DataRow In ds.Tables(0).Rows
                Dim oPicture_Commands_Sound As New Picture_Commands_Sound
                If Not IsNothing(oitem.Item(0)) Then oPicture_Commands_Sound.Picture_Commands_SoundId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(1)) Then oPicture_Commands_Sound.PictureFileId = New Guid(oitem.Item(1).ToString)
                If Not IsNothing(oitem.Item(2)) Then oPicture_Commands_Sound.CommandsId = New Guid(oitem.Item(2).ToString)
                If Not IsNothing(oitem.Item(3)) Then oPicture_Commands_Sound.SoundFileId = New Guid(oitem.Item(3).ToString)
                GetListofAllPicture_Commands_Sound.Add(oPicture_Commands_Sound)
            Next
        End If
    End Function


    Public Shared Function GetListDetailsByFingerCombination(ByVal fingerCombination As Integer) As IList(Of Picture_Commands_Sound)
        GetListDetailsByFingerCombination = Nothing
        Dim ds As DataSet = SqlConnectionHelper.GetData("Select * from Picture_Command_Sound inner join PictureFile on PictureFile.PictureFileId= Picture_Command_Sound.PictureFileId Inner Join Commands On Commands.CommandsId= Picture_Command_Sound.CommandsId where PictureFile.FingerCombination= 1 AND Commands.FingerCombination = 1")
        If Not SqlConnectionHelper.IsDataSetEmpty(ds) Then
            GetListDetailsByFingerCombination = New List(Of Picture_Commands_Sound)
            For Each oitem As DataRow In ds.Tables(0).Rows
                Dim oPicture_Commands_Sound As New Picture_Commands_Sound
                If Not IsNothing(oitem.Item(0)) Then oPicture_Commands_Sound.Picture_Commands_SoundId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(1)) Then oPicture_Commands_Sound.PictureFileId = New Guid(oitem.Item(1).ToString)
                If Not IsNothing(oitem.Item(2)) Then oPicture_Commands_Sound.CommandsId = New Guid(oitem.Item(2).ToString)
                If Not IsNothing(oitem.Item(3)) Then oPicture_Commands_Sound.SoundFileId = New Guid(oitem.Item(3).ToString)

                Dim oPictureFile As New PictureFile
                If Not IsNothing(oitem.Item(4)) Then oPictureFile.PictureFileId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(5)) Then oPictureFile.PictureFileName = (oitem.Item(1).ToString)
                If Not IsNothing(oitem.Item(6)) Then oPictureFile.PicturePath = oitem.Item(2).ToString
                If Not IsNothing(oitem.Item(7)) Then oPictureFile.PictureImage = oitem.Item(3)
                If Not IsNothing(oitem.Item(8)) Then oPictureFile.FingerCombination = Convert.ToInt32(oitem.Item(4))

                Dim oCommands As New Commands
                If Not IsNothing(oitem.Item(9)) Then oCommands.CommandId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(10)) Then oCommands.CommandText = (oitem.Item(1).ToString)
                If Not IsNothing(oitem.Item(11)) Then oCommands.FingerCombination = Convert.ToInt32(oitem.Item(2).ToString)

                oPicture_Commands_Sound.PictureFile = oPictureFile
                oPicture_Commands_Sound.Command = oCommands
                GetListofAllPicture_Commands_Sound.Add(oPicture_Commands_Sound)
            Next
        End If
    End Function
End Class
