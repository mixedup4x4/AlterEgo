Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class AdminTabsControl
        Inherits UserControl
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
            Me.Tabs = New TabControl
            Me.tabMachine = New TabPage
            Me.CtrlComputerInfo1 = New ctrlComputerInfo
            Me.ListProcessing = New TabPage
            Me.CtrlListProcessing1 = New ctrlListProcessing
            Me.Tabs.SuspendLayout
            Me.tabMachine.SuspendLayout
            Me.ListProcessing.SuspendLayout
            Me.SuspendLayout
            Me.Tabs.Controls.Add(Me.tabMachine)
            Me.Tabs.Controls.Add(Me.ListProcessing)
            Dim point As New Point(0, 0)
            Me.Tabs.Location = point
            Me.Tabs.Name = "Tabs"
            Me.Tabs.SelectedIndex = 0
            Dim size As New Size(&H139, &H187)
            Me.Tabs.Size = size
            Me.Tabs.TabIndex = 0
            Me.tabMachine.BackColor = Color.Transparent
            Me.tabMachine.Controls.Add(Me.CtrlComputerInfo1)
            point = New Point(4, &H16)
            Me.tabMachine.Location = point
            Me.tabMachine.Name = "tabMachine"
            Dim padding As New Padding(3)
            Me.tabMachine.Padding = padding
            size = New Size(&H131, &H16D)
            Me.tabMachine.Size = size
            Me.tabMachine.TabIndex = 0
            Me.tabMachine.Text = "Machine"
            Me.tabMachine.UseVisualStyleBackColor = True
            Me.CtrlComputerInfo1.BackColor = SystemColors.Control
            point = New Point(6, 6)
            Me.CtrlComputerInfo1.Location = point
            Me.CtrlComputerInfo1.Name = "CtrlComputerInfo1"
            size = New Size(&H11C, 360)
            Me.CtrlComputerInfo1.Size = size
            Me.CtrlComputerInfo1.TabIndex = 0
            Me.ListProcessing.Controls.Add(Me.CtrlListProcessing1)
            point = New Point(4, &H16)
            Me.ListProcessing.Location = point
            Me.ListProcessing.Name = "ListProcessing"
            size = New Size(&H131, &H16D)
            Me.ListProcessing.Size = size
            Me.ListProcessing.TabIndex = 1
            Me.ListProcessing.Text = "Batch Processing"
            Me.ListProcessing.UseVisualStyleBackColor = True
            Me.CtrlListProcessing1.BackColor = SystemColors.Control
            Me.CtrlListProcessing1.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
            point = New Point(1, 3)
            Me.CtrlListProcessing1.Location = point
            Me.CtrlListProcessing1.Name = "CtrlListProcessing1"
            size = New Size(&H12B, &H167)
            Me.CtrlListProcessing1.Size = size
            Me.CtrlListProcessing1.TabIndex = 0
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.Tabs)
            Me.Name = "AdminTabsControl"
            size = New Size(&H13C, &H187)
            Me.Size = size
            Me.Tabs.ResumeLayout(False)
            Me.tabMachine.ResumeLayout(False)
            Me.ListProcessing.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub


        ' Properties
        Friend Overridable Property CtrlComputerInfo1 As ctrlComputerInfo
            Get
                Return Me._CtrlComputerInfo1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ctrlComputerInfo)
                Me._CtrlComputerInfo1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property CtrlListProcessing1 As ctrlListProcessing
            Get
                Return Me._CtrlListProcessing1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ctrlListProcessing)
                Me._CtrlListProcessing1 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ListProcessing As TabPage
            Get
                Return Me._ListProcessing
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TabPage)
                Me._ListProcessing = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tabMachine As TabPage
            Get
                Return Me._tabMachine
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TabPage)
                Me._tabMachine = WithEventsValue
            End Set
        End Property

        Friend Overridable Property Tabs As TabControl
            Get
                Return Me._Tabs
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TabControl)
                Me._Tabs = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("CtrlComputerInfo1")> _
        Private _CtrlComputerInfo1 As ctrlComputerInfo
        <AccessedThroughProperty("CtrlListProcessing1")> _
        Private _CtrlListProcessing1 As ctrlListProcessing
        <AccessedThroughProperty("ListProcessing")> _
        Private _ListProcessing As TabPage
        <AccessedThroughProperty("tabMachine")> _
        Private _tabMachine As TabPage
        <AccessedThroughProperty("Tabs")> _
        Private _Tabs As TabControl
        Private components As IContainer
    End Class
End Namespace

