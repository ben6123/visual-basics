Imports System

Module Program
    Sub Main(args As String())
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        a = 1011
        b = 1001
        c = a + b

        If (a = b) Then
            Console.WriteLine("hey FRITZ")
        ElseIf (a < b) Then
            Console.WriteLine(c)
        Else
            Console.WriteLine("2 hoursofcode")

        End If
    End Sub
End Module


