Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Runtime.CompilerServices

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class fnChangeLocalAdmin
        ' Methods
        Friend Shared Function fnCreateNewAccount(ByVal mach As String, ByVal AdminName As String, ByVal pass As String) As Boolean
            Try 
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.GetObject(("WinNT://" & mach & ""), Nothing))
                Dim instance As Object = RuntimeHelpers.GetObjectValue(Interaction.GetObject(("WinNT://" & mach & "/administrators"), Nothing))
                Dim arguments As Object() = New Object() { "user", AdminName }
                Dim copyBack As Boolean() = New Boolean() { False, True }
                If copyBack(1) Then
                    AdminName = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(1)), GetType(String)))
                End If
                Dim obj4 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "create", arguments, Nothing, Nothing, copyBack))
                NewLateBinding.LateCall(obj4, Nothing, "setPassword", New Object() { "RanDomJUNKPw$#1234$" }, Nothing, Nothing, Nothing, True)
                NewLateBinding.LateCall(obj4, Nothing, "setInfo", New Object(0  - 1) {}, Nothing, Nothing, Nothing, True)
                arguments = New Object(1  - 1) {}
                Dim obj5 As Object = obj4
                arguments(0) = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, Nothing, "adspath", New Object(0  - 1) {}, Nothing, Nothing, Nothing))
                Dim objArray As Object() = arguments
                copyBack = New Boolean() { True }
                NewLateBinding.LateCall(instance, Nothing, "add", objArray, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    NewLateBinding.LateSetComplex(obj5, Nothing, "adspath", New Object() { RuntimeHelpers.GetObjectValue(objArray(0)) }, Nothing, Nothing, True, False)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                If (Strings.InStr(exception.ToString, "The account already exists", CompareMethod.Text) <> 0) Then
                    If (Conversions.ToString(CInt(Interaction.MsgBox(("Account already exists on " & mach & "!!" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & "Do you wish to reset this password?"), MsgBoxStyle.YesNo, "Account Already Exists?"))).ToString = "6") Then
                        fnChangeLocalAdmin.fnResetPassword(mach, AdminName, pass)
                    End If
                Else
                    Interaction.MsgBox(exception.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                End If
                ProjectData.ClearProjectError
                Return False
            End Try
            Return True
        End Function

        Friend Shared Function fnResetPassword(ByVal mach As String, ByVal AdminName As String, ByVal PassWord As String) As Boolean
            Try 
                Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.GetObject(("WinNT://" & mach & "/" & AdminName), Nothing))
                Dim arguments As Object() = New Object() { PassWord }
                Dim copyBack As Boolean() = New Boolean() { True }
                NewLateBinding.LateCall(objectValue, Nothing, "setPassword", arguments, Nothing, Nothing, copyBack, True)
                If copyBack(0) Then
                    PassWord = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(String)))
                End If
                Dim obj2 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "get", New Object() { "Userflags" }, Nothing, Nothing, Nothing))
                NewLateBinding.LateCall(objectValue, Nothing, "setInfo", New Object(0  - 1) {}, Nothing, Nothing, Nothing, True)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.MsgBox(("User Account Doesn't Exist on " & mach), MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
                Return False
            End Try
            Return True
        End Function


        ' Fields
        Friend Shared StringBLDROutput As String
    End Class
End Namespace

