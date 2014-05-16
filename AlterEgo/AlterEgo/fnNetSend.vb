Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Management
Imports System.Windows.Forms

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class fnNetSend
        ' Methods
        Friend Shared Function fnNetSend(ByVal strRemoteComputer As String, ByVal strMessage As String) As String
            Dim query As New ObjectQuery("SELECT * FROM Win32_Service where name='Messenger'")
            Dim scope2 As New ManagementScope(("\\" & strRemoteComputer & "\root\CIMV2"))
            Dim scope As New ManagementScope("\\.\root\CIMV2")
            Dim num4 As Integer = 0
            Dim num6 As Integer = 0
            Dim num5 As Integer = 0
            Dim num7 As Integer = 0
            Dim num2 As Integer = 0
            Dim num3 As Integer = 0
            Try 
                Do While ((num2 = 0) Or (num3 = 0))
                    Try 
                        If (num3 = 0) Then
                            Dim searcher As New ManagementObjectSearcher(scope2, query)
                            Dim obj2 As New ManagementObject(scope2, New ManagementPath("Win32_Service.Name='Messenger'"), Nothing)
                            Dim methodParameters As ManagementBaseObject = obj2.GetMethodParameters("ChangeStartMode")
                            Dim obj4 As ManagementObject
                            For Each obj4 In searcher.Get
                                If Operators.ConditionalCompareObjectNotEqual(obj4.Item("State"), "Running", False) Then
                                    If (num5 = 0) Then
                                        num3 = 0
                                        methodParameters.Item("StartMode") = "Manual"
                                        Dim obj5 As ManagementBaseObject = obj2.InvokeMethod("ChangeStartMode", methodParameters, Nothing)
                                        Dim obj6 As ManagementBaseObject = obj2.InvokeMethod("StartService", Nothing, Nothing)
                                        num5 = 1
                                    End If
                                Else
                                    num3 = 1
                                End If
                            Next
                        End If
                        If (num2 = 0) Then
                            Dim searcher2 As New ManagementObjectSearcher(scope, query)
                            Dim obj7 As New ManagementObject(scope, New ManagementPath("Win32_Service.Name='Messenger'"), Nothing)
                            Dim inParameters As ManagementBaseObject = obj7.GetMethodParameters("ChangeStartMode")
                            Dim obj9 As ManagementObject
                            For Each obj9 In searcher2.Get
                                If Operators.ConditionalCompareObjectNotEqual(obj9.Item("State"), "Running", False) Then
                                    If (num4 = 0) Then
                                        num2 = 0
                                        inParameters.Item("StartMode") = "Manual"
                                        Dim obj10 As ManagementBaseObject = obj7.InvokeMethod("ChangeStartMode", inParameters, Nothing)
                                        Dim obj11 As ManagementBaseObject = obj7.InvokeMethod("StartService", Nothing, Nothing)
                                        num4 = 1
                                    End If
                                Else
                                    num2 = 1
                                End If
                            Next
                        End If
                        Continue Do
                    Catch exception1 As ManagementException
                        ProjectData.SetProjectError(exception1)
                        Dim exception As ManagementException = exception1
                        MessageBox.Show(("An error occurred while querying for WMI data: " & exception.Message))
                        ProjectData.ClearProjectError
                        Continue Do
                    Catch exception8 As UnauthorizedAccessException
                        ProjectData.SetProjectError(exception8)
                        Dim exception2 As UnauthorizedAccessException = exception8
                        MessageBox.Show(("Connection error): " & exception2.Message))
                        ProjectData.ClearProjectError
                        Continue Do
                    End Try
                Loop
            Catch exception9 As Exception
                ProjectData.SetProjectError(exception9)
                Interaction.MsgBox(exception9.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
            Try 
                Interaction.Shell(("cmd.exe /k net send " & strRemoteComputer & " " & strMessage), AppWinStyle.Hide, True, &H1388)
                Interaction.Shell(String.Concat(New String() { "cmd.exe /k net send ", Environment.MachineName, " ", strMessage, " Was Sent" }), AppWinStyle.Hide, True, &H1388)
            Catch exception10 As Exception
                ProjectData.SetProjectError(exception10)
                Interaction.MsgBox(exception10.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
            Try 
                Do While ((num2 = 1) Or (num3 = 1))
                    Try 
                        If (num3 = 1) Then
                            Dim searcher3 As New ManagementObjectSearcher(scope2, query)
                            Dim obj12 As New ManagementObject(scope2, New ManagementPath("Win32_Service.Name='Messenger'"), Nothing)
                            Dim obj13 As ManagementBaseObject = obj12.GetMethodParameters("ChangeStartMode")
                            Dim obj14 As ManagementObject
                            For Each obj14 In searcher3.Get
                                If Operators.ConditionalCompareObjectNotEqual(obj14.Item("State"), "Stopped", False) Then
                                    If (num7 = 0) Then
                                        num3 = 1
                                        Dim obj16 As ManagementBaseObject = obj12.InvokeMethod("StopService", Nothing, Nothing)
                                        obj13.Item("StartMode") = "Disabled"
                                        Dim obj15 As ManagementBaseObject = obj12.InvokeMethod("ChangeStartMode", obj13, Nothing)
                                        num7 = 1
                                    End If
                                Else
                                    num3 = 0
                                    searcher3 = Nothing
                                    obj12 = Nothing
                                    obj13 = Nothing
                                    obj14 = Nothing
                                End If
                            Next
                        End If
                        If (num2 = 1) Then
                            Dim searcher4 As New ManagementObjectSearcher(scope, query)
                            Dim obj17 As New ManagementObject(scope, New ManagementPath("Win32_Service.Name='Messenger'"), Nothing)
                            Dim obj18 As ManagementBaseObject = obj17.GetMethodParameters("ChangeStartMode")
                            Dim obj19 As ManagementObject
                            For Each obj19 In searcher4.Get
                                If Operators.ConditionalCompareObjectNotEqual(obj19.Item("State"), "Stopped", False) Then
                                    If (num6 = 0) Then
                                        num2 = 1
                                        Dim obj21 As ManagementBaseObject = obj17.InvokeMethod("StopService", Nothing, Nothing)
                                        obj18.Item("StartMode") = "Disabled"
                                        Dim obj20 As ManagementBaseObject = obj17.InvokeMethod("ChangeStartMode", obj18, Nothing)
                                        num6 = 1
                                    End If
                                Else
                                    num2 = 0
                                    searcher4 = Nothing
                                    obj17 = Nothing
                                    obj18 = Nothing
                                    obj19 = Nothing
                                End If
                            Next
                        End If
                        Continue Do
                    Catch exception11 As ManagementException
                        ProjectData.SetProjectError(exception11)
                        Dim exception5 As ManagementException = exception11
                        MessageBox.Show(("An error occurred while querying for WMI data: " & exception5.Message))
                        ProjectData.ClearProjectError
                        Continue Do
                    Catch exception12 As UnauthorizedAccessException
                        ProjectData.SetProjectError(exception12)
                        Dim exception6 As UnauthorizedAccessException = exception12
                        MessageBox.Show(("Connection error): " & exception6.Message))
                        ProjectData.ClearProjectError
                        Continue Do
                    End Try
                Loop
            Catch exception13 As Exception
                ProjectData.SetProjectError(exception13)
                Interaction.MsgBox(exception13.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
            query = Nothing
            scope2 = Nothing
            scope = Nothing
            Dim num As Integer = 1
            Return Conversions.ToString(num)
        End Function

    End Class
End Namespace

