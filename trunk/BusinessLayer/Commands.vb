''' <summary>
''' Command class is created to create properties for the members of the table command in database to retrieve and insert data through this variables in the database.
''' </summary>
''' <remarks></remarks>
Public Class Commands
    Private _commandId As Guid
    Private _commandText As String
    Private _fingerCombination As Integer

    Public Property CommandId As Guid
        Get
            Return _commandId
        End Get
        Set(ByVal value As Guid)
            _commandId = value
        End Set
    End Property

    Public Property CommandText As String
        Get
            Return _commandText
        End Get
        Set(ByVal value As String)
            _commandText = value
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
