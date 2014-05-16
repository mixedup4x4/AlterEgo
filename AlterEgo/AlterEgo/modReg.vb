Imports AlterEgo.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class modReg
        ' Methods
        Private Shared Sub CheckLicense(ByVal klajdfhnvhfywstgajbgqayndjakasi As String)
            modReg.subEncode1(klajdfhnvhfywstgajbgqayndjakasi)
            modReg.subEncode2
            modReg.subEncode3
            modReg.subEncode4
            modReg.subEncode5
        End Sub

        Friend Shared Function Encrypt(ByVal PaSSed As String) As Integer
            Dim num As Integer
            Select Case PaSSed
                Case "A"
                    Return &H1B
                Case "B"
                    Return &H1C
                Case "C"
                    Return &H1D
                Case "D"
                    Return 30
                Case "E"
                    Return &H1F
                Case "F"
                    Return &H20
                Case "G"
                    Return &H21
                Case "H"
                    Return &H22
                Case "I"
                    Return &H23
                Case "J"
                    Return &H24
                Case "K"
                    Return &H25
                Case "L"
                    Return &H26
                Case "M"
                    Return &H27
                Case "N"
                    Return 40
                Case "O"
                    Return &H29
                Case "P"
                    Return &H2A
                Case "Q"
                    Return &H2B
                Case "R"
                    Return &H2C
                Case "S"
                    Return &H2D
                Case "T"
                    Return &H2E
                Case "U"
                    Return &H2F
                Case "V"
                    Return &H30
                Case "W"
                    Return &H31
                Case "X"
                    Return 50
                Case "Y"
                    Return &H33
                Case "Z"
                    Return &H34
                Case "a"
                    Return 1
                Case "b"
                    Return 2
                Case "c"
                    Return 3
                Case "d"
                    Return 4
                Case "e"
                    Return 5
                Case "f"
                    Return 6
                Case "g"
                    Return 7
                Case "h"
                    Return 8
                Case "i"
                    Return 9
                Case "j"
                    Return 10
                Case "k"
                    Return 11
                Case "l"
                    Return 12
                Case "m"
                    Return 13
                Case "n"
                    Return 14
                Case "o"
                    Return 15
                Case "p"
                    Return &H10
                Case "q"
                    Return &H11
                Case "r"
                    Return &H12
                Case "s"
                    Return &H13
                Case "t"
                    Return 20
                Case "u"
                    Return &H15
                Case "v"
                    Return &H16
                Case "w"
                    Return &H17
                Case "x"
                    Return &H18
                Case "y"
                    Return &H19
                Case "z"
                    Return &H1A
                Case "-"
                    Return &H63
                Case "1"
                    Return &H62
                Case "2"
                    Return &H61
                Case "3"
                    Return &H61
                Case "4"
                    Return &H5F
                Case "5"
                    Return &H5E
                Case "6"
                    Return &H5D
                Case "7"
                    Return &H5C
                Case "8"
                    Return &H5B
                Case "9"
                    Return 90
                Case "0"
                    Return &H59
                Case "_"
                    Return &H58
                Case "!"
                    Return &H57
                Case "@"
                    Return &H56
                Case "#"
                    Return &H55
                Case "$"
                    Return &H54
                Case "%"
                    Return &H53
                Case "^"
                    Return &H52
                Case "&"
                    Return &H51
                Case "*"
                    Return 80
                Case "("
                    Return &H4F
                Case ")"
                    Return &H4E
                Case "|"
                    Return &H4D
            End Select
            Return num
        End Function

        Private Shared Sub subEncode1(ByVal cn As String)
            Dim num As Integer = 0
            Do
                cn = (cn & "@%$%!*))&%" & cn)
                num += 1
            Loop While (num <= &H10)
            cn = cn.Substring(0, &H20)
            cn = (cn & cn & cn & cn)
            Dim num10 As Integer = (cn.Length - 1)
            Dim i As Integer = 0
            Do While (i <= num10)
                modReg.s(i) = cn.Substring(i, 1)
                modReg.s(i) = modReg.s(i)
                modReg.strTemp(i) = Conversions.ToString(modReg.Encrypt(modReg.s(i)))
                i += 1
            Loop
            Dim index As Integer = 0
            Do
                If (Conversions.ToDouble(modReg.strTemp(index)) = 0) Then
                    modReg.strTemp(index) = Conversions.ToString(&H345)
                End If
                modReg.strTemp(index) = Conversions.ToString(Convert.ToInt32(CDbl((Conversions.ToDouble(modReg.strTemp(index)) * 15))))
                modReg.strTemp(index) = Conversions.ToString(Convert.ToInt32(CDbl((Conversions.ToDouble(modReg.strTemp(index)) * 3.1415927))))
                modReg.strTemp(index) = Conversions.ToString(Conversion.Int(Convert.ToInt32(CDbl((Conversions.ToDouble(modReg.strTemp(index)) * 1.7987656)))))
                If (modReg.strTemp(index).Length < 8) Then
                    modReg.strTemp(index) = Conversions.ToString(Conversion.Int(CDbl((Convert.ToInt32(modReg.strTemp(index)) * 122.2112))))
                End If
                modReg.strTemp(index) = (modReg.strTemp(index) & modReg.strTemp(index))
                modReg.strTemp(index) = modReg.strTemp(index).Substring(0, 8)
                index += 1
            Loop While (index <= &H7F)
            Dim num4 As Integer = 0
            Do
                If (Strings.StrComp(modReg.strTemp(num4), modReg.strTemp((num4 + 1)), CompareMethod.Text) = 0) Then
                    modReg.strTemp((num4 + 1)) = Conversions.ToString(Conversion.Int(CDbl((Convert.ToInt32(modReg.strTemp((num4 + 1))) * 1.43235566))))
                    modReg.strTemp((num4 + 1)) = modReg.strTemp(num4).Substring(0, 8)
                End If
                num4 += 1
            Loop While (num4 <= &H7F)
            Dim num5 As Integer = 0
            Do
                Dim num6 As Integer = 0
                Do
                    modReg.plpokpol(num6) = modReg.strTemp(num5).Substring(num6, 1)
                    num6 += 1
                Loop While (num6 <= 7)
                modReg.strTemp(num5) = String.Concat(New String() { modReg.strTemp(num5), modReg.plpokpol(7), modReg.plpokpol(6), modReg.plpokpol(5), modReg.plpokpol(4), modReg.plpokpol(3), modReg.plpokpol(2), modReg.plpokpol(1), modReg.plpokpol(0) })
                num5 += 1
            Loop While (num5 <= &H7F)
            Dim num7 As Integer = 0
            Do
                Dim num8 As Integer = 0
                Do
                    modReg.pledjcmvhg3472(num8) = modReg.strTemp(num7).Substring(num8, 1)
                    num8 += 1
                Loop While (num8 <= 15)
                Dim str As String = ""
                Dim num9 As Short = 15
                Do
                    str = (str & modReg.pledjcmvhg3472(num9))
                    num9 = CShort((num9 + -1))
                Loop While (num9 >= 0)
                modReg.strTemp(num7) = (modReg.strTemp((num7 + 1)) & str)
                num7 += 1
            Loop While (num7 <= &H7F)
        End Sub

        Private Shared Sub subEncode2()
            Dim index As Integer = 0
            Do
                Dim num2 As Integer = 0
                Do
                    modReg.qzx876rty356qw5(num2) = modReg.strTemp(index).Substring(num2, 2)
                    modReg.qzx876rty356qw5(num2) = modReg.qzx876rty356qw5(num2).Substring(0, 2)
                    num2 += 1
                Loop While (num2 <= 8)
                index += 1
            Loop While (index <= &H7F)
            Dim num3 As Integer = 0
            Do
                Dim num4 As Integer = 0
                Do
                    modReg.qzx876rty356qw5(num4) = modReg.strTemp(num3).Substring(num4, 2)
                    num4 += 1
                Loop While (num4 <= 8)
                modReg.strTemp(num3) = String.Concat(New String() { modReg.strTemp(num3), modReg.qzx876rty356qw5(3), modReg.qzx876rty356qw5(5), modReg.qzx876rty356qw5(2), modReg.qzx876rty356qw5(1), modReg.qzx876rty356qw5(8) })
                num3 += 1
            Loop While (num3 <= &H7F)
        End Sub

        Private Shared Sub subEncode3()
            Dim index As Integer = 0
            Do
                Dim num2 As Integer = 0
                Do
                    If (Strings.StrComp(modReg.strTemp(index), modReg.strTemp(num2), CompareMethod.Text) = 0) Then
                        Dim str As String = modReg.strTemp(index).Substring(0, 8)
                        Dim str4 As String = modReg.strTemp(index).Substring(7, 8)
                        Dim str3 As String = str.Substring(3, 4)
                        str = str.Substring(0, 4)
                        Dim str2 As String = str4.Substring(3, 4)
                        str2 = Conversions.ToString(Conversion.Int(CDbl((Convert.ToInt64(str.Substring(0, 4)) * 72.278965))))
                        str = Conversions.ToString(Conversion.Int(CDbl((Convert.ToInt64(str2) * 91.789327))))
                        str3 = Conversions.ToString(Conversion.Int(CDbl((Convert.ToInt64(str4) * 43.8712456))))
                        str4 = Conversions.ToString(Conversion.Int(CDbl((Convert.ToInt64(str3) * 66.456))))
                        modReg.strTemp(index) = (str & str3 & str4 & str2)
                        modReg.strTemp(index) = String.Concat(New String() { modReg.strTemp(index), str2, str4, str2, str4, str, str3 })
                        modReg.strTemp(index) = modReg.strTemp(index).Substring(0, &H40)
                    End If
                    num2 += 1
                Loop While (num2 <= &H7F)
                index += 1
            Loop While (index <= &H7F)
        End Sub

        Private Shared Sub subEncode4()
            Dim index As Integer = 0
            Do
                modReg.strTemp(index) = (modReg.strTemp(index) & modReg.strTemp((index + 1)))
                index += 1
            Loop While (index <= &H7F)
            Dim num2 As Integer = 0
            Do
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("10", "1@")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("98", "l?")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("23", "#p")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("00", "):")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("65", "æÆ")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("21", ",ÿ")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("27", "|ÿ")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("18", "y%")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("91", "4#")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("29", "!;")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("53", "m~")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("04", "@")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("90", "~")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("55", "~]")
                modReg.strTemp(num2) = modReg.strTemp(num2).Replace("76", "{=")
                num2 = (num2 + 2)
            Loop While (num2 <= &H7F)
        End Sub

        Private Shared Sub subEncode5()
            Dim index As Integer = 0
            Do
                modReg.strTemp(index) = modReg.strTemp(index).Replace("~", "*&")
                modReg.strTemp(index) = modReg.strTemp(index).Replace(")", "$%")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("@", "@$")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("$", "):")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("5", "!!")
                modReg.strTemp(index) = modReg.strTemp(index).Replace(",", "*!*")
                modReg.strTemp(index) = modReg.strTemp(index).Replace(":", "as")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("88", "<>")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("98", "-+")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("15", "}5")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("106", "&3$345")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("43", "}{")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("90", "@7q")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("535", "~123]")
                modReg.strTemp(index) = modReg.strTemp(index).Replace("7", "{=1f")
                modReg.strTemp(index) = modReg.strTemp(index).Substring(0, &H80)
                index = (index + 3)
            Loop While (index <= &H7F)
        End Sub

        Private Shared Sub subImportLicFile()
            Dim reader As New StreamReader((Application.StartupPath & modReg.licFileName))
            Dim str As String = reader.ReadLine
            Dim num2 As Integer = modReg.max1
            Dim i As Integer = 0
            Do While (i <= num2)
                modReg.strLicFile(i) = reader.ReadLine
                i += 1
            Loop
            reader.Close
        End Sub

        Private Shared Sub subSetFlag()
            modReg.isGood = True
            Dim num2 As Integer = modReg.max1
            Dim i As Integer = 0
            Do While (i <= num2)
                If (Strings.StrComp(modReg.allLicense(i), modReg.strLicFile(i), CompareMethod.Binary) <> 0) Then
                    modReg.isGood = False
                    Return
                End If
                i += 1
            Loop
        End Sub

        Friend Shared Sub subStartHereToCheckRegistration()
            modReg.CNX = Environment.MachineName
            modReg.un = MySettingsProperty.Settings.UserStringToRegister
            modReg.CheckLicense(modReg.CNX)
            Dim index As Integer = 0
            Do
                modReg.allLicense(index) = modReg.strTemp(index)
                index += 1
            Loop While (index <= &H7F)
            modReg.CheckLicense(modReg.un)
            Dim num As Integer = 0
            Dim num4 As Integer = modReg.max1
            Dim i As Integer = &H80
            Do While (i <= num4)
                modReg.allLicense(i) = modReg.strTemp(num)
                num += 1
                i += 1
            Loop
            modReg.subImportLicFile
            modReg.subSetFlag
            If modReg.isGood Then
                modMain.Registered = True
            Else
                Interaction.MsgBox(("You have " & Conversions.ToString(CDbl(((CDbl(MyProject.Forms.frmTreeMenu.tmrDemo.Interval) / 1000) / 60))) & " minutes"), MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End Sub


        ' Fields
        Private Shared allLicense As String() = New String((modReg.max1 + 1)  - 1) {}
        Private Shared asdecsfsa As String() = New String(&H21  - 1) {}
        Private Shared CN As String
        Private Shared CNX As String
        Private Shared isGood As Boolean
        Private Shared key As String
        Private Shared licFileName As String = "\AE2License.licx"
        Private Shared max1 As Integer = &H100
        Private Shared pledjcmvhg3472 As String() = New String(&H21  - 1) {}
        Private Shared plpokpol As String() = New String(&H21  - 1) {}
        Private Shared qzx876rty356qw5 As String() = New String(&H21  - 1) {}
        Private Shared s As String() = New String(&H401  - 1) {}
        Private Shared strLicFile As String() = New String((modReg.max1 + 1)  - 1) {}
        Private Shared strPC As String() = New String((modReg.max1 + 1)  - 1) {}
        Private Shared strTemp As String() = New String((modReg.max1 + 1)  - 1) {}
        Private Shared un As String
        Friend Shared w As StreamWriter
    End Class
End Namespace

