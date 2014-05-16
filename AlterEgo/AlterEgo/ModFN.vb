Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.IO

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class ModFN
        ' Methods
        Friend Shared Sub OpenFolder(ByVal eFolderName As String)
            Try 
                Interaction.Shell(("explorer.exe /n," & eFolderName), AppWinStyle.NormalFocus, False, -1)
            Catch exception1 As FileNotFoundException
                ProjectData.SetProjectError(exception1)
                Dim exception As FileNotFoundException = exception1
                Interaction.MsgBox("The folder cannot be found...", MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Interaction.MsgBox(("The folder cannot be found or you are not authorized to access it" & ChrW(13) & ChrW(10) & exception3.ToString), MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

    End Class
End Namespace

