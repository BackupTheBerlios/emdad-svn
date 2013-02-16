Public Class BrowseFileCtrl
    Private _title As String
    Private _fileType As String
    Private _selectedObject As Object
    Private _fileSize As String
    Private _filePath As String
    'creating properties for the values which areto be inserted in to the database
#Region "Events"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FilePath() As String
        Get
            Return _filePath
        End Get
        Set(ByVal value As String)
            _filePath = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FileType() As String
        Get
            If _fileType = String.Empty Then Return "|*.*"
            Return _fileType
        End Get
        Set(ByVal value As String)
            _fileType = value
        End Set
    End Property


    Public Property FileSize() As String
        Get
            Return _fileSize
        End Get
        Set(ByVal value As String)
            _fileSize = value
        End Set
    End Property
#End Region

#Region "Functions"
    ''' <summary>
    ''' Validate function is used to check whether the datas inserted in to the database are genuine
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ValidateProperties() As Boolean
        ValidateProperties = True
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Function configureOpenDialgoue() As Boolean
        configureOpenDialgoue = False
        fileOpenDialouge.Filter = FileType
        fileOpenDialouge.Title = Title
        If fileOpenDialouge.ShowDialog() = DialogResult.OK Then
            txtPath.Text = fileOpenDialouge.FileName
            FilePath = txtPath.Text
            configureOpenDialgoue = True
        End If
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ReadFile() As Boolean
        ReadFile = False
    End Function
#End Region

#Region "Events"

    Private Sub btnSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If ValidateProperties() Then
            If configureOpenDialgoue() Then
            End If
        End If
    End Sub

#End Region
End Class
