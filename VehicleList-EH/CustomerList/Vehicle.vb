Option Strict On

Public Class Vehicle

    Private Shared carCount As Integer

    Private newStat As Boolean
    Private ID As Integer
    Private maker As String
    Private modelType As String
    Private gen As String
    Private cost As Double

    ' Constrcutors

    Public Sub New()
        carCount += 1
        ID = carCount
    End Sub
    Public Sub New(n As Boolean, k As String, m As String, y As String, p As Double)
        newStat = n
        maker = k
        modelType = m
        gen = y
        cost = p

        carCount += 1
        ID = carCount
    End Sub

    ' Getters for each element

    Public Property NewStatus() As Boolean
        Get
            Return newStat
        End Get
        Set(ByVal value As Boolean)
            newStat = value
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

    Public Property Year() As String
        Get
            Return gen
        End Get
        Set(ByVal value As String)
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

    Public Function GetCarData() As String

        Dim toReturn As String = ""

        If newStat Then
            toReturn = "A new "
        End If

        Return toReturn + Year + " " + Make + " " + Model + " worth " + cost.ToString

    End Function

End Class
