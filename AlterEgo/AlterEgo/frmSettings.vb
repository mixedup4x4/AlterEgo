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
    Public Class frmSettings
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmSettings_Load)
            Me.InitializeComponent
        End Sub

        Private Sub cmdCreateFile_Click(ByVal sender As Object, ByVal e As EventArgs)
            Interaction.MsgBox(Application.StartupPath, MsgBoxStyle.ApplicationModal, Nothing)
            Dim writer As StreamWriter = File.CreateText((Application.StartupPath & "\AuthEncrypt.AE"))
            writer.WriteLine(Environment.UserName)
            writer.WriteLine(Me.txtUN.Text)
            writer.WriteLine(Me.txtPass.Text)
            writer.Close
            Interaction.MsgBox("Authentication SAVED!!!", MsgBoxStyle.ApplicationModal, Nothing)
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmSettings_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.tmrfrmSettings.Enabled = True
            Me.txtEnvironmentUser.Text = Environment.UserName
            If MySettingsProperty.Settings.SavePassword Then
                Me.ckEnablePWSave.Checked = True
                Me.txtUN.Text = "Password Saved"
            Else
                Me.ckEnablePWSave.Checked = False
            End If
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(frmSettings))
            Me.GroupBox1 = New GroupBox
            Me.cmdCreateFile = New Button
            Me.ckEnablePWSave = New CheckBox
            Me.pnlPasswordInfo = New Panel
            Me.Label3 = New Label
            Me.Label2 = New Label
            Me.Label1 = New Label
            Me.txtPass = New TextBox
            Me.txtUN = New TextBox
            Me.txtEnvironmentUser = New TextBox
            Me.Label4 = New Label
            Me.tmrfrmSettings = New Timer(Me.components)
            Me.GroupBox1.SuspendLayout
            Me.pnlPasswordInfo.SuspendLayout
            Me.SuspendLayout
            Me.GroupBox1.Controls.Add(Me.cmdCreateFile)
            Me.GroupBox1.Controls.Add(Me.ckEnablePWSave)
            Me.GroupBox1.Controls.Add(Me.pnlPasswordInfo)
            Me.GroupBox1.Controls.Add(Me.Label4)
            Dim point As New Point(12, 12)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            Dim size As New Size(&H16A, &HBB)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = 1
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Save AlterEgo's Password"
            point = New Point(13, 120)
            Me.cmdCreateFile.Location = point
            Me.cmdCreateFile.Name = "cmdCreateFile"
            size = New Size(&H88, &H17)
            Me.cmdCreateFile.Size = size
            Me.cmdCreateFile.TabIndex = 2
            Me.cmdCreateFile.Text = "Create Auth File"
            Me.cmdCreateFile.UseVisualStyleBackColor = True
            Me.ckEnablePWSave.AutoSize = True
            point = New Point(13, &H53)
            Me.ckEnablePWSave.Location = point
            Me.ckEnablePWSave.Name = "ckEnablePWSave"
            size = New Size(&H88, &H11)
            Me.ckEnablePWSave.Size = size
            Me.ckEnablePWSave.TabIndex = 7
            Me.ckEnablePWSave.Text = "Enable Password Save"
            Me.ckEnablePWSave.UseVisualStyleBackColor = True
            Me.pnlPasswordInfo.Controls.Add(Me.Label3)
            Me.pnlPasswordInfo.Controls.Add(Me.Label2)
            Me.pnlPasswordInfo.Controls.Add(Me.Label1)
            Me.pnlPasswordInfo.Controls.Add(Me.txtPass)
            Me.pnlPasswordInfo.Controls.Add(Me.txtUN)
            Me.pnlPasswordInfo.Controls.Add(Me.txtEnvironmentUser)
            Me.pnlPasswordInfo.Enabled = False
            point = New Point(&H9B, &H53)
            Me.pnlPasswordInfo.Location = point
            Me.pnlPasswordInfo.Name = "pnlPasswordInfo"
            size = New Size(200, 100)
            Me.pnlPasswordInfo.Size = size
            Me.pnlPasswordInfo.TabIndex = 6
            Me.Label3.AutoSize = True
            point = New Point(&H1D, &H45)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H38, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = 10
            Me.Label3.Text = "Password:"
            Me.Label2.AutoSize = True
            point = New Point(12, &H2B)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H4B, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 9
            Me.Label2.Text = "Your AlterEgo:"
            Me.Label1.AutoSize = True
            point = New Point(&H10, &H11)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H45, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 8
            Me.Label1.Text = "Current User:"
            point = New Point(&H58, &H42)
            Me.txtPass.Location = point
            Me.txtPass.Name = "txtPass"
            size = New Size(100, 20)
            Me.txtPass.Size = size
            Me.txtPass.TabIndex = 7
            Me.txtPass.UseSystemPasswordChar = True
            point = New Point(&H58, 40)
            Me.txtUN.Location = point
            Me.txtUN.Name = "txtUN"
            size = New Size(100, 20)
            Me.txtUN.Size = size
            Me.txtUN.TabIndex = 6
            point = New Point(&H58, 14)
            Me.txtEnvironmentUser.Location = point
            Me.txtEnvironmentUser.Name = "txtEnvironmentUser"
            Me.txtEnvironmentUser.ReadOnly = True
            size = New Size(100, 20)
            Me.txtEnvironmentUser.Size = size
            Me.txtEnvironmentUser.TabIndex = 5
            point = New Point(&H29, &H10)
            Me.Label4.Location = point
            size = New Size(300, 20)
            Me.Label4.MinimumSize = size
            Me.Label4.Name = "Label4"
            size = New Size(300, 60)
            Me.Label4.Size = size
            Me.Label4.TabIndex = 5
            Me.Label4.Text = manager.GetString("Label4.Text")
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H240, &H1B3)
            Me.ClientSize = size
            Me.Controls.Add(Me.GroupBox1)
            Me.Name = "frmSettings"
            Me.Text = "frmSettings"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout
            Me.pnlPasswordInfo.ResumeLayout(False)
            Me.pnlPasswordInfo.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Private Sub tmrfrmSettings_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If Me.ckEnablePWSave.Checked Then
                Me.pnlPasswordInfo.Enabled = True
                Me.cmdCreateFile.Enabled = True
            Else
                Me.pnlPasswordInfo.Enabled = False
                Me.cmdCreateFile.Enabled = False
            End If
        End Sub


        ' Properties
        Friend Overridable Property ckEnablePWSave As CheckBox
            Get
                Return Me._ckEnablePWSave
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckEnablePWSave = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdCreateFile As Button
            Get
                Return Me._cmdCreateFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdCreateFile Is Nothing) Then
                    RemoveHandler Me._cmdCreateFile.Click, New EventHandler(AddressOf Me.cmdCreateFile_Click)
                End If
                Me._cmdCreateFile = WithEventsValue
                If (Not Me._cmdCreateFile Is Nothing) Then
                    AddHandler Me._cmdCreateFile.Click, New EventHandler(AddressOf Me.cmdCreateFile_Click)
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

        Friend Overridable Property Label1 As Label
            Get
                Return Me._Label1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._Label1 = WithEventsValue
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

        Friend Overridable Property Label4 As Label
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._Label4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property pnlPasswordInfo As Panel
            Get
                Return Me._pnlPasswordInfo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Panel)
                Me._pnlPasswordInfo = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tmrfrmSettings As Timer
            Get
                Return Me._tmrfrmSettings
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._tmrfrmSettings Is Nothing) Then
                    RemoveHandler Me._tmrfrmSettings.Tick, New EventHandler(AddressOf Me.tmrfrmSettings_Tick)
                End If
                Me._tmrfrmSettings = WithEventsValue
                If (Not Me._tmrfrmSettings Is Nothing) Then
                    AddHandler Me._tmrfrmSettings.Tick, New EventHandler(AddressOf Me.tmrfrmSettings_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property txtEnvironmentUser As TextBox
            Get
                Return Me._txtEnvironmentUser
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtEnvironmentUser = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtPass As TextBox
            Get
                Return Me._txtPass
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtPass = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtUN As TextBox
            Get
                Return Me._txtUN
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtUN = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("ckEnablePWSave")> _
        Private _ckEnablePWSave As CheckBox
        <AccessedThroughProperty("cmdCreateFile")> _
        Private _cmdCreateFile As Button
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label
        <AccessedThroughProperty("pnlPasswordInfo")> _
        Private _pnlPasswordInfo As Panel
        <AccessedThroughProperty("tmrfrmSettings")> _
        Private _tmrfrmSettings As Timer
        <AccessedThroughProperty("txtEnvironmentUser")> _
        Private _txtEnvironmentUser As TextBox
        <AccessedThroughProperty("txtPass")> _
        Private _txtPass As TextBox
        <AccessedThroughProperty("txtUN")> _
        Private _txtUN As TextBox
        Private components As IContainer
    End Class
End Namespace

