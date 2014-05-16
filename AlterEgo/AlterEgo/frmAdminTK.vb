Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class frmAdminTK
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmAdminTK_Load)
            Me.dlgFilexx = New OpenFileDialog
            Me.ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width
            Me.ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height
            Me.InitializeComponent
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmAdminTK_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim ntk As frmAdminTK = Me
            ntk.Top = CInt(Math.Round(CDbl((CDbl((Me.ScreenHeight - ntk.Height)) / 2))))
            ntk.Left = CInt(Math.Round(CDbl((CDbl((Me.ScreenWidth - ntk.Width)) / 2))))
            ntk.Text = ("Admin Tool Kit - " & modMain.CurrentUser)
            ntk = Nothing
            Me.dlgFilexx.Title = "Select File..."
            Me.dlgFilexx.InitialDirectory = Conversions.ToString(0)
            Me.dlgFilexx.Filter = "All Files (*.*)|*.*"
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.AdminTabsControl1 = New AdminTabsControl
            Me.SuspendLayout
            Me.AdminTabsControl1.BackColor = Color.Transparent
            Me.AdminTabsControl1.BorderStyle = BorderStyle.Fixed3D
            Dim point As New Point(-1, 1)
            Me.AdminTabsControl1.Location = point
            Me.AdminTabsControl1.Name = "AdminTabsControl1"
            Dim size As New Size(&H13C, &H18F)
            Me.AdminTabsControl1.Size = size
            Me.AdminTabsControl1.TabIndex = 0
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.White
            size = New Size(&H138, &H18A)
            Me.ClientSize = size
            Me.Controls.Add(Me.AdminTabsControl1)
            Me.Name = "frmAdminTK"
            Me.Text = "frmAdminTK"
            Me.ResumeLayout(False)
        End Sub


        ' Properties
        Friend Overridable Property AdminTabsControl1 As AdminTabsControl
            Get
                Return Me._AdminTabsControl1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As AdminTabsControl)
                Me._AdminTabsControl1 = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("AdminTabsControl1")> _
        Private _AdminTabsControl1 As AdminTabsControl
        Friend changePW As Boolean
        Private components As IContainer
        Friend dlgFilexx As OpenFileDialog
        Friend ScreenHeight As Integer
        Friend ScreenWidth As Integer
        Friend strPassword As String
        Friend strUsername As String
    End Class
End Namespace

