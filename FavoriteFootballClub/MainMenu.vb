Class MainMenu
    Implements Teams
    Dim clublist as list(of clubs) = new list(of clubs)
    Sub Start() Implements Teams.Start
        Console.WriteLine("Hello Football Fan, a list of all 20 English Prem League Club is available to view")
        ' Dim arsenal as clubs = new clubs()
        ' arsenal.Name = "Arsenal"
        ' clublist.add(arsenal)
        dim repeat as Boolean = true
        Do While repeat
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[t] Teams")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "t"
                ' Private  Function get (Aresenal.clubs, Astonvilla.clubs) As String 
                '  Return 
                     
                '  End Function
                '     Get {Club} = new.clubs; 
                '         Return 
                '     End Get
                    ' don't define a function within a function you'll get an error as well 
                    AddTeam()
                Case "x"
                    Console.WriteLine("Goodbye")
                    repeat = false
            End Select
        Loop
    End Sub

    Sub AddTeam()
        Console.WriteLine("Team Outside Prem: ")
        dim Teams as string = Console.ReadLine()
        Console.WriteLine("League: ")
        dim League as string = Console.ReadLine()

        End Sub




End Class