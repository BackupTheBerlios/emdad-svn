Imports System.IO
Imports System.Drawing
Module CommonOperations
    ''' <summary>
    ''' Function ImagetoByte is used to convert a image into byte
    ''' </summary>
    ''' <param name="_image"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ImageToByte(ByVal _image As System.Drawing.Image) As Byte()
        ImageToByte = Nothing
        Dim imgMemoryStream As MemoryStream = New MemoryStream()
        _image.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return imgMemoryStream.GetBuffer()
    End Function

    ''' <summary>
    ''' BytesToImageDsrawing function is the viceversa of ImageToByte function
    ''' </summary>
    ''' <param name="_imageBytes"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function BytesToImageDrawing(ByVal _imageBytes As Byte()) As System.Drawing.Image
        BytesToImageDrawing = Nothing
        Dim imgMemoryStream As MemoryStream = New MemoryStream()
        imgMemoryStream = New MemoryStream(_imageBytes)
        Return Drawing.Image.FromStream(imgMemoryStream)
    End Function
End Module
