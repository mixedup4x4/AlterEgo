Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Management

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class fnStartRemoteProcess
        ' Methods
        Friend Shared Function fnGetUserOnMachine(ByVal MachineName As String, ByVal ProcessX As String) As String
            Dim num As Integer = 0
            New ManagementScope(("\\" & MachineName & "\root\CIMV2")).Connect
            Return Conversions.ToString(num)
        End Function

    End Class
End Namespace

