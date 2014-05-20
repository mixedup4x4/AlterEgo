Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class fnRebootShutdown
        ' Methods
        Friend Shared Function fnReboot(ByVal Inst As String) As Integer
            Dim num2 As Integer = 0
            Try 
                Dim scope As New ManagementScope(("\\" & fnRebootShutdown.MachineName & "\root\CIMV2"))
                scope.Connect
                Dim obj2 As New ManagementObject(scope, New ManagementPath(("Win32_OperatingSystem.Name='" & Inst & "'")), Nothing)
                num2 = Conversions.ToInteger(obj2.InvokeMethod("Reboot", Nothing, Nothing).Item("ReturnValue"))
            Catch exception1 As ManagementException
                ProjectData.SetProjectError(exception1)
                Dim exception As ManagementException = exception1
                MessageBox.Show(("An error occurred while trying to execute the WMI method: " & exception.Message))
                ProjectData.ClearProjectError
            Catch exception3 As UnauthorizedAccessException
                ProjectData.SetProjectError(exception3)
                Dim exception2 As UnauthorizedAccessException = exception3
                MessageBox.Show(("Connection error (user name or password might be incorrect): " & exception2.Message))
                ProjectData.ClearProjectError
            End Try
            Return num2
        End Function

        Friend Shared Function fnRebootShutdown(ByVal MachineNamex As String, ByVal Reboot0Shutdown1 As Integer) As Boolean
            Dim flag As Boolean
            fnRebootShutdown.MachineName = MachineNamex
            Try 
                Dim prompt As Integer = 0
                Dim inst As String = ""
                Dim scope As New ManagementScope(("\\" & fnRebootShutdown.MachineName & "\root\CIMV2"))
                scope.Connect
                Dim query As New ObjectQuery("SELECT * FROM Win32_OperatingSystem")
                Dim searcher As New ManagementObjectSearcher(scope, query)
                Dim obj2 As ManagementObject
                For Each obj2 In searcher.Get
                    inst = Conversions.ToString(obj2.Item("Name"))
                Next
                If (Reboot0Shutdown1 = 0) Then
                    If (fnRebootShutdown.fnReboot(inst) = 1) Then
                        prompt = 1
                    Else
                        prompt = 0
                    End If
                ElseIf (Reboot0Shutdown1 = 1) Then
                    If (fnRebootShutdown.fnShutdown(inst) = 1) Then
                        prompt = 1
                    Else
                        Interaction.MsgBox(prompt, MsgBoxStyle.ApplicationModal, Nothing)
                        prompt = 0
                    End If
                End If
                flag = (prompt > 0)
            Catch exception1 As ManagementException
                ProjectData.SetProjectError(exception1)
                Dim exception As ManagementException = exception1
                MessageBox.Show(("An error occurred while querying for WMI data: " & exception.Message))
                ProjectData.ClearProjectError
            Catch exception5 As UnauthorizedAccessException
                ProjectData.SetProjectError(exception5)
                MessageBox.Show(("Connection error (user name or password might be incorrect): " & exception5.ToString))
                ProjectData.ClearProjectError
            Catch exception6 As COMException
                ProjectData.SetProjectError(exception6)
                Interaction.MsgBox(exception6.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Interaction.MsgBox(exception7.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
            Return flag
        End Function

        Friend Shared Function fnShutdown(ByVal Inst As String) As Integer
            Dim num2 As Integer = 0
            Try 
                Dim scope As New ManagementScope(("\\" & fnRebootShutdown.MachineName & "\root\CIMV2"))
                scope.Connect
                Dim obj2 As New ManagementObject(scope, New ManagementPath(("Win32_OperatingSystem.Name='" & Inst & "'")), Nothing)
                Dim methodParameters As ManagementBaseObject = obj2.GetMethodParameters("Shutdown")
                num2 = Conversions.ToInteger(obj2.InvokeMethod("Shutdown", methodParameters, Nothing).Item("ReturnValue"))
            Catch exception1 As ManagementException
                ProjectData.SetProjectError(exception1)
                Dim exception As ManagementException = exception1
                MessageBox.Show(("An error occurred while trying to execute the WMI method: " & exception.Message))
                ProjectData.ClearProjectError
            Catch exception3 As UnauthorizedAccessException
                ProjectData.SetProjectError(exception3)
                Dim exception2 As UnauthorizedAccessException = exception3
                MessageBox.Show(("Connection error (user name or password might be incorrect): " & exception2.Message))
                ProjectData.ClearProjectError
            End Try
            Return num2
        End Function


        ' Fields
        Friend Shared MachineName As String = ""
    End Class
End Namespace

