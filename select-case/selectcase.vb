Imports System

Module Program
    Sub main()
        Dim t As Integer
        Console.WriteLine("input t")
        t = Console.ReadLine()
        ' A Select Case statement allows a variable to be tested for equality against a list of values. Each value is called a case,
        ' and the variable being switched on is checked for each select case.
        Select Case t
            Case 1
                Console.WriteLine("January")
            Case 2
                Console.WriteLine("Febuary")
            Case 3
                Console.WriteLine("march")
            Case 4
                Console.WriteLine("april")
            Case 5
                Console.WriteLine("may")
            Case 6
                Console.WriteLine("june")
            Case 7
                Console.WriteLine("july")
            Case 8
                Console.WriteLine("august")
            Case 9
                Console.WriteLine("september")
            Case 10
                Console.WriteLine("october")
            Case 11
                Console.Write("november")
            Case 12
                Console.WriteLine("december")
            Case Else
                Console.WriteLine("syntax.error")




        End Select


    End Sub
End Module
