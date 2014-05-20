Imports AlterEgo.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Management
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class ctrlListProcessing
        Inherits UserControl

        Private _array As String

        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.ctrlListProcessing_Load)
            Me.BatchArray = New String(&H2711 - 1) {}
            Me.ItemCounter = 0
            Me.strDelimeter = MySettingsProperty.Settings.AdminTKstrDelimeter
            Me.InitializeComponent()
        End Sub

        Private Property Array(num2 As Integer, num As Integer) As String
            Get
                Return _array
            End Get
            Set(value As String)
                _array = value
            End Set
        End Property

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.txtOutputFile.Text = Me.fnGetFilePath
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num9 As Integer
            Try 
                Dim num10 As Integer
            Label_0000:
                num10 = 1
                Dim results As New frmBatchResults
            Label_0009:
                num10 = 2
                Dim str As String = ""
            Label_0012:
                num10 = 3
                Dim strArray2 As String() = New String(11  - 1) {}
            Label_001D:
                num10 = 4
                Dim strArray(,) As String(0 To .,0 To .) = New String(11  - 1, &H1F  - 1) {}
            Label_002A:
                num10 = 5
                If (Me.BatchArray.Length = 0) Then
                    goto Label_067B
                End If
            Label_003D:
                num10 = 8
                Dim num5 As Integer = (Me.BatchArray.Length - 1)
                Dim index As Integer = 0
                goto Label_04B7
            Label_0054:
                num10 = 9
                If (Strings.StrComp(Me.BatchArray(index), "", CompareMethod.Binary) = 0) Then
                    goto Label_04C0
                End If
            Label_0072:
                ProjectData.ClearProjectError
                Dim num8 As Integer = 1
            Label_007A:
                num10 = 13
                Dim options As New ConnectionOptions
            Label_0085:
                num10 = 14
                Dim scope As New ManagementScope(("\\" & Me.BatchArray(index) & "\root\CIMV2"), options)
            Label_00AA:
                num10 = 15
                scope.Connect
            Label_00B5:
                num10 = &H10
                Dim query3 As New ObjectQuery("SELECT * FROM Win32_OperatingSystem")
            Label_00C5:
                num10 = &H11
                Dim searcher3 As New ManagementObjectSearcher(scope, query3)
            Label_00D4:
                num10 = &H12
                Dim num As Integer = 0
            Label_00DB:
                num10 = &H13
                Dim enumerator As ManagementObjectEnumerator = searcher3.Get.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ManagementObject = DirectCast(enumerator.Current, ManagementObject)
                Label_00FD:
                    num10 = 20
                    strArray2(num) = Conversions.ToString(current.Item("LastBootUpTime"))
                Label_0116:
                    num10 = &H15
                    num += 1
                Label_0120:
                    num10 = &H16
                Loop
                If (Not enumerator Is Nothing) Then
                    enumerator.Dispose
                End If
            Label_0138:
                num10 = &H17
                Dim query As New ObjectQuery("SELECT * FROM Win32_ComputerSystem")
            Label_0148:
                num10 = &H18
                Dim searcher As New ManagementObjectSearcher(scope, query)
            Label_0157:
                num10 = &H19
                Dim enumerator2 As ManagementObjectEnumerator = searcher.Get.GetEnumerator
                Do While enumerator2.MoveNext
                    Dim obj3 As ManagementObject = DirectCast(enumerator2.Current, ManagementObject)
                Label_0179:
                    num10 = &H1A
                    strArray2(num) = Conversions.ToString(obj3.Item("UserName"))
                Label_0192:
                    num10 = &H1B
                    num += 1
                Label_019C:
                    num10 = &H1C
                Loop
                If (Not enumerator2 Is Nothing) Then
                    enumerator2.Dispose
                End If
            Label_01B4:
                num10 = &H1D
                str = (str & Me.BatchArray(index))
            Label_01C8:
                num10 = 30
                If Not Me.ckOS00.Checked Then
                    goto Label_01ED
                End If
            Label_01D9:
                num10 = &H1F
                str = (str & Me.strDelimeter & strArray2(0))
            Label_01ED:
                num10 = &H21
                If Not Me.ckCS01.Checked Then
                    goto Label_0212
                End If
            Label_01FE:
                num10 = &H22
                str = (str & Me.strDelimeter & strArray2(1))
            Label_0212:
                num10 = &H24
                Dim num2 As Integer = 0
            Label_0219:
                num10 = &H25
                num = 0
            Label_0220:
                num10 = &H26
                Dim query2 As New ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration")
            Label_0230:
                num10 = &H27
                Dim searcher2 As New ManagementObjectSearcher(scope, query2)
            Label_023F:
                num10 = 40
                Dim enumerator3 As ManagementObjectEnumerator = searcher2.Get.GetEnumerator
                Do While enumerator3.MoveNext
                    Dim obj4 As ManagementObject = DirectCast(enumerator3.Current, ManagementObject)
                Label_0264:
                    num10 = &H29
                    If (obj4.Item("IPAddress") Is Nothing) Then
                        goto Label_0357
                    End If
                Label_027B:
                    num10 = &H2B
                Label_027F:
                    num10 = &H2C
                    Dim strArray3 As String() = DirectCast(obj4.Item("IPAddress"), String())
                Label_0296:
                    num10 = &H2D
                    Dim strArray4 As String() = strArray3
                    Dim num6 As Integer = 0
                    Do While (num6 < strArray4.Length)
                        Dim str2 As String = strArray4(num6)
                    Label_02AD:
                        num10 = &H2E
                        Array(num2, num) = str2
                    Label_02BD:
                        num10 = &H2F
                        num += 1
                    Label_02C7:
                        num10 = &H30
                        Array(num2, num) = Conversions.ToString(obj4.Item("MACAddress"))
                    Label_02E6:
                        num10 = &H31
                        num += 1
                    Label_02F0:
                        num10 = 50
                        Array(num2, num) = Conversions.ToString(obj4.Item("DNSHostName"))
                    Label_030F:
                        num10 = &H33
                        num += 1
                    Label_0319:
                        num10 = &H34
                        Array(num2, num) = Conversions.ToString(obj4.Item("DHCPEnabled"))
                        num6 += 1
                    Label_033E:
                        num10 = &H35
                    Loop
                Label_034D:
                    num10 = &H36
                    num2 += 1
                Label_0357:
                    num10 = &H38
                Loop
                If (Not enumerator3 Is Nothing) Then
                    enumerator3.Dispose
                End If
            Label_0372:
                num10 = &H39
                If Not (((Me.ckNET00.Checked Or Me.cknet01.Checked) Or Me.cknet02.Checked) Or Me.cknet03.Checked) Then
                    goto Label_0485
                End If
            Label_03AA:
                num10 = &H3A
                If (num2 = 0) Then
                    goto Label_0485
                End If
            Label_03B6:
                num10 = &H3B
                Dim num7 As Integer = num2
                Dim num4 As Integer = 0
                goto Label_047C
            Label_03C6:
                num10 = 60
                If Not Me.ckNET00.Checked Then
                    goto Label_03F1
                End If
            Label_03D7:
                num10 = &H3D
                str = (str & Me.strDelimeter & Array(num4, 0))
            Label_03F1:
                num10 = &H3F
                If Not Me.cknet01.Checked Then
                    goto Label_041C
                End If
            Label_0402:
                num10 = &H40
                str = (str & Me.strDelimeter & Array(num4, 1))
            Label_041C:
                num10 = &H42
                If Not Me.cknet02.Checked Then
                    goto Label_0447
                End If
            Label_042D:
                num10 = &H43
                str = (str & Me.strDelimeter & strArray(num4, 2))
            Label_0447:
                num10 = &H45
                If Not Me.cknet03.Checked Then
                    goto Label_0472
                End If
            Label_0458:
                num10 = 70
                str = (str & Me.strDelimeter & strArray(num4, 3))
            Label_0472:
                num10 = &H48
                num4 += 1
            Label_047C:
                If (num4 <= num7) Then
                    goto Label_03C6
                End If
            Label_0485:
                num10 = &H4B
                If (Strings.StrComp(str, "", CompareMethod.Binary) = 0) Then
                    goto Label_067B
                End If
            Label_049D:
                num10 = &H4E
                str = (str & ChrW(13) & ChrW(10))
            Label_04AD:
                num10 = &H4F
                index += 1
            Label_04B7:
                If (index <= num5) Then
                    goto Label_0054
                End If
            Label_04C0:
                num10 = 80
                results.Show
            Label_04CA:
                num10 = &H51
                results.txtResults.Text = str
                goto Label_067B
            Label_04DF:
                num9 = 0
                Select Case (num9 + 1)
                    Case 1, 10
                        goto Label_0000
                    Case 2
                        goto Label_0009
                    Case 3
                        goto Label_0012
                    Case 4
                        goto Label_001D
                    Case 5
                        goto Label_002A
                    Case 6, &H4C, &H52
                        goto Label_067B
                    Case 7, 8
                        goto Label_003D
                    Case 9
                        goto Label_0054
                    Case 11, 12
                        goto Label_0072
                    Case 13
                        goto Label_007A
                    Case 14
                        goto Label_0085
                    Case 15
                        goto Label_00AA
                    Case &H10
                        goto Label_00B5
                    Case &H11
                        goto Label_00C5
                    Case &H12
                        goto Label_00D4
                    Case &H13
                        goto Label_00DB
                    Case 20
                        goto Label_00FD
                    Case &H15
                        goto Label_0116
                    Case &H16
                        goto Label_0120
                    Case &H17
                        goto Label_0138
                    Case &H18
                        goto Label_0148
                    Case &H19
                        goto Label_0157
                    Case &H1A
                        goto Label_0179
                    Case &H1B
                        goto Label_0192
                    Case &H1C
                        goto Label_019C
                    Case &H1D
                        goto Label_01B4
                    Case 30
                        goto Label_01C8
                    Case &H1F
                        goto Label_01D9
                    Case &H20, &H21
                        goto Label_01ED
                    Case &H22
                        goto Label_01FE
                    Case &H23, &H24
                        goto Label_0212
                    Case &H25
                        goto Label_0219
                    Case &H26
                        goto Label_0220
                    Case &H27
                        goto Label_0230
                    Case 40
                        goto Label_023F
                    Case &H29
                        goto Label_0264
                    Case &H2A, &H37, &H38
                        goto Label_0357
                    Case &H2B
                        goto Label_027B
                    Case &H2C
                        goto Label_027F
                    Case &H2D
                        goto Label_0296
                    Case &H2E
                        goto Label_02AD
                    Case &H2F
                        goto Label_02BD
                    Case &H30
                        goto Label_02C7
                    Case &H31
                        goto Label_02E6
                    Case 50
                        goto Label_02F0
                    Case &H33
                        goto Label_030F
                    Case &H34
                        goto Label_0319
                    Case &H35
                        goto Label_033E
                    Case &H36
                        goto Label_034D
                    Case &H39
                        goto Label_0372
                    Case &H3A
                        goto Label_03AA
                    Case &H3B
                        goto Label_03B6
                    Case 60
                        goto Label_03C6
                    Case &H3D
                        goto Label_03D7
                    Case &H3E, &H3F
                        goto Label_03F1
                    Case &H40
                        goto Label_0402
                    Case &H41, &H42
                        goto Label_041C
                    Case &H43
                        goto Label_042D
                    Case &H44, &H45
                        goto Label_0447
                    Case 70
                        goto Label_0458
                    Case &H47, &H48
                        goto Label_0472
                    Case &H49, &H4A, &H4B
                        goto Label_0485
                    Case &H4D, &H4E
                        goto Label_049D
                    Case &H4F
                        goto Label_04AD
                    Case 80
                        goto Label_04C0
                    Case &H51
                        goto Label_04CA
                    Case Else
                        goto Label_0670
                End Select
            Label_0639:
                num9 = num10
                Select Case num8
                    Case 0
                        goto Label_0670
                    Case 1
                        goto Label_04DF
                End Select
            Catch obj1 As Object When (?)
                ProjectData.SetProjectError(DirectCast(obj1, Exception))
                goto Label_0639
            End Try
        Label_0670:
            Throw ProjectData.CreateProjectError(-2146828237)
        Label_067B:
            If (num9 <> 0) Then
                ProjectData.ClearProjectError
            End If
        End Sub

        Friend Sub ChangePasswords(ByVal machine As String, ByVal un As String, ByVal pass As String)
            If MyProject.Forms.frmAdminTK.changePW Then
                If MyProject.Forms.frmChangePW.ckCreateAdminAccount.Checked Then
                    fnChangeLocalAdmin.fnCreateNewAccount(machine, un, pass)
                    fnChangeLocalAdmin.fnResetPassword(machine, un, pass)
                Else
                    fnChangeLocalAdmin.fnResetPassword(machine, un, pass)
                End If
            End If
        End Sub

        Private Sub clearArray()
            Dim num2 As Integer = (Me.BatchArray.Length - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.BatchArray(i) = ""
                i += 1
            Loop
        End Sub

        Private Sub cmdInputFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.clearArray
            Me.txtInputFile.Text = Me.fnGetFilePath
            If Not ((Me.txtInputFile.Text = "") Or (Me.txtInputFile.Text = Nothing)) Then
                MySettingsProperty.Settings.AdminTKLastInputFile = Me.txtInputFile.Text
                Try 
                    Me.lstItems.Items.Clear
                    Me.lblItemCount.Text = ""
                    Me.ItemCounter = 0
                    Dim reader As New StreamReader(Me.txtInputFile.Text)
                    Do While Not reader.EndOfStream
                        Dim str As String = reader.ReadLine
                        If (Strings.StrComp(str, "", CompareMethod.Text) <> 0) Then
                            Me.BatchArray(Me.ItemCounter) = Strings.UCase(str)
                            Me.lstItems.Items.Add((Conversions.ToString(CInt((Me.ItemCounter + 1))) & ":   " & Me.BatchArray(Me.ItemCounter)))
                            Me.ItemCounter += 1
                        End If
                    Loop
                    Me.lblItemCount.Text = ("Input File contained " & Conversions.ToString(Me.ItemCounter) & " Items")
                    Me.cmdRun.Enabled = True
                Catch exception1 As FileNotFoundException
                    ProjectData.SetProjectError(exception1)
                    Dim exception As FileNotFoundException = exception1
                    Interaction.MsgBox("File Could not be found or accessed", MsgBoxStyle.ApplicationModal, Nothing)
                    ProjectData.ClearProjectError
                Catch exception3 As Exception
                    ProjectData.SetProjectError(exception3)
                    Interaction.MsgBox(exception3.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                    ProjectData.ClearProjectError
                End Try
            End If
        End Sub

        Private Sub cmdReboot_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim num4 As Integer
            Try 
                Dim num5 As Integer
            Label_0000:
                num5 = 1
                Dim str As String = Conversions.ToString(CInt(Interaction.MsgBox("This will reboot all machines in the list." & ChrW(13) & ChrW(10) & "Do you wish to continue?", MsgBoxStyle.YesNo, "Reboot List?")))
            Label_0019:
                num5 = 2
                If (str.ToString <> "6") Then
                    goto Label_0096
                End If
            Label_0030:
                num5 = 3
                Dim num2 As Integer = (Me.BatchArray.Length - 1)
                Dim index As Integer = 0
                goto Label_008D
            Label_0042:
                num5 = 4
                If (Strings.StrComp(Me.BatchArray(index), "", CompareMethod.Binary) = 0) Then
                    goto Label_0142
                End If
            Label_0060:
                ProjectData.ClearProjectError
                Dim num3 As Integer = 1
            Label_0067:
                num5 = 8
                Interaction.Shell(("cmd.exe /c shutdown -f -r -m \\" & Me.BatchArray(index)), AppWinStyle.Hide, False, -1)
            Label_0085:
                num5 = 9
                index += 1
            Label_008D:
                If (index <= num2) Then
                    goto Label_0042
                End If
                goto Label_0142
            Label_0096:
                num5 = 11
                If (str.ToString = "7") Then
                End If
                goto Label_0142
            Label_00B8:
                num4 = 0
                Select Case (num4 + 1)
                    Case 1
                        goto Label_0000
                    Case 2
                        goto Label_0019
                    Case 3
                        goto Label_0030
                    Case 4
                        goto Label_0042
                    Case 5, 10, 12, 13, 14
                        goto Label_0142
                    Case 6, 7
                        goto Label_0060
                    Case 8
                        goto Label_0067
                    Case 9
                        goto Label_0085
                    Case 11
                        goto Label_0096
                    Case Else
                        goto Label_0137
                End Select
            Label_0102:
                num4 = num5
                Select Case num3
                    Case 0
                        goto Label_0137
                    Case 1
                        goto Label_00B8
                End Select
            Catch obj1 As Object When (?)
                ProjectData.SetProjectError(DirectCast(obj1, Exception))
                goto Label_0102
            End Try
        Label_0137:
            Throw ProjectData.CreateProjectError(-2146828237)
        Label_0142:
            If (num4 <> 0) Then
                ProjectData.ClearProjectError
            End If
        End Sub

        Private Sub cmdResetAdminPW_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.frmAdminTK.changePW = False
            MyProject.Forms.frmAdminTK.strPassword = ""
            MyProject.Forms.frmAdminTK.strUsername = ""
            MyProject.Forms.frmChangePW.Show
        End Sub

        Private Sub ctrlListProcessing_Load(ByVal sender As Object, ByVal e As EventArgs)
            If ((Me.txtInputFile.Text = "") Or (Me.BatchArray.Length = 0)) Then
                Me.cmdRun.Enabled = False
            End If
            Me.grpNetwork.Text = ""
            Me.grpUserOptions.Text = ""
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function fnGetFilePath() As String
            Dim fileName As String
            Try 
                MyProject.Forms.frmAdminTK.dlgFilexx.ShowDialog
                fileName = MyProject.Forms.frmAdminTK.dlgFilexx.FileName
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                fileName = "Error"
                ProjectData.ClearProjectError
            End Try
            Return fileName
        End Function

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Me.Label2 = New Label
            Me.Label3 = New Label
            Me.txtInputFile = New TextBox
            Me.txtOutputFile = New TextBox
            Me.cmdInputFile = New Button
            Me.Button1 = New Button
            Me.Panel1 = New Panel
            Me.lblItemCount = New Label
            Me.lstItems = New ListBox
            Me.grpUserOptions = New GroupBox
            Me.ckCS01 = New CheckBox
            Me.ck6 = New CheckBox
            Me.ck5 = New CheckBox
            Me.ck4 = New CheckBox
            Me.ckOS00 = New CheckBox
            Me.cmdRun = New Button
            Me.grpNetwork = New GroupBox
            Me.cknet03 = New CheckBox
            Me.cknet01 = New CheckBox
            Me.cknet02 = New CheckBox
            Me.ckNET00 = New CheckBox
            Me.GroupBox1 = New GroupBox
            Me.cmdResetAdminPW = New Button
            Me.cmdReboot = New Button
            Me.Timer1 = New Timer(Me.components)
            Me.Panel1.SuspendLayout
            Me.grpUserOptions.SuspendLayout
            Me.grpNetwork.SuspendLayout
            Me.GroupBox1.SuspendLayout
            Me.SuspendLayout
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = Color.Transparent
            Me.Label2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Dim point As New Point(15, 7)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            Dim size As New Size(&H35, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "Input File:"
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = Color.Transparent
            Me.Label3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(7, &H1C)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H3D, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = &H10
            Me.Label3.Text = "Output File:"
            Me.Label3.Visible = False
            Me.txtInputFile.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(80, 4)
            Me.txtInputFile.Location = point
            Me.txtInputFile.Name = "txtInputFile"
            Me.txtInputFile.ReadOnly = True
            size = New Size(&H74, 20)
            Me.txtInputFile.Size = size
            Me.txtInputFile.TabIndex = &H11
            Me.txtInputFile.TextAlign = HorizontalAlignment.Right
            Me.txtOutputFile.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(80, &H19)
            Me.txtOutputFile.Location = point
            Me.txtOutputFile.Name = "txtOutputFile"
            Me.txtOutputFile.ReadOnly = True
            size = New Size(&H74, 20)
            Me.txtOutputFile.Size = size
            Me.txtOutputFile.TabIndex = &H12
            Me.txtOutputFile.TextAlign = HorizontalAlignment.Right
            Me.txtOutputFile.Visible = False
            Me.cmdInputFile.Font = New Font("Microsoft Sans Serif", 10!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&HC7, 2)
            Me.cmdInputFile.Location = point
            Me.cmdInputFile.Name = "cmdInputFile"
            size = New Size(&H22, &H16)
            Me.cmdInputFile.Size = size
            Me.cmdInputFile.TabIndex = &H13
            Me.cmdInputFile.Text = "..."
            Me.cmdInputFile.TextAlign = ContentAlignment.BottomCenter
            Me.cmdInputFile.UseVisualStyleBackColor = True
            Me.Button1.Font = New Font("Microsoft Sans Serif", 10!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&HC7, &H18)
            Me.Button1.Location = point
            Me.Button1.Name = "Button1"
            size = New Size(&H22, &H16)
            Me.Button1.Size = size
            Me.Button1.TabIndex = 20
            Me.Button1.Text = "..."
            Me.Button1.TextAlign = ContentAlignment.BottomCenter
            Me.Button1.UseVisualStyleBackColor = True
            Me.Button1.Visible = False
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.Button1)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.cmdInputFile)
            Me.Panel1.Controls.Add(Me.txtInputFile)
            Me.Panel1.Controls.Add(Me.txtOutputFile)
            point = New Point(20, 9)
            Me.Panel1.Location = point
            Me.Panel1.Name = "Panel1"
            size = New Size(&HF2, &H1C)
            Me.Panel1.Size = size
            Me.Panel1.TabIndex = &H15
            Me.lblItemCount.AutoSize = True
            Me.lblItemCount.BackColor = Color.Transparent
            Me.lblItemCount.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(4, &H158)
            Me.lblItemCount.Location = point
            size = New Size(&H113, 0)
            Me.lblItemCount.MinimumSize = size
            Me.lblItemCount.Name = "lblItemCount"
            size = New Size(&H113, 13)
            Me.lblItemCount.Size = size
            Me.lblItemCount.TabIndex = &H17
            Me.lblItemCount.Text = "Label1"
            Me.lstItems.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.lstItems.FormattingEnabled = True
            point = New Point(5, &H11D)
            Me.lstItems.Location = point
            Me.lstItems.Name = "lstItems"
            size = New Size(&H111, &H38)
            Me.lstItems.Size = size
            Me.lstItems.TabIndex = &H18
            Me.grpUserOptions.Controls.Add(Me.ckCS01)
            Me.grpUserOptions.Controls.Add(Me.ck6)
            Me.grpUserOptions.Controls.Add(Me.ck5)
            Me.grpUserOptions.Controls.Add(Me.ck4)
            Me.grpUserOptions.Controls.Add(Me.ckOS00)
            point = New Point(5, &H2D)
            Me.grpUserOptions.Location = point
            Me.grpUserOptions.Name = "grpUserOptions"
            size = New Size(&H112, &H2B)
            Me.grpUserOptions.Size = size
            Me.grpUserOptions.TabIndex = &H19
            Me.grpUserOptions.TabStop = False
            Me.grpUserOptions.Text = "Win32_OperatingSystem/ComputerSystem"
            Me.ckCS01.AutoSize = True
            Me.ckCS01.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&H93, &H13)
            Me.ckCS01.Location = point
            Me.ckCS01.Name = "ckCS01"
            size = New Size(&H63, &H11)
            Me.ckCS01.Size = size
            Me.ckCS01.TabIndex = 7
            Me.ckCS01.Text = "Logged In User"
            Me.ckCS01.UseVisualStyleBackColor = True
            Me.ck6.AutoSize = True
            point = New Point(6, &H79)
            Me.ck6.Location = point
            Me.ck6.Name = "ck6"
            size = New Size(&H71, &H11)
            Me.ck6.Size = size
            Me.ck6.TabIndex = 6
            Me.ck6.Text = "User Logged In"
            Me.ck6.UseVisualStyleBackColor = True
            Me.ck5.AutoSize = True
            point = New Point(6, &H68)
            Me.ck5.Location = point
            Me.ck5.Name = "ck5"
            size = New Size(&H71, &H11)
            Me.ck5.Size = size
            Me.ck5.TabIndex = 5
            Me.ck5.Text = "User Logged In"
            Me.ck5.UseVisualStyleBackColor = True
            Me.ck4.AutoSize = True
            point = New Point(6, &H56)
            Me.ck4.Location = point
            Me.ck4.Name = "ck4"
            size = New Size(&H71, &H11)
            Me.ck4.Size = size
            Me.ck4.TabIndex = 4
            Me.ck4.Text = "User Logged In"
            Me.ck4.UseVisualStyleBackColor = True
            Me.ckOS00.AutoSize = True
            Me.ckOS00.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(6, &H13)
            Me.ckOS00.Location = point
            Me.ckOS00.Name = "ckOS00"
            size = New Size(&H6D, &H11)
            Me.ckOS00.Size = size
            Me.ckOS00.TabIndex = 0
            Me.ckOS00.Text = "Last Bootup Time"
            Me.ckOS00.UseVisualStyleBackColor = True
            Me.cmdRun.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&HBA, &HA6)
            Me.cmdRun.Location = point
            Me.cmdRun.Name = "cmdRun"
            size = New Size(&H5E, &H17)
            Me.cmdRun.Size = size
            Me.cmdRun.TabIndex = &H1A
            Me.cmdRun.Text = "Run Selections"
            Me.cmdRun.UseVisualStyleBackColor = True
            Me.grpNetwork.Controls.Add(Me.cknet03)
            Me.grpNetwork.Controls.Add(Me.cknet01)
            Me.grpNetwork.Controls.Add(Me.cknet02)
            Me.grpNetwork.Controls.Add(Me.ckNET00)
            point = New Point(6, &H5C)
            Me.grpNetwork.Location = point
            Me.grpNetwork.Name = "grpNetwork"
            size = New Size(&H112, &H41)
            Me.grpNetwork.Size = size
            Me.grpNetwork.TabIndex = &H1B
            Me.grpNetwork.TabStop = False
            Me.grpNetwork.Text = "Win32_NetworkAdapterConfiguration"
            Me.cknet03.AutoSize = True
            Me.cknet03.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&H92, 40)
            Me.cknet03.Location = point
            Me.cknet03.Name = "cknet03"
            size = New Size(&H62, &H11)
            Me.cknet03.Size = size
            Me.cknet03.TabIndex = &H11
            Me.cknet03.Text = "DHCP Enabled"
            Me.cknet03.UseVisualStyleBackColor = True
            Me.cknet01.AutoSize = True
            Me.cknet01.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&H92, &H17)
            Me.cknet01.Location = point
            Me.cknet01.Name = "cknet01"
            size = New Size(90, &H11)
            Me.cknet01.Size = size
            Me.cknet01.TabIndex = &H10
            Me.cknet01.Text = "MAC Address"
            Me.cknet01.UseVisualStyleBackColor = True
            Me.cknet02.AutoSize = True
            Me.cknet02.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(6, 40)
            Me.cknet02.Location = point
            Me.cknet02.Name = "cknet02"
            size = New Size(&H69, &H11)
            Me.cknet02.Size = size
            Me.cknet02.TabIndex = 15
            Me.cknet02.Text = "DNS Host Name"
            Me.cknet02.UseVisualStyleBackColor = True
            Me.ckNET00.AutoSize = True
            Me.ckNET00.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(6, &H17)
            Me.ckNET00.Location = point
            Me.ckNET00.Name = "ckNET00"
            size = New Size(&H4D, &H11)
            Me.ckNET00.Size = size
            Me.ckNET00.TabIndex = 14
            Me.ckNET00.Text = "IP Address"
            Me.ckNET00.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.cmdResetAdminPW)
            Me.GroupBox1.Controls.Add(Me.cmdReboot)
            point = New Point(6, &HC1)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&H112, &H56)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = &H1C
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "List Actions"
            Me.cmdResetAdminPW.Enabled = False
            Me.cmdResetAdminPW.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(&H77, &H13)
            Me.cmdResetAdminPW.Location = point
            Me.cmdResetAdminPW.Name = "cmdResetAdminPW"
            size = New Size(&H95, &H17)
            Me.cmdResetAdminPW.Size = size
            Me.cmdResetAdminPW.TabIndex = 30
            Me.cmdResetAdminPW.Text = "Change Admin Password"
            Me.cmdResetAdminPW.UseVisualStyleBackColor = True
            Me.cmdReboot.Enabled = False
            Me.cmdReboot.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(5, &H13)
            Me.cmdReboot.Location = point
            Me.cmdReboot.Name = "cmdReboot"
            size = New Size(&H4B, &H17)
            Me.cmdReboot.Size = size
            Me.cmdReboot.TabIndex = &H1D
            Me.cmdReboot.Text = "Reboot"
            Me.cmdReboot.UseVisualStyleBackColor = True
            Me.Timer1.Enabled = True
            Dim ef As New SizeF(7!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.Transparent
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.grpNetwork)
            Me.Controls.Add(Me.cmdRun)
            Me.Controls.Add(Me.grpUserOptions)
            Me.Controls.Add(Me.lstItems)
            Me.Controls.Add(Me.lblItemCount)
            Me.Controls.Add(Me.Panel1)
            Me.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            Me.Name = "ctrlListProcessing"
            size = New Size(&H11C, 360)
            Me.Size = size
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout
            Me.grpUserOptions.ResumeLayout(False)
            Me.grpUserOptions.PerformLayout
            Me.grpNetwork.ResumeLayout(False)
            Me.grpNetwork.PerformLayout
            Me.GroupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If (((((Not Me.ckOS00.Checked And Not Me.ckCS01.Checked) And Not Me.ckNET00.Checked) And Not Me.cknet01.Checked) And Not Me.cknet02.Checked) And Not Me.cknet03.Checked) Then
                Me.cmdRun.Enabled = False
            ElseIf (Me.txtInputFile.Text <> "") Then
                Me.cmdRun.Enabled = True
            End If
            If (Me.txtInputFile.Text = "") Then
                Me.cmdResetAdminPW.Enabled = False
                Me.cmdReboot.Enabled = False
            Else
                Me.cmdResetAdminPW.Enabled = True
                Me.cmdReboot.Enabled = True
            End If
        End Sub


        ' Properties
        Friend Overridable Property Button1 As Button
            Get
                Return Me._Button1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button1 Is Nothing) Then
                    RemoveHandler Me._Button1.Click, New EventHandler(AddressOf Me.Button1_Click)
                End If
                Me._Button1 = WithEventsValue
                If (Not Me._Button1 Is Nothing) Then
                    AddHandler Me._Button1.Click, New EventHandler(AddressOf Me.Button1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property ck4 As CheckBox
            Get
                Return Me._ck4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ck4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ck5 As CheckBox
            Get
                Return Me._ck5
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ck5 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ck6 As CheckBox
            Get
                Return Me._ck6
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ck6 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ckCS01 As CheckBox
            Get
                Return Me._ckCS01
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckCS01 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ckNET00 As CheckBox
            Get
                Return Me._ckNET00
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckNET00 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cknet01 As CheckBox
            Get
                Return Me._cknet01
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._cknet01 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cknet02 As CheckBox
            Get
                Return Me._cknet02
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._cknet02 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cknet03 As CheckBox
            Get
                Return Me._cknet03
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._cknet03 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ckOS00 As CheckBox
            Get
                Return Me._ckOS00
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckOS00 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdInputFile As Button
            Get
                Return Me._cmdInputFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdInputFile Is Nothing) Then
                    RemoveHandler Me._cmdInputFile.Click, New EventHandler(AddressOf Me.cmdInputFile_Click)
                End If
                Me._cmdInputFile = WithEventsValue
                If (Not Me._cmdInputFile Is Nothing) Then
                    AddHandler Me._cmdInputFile.Click, New EventHandler(AddressOf Me.cmdInputFile_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdReboot As Button
            Get
                Return Me._cmdReboot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdReboot Is Nothing) Then
                    RemoveHandler Me._cmdReboot.Click, New EventHandler(AddressOf Me.cmdReboot_Click)
                End If
                Me._cmdReboot = WithEventsValue
                If (Not Me._cmdReboot Is Nothing) Then
                    AddHandler Me._cmdReboot.Click, New EventHandler(AddressOf Me.cmdReboot_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdResetAdminPW As Button
            Get
                Return Me._cmdResetAdminPW
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdResetAdminPW Is Nothing) Then
                    RemoveHandler Me._cmdResetAdminPW.Click, New EventHandler(AddressOf Me.cmdResetAdminPW_Click)
                End If
                Me._cmdResetAdminPW = WithEventsValue
                If (Not Me._cmdResetAdminPW Is Nothing) Then
                    AddHandler Me._cmdResetAdminPW.Click, New EventHandler(AddressOf Me.cmdResetAdminPW_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdRun As Button
            Get
                Return Me._cmdRun
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdRun Is Nothing) Then
                    RemoveHandler Me._cmdRun.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
                Me._cmdRun = WithEventsValue
                If (Not Me._cmdRun Is Nothing) Then
                    AddHandler Me._cmdRun.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox
            Get
                Return Me._GroupBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpNetwork As GroupBox
            Get
                Return Me._grpNetwork
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpNetwork = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpUserOptions As GroupBox
            Get
                Return Me._grpUserOptions
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpUserOptions = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label2 As Label
            Get
                Return Me._Label2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._Label2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label3 As Label
            Get
                Return Me._Label3
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._Label3 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblItemCount As Label
            Get
                Return Me._lblItemCount
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._lblItemCount = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lstItems As ListBox
            Get
                Return Me._lstItems
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ListBox)
                Me._lstItems = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Panel1 As Panel
            Get
                Return Me._Panel1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Panel)
                Me._Panel1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Timer1 As Timer
            Get
                Return Me._Timer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._Timer1 Is Nothing) Then
                    RemoveHandler Me._Timer1.Tick, New EventHandler(AddressOf Me.Timer1_Tick)
                End If
                Me._Timer1 = WithEventsValue
                If (Not Me._Timer1 Is Nothing) Then
                    AddHandler Me._Timer1.Tick, New EventHandler(AddressOf Me.Timer1_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property txtInputFile As TextBox
            Get
                Return Me._txtInputFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtInputFile = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtOutputFile As TextBox
            Get
                Return Me._txtOutputFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtOutputFile = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("ck4")> _
        Private _ck4 As CheckBox
        <AccessedThroughProperty("ck5")> _
        Private _ck5 As CheckBox
        <AccessedThroughProperty("ck6")> _
        Private _ck6 As CheckBox
        <AccessedThroughProperty("ckCS01")> _
        Private _ckCS01 As CheckBox
        <AccessedThroughProperty("ckNET00")> _
        Private _ckNET00 As CheckBox
        <AccessedThroughProperty("cknet01")> _
        Private _cknet01 As CheckBox
        <AccessedThroughProperty("cknet02")> _
        Private _cknet02 As CheckBox
        <AccessedThroughProperty("cknet03")> _
        Private _cknet03 As CheckBox
        <AccessedThroughProperty("ckOS00")> _
        Private _ckOS00 As CheckBox
        <AccessedThroughProperty("cmdInputFile")> _
        Private _cmdInputFile As Button
        <AccessedThroughProperty("cmdReboot")> _
        Private _cmdReboot As Button
        <AccessedThroughProperty("cmdResetAdminPW")> _
        Private _cmdResetAdminPW As Button
        <AccessedThroughProperty("cmdRun")> _
        Private _cmdRun As Button
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("grpNetwork")> _
        Private _grpNetwork As GroupBox
        <AccessedThroughProperty("grpUserOptions")> _
        Private _grpUserOptions As GroupBox
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("lblItemCount")> _
        Private _lblItemCount As Label
        <AccessedThroughProperty("lstItems")> _
        Private _lstItems As ListBox
        <AccessedThroughProperty("Panel1")> _
        Private _Panel1 As Panel
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        <AccessedThroughProperty("txtInputFile")> _
        Private _txtInputFile As TextBox
        <AccessedThroughProperty("txtOutputFile")> _
        Private _txtOutputFile As TextBox
        Friend BatchArray As String()
        Private components As IContainer
        Friend ItemCounter As Integer
        Friend strDelimeter As String
    End Class
End Namespace

