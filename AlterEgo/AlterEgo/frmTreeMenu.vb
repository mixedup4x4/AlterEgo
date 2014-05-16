Imports AlterEgo.My
Imports AlterEgo.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace AlterEgo
    <DesignerGenerated> _
    Public Class frmTreeMenu
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmTreeMenu_Load)
            Me.renameMenu = True
            Me.AddMenuButton = New ToolStripMenuItem("Add", Resources.ADDBLAND, New EventHandler(AddressOf Me.subAddMenu))
            Me.tsiUserMenu = New ToolStripMenuItem(modMain.CurrentUser, modMain.ObjImg(modMain.UserIcon), New EventHandler(AddressOf MenuSubs.ChangeMyIcon))
            Me.tsiMYDocs = New ToolStripMenuItem("My Documents", Resources.imgMyDocs, New EventHandler(AddressOf MenuSubs.subMyDocs))
            Me.tsiDesktop = New ToolStripMenuItem("Desktop", Resources.imgDesktop, New EventHandler(AddressOf MenuSubs.subMyDesktop))
            Me.tsiHelp = New ToolStripMenuItem("Help", Resources.imgHelp, New EventHandler(AddressOf MenuSubs.subHelp))
            Me.tsiCommandeer = New ToolStripMenuItem("Commandeer Desktop", Resources.imgBadge, New EventHandler(AddressOf MenuSubs.subCommandeer))
            Me.tsiRegister = New ToolStripMenuItem("Register", Resources.imgRegister, New EventHandler(AddressOf MenuSubs.subMeNuRegister))
            Me.tsiMYCompMenu = New ToolStripMenuItem("My Computer", Resources.imgMyComputer, New EventHandler(AddressOf MenuSubs.subLocalMyComputer))
            Me.tsiLocalUserMenu = New ToolStripMenuItem("Local Environment", Resources.imgLocalUser)
            Me.tsiLocalMYDocs = New ToolStripMenuItem("My Documents", Resources.imgMyDocs, New EventHandler(AddressOf MenuSubs.subLocalMyDocs))
            Me.tsiLocalMYComp = New ToolStripMenuItem("My Computer", Resources.imgMyComputer, New EventHandler(AddressOf MenuSubs.subLocalMyComputer))
            Me.tsiLocalRegedit = New ToolStripMenuItem("Regedit", Resources.imgRegedit, New EventHandler(AddressOf MenuSubs.subLocalRegedit))
            Me.tsiLocalDesktop = New ToolStripMenuItem("Desktop", Resources.imgDesktop, New EventHandler(AddressOf MenuSubs.subLocalMyDesktop))
            Me.tsiExplore = New ToolStripMenuItem("Explore...", Resources.imgEXP, New EventHandler(AddressOf MenuSubs.subexplorer))
            Me.tsiControlPanel = New ToolStripMenuItem("Control Panel", Resources.imgControlPanel, New EventHandler(AddressOf MenuSubs.subControlPanel))
            Me.tsiCompmgmt = New ToolStripMenuItem("Manage...", Resources.imgManage, New EventHandler(AddressOf MenuSubs.subCompMGMT))
            Me.tsiPrinter = New ToolStripMenuItem("Printers and Faxes", Resources.imgPnf, New EventHandler(AddressOf MenuSubs.subPrinters))
            Me.tsiTKMenu = New ToolStripMenuItem("Tool Kits", Resources.imgBlank)
            Me.tsiADminTK = New ToolStripMenuItem("Admin Toolkit", Resources.imgCircSaw, New EventHandler(AddressOf MenuSubs.subAdminTK))
            Me.PPP = New ToolStripMenuItem((MySettingsProperty.Settings.MnuMax + 1)  - 1) {}
            Me.arrayMNU = New TreeNode((MySettingsProperty.Settings.MnuMax + 1)  - 1) {}
            Me.mnu0 = New TreeNode((MySettingsProperty.Settings.MnuMax + 1)  - 1) {}
            Me.cxtMNU = New ContextMenuStrip
            Me.cxtItems = New ContextMenuStrip
            Me.cxtRoot = New ContextMenuStrip
            Me.cxtVariables = New ContextMenuStrip
            Me.stateData = New Boolean((MySettingsProperty.Settings.MnuMax + 1)  - 1) {}
            Me.InitializeComponent
        End Sub

        Friend Sub Browse_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Me.optFile.Checked Then
                MyProject.Forms.frmRun.ucRun1.XBrowse
                Me.txt1.Text = modMain.FilePathNameToPassToUFR
            ElseIf Me.optFolder.Checked Then
                modMain.dlgFolder.ShowDialog
                modMain.dlgFolder.RootFolder = SpecialFolder.MyComputer
                Me.txt1.Text = Application.StartupPath
            End If
        End Sub

        Public Sub BubbleSort()
            Dim num6 As Integer = (MySettingsProperty.Settings.MnuMax - 1)
            Dim i As Integer = 0
            Do While (i <= num6)
                If ((Strings.StrComp(modFileSettingsandArray.mnuTypes(i), "", CompareMethod.Text) = 0) Or (Strings.StrComp(modFileSettingsandArray.mnuTypes(i), Nothing, CompareMethod.Text) = 0)) Then
                    modFileSettingsandArray.mnuTypes(i) = modFileSettingsandArray.mnuTypes((i + 1))
                    modFileSettingsandArray.mnuTypes((i + 1)) = ""
                End If
                i += 1
            Loop
            Dim num7 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
            Dim j As Integer = 0
            Do While (j <= num7)
                Dim num8 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
                Dim m As Integer = 0
                Do While (m <= num8)
                    If (Strings.StrComp(modFileSettingsandArray.AllArray(m, 0), "", CompareMethod.Text) = 0) Then
                        modFileSettingsandArray.AllArray(m, 0) = modFileSettingsandArray.AllArray((m + 1), 0)
                        modFileSettingsandArray.AllArray(m, 1) = modFileSettingsandArray.AllArray((m + 1), 1)
                        modFileSettingsandArray.AllArray(m, 2) = modFileSettingsandArray.AllArray((m + 1), 2)
                        modFileSettingsandArray.AllArray(m, 3) = modFileSettingsandArray.AllArray((m + 1), 3)
                        modFileSettingsandArray.AllArray(m, 4) = modFileSettingsandArray.AllArray((m + 1), 4)
                        modFileSettingsandArray.AllArray(m, 5) = modFileSettingsandArray.AllArray((m + 1), 5)
                        modFileSettingsandArray.AllArray((m + 1), 0) = ""
                        modFileSettingsandArray.AllArray((m + 1), 1) = ""
                        modFileSettingsandArray.AllArray((m + 1), 2) = ""
                        modFileSettingsandArray.AllArray((m + 1), 3) = ""
                        modFileSettingsandArray.AllArray((m + 1), 4) = ""
                        modFileSettingsandArray.AllArray((m + 1), 5) = ""
                    End If
                    m += 1
                Loop
                j += 1
            Loop
            Dim num9 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
            Dim k As Integer = 0
            Do While (k <= num9)
                Dim num10 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
                Dim n As Integer = 0
                Do While (n <= num10)
                    If (Strings.StrComp(modFileSettingsandArray.AllArray(n, 2), modFileSettingsandArray.AllArray((n + 1), 2), CompareMethod.Text) < 0) Then
                        Dim str As String = modFileSettingsandArray.AllArray(n, 0)
                        Dim str2 As String = modFileSettingsandArray.AllArray(n, 1)
                        Dim str3 As String = modFileSettingsandArray.AllArray(n, 2)
                        Dim str4 As String = modFileSettingsandArray.AllArray(n, 3)
                        Dim str5 As String = modFileSettingsandArray.AllArray(n, 4)
                        Dim str6 As String = modFileSettingsandArray.AllArray(n, 5)
                        modFileSettingsandArray.AllArray(n, 0) = modFileSettingsandArray.AllArray((n + 1), 0)
                        modFileSettingsandArray.AllArray(n, 1) = modFileSettingsandArray.AllArray((n + 1), 1)
                        modFileSettingsandArray.AllArray(n, 2) = modFileSettingsandArray.AllArray((n + 1), 2)
                        modFileSettingsandArray.AllArray(n, 3) = modFileSettingsandArray.AllArray((n + 1), 3)
                        modFileSettingsandArray.AllArray(n, 4) = modFileSettingsandArray.AllArray((n + 1), 4)
                        modFileSettingsandArray.AllArray(n, 5) = modFileSettingsandArray.AllArray((n + 1), 5)
                        modFileSettingsandArray.AllArray((n + 1), 0) = str
                        modFileSettingsandArray.AllArray((n + 1), 1) = str2
                        modFileSettingsandArray.AllArray((n + 1), 2) = str3
                        modFileSettingsandArray.AllArray((n + 1), 3) = str4
                        modFileSettingsandArray.AllArray((n + 1), 4) = str5
                        modFileSettingsandArray.AllArray((n + 1), 5) = str6
                    End If
                    n += 1
                Loop
                k += 1
            Loop
            Me.subFormLoadRefresh
        End Sub

        Friend Sub checkUnique(ByVal pathx As String, ByVal id As Integer)
            Dim num2 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (Strings.StrComp(pathx, modFileSettingsandArray.AllArray(i, 0), CompareMethod.Text) = 0) Then
                    Me.Unique = 0
                    If (id = i) Then
                        Me.Unique = 1
                    End If
                End If
                i += 1
            Loop
        End Sub

        Private Sub cmdAccept_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.cmdACceptCode(Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(0  - 1) {}, Nothing, Nothing, Nothing)))
        End Sub

        Friend Sub cmdACceptCode(ByVal j As String)
            Me.CurrentNodeSelectedForRefresh = Me.ROOTnode.TreeView.SelectedNode
            If (Strings.Trim(Me.txt0.Text) = "") Then
                Interaction.MsgBox("Display Name Cannot Be Blank", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Me.Unique = 1
                Select Case j
                    Case "Save"
                        If (Strings.Trim(Me.cboCat.Text) = "") Then
                            Return
                        End If
                        If (Strings.InStr(Strings.Trim(Me.txt1.Text), modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                            Me.txt1.Text = Me.txt1.Text.Replace(modMain.RelativeMarker, Application.StartupPath)
                        End If
                        Dim id As Integer = Convert.ToInt32(Me.txtNode.Text)
                        Me.checkUnique(Strings.Trim(Me.txt0.Text), id)
                        If (Strings.StrComp(Strings.Trim(Me.txt0.Text), "-", CompareMethod.Text) = 0) Then
                            Me.Unique = 1
                        End If
                        If (Me.Unique <> 1) Then
                            Interaction.MsgBox("Display Names Must Be Unique", MsgBoxStyle.ApplicationModal, Nothing)
                            Me.txt0.Text = modFileSettingsandArray.AllArray(id, 0)
                            Return
                        End If
                        If (Strings.InStr(Me.txt1.Text, modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                            Me.txt1.Text.Replace(modMain.RelativeMarker, Application.StartupPath)
                        End If
                        modFileSettingsandArray.AllArray(id, 0) = Strings.Trim(Me.txt0.Text)
                        Me.subCheckRelativitity(Strings.Trim(Me.txt1.Text))
                        modFileSettingsandArray.AllArray(id, 1) = Strings.Trim(Me.txt1.Text)
                        Me.TreeMenu.SelectedNode.Text = modFileSettingsandArray.AllArray(id, 0)
                        modFileSettingsandArray.AllArray(id, 2) = Strings.Trim(Me.cboCat.Text)
                        If Me.optCommand.Checked Then
                            modFileSettingsandArray.AllArray(id, 4) = "Command"
                            If Me.ckCommand.Checked Then
                                modFileSettingsandArray.AllArray(id, 5) = "True"
                            Else
                                modFileSettingsandArray.AllArray(id, 5) = "False"
                            End If
                        ElseIf Me.optFile.Checked Then
                            modFileSettingsandArray.AllArray(id, 4) = "File"
                            modFileSettingsandArray.AllArray(id, 5) = "False"
                        ElseIf Me.optFolder.Checked Then
                            modFileSettingsandArray.AllArray(id, 4) = "Folder"
                            modFileSettingsandArray.AllArray(id, 5) = "False"
                        End If
                        If (Strings.InStr(Strings.Trim(Me.txt1.Text), modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                            Me.txt1.Text = Me.txt1.Text.Replace(modMain.RelativeMarker, Application.StartupPath)
                        End If
                        Me.subAttachMenuImage(Me.txt1.Text)
                        modFileSettingsandArray.AllArray(id, 3) = Conversions.ToString(Me.imageID)
                        Me.txt0.Text = ""
                        Me.txt1.Text = ""
                        Me.txt2.Text = ""
                        Me.SaveNodeStates
                        Me.subFormLoadRefresh
                        Me.LoadNodeStates
                        Exit Select
                    Case "Add"
                        Me.Unique = 1
                        If (Strings.Trim(Me.cboCat.Text) = "") Then
                            Return
                        End If
                        If (Strings.StrComp(Strings.Trim(Me.txt0.Text), "-", CompareMethod.Text) = 0) Then
                            modFileSettingsandArray.AllArray(Me.ItemCount, 0) = "-"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 1) = ""
                            modFileSettingsandArray.AllArray(Me.ItemCount, 2) = Strings.Trim(Me.cboCat.Text)
                            modFileSettingsandArray.AllArray(Me.ItemCount, 3) = "0"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 4) = "File"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 5) = "False"
                            Me.txt0.Text = ""
                            Me.txt1.Text = ""
                            Me.txt2.Text = ""
                            Me.SaveNodeStates
                            Me.subFormLoadRefresh
                            Me.LoadNodeStates
                            Return
                        End If
                        If (Strings.InStr(Strings.Trim(Me.txt1.Text), modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                            Me.txt1.Text = Me.txt1.Text.Replace(modMain.RelativeMarker, Application.StartupPath)
                        End If
                        Me.checkUnique(Strings.Trim(Me.txt0.Text), &H3E7)
                        If (Me.Unique <> 1) Then
                            Interaction.MsgBox("Display Names Must Be Unique", MsgBoxStyle.ApplicationModal, Nothing)
                            Return
                        End If
                        modFileSettingsandArray.AllArray(Me.ItemCount, 0) = Strings.Trim(Me.txt0.Text)
                        Me.subCheckRelativitity(Strings.Trim(Me.txt1.Text))
                        modFileSettingsandArray.AllArray(Me.ItemCount, 1) = Strings.Trim(Me.txt1.Text)
                        modFileSettingsandArray.AllArray(Me.ItemCount, 2) = Strings.Trim(Me.cboCat.Text)
                        modFileSettingsandArray.AllArray(Me.ItemCount, 2) = Strings.Trim(Me.cboCat.Text)
                        modFileSettingsandArray.AllArray(Me.ItemCount, 2) = Strings.Trim(Me.cboCat.Text)
                        If Me.optCommand.Checked Then
                            modFileSettingsandArray.AllArray(Me.ItemCount, 4) = "Command"
                            If Me.ckCommand.Checked Then
                                modFileSettingsandArray.AllArray(Me.ItemCount, 5) = "True"
                            Else
                                modFileSettingsandArray.AllArray(Me.ItemCount, 5) = "False"
                            End If
                        ElseIf Me.optFile.Checked Then
                            modFileSettingsandArray.AllArray(Me.ItemCount, 4) = "File"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 5) = "False"
                        ElseIf Me.optFolder.Checked Then
                            modFileSettingsandArray.AllArray(Me.ItemCount, 4) = "Folder"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 5) = "False"
                        End If
                        Me.subAttachMenuImage(modFileSettingsandArray.AllArray(Me.ItemCount, 1))
                        modFileSettingsandArray.AllArray(Me.ItemCount, 3) = Conversions.ToString(Me.imageID)
                        Me.txt0.Text = ""
                        Me.txt1.Text = ""
                        Me.txt2.Text = ""
                        Me.SaveNodeStates
                        Me.subFormLoadRefresh
                        Me.LoadNodeStates
                        Exit Select
                End Select
            End If
        End Sub

        Friend Sub cmdClose_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide
            Dim num3 As Integer = (Me.ROOTnode.Nodes.Count - 1)
            Dim i As Integer = 0
            Do While (i <= num3)
                If (Me.arrayMNU(i).Nodes.Count = 0) Then
                    Dim num4 As Integer = (MySettingsProperty.Settings.MnuMax - 1)
                    Dim j As Integer = 0
                    Do While (j <= num4)
                        If (Strings.StrComp(Me.ROOTnode.Nodes.Item(i).Name, modFileSettingsandArray.mnuTypes(j), CompareMethod.Text) = 0) Then
                            modFileSettingsandArray.mnuTypes(i) = ""
                        End If
                        j += 1
                    Loop
                End If
                i += 1
            Loop
            Me.subFormLoadRefresh
            Me.Hide
            modFileSettingsandArray.SaveSettings
            Me.Dispose
        End Sub

        Private Sub cmdRenameMenu_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.pnlRenameMenu.Left = 260
            Me.pnlRenameMenu.Top = 12
            Dim mnuMax As Integer = MySettingsProperty.Settings.MnuMax
            Dim i As Integer = 0
            Do While (i <= mnuMax)
                If (Strings.StrComp(Strings.Trim(Me.txtRenameNode.Text), modFileSettingsandArray.mnuTypes(i), CompareMethod.Text) = 0) Then
                    Interaction.MsgBox("Menu Name Must Be Unique", MsgBoxStyle.ApplicationModal, Nothing)
                    Return
                End If
                i += 1
            Loop
            Dim num5 As Integer = MySettingsProperty.Settings.MnuMax
            Dim j As Integer = 0
            Do While (j <= num5)
                If (Strings.StrComp(Me.TreeMenu.SelectedNode.Text, modFileSettingsandArray.mnuTypes(j), CompareMethod.Text) = 0) Then
                    Dim maxSize As Integer = MySettingsProperty.Settings.MaxSize
                    Dim k As Integer = 0
                    Do While (k <= maxSize)
                        If (Strings.StrComp(Me.TreeMenu.SelectedNode.Text, modFileSettingsandArray.AllArray(k, 2), CompareMethod.Text) = 0) Then
                            modFileSettingsandArray.AllArray(k, 2) = Strings.Trim(Me.txtRenameNode.Text)
                        End If
                        k += 1
                    Loop
                    Me.TreeMenu.SelectedNode.Text = Strings.Trim(Me.txtRenameNode.Text)
                    modFileSettingsandArray.mnuTypes(j) = Strings.Trim(Me.txtRenameNode.Text)
                End If
                j += 1
            Loop
            Me.pnlRenameMenu.Visible = False
            Me.subFormLoadRefresh
        End Sub

        Friend Sub DelMenu(ByVal s As String)
            Dim itemMax As Integer = MySettingsProperty.Settings.ItemMax
            Dim i As Integer = 0
            Do While (i <= itemMax)
                If (Strings.StrComp(modFileSettingsandArray.AllArray(i, 2), s, CompareMethod.Text) = 0) Then
                    modFileSettingsandArray.AllArray(i, 0) = ""
                    modFileSettingsandArray.AllArray(i, 1) = ""
                    modFileSettingsandArray.AllArray(i, 2) = ""
                    modFileSettingsandArray.AllArray(i, 3) = ""
                    modFileSettingsandArray.AllArray(i, 4) = ""
                    modFileSettingsandArray.AllArray(i, 5) = ""
                End If
                i += 1
            Loop
            Dim num4 As Integer = (MySettingsProperty.Settings.MnuMax - 1)
            Dim j As Integer = 0
            Do While (j <= num4)
                If (Strings.StrComp(modFileSettingsandArray.mnuTypes(j), s, CompareMethod.Text) = 0) Then
                    modFileSettingsandArray.mnuTypes(j) = ""
                End If
                j += 1
            Loop
            Me.BubbleSort
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Friend Sub frmTreeMenu_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not modMain.Registered Then
                Me.tmrDemo.Enabled = True
            End If
            Me.Text = modMain.CurrentUser
            Me.Top = CInt(Math.Round(CDbl((CDbl((modMain.ScreenHeight - Me.Height)) / 2))))
            Me.Left = CInt(Math.Round(CDbl((CDbl((modMain.ScreenWidth - Me.Width)) / 2))))
            Me.optFile.Checked = True
            Me.Icon = modMain.ObjIcon(modMain.UserIcon)
            Me.subFormLoadRefresh
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim node As New TreeNode("")
            Dim style As New DataGridViewCellStyle
            Dim style2 As New DataGridViewCellStyle
            Dim style3 As New DataGridViewCellStyle
            Me.TreeMenu = New TreeView
            Me.txt2 = New TextBox
            Me.Timer1 = New Timer(Me.components)
            Me.Browse = New Button
            Me.cmdClose = New Button
            Me.cmdAccept = New Button
            Me.txtNode = New TextBox
            Me.pnlEdit = New Panel
            Me.GroupBox1 = New GroupBox
            Me.ckCommand = New CheckBox
            Me.optFile = New RadioButton
            Me.optFolder = New RadioButton
            Me.optCommand = New RadioButton
            Me.Label3 = New Label
            Me.Label2 = New Label
            Me.Label1 = New Label
            Me.cboCat = New EnterComboBox
            Me.txt1 = New EnterTextBox
            Me.txt0 = New EnterTextBox
            Me.cmdRenameMenu = New Button
            Me.pnlRenameMenu = New Panel
            Me.Label4 = New Label
            Me.txtRenameNode = New EnterTextBox
            Me.dg = New DataGridView
            Me.cmd = New Button
            Me.ckCommandeer = New CheckBox
            Me.tmrDemo = New Timer(Me.components)
            Me.lblInstruction = New Label
            Me.pnlEdit.SuspendLayout
            Me.GroupBox1.SuspendLayout
            Me.pnlRenameMenu.SuspendLayout
            DirectCast(Me.dg, ISupportInitialize).BeginInit
            Me.SuspendLayout
            Me.TreeMenu.AllowDrop = True
            Dim point As New Point(12, 12)
            Me.TreeMenu.Location = point
            Me.TreeMenu.Name = "TreeMenu"
            node.Name = "Node0"
            node.Text = ""
            Me.TreeMenu.Nodes.AddRange(New TreeNode() { node })
            Dim size As New Size(&HF2, &HD5)
            Me.TreeMenu.Size = size
            Me.TreeMenu.TabIndex = 0
            point = New Point(-40, &H56)
            Me.txt2.Location = point
            Me.txt2.Name = "txt2"
            size = New Size(&H52, 20)
            Me.txt2.Size = size
            Me.txt2.TabIndex = 4
            Me.txt2.Visible = False
            Me.Timer1.Interval = 10
            point = New Point(&H4E, &H5D)
            Me.Browse.Location = point
            Me.Browse.Name = "Browse"
            size = New Size(&H4B, &H17)
            Me.Browse.Size = size
            Me.Browse.TabIndex = &H63
            Me.Browse.TabStop = False
            Me.Browse.Text = "Browse..."
            Me.Browse.UseVisualStyleBackColor = True
            point = New Point(&H108, 200)
            Me.cmdClose.Location = point
            Me.cmdClose.Name = "cmdClose"
            size = New Size(&H4B, &H17)
            Me.cmdClose.Size = size
            Me.cmdClose.TabIndex = 10
            Me.cmdClose.Text = "Close"
            Me.cmdClose.UseVisualStyleBackColor = True
            point = New Point(&H9F, &H5D)
            Me.cmdAccept.Location = point
            Me.cmdAccept.Name = "cmdAccept"
            size = New Size(&H4B, &H17)
            Me.cmdAccept.Size = size
            Me.cmdAccept.TabIndex = 8
            Me.cmdAccept.Text = "Change"
            Me.cmdAccept.UseVisualStyleBackColor = True
            point = New Point(-40, &H6C)
            Me.txtNode.Location = point
            Me.txtNode.Name = "txtNode"
            size = New Size(&H52, 20)
            Me.txtNode.Size = size
            Me.txtNode.TabIndex = 8
            Me.txtNode.Visible = False
            Me.pnlEdit.Controls.Add(Me.GroupBox1)
            Me.pnlEdit.Controls.Add(Me.Label3)
            Me.pnlEdit.Controls.Add(Me.Label2)
            Me.pnlEdit.Controls.Add(Me.Label1)
            Me.pnlEdit.Controls.Add(Me.cboCat)
            Me.pnlEdit.Controls.Add(Me.txt1)
            Me.pnlEdit.Controls.Add(Me.txt0)
            Me.pnlEdit.Controls.Add(Me.cmdAccept)
            Me.pnlEdit.Controls.Add(Me.txtNode)
            Me.pnlEdit.Controls.Add(Me.Browse)
            Me.pnlEdit.Controls.Add(Me.txt2)
            point = New Point(260, 12)
            Me.pnlEdit.Location = point
            Me.pnlEdit.Name = "pnlEdit"
            size = New Size(&H19C, &H7C)
            Me.pnlEdit.Size = size
            Me.pnlEdit.TabIndex = 9
            Me.GroupBox1.Controls.Add(Me.ckCommand)
            Me.GroupBox1.Controls.Add(Me.optFile)
            Me.GroupBox1.Controls.Add(Me.optFolder)
            Me.GroupBox1.Controls.Add(Me.optCommand)
            point = New Point(240, &H34)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&HAC, &H40)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = 15
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Type"
            Me.ckCommand.AutoSize = True
            point = New Point(80, 14)
            Me.ckCommand.Location = point
            Me.ckCommand.Name = "ckCommand"
            size = New Size(&H56, &H11)
            Me.ckCommand.Size = size
            Me.ckCommand.TabIndex = 5
            Me.ckCommand.Text = "Keep Open?"
            Me.ckCommand.UseVisualStyleBackColor = True
            Me.optFile.AutoSize = True
            point = New Point(7, &H2B)
            Me.optFile.Location = point
            Me.optFile.Name = "optFile"
            size = New Size(&H29, &H11)
            Me.optFile.Size = size
            Me.optFile.TabIndex = 7
            Me.optFile.TabStop = True
            Me.optFile.Text = "File"
            Me.optFile.UseVisualStyleBackColor = True
            Me.optFolder.AutoSize = True
            point = New Point(7, &H1C)
            Me.optFolder.Location = point
            Me.optFolder.Name = "optFolder"
            size = New Size(&H36, &H11)
            Me.optFolder.Size = size
            Me.optFolder.TabIndex = 6
            Me.optFolder.TabStop = True
            Me.optFolder.Text = "Folder"
            Me.optFolder.UseVisualStyleBackColor = True
            Me.optCommand.AutoSize = True
            point = New Point(7, 13)
            Me.optCommand.Location = point
            Me.optCommand.Name = "optCommand"
            size = New Size(&H48, &H11)
            Me.optCommand.Size = size
            Me.optCommand.TabIndex = 4
            Me.optCommand.TabStop = True
            Me.optCommand.Text = "Command"
            Me.optCommand.UseVisualStyleBackColor = True
            Me.Label3.AutoSize = True
            point = New Point(&H27, &H41)
            Me.Label3.Location = point
            Me.Label3.Name = "Label3"
            size = New Size(&H25, 13)
            Me.Label3.Size = size
            Me.Label3.TabIndex = 14
            Me.Label3.Text = "Menu:"
            Me.Label3.TextAlign = ContentAlignment.MiddleRight
            Me.Label2.AutoSize = True
            point = New Point(&H2C, &H23)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H20, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Path:"
            Me.Label2.TextAlign = ContentAlignment.MiddleRight
            Me.Label1.AutoSize = True
            point = New Point(1, 8)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H4B, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Display Name:"
            Me.Label1.TextAlign = ContentAlignment.MiddleRight
            Me.cboCat.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboCat.FormattingEnabled = True
            point = New Point(&H4E, &H3D)
            Me.cboCat.Location = point
            Me.cboCat.Name = "cboCat"
            size = New Size(&H9C, &H15)
            Me.cboCat.Size = size
            Me.cboCat.TabIndex = 3
            point = New Point(&H4E, &H20)
            Me.txt1.Location = point
            Me.txt1.Name = "txt1"
            size = New Size(&H14E, 20)
            Me.txt1.Size = size
            Me.txt1.TabIndex = 2
            point = New Point(&H4E, 5)
            Me.txt0.Location = point
            Me.txt0.Name = "txt0"
            size = New Size(&H14E, 20)
            Me.txt0.Size = size
            Me.txt0.TabIndex = 1
            point = New Point(&H54, &H22)
            Me.cmdRenameMenu.Location = point
            Me.cmdRenameMenu.Name = "cmdRenameMenu"
            size = New Size(&H69, &H17)
            Me.cmdRenameMenu.Size = size
            Me.cmdRenameMenu.TabIndex = 7
            Me.cmdRenameMenu.Text = "Rename Menu"
            Me.cmdRenameMenu.UseVisualStyleBackColor = True
            Me.pnlRenameMenu.Controls.Add(Me.Label4)
            Me.pnlRenameMenu.Controls.Add(Me.cmdRenameMenu)
            Me.pnlRenameMenu.Controls.Add(Me.txtRenameNode)
            point = New Point(260, &H8A)
            Me.pnlRenameMenu.Location = point
            Me.pnlRenameMenu.Name = "pnlRenameMenu"
            size = New Size(&H19C, 60)
            Me.pnlRenameMenu.Size = size
            Me.pnlRenameMenu.TabIndex = 12
            Me.Label4.AutoSize = True
            point = New Point(14, 12)
            Me.Label4.Location = point
            Me.Label4.Name = "Label4"
            size = New Size(&H44, 13)
            Me.Label4.Size = size
            Me.Label4.TabIndex = 15
            Me.Label4.Text = "Menu Name:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            point = New Point(&H54, 8)
            Me.txtRenameNode.Location = point
            Me.txtRenameNode.Name = "txtRenameNode"
            size = New Size(&H145, 20)
            Me.txtRenameNode.Size = size
            Me.txtRenameNode.TabIndex = 6
            style.Alignment = DataGridViewContentAlignment.MiddleLeft
            style.BackColor = SystemColors.Control
            style.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            style.ForeColor = SystemColors.WindowText
            style.SelectionBackColor = SystemColors.Highlight
            style.SelectionForeColor = SystemColors.HighlightText
            style.WrapMode = DataGridViewTriState.True
            Me.dg.ColumnHeadersDefaultCellStyle = style
            Me.dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            style2.Alignment = DataGridViewContentAlignment.MiddleLeft
            style2.BackColor = SystemColors.Window
            style2.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            style2.ForeColor = SystemColors.ControlText
            style2.SelectionBackColor = SystemColors.Highlight
            style2.SelectionForeColor = SystemColors.HighlightText
            style2.WrapMode = DataGridViewTriState.False
            Me.dg.DefaultCellStyle = style2
            point = New Point(12, &HF3)
            Me.dg.Location = point
            Me.dg.Name = "dg"
            style3.Alignment = DataGridViewContentAlignment.MiddleLeft
            style3.BackColor = SystemColors.Control
            style3.Font = New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
            style3.ForeColor = SystemColors.WindowText
            style3.SelectionBackColor = SystemColors.Highlight
            style3.SelectionForeColor = SystemColors.HighlightText
            style3.WrapMode = DataGridViewTriState.True
            Me.dg.RowHeadersDefaultCellStyle = style3
            size = New Size(&H17F, &HD5)
            Me.dg.Size = size
            Me.dg.TabIndex = 13
            point = New Point(&H158, 200)
            Me.cmd.Location = point
            Me.cmd.Name = "cmd"
            size = New Size(&H98, &H17)
            Me.cmd.Size = size
            Me.cmd.TabIndex = 14
            Me.cmd.TabStop = False
            Me.cmd.Text = "Preview Menu (Right Click)"
            Me.cmd.UseVisualStyleBackColor = True
            Me.ckCommandeer.AutoSize = True
            point = New Point(&H200, &HCC)
            Me.ckCommandeer.Location = point
            Me.ckCommandeer.Name = "ckCommandeer"
            size = New Size(&H7F, &H11)
            Me.ckCommandeer.Size = size
            Me.ckCommandeer.TabIndex = 15
            Me.ckCommandeer.Text = "Enable Commandeer "
            Me.ckCommandeer.UseVisualStyleBackColor = True
            Me.tmrDemo.Interval = &H927C0
            Me.lblInstruction.AutoSize = True
            Me.lblInstruction.Font = New Font("Microsoft Sans Serif", 14!, FontStyle.Regular, GraphicsUnit.Point, 0)
            point = New Point(410, &HE0)
            Me.lblInstruction.Location = point
            Me.lblInstruction.Name = "lblInstruction"
            size = New Size(&H106, &H18)
            Me.lblInstruction.Size = size
            Me.lblInstruction.TabIndex = 100
            Me.lblInstruction.Text = "Use the tree to edit your menu"
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H2AC, 240)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.lblInstruction)
            Me.Controls.Add(Me.ckCommandeer)
            Me.Controls.Add(Me.cmd)
            Me.Controls.Add(Me.dg)
            Me.Controls.Add(Me.pnlRenameMenu)
            Me.Controls.Add(Me.pnlEdit)
            Me.Controls.Add(Me.cmdClose)
            Me.Controls.Add(Me.TreeMenu)
            Me.Name = "frmTreeMenu"
            Me.Text = "Form1"
            Me.pnlEdit.ResumeLayout(False)
            Me.pnlEdit.PerformLayout
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout
            Me.pnlRenameMenu.ResumeLayout(False)
            Me.pnlRenameMenu.PerformLayout
            DirectCast(Me.dg, ISupportInitialize).EndInit
            Me.ResumeLayout(False)
            Me.PerformLayout
        End Sub

        Friend Sub LoadNodeStates()
            Dim mnuMax As Integer = MySettingsProperty.Settings.MnuMax
            Dim i As Integer = 0
            Do While (i <= mnuMax)
                If Me.stateData(i) Then
                    Me.arrayMNU(i).Expand
                End If
                i += 1
            Loop
            Me.ROOTnode.TreeView.Select
            Me.ROOTnode.TreeView.SelectedNode = Me.CurrentNodeSelectedForRefresh
            Me.TreeMenu.Refresh
        End Sub

        Friend Sub LoadTreeNodesArrays()
            Me.ItemCount = 0
            Me.cboCat.Items.Clear
            Me.TreeMenu.Nodes.Clear
            Me.ROOTnode = New TreeNode(modMain.CurrentUser)
            Me.ROOTnode.Name = "RootNode"
            Me.ROOTnode.ContextMenuStrip = Me.cxtRoot
            Me.TreeMenu.Nodes.Add(Me.ROOTnode)
            Me.ROOTnode.TreeView.ShowRootLines = False
            Dim mnuMax As Integer = MySettingsProperty.Settings.MnuMax
            Dim i As Integer = 0
            Do While (i <= mnuMax)
                If (modFileSettingsandArray.mnuTypes(i) = "") Then
                    Exit Do
                End If
                Me.arrayMNU(i) = New TreeNode(modFileSettingsandArray.mnuTypes(i))
                Me.arrayMNU(i).Name = modFileSettingsandArray.mnuTypes(i)
                Me.arrayMNU(i).ContextMenuStrip = Me.cxtMNU
                Me.ROOTnode.Nodes.Add(Me.arrayMNU(i))
                Me.PPP(i) = New ToolStripMenuItem(modFileSettingsandArray.mnuTypes(i))
                Me.cboCat.Items.Add(modFileSettingsandArray.mnuTypes(i))
                Dim num4 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
                Dim j As Integer = 0
                Do While (j <= num4)
                    If (Strings.StrComp(modFileSettingsandArray.mnuTypes(i), modFileSettingsandArray.AllArray(j, 2), CompareMethod.Text) = 0) Then
                        Me.mnu0(j) = New TreeNode(modFileSettingsandArray.AllArray(j, 0))
                        Me.mnu0(j).Name = Conversions.ToString(j)
                        Me.mnu0(j).ContextMenuStrip = Me.cxtItems
                        Me.ROOTnode.Nodes.Item(i).Nodes.Add(Me.mnu0(j))
                        If (Strings.StrComp(modFileSettingsandArray.AllArray(j, 0), "-", CompareMethod.Text) = 0) Then
                            Me.PPP(i).DropDownItems.Add("-")
                            Me.ItemCount += 1
                        ElseIf (Strings.StrComp(modFileSettingsandArray.AllArray(j, 3), "", CompareMethod.Text) = 0) Then
                            Me.subAttachMenuImage(modFileSettingsandArray.AllArray(j, 1))
                            Me.PPP(i).DropDownItems.Add(modFileSettingsandArray.AllArray(j, 0), modMain.arrayImgFileTypes(Me.imageID), New EventHandler(AddressOf Me.SubRunMenuItem))
                            Me.ItemCount += 1
                            modFileSettingsandArray.AllArray(j, 3) = Conversions.ToString(Me.imageID)
                        Else
                            Try 
                                Me.imageID = Convert.ToInt32(modFileSettingsandArray.AllArray(j, 3))
                                Me.PPP(i).DropDownItems.Add(modFileSettingsandArray.AllArray(j, 0), modMain.arrayImgFileTypes(Me.imageID), New EventHandler(AddressOf Me.SubRunMenuItem))
                                Me.ItemCount += 1
                            Catch exception1 As Exception
                                ProjectData.SetProjectError(exception1)
                                Dim exception As Exception = exception1
                                Interaction.MsgBox("??? Some error or something has occurred", MsgBoxStyle.ApplicationModal, Nothing)
                                ProjectData.ClearProjectError
                            End Try
                        End If
                    End If
                    j += 1
                Loop
                i += 1
            Loop
        End Sub

        Private Sub optCommand_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.optCommand.Checked Then
                Me.ckCommand.Enabled = True
            Else
                Me.ckCommand.Enabled = False
                Me.ckCommand.Checked = False
            End If
        End Sub

        Private Sub optFile_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ckCommand.Enabled = False
            Me.ckCommand.Checked = False
        End Sub

        Private Sub optFolder_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.ckCommand.Enabled = False
            Me.ckCommand.Checked = False
        End Sub

        Private Sub pnlEdit_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
            Me.pnlEdit.Visible = False
        End Sub

        Friend Sub SaveNodeStates()
            Dim mnuMax As Integer = MySettingsProperty.Settings.MnuMax
            Dim i As Integer = 0
            Do While (i <= mnuMax)
                If (Strings.StrComp(Me.ROOTnode.TreeView.SelectedNode.Parent.Name, modFileSettingsandArray.mnuTypes(i), CompareMethod.Text) = 0) Then
                    Me.stateData(i) = True
                Else
                    Me.stateData(i) = False
                End If
                i += 1
            Loop
        End Sub

        Friend Sub subAdd(ByVal sender As Object, ByVal e As EventArgs)
            Me.cboCat.SelectedItem = Strings.Trim(Me.txtNode.Text)
            Me.cmdAccept.Text = "Add"
            Me.txt0.Text = "NEW"
            Me.txt1.Text = ""
            Me.optFile.Checked = True
            Me.ckCommand.Checked = False
            Me.ckCommand.Enabled = False
            Me.pnlEdit.Visible = True
            Me.txt0.Select(0, Me.txt0.Text.Length)
            modFileSettingsandArray.SaveSettings
        End Sub

        Friend Sub subAddMenu(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Interaction.InputBox("Enter new Menu Name", "Add Menu", "", -1, -1)
            If (Strings.StrComp(str, "-", CompareMethod.Text) = 0) Then
                Interaction.MsgBox("A separator cannot be added here", MsgBoxStyle.ApplicationModal, Nothing)
            Else
                Dim num As Integer = 1
                If (str <> "") Then
                    Dim index As Integer = 0
                    Do
                        If (Strings.StrComp(modFileSettingsandArray.mnuTypes(index), str, CompareMethod.Text) = 0) Then
                            num = 0
                            Exit Do
                        End If
                        If (Strings.StrComp(modFileSettingsandArray.mnuTypes(index), "", CompareMethod.Text) <> 0) Then
                            Me.mnuItemCount += 1
                        End If
                        index += 1
                    Loop While (index <= 30)
                    If (num = 1) Then
                        If (Me.ROOTnode.Nodes.Count > 0) Then
                            Dim node As New TreeNode
                            node.Text = Strings.Trim(str)
                            node.Name = Strings.Trim(str)
                            node.ContextMenuStrip = Me.cxtMNU
                            Me.ROOTnode.Nodes.Add(node)
                            modFileSettingsandArray.mnuTypes(Me.mnuItemCount) = Strings.Trim(str)
                            modFileSettingsandArray.AllArray(Me.ItemCount, 0) = "NEW ITEM"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 1) = ""
                            modFileSettingsandArray.AllArray(Me.ItemCount, 2) = Strings.Trim(str)
                            Me.cboCat.Items.Add(Strings.Trim(str))
                            Me.mnuItemCount += 1
                            Me.subFormLoadRefresh
                        Else
                            Dim node2 As New TreeNode
                            node2.Text = Strings.Trim(str)
                            node2.Name = Strings.Trim(str)
                            node2.ContextMenuStrip = Me.cxtMNU
                            Me.ROOTnode.Nodes.Add(node2)
                            modFileSettingsandArray.mnuTypes(Me.mnuItemCount) = Strings.Trim(str)
                            modFileSettingsandArray.AllArray(Me.ItemCount, 0) = "NEW ITEM"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 1) = ""
                            modFileSettingsandArray.AllArray(Me.ItemCount, 2) = Strings.Trim(str)
                            modFileSettingsandArray.AllArray(Me.ItemCount, 2) = "File"
                            modFileSettingsandArray.AllArray(Me.ItemCount, 2) = "False"
                            Me.CurrentNodeSelectedForRefresh = node2
                            Me.mnuItemCount += 1
                            Me.cboCat.Items.Add(Strings.Trim(str))
                            Dim num3 As Integer = Me.ROOTnode.TreeView.SelectedNode.Index
                            modFileSettingsandArray.SaveSettings
                            Me.subFormLoadRefresh
                            Me.ROOTnode.Expand
                        End If
                    Else
                        Interaction.MsgBox("Name Must be Unique", MsgBoxStyle.ApplicationModal, "Try Again")
                    End If
                End If
            End If
        End Sub

        Friend Sub subAttachMenuImage(ByVal xyz As String)
            If (Strings.InStr(xyz, modMain.RelativeMarker, CompareMethod.Binary) > 0) Then
                xyz = xyz.Replace(xyz, modMain.RelativeMarker)
            End If
            Try 
                If (xyz = "") Then
                    Me.imageID = 0
                Else
                    Dim str3 As String
                    Dim str4 As String = xyz
                    Dim str6 As String = xyz.Substring(0, 2)
                    Dim str5 As String = xyz.Substring(0, 3)
                    If (xyz.Length < 5) Then
                        str3 = str4
                    Else
                        str3 = xyz.Substring(0, 5)
                    End If
                    Dim str As String = ""
                    Dim str2 As String = ""
                    If (Strings.InStr(str3, "\", CompareMethod.Text) > 0) Then
                        Dim array As String() = xyz.Split(New Char() { "\"c })
                        str2 = array(Information.UBound(array, 1))
                        If (Strings.InStr(str2, ".", CompareMethod.Text) > 0) Then
                            array = str2.Split(New Char() { "."c })
                            str = ("." & array(Information.UBound(array, 1)))
                        End If
                    End If
                    Me.imageID = 0
                    Dim str7 As String = str6
                    If (str7 = "\\") Then
                        Dim strArray2 As String() = xyz.Split(New Char() { "\"c })
                        If (Information.UBound(strArray2, 1) > 2) Then
                            Me.imageID = &H2F
                            If (Strings.StrComp("", strArray2(3), CompareMethod.Text) = 0) Then
                                Me.imageID = &H2D
                            Else
                                Me.imageID = &H2F
                            End If
                        Else
                            Me.imageID = &H2D
                        End If
                    ElseIf (str7 = modMain.RelativeMarker) Then
                        Me.imageID = &H2D
                    Else
                        If (Strings.InStr(str6, ":", CompareMethod.Text) > 0) Then
                            Me.imageID = &H30
                        Else
                            Me.imageID = &H31
                        End If
                        Dim index As Integer = 0
                        Do
                            If (Strings.StrComp(str, modMain.arrayStrFileTypes(index), CompareMethod.Text) = 0) Then
                                Me.imageID = index
                                Exit Do
                            End If
                            index += 1
                        Loop While (index <= 12)
                        Dim num3 As Integer = ((50 + MySettingsProperty.Settings.ProgramCTR) - 1)
                        Dim i As Integer = 50
                        Do While (i <= num3)
                            If (Strings.StrComp(str2, modMain.arrayStrFileTypes(i), CompareMethod.Text) = 0) Then
                                Me.imageID = i
                                Return
                            End If
                            If (Strings.StrComp(str3, modMain.arrayStrFileTypes(i), CompareMethod.Text) = 0) Then
                                Me.imageID = i
                                Return
                            End If
                            i += 1
                        Loop
                    End If
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Sub subCheckRelativitity(ByVal pathx As String)
            Dim startupPath As String = Application.StartupPath
            If (Strings.InStr(startupPath, pathx, CompareMethod.Text) = 0) Then
                pathx = pathx.Replace(startupPath, modMain.RelativeMarker)
                Me.txt1.Text = pathx
            End If
        End Sub

        Friend Sub subClearall(ByVal sender As Object, ByVal e As EventArgs)
            Me.TreeMenu.Nodes.Clear
            Me.ROOTnode = New TreeNode(modMain.CurrentUser)
            Me.ROOTnode.Name = "RootNode"
            Me.ROOTnode.ContextMenuStrip = Me.cxtRoot
            Me.TreeMenu.Nodes.Add(Me.ROOTnode)
            Me.mnuItemCount = 0
            Dim itemMax As Integer = MySettingsProperty.Settings.ItemMax
            Dim i As Integer = 0
            Do While (i <= itemMax)
                If (i < &H1F) Then
                    modFileSettingsandArray.mnuTypes(i) = ""
                End If
                modFileSettingsandArray.AllArray(i, 0) = ""
                modFileSettingsandArray.AllArray(i, 1) = ""
                modFileSettingsandArray.AllArray(i, 2) = ""
                modFileSettingsandArray.AllArray(i, 3) = ""
                modFileSettingsandArray.AllArray(i, 4) = ""
                modFileSettingsandArray.AllArray(i, 5) = ""
                i += 1
            Loop
            modFileSettingsandArray.SaveSettings
            Me.subFormLoadRefresh
        End Sub

        Private Sub subCollapseAll(ByVal sender As Object, ByVal e As EventArgs)
            Me.TreeMenu.CollapseAll
            Me.ROOTnode.Expand
        End Sub

        Friend Sub SubDelete(ByVal sender As Object, ByVal e As EventArgs)
            Dim num As Integer = Convert.ToInt32(Me.txtNode.Text)
            Me.txt0.Text = ""
            Me.txt1.Text = ""
            Me.txt2.Text = ""
            modFileSettingsandArray.AllArray(num, 0) = ""
            modFileSettingsandArray.AllArray(num, 1) = ""
            modFileSettingsandArray.AllArray(num, 2) = ""
            modFileSettingsandArray.AllArray(num, 3) = ""
            modFileSettingsandArray.AllArray(num, 4) = ""
            modFileSettingsandArray.AllArray(num, 5) = ""
            Me.BubbleSort
        End Sub

        Friend Sub SubDeleteMenu(ByVal sender As Object, ByVal e As EventArgs)
            Me.DelMenu(Strings.Trim(Me.txtNode.Text))
        End Sub

        Private Sub subExpandAll(ByVal sender As Object, ByVal e As EventArgs)
            Me.TreeMenu.ExpandAll
        End Sub

        Friend Sub subExport(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                Dim writer As StreamWriter = File.CreateText(modMain.ConfigPath)
                writer.WriteLine(MySettingsProperty.Settings.MenuVersion)
                Dim mnuMax As Integer = MySettingsProperty.Settings.MnuMax
                Dim i As Integer = 0
                Do While (i <= mnuMax)
                    writer.WriteLine(modFileSettingsandArray.mnuTypes(i))
                    i += 1
                Loop
                Dim itemMax As Integer = MySettingsProperty.Settings.ItemMax
                modMain.loopCounter = 0
                Do While (modMain.loopCounter <= itemMax)
                    writer.WriteLine(modFileSettingsandArray.AllArray(modMain.loopCounter, 0))
                    writer.WriteLine(modFileSettingsandArray.AllArray(modMain.loopCounter, 1))
                    writer.WriteLine(modFileSettingsandArray.AllArray(modMain.loopCounter, 2))
                    writer.WriteLine(modFileSettingsandArray.AllArray(modMain.loopCounter, 3))
                    writer.WriteLine(modFileSettingsandArray.AllArray(modMain.loopCounter, 4))
                    writer.WriteLine(modFileSettingsandArray.AllArray(modMain.loopCounter, 5))
                    modMain.loopCounter += 1
                Loop
                writer.Close
                Interaction.MsgBox(("Export Completed to " & Application.StartupPath), MsgBoxStyle.ApplicationModal, Nothing)
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Interaction.MsgBox(exception1.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Friend Sub subFormLoadRefresh()
            Me.Timer1.Enabled = False
            If MySettingsProperty.Settings.Commandeer Then
                Me.ckCommandeer.Checked = True
            Else
                Me.ckCommandeer.Checked = False
            End If
            If (modMain.UserIcon > &H13) Then
                Me.tsiUserMenu.Image = modMain.ObjImg(&H10)
            End If
            Me.mnuItemCount = 0
            Me.ItemCount = 0
            Me.pnlRenameMenu.Visible = False
            Me.pnlEdit.Visible = False
            Me.subLoadMenu
            Me.LoadTreeNodesArrays
            Me.ROOTnode.Expand
            Me.subLoadContextMenu
            Me.Timer1.Enabled = True
        End Sub

        Friend Sub subImport(ByVal sender As Object, ByVal e As EventArgs)
            Try 
                modMain.dlgFile.Title = "Select File to add"
                modMain.dlgFile.InitialDirectory = Application.StartupPath
                modMain.dlgFile.Filter = "All Files (*.*)|*.*"
                modMain.dlgFile.ShowDialog
                modMain.FileName = modMain.dlgFile.FileName
                If Not ((modMain.FileName = "") Or (modMain.FileName = Nothing)) Then
                    Dim str As String = Conversions.ToString(CInt(Interaction.MsgBox("This will overwrite your existing Settings." & ChrW(13) & ChrW(10) & "Do you wish to continue?", MsgBoxStyle.YesNo, "IMPORT CONFIG?")))
                    If (str.ToString = "6") Then
                        Try 
                            Dim reader As New StreamReader(modMain.FileName)
                            Dim str2 As String = reader.ReadLine
                            Dim mnuMax As Integer = MySettingsProperty.Settings.MnuMax
                            Dim i As Integer = 0
                            Do While (i <= mnuMax)
                                modFileSettingsandArray.mnuTypes(i) = reader.ReadLine
                                i += 1
                            Loop
                            Dim itemMax As Integer = MySettingsProperty.Settings.ItemMax
                            modMain.loopCounter = 0
                            Do While (modMain.loopCounter <= itemMax)
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 0) = ""
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 1) = ""
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 2) = ""
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 3) = ""
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 4) = ""
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 5) = ""
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 0) = reader.ReadLine
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 1) = reader.ReadLine
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 2) = reader.ReadLine
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 3) = reader.ReadLine
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 4) = reader.ReadLine
                                modFileSettingsandArray.AllArray(modMain.loopCounter, 5) = reader.ReadLine
                                modMain.loopCounter += 1
                            Loop
                            reader.Close
                            Me.BubbleSort
                            Dim num8 As Integer = MySettingsProperty.Settings.ItemMax
                            Dim j As Integer = 0
                            Do While (j <= num8)
                                Dim num3 As Integer = 1
                                Dim index As Integer = 0
                                Dim num9 As Integer = MySettingsProperty.Settings.MnuMax
                                Dim k As Integer = 0
                                Do While (k <= num9)
                                    If (Strings.StrComp(modFileSettingsandArray.mnuTypes(k), modFileSettingsandArray.AllArray(j, 2), CompareMethod.Text) = 0) Then
                                        num3 = 0
                                        Exit Do
                                    End If
                                    If (Strings.StrComp(modFileSettingsandArray.mnuTypes(k), "", CompareMethod.Text) <> 0) Then
                                        index += 1
                                    ElseIf (Strings.StrComp(modFileSettingsandArray.mnuTypes(k), "", CompareMethod.Text) = 0) Then
                                        Exit Do
                                    End If
                                    k += 1
                                Loop
                                If (num3 = 1) Then
                                    modFileSettingsandArray.mnuTypes(index) = modFileSettingsandArray.AllArray(j, 2)
                                End If
                                j += 1
                            Loop
                            modFileSettingsandArray.SaveSettings
                            Me.subFormLoadRefresh
                        Catch exception1 As Exception
                            ProjectData.SetProjectError(exception1)
                            Interaction.MsgBox(("You have chosen Poorly... Actually the error was " & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & exception1.ToString), MsgBoxStyle.ApplicationModal, Nothing)
                            ProjectData.ClearProjectError
                        End Try
                    ElseIf (str.ToString = "7") Then
                    End If
                End If
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Interaction.MsgBox(exception3.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Private Sub subItemMoveDown(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Strings.Trim(Me.txt2.Text)
            Dim str2 As String = Strings.Trim(Me.txt0.Text)
            Dim num As Integer = Convert.ToInt32(Me.txtNode.Text)
            Dim i As Integer = (num + 1)
            Do While (i <= 90)
                If (Strings.StrComp(modFileSettingsandArray.AllArray(i, 2), str, CompareMethod.Text) = 0) Then
                    Dim str3 As String = modFileSettingsandArray.AllArray(i, 0)
                    Dim str4 As String = modFileSettingsandArray.AllArray(i, 1)
                    Dim str5 As String = modFileSettingsandArray.AllArray(i, 2)
                    Dim str6 As String = modFileSettingsandArray.AllArray(i, 3)
                    Dim str7 As String = modFileSettingsandArray.AllArray(i, 4)
                    Dim str8 As String = modFileSettingsandArray.AllArray(i, 5)
                    modFileSettingsandArray.AllArray(i, 0) = modFileSettingsandArray.AllArray(num, 0)
                    modFileSettingsandArray.AllArray(i, 1) = modFileSettingsandArray.AllArray(num, 1)
                    modFileSettingsandArray.AllArray(i, 2) = modFileSettingsandArray.AllArray(num, 2)
                    modFileSettingsandArray.AllArray(i, 3) = modFileSettingsandArray.AllArray(num, 3)
                    modFileSettingsandArray.AllArray(i, 4) = modFileSettingsandArray.AllArray(num, 4)
                    modFileSettingsandArray.AllArray(i, 5) = modFileSettingsandArray.AllArray(num, 5)
                    modFileSettingsandArray.AllArray(num, 0) = str3
                    modFileSettingsandArray.AllArray(num, 1) = str4
                    modFileSettingsandArray.AllArray(num, 2) = str5
                    modFileSettingsandArray.AllArray(num, 3) = str6
                    modFileSettingsandArray.AllArray(num, 4) = str7
                    modFileSettingsandArray.AllArray(num, 5) = str8
                    Me.CurrentNodeSelectedForRefresh = Me.ROOTnode.TreeView.SelectedNode
                    Me.pnlEdit.Visible = False
                    Me.SaveNodeStates
                    Me.subFormLoadRefresh
                    Me.LoadNodeStates
                    Return
                End If
                i += 1
            Loop
        End Sub

        Private Sub subItemMoveUP(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Strings.Trim(Me.txt2.Text)
            Dim str2 As String = Strings.Trim(Me.txt0.Text)
            Dim num As Integer = Convert.ToInt32(Me.txtNode.Text)
            Dim i As Integer = (num - 1)
            Do While (i >= 0)
                If (Strings.StrComp(modFileSettingsandArray.AllArray(i, 2), str, CompareMethod.Text) = 0) Then
                    Dim str3 As String = modFileSettingsandArray.AllArray(i, 0)
                    Dim str4 As String = modFileSettingsandArray.AllArray(i, 1)
                    Dim str5 As String = modFileSettingsandArray.AllArray(i, 2)
                    Dim str6 As String = modFileSettingsandArray.AllArray(i, 3)
                    Dim str7 As String = modFileSettingsandArray.AllArray(i, 4)
                    Dim str8 As String = modFileSettingsandArray.AllArray(i, 5)
                    modFileSettingsandArray.AllArray(i, 0) = modFileSettingsandArray.AllArray(num, 0)
                    modFileSettingsandArray.AllArray(i, 1) = modFileSettingsandArray.AllArray(num, 1)
                    modFileSettingsandArray.AllArray(i, 2) = modFileSettingsandArray.AllArray(num, 2)
                    modFileSettingsandArray.AllArray(i, 3) = modFileSettingsandArray.AllArray(num, 3)
                    modFileSettingsandArray.AllArray(i, 4) = modFileSettingsandArray.AllArray(num, 4)
                    modFileSettingsandArray.AllArray(i, 5) = modFileSettingsandArray.AllArray(num, 5)
                    modFileSettingsandArray.AllArray(num, 0) = str3
                    modFileSettingsandArray.AllArray(num, 1) = str4
                    modFileSettingsandArray.AllArray(num, 2) = str5
                    modFileSettingsandArray.AllArray(num, 3) = str6
                    modFileSettingsandArray.AllArray(num, 4) = str7
                    modFileSettingsandArray.AllArray(num, 5) = str8
                    Me.pnlEdit.Visible = False
                    Me.CurrentNodeSelectedForRefresh = Me.ROOTnode.TreeView.SelectedNode
                    Me.SaveNodeStates
                    Me.subFormLoadRefresh
                    Me.LoadNodeStates
                    Return
                End If
                i = (i + -1)
            Loop
        End Sub

        Friend Sub subLoadContextMenu()
            Me.assMenu = New ContextMenuStrip
            Me.assMenu.Items.Clear
            Me.assMenu.BackColor = Color.Transparent
            Dim size As New Size(MySettingsProperty.Settings.intMenuImageSize, MySettingsProperty.Settings.intMenuImageSize)
            Me.assMenu.ImageScalingSize = size
            Me.assMenu.DefaultDropDownDirection = ToolStripDropDownDirection.Left
            Me.tsiUserMenu.DropDownItems.Clear
            Me.tsiUserMenu.DropDownItems.Add(Me.tsiMYDocs)
            Me.tsiUserMenu.DropDownItems.Add(Me.tsiDesktop)
            Me.tsiLocalUserMenu.DropDownItems.Clear
            Me.tsiLocalUserMenu.DropDownItems.Add(Me.tsiLocalMYDocs)
            Me.tsiLocalUserMenu.DropDownItems.Add(Me.tsiLocalDesktop)
            Me.tsiMYCompMenu.DropDownItems.Clear
            Me.tsiMYCompMenu.DropDownItems.Add(Me.tsiLocalMYComp)
            Me.tsiMYCompMenu.DropDownItems.Add(Me.tsiCompmgmt)
            Me.tsiMYCompMenu.DropDownItems.Add(Me.tsiControlPanel)
            Me.tsiMYCompMenu.DropDownItems.Add(Me.tsiLocalRegedit)
            Me.tsiMYCompMenu.DropDownItems.Add(Me.tsiPrinter)
            Me.tsiMYCompMenu.DropDownItems.Add("-")
            Me.tsiMYCompMenu.DropDownItems.Add(Me.tsiHelp)
            Me.tsiTKMenu.DropDownItems.Clear
            Me.tsiTKMenu.DropDownItems.Add(Me.tsiADminTK)
            Me.assMenu.Items.Add(Me.tsiUserMenu)
            If modMain.Registered Then
                If modMain.aDMin Then
                    Me.assMenu.Items.Add(Me.tsiLocalUserMenu)
                    Me.assMenu.Items.Add(Me.tsiMYCompMenu)
                End If
            Else
                Me.assMenu.Items.Add(Me.tsiRegister)
            End If
            Me.assMenu.Items.Add("-")
            Me.assMenu.Items.Add("Modify Menu...", Resources.imgSettingsCog, New EventHandler(AddressOf MenuSubs.subModMenu))
            If (modMain.Registered AndAlso (MySettingsProperty.Settings.Commandeer And modMain.aDMin)) Then
                If (Strings.StrComp(modMain.CurrentUser.ToUpper, modMain.UserLoggedInLocally.ToUpper, CompareMethod.Text) <> 0) Then
                    Me.assMenu.Items.Add(Me.tsiCommandeer)
                    Me.ckCommandeer.Checked = True
                Else
                    Me.ckCommandeer.Checked = False
                End If
            End If
            Me.assMenu.Items.Add(Me.tsiTKMenu)
            Me.assMenu.Items.Add("-")
            If modMain.Registered Then
                If (Me.ROOTnode.Nodes.Count > 0) Then
                    Dim num4 As Integer = (Me.ROOTnode.Nodes.Count - 1)
                    Dim i As Integer = 0
                    Do While (i <= num4)
                        If (Me.PPP(i).Text <> "") Then
                            Me.assMenu.Items.Add(Me.PPP(i))
                        End If
                        i += 1
                    Loop
                    Me.assMenu.Items.Add("-")
                End If
            ElseIf (Me.ROOTnode.Nodes.Count > 0) Then
                Dim count As Integer = 0
                If (Me.ROOTnode.Nodes.Count > 3) Then
                    count = 3
                Else
                    count = Me.ROOTnode.Nodes.Count
                End If
                Dim num5 As Integer = (count - 1)
                Dim j As Integer = 0
                Do While (j <= num5)
                    If (Me.PPP(j).Text <> "") Then
                        Me.assMenu.Items.Add(Me.PPP(j))
                    End If
                    j += 1
                Loop
                Me.assMenu.Items.Add("-")
            End If
            If modMain.Registered Then
                Me.assMenu.Items.Add(Me.tsiExplore)
                Me.assMenu.Items.Add("Run...", Resources.imgRun, New EventHandler(AddressOf MenuSubs.subRun))
                Me.assMenu.Items.Add("-")
            End If
            Me.assMenu.Items.Add("Exit", Resources.imgAEShutdown, New EventHandler(AddressOf modMain.ExitAPP))
            Me.assMenu.Items.Item(0).BackColor = Color.Blue
            Me.assMenu.Items.Item(0).ForeColor = Color.White
            Me.assMenu.Items.Item(0).ToolTipText = "Click to change you icon"
            Me.cmd.ContextMenuStrip = Me.assMenu
            modMain.mobNotifyIcon.ContextMenuStrip = Me.assMenu
            MyProject.Forms.frmCool.picBox.ContextMenuStrip = Me.assMenu
            Me.tsiUserMenu.Text = Strings.UCase(modMain.CurrentUserName.Name)
            Me.tsiUserMenu.Image = modMain.ObjImg(modMain.UserIcon)
            If Not modMain.Registered Then
                Me.tsiUserMenu.Text = (modMain.CurrentUserName.Name & "(DEMO)")
                Me.tsiUserMenu.Image = modMain.ObjImg(modMain.UserIcon)
            End If
        End Sub

        Friend Sub subLoadMenu()
            Me.cxtRoot.Items.Clear
            Dim size As New Size(MySettingsProperty.Settings.intMenuImageSize, MySettingsProperty.Settings.intMenuImageSize)
            Me.cxtRoot.ImageScalingSize = size
            Me.cxtRoot.Items.Add(Me.AddMenuButton)
            Me.cxtRoot.Items.Add("-")
            Me.cxtRoot.Items.Add("Import", Resources.imgImport, New EventHandler(AddressOf Me.subImport))
            Me.cxtRoot.Items.Add("Export", Resources.imgExport, New EventHandler(AddressOf Me.subExport))
            Me.cxtRoot.Items.Add("-")
            Me.cxtRoot.Items.Add("Expand All", Resources.imgBlank, New EventHandler(AddressOf Me.subExpandAll))
            Me.cxtRoot.Items.Add("Collapse All", Resources.imgBlank, New EventHandler(AddressOf Me.subCollapseAll))
            Me.cxtRoot.Items.Add("-")
            Me.cxtRoot.Items.Add("Clear Menus", Resources.imgRedx, New EventHandler(AddressOf Me.subClearall))
            Me.cxtMNU.Items.Clear
            size = New Size(MySettingsProperty.Settings.intMenuImageSize, MySettingsProperty.Settings.intMenuImageSize)
            Me.cxtMNU.ImageScalingSize = size
            Me.cxtMNU.Items.Add("Rename", Resources.imgRename, New EventHandler(AddressOf Me.SubRename))
            Me.cxtMNU.Items.Add("Delete", Resources.DELBLANDRED, New EventHandler(AddressOf Me.SubDeleteMenu))
            Me.cxtMNU.Items.Add("Add", Resources.ADDBLAND, New EventHandler(AddressOf Me.subAdd))
            Me.cxtMNU.Items.Add("-")
            Me.cxtMNU.Items.Add("Move Up", Resources.UPBLAND, New EventHandler(AddressOf Me.subMenuMoveUP))
            Me.cxtMNU.Items.Add("Move Down", Resources.DOWNBLAND, New EventHandler(AddressOf Me.subMenuMoveDown))
            Me.cxtItems.Items.Clear
            size = New Size(MySettingsProperty.Settings.intMenuImageSize, MySettingsProperty.Settings.intMenuImageSize)
            Me.cxtItems.ImageScalingSize = size
            Me.cxtItems.Items.Add("Delete", Resources.DELBLANDRED, New EventHandler(AddressOf Me.SubDelete))
            Me.cxtItems.Items.Add("-")
            Me.cxtItems.Items.Add("Move Up", Resources.UPBLAND, New EventHandler(AddressOf Me.subItemMoveUP))
            Me.cxtItems.Items.Add("Move Down", Resources.DOWNBLAND, New EventHandler(AddressOf Me.subItemMoveDown))
            Me.cxtVariables.Items.Clear
            size = New Size(MySettingsProperty.Settings.intMenuImageSize, MySettingsProperty.Settings.intMenuImageSize)
            Me.cxtVariables.ImageScalingSize = size
            Dim num2 As Integer = (Information.UBound(modMain.AeVar, 1) - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                Me.cxtVariables.Items.Add(("Variable: " & modMain.AeVar(i)), Resources.imgBlank, New EventHandler(AddressOf Me.subVar))
                i += 1
            Loop
            Me.txt1.ContextMenuStrip = Me.cxtVariables
        End Sub

        Private Sub subMenuMoveDown(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = (MySettingsProperty.Settings.MnuMax - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (Strings.StrComp(Strings.Trim(Me.txtNode.Text), modFileSettingsandArray.mnuTypes(i), CompareMethod.Text) = 0) Then
                    If (i = (Me.ROOTnode.Nodes.Count - 1)) Then
                        Return
                    End If
                    Dim str As String = modFileSettingsandArray.mnuTypes((i + 1))
                    modFileSettingsandArray.mnuTypes((i + 1)) = modFileSettingsandArray.mnuTypes(i)
                    modFileSettingsandArray.mnuTypes(i) = str
                    Me.pnlEdit.Visible = False
                    Me.SaveNodeStates
                    Me.subFormLoadRefresh
                    Me.LoadNodeStates
                    Exit Do
                End If
                i += 1
            Loop
        End Sub

        Private Sub subMenuMoveUP(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = (MySettingsProperty.Settings.MnuMax - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (Strings.StrComp(Strings.Trim(Me.txtNode.Text), modFileSettingsandArray.mnuTypes(i), CompareMethod.Text) = 0) Then
                    If (i = 0) Then
                        Return
                    End If
                    Dim str As String = modFileSettingsandArray.mnuTypes((i - 1))
                    modFileSettingsandArray.mnuTypes((i - 1)) = modFileSettingsandArray.mnuTypes(i)
                    modFileSettingsandArray.mnuTypes(i) = str
                    Me.pnlEdit.Visible = False
                    Me.SaveNodeStates
                    Me.subFormLoadRefresh
                    Me.LoadNodeStates
                    Exit Do
                End If
                i += 1
            Loop
        End Sub

        Friend Sub SubRename(ByVal sender As Object, ByVal e As EventArgs)
            If (Strings.StrComp(Me.TreeMenu.SelectedNode.Name, "ROOTnode", CompareMethod.Text) <> 0) Then
                Me.txtRenameNode.Text = Me.TreeMenu.SelectedNode.Name
                Me.pnlRenameMenu.Visible = True
                Me.renameMenu = True
            End If
        End Sub

        Friend Sub SubRunMenuItem(ByVal sender As Object, ByVal e As EventArgs)
            Dim num2 As Integer = (MySettingsProperty.Settings.ItemMax - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (Strings.StrComp(Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(0  - 1) {}, Nothing, Nothing, Nothing)), modFileSettingsandArray.AllArray(i, 0), CompareMethod.Text) = 0) Then
                    If modMain.Registered Then
                        UFR.UFR(modFileSettingsandArray.AllArray(i, 1), modFileSettingsandArray.AllArray(i, 4), i)
                        Exit Do
                    End If
                    If Not modMain.Registered Then
                        MyProject.Forms.frmNag.Show
                        MyProject.Forms.frmNag.passvar(modFileSettingsandArray.AllArray(i, 1), modFileSettingsandArray.AllArray(i, 4), i)
                        Exit Do
                    End If
                End If
                i += 1
            Loop
        End Sub

        Friend Sub subVar(ByVal sender As Object, ByVal e As EventArgs)
            Dim str As String = Conversions.ToString(NewLateBinding.LateGet(sender, Nothing, "text", New Object(0  - 1) {}, Nothing, Nothing, Nothing))
            Dim num2 As Integer = (Information.UBound(modMain.AeVar, 1) - 1)
            Dim i As Integer = 0
            Do While (i <= num2)
                If (Strings.StrComp(("Variable: " & modMain.AeVar(i)), str, CompareMethod.Text) = 0) Then
                    Me.txt1.Text = (Me.txt1.Text & modMain.AeVar(i))
                    Me.txt1.Select(Me.txt1.Text.Length, 0)
                    Exit Do
                End If
                i += 1
            Loop
        End Sub

        Friend Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If (Strings.StrComp(Strings.Trim(Me.txt0.Text), "", CompareMethod.Text) = 0) Then
                If Not Me.txt0.Focused Then
                    Me.pnlEdit.Visible = False
                End If
            Else
                Me.pnlEdit.Visible = True
            End If
            If Not Me.pnlEdit.Visible Then
                If Not Me.pnlRenameMenu.Visible Then
                    Me.lblInstruction.Visible = True
                    Me.lblInstruction.Left = &H16E
                    Me.lblInstruction.Top = &H4A
                Else
                    Me.lblInstruction.Visible = False
                End If
            Else
                Me.lblInstruction.Visible = False
            End If
            If Not modMain.Registered Then
                If (Me.ROOTnode.Nodes.Count = 2) Then
                    Me.AddMenuButton.Enabled = False
                Else
                    Me.AddMenuButton.Enabled = True
                End If
            ElseIf (Me.ROOTnode.Nodes.Count = MySettingsProperty.Settings.MnuMax) Then
                Me.AddMenuButton.Enabled = False
            Else
                Me.AddMenuButton.Enabled = True
            End If
            If Me.optCommand.Checked Then
                Me.Browse.Enabled = False
            Else
                Me.Browse.Enabled = True
            End If
            If Me.ckCommandeer.Checked Then
                MySettingsProperty.Settings.Commandeer = True
            Else
                MySettingsProperty.Settings.Commandeer = False
            End If
            If Me.tsiUserMenu.Selected Then
                Me.tsiUserMenu.ForeColor = Color.Black
                Me.tsiUserMenu.BackColor = Color.Transparent
            Else
                Me.tsiUserMenu.ForeColor = Color.White
                Me.tsiUserMenu.BackColor = Color.Blue
            End If
        End Sub

        Private Sub tmrDemo_Tick(ByVal sender As Object, ByVal e As EventArgs)
            MyProject.Forms.frmCool.Hide
            Interaction.MsgBox("Your timer has expired.  To enable all functionality and remove this timer, purchase a license key.", MsgBoxStyle.ApplicationModal, Nothing)
            Application.Exit
        End Sub

        Friend Sub TreeMenu_NodeMouseClick(ByVal s As Object, ByVal e As TreeNodeMouseClickEventArgs)
            Me.renameMenu = False
            Me.pnlRenameMenu.Visible = False
            Dim name As String = e.Node.Name
            Me.TreeMenu.SelectedNode = e.Node
            Me.txtNode.Text = e.Node.Name
            Try 
                Me.SelectedNodeIndexNumber = Convert.ToInt32(e.Node.Name)
                Me.txt0.Text = modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 0)
                Me.txt1.Text = modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 1)
                Me.txt2.Text = modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 2)
                If (Strings.StrComp(modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 4), "Command", CompareMethod.Text) = 0) Then
                    Me.optCommand.Checked = True
                    If (Strings.StrComp(modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 5), "True", CompareMethod.Text) = 0) Then
                        Me.ckCommand.Checked = True
                    Else
                        Me.ckCommand.Checked = False
                    End If
                ElseIf (Strings.StrComp(modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 4), "Folder", CompareMethod.Text) = 0) Then
                    Me.optFolder.Checked = True
                ElseIf (Strings.StrComp(modFileSettingsandArray.AllArray(Me.SelectedNodeIndexNumber, 4), "File", CompareMethod.Text) = 0) Then
                    Me.optFile.Checked = True
                End If
                Me.cboCat.SelectedItem = e.Node.Parent.Name
                Me.cmdAccept.Text = "Save"
            Catch exception1 As FormatException
                ProjectData.SetProjectError(exception1)
                Dim exception As FormatException = exception1
                Me.txt0.Text = ""
                Me.txt1.Text = ""
                ProjectData.ClearProjectError
            Catch exception3 As Exception
                ProjectData.SetProjectError(exception3)
                Interaction.MsgBox(exception3.ToString, MsgBoxStyle.ApplicationModal, Nothing)
                ProjectData.ClearProjectError
            End Try
        End Sub

        Private Sub txt0_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.txt0.Select(0, Me.txt0.Text.Length)
        End Sub

        Private Sub txt0_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyCode = Keys.Enter) Then
                e.Handled = True
                Me.cmdACceptCode(Me.cmdAccept.Text)
            End If
        End Sub

        Private Sub txt1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.txt1.Select(0, Me.txt1.Text.Length)
        End Sub

        Private Sub txt1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyCode = Keys.Enter) Then
                e.Handled = True
                Me.cmdACceptCode(Me.cmdAccept.Text)
            End If
        End Sub


        ' Properties
        Friend Overridable Property Browse As Button
            Get
                Return Me._Browse
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._Browse Is Nothing) Then
                    RemoveHandler Me._Browse.Click, New EventHandler(AddressOf Me.Browse_Click)
                End If
                Me._Browse = WithEventsValue
                If (Not Me._Browse Is Nothing) Then
                    AddHandler Me._Browse.Click, New EventHandler(AddressOf Me.Browse_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cboCat As EnterComboBox
            Get
                Return Me._cboCat
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterComboBox)
                Me._cboCat = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ckCommand As CheckBox
            Get
                Return Me._ckCommand
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckCommand = WithEventsValue
            End Set
        End Property

        Friend Overridable Property ckCommandeer As CheckBox
            Get
                Return Me._ckCommandeer
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As CheckBox)
                Me._ckCommandeer = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmd As Button
            Get
                Return Me._cmd
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                Me._cmd = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdAccept As Button
            Get
                Return Me._cmdAccept
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdAccept Is Nothing) Then
                    RemoveHandler Me._cmdAccept.Click, New EventHandler(AddressOf Me.cmdAccept_Click)
                End If
                Me._cmdAccept = WithEventsValue
                If (Not Me._cmdAccept Is Nothing) Then
                    AddHandler Me._cmdAccept.Click, New EventHandler(AddressOf Me.cmdAccept_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdClose As Button
            Get
                Return Me._cmdClose
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdClose Is Nothing) Then
                    RemoveHandler Me._cmdClose.Click, New EventHandler(AddressOf Me.cmdClose_Click)
                End If
                Me._cmdClose = WithEventsValue
                If (Not Me._cmdClose Is Nothing) Then
                    AddHandler Me._cmdClose.Click, New EventHandler(AddressOf Me.cmdClose_Click)
                End If
            End Set
        End Property

        Friend Overridable Property cmdRenameMenu As Button
            Get
                Return Me._cmdRenameMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdRenameMenu Is Nothing) Then
                    RemoveHandler Me._cmdRenameMenu.Click, New EventHandler(AddressOf Me.cmdRenameMenu_Click)
                End If
                Me._cmdRenameMenu = WithEventsValue
                If (Not Me._cmdRenameMenu Is Nothing) Then
                    AddHandler Me._cmdRenameMenu.Click, New EventHandler(AddressOf Me.cmdRenameMenu_Click)
                End If
            End Set
        End Property

        Friend Overridable Property dg As DataGridView
            Get
                Return Me._dg
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As DataGridView)
                Me._dg = WithEventsValue
            End Set
        End Property

        Friend Overridable Property GroupBox1 As GroupBox
            Get
                Return Me._GroupBox1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._GroupBox1 = WithEventsValue
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

        Friend Overridable Property Label4 As Label
            Get
                Return Me._Label4
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._Label4 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property lblInstruction As Label
            Get
                Return Me._lblInstruction
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Label)
                Me._lblInstruction = WithEventsValue
            End Set
        End Property

        Friend Overridable Property optCommand As RadioButton
            Get
                Return Me._optCommand
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._optCommand Is Nothing) Then
                    RemoveHandler Me._optCommand.CheckedChanged, New EventHandler(AddressOf Me.optCommand_CheckedChanged)
                End If
                Me._optCommand = WithEventsValue
                If (Not Me._optCommand Is Nothing) Then
                    AddHandler Me._optCommand.CheckedChanged, New EventHandler(AddressOf Me.optCommand_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property optFile As RadioButton
            Get
                Return Me._optFile
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._optFile Is Nothing) Then
                    RemoveHandler Me._optFile.CheckedChanged, New EventHandler(AddressOf Me.optFile_CheckedChanged)
                End If
                Me._optFile = WithEventsValue
                If (Not Me._optFile Is Nothing) Then
                    AddHandler Me._optFile.CheckedChanged, New EventHandler(AddressOf Me.optFile_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property optFolder As RadioButton
            Get
                Return Me._optFolder
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As RadioButton)
                If (Not Me._optFolder Is Nothing) Then
                    RemoveHandler Me._optFolder.CheckedChanged, New EventHandler(AddressOf Me.optFolder_CheckedChanged)
                End If
                Me._optFolder = WithEventsValue
                If (Not Me._optFolder Is Nothing) Then
                    AddHandler Me._optFolder.CheckedChanged, New EventHandler(AddressOf Me.optFolder_CheckedChanged)
                End If
            End Set
        End Property

        Friend Overridable Property pnlEdit As Panel
            Get
                Return Me._pnlEdit
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Panel)
                If (Not Me._pnlEdit Is Nothing) Then
                    RemoveHandler Me._pnlEdit.LostFocus, New EventHandler(AddressOf Me.pnlEdit_LostFocus)
                End If
                Me._pnlEdit = WithEventsValue
                If (Not Me._pnlEdit Is Nothing) Then
                    AddHandler Me._pnlEdit.LostFocus, New EventHandler(AddressOf Me.pnlEdit_LostFocus)
                End If
            End Set
        End Property

        Friend Overridable Property pnlRenameMenu As Panel
            Get
                Return Me._pnlRenameMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Panel)
                Me._pnlRenameMenu = WithEventsValue
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

        Friend Overridable Property tmrDemo As Timer
            Get
                Return Me._tmrDemo
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._tmrDemo Is Nothing) Then
                    RemoveHandler Me._tmrDemo.Tick, New EventHandler(AddressOf Me.tmrDemo_Tick)
                End If
                Me._tmrDemo = WithEventsValue
                If (Not Me._tmrDemo Is Nothing) Then
                    AddHandler Me._tmrDemo.Tick, New EventHandler(AddressOf Me.tmrDemo_Tick)
                End If
            End Set
        End Property

        Friend Overridable Property TreeMenu As TreeView
            Get
                Return Me._TreeMenu
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TreeView)
                If (Not Me._TreeMenu Is Nothing) Then
                    RemoveHandler Me._TreeMenu.NodeMouseClick, New TreeNodeMouseClickEventHandler(AddressOf Me.TreeMenu_NodeMouseClick)
                End If
                Me._TreeMenu = WithEventsValue
                If (Not Me._TreeMenu Is Nothing) Then
                    AddHandler Me._TreeMenu.NodeMouseClick, New TreeNodeMouseClickEventHandler(AddressOf Me.TreeMenu_NodeMouseClick)
                End If
            End Set
        End Property

        Friend Overridable Property txt0 As EnterTextBox
            Get
                Return Me._txt0
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                If (Not Me._txt0 Is Nothing) Then
                    RemoveHandler Me._txt0.KeyDown, New KeyEventHandler(AddressOf Me.txt0_KeyDown)
                    RemoveHandler Me._txt0.DoubleClick, New EventHandler(AddressOf Me.txt0_DoubleClick)
                End If
                Me._txt0 = WithEventsValue
                If (Not Me._txt0 Is Nothing) Then
                    AddHandler Me._txt0.KeyDown, New KeyEventHandler(AddressOf Me.txt0_KeyDown)
                    AddHandler Me._txt0.DoubleClick, New EventHandler(AddressOf Me.txt0_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property txt1 As EnterTextBox
            Get
                Return Me._txt1
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                If (Not Me._txt1 Is Nothing) Then
                    RemoveHandler Me._txt1.KeyDown, New KeyEventHandler(AddressOf Me.txt1_KeyDown)
                    RemoveHandler Me._txt1.DoubleClick, New EventHandler(AddressOf Me.txt1_DoubleClick)
                End If
                Me._txt1 = WithEventsValue
                If (Not Me._txt1 Is Nothing) Then
                    AddHandler Me._txt1.KeyDown, New KeyEventHandler(AddressOf Me.txt1_KeyDown)
                    AddHandler Me._txt1.DoubleClick, New EventHandler(AddressOf Me.txt1_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property txt2 As TextBox
            Get
                Return Me._txt2
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txt2 = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtNode As TextBox
            Get
                Return Me._txtNode
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As TextBox)
                Me._txtNode = WithEventsValue
            End Set
        End Property

        Friend Overridable Property txtRenameNode As EnterTextBox
            Get
                Return Me._txtRenameNode
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterTextBox)
                Me._txtRenameNode = WithEventsValue
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("Browse")> _
        Private _Browse As Button
        <AccessedThroughProperty("cboCat")> _
        Private _cboCat As EnterComboBox
        <AccessedThroughProperty("ckCommand")> _
        Private _ckCommand As CheckBox
        <AccessedThroughProperty("ckCommandeer")> _
        Private _ckCommandeer As CheckBox
        <AccessedThroughProperty("cmd")> _
        Private _cmd As Button
        <AccessedThroughProperty("cmdAccept")> _
        Private _cmdAccept As Button
        <AccessedThroughProperty("cmdClose")> _
        Private _cmdClose As Button
        <AccessedThroughProperty("cmdRenameMenu")> _
        Private _cmdRenameMenu As Button
        <AccessedThroughProperty("dg")> _
        Private _dg As DataGridView
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("Label3")> _
        Private _Label3 As Label
        <AccessedThroughProperty("Label4")> _
        Private _Label4 As Label
        <AccessedThroughProperty("lblInstruction")> _
        Private _lblInstruction As Label
        <AccessedThroughProperty("optCommand")> _
        Private _optCommand As RadioButton
        <AccessedThroughProperty("optFile")> _
        Private _optFile As RadioButton
        <AccessedThroughProperty("optFolder")> _
        Private _optFolder As RadioButton
        <AccessedThroughProperty("pnlEdit")> _
        Private _pnlEdit As Panel
        <AccessedThroughProperty("pnlRenameMenu")> _
        Private _pnlRenameMenu As Panel
        <AccessedThroughProperty("Timer1")> _
        Private _Timer1 As Timer
        <AccessedThroughProperty("tmrDemo")> _
        Private _tmrDemo As Timer
        <AccessedThroughProperty("TreeMenu")> _
        Private _TreeMenu As TreeView
        <AccessedThroughProperty("txt0")> _
        Private _txt0 As EnterTextBox
        <AccessedThroughProperty("txt1")> _
        Private _txt1 As EnterTextBox
        <AccessedThroughProperty("txt2")> _
        Private _txt2 As TextBox
        <AccessedThroughProperty("txtNode")> _
        Private _txtNode As TextBox
        <AccessedThroughProperty("txtRenameNode")> _
        Private _txtRenameNode As EnterTextBox
        Friend AddMenuButton As ToolStripMenuItem
        Friend arrayMNU As TreeNode()
        Friend assMenu As ContextMenuStrip
        Private components As IContainer
        Friend CurrentNodeSelectedForRefresh As TreeNode
        Private cxtItems As ContextMenuStrip
        Private cxtMNU As ContextMenuStrip
        Private cxtRoot As ContextMenuStrip
        Private cxtVariables As ContextMenuStrip
        Friend imageID As Integer
        Friend ItemCount As Integer
        Friend mnu0 As TreeNode()
        Friend mnuItemCount As Integer
        Friend PicMenu As Size
        Friend PicWin As Size
        Friend PPP As ToolStripMenuItem()
        Friend renameMenu As Boolean
        Friend ROOTnode As TreeNode
        Friend SelectedNodeIndexNumber As Integer
        Friend stateData As Boolean()
        Friend tsiADminTK As ToolStripMenuItem
        Friend tsiCommandeer As ToolStripMenuItem
        Friend tsiCompmgmt As ToolStripMenuItem
        Friend tsiControlPanel As ToolStripMenuItem
        Friend tsiDesktop As ToolStripMenuItem
        Friend tsiExplore As ToolStripMenuItem
        Friend tsiHelp As ToolStripMenuItem
        Friend tsiLocalDesktop As ToolStripMenuItem
        Friend tsiLocalMYComp As ToolStripMenuItem
        Friend tsiLocalMYDocs As ToolStripMenuItem
        Friend tsiLocalRegedit As ToolStripMenuItem
        Friend tsiLocalUserMenu As ToolStripMenuItem
        Friend tsiMYCompMenu As ToolStripMenuItem
        Friend tsiMYDocs As ToolStripMenuItem
        Friend tsiPrinter As ToolStripMenuItem
        Friend tsiRegister As ToolStripMenuItem
        Friend tsiTKMenu As ToolStripMenuItem
        Friend tsiUserMenu As ToolStripMenuItem
        Friend Unique As Integer
    End Class
End Namespace

