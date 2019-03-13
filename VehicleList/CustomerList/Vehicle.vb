Option Strict On

Public Class Vehicle

    Private Shared carCount As Integer

    Private recent As Boolean
    Private ID As Integer
    Private maker As String
    Private modelType As String
    Private gen As Integer
    Private cost As Double

    ' Constrcutor
    Public Sub New(n As Boolean, k As String, m As String, y As Integer, p As Double)
        recent = n
        carCount += 1
        ID = carCount
        maker = k
        modelType = m
        gen = y
        cost = p
    End Sub

    ' Getters for each element

    Public Property NewStatus() As Boolean
        Get
            Return recent
        End Get
        Set(ByVal value As Boolean)
            recent = value
        End Set
    End Property

    Public ReadOnly Property Identification() As Integer
        Get
            Return ID
        End Get
    End Property
    Public Property Make() As String
        Get
            Return maker
        End Get
        Set(ByVal value As String)
            maker = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return modelType
        End Get
        Set(ByVal value As String)
            modelType = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return gen
        End Get
        Set(ByVal value As Integer)
            gen = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return cost
        End Get
        Set(ByVal value As Double)
            cost = value
        End Set
    End Property

End Class
