Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class frmBatchResults
        Inherits Form
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
            Me.txtResults = New TextBox
            Me.SuspendLayout
            Dim point As New Point(12, 12)
            Me.txtResults.Location = point
            Me.txtResults.Multiline = True
            Me.txtResults.Name = "txtResults"
            Dim size As New Size(&H25C, &H174)
            Me.txtResults.Size = size
            Me.txtResults.TabIndex = 0
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H271, &H196)
            Me.ClientSize = size
            Me.Controls.Add(Me.txtResults)
            Me.Name = "frmBatchResults"
            Me.Text = "BatchResults"
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub


        ' Properties
        Friend Overridable Property txtResults As TextBox
            Get
                Return Me._txtResults
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtResults = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("txtResults")> _
        Private _txtResults As TextBox
        Private components As IContainer
    End Class
End Namespace

