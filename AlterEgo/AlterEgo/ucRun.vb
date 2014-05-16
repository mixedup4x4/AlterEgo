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
    Friend Class ucRun
        Inherits UserControl
        ' Methods
        Public Sub New()
            Me.InitializeComponent
        End Sub

        Private Sub cboRun_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try 
                If (e.KeyCode = Keys.Enter) Then
                    e.Handled = True
                    Me.Parent.Hide
                    Me.runFile
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Interaction.MsgBox(exception.Message.ToString, MsgBoxStyle.Critical, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Private Sub cmdBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.XBrowse
            UFR.UFR(modMain.FilePathNameToPassToUFR, "run", &H270F)
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Parent.Hide
        End Sub

        Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Parent.Hide
            Me.runFile
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
            Dim manager As New ComponentResourceManager(GetType(ucRun))
            Me.cmdCancel = New Button
            Me.cmdOK = New Button
            Me.Label1 = New Label
            Me.PictureBox2 = New PictureBox
            Me.Label2 = New Label
            Me.cmdBrowse = New Button
            Me.cboRun = New EnterComboBox
            DirectCast(Me.PictureBox2, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Dim point As New Point(&HAF, &H76)
            Me.cmdCancel.Location = point
            Me.cmdCancel.Name = "cmdCancel"
            Dim size As New Size(&H49, &H17)
            Me.cmdCancel.Size = size
            Me.cmdCancel.TabIndex = 2
            Me.cmdCancel.Text = "Cancel"
            Me.cmdCancel.UseVisualStyleBackColor = True
            point = New Point(&H5E, &H76)
            Me.cmdOK.Location = point
            Me.cmdOK.Name = "cmdOK"
            size = New Size(&H49, &H17)
            Me.cmdOK.Size = size
            Me.cmdOK.TabIndex = 1
            Me.cmdOK.Text = "OK"
            Me.cmdOK.UseVisualStyleBackColor = True
            Me.Label1.AutoSize = True
            point = New Point(7, &H43)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H2A, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "Open..."
            Me.PictureBox2.Image = DirectCast(manager.GetObject("PictureBox2.Image"), Image)
            point = New Point(10, &H12)
            Me.PictureBox2.Location = point
            Me.PictureBox2.Name = "PictureBox2"
            size = New Size(&H24, &H20)
            Me.PictureBox2.Size = size
            Me.PictureBox2.TabIndex = 6
            Me.PictureBox2.TabStop = False
            point = New Point(&H34, &H17)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(280, &H1B)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Type the name of a program, folder, document or Internet resource and ALTER EGO will open it for you."
            point = New Point(&H100, &H76)
            Me.cmdBrowse.Location = point
            Me.cmdBrowse.Name = "cmdBrowse"
            size = New Size(&H49, &H17)
            Me.cmdBrowse.Size = size
            Me.cmdBrowse.TabIndex = 3
            Me.cmdBrowse.Text = "Browse..."
            Me.cmdBrowse.UseVisualStyleBackColor = True
            Me.cboRun.FormattingEnabled = True
            point = New Point(&H37, &H3F)
            Me.cboRun.Location = point
            Me.cboRun.Name = "cboRun"
            size = New Size(&H112, &H15)
            Me.cboRun.Size = size
            Me.cboRun.TabIndex = 0
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.Controls.Add(Me.cboRun)
            Me.Controls.Add(Me.cmdBrowse)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cmdOK)
            Me.Controls.Add(Me.cmdCancel)
            Me.Name = "ucRun"
            size = New Size(&H15B, &HA2)
            Me.Size = size
            DirectCast(Me.PictureBox2, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Friend Sub runFile()
            Me.Parent.Hide
            UFR.UFR(Strings.Trim(Me.cboRun.Text), "Run", &H270F)
        End Sub

        Friend Sub XBrowse()
            Try 
                modMain.FilePathNameToPassToUFR = ""
                modMain.dlgFile.FileName = ""
                modMain.dlgFile.Title = "Browse"
                modMain.dlgFile.InitialDirectory = Application.StartupPath
                modMain.dlgFile.Filter = "All Files (*.*)|*.*"
                modMain.dlgFile.ShowDialog
                modMain.FilePathNameToPassToUFR = modMain.dlgFile.FileName
                If (Strings.StrComp(modMain.FilePathNameToPassToUFR, "", CompareMethod.Text) <> 0) Then
                    Me.Parent.Hide
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError
            End Try
        End Sub


        ' Properties
        Friend Overridable Property cboRun As EnterComboBox
            Get
                Return Me._cboRun
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterComboBox)
                If (Not Me._cboRun Is Nothing) Then
                    RemoveHandler Me._cboRun.KeyDown, New KeyEventHandler(AddressOf Me.cboRun_KeyDown)
                End If
                Me._cboRun = WithEventsValue
                If (Not Me._cboRun Is Nothing) Then
                    AddHandler Me._cboRun.KeyDown, New KeyEventHandler(AddressOf Me.cboRun_KeyDown)
                End If
            End Set
        End Property

        Friend Overridable Property cmdBrowse As Button
            Get
                Return Me._cmdBrowse
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdBrowse Is Nothing) Then
                    RemoveHandler Me._cmdBrowse.Click, New EventHandler(AddressOf Me.cmdBrowse_Click)
                End If
                Me._cmdBrowse = WithEventsValue
                If (Not Me._cmdBrowse Is Nothing) Then
                    AddHandler Me._cmdBrowse.Click, New EventHandler(AddressOf Me.cmdBrowse_Click)
                End If
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

        Friend Overridable Property cmdOK As Button
            Get
                Return Me._cmdOK
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdOK Is Nothing) Then
                    RemoveHandler Me._cmdOK.Click, New EventHandler(AddressOf Me.cmdOK_Click)
                End If
                Me._cmdOK = WithEventsValue
                If (Not Me._cmdOK Is Nothing) Then
                    AddHandler Me._cmdOK.Click, New EventHandler(AddressOf Me.cmdOK_Click)
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

        Friend Overridable Property PictureBox2 As PictureBox
            Get
                Return Me._PictureBox2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._PictureBox2 = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("cboRun")> _
        Private _cboRun As EnterComboBox
        <AccessedThroughProperty("cmdBrowse")> _
        Private _cmdBrowse As Button
        <AccessedThroughProperty("cmdCancel")> _
        Private _cmdCancel As Button
        <AccessedThroughProperty("cmdOK")> _
        Private _cmdOK As Button
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("PictureBox2")> _
        Private _PictureBox2 As PictureBox
        Private components As IContainer
    End Class
End Namespace

