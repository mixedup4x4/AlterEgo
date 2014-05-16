Imports AlterEgo.My
Imports AlterEgo.My.Resources
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public NotInheritable Class frmSplash
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmSplash_Load)
            Me.InitializeComponent
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.lblbuild.Text = ("bld. " & MySettingsProperty.Settings.appbld)
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = MySettingsProperty.Settings.SplashTime
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Me.Timer1 = New Timer(Me.components)
            Me.lblbuild = New Label
            Me.SuspendLayout
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = &HFA0
            Me.lblbuild.AutoSize = True
            Me.lblbuild.BackColor = Color.Transparent
            Me.lblbuild.Font = New Font("Ravie", 8!, FontStyle.Regular, GraphicsUnit.Point, 0)
            Me.lblbuild.ForeColor = Color.DimGray
            Dim point As New Point(&HE4, &H11C)
            Me.lblbuild.Location = point
            Me.lblbuild.Name = "lblbuild"
            Dim size As New Size(&H3F, &H11)
            Me.lblbuild.Size = size
            Me.lblbuild.TabIndex = 0
            Me.lblbuild.Text = "build 70"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackgroundImage = Resources.splash
            size = New Size(&H1F0, &H12F)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.lblbuild)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmSplash"
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            Me.Timer1.Enabled = False
            modMain.statupLocationSetting
            Me.Dispose
        End Sub


        ' Properties
        Friend Overridable Property lblbuild As Label
            Get
                Return Me._lblbuild
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._lblbuild = WithEventsValue
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


        ' Fields
        <AccessedThroughProperty("lblbuild")> _
        Private _lblbuild As Label
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        Private components As IContainer
    End Class
End Namespace

