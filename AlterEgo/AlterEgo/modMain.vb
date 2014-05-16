Imports AlterEgo.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Security.Principal
Imports System.Windows.Forms

Namespace AlterEgo
    <StandardModule> _
    Friend NotInheritable Class modMain
        ' Methods
        Friend Shared Sub ExitAPP(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Try 
                    modMain.RevertRegHack
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    Interaction.MsgBox("Could not revert RegHack", MsgBoxStyle.ApplicationModal, Nothing)
                    ProjectData.ClearProjectError
                End Try
                modFileSettingsandArray.SaveSettings
                modMain.mobNotifyIcon.Visible = False
                modMain.mobNotifyIcon.Dispose
                MyProject.Forms.frmRun = Nothing
                MyProject.Forms.frmIconChange = Nothing
                MyProject.Forms.frmCool = Nothing
                MyProject.Forms.frmTreeMenu = Nothing
                Application.Exit
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Dim exception2 As Exception = exception3
                Throw exception2
            End Try
        End Sub

        Friend Shared Sub getregistrysetting()
            Try 
                If Operators.ConditionalCompareObjectEqual(Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", True).GetValue("SeparateProcess"), 0, False) Then
                    modMain.regSetting = False
                Else
                    modMain.regSetting = True
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                modMain.regSetting = False
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub GetUserLoggedInLocally()
            Try 
                modMain.UserLoggedInLocallywoDomain = ""
                modMain.UserLoggedInLocally = ""
                Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Process WHERE Name = 'explorer.exe'")
                Dim str As String = ""
                Dim obj4 As ManagementObject
                For Each obj4 In searcher.Get
                    str = Conversions.ToString(obj4.Item("ProcessId"))
                Next
                Dim obj3 As ManagementBaseObject = New ManagementObject("root\CIMV2", ("Win32_Process.Handle='" & str & "'"), Nothing).InvokeMethod("GetOwner", Nothing, Nothing)
                modMain.UserLoggedInLocally = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(obj3.Item("Domain"), "\"), obj3.Item("User")))
                modMain.UserLoggedInLocallywoDomain = Conversions.ToString(obj3.Item("User"))
                modMain.aDMin = True
            Catch exception1 As ManagementException
                ProjectData.SetProjectError(exception1)
                Dim exception As ManagementException = exception1
                MessageBox.Show(("An error occurred while querying for WMI data...are you a Local Admin? : " & exception.Message))
                Interaction.MsgBox("Could Not get user Logged In Locally", MsgBoxStyle.ApplicationModal, Nothing)
                modMain.aDMin = False
                ProjectData.ClearProjectError
            End Try
        End Sub

        <STAThread> _
        Friend Shared Sub Main()
            Try 
                modMain.SubStartup
                Application.Run
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.MsgBox(exception.Message.ToString, MsgBoxStyle.Critical, Nothing)
                ProjectData.EndApp
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub OneWordRun()
            Try 
                Dim localMachine As RegistryKey = Registry.LocalMachine
                localMachine.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\AlterEgo.exe", RegistryKeyPermissionCheck.ReadWriteSubTree)
                Dim key2 As RegistryKey = localMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\AlterEgo.exe", True)
                key2.SetValue("", Application.ExecutablePath, RegistryValueKind.String)
                key2.SetValue("Path", Application.StartupPath, RegistryValueKind.String)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub RevertRegHack()
            Dim flag As Boolean
            Try 
                Dim key2 As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", True)
                If modMain.HackedRegNeedToPutBack Then
                    key2.SetValue("SeparateProcess", "0", RegistryValueKind.DWord)
                End If
                flag = True
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                flag = False
                modMain.HackedReg = False
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub statupLocationSetting()
            Try 
                If (MySettingsProperty.Settings.intStatupLocation = 0) Then
                    Dim mobNotifyIcon As NotifyIcon = modMain.mobNotifyIcon
                    mobNotifyIcon.Icon = modMain.ObjIcon(modMain.UserIcon)
                    mobNotifyIcon.ContextMenuStrip = MyProject.Forms.frmTreeMenu.assMenu
                    mobNotifyIcon.Visible = True
                    mobNotifyIcon.BalloonTipText = MySettingsProperty.Settings.NotifyText
                    mobNotifyIcon.BalloonTipTitle = modMain.CurrentUser
                    mobNotifyIcon.ShowBalloonTip(Conversions.ToInteger(MySettingsProperty.Settings.NotifyTimeout))
                    MyProject.Forms.frmCool.Visible = False
                    mobNotifyIcon = Nothing
                ElseIf (MySettingsProperty.Settings.intStatupLocation = 1) Then
                    MyProject.Forms.frmCool.Left = (modMain.ScreenWidth + 100)
                    MyProject.Forms.frmCool.Visible = True
                    modMain.mobNotifyIcon.Visible = False
                    MyProject.Forms.frmCool.subrefreshfrmCool
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subOpenFile(ByVal eFileName As String)
            Try 
                Dim info As New ProcessStartInfo(eFileName)
                Dim process As New Process
                process.StartInfo = info
                process.Start
                info = Nothing
                process = Nothing
            Catch exception1 As FileNotFoundException
                ProjectData.SetProjectError(exception1)
                Dim exception As FileNotFoundException = exception1
                Interaction.MsgBox(("The folder cannot be found or you are not authorized to access it" & exception.InnerException.ToString), MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Interaction.MsgBox(("The folder cannot be found or you are not authorized to access it" & exception3.ToString), MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub subOpenFolder(ByVal eFolderName As String)
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

        Friend Shared Sub SubStartup()
            If (modMain.CompileType = 0) Then
                modMain.Registered = False
                modReg.subStartHereToCheckRegistration
            Else
                modMain.Registered = True
            End If
            Try 
                Try 
                    Try 
                        modMain.AeVar(0) = "<æ>"
                        modMain.AeVar(1) = "<Ψ>"
                        modMain.AeVar(2) = "<∑>"
                        modMain.AeVar(3) = "<Ω>"
                        modMain.AeVar(4) = "<Φ>"
                        modMain.OneWordRun
                        modMain.WriteRegHack
                    Catch exception1 As Exception
                        ProjectData.SetProjectError(exception1)
                        Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                        ProjectData.ClearProjectError
                    End Try
                    modFileSettingsandArray.LoadSettings
                    modMain.intSpacer = MySettingsProperty.Settings.IntSpacer
                    modMain.CurrentUser = ""
                    Try 
                        modMain.CurrentUserName = WindowsIdentity.GetCurrent
                        modMain.CurrentUser = modMain.CurrentUserName.Name.ToUpper
                    Catch exception5 As Exception
                        ProjectData.SetProjectError(exception5)
                        Dim exception2 As Exception = exception5
                        Interaction.MsgBox("Get Current UserName Failed", MsgBoxStyle.ApplicationModal, Nothing)
                        ProjectData.ClearProjectError
                    End Try
                Catch exception6 As Exception
                    ProjectData.SetProjectError(exception6)
                    Dim exception3 As Exception = exception6
                    modMain.CurrentUser = "Guest"
                    Interaction.MsgBox("Error Getting Username", MsgBoxStyle.ApplicationModal, Nothing)
                    ProjectData.ClearProjectError
                End Try
                modMain.GetUserLoggedInLocally
                MyProject.Forms.frmIconChange.subLoadIcons
                MyProject.Forms.frmIconChange.subLoadFileTypeArrays
                modMain.UserIcon = MySettingsProperty.Settings.UserIcon
                modMain.mobNotifyIcon = New NotifyIcon
                modMain.mobNotifyIcon.Visible = False
                MyProject.Forms.frmCool.subrefreshfrmCool
                MyProject.Forms.frmTreeMenu.Show
                MyProject.Forms.frmTreeMenu.Hide
                If modMain.splash Then
                    MyProject.Forms.frmSplash.Show
                Else
                    modMain.statupLocationSetting
                End If
            Catch exception7 As Exception
                ProjectData.SetProjectError(exception7)
                Dim exception4 As Exception = exception7
                Interaction.MsgBox(exception4.Message.ToString, MsgBoxStyle.Critical, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Shared Sub WriteRegHack()
            Dim flag As Boolean
            Try 
                Dim key2 As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\", True)
                If Operators.ConditionalCompareObjectEqual(key2.GetValue("SeparateProcess"), 0, False) Then
                    modMain.regSetting = False
                    key2.SetValue("SeparateProcess", "1", RegistryValueKind.DWord)
                    flag = True
                    modMain.HackedReg = True
                    modMain.HackedRegNeedToPutBack = True
                Else
                    modMain.regSetting = True
                    modMain.HackedReg = False
                    modMain.HackedRegNeedToPutBack = False
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                flag = False
                modMain.HackedReg = False
                modMain.HackedRegNeedToPutBack = False
                ProjectData.ClearProjectError
            End Try
        End Sub


        ' Fields
        Friend Shared aDMin As Boolean
        Friend Shared AeVar As String() = New String(6  - 1) {}
        Friend Shared arrayCommands As String(0 To .,0 To .) = New String((MySettingsProperty.Settings.MaxSize + 1)  - 1, 2  - 1) {}
        Friend Shared arrayConfig As String() = New String((MySettingsProperty.Settings.MaxSize + 1)  - 1) {}
        Friend Shared arrayFiles As String(0 To .,0 To .) = New String((MySettingsProperty.Settings.MaxSize + 1)  - 1, 2  - 1) {}
        Friend Shared arrayFolders As String(0 To .,0 To .) = New String((MySettingsProperty.Settings.MaxSize + 1)  - 1, 2  - 1) {}
        Friend Shared arrayImgFileTypes As Image() = New Image(&H65  - 1) {}
        Friend Shared arrayRun As String() = New String((MySettingsProperty.Settings.MaxSize + 1)  - 1) {}
        Friend Shared arrayStrFileTypes As String() = New String(&H65  - 1) {}
        Friend Shared arrayUserIcons As String(0 To .,0 To .) = New String((MySettingsProperty.Settings.MaxSize + 1)  - 1, 2  - 1) {}
        Friend Shared ColumnCounter As Integer
        Friend Shared CommandItemCounter As Integer
        Friend Shared CompileType As Integer = 1
        Friend Shared ConfigPath As String = (Application.StartupPath & "\" & MySettingsProperty.Settings.ConfigFileName)
        Friend Shared CurrentIcon As String
        Friend Shared CurrentUser As String
        Friend Shared CurrentUserName As WindowsIdentity
        Friend Shared dlgFile As OpenFileDialog = New OpenFileDialog
        Friend Shared dlgFolder As FolderBrowserDialog = New FolderBrowserDialog
        Friend Shared dlgInitDir As String = MySettingsProperty.Settings.InitialDirectory
        Friend Shared f As File
        Friend Shared FileItemCounter As Integer
        Friend Shared FileName As String
        Friend Shared FilePathNameToPassToUFR As String
        Friend Shared FileTypeFound As Integer
        Friend Shared FolderItemCounter As Integer
        Friend Shared FolderName As String
        Friend Shared frmHelp As Form
        Friend Shared HackedReg As Boolean = False
        Friend Shared HackedRegNeedToPutBack As Boolean
        Friend Shared indexCommands As Integer
        Friend Shared indexFiles As Integer
        Friend Shared indexFolders As Integer
        Friend Shared intCMDSelectedIndex As Integer
        Friend Shared intColumn As Integer
        Friend Shared intFILSelectedIndex As Integer
        Friend Shared intFOLSelectedIndex As Integer
        Friend Shared intSpacer As Integer
        Friend Shared LC20 As Integer
        Friend Shared loopCounter As Integer
        Friend Shared mobNotifyIcon As NotifyIcon
        Friend Shared NotifyIconName As String
        Friend Shared Notifytext As String
        Friend Shared NotifyTimeout As String
        Friend Shared NotifyTitle As String
        Friend Shared ObjIcon As Icon() = New Icon(&H17  - 1) {}
        Friend Shared ObjImg As Image() = New Image(&H17  - 1) {}
        Friend Shared Panthro As String
        Friend Shared ProfilePath As String
        Friend Shared r As StreamReader
        Friend Shared Registered As Boolean
        Friend Shared regSetting As Boolean
        Friend Shared RelativeMarker As String = "||"
        Friend Shared RowCounter As Integer
        Friend Shared RunCmdString As String
        Friend Shared runItemCounter As Integer
        Friend Shared ScreenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Friend Shared ScreenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Friend Shared SelectedIcon As Integer
        Friend Shared ShCommandeer As Boolean = False
        Friend Shared splash As Boolean = True
        Friend Shared tsiCommands As ToolStripMenuItem = New ToolStripMenuItem("Commands", Resources.imgCmd)
        Friend Shared tsiFiles As ToolStripMenuItem = New ToolStripMenuItem("Files", Resources.imgTxtFile)
        Friend Shared tsiFolders As ToolStripMenuItem = New ToolStripMenuItem("Folders", Resources.imgFolder)
        Friend Shared UpdateItem As String
        Friend Shared UserCounter As Integer
        Friend Shared UserIcon As Integer
        Friend Shared UserId As String
        Friend Shared UserLoggedInLocally As String = ""
        Friend Shared UserLoggedInLocallywoDomain As String = ""
        Friend Shared w As StreamWriter
    End Class
End Namespace

