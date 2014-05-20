Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Friend Class frmRun
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmRun_Load)
            Me.ucRun1 = New ucRun
            Me.InitializeComponent
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmRun_Load(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Me.TopMost = True
                Me.Visible = False
                Me.Controls.Add(Me.ucRun1)
                Me.Width = (Me.ucRun1.Width + modMain.intSpacer)
                Me.Height = CInt(Math.Round(CDbl((Me.ucRun1.Height + (modMain.intSpacer * 1.5)))))
                Me.Left = (modMain.ScreenWidth - Me.Width)
                Me.Top = (modMain.ScreenHeight - Me.Height)
                Me.subLoadHistory
                Me.Visible = True
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.MsgBox(exception.Message.ToString, MsgBoxStyle.Critical, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Dim manager As New ComponentResourceManager(GetType(frmRun))
            Me.SuspendLayout
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Dim size As New Size(&H124, &H10A)
            Me.ClientSize = size
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.Name = "frmRun"
            Me.ShowInTaskbar = False
            Me.Text = "Run"
            Me.ResumeLayout(False)
        End Sub

        Friend Sub subLoadHistory()
            Try 
                Dim num As Integer = (modMain.runItemCounter - 1)
                modMain.loopCounter = 0
                Do While (modMain.loopCounter <= num)
                    If (Strings.StrComp(modMain.arrayRun(modMain.loopCounter), "", CompareMethod.Text) <> 0) Then
                        Me.ucRun1.cboRun.Items.Add(modMain.arrayRun(modMain.loopCounter))
                    End If
                    modMain.loopCounter += 1
                Loop
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.MsgBox(exception.Message.ToString, MsgBoxStyle.Critical, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub


        ' Fields
        Private components As IContainer
        Friend ucRun1 As ucRun
    End Class
End Namespace

