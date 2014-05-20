Imports AlterEgo.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Threading

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class MenuSubs
        ' Methods
        Public Shared Sub AdminTkThreadExecute()
            MyProject.Forms.frmAdminTK.Show
        End Sub

        Friend Shared Sub ChangeMyIcon(ByVal s As Object, ByVal e As EventArgs)
            MyProject.Forms.frmIconChange.Show
        End Sub

        Friend Shared Sub subAdminTK(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                MenuSubs.AdminTkThreadExecute
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subCommandeer(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                MyProject.Forms.frmCommandeer.Show
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subCompMGMT(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                modMain.subOpenFile("compmgmt.msc")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subControlPanel(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                modMain.subOpenFile("Control.exe")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subexplorer(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                modMain.subOpenFile("explorer.exe")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subHelp(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Interaction.Shell(("explorer.exe " & MySettingsProperty.Settings.HelpPath), AppWinStyle.Hide, False, -1)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subLocalMyComputer(ByVal sender As Object, ByVal e As EventArgs)
            Dim folderPath As String = Environment.GetFolderPath(SpecialFolder.MyComputer)
            If modMain.HackedReg Then
                Interaction.Shell(("explorer.exe /e,/root," & folderPath), AppWinStyle.NormalFocus, False, -1)
            Else
                modMain.subOpenFolder(folderPath)
            End If
        End Sub

        Friend Shared Sub subLocalMyDesktop(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Dim num As Integer
                Dim strArray As String() = Environment.GetFolderPath(SpecialFolder.Desktop).Split(New Char() { "\"c })
                Dim eFolderName As String = ""
                Dim num3 As Integer = (strArray.GetUpperBound(num) - 2)
                Dim i As Integer = 0
                Do While (i <= num3)
                    eFolderName = (eFolderName & strArray(i) & "\")
                    i += 1
                Loop
                eFolderName = (eFolderName & modMain.UserLoggedInLocallywoDomain & "\Desktop")
                If modMain.HackedReg Then
                    Interaction.Shell(("explorer.exe /e,/select," & eFolderName), AppWinStyle.NormalFocus, False, -1)
                Else
                    modMain.subOpenFolder(eFolderName)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subLocalMyDocs(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Dim num As Integer
                Dim strArray As String() = Environment.GetFolderPath(SpecialFolder.Personal).Split(New Char() { "\"c })
                Dim eFolderName As String = ""
                Dim num3 As Integer = (strArray.GetUpperBound(num) - 2)
                Dim i As Integer = 0
                Do While (i <= num3)
                    eFolderName = (eFolderName & strArray(i) & "\")
                    i += 1
                Loop
                eFolderName = (eFolderName & modMain.UserLoggedInLocallywoDomain & "\My Documents\")
                If modMain.HackedReg Then
                    Interaction.Shell(("explorer.exe /e,/select," & eFolderName), AppWinStyle.NormalFocus, False, -1)
                Else
                    modMain.subOpenFolder(eFolderName)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subLocalRegedit(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                modMain.subOpenFile("regedit.exe")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subMeNuRegister(ByVal sender As Object, ByVal e As EventArgs)
            MenuSubs.subRegister
        End Sub

        Friend Shared Sub subModMenu(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                MyProject.Forms.frmTreeMenu.Show
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subMyDesktop(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Dim folderPath As String = Environment.GetFolderPath(SpecialFolder.Desktop)
                If modMain.HackedReg Then
                    Interaction.Shell(("explorer.exe /e,/select," & folderPath), AppWinStyle.NormalFocus, False, -1)
                Else
                    modMain.subOpenFolder(folderPath)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subMyDocs(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Dim folderPath As String = Environment.GetFolderPath(SpecialFolder.Personal)
                If modMain.HackedReg Then
                    Interaction.Shell(("explorer.exe /e,/select," & folderPath), AppWinStyle.NormalFocus, False, -1)
                Else
                    modMain.subOpenFolder(folderPath)
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subPrinters(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                modMain.subOpenFile("::{2227A280-3AEA-1069-A2DE-08002B30309D}")
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subRegister()
            MyProject.Forms.frmRegister.Show
        End Sub

        Friend Shared Sub subRun(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.frmRun.Show
        End Sub


        ' Fields
        Friend Shared threadAdminTK As Thread
    End Class
End Namespace

