Imports AlterEgo.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class ctrlComputerInfo
        Inherits UserControl
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.ctrlCompuerInfo_Load)
            Me.InitializeComponent
        End Sub

        Private Sub btnGetComputerOnMachine_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim prompt As String = fnGetUserOnMachine.fnGetUserOnMachine(Me.txtComputerName.Text)
            If (prompt <> "") Then
                Interaction.MsgBox(prompt, MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End Sub

        Private Sub cboActions_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Private Sub cboMMC_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyCode = Keys.Enter) Then
                e.Handled = True
                Interaction.Shell(("cmd.exe /c " & modMSC.MSC(Me.cboMMC.SelectedIndex, 1) & "/computer " & Strings.Trim(Me.txtComputerName.Text)), AppWinStyle.Hide, False, -1)
            End If
        End Sub

        Private Sub CHack_Click(ByVal sender As Object, ByVal e As EventArgs)
            ModFN.OpenFolder(("\\" & Me.txtComputerName.Text & "\C$"))
        End Sub

        Private Sub cmdCreateLocal_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.frmChangePWSingle.Show
        End Sub

        Private Sub cmdMMCLaunch_Click(ByVal sender As Object, ByVal e As EventArgs)
            Interaction.Shell(("cmd.exe /c " & modMSC.MSC(Me.cboMMC.SelectedIndex, 1) & " /computer=\\" & Strings.Trim(Me.txtComputerName.Text)), AppWinStyle.Hide, False, -1)
        End Sub

        Private Sub cmdNetInfo_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.frmNetworkInfo.PCName = Me.txtComputerName.Text
            MyProject.Forms.frmNetworkInfo.Show
        End Sub

        Private Sub cmdNetSend_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Conversions.ToInteger(fnNetSend.fnNetSend(Strings.Trim(Me.txtComputerName.Text), Strings.Trim(Me.txtNSmsg.Text))) = 1) Then
                Interaction.MsgBox("NetSend Completed Sucessfully", MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End Sub

        Private Sub cmdReboot_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Conversions.ToString(CInt(Interaction.MsgBox("This will reboot The Machine." & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & "Do you wish to continue?", MsgBoxStyle.YesNo, "Reboot Machine?")))
            If (str.ToString = "6") Then
                Dim cmd As String = "shutdown -f "
                If (Me.cboShutdownType.SelectedText = "Shutdown") Then
                    cmd = (cmd & "-s ")
                Else
                    cmd = (cmd & "-r ")
                End If
                cmd = (cmd & "-m \\" & Me.txtComputerName.Text)
                Dim text As String = Me.cboMinutes.Text
                [text] = [text].Replace("min", "")
                cmd = (cmd & " -t " & Conversions.ToString(CInt((Convert.ToInt32([text]) * 60))))
                Me.subShell(cmd)
            ElseIf (str.ToString <> "7") Then
            End If
        End Sub

        Private Sub cmdRemoteDesktop_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.subShell(("mstsc /v " & Strings.Trim(Me.txtComputerName.Text)))
        End Sub

        Private Sub Comment_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.cmdReboot.Enabled = True
        End Sub

        Private Sub ctrlCompuerInfo_Load(ByVal sender As Object, ByVal e As EventArgs)
            modMSC.LoadMSCArray
            Dim num2 As Integer = (Information.UBound(modMSC.MSC, 1) - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.cboMMC.Items.Add(modMSC.MSC(i, 0))
                i += 1
            Loop
            Me.txtComputerName.Text = Environment.MachineName
            Me.txtComputerName.Select
            Me.txtNSmsg.Text = "Enter Your NetSend Mesage Here"
            Me.cboMinutes.SelectedItem = "60 min"
            Me.cboShutdownType.SelectedItem = "Reboot"
            Me.txtComment.Text = "Enter your Shutdown Message Here"
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.Label1 = New Label
            Me.grpNS = New GroupBox
            Me.cmdNetSend = New Button
            Me.txtNSmsg = New EnterTextBox
            Me.grpGetUserLoggedIn = New GroupBox
            Me.cmdCreateLocal = New Button
            Me.CHack = New Button
            Me.cmdNetInfo = New Button
            Me.btnGetUserOnMachine = New Button
            Me.GroupBox1 = New GroupBox
            Me.cmdMMCLaunch = New Button
            Me.cboMMC = New EnterComboBox
            Me.GroupBox2 = New GroupBox
            Me.txtComment = New TextBox
            Me.cboMinutes = New ComboBox
            Me.cboShutdownType = New ComboBox
            Me.cmdRemoteDesktop = New Button
            Me.cmdReboot = New Button
            Me.txtComputerName = New EnterTextBox
            Me.grpNS.SuspendLayout
            Me.grpGetUserLoggedIn.SuspendLayout
            Me.GroupBox1.SuspendLayout
            Me.GroupBox2.SuspendLayout
            Me.SuspendLayout
            Me.Label1.AutoSize = True
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Dim point As New Point(&H88, 3)
            Me.Label1.Location = point
            Dim size As New Size(&H6D, &H13)
            Me.Label1.MinimumSize = size
            Me.Label1.Name = "Label1"
            size = New Size(&H6D, &H13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Paste From Clipboard"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            Me.grpNS.BackColor = Color.Transparent
            Me.grpNS.Controls.Add(Me.cmdNetSend)
            Me.grpNS.Controls.Add(Me.txtNSmsg)
            point = New Point(5, &HB7)
            Me.grpNS.Location = point
            Me.grpNS.Name = "grpNS"
            size = New Size(&H117, &H34)
            Me.grpNS.Size = size
            Me.grpNS.TabIndex = 11
            Me.grpNS.TabStop = False
            Me.grpNS.Text = "NetSend"
            point = New Point(&HCA, &H12)
            Me.cmdNetSend.Location = point
            Me.cmdNetSend.Name = "cmdNetSend"
            size = New Size(&H47, &H17)
            Me.cmdNetSend.Size = size
            Me.cmdNetSend.TabIndex = 6
            Me.cmdNetSend.Text = "Send"
            Me.cmdNetSend.UseVisualStyleBackColor = True
            point = New Point(7, &H13)
            Me.txtNSmsg.Location = point
            Me.txtNSmsg.Multiline = True
            Me.txtNSmsg.Name = "txtNSmsg"
            size = New Size(&HBD, &H15)
            Me.txtNSmsg.Size = size
            Me.txtNSmsg.TabIndex = 2
            Me.grpGetUserLoggedIn.BackColor = Color.Transparent
            Me.grpGetUserLoggedIn.Controls.Add(Me.cmdCreateLocal)
            Me.grpGetUserLoggedIn.Controls.Add(Me.CHack)
            Me.grpGetUserLoggedIn.Controls.Add(Me.cmdNetInfo)
            Me.grpGetUserLoggedIn.Controls.Add(Me.btnGetUserOnMachine)
            point = New Point(5, 40)
            Me.grpGetUserLoggedIn.Location = point
            Me.grpGetUserLoggedIn.Name = "grpGetUserLoggedIn"
            size = New Size(&H112, &H51)
            Me.grpGetUserLoggedIn.Size = size
            Me.grpGetUserLoggedIn.TabIndex = 9
            Me.grpGetUserLoggedIn.TabStop = False
            Me.grpGetUserLoggedIn.Text = "Remote Information"
            point = New Point(&H72, 20)
            Me.cmdCreateLocal.Location = point
            Me.cmdCreateLocal.Name = "cmdCreateLocal"
            size = New Size(&H9A, &H17)
            Me.cmdCreateLocal.Size = size
            Me.cmdCreateLocal.TabIndex = 3
            Me.cmdCreateLocal.Text = "Create Local Admin Account"
            Me.cmdCreateLocal.UseVisualStyleBackColor = True
            point = New Point(9, 50)
            Me.CHack.Location = point
            Me.CHack.Name = "CHack"
            size = New Size(&H63, &H17)
            Me.CHack.Size = size
            Me.CHack.TabIndex = 2
            Me.CHack.Text = "C$ Share"
            Me.CHack.UseVisualStyleBackColor = True
            point = New Point(9, &H15)
            Me.cmdNetInfo.Location = point
            Me.cmdNetInfo.Name = "cmdNetInfo"
            size = New Size(&H63, &H17)
            Me.cmdNetInfo.Size = size
            Me.cmdNetInfo.TabIndex = 1
            Me.cmdNetInfo.Text = "Network Config"
            Me.cmdNetInfo.UseVisualStyleBackColor = True
            point = New Point(9, &H15)
            Me.btnGetUserOnMachine.Location = point
            Me.btnGetUserOnMachine.Name = "btnGetUserOnMachine"
            size = New Size(&H57, &H17)
            Me.btnGetUserOnMachine.Size = size
            Me.btnGetUserOnMachine.TabIndex = 0
            Me.btnGetUserOnMachine.Text = "Current User"
            Me.btnGetUserOnMachine.UseVisualStyleBackColor = True
            Me.GroupBox1.BackColor = Color.Transparent
            Me.GroupBox1.Controls.Add(Me.cmdMMCLaunch)
            Me.GroupBox1.Controls.Add(Me.cboMMC)
            point = New Point(5, &H7F)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&H117, 50)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = 10
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Admin Tools (built-in MMC)"
            point = New Point(200, &H12)
            Me.cmdMMCLaunch.Location = point
            Me.cmdMMCLaunch.Name = "cmdMMCLaunch"
            size = New Size(&H47, &H17)
            Me.cmdMMCLaunch.Size = size
            Me.cmdMMCLaunch.TabIndex = 7
            Me.cmdMMCLaunch.Text = "Launch"
            Me.cmdMMCLaunch.UseVisualStyleBackColor = True
            Me.cboMMC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cboMMC.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cboMMC.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboMMC.FormattingEnabled = True
            point = New Point(6, &H13)
            Me.cboMMC.Location = point
            Me.cboMMC.Name = "cboMMC"
            size = New Size(&HBD, &H15)
            Me.cboMMC.Size = size
            Me.cboMMC.TabIndex = 4
            Me.GroupBox2.BackColor = Color.Transparent
            Me.GroupBox2.Controls.Add(Me.txtComment)
            Me.GroupBox2.Controls.Add(Me.cboMinutes)
            Me.GroupBox2.Controls.Add(Me.cboShutdownType)
            Me.GroupBox2.Controls.Add(Me.cmdRemoteDesktop)
            Me.GroupBox2.Controls.Add(Me.cmdReboot)
            point = New Point(5, &HF1)
            Me.GroupBox2.Location = point
            Me.GroupBox2.Name = "GroupBox2"
            size = New Size(&H117, &H70)
            Me.GroupBox2.Size = size
            Me.GroupBox2.TabIndex = 14
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Remote Machine"
            Me.txtComment.Enabled = False
            point = New Point(9, &H52)
            Me.txtComment.Location = point
            Me.txtComment.Name = "txtComment"
            size = New Size(&H106, 20)
            Me.txtComment.Size = size
            Me.txtComment.TabIndex = 5
            Me.cboMinutes.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboMinutes.FormattingEnabled = True
            Me.cboMinutes.Items.AddRange(New Object() { "1 min", "2 min", "3 min", "4 min", "5 min", "6 min", "7 min ", "8 min", "9 min", "10 min", "15 min", "20 min", "25 min", "30 min", "35 min", "40 min", "45 min", "50 min", "55 min", "60 min", "120 min", "180 min", "240 min", "300 min", "360 min", "420 min", "480 min", "540 min", "600 min", "660 min", "720 min", "780 min", "840 min", "900 min", "960 min", "1020 min", "1080 min", "1140 min", "1200 min", "1260 min", "1320 min", "1380 min", "1440 min", "1500 min", "1560 min", "1620 min", "1680 min", "1740 min", "1800 min", "1860 min", "1920 min", "1980 min", "2040 min", "2100 min", "2160 min", "2220 min", "2280 min", "2340 min", "2400 min", "2460 min", "2520 min", "2580 min", "2640 min", "2700 min", "2760 min", "2820 min", "2880 min", "2940 min", "3000 min", "3060 min", "3120 min " })
            point = New Point(&H72, &H35)
            Me.cboMinutes.Location = point
            Me.cboMinutes.Name = "cboMinutes"
            size = New Size(&H44, &H15)
            Me.cboMinutes.Size = size
            Me.cboMinutes.TabIndex = 4
            Me.cboShutdownType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboShutdownType.FormattingEnabled = True
            Me.cboShutdownType.Items.AddRange(New Object() { "Reboot", "Shutdown" })
            point = New Point(8, &H35)
            Me.cboShutdownType.Location = point
            Me.cboShutdownType.Name = "cboShutdownType"
            size = New Size(100, &H15)
            Me.cboShutdownType.Size = size
            Me.cboShutdownType.TabIndex = 3
            point = New Point(8, &H16)
            Me.cmdRemoteDesktop.Location = point
            Me.cmdRemoteDesktop.Name = "cmdRemoteDesktop"
            size = New Size(&H107, &H17)
            Me.cmdRemoteDesktop.Size = size
            Me.cmdRemoteDesktop.TabIndex = 2
            Me.cmdRemoteDesktop.Text = "Remote Desktop"
            Me.cmdRemoteDesktop.UseVisualStyleBackColor = True
            point = New Point(&HBC, &H34)
            Me.cmdReboot.Location = point
            Me.cmdReboot.Name = "cmdReboot"
            size = New Size(&H53, &H17)
            Me.cmdReboot.Size = size
            Me.cmdReboot.TabIndex = 0
            Me.cmdReboot.Text = "Reboot"
            Me.cmdReboot.UseVisualStyleBackColor = True
            point = New Point(10, 2)
            Me.txtComputerName.Location = point
            Me.txtComputerName.Name = "txtComputerName"
            size = New Size(&H79, 20)
            Me.txtComputerName.Size = size
            Me.txtComputerName.TabIndex = 13
            Me.txtComputerName.Text = "Enter Name or IP"
            Me.txtComputerName.TextAlign = HorizontalAlignment.Center
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.Transparent
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.txtComputerName)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.grpNS)
            Me.Controls.Add(Me.grpGetUserLoggedIn)
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "ctrlComputerInfo"
            size = New Size(290, &H16E)
            Me.Size = size
            Me.grpNS.ResumeLayout(False)
            Me.grpNS.PerformLayout
            Me.grpGetUserLoggedIn.ResumeLayout(False)
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub Label1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.subClipboard
        End Sub

        Friend Sub subClipboard()
            Dim text As String = Clipboard.GetText
            Me.txtComputerName.Text = Strings.Trim([text])
        End Sub

        Friend Sub subOpenFile(ByVal eFileName As String)
            Try 
                Dim info As New ProcessStartInfo(eFileName)
                Dim process As New Process
                process.StartInfo = info
                process.Start
                info = Nothing
                process = Nothing
            Catch exception1 As FileNotFoundException
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Interaction.MsgBox(exception3.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Sub subShell(ByVal cmd As String)
            Interaction.Shell(("cmd.exe /c " & cmd), AppWinStyle.Hide, False, -1)
        End Sub

        Friend Sub subShellStay(ByVal cmd As String)
            Interaction.Shell(("cmd.exe /k " & cmd), AppWinStyle.Hide, False, -1)
        End Sub

        Private Sub txtComputerName_Leave(ByVal sender As Object, ByVal e As EventArgs)
            Me.txtComputerName.Text = Strings.Trim(Me.txtComputerName.Text.ToUpper)
        End Sub

        Private Sub txtComputerName_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.txtComputerName.Select(0, Me.txtComputerName.Text.Length)
        End Sub

        Private Sub txtNSmsg_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyCode = Keys.Enter) Then
                e.Handled = True
                If (Conversions.ToInteger(fnNetSend.fnNetSend(Strings.Trim(Me.txtComputerName.Text), Strings.Trim(Me.txtNSmsg.Text))) = 1) Then
                    Interaction.MsgBox("NetSend Completed Sucessfully", MsgBoxStyle.ApplicationModal, Nothing)
                End If
            End If
        End Sub

        Private Sub txtNSmsg_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.txtNSmsg.Select(0, Me.txtNSmsg.Text.Length)
        End Sub


        ' Properties
        Friend Overridable Property btnGetUserOnMachine As Button
            Get
                Return Me._btnGetUserOnMachine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._btnGetUserOnMachine Is Nothing) Then
                    RemoveHandler Me._btnGetUserOnMachine.Click, New EventHandler(AddressOf Me.btnGetComputerOnMachine_Click)
                End If
                Me._btnGetUserOnMachine = WithEventsValue
                If (Not Me._btnGetUserOnMachine Is Nothing) Then
                    AddHandler Me._btnGetUserOnMachine.Click, New EventHandler(AddressOf Me.btnGetComputerOnMachine_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cboMinutes As ComboBox
            Get
                Return Me._cboMinutes
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._cboMinutes = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cboMMC As EnterComboBox
            Get
                Return Me._cboMMC
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterComboBox)
                If (Not Me._cboMMC Is Nothing) Then
                    RemoveHandler Me._cboMMC.SelectedIndexChanged, New EventHandler(AddressOf Me.cboActions_SelectedIndexChanged_1)
                    RemoveHandler Me._cboMMC.KeyDown, New KeyEventHandler(AddressOf Me.cboMMC_KeyDown)
                End If
                Me._cboMMC = WithEventsValue
                If (Not Me._cboMMC Is Nothing) Then
                    AddHandler Me._cboMMC.SelectedIndexChanged, New EventHandler(AddressOf Me.cboActions_SelectedIndexChanged_1)
                    AddHandler Me._cboMMC.KeyDown, New KeyEventHandler(AddressOf Me.cboMMC_KeyDown)
                End If
            End Set
        End Property

        Friend Overridable Property cboShutdownType As ComboBox
            Get
                Return Me._cboShutdownType
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._cboShutdownType = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CHack As Button
            Get
                Return Me._CHack
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._CHack Is Nothing) Then
                    RemoveHandler Me._CHack.Click, New EventHandler(AddressOf Me.CHack_Click)
                End If
                Me._CHack = WithEventsValue
                If (Not Me._CHack Is Nothing) Then
                    AddHandler Me._CHack.Click, New EventHandler(AddressOf Me.CHack_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdCreateLocal As Button
            Get
                Return Me._cmdCreateLocal
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdCreateLocal Is Nothing) Then
                    RemoveHandler Me._cmdCreateLocal.Click, New EventHandler(AddressOf Me.cmdCreateLocal_Click)
                End If
                Me._cmdCreateLocal = WithEventsValue
                If (Not Me._cmdCreateLocal Is Nothing) Then
                    AddHandler Me._cmdCreateLocal.Click, New EventHandler(AddressOf Me.cmdCreateLocal_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdMMCLaunch As Button
            Get
                Return Me._cmdMMCLaunch
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdMMCLaunch Is Nothing) Then
                    RemoveHandler Me._cmdMMCLaunch.Click, New EventHandler(AddressOf Me.cmdMMCLaunch_Click)
                End If
                Me._cmdMMCLaunch = WithEventsValue
                If (Not Me._cmdMMCLaunch Is Nothing) Then
                    AddHandler Me._cmdMMCLaunch.Click, New EventHandler(AddressOf Me.cmdMMCLaunch_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdNetInfo As Button
            Get
                Return Me._cmdNetInfo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdNetInfo Is Nothing) Then
                    RemoveHandler Me._cmdNetInfo.Click, New EventHandler(AddressOf Me.cmdNetInfo_Click)
                End If
                Me._cmdNetInfo = WithEventsValue
                If (Not Me._cmdNetInfo Is Nothing) Then
                    AddHandler Me._cmdNetInfo.Click, New EventHandler(AddressOf Me.cmdNetInfo_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdNetSend As Button
            Get
                Return Me._cmdNetSend
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdNetSend Is Nothing) Then
                    RemoveHandler Me._cmdNetSend.Click, New EventHandler(AddressOf Me.cmdNetSend_Click)
                End If
                Me._cmdNetSend = WithEventsValue
                If (Not Me._cmdNetSend Is Nothing) Then
                    AddHandler Me._cmdNetSend.Click, New EventHandler(AddressOf Me.cmdNetSend_Click)
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

        Friend Overridable Property cmdRemoteDesktop As Button
            Get
                Return Me._cmdRemoteDesktop
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdRemoteDesktop Is Nothing) Then
                    RemoveHandler Me._cmdRemoteDesktop.Click, New EventHandler(AddressOf Me.cmdRemoteDesktop_Click)
                End If
                Me._cmdRemoteDesktop = WithEventsValue
                If (Not Me._cmdRemoteDesktop Is Nothing) Then
                    AddHandler Me._cmdRemoteDesktop.Click, New EventHandler(AddressOf Me.cmdRemoteDesktop_Click)
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

        Friend Overridable Property GroupBox2 As GroupBox
            Get
                Return Me._GroupBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpGetUserLoggedIn As GroupBox
            Get
                Return Me._grpGetUserLoggedIn
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpGetUserLoggedIn = WithEventsValue
            End Set
        End Property

        Friend Overridable Property grpNS As GroupBox
            Get
                Return Me._grpNS
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpNS = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Label1 As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                If (Not Me._Label1 Is Nothing) Then
                    RemoveHandler Me._Label1.Click, New EventHandler(AddressOf Me.Label1_Click)
                End If
                Me._Label1 = WithEventsValue
                If (Not Me._Label1 Is Nothing) Then
                    AddHandler Me._Label1.Click, New EventHandler(AddressOf Me.Label1_Click)
                End If
            End Set
        End Property

        Friend Overridable Property txtComment As TextBox
            Get
                Return Me._txtComment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                If (Not Me._txtComment Is Nothing) Then
                    RemoveHandler Me._txtComment.TextChanged, New EventHandler(AddressOf Me.Comment_TextChanged)
                End If
                Me._txtComment = WithEventsValue
                If (Not Me._txtComment Is Nothing) Then
                    AddHandler Me._txtComment.TextChanged, New EventHandler(AddressOf Me.Comment_TextChanged)
                End If
            End Set
        End Property

        Friend Overridable Property txtComputerName As EnterTextBox
            Get
                Return Me._txtComputerName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                If (Not Me._txtComputerName Is Nothing) Then
                    RemoveHandler Me._txtComputerName.MouseDoubleClick, New MouseEventHandler(AddressOf Me.txtComputerName_MouseDoubleClick)
                    RemoveHandler Me._txtComputerName.Leave, New EventHandler(AddressOf Me.txtComputerName_Leave)
                End If
                Me._txtComputerName = WithEventsValue
                If (Not Me._txtComputerName Is Nothing) Then
                    AddHandler Me._txtComputerName.MouseDoubleClick, New MouseEventHandler(AddressOf Me.txtComputerName_MouseDoubleClick)
                    AddHandler Me._txtComputerName.Leave, New EventHandler(AddressOf Me.txtComputerName_Leave)
                End If
            End Set
        End Property

        Friend Overridable Property txtNSmsg As EnterTextBox
            Get
                Return Me._txtNSmsg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                If (Not Me._txtNSmsg Is Nothing) Then
                    RemoveHandler Me._txtNSmsg.MouseDoubleClick, New MouseEventHandler(AddressOf Me.txtNSmsg_MouseDoubleClick)
                    RemoveHandler Me._txtNSmsg.KeyDown, New KeyEventHandler(AddressOf Me.txtNSmsg_KeyDown)
                End If
                Me._txtNSmsg = WithEventsValue
                If (Not Me._txtNSmsg Is Nothing) Then
                    AddHandler Me._txtNSmsg.MouseDoubleClick, New MouseEventHandler(AddressOf Me.txtNSmsg_MouseDoubleClick)
                    AddHandler Me._txtNSmsg.KeyDown, New KeyEventHandler(AddressOf Me.txtNSmsg_KeyDown)
                End If
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("btnGetUserOnMachine")> _
        Private _btnGetUserOnMachine As Button
        <AccessedThroughProperty("cboMinutes")> _
        Private _cboMinutes As ComboBox
        <AccessedThroughProperty("cboMMC")> _
        Private _cboMMC As EnterComboBox
        <AccessedThroughProperty("cboShutdownType")> _
        Private _cboShutdownType As ComboBox
        <AccessedThroughProperty("CHack")> _
        Private _CHack As Button
        <AccessedThroughProperty("cmdCreateLocal")> _
        Private _cmdCreateLocal As Button
        <AccessedThroughProperty("cmdMMCLaunch")> _
        Private _cmdMMCLaunch As Button
        <AccessedThroughProperty("cmdNetInfo")> _
        Private _cmdNetInfo As Button
        <AccessedThroughProperty("cmdNetSend")> _
        Private _cmdNetSend As Button
        <AccessedThroughProperty("cmdReboot")> _
        Private _cmdReboot As Button
        <AccessedThroughProperty("cmdRemoteDesktop")> _
        Private _cmdRemoteDesktop As Button
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("GroupBox2")> _
        Private _GroupBox2 As GroupBox
        <AccessedThroughProperty("grpGetUserLoggedIn")> _
        Private _grpGetUserLoggedIn As GroupBox
        <AccessedThroughProperty("grpNS")> _
        Private _grpNS As GroupBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("txtComment")> _
        Private _txtComment As TextBox
        <AccessedThroughProperty("txtComputerName")> _
        Private _txtComputerName As EnterTextBox
        <AccessedThroughProperty("txtNSmsg")> _
        Private _txtNSmsg As EnterTextBox
        Private components As IContainer
    End Class
End Namespace

