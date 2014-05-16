Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Diagnostics
Imports System.Threading
Imports System.Windows.Forms

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class UFR
        ' Methods
        Friend Shared Sub UFR(ByVal xyz As String, ByVal type As String, ByVal ID As Integer)
            Try 
                Dim newValue As String = ""
                Dim num2 As Integer = (Information.UBound(modMain.AeVar, 1) - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    If (Strings.InStr(xyz, modMain.AeVar(i), CompareMethod.Binary) > 0) Then
                        newValue = Interaction.InputBox(("Enter your parameter for: " & modMain.AeVar(i)), "", "", -1, -1)
                        xyz = xyz.Replace(modMain.AeVar(i), newValue)
                    End If
                    i += 1
                Loop
                If (Strings.InStr(xyz, modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                    Dim str10 As String = xyz
                    str10 = str10.Replace(modMain.RelativeMarker, Application.StartupPath)
                End If
                Dim startupPath As String = Application.StartupPath
                If (xyz <> "") Then
                    Dim str3 As String
                    Dim eFolderName As String = xyz
                    If (Strings.StrComp(eFolderName.Substring(0, 2), modMain.RelativeMarker, CompareMethod.Text) = 0) Then
                        eFolderName = eFolderName.Replace(modMain.RelativeMarker, startupPath)
                    End If
                    Try 
                        Dim str8 As String = xyz.Substring(0, 2)
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Dim exception As Exception = exception1
                        ProjectData.ClearProjectError
                    End Try
                    Try 
                        Dim str7 As String = xyz.Substring(0, 3)
                    Catch exception7 As Exception
                        ProjectData.SetProjectError(exception7)
                        Dim exception2 As Exception = exception7
                        ProjectData.ClearProjectError
                    End Try
                    Dim str4 As String = xyz.Substring((xyz.Length - 1), 1)
                    If (xyz.Length < 5) Then
                        str3 = eFolderName
                    Else
                        str3 = xyz.Substring(0, 5)
                    End If
                    Dim str As String = ""
                    Dim str2 As String = ""
                    If (Strings.InStr(str3, "\", CompareMethod.Text) > 0) Then
                        Dim array As String() = xyz.Split(New Char() { "\"c })
                        str2 = array(Information.UBound(array, 1))
                        If (Strings.InStr(str2, ".", CompareMethod.Text) > 0) Then
                            array = str2.Split(New Char() { "."c })
                            str = ("." & array(Information.UBound(array, 1)))
                        End If
                    End If
                    If (ID <> &H270F) Then
                        If (Strings.StrComp(type, "Command", CompareMethod.Text) = 0) Then
                            If (Strings.StrComp(modFileSettingsandArray.AllArray(ID, 5), "True", CompareMethod.Text) = 0) Then
                                Interaction.Shell(("cmd.exe /k " & xyz), AppWinStyle.NormalFocus, False, -1)
                                Return
                            End If
                            Try 
                                Interaction.Shell(xyz, AppWinStyle.NormalFocus, False, -1)
                                Return
                            Catch exception8 As Exception
                                ProjectData.SetProjectError(exception8)
                                Dim exception3 As Exception = exception8
                                Interaction.Shell(("cmd.exe /c " & xyz), AppWinStyle.NormalFocus, False, -1)
                                ProjectData.ClearProjectError
                                Return
                            End Try
                        End If
                        If (Strings.StrComp(type, "Folder", CompareMethod.Text) = 0) Then
                            Select Case modFileSettingsandArray.AllArray(ID, 3)
                                Case "45"
                                    modMain.getregistrysetting
                                    If modMain.regSetting Then
                                        Interaction.Shell(("explorer.exe /e," & eFolderName), AppWinStyle.NormalFocus, False, -1)
                                    Else
                                        modMain.subOpenFolder(eFolderName)
                                    End If
                                    Return
                                Case "47"
                                    modMain.subOpenFolder(eFolderName)
                                    Exit Select
                                Case "48"
                                    modMain.getregistrysetting
                                    If modMain.regSetting Then
                                        Interaction.Shell(("explorer.exe /e,/select," & eFolderName), AppWinStyle.NormalFocus, False, -1)
                                    Else
                                        modMain.subOpenFolder(eFolderName)
                                    End If
                                    Exit Select
                            End Select
                        ElseIf (Strings.StrComp(type, "File", CompareMethod.Text) = 0) Then
                            If (Strings.InStr(eFolderName, modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                                eFolderName = xyz.Replace(xyz, modMain.RelativeMarker)
                            End If
                            modMain.subOpenFile(eFolderName)
                        Else
                            Interaction.MsgBox("Verify that you have a file type selected for this path", MsgBoxStyle.ApplicationModal, Nothing)
                        End If
                    Else
                        Try 
                            If (str <> "") Then
                                modMain.subOpenFile(eFolderName)
                            ElseIf (str4 = "\") Then
                                modMain.subOpenFolder(eFolderName)
                            Else
                                Dim process As New Process
                                Try 
                                    process.StartInfo.FileName = eFolderName
                                    process.StartInfo.UseShellExecute = True
                                    process.Start
                                Catch exception9 As Exception
                                    ProjectData.SetProjectError(exception9)
                                    Dim exception4 As Exception = exception9
                                    ProjectData.ClearProjectError
                                Finally
                                    process.Dispose
                                End Try
                            End If
                        Catch exception10 As Exception
                            ProjectData.SetProjectError(exception10)
                            Interaction.MsgBox(exception10.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                            ProjectData.ClearProjectError
                        End Try
                    End If
                End If
            Catch exception11 As Exception
                ProjectData.SetProjectError(exception11)
                Interaction.MsgBox(exception11.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub


        ' Fields
        Private Shared MasterOfTheUniverse As String
        Private Shared thr0 As Thread
        Private Shared thr1 As Thread
        Private Shared thr2 As Thread
        Private Shared thr3 As Thread
        Private Shared thr4 As Thread
        Private Shared thr5 As Thread
    End Class
End Namespace

