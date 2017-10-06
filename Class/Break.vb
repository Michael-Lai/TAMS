Public Class Break

    Sub New()
        _BreakOut = Nothing
        _BreakIn = Nothing
    End Sub

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _BreakFrom As Date
    Public Property BreakFrom() As Date
        Get
            Return _BreakFrom
        End Get
        Set(ByVal value As Date)
            _BreakFrom = value
        End Set
    End Property

    Private _BreakTo As Date
    Public Property BreakTo() As Date
        Get
            Return _BreakTo
        End Get
        Set(ByVal value As Date)
            _BreakTo = value
        End Set
    End Property

    Private _BreakHours As String
    Public Property BreakHours() As String
        Get
            Return _BreakHours
        End Get
        Set(ByVal value As String)
            _BreakHours = value
        End Set
    End Property

    Private _BreakOut As Date
    Public Property BreakOut() As Date
        Get
            Return _BreakOut
        End Get
        Set(ByVal value As Date)
            _BreakOut = value
        End Set
    End Property

    Private _BreakIn As Date
    Public Property BreakIn() As Date
        Get
            Return _BreakIn
        End Get
        Set(ByVal value As Date)
            _BreakIn = value
        End Set
    End Property

    Private _TAMSIn As String
    Public Property TAMSIn() As String
        Get
            Return _TAMSIn
        End Get
        Set(ByVal value As String)
            _TAMSIn = value
        End Set
    End Property

    Private _TAMSOut As String
    Public Property TAMSOut() As String
        Get
            Return _TAMSOut
        End Get
        Set(ByVal value As String)
            _TAMSOut = value
        End Set
    End Property

    Private _IsLate As Boolean
    Public Property IsLate() As Boolean
        Get
            Return _IsLate
        End Get
        Set(ByVal value As Boolean)
            _IsLate = value
        End Set
    End Property
End Class
