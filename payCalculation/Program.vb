Imports System

Module Program
    Sub Main()
        Dim pay As Double
        Dim hours As Short
        Dim overTime As Short
        Dim response As String
        Console.WriteLine("Pay Calculator")
        Call payRate(pay)
        Call time(hours)
        Console.WriteLine("Did you work overtime this week (y/n):")
        response = Console.ReadLine()
        Select Case response.ToLower
    End Sub

    Function payRate(hourlyRate)
        Console.WriteLine("Please enter your hourly rate in the form [X.YY]: ")
        hourlyRate = Console.ReadLine()
        Return hourlyRate
    End Function

    Function time(hours)
        Console.WriteLine("How many hours have you worked this week: ")
        hours = Console.ReadLine()
        Return hours
    End Function

    Function overT(overTime)
        Console.WriteLine("Please enter how many hours of overtime you did this week: ")
        overTime = Console.ReadLine()
        Return overTime
    End Function
End Module
