''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class Picture_Commands_Sound
    Private _pictureFileId As Guid
    Private _picture_Sound_SoundId As Guid
    Private _commandsId As Guid
    Private _soundFileId As Guid
    Private _soundfile As SoundFile
    Private _pictureFile As PictureFile
    Private _command As Commands
    Public Property PictureFileId() As Guid
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



    Public Property SoundFile() As SoundFile
        Get
            Return _soundfile
        End Get
        Set(ByVal value As SoundFile)
            _soundfile = value
        End Set
    End Property


    Public Property PictureFile() As PictureFile
        Get
            Return _pictureFile
        End Get
        Set(ByVal value As PictureFile)
            _pictureFile = value
        End Set
    End Property

    Public Property Command() As Commands
        Get
            Return _command
        End Get
        Set(ByVal value As Commands)
            _command = value
        End Set
    End Property
End Class
