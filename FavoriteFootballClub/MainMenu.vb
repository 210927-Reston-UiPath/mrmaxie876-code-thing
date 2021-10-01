Class MainMenu
    Implements Teams
    Sub Start() Implements Teams.Start, Teams.End
        Console.WriteLine("Hello Football Fan, a list of all 20 English Prem League Club is available to view")
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[t] Teams")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "t"
                    'maybe another method to list all teams?
                    AddTeam()
                Case "x"
                    Console.WriteLine("Goodbye")
                    repeat = false
            End Select
        Loop
    End Sub

    Sub AddTeam()
        Console.WriteLine("Team Outside Prem: ")
        dim Teams as string
        Console.WriteLine("League: ")
        dim League as string = Console.ReadLine()

        End Sub




End Class