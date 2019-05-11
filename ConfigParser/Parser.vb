Imports System.IO

Public Class Parser

    Public ConfigFile As String

    Public Sub New(ByVal ConfigFile As String)
        Me.ConfigFile = ConfigFile
    End Sub

    Public Function ReadConfig(ByVal Param As String)
        Dim TheLine As String

        Using Reader As New StreamReader(ConfigFile)
            While Not Reader.EndOfStream
                Dim Line As String = Reader.ReadLine()
                If Line.Contains(Param) Then
                    TheLine = Line
                End If
            End While
        End Using

        Return TheLine
    End Function

End Class
