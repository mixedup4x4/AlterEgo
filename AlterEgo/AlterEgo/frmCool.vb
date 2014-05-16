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
    Public Class frmCool
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Shown, New EventHandler(AddressOf Me.frmCool_Shown)
            AddHandler MyBase.DragDrop, New DragEventHandler(AddressOf Me.frmCool_DragDrop)
            Me.InitializeComponent
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmCool_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            Interaction.MsgBox(e.Data, MsgBoxStyle.ApplicationModal, Nothing)
        End Sub

        Private Sub frmCool_Shown(ByVal sender As Object, ByVal e As EventArgs)
            Me.subrefreshfrmCool
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Me.picBox = New PictureBox
            Me.Timer1 = New Timer(Me.components)
            DirectCast(Me.picBox, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.picBox.BackColor = SystemColors.ControlDarkDark
            Me.picBox.BackgroundImageLayout = ImageLayout.None
            Me.picBox.Dock = DockStyle.Fill
            Dim point As New Point(0, 0)
            Me.picBox.Location = point
            Me.picBox.Name = "picBox"
            Dim size As New Size(&H42, &H3E)
            Me.picBox.Size = size
            Me.picBox.SizeMode = PictureBoxSizeMode.Zoom
            Me.picBox.TabIndex = 0
            Me.picBox.TabStop = False
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 10
            Me.AllowDrop = True
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.BackColor = Color.Red
            size = New Size(&H42, &H3E)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.picBox)
            Me.FormBorderStyle = FormBorderStyle.None
            Me.Name = "frmCool"
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.StartPosition = FormStartPosition.CenterParent
            Me.Text = "frmCool"
            Me.TransparencyKey = SystemColors.ControlDarkDark
            Me.WindowState = FormWindowState.Minimized
            DirectCast(Me.picBox, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
        End Sub

        Friend Sub subrefreshfrmCool()
            Dim num As Double = (CDbl(modMain.ObjImg(modMain.UserIcon).Height) / CDbl(modMain.ObjImg(modMain.UserIcon).Width))
            Me.Width = MySettingsProperty.Settings.intWinImageSize
            Me.Height = CInt(Math.Round(Conversion.Int(CDbl((num * MySettingsProperty.Settings.intWinImageSize)))))
            Me.picBox.Width = Me.Width
            Me.picBox.Height = Me.Height
            Me.picBox.ContextMenuStrip = MyProject.Forms.frmTreeMenu.assMenu
            Me.Left = (modMain.ScreenWidth - Me.Width)
            Me.Top = (modMain.ScreenHeight - Me.Height)
            Me.TopMost = True
            Me.Opacity = 1
            Me.picBox.Image = modMain.ObjImg(modMain.UserIcon)
            Me.WindowState = FormWindowState.Normal
        End Sub


        ' Properties
        Friend Overridable Property picBox As PictureBox
            Get
                Return Me._picBox
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._picBox = WithEventsValue
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
        <AccessedThroughProperty("picBox")> _
        Private _picBox As PictureBox
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        Private components As IContainer
    End Class
End Namespace

