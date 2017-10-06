Public Class Rest

    Property ListRestDetail As New List(Of RestDetail)

    Private _ListRest As New List(Of TimeSpan)
    Property ListRest() As List(Of TimeSpan)
        Get
            Return _ListRest
        End Get
        Set(ByVal value As List(Of TimeSpan))
            _ListRest = value
        End Set
    End Property

    Private _ListRestLate As New List(Of TimeSpan)
    Property ListRestLate() As List(Of TimeSpan)
        Get
            Return _ListRestLate
        End Get
        Set(ByVal value As List(Of TimeSpan))
            _ListRestLate = value
        End Set
    End Property

    Private _ListOTRest As New List(Of TimeSpan)
    Property ListOTRest() As List(Of TimeSpan)
        Get
            Return _ListOTRest
        End Get
        Set(ByVal value As List(Of TimeSpan))
            _ListOTRest = value
        End Set
    End Property

    Private _ListLateType As New List(Of String)
    Property ListLateType() As List(Of String)
        Get
            Return _ListLateType
        End Get
        Set(ByVal value As List(Of String))
            _ListLateType = value
        End Set
    End Property
End Class
