Imports AlterEgo.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class frmChangePWSingle
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmChangePW_Load)
            Me.ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width
            Me.ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height
            Me.InitializeComponent
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Strings.StrComp(Me.txtPass1.Text, Me.txtPass2.Text, CompareMethod.Binary) <> 0) Then
                Interaction.MsgBox("Passwords Don't Match...", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Try 
                    MyProject.Forms.frmAdminTK.changePW = True
                    Me.Hide
                    MyProject.Forms.frmAdminTK.AdminTabsControl1.CtrlListProcessing1.ChangePasswords(MyProject.Forms.frmAdminTK.AdminTabsControl1.CtrlComputerInfo1.txtComputerName.Text, Me.txtUsername.Text, Me.txtPass1.Text)
                    Interaction.MsgBox("Password changes completed", MsgBoxStyle.ApplicationModal, Nothing)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Interaction.MsgBox(("an Error occurred " & ChrW(13) & ChrW(10) & exception1.ToString), MsgBoxStyle.ApplicationModal, Nothing)
                    ProjectData.ClearProjectError
                End Try
                Me.Dispose
            End If
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.frmAdminTK.strPassword = ""
            MyProject.Forms.frmAdminTK.strUsername = ""
            MyProject.Forms.frmAdminTK.changePW = False
            Me.Dispose
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmChangePW_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As frmChangePWSingle = Me
            num.Top = CInt(Math.Round(CDbl((CDbl((Me.ScreenHeight - num.Height)) / 2))))
            num.Left = CInt(Math.Round(CDbl((CDbl((Me.ScreenWidth - num.Width)) / 2))))
            num.Text = ("Change PW - " & modMain.CurrentUser)
            num = Nothing
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(frmChangePWSingle))
            Me.Button1 = New Button
            Me.txtUsername = New TextBox
            Me.txtPass1 = New TextBox
            Me.txtPass2 = New TextBox
            Me.Label1 = New Label
            Me.Label2 = New Label
            Me.Label3 = New Label
            Me.cmdCancel = New Button
            Me.TextBox1 = New TextBox
            Me.ckCreateAdminAccount = New CheckBox
            Me.ckOWAccount = New CheckBox
            Me.SuspendLayout
            Dim point As New Point(120, &HBF)
            Me.Button1.Location = point
            Me.Button1.Name = "Button1"
            Dim size As New Size(&H70, &H1F)
            Me.Button1.Size = size
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Execute"
            Me.Button1.UseVisualStyleBackColor = True
            point = New Point(90, &H61)
            Me.txtUsername.Location = point
            Me.txtUsername.Name = "txtUsername"
            size = New Size(&HA7, 20)
            Me.txtUsername.Size = size
            Me.txtUsername.TabIndex = 1
            point = New Point(90, &H7B)
            Me.txtPass1.Location = point
            Me.txtPass1.Name = "txtPass1"
            size = New Size(&HA7, 20)
            Me.txtPass1.Size = size
            Me.txtPass1.TabIndex = 2
            Me.txtPass1.UseSystemPasswordChar = True
            point = New Point(90, &H95)
            Me.txtPass2.Location = point
            Me.txtPass2.Name = "txtPass2"
            size = New Size(&HA7, 20)
            Me.txtPass2.Size = size
            Me.txtPass2.TabIndex = 3
            Me.txtPass2.UseSystemPasswordChar = True
            Me.Label1.AutoSize = True
            point = New Point(&H18, 100)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(60, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "UserName:"
            Me.Label2.AutoSize = True
            point = New Point(&H18, &H7E)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H38, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Password:"
            Me.Label3.AutoSize = True
            point = New Point(&H18, &H95)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H2D, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = 6
            Me.Label3.Text = "Confirm:"
            point = New Point(&HEE, &HC0)
            Me.cmdCancel.Location = point
            Me.cmdCancel.Name = "cmdCancel"
            size = New Size(&H70, &H1F)
            Me.cmdCancel.Size = size
            Me.cmdCancel.TabIndex = 7
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = True
            Me.TextBox1.BackColor = SystemColors.Control
            point = New Point(12, 12)
            Me.TextBox1.Location = point
            Me.TextBox1.Multiline = True
            Me.TextBox1.Name = "TextBox1"
            size = New Size(&H1AC, &H44)
            Me.TextBox1.Size = size
            Me.TextBox1.TabIndex = 8
            Me.TextBox1.Text = manager.GetString("TextBox1.Text")
            Me.ckCreateAdminAccount.AutoSize = True
            point = New Point(&H11B, 100)
            Me.ckCreateAdminAccount.Location = point
            Me.ckCreateAdminAccount.Name = "ckCreateAdminAccount"
            size = New Size(&H9D, &H11)
            Me.ckCreateAdminAccount.Size = size
            Me.ckCreateAdminAccount.TabIndex = 9
            Me.ckCreateAdminAccount.Text = "Create New Admin Account"
            Me.ckCreateAdminAccount.UseVisualStyleBackColor = True
            Me.ckOWAccount.AutoSize = True
            point = New Point(&H11B, &H7E)
            Me.ckOWAccount.Location = point
            Me.ckOWAccount.Name = "ckOWAccount"
            size = New Size(&H9E, &H11)
            Me.ckOWAccount.Size = size
            Me.ckOWAccount.TabIndex = 10
            Me.ckOWAccount.Text = "Overwrite Existing Accounts"
            Me.ckOWAccount.UseVisualStyleBackColor = True
            Me.ckOWAccount.Visible = False
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H1CB, &HEE)
            Me.ClientSize = size
            Me.Controls.Add(Me.ckOWAccount)
            Me.Controls.Add(Me.ckCreateAdminAccount)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.cmdCancel)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.txtPass2)
            Me.Controls.Add(Me.txtPass1)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.Button1)
            Me.Name = "frmChangePW"
            Me.Text = "Batch Change Passwords"
            Me.ResumeLayout(False)
            Me.PerformLayout
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

        Friend Overridable Property ckCreateAdminAccount As CheckBox
            Get
                Return Me._ckCreateAdminAccount
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckCreateAdminAccount = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ckOWAccount As CheckBox
            Get
                Return Me._ckOWAccount
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckOWAccount = WithEventsValue
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

        Friend Overridable Property TextBox1 As TextBox
            Get
                Return Me._TextBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._TextBox1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtPass1 As TextBox
            Get
                Return Me._txtPass1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtPass1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtPass2 As TextBox
            Get
                Return Me._txtPass2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtPass2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtUsername As TextBox
            Get
                Return Me._txtUsername
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtUsername = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("ckCreateAdminAccount")> _
        Private _ckCreateAdminAccount As CheckBox
        <AccessedThroughProperty("ckOWAccount")> _
        Private _ckOWAccount As CheckBox
        <AccessedThroughProperty("cmdCancel")> _
        Private _cmdCancel As Button
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("TextBox1")> _
        Private _TextBox1 As TextBox
        <AccessedThroughProperty("txtPass1")> _
        Private _txtPass1 As TextBox
        <AccessedThroughProperty("txtPass2")> _
        Private _txtPass2 As TextBox
        <AccessedThroughProperty("txtUsername")> _
        Private _txtUsername As TextBox
        Private components As IContainer
        Friend ScreenHeight As Integer
        Friend ScreenWidth As Integer

        Sub Show()
            Throw New NotImplementedException
        End Sub

    End Class
End Namespace

