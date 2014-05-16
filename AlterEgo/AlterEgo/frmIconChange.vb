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
    Public Class frmIconChange
        Inherits Form
        ' Methods
        Public Sub New()
            AddHandler MyBase.Load, New EventHandler(AddressOf Me.frmIconChange_Load)
            Me.InitializeComponent
        End Sub

        Private Sub cmdSelect_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.subSaveIconPreference
        End Sub

        <DebuggerNonUserCode> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing AndAlso (Not Me.components Is Nothing)) Then
                Me.components.Dispose
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Sub frmIconChange_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.Hide
            Me.subloadCombos
            Me.subLoadIcons
            If (MySettingsProperty.Settings.intStatupLocation = 0) Then
                Me.optSystray.Checked = True
            Else
                Me.optWindows.Checked = True
            End If
            Me.lst.SelectedIndex = modMain.UserIcon
            Me.pic.Image = modMain.ObjImg(modMain.UserIcon)
            Me.Left = (modMain.ScreenWidth - Me.Width)
            Me.Top = (modMain.ScreenHeight - Me.Height)
            Me.Text = modMain.CurrentUser
            Me.Show
            Me.TopMost = True
        End Sub

        <DebuggerStepThrough> _
        Private Sub InitializeComponent()
            Me.components = New Container
            Dim manager As New ComponentResourceManager(GetType(frmIconChange))
            Me.tmr = New Timer(Me.components)
            Me.pic = New PictureBox
            Me.cmdSelect = New Button
            Me.GroupBox1 = New GroupBox
            Me.optWindows = New RadioButton
            Me.optSystray = New RadioButton
            Me.grpSize = New GroupBox
            Me.Label2 = New Label
            Me.cboWinImage = New ComboBox
            Me.Label1 = New Label
            Me.cboMenuImage = New ComboBox
            Me.lv = New ListView
            Me.lst = New EnterListBox
            Me.IL = New ImageList(Me.components)
            DirectCast(Me.pic, ISupportInitialize).BeginInit
            Me.GroupBox1.SuspendLayout
            Me.grpSize.SuspendLayout
            Me.SuspendLayout
            Me.tmr.Enabled = True
            Me.pic.Anchor = (AnchorStyles.Right Or (AnchorStyles.Left Or (AnchorStyles.Bottom Or AnchorStyles.Top)))
            Dim point As New Point(&HB8, 12)
            Me.pic.Location = point
            Me.pic.Name = "pic"
            Dim size As New Size(&H80, &H80)
            Me.pic.Size = size
            Me.pic.SizeMode = PictureBoxSizeMode.CenterImage
            Me.pic.TabIndex = 1
            Me.pic.TabStop = False
            point = New Point(&HB9, &H97)
            Me.cmdSelect.Location = point
            Me.cmdSelect.Name = "cmdSelect"
            size = New Size(&H80, &H51)
            Me.cmdSelect.Size = size
            Me.cmdSelect.TabIndex = 2
            Me.cmdSelect.Text = "Select"
            Me.cmdSelect.UseVisualStyleBackColor = True
            Me.GroupBox1.Controls.Add(Me.optWindows)
            Me.GroupBox1.Controls.Add(Me.optSystray)
            point = New Point(&H14E, 14)
            Me.GroupBox1.Location = point
            Me.GroupBox1.Name = "GroupBox1"
            size = New Size(&HB7, &H56)
            Me.GroupBox1.Size = size
            Me.GroupBox1.TabIndex = 4
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Running Location"
            Me.optWindows.AutoSize = True
            point = New Point(14, 60)
            Me.optWindows.Location = point
            Me.optWindows.Name = "optWindows"
            size = New Size(&H41, &H11)
            Me.optWindows.Size = size
            Me.optWindows.TabIndex = 1
            Me.optWindows.TabStop = True
            Me.optWindows.Text = "Desktop"
            Me.optWindows.UseVisualStyleBackColor = True
            Me.optSystray.AutoSize = True
            point = New Point(13, &H21)
            Me.optSystray.Location = point
            Me.optSystray.Name = "optSystray"
            size = New Size(&H53, &H11)
            Me.optSystray.Size = size
            Me.optSystray.TabIndex = 0
            Me.optSystray.TabStop = True
            Me.optSystray.Text = "System Tray"
            Me.optSystray.UseVisualStyleBackColor = True
            Me.grpSize.Controls.Add(Me.Label2)
            Me.grpSize.Controls.Add(Me.cboWinImage)
            Me.grpSize.Controls.Add(Me.Label1)
            Me.grpSize.Controls.Add(Me.cboMenuImage)
            point = New Point(&H14E, &H6F)
            Me.grpSize.Location = point
            Me.grpSize.Name = "grpSize"
            size = New Size(&HB7, 120)
            Me.grpSize.Size = size
            Me.grpSize.TabIndex = 5
            Me.grpSize.TabStop = False
            Me.grpSize.Text = "Image Size Preference"
            Me.Label2.AutoSize = True
            point = New Point(&H11, &H4A)
            Me.Label2.Location = point
            Me.Label2.Name = "Label2"
            size = New Size(&H54, 13)
            Me.Label2.Size = size
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "User Image Size"
            Me.cboWinImage.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboWinImage.FormattingEnabled = True
            point = New Point(14, &H5E)
            Me.cboWinImage.Location = point
            Me.cboWinImage.Name = "cboWinImage"
            size = New Size(&H5C, &H15)
            Me.cboWinImage.Size = size
            Me.cboWinImage.TabIndex = 2
            Me.Label1.AutoSize = True
            point = New Point(15, &H1B)
            Me.Label1.Location = point
            Me.Label1.Name = "Label1"
            size = New Size(&H59, 13)
            Me.Label1.Size = size
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Menu Image Size"
            Me.cboMenuImage.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cboMenuImage.FormattingEnabled = True
            point = New Point(12, &H2F)
            Me.cboMenuImage.Location = point
            Me.cboMenuImage.Name = "cboMenuImage"
            size = New Size(&H5C, &H15)
            Me.cboMenuImage.Size = size
            Me.cboMenuImage.TabIndex = 0
            Me.lv.AutoArrange = False
            Me.lv.BackColor = SystemColors.Window
            Me.lv.LargeImageList = Me.IL
            point = New Point(12, &H13)
            Me.lv.Location = point
            Me.lv.Name = "lv"
            size = New Size(&H97, &HD5)
            Me.lv.Size = size
            Me.lv.SmallImageList = Me.IL
            Me.lv.StateImageList = Me.IL
            Me.lv.TabIndex = 6
            Me.lv.UseCompatibleStateImageBehavior = False
            Me.lv.View = View.SmallIcon
            Me.lv.Visible = False
            Me.lst.BackColor = SystemColors.ControlLight
            Me.lst.FormattingEnabled = True
            point = New Point(12, &H13)
            Me.lst.Location = point
            Me.lst.Name = "lst"
            size = New Size(&H97, &HD4)
            Me.lst.Size = size
            Me.lst.TabIndex = 3
            Me.IL.ColorDepth = ColorDepth.Depth32Bit
            size = New Size(&H20, &H20)
            Me.IL.ImageSize = size
            Me.IL.TransparentColor = Color.Transparent
            Dim ef As New SizeF(6!, 13!)
            Me.AutoScaleDimensions = ef
            Me.AutoScaleMode = AutoScaleMode.Font
            size = New Size(&H20D, &HFB)
            Me.ClientSize = size
            Me.ControlBox = False
            Me.Controls.Add(Me.lv)
            Me.Controls.Add(Me.grpSize)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.lst)
            Me.Controls.Add(Me.cmdSelect)
            Me.Controls.Add(Me.pic)
            Me.FormBorderStyle = FormBorderStyle.Fixed3D
            Me.Icon = DirectCast(manager.GetObject("$this.Icon"), Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "frmIconChange"
            Me.ShowInTaskbar = False
            Me.Text = "frmIconChange"
            Me.TransparencyKey = Color.LightPink
            DirectCast(Me.pic, ISupportInitialize).EndInit
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout
            Me.grpSize.ResumeLayout(False)
            Me.grpSize.PerformLayout
            Me.ResumeLayout(False)
        End Sub

        Private Sub lst_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.subSaveIconPreference
        End Sub

        Private Sub lst_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If (e.KeyCode = Keys.Enter) Then
                e.Handled = True
                Me.subSaveIconPreference
            End If
        End Sub

        Private Sub lst_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.pic.Image = modMain.ObjImg(Me.lst.SelectedIndex)
        End Sub

        Private Sub lv_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Friend Sub subloadCombos()
            Dim cboMenuImage As ComboBox = Me.cboMenuImage
            cboMenuImage.Items.Add("10")
            cboMenuImage.Items.Add("12")
            cboMenuImage.Items.Add("14")
            cboMenuImage.Items.Add("16")
            cboMenuImage.Items.Add("18")
            cboMenuImage.Items.Add("20")
            cboMenuImage.Items.Add("22")
            cboMenuImage.Items.Add("24")
            cboMenuImage.Items.Add("26")
            cboMenuImage.Items.Add("28")
            cboMenuImage.Items.Add("30")
            cboMenuImage.Items.Add("32")
            cboMenuImage.Items.Add("34")
            cboMenuImage.Items.Add("36")
            cboMenuImage.Items.Add("38")
            cboMenuImage.Items.Add("40")
            cboMenuImage.Items.Add("42")
            cboMenuImage.Items.Add("44")
            cboMenuImage.Items.Add("46")
            cboMenuImage.Items.Add("48")
            cboMenuImage.Items.Add("50")
            cboMenuImage.Items.Add("52")
            cboMenuImage.Items.Add("54")
            cboMenuImage.Items.Add("56")
            cboMenuImage.Items.Add("58")
            cboMenuImage.Items.Add("60")
            cboMenuImage.Items.Add("62")
            cboMenuImage.Items.Add("64")
            cboMenuImage.Items.Add("66")
            cboMenuImage.Items.Add("68")
            cboMenuImage.Items.Add("70")
            cboMenuImage.Items.Add("72")
            cboMenuImage.Items.Add("74")
            cboMenuImage.Items.Add("76")
            cboMenuImage.Items.Add("78")
            cboMenuImage.Items.Add("80")
            cboMenuImage.Items.Add("82")
            cboMenuImage.Items.Add("84")
            cboMenuImage.Items.Add("86")
            cboMenuImage.Items.Add("88")
            cboMenuImage.Items.Add("90")
            cboMenuImage.Items.Add("92")
            cboMenuImage.Items.Add("94")
            cboMenuImage.Items.Add("96")
            cboMenuImage.Items.Add("98")
            cboMenuImage.Items.Add("100")
            cboMenuImage.Items.Add("102")
            cboMenuImage.Items.Add("104")
            cboMenuImage.Items.Add("106")
            cboMenuImage.Items.Add("108")
            cboMenuImage.Items.Add("110")
            cboMenuImage.Items.Add("112")
            cboMenuImage.Items.Add("114")
            cboMenuImage.Items.Add("116")
            cboMenuImage.Items.Add("118")
            cboMenuImage.Items.Add("120")
            cboMenuImage.Items.Add("122")
            cboMenuImage.Items.Add("124")
            cboMenuImage.Items.Add("126")
            cboMenuImage.Items.Add("128")
            cboMenuImage = Nothing
            Dim cboWinImage As ComboBox = Me.cboWinImage
            cboWinImage.Items.Add("20")
            cboWinImage.Items.Add("22")
            cboWinImage.Items.Add("24")
            cboWinImage.Items.Add("26")
            cboWinImage.Items.Add("28")
            cboWinImage.Items.Add("30")
            cboWinImage.Items.Add("32")
            cboWinImage.Items.Add("34")
            cboWinImage.Items.Add("36")
            cboWinImage.Items.Add("38")
            cboWinImage.Items.Add("40")
            cboWinImage.Items.Add("42")
            cboWinImage.Items.Add("44")
            cboWinImage.Items.Add("46")
            cboWinImage.Items.Add("48")
            cboWinImage.Items.Add("50")
            cboWinImage.Items.Add("52")
            cboWinImage.Items.Add("54")
            cboWinImage.Items.Add("56")
            cboWinImage.Items.Add("58")
            cboWinImage.Items.Add("60")
            cboWinImage.Items.Add("62")
            cboWinImage.Items.Add("64")
            cboWinImage.Items.Add("66")
            cboWinImage.Items.Add("68")
            cboWinImage.Items.Add("70")
            cboWinImage.Items.Add("72")
            cboWinImage.Items.Add("74")
            cboWinImage.Items.Add("76")
            cboWinImage.Items.Add("78")
            cboWinImage.Items.Add("80")
            cboWinImage.Items.Add("82")
            cboWinImage.Items.Add("84")
            cboWinImage.Items.Add("86")
            cboWinImage.Items.Add("88")
            cboWinImage.Items.Add("90")
            cboWinImage.Items.Add("92")
            cboWinImage.Items.Add("94")
            cboWinImage.Items.Add("96")
            cboWinImage.Items.Add("98")
            cboWinImage.Items.Add("100")
            cboWinImage.Items.Add("102")
            cboWinImage.Items.Add("104")
            cboWinImage.Items.Add("106")
            cboWinImage.Items.Add("108")
            cboWinImage.Items.Add("110")
            cboWinImage.Items.Add("112")
            cboWinImage.Items.Add("114")
            cboWinImage.Items.Add("116")
            cboWinImage.Items.Add("118")
            cboWinImage.Items.Add("120")
            cboWinImage.Items.Add("122")
            cboWinImage.Items.Add("124")
            cboWinImage.Items.Add("126")
            cboWinImage.Items.Add("128")
            cboWinImage = Nothing
            Me.cboMenuImage.SelectedItem = MySettingsProperty.Settings.intMenuImageSize.ToString
            Me.cboWinImage.SelectedItem = MySettingsProperty.Settings.intWinImageSize.ToString
        End Sub

        Friend Sub subLoadFileTypeArrays()
            modMain.arrayStrFileTypes(0) = "Unknownxxx"
            modMain.arrayImgFileTypes(0) = Resources.imgUnkFile
            modMain.arrayStrFileTypes(1) = ".html"
            modMain.arrayImgFileTypes(1) = Resources.imgHtmlFile
            modMain.arrayStrFileTypes(2) = ".htm"
            modMain.arrayImgFileTypes(2) = Resources.imgHtmlFile
            modMain.arrayStrFileTypes(3) = ".js"
            modMain.arrayImgFileTypes(3) = Resources.imgJsFile
            modMain.arrayStrFileTypes(4) = ".bat"
            modMain.arrayImgFileTypes(4) = Resources.imgBatFile
            modMain.arrayStrFileTypes(5) = ".msc"
            modMain.arrayImgFileTypes(5) = Resources.imgMSCFile
            modMain.arrayStrFileTypes(6) = ".sln"
            modMain.arrayImgFileTypes(6) = Resources.imgVS
            modMain.arrayStrFileTypes(7) = ".txt"
            modMain.arrayImgFileTypes(7) = Resources.imgTxtFile
            modMain.arrayStrFileTypes(8) = ".zip"
            modMain.arrayImgFileTypes(8) = Resources.imgZipFile
            modMain.arrayStrFileTypes(9) = ".exe"
            modMain.arrayImgFileTypes(9) = Resources.imgapp
            modMain.arrayStrFileTypes(10) = ".vbs"
            modMain.arrayImgFileTypes(10) = Resources.imgVBSFile
            modMain.arrayStrFileTypes(11) = ".csv"
            modMain.arrayImgFileTypes(11) = Resources.imgTxtFile
            modMain.arrayStrFileTypes(12) = ".rdp"
            modMain.arrayImgFileTypes(12) = Resources.imgRDP
            modMain.arrayStrFileTypes(&H2D) = "NetFolder IMage #45"
            modMain.arrayImgFileTypes(&H2D) = Resources.imgServer
            modMain.arrayStrFileTypes(&H2E) = "NetFolder IMage #46"
            modMain.arrayImgFileTypes(&H2E) = Resources.imgapp
            modMain.arrayStrFileTypes(&H2F) = "NetFolder IMage #47"
            modMain.arrayImgFileTypes(&H2F) = Resources.imgNetFolder
            modMain.arrayStrFileTypes(&H30) = "Folders Regular #48"
            modMain.arrayImgFileTypes(&H30) = Resources.imgFolder
            modMain.arrayStrFileTypes(&H31) = "Commands #49"
            modMain.arrayImgFileTypes(&H31) = Resources.imgCmd
            modMain.arrayStrFileTypes(50) = "dreamweaver.exe"
            modMain.arrayImgFileTypes(50) = Resources.imgDW
            modMain.arrayStrFileTypes(&H33) = "iexplore.exe"
            modMain.arrayImgFileTypes(&H33) = Resources.imgIE6
            modMain.arrayStrFileTypes(&H34) = "ipscan.exe"
            modMain.arrayImgFileTypes(&H34) = Resources.imgAngryIP
            modMain.arrayStrFileTypes(&H35) = "mstsc"
            modMain.arrayImgFileTypes(&H35) = Resources.imgRDP
            modMain.arrayStrFileTypes(&H36) = "iexpl"
            modMain.arrayImgFileTypes(&H36) = Resources.imgIE6
        End Sub

        Friend Sub subLoadIcons()
            Me.lst.Items.Clear
            Me.lv.Items.Clear
            Me.IL.Images.Clear
            modMain.ObjImg(0) = Resources.XPPPL01_ico
            modMain.ObjIcon(0) = Resources.XPPPL01
            Me.IL.Images.Add(modMain.ObjIcon(0))
            Me.lv.Items.Add("", 0)
            Me.lst.Items.Add("XPPPL01")
            modMain.ObjImg(1) = Resources.XPPPL02_ico
            modMain.ObjIcon(1) = Resources.XPPPL02
            Me.IL.Images.Add(modMain.ObjIcon(1))
            Me.lv.Items.Add("", 1)
            Me.lst.Items.Add("XPPPL02")
            modMain.ObjImg(2) = Resources.XPPPL03_ico
            modMain.ObjIcon(2) = Resources.XPPPL03
            Me.IL.Images.Add(modMain.ObjIcon(2))
            Me.lv.Items.Add("", 2)
            Me.lst.Items.Add("XPPPL03")
            modMain.ObjImg(3) = Resources.XPPPL04_ico
            modMain.ObjIcon(3) = Resources.XPPPL04
            Me.IL.Images.Add(modMain.ObjIcon(3))
            Me.lv.Items.Add("", 3)
            Me.lst.Items.Add("XPPPL04")
            modMain.ObjImg(4) = Resources.XPPPL05_ico
            modMain.ObjIcon(4) = Resources.XPPPL05
            Me.IL.Images.Add(modMain.ObjIcon(4))
            Me.lv.Items.Add("", 4)
            Me.lst.Items.Add("XPPPL05")
            modMain.ObjImg(5) = Resources.XPPPL06_ico
            modMain.ObjIcon(5) = Resources.XPPPL06
            Me.IL.Images.Add(modMain.ObjIcon(5))
            Me.lv.Items.Add("", 5)
            Me.lst.Items.Add("XPPPL06")
            modMain.ObjImg(6) = Resources.XPPPL07_ico
            modMain.ObjIcon(6) = Resources.XPPPL07
            Me.IL.Images.Add(modMain.ObjIcon(6))
            Me.lv.Items.Add("", 6)
            Me.lst.Items.Add("XPPPL07")
            modMain.ObjImg(7) = Resources.XPPPL08_ico
            modMain.ObjIcon(7) = Resources.XPPPL08
            Me.IL.Images.Add(modMain.ObjIcon(7))
            Me.lv.Items.Add("", 7)
            Me.lst.Items.Add("XPPPL08")
            modMain.ObjImg(8) = Resources.XPPPL09_ico
            modMain.ObjIcon(8) = Resources.XPPPL09
            Me.IL.Images.Add(modMain.ObjIcon(8))
            Me.lv.Items.Add("", 8)
            Me.lst.Items.Add("XPPPL09")
            modMain.ObjImg(9) = Resources.XPPPL10_ico
            modMain.ObjIcon(9) = Resources.XPPPL10
            Me.IL.Images.Add(modMain.ObjIcon(9))
            Me.lv.Items.Add("", 9)
            Me.lst.Items.Add("XPPPL10")
            modMain.ObjImg(10) = Resources.XPPPL11_ico
            modMain.ObjIcon(10) = Resources.XPPPL11
            Me.IL.Images.Add(modMain.ObjIcon(10))
            Me.lv.Items.Add("", 10)
            Me.lst.Items.Add("XPPPL11")
            modMain.ObjImg(11) = Resources.XPPPL12_ico
            modMain.ObjIcon(11) = Resources.XPPPL12
            Me.IL.Images.Add(modMain.ObjIcon(11))
            Me.lv.Items.Add("", 11)
            Me.lst.Items.Add("XPPPL12")
            modMain.ObjImg(12) = Resources.XPPPL13_ico
            modMain.ObjIcon(12) = Resources.XPPPL13
            Me.IL.Images.Add(modMain.ObjIcon(12))
            Me.lv.Items.Add("", 12)
            Me.lst.Items.Add("XPPPL13")
            modMain.ObjImg(13) = Resources.XPPPL14_ico
            modMain.ObjIcon(13) = Resources.XPPPL14
            Me.IL.Images.Add(modMain.ObjIcon(13))
            Me.lv.Items.Add("", 13)
            Me.lst.Items.Add("XPPPL14")
            modMain.ObjImg(14) = Resources.XPPPL15_ico
            modMain.ObjIcon(14) = Resources.XPPPL15
            Me.IL.Images.Add(modMain.ObjIcon(14))
            Me.lv.Items.Add("", 14)
            Me.lst.Items.Add("XPPPL15")
            modMain.ObjImg(15) = Resources.XPPPL16_ico
            modMain.ObjIcon(15) = Resources.XPPPL16
            Me.IL.Images.Add(modMain.ObjIcon(15))
            Me.lv.Items.Add("", 15)
            Me.lst.Items.Add("Alter Ego Default")
            modMain.ObjImg(&H10) = Resources.XPPPL17_ico
            modMain.ObjIcon(&H10) = Resources.XPPPL17
            Me.IL.Images.Add(modMain.ObjIcon(&H10))
            Me.lv.Items.Add("", &H10)
            Me.lst.Items.Add("XPPPL17")
            modMain.ObjImg(&H11) = Resources.XPPPL18_ico
            modMain.ObjIcon(&H11) = Resources.XPPPL18
            Me.IL.Images.Add(modMain.ObjIcon(&H11))
            Me.lv.Items.Add("", &H11)
            Me.lst.Items.Add("XPPPL18")
            modMain.ObjImg(&H12) = Resources.XPPPL19_ico
            modMain.ObjIcon(&H12) = Resources.XPPPL19
            Me.IL.Images.Add(modMain.ObjIcon(&H12))
            Me.lv.Items.Add("", &H12)
            Me.lst.Items.Add("XPPPL19")
            modMain.ObjImg(&H13) = Resources.XPPPL20_ico
            modMain.ObjIcon(&H13) = Resources.XPPPL20
            Me.IL.Images.Add(modMain.ObjIcon(&H13))
            Me.lv.Items.Add("", &H13)
            Me.lst.Items.Add("XPPPL20")
            modMain.ObjImg(20) = Resources.imgAEStartClassic
            modMain.ObjIcon(20) = Resources.XPPPL16
            Me.IL.Images.Add(modMain.ObjIcon(20))
            Me.lv.Items.Add("", 20)
            Me.lst.Items.Add("Alter Ego Classic Start Bar")
            modMain.ObjImg(&H15) = Resources.imgAEStartXP2
            modMain.ObjIcon(&H15) = Resources.XPPPL16
            Me.IL.Images.Add(modMain.ObjIcon(&H15))
            Me.lv.Items.Add("", &H15)
            Me.lst.Items.Add("Alter Ego XP Start Bar")
        End Sub

        Friend Sub subSaveIconPreference()
            modMain.UserIcon = Me.lst.SelectedIndex
            If Not modMain.Registered Then
                modMain.UserIcon = 15
            End If
            Me.Hide
            If Me.optSystray.Checked Then
                MySettingsProperty.Settings.intStatupLocation = 0
                Dim mobNotifyIcon As NotifyIcon = modMain.mobNotifyIcon
                mobNotifyIcon.Icon = modMain.ObjIcon(modMain.UserIcon)
                mobNotifyIcon.ContextMenuStrip = MyProject.Forms.frmTreeMenu.assMenu
                mobNotifyIcon.Visible = True
                mobNotifyIcon = Nothing
                MyProject.Forms.frmCool.Hide
            Else
                MySettingsProperty.Settings.intStatupLocation = 1
                MyProject.Forms.frmCool.picBox.Image = modMain.ObjImg(modMain.UserIcon)
                MyProject.Forms.frmCool.subrefreshfrmCool
                modMain.mobNotifyIcon.Visible = False
                MyProject.Forms.frmCool.subrefreshfrmCool
            End If
            MySettingsProperty.Settings.intMenuImageSize = Convert.ToInt32(Me.cboMenuImage.Text)
            MySettingsProperty.Settings.intWinImageSize = Convert.ToInt32(Me.cboWinImage.Text)
            modFileSettingsandArray.SaveSettings
            modFileSettingsandArray.LoadSettings
            modMain.statupLocationSetting
            If (modMain.UserIcon > &H13) Then
                MyProject.Forms.frmTreeMenu.tsiUserMenu.Image = modMain.ObjImg(15)
            Else
                MyProject.Forms.frmTreeMenu.tsiUserMenu.Image = modMain.ObjImg(modMain.UserIcon)
            End If
            MyProject.Forms.frmTreeMenu.subFormLoadRefresh
        End Sub

        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If (Me.lst.SelectedIndex > &H13) Then
                Me.optWindows.Checked = True
                Me.optSystray.Enabled = False
            Else
                Me.optSystray.Enabled = True
            End If
            If Me.optWindows.Checked Then
                Me.cboWinImage.Enabled = True
            Else
                Me.cboWinImage.Enabled = False
            End If
        End Sub


        ' Properties
        Friend Overridable Property cboMenuImage As ComboBox
            Get
                Return Me._cboMenuImage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._cboMenuImage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cboWinImage As ComboBox
            Get
                Return Me._cboWinImage
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ComboBox)
                Me._cboWinImage = WithEventsValue
            End Set
        End Property

        Friend Overridable Property cmdSelect As Button
            Get
                Return Me._cmdSelect
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Button)
                If (Not Me._cmdSelect Is Nothing) Then
                    RemoveHandler Me._cmdSelect.Click, New EventHandler(AddressOf Me.cmdSelect_Click)
                End If
                Me._cmdSelect = WithEventsValue
                If (Not Me._cmdSelect Is Nothing) Then
                    AddHandler Me._cmdSelect.Click, New EventHandler(AddressOf Me.cmdSelect_Click)
                End If
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

        Friend Overridable Property grpSize As GroupBox
            Get
                Return Me._grpSize
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As GroupBox)
                Me._grpSize = WithEventsValue
            End Set
        End Property

        Friend Overridable Property IL As ImageList
            Get
                Return Me._IL
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ImageList)
                Me._IL = WithEventsValue
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

        Friend Overridable Property lst As EnterListBox
            Get
                Return Me._lst
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As EnterListBox)
                If (Not Me._lst Is Nothing) Then
                    RemoveHandler Me._lst.SelectedIndexChanged, New EventHandler(AddressOf Me.lst_SelectedIndexChanged)
                    RemoveHandler Me._lst.KeyDown, New KeyEventHandler(AddressOf Me.lst_KeyDown)
                    RemoveHandler Me._lst.DoubleClick, New EventHandler(AddressOf Me.lst_DoubleClick)
                End If
                Me._lst = WithEventsValue
                If (Not Me._lst Is Nothing) Then
                    AddHandler Me._lst.SelectedIndexChanged, New EventHandler(AddressOf Me.lst_SelectedIndexChanged)
                    AddHandler Me._lst.KeyDown, New KeyEventHandler(AddressOf Me.lst_KeyDown)
                    AddHandler Me._lst.DoubleClick, New EventHandler(AddressOf Me.lst_DoubleClick)
                End If
            End Set
        End Property

        Friend Overridable Property lv As ListView
            Get
                Return Me._lv
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As ListView)
                If (Not Me._lv Is Nothing) Then
                    RemoveHandler Me._lv.SelectedIndexChanged, New EventHandler(AddressOf Me.lv_SelectedIndexChanged)
                End If
                Me._lv = WithEventsValue
                If (Not Me._lv Is Nothing) Then
                    AddHandler Me._lv.SelectedIndexChanged, New EventHandler(AddressOf Me.lv_SelectedIndexChanged)
                End If
            End Set
        End Property

        Friend Overridable Property optSystray As RadioButton
            Get
                Return Me._optSystray
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._optSystray = WithEventsValue
            End Set
        End Property

        Friend Overridable Property optWindows As RadioButton
            Get
                Return Me._optWindows
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As RadioButton)
                Me._optWindows = WithEventsValue
            End Set
        End Property

        Friend Overridable Property pic As PictureBox
            Get
                Return Me._pic
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As PictureBox)
                Me._pic = WithEventsValue
            End Set
        End Property

        Friend Overridable Property tmr As Timer
            Get
                Return Me._tmr
            End Get
            <MethodImpl(MethodImplOptions.Synchronized)> _
            Set(ByVal WithEventsValue As Timer)
                If (Not Me._tmr Is Nothing) Then
                    RemoveHandler Me._tmr.Tick, New EventHandler(AddressOf Me.tmr_Tick)
                End If
                Me._tmr = WithEventsValue
                If (Not Me._tmr Is Nothing) Then
                    AddHandler Me._tmr.Tick, New EventHandler(AddressOf Me.tmr_Tick)
                End If
            End Set
        End Property


        ' Fields
        <AccessedThroughProperty("cboMenuImage")> _
        Private _cboMenuImage As ComboBox
        <AccessedThroughProperty("cboWinImage")> _
        Private _cboWinImage As ComboBox
        <AccessedThroughProperty("cmdSelect")> _
        Private _cmdSelect As Button
        <AccessedThroughProperty("GroupBox1")> _
        Private _GroupBox1 As GroupBox
        <AccessedThroughProperty("grpSize")> _
        Private _grpSize As GroupBox
        <AccessedThroughProperty("IL")> _
        Private _IL As ImageList
        <AccessedThroughProperty("Label1")> _
        Private _Label1 As Label
        <AccessedThroughProperty("Label2")> _
        Private _Label2 As Label
        <AccessedThroughProperty("lst")> _
        Private _lst As EnterListBox
        <AccessedThroughProperty("lv")> _
        Private _lv As ListView
        <AccessedThroughProperty("optSystray")> _
        Private _optSystray As RadioButton
        <AccessedThroughProperty("optWindows")> _
        Private _optWindows As RadioButton
        <AccessedThroughProperty("pic")> _
        Private _pic As PictureBox
        <AccessedThroughProperty("tmr")> _
        Private _tmr As Timer
        Private components As IContainer
    End Class
End Namespace

