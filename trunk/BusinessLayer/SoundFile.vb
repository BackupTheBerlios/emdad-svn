''' <summary>
''' SoundFile class is created to create properties for the members of the table Sound in database to retrieve and insert data through this variables in the database.
''' </summary>
''' <remarks></remarks>
Public Class SoundFile
    Private _soundFileId As Guid
    Private _soundFileName As String
    Private _soundX As Byte()
    Private _soundCombination As Integer

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


    Public Property SoundX As Byte()
        Get
            Return _soundX
        End Get
        Set(ByVal value As Byte())
            _soundX = value
        End Set
    End Property
    Public Property FingerCombination As Integer
        Get
            Return _soundCombination
        End Get
        Set(ByVal value As Integer)
            _soundCombination = value
        End Set
    End Property

End Class
