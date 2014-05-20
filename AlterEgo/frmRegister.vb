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
    Public Class frmRegister
        Inherits Form
        ' Methods
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If (Strings.Trim(Me.txtUserID.Text) = "") Then
                MySettingsProperty.Settings.UserStringToRegister = "Demo"
                MySettingsProperty.Settings.Save
                Me.Hide
                Interaction.MsgBox("User ID cannot be Blank", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                MySettingsProperty.Settings.UserStringToRegister = Strings.Trim(Me.txtUserID.Text)
                MySettingsProperty.Settings.Save
                modMain.SubStartup
            End If
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close
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
            Me.txtUserID = New TextBox
            Me.Label2 = New Label
            Me.Button1 = New Button
            Me.Button2 = New Button
            Me.Label3 = New Label
            Me.SuspendLayout
            Me.Label1.AutoSize = True
            Dim point As New Point(15, &H30)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            Dim size As New Size(&H2E, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "User ID:"
            point = New Point(&H43, &H2D)
            Me.txtUserID.Location = point
            Me.txtUserID.Name = "txtUserID"
            size = New Size(&H107, 20)
            Me.txtUserID.Size = size
            Me.txtUserID.TabIndex = 1
            Me.Label2.AutoSize = True
            point = New Point(12, 9)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&HE1, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Enter your user ID from registration paperwork:"
            point = New Point(&HFF, &H47)
            Me.Button1.Location = point
            Me.Button1.Name = "Button1"
            size = New Size(&H4B, &H17)
            Me.Button1.Size = size
            Me.Button1.TabIndex = 3
            Me.Button1.Text = "Create Registration"
            Me.Button1.UseVisualStyleBackColor = True
            point = New Point(&HAE, &H47)
            Me.Button2.Location = point
            Me.Button2.Name = "Button2"
            size = New Size(&H4B, &H17)
            Me.Button2.Size = size
            Me.Button2.TabIndex = 4
            Me.Button2.Text = "Cancel"
            Me.Button2.UseVisualStyleBackColor = True
            Me.Label3.AutoSize = True
            point = New Point(&HF7, 9)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H53, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "(Case Sensitive)"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H153, &H69)
            Me.ClientSize = size
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtUserID)
            Me.Controls.Add(Me.Label1)
            Me.Name = "frmRegister"
            Me.Text = "Register"
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

        Friend Overridable Property Button2 As Button
            Get
                Return Me._Button2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Button2 Is Nothing) Then
                    RemoveHandler Me._Button2.Click, New EventHandler(AddressOf Me.Button2_Click)
                End If
                Me._Button2 = WithEventsValue
                If (Not Me._Button2 Is Nothing) Then
                    AddHandler Me._Button2.Click, New EventHandler(AddressOf Me.Button2_Click)
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

        Friend Overridable Property txtUserID As TextBox
            Get
                Return Me._txtUserID
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtUserID = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("Button2")> _
        Private _Button2 As Button
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("txtUserID")> _
        Private _txtUserID As TextBox
        Private components As IContainer
    End Class
End Namespace

