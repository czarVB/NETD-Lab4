Imports Microsoft.VisualBasic

Public Class Vehicle

    Private recent As Boolean
    Private ID As Integer
    Private make As String
    Private model As String
    Private year As Integer
    Private price As Double

    ' Getters for each element
    Public Function getNew() As Boolean
        Return recent
    End Function

    Public Function getID() As Integer
        Return ID
    End Function

    Public Function getMake() As String
        Return make
    End Function

    Public Function getModel() As String
        Return model
    End Function

    Public Function getYear() As Integer
        Return year
    End Function

    Public Function getPrice() As Double
        Return price
    End Function

    ' Setters for each element (Except ID)
    Public Function setNew(ByVal value As Boolean) As Boolean
        recent = value
        Return True
    End Function

    Public Function setMake(ByVal value As String) As Boolean
        make = value
        Return True
    End Function

    Public Function setModel(ByVal value As String) As Boolean
        model = value
        Return True
    End Function

    Public Function setYear(ByVal value As Integer) As Boolean
        year = value
        Return True
    End Function

    Public Function setPrice(ByVal value As Double) As Boolean
        price = value
        Return True
    End Function
End Class
