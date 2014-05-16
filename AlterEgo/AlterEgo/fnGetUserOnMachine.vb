Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class fnGetUserOnMachine
        ' Methods
        Friend Shared Function fnGetUserOnMachine(ByVal PCName As String) As String
            Dim str As String = ""
            Try 
                Dim enumerator As ManagementObjectEnumerator
                Dim scope As New ManagementScope(("\\" & Strings.Trim(PCName) & "\root\CIMV2"))
                Dim query As New ObjectQuery("SELECT * FROM Win32_ComputerSystem")
                Dim searcher As New ManagementObjectSearcher(scope, query)
                Try 
                    enumerator = searcher.Get.GetEnumerator
                    Do While enumerator.MoveNext
                        Dim current As ManagementObject = DirectCast(enumerator.Current, ManagementObject)
                        str = current.Item("UserName").ToString
                    Loop
                    Return str
                Finally
                    If (Not enumerator Is Nothing) Then
                        enumerator.Dispose
                    End If
                End Try
            Catch exception1 As ManagementException
                ProjectData.SetProjectError(exception1)
                Dim exception As ManagementException = exception1
                MessageBox.Show(("An error occurred while querying for WMI data: " & exception.Message))
                ProjectData.ClearProjectError
            Catch exception5 As UnauthorizedAccessException
                ProjectData.SetProjectError(exception5)
                Dim exception2 As UnauthorizedAccessException = exception5
                MessageBox.Show(("Connection error (user name or password might be incorrect): " & exception2.Message))
                ProjectData.ClearProjectError
            Catch exception6 As COMException
                ProjectData.SetProjectError(exception6)
                Dim exception3 As COMException = exception6
                Interaction.MsgBox(exception3.Message, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Dim exception4 As Exception = exception7
                MessageBox.Show(exception4.Message, "GetUserOnMachine", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                str = "Enter Name or IP"
                ProjectData.ClearProjectError
            End Try
            Return str
        End Function

    End Class
End Namespace

