Public Class ProgressWrapper
    Inherits Object
    Private CurrentObject As Integer = 0
    Private TotalObjects As Integer = 0
    Private StatusMessage As String = ""
    Public ReadOnly Property Total As Integer
        Get
            Return TotalObjects
        End Get
    End Property
    Public Property Current As Integer
        Get
            Return CurrentObject
        End Get
        Set(value As Integer)
            If value > TotalObjects Then
                Throw New ArgumentOutOfRangeException("Current", value, "Property 'Current' cannot exceed value of 'Total' which is " & TotalObjects.ToString)
            ElseIf value < 0 Then
                Throw New ArgumentOutOfRangeException("Current", value, "Property 'Current' cannot be less than 0")
            Else
                CurrentObject = value
            End If
        End Set
    End Property
    Public Property Status As String
        Get
            Return StatusMessage
        End Get
        Set(value As String)
            StatusMessage = value
        End Set
    End Property

    Public Sub New(ByVal Total As Integer)
        TotalObjects = Total
    End Sub
    Public Sub New(ByVal Total As Integer, ByVal Status As String)
        TotalObjects = Total
        StatusMessage = Status
    End Sub
    Public Sub New(ByVal Total As Integer, ByVal Current As Integer)
        TotalObjects = Total
        CurrentObject = Current
    End Sub
    Public Sub New(ByVal Total As Integer, ByVal Current As Integer, ByVal Status As String)
        TotalObjects = Total
        CurrentObject = Current
        StatusMessage = Status
    End Sub
End Class
