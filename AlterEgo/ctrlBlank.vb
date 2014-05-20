Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class ctrlBlank
        Inherits UserControl
        ' Methods
        Public Sub New()
            Me.InitializeComponent
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
            Dim point As New Point(&H89, 5)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            Dim size As New Size(&H6A, 15)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Copy From Clipboard"
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
            point = New Point(&HCA, &H11)
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
            Me.grpGetUserLoggedIn.BackColor = Color.White
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
            point = New Point(200, &H11)
            Me.cmdMMCLaunch.Location = point
            Me.cmdMMCLaunch.Name = "cmdMMCLaunch"
            size = New Size(&H47, &H17)
            Me.cmdMMCLaunch.Size = size
            Me.cmdMMCLaunch.TabIndex = 7
            Me.cmdMMCLaunch.Text = "Launch"
            Me.cmdMMCLaunch.UseVisualStyleBackColor = True
            Me.cboMMC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.cboMMC.AutoCompleteSource = AutoCompleteSource.ListItems
            Me.cboMMC.FormattingEnabled = True
            point = New Point(6, &H13)
            Me.cboMMC.Location = point
            Me.cboMMC.Name = "cboMMC"
            size = New Size(&HBD, &H15)
            Me.cboMMC.Size = size
            Me.cboMMC.TabIndex = 4
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
            Me.BackColor = Color.White
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


        ' Properties
        Friend Overridable Property btnGetUserOnMachine As Button
            Get
                Return Me._btnGetUserOnMachine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._btnGetUserOnMachine = WithEventsValue
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
                Me._cboMMC = WithEventsValue
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
                Me._CHack = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdMMCLaunch As Button
            Get
                Return Me._cmdMMCLaunch
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._cmdMMCLaunch = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdNetInfo As Button
            Get
                Return Me._cmdNetInfo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._cmdNetInfo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdNetSend As Button
            Get
                Return Me._cmdNetSend
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._cmdNetSend = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdReboot As Button
            Get
                Return Me._cmdReboot
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._cmdReboot = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdRemoteDesktop As Button
            Get
                Return Me._cmdRemoteDesktop
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._cmdRemoteDesktop = WithEventsValue
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
                Me._Label1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtComment As TextBox
            Get
                Return Me._txtComment
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtComment = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtComputerName As EnterTextBox
            Get
                Return Me._txtComputerName
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                Me._txtComputerName = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtNSmsg As EnterTextBox
            Get
                Return Me._txtNSmsg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                Me._txtNSmsg = WithEventsValue
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

