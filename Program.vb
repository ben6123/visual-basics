Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Console.WriteLine("input x")
        x = Console.ReadLine()
        Console.WriteLine("input y")
        y = Console.ReadLine()
        Console.WriteLine("input z")
        z = Console.ReadLine()

        If x > y And x > z Then
            Console.WriteLine("" & x)
        ElseIf y > x And y > z Then
            Console.WriteLine("" & y)
        Else
            console.WriteLine("" & z)

        End If


    End Sub
End Module
