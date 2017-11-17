Imports System.Threading
Imports System.Math

Module Module1
    Public diff As Integer
    Sub Main()
        Dim number As Integer = 0
        Dim answer As String
        Dim one, two, three, upper, lower As Integer

        Console.Write("enter num 1: ")
        one = Console.ReadLine
        ' Console.Write("enter upper limit: ")
        ' upper = Console.ReadLine
        ' Console.Write("enter lower limit: ")
        ' lower = Console.ReadLine
        Console.Write("enter num 2: ")
        two = Console.ReadLine
        Console.Write(
        'number = Console.ReadLine
        'answer = AddTwo(number)
        'answer = SquareIt(number)
        'answer = cubeIt(number)
        'answer = HalfIt(number)
        'answer = negateIt(number
        'answer = PositiveIt(number)
        'answer = SquareRoot(number)
        'answer = IsNegative(number)
        'answer = IsPositive(number)
        'answer = Biggest(one, two)
        'answer = smallest(one, two)
        'answer = SameNumber(one, two)
        'answer = Difference(one, two)
        'answer = WithInTen(one, two)
        'answer = WithinLimit(one, two)
        answer = betweenLimits(one, upper, lower)

        Console.WriteLine(answer)
        Console.ReadKey()
    End Sub

    Function AddTwo(incomingnumber As Integer) As Integer
        Dim x As Integer
        x = incomingnumber + 2
        Return x
    End Function

    Function SquareIt(incomingNumber As Integer) As Integer
        Dim x As Integer
        x = incomingNumber ^ 2
        Return x
    End Function

    Function cubeIt(incomingNumber As Integer) As Integer
        Dim x As Integer
        x = incomingNumber ^ 3
        Return x
    End Function

    Function HalfIt(incomingNumber As Integer) As Integer
        Dim x As Integer
        x = incomingNumber / 2
        Return x
    End Function

    Function NegateIt(TheNumber As Single) As Single
        Dim X As Single
        If TheNumber > -1 Then
            X = TheNumber - 2 * TheNumber
        Else
            Console.WriteLine("The number must be POSITIVE")
            X = 0
        End If
        Return X
    End Function

    Function PositiveIt(TheNumber As Single) As Single
        Dim x As Single
        If TheNumber < 0 Then
            x = TheNumber - 2 * TheNumber
        Else
            Console.WriteLine("The number must be NEGATIVE")
            x = 0
        End If
        Return x
    End Function

    Function SwitchSigns(TheNumber As Single) As Single
        Dim x As Single
        x = TheNumber + -2 * TheNumber
        Return x
    End Function

    Function isZero(incomingNumber As Integer) As Integer
        Dim zero As Integer
        If incomingNumber = 0 Then
            zero = 0
        Else
            zero = 1

        End If
        Return zero
    End Function

    Function SquareRoot(incomingNumber As Single) As Single
        Dim x As Single
        x = Sqrt(incomingNumber)
        Return x
    End Function

    Function IsNegative(TheNumber As Single) As Boolean
        Dim ans As Boolean
        If TheNumber < 0 Then
            ans = True
        End If
        Return ans
    End Function

    Function IsPositive(TheNumber As Single) As Boolean
        Dim X As Boolean
        If TheNumber > -1 Then
            X = True
        End If
        Return X
    End Function

    'chicken pie diagram stuff
    Function Biggest(number1 As Integer, number2 As Integer) As Integer
        If number1 > number2 Then
            Console.Write("the biggest number is: ")
            Return number1
        Else
            Console.Write("the biggest number is: ")
            Return number2
        End If
    End Function

    Function smallest(number1 As Integer, number2 As Integer) As Integer
        If number1 < number2 Then
            Console.Write("the smallest number is: ")
            Return number1
        Else
            Console.Write("the smallest number is: ")
            Return number2
        End If
    End Function

    Function SameNumber(number1 As Integer, number2 As Integer) As Boolean

        If number1 = number2 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function SumOf(number1 As Integer, number2 As Integer) As Integer
        Dim ans As Integer
        ans = number1 + number2
        Return ans

    End Function

    Function Difference(number1 As Integer, number2 As Integer) As Integer
        Dim ans As Integer
        If number1 < number2 Then
            ans = number1 - number2
            diff = ans
            Console.Write("the Difference is: ")

            Return number1
        Else
            ans = number2 - number1
            diff = ans
            Console.Write("the Difference is: ")
            Return number2
        End If
    End Function

    Function WithInTen(number1 As Integer, number2 As Integer) As Boolean
        If diff < 10 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function WithinLimit(number1 As Integer, number2 As Integer) As Boolean
        If number1 < number2 Then
            Return True
        Else
            Return False

        End If

    End Function

    Function betweenLimits(number As Integer, upperLimit As Integer, LowerLimit As Integer) As Boolean
        If number < upperLimit And number > LowerLimit Then
            Return True
        Else
            Return False
        End If
    End Function

    Function count(num1 As Integer, num2 As Integer, num3 As Integer) As Integer


    End Function
End Module
