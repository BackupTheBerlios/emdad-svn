Imports System.IO
Imports System.Drawing


''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class PictureFile
    Private _pictureFileId As Guid
    Private _pictureFileName As String
    Private _picturePath As String
    Private _pictureImage As Byte()
    Private _pictureCombination As Integer



    Public Property PictureFileId() As Guid
        Get
            Return _pictureFileId
        End Get
        Set(ByVal value As Guid)
            _pictureFileId = value
        End Set
    End Property


    Public Property PictureFileName() As String
        Get
            Return _pictureFileName
        End Get
        Set(ByVal value As String)
            _pictureFileName = value
        End Set
    End Property


    Public Property PicturePath() As String
        Get
            Return _picturePath

        End Get
        Set(ByVal value As String)
            _picturePath = value
        End Set
    End Property



    Public Property PictureImage() As Byte()
        Get
            Return _pictureImage
        End Get
        Set(ByVal value As Byte())
            _pictureImage = value
        End Set
    End Property



    Public Property FingerCombination() As Integer
        Get
            Return _pictureCombination
        End Get
        Set(ByVal value As Integer)
            _pictureCombination = value
        End Set
    End Property


    Public ReadOnly Property PictureFileImageDrawing() As System.Drawing.Image
        Get
            PictureFileImageDrawing = Nothing
            If Not IsNothing(PictureImage) Then
                Dim imgMemoryStream As MemoryStream = New MemoryStream()
                imgMemoryStream = New MemoryStream(PictureImage, False)
                Return Drawing.Image.FromStream(imgMemoryStream)
            End If

        End Get
    End Property
    Public ReadOnly Property DrawingImage() As System.Drawing.Image
        Get
            If Not IsNothing(PictureImage) Then
                Dim streamBitmap As System.IO.MemoryStream
                streamBitmap = New System.IO.MemoryStream(PictureImage)
                Dim bm As New Bitmap(streamBitmap, False)
                ' If File has been loaded
                If Not bm Is Nothing Then
                    Return bm
                End If
            End If
            Return Nothing
        End Get
    End Property
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReturnImageAsBytes(ByVal fullFileName As String) As Byte()
        Try
            ReturnImageAsBytes = Nothing
            If File.Exists(fullFileName) Then
                Dim ImageFS As New FileStream(fullFileName, FileMode.Open, FileAccess.Read)
                Dim ImageSize As Integer = System.Convert.ToInt32(ImageFS.Length)
                Dim ImageBytes(ImageSize) As Byte
                ImageFS.Read(ImageBytes, 0, ImageSize)
                ImageFS.Close()
                Return ImageBytes
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
