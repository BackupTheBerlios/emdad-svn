Imports BusinessLayer
Imports System.Collections.Generic
Imports System.Data
'Command provider is a class which gets all data relating commands from database using objects
Public Class CommandsProvider
    Public Function GetListofAllCommands() As IList(Of Commands)
        GetListofAllCommands = Nothing
        Dim ds As DataSet = SqlConnectionHelper.GetData("Select * from Commands")
        If Not SqlConnectionHelper.IsDataSetEmpty(ds) Then
            GetListofAllCommands = New List(Of Commands)
            For Each oitem As DataRow In ds.Tables(0).Rows
                Dim oCommands As New Commands
                If Not IsNothing(oitem.Item(0)) Then oCommands.CommandId = New Guid(oitem.Item(0).ToString)
                If Not IsNothing(oitem.Item(1)) Then oCommands.CommandText = (oitem.Item(1).ToString)
                GetListofAllCommands.Add(oCommands)
            Next
        End If
    End Function
    'Set Command value function is used to insert value into table commands in database
    Public Function SetCommandValue(ByVal _commandObject As Commands) As Boolean
        SetCommandValue = False
        Dim _com As String = "Insert Into Command Values(" + _commandObject.CommandId.ToString + "," + _commandObject.CommandText + "," + _commandObject.FingerCombination.ToString + ")"
        If SqlConnectionHelper.SetData(_com) Then
            SetCommandValue = True
        End If
    End Function


    Public Function SetCommand(ByVal opicObject As Commands) As Boolean
        SetCommand = False
        Dim commandText As String = "Insert Into Commands(CommandId,CommandText,FingerCombination) Values(@CommandId,@CommandText,@FingerCombination)"
        Dim com As New SqlClient.SqlCommand(commandText)
        com.Parameters.Add("@CommandId", SqlDbType.UniqueIdentifier)
        com.Parameters.Add("@CommandText", SqlDbType.NVarChar, 50)
        com.Parameters.Add("@FingerCombination", SqlDbType.Int)
        com.Parameters("@CommandId").Value = opicObject.CommandId
        com.Parameters("@CommandText").Value = opicObject.CommandText
        com.Parameters("@FingerCombination").Value = opicObject.FingerCombination
        SqlConnectionHelper.SetData(com)
    End Function
End Class