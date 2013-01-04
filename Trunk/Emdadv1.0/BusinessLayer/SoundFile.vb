''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class SoundFile
    Private _soundFileId As Guid
    Private _soundFileName As String
    Private _soundX As Byte()


    Public Property SoundFileId As Guid
        Get
            Return _soundFileId
        End Get
        Set(ByVal value As Guid)
            _soundFileId = value
        End Set
    End Property


    Public Property SoundFileName As String
        Get
            Return _soundFileName
        End Get
        Set(ByVal value As String)
            _soundFileName = value
        End Set
    End Property


    Public Property SoundX() As Byte()
        Get
            Return _soundX
        End Get
        Set(ByVal value As Byte())
            _soundX = value
        End Set
    End Property

End Class
