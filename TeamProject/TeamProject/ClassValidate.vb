Option Strict On
Imports System.Data
Imports System.Data.SqlClient

Public Class ClassValidate

    'Purpose: Checks Last Name 
    'Arguments: textbox input
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim
    Public Function LastNameVerification(ByVal strInput As String) As String
        If strInput = "" Then
            Return "-999"
        Else
            Return strInput
        End If
    End Function


    'Purpose: Checks First Name
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim
    Public Function FirstNameVerification(ByVal strInput As String) As String
        If strInput = "" Then
            Return "-999"
        Else
            Return strInput
        End If
    End Function

    'Purpose: Checks Initial
    'Arguments: textbox input
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim 
    Public Function IntialVerification(ByVal strInput As String) As String
        If strInput.Length > 1 Then
            Return "-999"
        Else
            Return strInput
        End If
    End Function

    'Purpose: Checks Password 
    'Arguments: textbox input
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim
    Public Function PasswordVerificationLength(ByVal strInput As String) As String

        'Check to see if greater than 6 digits
        If Len(strInput) < 5 And Len(strInput) > 11 Then
            Return "-999"
        Else
            Return strInput
        End If


    End Function

    'Purpose: Checks Password (specific)
    'Arguments: textbox input
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim
    Public Function PasswordVerificationDetailed(ByVal strInput As String) As Boolean
        Dim i As Integer
        Dim strFirstDigit As String
        Dim strFirstDigitCheck As String
        Dim intDigitCount As Integer

        For i = 1 To Len(strInput) - 1
            'get one character from the string
            strFirstDigit = strInput.Substring(i, 1)
            strFirstDigitCheck = strInput.Substring(0, 1)
            Select Case strFirstDigitCheck
                Case "0" To "9"
                    Return False
            End Select
            Select Case strFirstDigit.ToLower
                'if the character is 0-9, then keep going
                Case "0" To "9"
                    intDigitCount += 1
                Case "a" To "z"
                Case Else
                    Return False
            End Select
        Next

        'Was there at least one digit present in the substring

        If intDigitCount > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ''Purpose: Checks input
    ''Arguments: textbox input
    ''Returns: false,  true
    ''Author: Susie Kim

    ''This is different than PasswrodVerificationDetailed in that it doesn't have the digitcount requirement.
    ''This also exculsively checks digits and not letters
    'Public Function CheckDigits(ByVal strInput As String) As Boolean
    '    Dim i As Integer
    '    Dim strFirstDigit As String
    '    Dim strUnformattedIntermediate As String

    '    strUnformattedIntermediate = strInput
    '    'Unformat the data (THIS IS FOR PHONE Number)
    '    'strUnformattedIntermediate = strInput.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "")

    '    For i = 1 To Len(strUnformattedIntermediate) - 1
    '        'get one character from the string
    '        strFirstDigit = strUnformattedIntermediate.Substring(i, 1)
    '        Select Case strFirstDigit.ToLower
    '            'if the character is 0-9, then keep going
    '            Case "0" To "9"
    '            Case Else
    '                Return False
    '        End Select
    '    Next

    '    'If it gets this far, I assume everything is good
    '    Return True
    'End Function

    ''Purpose: Checks that input is all letters
    ''Arguments: textbox input
    ''Returns: false, true
    ''Author: Susie Kim

    'Public Function CheckLetters(ByVal strInput As String) As Boolean
    '    Dim i As Integer
    '    Dim strFirstDigit As String

    '    For i = 1 To Len(strInput) - 1
    '        'get one character from the string
    '        strFirstDigit = strInput.Substring(i, 1)
    '        Select Case strFirstDigit.ToLower
    '            'if the character is a-z, then keep going
    '            Case "a" To "z"
    '            Case Else
    '                Return False
    '        End Select
    '    Next

    '    'If it gets this far, I assume everything is good
    '    Return True
    'End Function

    'Purpose: Checks state
    'Arguments: textbox input
    'Returns: "False" for false, strINput for true
    'Author: Susie Kim

    Public Function StateVerification(ByVal strInput As String) As String

        'Verify Input is only two Characters
        If strInput.Length = 2 Then
            Return strInput
        Else
            If strInput.Length = 0 Then
                Return strInput
            End If
            Return "False"
        End If
    End Function

    'Purpose: Checks zip 
    'Arguments: textbox input
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim

    Public Function ZipCodeVerification(ByVal strInput As String) As String
        If strInput.Length = 0 Then
            Return strInput
        End If

        'Check if Input is 5 characters
        If strInput.Length = 5 Then
            Return strInput
        Else
            'Oh it's not 5, why not 9 digets then
            If strInput.Length = 9 Then
                Return strInput
            Else
                'Return Bad!
                Return "-999"
            End If
        End If
    End Function
    'Purpose: Checks Phone Number to make sure it is appropriate
    'Arguments: textbox input
    'Returns: -999 for false, strINput for true
    'Author: Susie Kim

    Public Function PhoneVerification(ByVal strInput As String) As String
        Dim strUnformattedNumber As String

        strUnformattedNumber = strInput

        strUnformattedNumber = strInput.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "")

        'Check if length is exactly 10 characters long
        If Len(strUnformattedNumber) = 10 Or Len(strUnformattedNumber) = 0 Then
            Return strUnformattedNumber
        Else
            Return "-999"
        End If
    End Function

    Public Function ShowButtonsCombination(ByVal CurrentIndex As Integer, LastSQLIndex As Integer) As Integer
        If CurrentIndex = 0 Then
            'Hide First and Previous Button
            Return 0
        End If
        If CurrentIndex = LastSQLIndex Then
            'Hide Last Button and Next Button
            Return 1
        End If
        'Everything is good!
        Return -999
    End Function


        Public Function CheckBlank(strIn As String) As Boolean
            'check length of phone number
            If strIn.Length = 0 Then
                Return False
            End If
            Return True
        End Function

        Public Function CheckDigits(strIn As String) As Boolean
            'From Page 8
            'check to see that each character is 0-9
            Dim i As Integer
            Dim strOne As String

            For i = 0 To Len(strIn) - 1
                'get one character from the string
                strOne = strIn.Substring(i, 1)
                Select Case strOne
                    'if the character is 0-9, then keep going
                    Case "0" To "9"
                        'if the character is anything else, stop looking and return false
                    Case Else
                        'if bad data, return false
                        Return False
                End Select
            Next

            'if we made it through the loop, return true
            Return True
        End Function

        Public Function CheckLetters(strIn As String) As Boolean
            'From Page 8
            'check to see that each character is a-z
            Dim i As Integer
            Dim strOne As String

            For i = 0 To Len(strIn) - 1
                'get one character from the string
                strOne = strIn.Substring(i, 1)
                Select Case strOne.ToLower
                    'if the character is 0-9, then keep going
                    Case "a" To "z"
                        'if the character is anything else, stop looking and return false
                    Case Else
                        'if bad data, return false
                        Return False
                End Select
            Next

            'if we made it through the loop, return true
            Return True
        End Function

        Public Function CheckDigitsAndLetters(strIn As String) As Boolean
            'From Page 8
            'check to see that each character is 0-9 or a-z
            Dim i As Integer
            Dim strOne As String

            For i = 0 To Len(strIn) - 1
                'get one character from the string
                strOne = strIn.Substring(i, 1)
                Select Case strOne.ToLower
                    'if the character is 0-9, then keep going
                    Case "a" To "z"
                    Case "0" To "9"
                        'if the character is anything else, stop looking and return false
                    Case Else
                        'if bad data, return false
                        Return False
                End Select
            Next

            'if we made it through the loop, return true
            Return True
        End Function


        Public Function CheckState(strIn As String) As Boolean
            'check length of phone number
            If strIn.Length <> 2 Then
                Return False
            End If
            Return True
        End Function

        Public Function CheckMI(strIn As String) As Boolean
            'check length of phone number
            If strIn.Length <> 1 Then
                Return False
            End If
            Return True
        End Function

        Public Function CheckZip(strIn As String) As Boolean
            'purpose: Test zip code for integers
            'arguments: String
            'returns: true/fase
            'author: Jee-Ho Kang
            If strIn.Length = 5 Then
                Return CheckDigits(strIn)
            End If
            Return False
        End Function


        Public Function FormatPhone(strIn As String) As String

            Dim dblPhone As Double
            Dim strResult As String
            dblPhone = Convert.ToDouble(strIn)
            strResult = dblPhone.ToString("(###) ###-####")

            Return strResult
        End Function

        Public Function CheckPhone(strIn As String) As Boolean
            'check length of phone number
            If strIn.Length <> 10 Then
                Return False
            End If

            'check all digits
            If CheckDigits(strIn) = False Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Function CheckPassword(strIn1 As String, strIn2 As String) As Boolean
            'check Password
            If strIn1 <> strIn2 Then
                Return False
            Else
                Return True
            End If
        End Function



    End Class


