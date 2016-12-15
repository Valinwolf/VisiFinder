Imports System.IO

Public Class ArgumentWrapper
    Inherits Object
    Private MinSimObject As Integer
    Private FileObject As FileInfo()
    Public ReadOnly Property MinSim As Integer
        Get
            Return MinSimObject
        End Get
    End Property
    Public ReadOnly Property Files As FileInfo()
        Get
            Return FileObject
        End Get
    End Property

    Public Sub New(ByVal Files As FileInfo(), ByVal MinSim As Integer)
        FileObject = Files
        MinSimObject = MinSim
    End Sub
End Class
