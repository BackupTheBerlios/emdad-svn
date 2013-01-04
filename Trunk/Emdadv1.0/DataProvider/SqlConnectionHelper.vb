Imports System.Data.SqlClient
Imports System.Data
Public Module SqlConnectionHelper
    Private connection As SqlConnection

    Private Sub ConnectionIntiator()
        Dim connectionString As String
        Try
            connectionString = "Data Source=XTREME\SQLEXPRESS;Initial Catalog=EmdadTest;Integrated Security=True;Pooling=False"
            connection = New SqlConnection(connectionString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Function GetData(ByVal SqlCommandString As String) As DataSet
        GetData = Nothing
        If IsNothing(connection) Then ConnectionIntiator()
        If Not IsNothing(connection) Then
            If Not SqlCommandString = String.Empty Then
                Try
                    connection.Open()
                    Dim sqlc As New SqlCommand
                    Dim sqlDA As New SqlDataAdapter
                    Dim ds As New DataSet
                    sqlc.CommandText = SqlCommandString
                    sqlc.Connection = connection
                    sqlDA.SelectCommand = sqlc
                    sqlDA.Fill(ds)
                    GetData = ds
                    connection.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Function


    Public Function SetData(ByVal SqlInsertString As String) As Boolean
        SetData = False
        If IsNothing(connection) Then ConnectionIntiator()
        If Not IsNothing(connection) Then
            If Not SqlInsertString = String.Empty Then
                Try


                    connection.Open()
                    Dim sqlc As New SqlCommand
                    Dim sqlDA As New SqlDataAdapter
                    sqlc.CommandText = SqlInsertString
                    sqlc.Connection = connection
                    sqlDA.InsertCommand = sqlc
                    sqlDA.InsertCommand.ExecuteNonQuery()

                    connection.Close()
                    SetData = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Function

    Public Function SetData(ByVal sqlCommand As SqlClient.SqlCommand) As Boolean
        SetData = False
        If IsNothing(connection) Then ConnectionIntiator()
        If Not IsNothing(connection) Then
            If Not IsNothing(sqlCommand) Then
                Try


                    connection.Open()

                    Dim sqlDA As New SqlDataAdapter

                    sqlCommand.Connection = connection
                    'sqlDA.InsertCommand = sqlCommand
                    'sqlDA.InsertCommand.ExecuteNonQuery()
                    sqlCommand.ExecuteNonQuery()
                    connection.Close()
                    SetData = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Function
    Public Function IsDataSetEmpty(ByVal ds As DataSet)
        IsDataSetEmpty = True
        If Not IsNothing(ds) Then
            If Not IsNothing(ds.Tables) Then
                If Not IsNothing(ds.Tables(0).Rows) Then
                    If (ds.Tables(0).Rows.Count) > 0 Then
                        IsDataSetEmpty = False
                    End If
                End If
            End If
        End If
    End Function

End Module
