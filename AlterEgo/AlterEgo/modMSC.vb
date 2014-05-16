Imports Microsoft.VisualBasic.CompilerServices
Imports System

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class modMSC
        ' Methods
        Friend Shared Sub LoadMSCArray()
            modMSC.MSC(0, 0) = "Computer Management"
            modMSC.MSC(0, 1) = "compmgmt.msc"
            modMSC.MSC(1, 0) = "Event Viewer"
            modMSC.MSC(1, 1) = "eventvwr.msc"
            modMSC.MSC(2, 0) = "Services Management"
            modMSC.MSC(2, 1) = "services.msc"
        End Sub


        ' Fields
        Friend Shared MSC As String(0 To .,0 To .) = New String(4  - 1, 2  - 1) {}
    End Class
End Namespace

