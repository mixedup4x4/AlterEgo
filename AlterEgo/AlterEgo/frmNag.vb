Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class frmNag
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmNag_Load)
            Me.InitializeComponent
        End Sub

        Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            UFR.UFR(Me.str1, Me.str2, Me.int3)
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmNag_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.Button1.Enabled = False
            Me.txtNag.Text = "Make this go away.  Purchase a License!!" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10)
            Me.txtNag.Text = (Me.txtNag.Text & "A license enables all features that are disabled or timed in the demo version")
            Me.txtNag.Text = (Me.txtNag.Text & "Features include Commandeer Desktop, Explore, and Run in the AE Menu.")
            Me.txtNag.Text = (Me.txtNag.Text & "The Run Command button will enable in 30 seconds")
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Me.Timer1 = New Timer(Me.components)
            Me.txtNag = New TextBox
            Me.Button1 = New Button
            Me.SuspendLayout
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = &H4E20
            Me.txtNag.BackColor = SystemColors.ButtonFace
            Me.txtNag.BorderStyle = BorderStyle.None
            Dim point As New Point(12, 12)
            Me.txtNag.Location = point
            Me.txtNag.Multiline = True
            Me.txtNag.Name = "txtNag"
            Me.txtNag.ReadOnly = True
            Dim size As New Size(&HF1, &H72)
            Me.txtNag.Size = size
            Me.txtNag.TabIndex = 9
            point = New Point(12, &H84)
            Me.Button1.Location = point
            Me.Button1.Name = "Button1"
            size = New Size(&HF1, &H27)
            Me.Button1.Size = size
            Me.Button1.TabIndex = 0
            Me.Button1.Text = "Run Command"
            Me.Button1.UseVisualStyleBackColor = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H109, &HB8)
            Me.ClientSize = size
            Me.Controls.Add(Me.txtNag)
            Me.Controls.Add(Me.Button1)
            Me.Name = "frmNag"
            Me.Text = "Alter Ego Nag "
            Me.TopMost = True
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Friend Sub passvar(ByVal xyz As String, ByVal type As String, ByVal ID As Integer)
            Me.str1 = xyz
            Me.str2 = type
            Me.int3 = ID
        End Sub

        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.Button1.Enabled = True
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

        Friend Overridable Property txtNag As TextBox
            Get
                Return Me._txtNag
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtNag = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("Button1")> _
        Private _Button1 As Button
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        <AccessedThroughProperty("txtNag")> _
        Private _txtNag As TextBox
        Private components As IContainer
        Private int3 As Integer
        Private str1 As String
        Private str2 As String
    End Class
End Namespace

