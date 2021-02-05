Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Convert and Validate
'

Module ConvertValidate

    Sub Main()

        Dim MyString As String = ""
        Dim MyInteger As Int32 = 0

        'Tell the user to give us a string
        Console.WriteLine("Hello!")
        Console.WriteLine("Please give me a string of numbers to convert into real numbers!")
        MyString = Console.ReadLine()

        'Call funciton and write out the result and our variable
        Console.WriteLine(ConvertValidate.ConvertStringToInteger(MyString, MyInteger))
        Console.WriteLine(MyInteger)


        Console.ReadKey()

    End Sub

    Function ConvertStringToInteger(ByVal ConvertThisString As String, ByRef ToThisInteger As Int32) As String

        Try

            'Try to convert the string to a integer
            ToThisInteger = Convert.ToInt32(ConvertThisString)
            Return "[Success]"

        Catch ex As Exception

            If ConvertThisString = "" Then

                'If string has nothing in it then return empty
                Return "[Error]: Empty"

            Else

                'If a different error occoured it is most likely that the user did not input only numbers
                Return "[Error]: String does not contain only numbers."

            End If

        End Try

    End Function

End Module
