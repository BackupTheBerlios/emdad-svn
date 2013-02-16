''' <summary>
'''Picture_Command_Sound class is created to create properties for the members of the table Picture_Command_Sound  in database to retrieve and insert data through this variables in the database.
''' </summary>
''' <remarks></remarks>
Public Class Picture_Commands_Sound
    Private _pictureFileId As Guid
    Private _picture_Sound_SoundId As Guid
    Private _commandsId As Guid
    Private _soundFileId As Guid
    Private _SoundFile As SoundFile
    Private _PictureFile As PictureFile
    Private _command As Commands
    Private _fingerCombination As Integer

    Public Property PictureFileId As Guid
        Get
            Return _pictureFileId
        End Get
        Set(ByVal value As Guid)
            _pictureFileId = value
        End Set
    End Property


    Public Property Picture_Commands_SoundId As Guid
        Get
            Return _picture_Sound_SoundId
        End Get
        Set(ByVal value As Guid)
            _picture_Sound_SoundId = value
        End Set
    End Property


    Public Property CommandsId As Guid
        Get
            Return _commandsId

        End Get
        Set(ByVal value As Guid)
            _commandsId = value
        End Set
    End Property



    Public Property SoundFileId As Guid
        Get
            Return _soundFileId
        End Get
        Set(ByVal value As Guid)
            _soundFileId = value
        End Set
    End Property


    Public Property SoundFile As SoundFile
        Get
            Return _SoundFile
        End Get
        Set(ByVal value As SoundFile)
            _SoundFile = value
        End Set
    End Property

    Public Property Command As Commands
        Get
            Return _command
        End Get
        Set(ByVal value As Commands)
            _command = value
        End Set
    End Property


    Public Property PictureFile As PictureFile
        Get
            Return _PictureFile
        End Get
        Set(ByVal value As PictureFile)
            _PictureFile = value
        End Set
    End Property
    Public Property FingerCombination As Integer
        Get
            Return _fingerCombination
        End Get
        Set(ByVal value As Integer)
            _fingerCombination = value
        End Set
    End Property
End Class
