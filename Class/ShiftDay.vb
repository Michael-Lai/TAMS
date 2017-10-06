Public Class ShiftDay
    Private _ShiftID As String
    Public Property ShiftID() As String
        Get
            Return _ShiftID
        End Get
        Set(ByVal value As String)
            _ShiftID = value
        End Set
    End Property

    Private _DayID As String
    Public Property DayID() As String
        Get
            Return _DayID
        End Get
        Set(ByVal value As String)
            _DayID = value
        End Set
    End Property

    Private _DayName As String
    Public Property DayName() As String
        Get
            Return _DayName
        End Get
        Set(ByVal value As String)
            _DayName = value
        End Set
    End Property


End Class
