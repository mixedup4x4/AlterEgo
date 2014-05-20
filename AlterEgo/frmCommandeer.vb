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
    Public Class frmCommandeer
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmCommandeer_Load)
            Me.lblMessage = New Label
            Me.exp = New Process
            Me.CommandeerButtonWidth = 90
            Me.CommandeerButtonHeight = 30
            Me.CommandeerFormWidth = 250
            Me.CommandeerFormHeight = 150
            Me.Proceed = 0
            Me.InitializeComponent
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide
        End Sub

        Private Sub cmdCommandeer_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.KILLEXPLORER
            Me.gp2.Visible = True
            Me.gp1.Visible = False
            modMain.subOpenFile("explorer.exe")
        End Sub

        Private Sub cmdRelinquish_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Me.KILLEXPLORER
                Interaction.Shell(("cmd.exe /c runas /user:" & modMain.UserLoggedInLocally & " explorer.exe"), AppWinStyle.Hide, False, -1)
                modMain.WriteRegHack
                Me.Dispose
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Me.Hide
                Interaction.MsgBox(exception.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                Interaction.MsgBox("Computer Configuration does not allow this functionality.  Commandeer can be reenabled on the Modify Menu Form", MsgBoxStyle.ApplicationModal, Nothing)
                MySettingsProperty.Settings.Commandeer = False
                MyProject.Forms.frmTreeMenu.ckCommandeer.Checked = False
                modFileSettingsandArray.SaveSettings
                modFileSettingsandArray.LoadSettings
                MyProject.Forms.frmTreeMenu.subFormLoadRefresh
                Me.Dispose
                ProjectData.ClearProjectError
            End Try
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Friend Sub DrawComandeerForm()
            If (MySettingsProperty.Settings.intStatupLocation = 0) Then
                Me.Left = (modMain.ScreenWidth - Me.Width)
                Me.Top = (modMain.ScreenHeight - Me.Height)
            Else
                Me.Left = (modMain.ScreenWidth - Me.Width)
                Me.Top = (modMain.ScreenHeight - (Me.Height + MyProject.Forms.frmCool.Height))
            End If
        End Sub

        Private Sub frmCommandeer_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.DrawComandeerForm
            Me.Text = modMain.CurrentUser
            Me.lblAE.Text = modMain.CurrentUser
            Me.lblDesktop.Text = modMain.UserLoggedInLocally.ToUpper
            Me.gp2.Visible = False
            Me.gp1.Visible = True
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(frmCommandeer))
            Me.checkTimer = New Timer(Me.components)
            Me.cmdCommandeer = New Button
            Me.cmdCancel = New Button
            Me.gp1 = New GroupBox
            Me.TextBox1 = New TextBox
            Me.lblAE = New Label
            Me.lblDesktop = New Label
            Me.Label1 = New Label
            Me.lblInfo = New Label
            Me.TextBox2 = New TextBox
            Me.gp2 = New GroupBox
            Me.cmdRelinquish = New Button
            Me.Timer1 = New Timer(Me.components)
            Me.gp1.SuspendLayout
            Me.gp2.SuspendLayout
            Me.SuspendLayout
            Me.checkTimer.Enabled = True
            Me.checkTimer.Interval = &HFA0
            Dim point As New Point(&H57, &H68)
            Me.cmdCommandeer.Location = point
            Me.cmdCommandeer.Name = "cmdCommandeer"
            Dim size As New Size(&H4B, &H17)
            Me.cmdCommandeer.Size = size
            Me.cmdCommandeer.TabIndex = 0
            Me.cmdCommandeer.Text = "Commandere"
            Me.cmdCommandeer.UseVisualStyleBackColor = True
            point = New Point(6, &H68)
            Me.cmdCancel.Location = point
            Me.cmdCancel.Name = "cmdCancel"
            size = New Size(&H4B, &H17)
            Me.cmdCancel.Size = size
            Me.cmdCancel.TabIndex = 1
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = True
            Me.gp1.Controls.Add(Me.TextBox1)
            Me.gp1.Controls.Add(Me.lblAE)
            Me.gp1.Controls.Add(Me.lblDesktop)
            Me.gp1.Controls.Add(Me.Label1)
            Me.gp1.Controls.Add(Me.lblInfo)
            Me.gp1.Controls.Add(Me.cmdCommandeer)
            Me.gp1.Controls.Add(Me.cmdCancel)
            point = New Point(12, 12)
            Me.gp1.Location = point
            Me.gp1.Name = "gp1"
            size = New Size(&H10C, &H85)
            Me.gp1.Size = size
            Me.gp1.TabIndex = 2
            Me.gp1.TabStop = False
            Me.gp1.Text = "Commandeer Desktop"
            Me.TextBox1.BackColor = SystemColors.Control
            Me.TextBox1.BorderStyle = BorderStyle.None
            point = New Point(11, &H37)
            Me.TextBox1.Location = point
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            size = New Size(&HFB, &H29)
            Me.TextBox1.Size = size
            Me.TextBox1.TabIndex = 6
            Me.TextBox1.Text = "This will KILL all explorer processes running on the machine and then load Explorer.exe as your Alter Ego.  "
            Me.lblAE.AutoSize = True
            point = New Point(&H6A, &H21)
            Me.lblAE.Location = point
            Me.lblAE.Name = "lblAE"
            size = New Size(&H54, 13)
            Me.lblAE.Size = size
            Me.lblAE.TabIndex = 5
            Me.lblAE.Text = "Desktop Owner:"
            Me.lblDesktop.AutoSize = True
            point = New Point(&H6B, &H11)
            Me.lblDesktop.Location = point
            Me.lblDesktop.Name = "lblDesktop"
            size = New Size(&H54, 13)
            Me.lblDesktop.Size = size
            Me.lblDesktop.TabIndex = 4
            Me.lblDesktop.Text = "Desktop Owner:"
            Me.Label1.AutoSize = True
            Me.Label1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(8, &H21)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H3F, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Alter Ego:"
            Me.lblInfo.AutoSize = True
            Me.lblInfo.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(8, &H11)
            Me.lblInfo.Location = point
            Me.lblInfo.Name = "lblInfo"
            size = New Size(&H62, 13)
            Me.lblInfo.Size = size
            Me.lblInfo.TabIndex = 2
            Me.lblInfo.Text = "Desktop Owner:"
            Me.TextBox2.BackColor = SystemColors.Control
            Me.TextBox2.BorderStyle = BorderStyle.None
            point = New Point(11, 20)
            Me.TextBox2.Location = point
            Me.TextBox2.Multiline = True
            Me.TextBox2.Name = "TextBox2"
            size = New Size(&HFB, &H4E)
            Me.TextBox2.Size = size
            Me.TextBox2.TabIndex = 6
            Me.TextBox2.Text = "Click ""Relinquish Control"" to give control back.  " & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & "The user's password is required."
            Me.gp2.Controls.Add(Me.TextBox2)
            Me.gp2.Controls.Add(Me.cmdRelinquish)
            point = New Point(12, 12)
            Me.gp2.Location = point
            Me.gp2.Name = "gp2"
            size = New Size(&H10C, &H85)
            Me.gp2.Size = size
            Me.gp2.TabIndex = 7
            Me.gp2.TabStop = False
            Me.gp2.Text = "Relinquish Desktop"
            point = New Point(6, &H68)
            Me.cmdRelinquish.Location = point
            Me.cmdRelinquish.Name = "cmdRelinquish"
            size = New Size(&H8A, &H17)
            Me.cmdRelinquish.Size = size
            Me.cmdRelinquish.TabIndex = 1
            Me.cmdRelinquish.Text = "Relinquish Control"
            Me.cmdRelinquish.UseVisualStyleBackColor = True
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = &HFA0
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H124, &H9D)
            Me.ClientSize = size
            Me.Controls.Add(Me.gp2)
            Me.Controls.Add(Me.gp1)
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "frmCommandeer"
            Me.Text = "Please Wait..."
            Me.gp1.ResumeLayout(False)
            Me.gp1.PerformLayout
            Me.gp2.ResumeLayout(False)
            Me.gp2.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Friend Sub KILLEXPLORER()
            Try 
                Dim processesByName As Process() = Process.GetProcessesByName("Explorer")
                Dim i As Integer
                For i = 0 To processesByName.Length - 1
                    Me.exp = processesByName(i)
                    Me.exp.Kill
                Next i
                modMain.RevertRegHack
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Me.Hide
                Interaction.MsgBox(exception.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                Interaction.MsgBox("Computer Configuration does not allow this functionality.  Commandeer can be reenabled on the Modify Menu Form", MsgBoxStyle.ApplicationModal, Nothing)
                MySettingsProperty.Settings.Commandeer = False
                MyProject.Forms.frmTreeMenu.ckCommandeer.Checked = False
                modFileSettingsandArray.SaveSettings
                modFileSettingsandArray.LoadSettings
                MyProject.Forms.frmTreeMenu.subFormLoadRefresh
                Me.Dispose
                ProjectData.ClearProjectError
            End Try
        End Sub


        ' Properties
        Friend Overridable Property checkTimer As Timer
            Get
                Return Me._checkTimer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Timer)
                Me._checkTimer = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdCancel As Button
            Get
                Return Me._cmdCancel
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdCancel Is Nothing) Then
                    RemoveHandler Me._cmdCancel.Click, New EventHandler(AddressOf Me.cmdCancel_Click)
                End If
                Me._cmdCancel = WithEventsValue
                If (Not Me._cmdCancel Is Nothing) Then
                    AddHandler Me._cmdCancel.Click, New EventHandler(AddressOf Me.cmdCancel_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdCommandeer As Button
            Get
                Return Me._cmdCommandeer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdCommandeer Is Nothing) Then
                    RemoveHandler Me._cmdCommandeer.Click, New EventHandler(AddressOf Me.cmdCommandeer_Click)
                End If
                Me._cmdCommandeer = WithEventsValue
                If (Not Me._cmdCommandeer Is Nothing) Then
                    AddHandler Me._cmdCommandeer.Click, New EventHandler(AddressOf Me.cmdCommandeer_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdRelinquish As Button
            Get
                Return Me._cmdRelinquish
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdRelinquish Is Nothing) Then
                    RemoveHandler Me._cmdRelinquish.Click, New EventHandler(AddressOf Me.cmdRelinquish_Click)
                End If
                Me._cmdRelinquish = WithEventsValue
                If (Not Me._cmdRelinquish Is Nothing) Then
                    AddHandler Me._cmdRelinquish.Click, New EventHandler(AddressOf Me.cmdRelinquish_Click)
                End If
            End Set
        End Property

        Friend Overridable Property gp1 As GroupBox
            Get
                Return Me._gp1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._gp1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property gp2 As GroupBox
            Get
                Return Me._gp2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._gp2 = WithEventsValue
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

        Friend Overridable Property lblAE As Label
            Get
                Return Me._lblAE
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._lblAE = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblDesktop As Label
            Get
                Return Me._lblDesktop
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._lblDesktop = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblInfo As Label
            Get
                Return Me._lblInfo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._lblInfo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox1 As TextBox
            Get
                Return Me._TextBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property TextBox2 As TextBox
            Get
                Return Me._TextBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Timer1 As Timer
            Get
                Return Me._Timer1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Timer)
                Me._Timer1 = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("checkTimer")> _
        Private _checkTimer As Timer
        <AccessedThroughProperty("cmdCancel")> _
        Private _cmdCancel As Button
        <AccessedThroughProperty("cmdCommandeer")> _
        Private _cmdCommandeer As Button
        <AccessedThroughProperty("cmdRelinquish")> _
        Private _cmdRelinquish As Button
        <AccessedThroughProperty("gp1")> _
        Private _gp1 As GroupBox
        <AccessedThroughProperty("gp2")> _
        Private _gp2 As GroupBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("lblAE")> _
        Private _lblAE As Label
        <AccessedThroughProperty("lblDesktop")> _
        Private _lblDesktop As Label
        <AccessedThroughProperty("lblInfo")> _
        Private _lblInfo As Label
        <AccessedThroughProperty("TextBox1")> _
        Private _TextBox1 As TextBox
        <AccessedThroughProperty("TextBox2")> _
        Private _TextBox2 As TextBox
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        Friend CommandeerButtonHeight As Integer
        Friend CommandeerButtonWidth As Integer
        Friend CommandeerFormHeight As Integer
        Friend CommandeerFormWidth As Integer
        Private components As IContainer
        Friend exp As Process
        Friend lblMessage As Label
        Friend oCommandeerFile As File
        Friend Proceed As Integer
    End Class
End Namespace

