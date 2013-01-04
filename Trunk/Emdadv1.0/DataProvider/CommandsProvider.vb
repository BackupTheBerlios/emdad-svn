Imports BusinessLayer
Imports System.Collections.Generic
Imports System.Data


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
                If Not IsNothing(oitem.Item(2)) Then oCommands.FingerCombination = Convert.ToInt32(oitem.Item(2).ToString)
                GetListofAllCommands.Add(oCommands)
            Next
        End If
    End Function
End Class
