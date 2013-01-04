Imports DataProvider
''' <summary>
''' Custom control for Commands 
''' </summary>
''' <remarks></remarks>
Public Class CommandsGrid
    Private _isConfigured As Boolean = False
    ''' <summary>
    ''' Configure grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ConfigureGrid()
        CommandsDataGridView.AutoGenerateColumns = False
        ' add columns to grid
        AddColumns("CommandsFileName", "Commands Name")
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
        CommandsDataGridView.Columns.Add(col)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PopulateGrid()
        If Not _isConfigured Then ConfigureGrid()
        Dim comProvider As New CommandsProvider()

        CommandsDataGridView.DataSource = comProvider.GetListofAllCommands()
    End Sub


End Class
