<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KirimPOInt
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KirimPOInt))
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.DTTanggal = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListPOPrd = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListPODsn = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEditPO = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnKembaliRev = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnLanjutRevisi = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnKeluarPO = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSimpanPO = New DevExpress.XtraEditors.SimpleButton()
        Me.TidPO = New System.Windows.Forms.TextBox()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BtnProsesPO = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnKirimPO = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExit = New DevExpress.XtraBars.BarButtonItem()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListDO = New System.Windows.Forms.ListView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RbAda = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelAlasan = New System.Windows.Forms.GroupBox()
        Me.BatalRevisi = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAlasan = New DevExpress.XtraEditors.SimpleButton()
        Me.TAlasan = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer2.Panel1.SuspendLayout
        Me.SplitContainer2.Panel2.SuspendLayout
        Me.SplitContainer2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.barManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.PanelAlasan.SuspendLayout
        Me.SuspendLayout
        '
        'bar2
        '
        Me.bar2.BarItemVertIndent = 9
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.OptionsBar.AllowQuickCustomization = false
        Me.bar2.OptionsBar.DrawBorder = false
        Me.bar2.OptionsBar.MultiLine = true
        Me.bar2.OptionsBar.UseWholeRow = true
        Me.bar2.Text = "Main menu"
        '
        'DTTanggal
        '
        Me.DTTanggal.Enabled = false
        Me.DTTanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DTTanggal.Location = New System.Drawing.Point(524, 5)
        Me.DTTanggal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTTanggal.Name = "DTTanggal"
        Me.DTTanggal.Size = New System.Drawing.Size(179, 23)
        Me.DTTanggal.TabIndex = 124
        Me.DTTanggal.Visible = false
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1315, 345)
        Me.SplitContainer2.SplitterDistance = 181
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListPOPrd)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1315, 181)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "PO. Produksi"
        '
        'ListPOPrd
        '
        Me.ListPOPrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPOPrd.HideSelection = false
        Me.ListPOPrd.Location = New System.Drawing.Point(4, 25)
        Me.ListPOPrd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListPOPrd.Name = "ListPOPrd"
        Me.ListPOPrd.Size = New System.Drawing.Size(1307, 151)
        Me.ListPOPrd.TabIndex = 1
        Me.ListPOPrd.UseCompatibleStateImageBehavior = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListPODsn)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1315, 158)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "PO. Detail"
        '
        'ListPODsn
        '
        Me.ListPODsn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPODsn.HideSelection = false
        Me.ListPODsn.Location = New System.Drawing.Point(4, 25)
        Me.ListPODsn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListPODsn.Name = "ListPODsn"
        Me.ListPODsn.Size = New System.Drawing.Size(1307, 128)
        Me.ListPODsn.TabIndex = 1
        Me.ListPODsn.UseCompatibleStateImageBehavior = false
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PanelEditPO)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(131, 86)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 360)
        Me.Panel1.TabIndex = 12
        Me.Panel1.Visible = False
        '
        'PanelEditPO
        '
        Me.PanelEditPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEditPO.Location = New System.Drawing.Point(0, 0)
        Me.PanelEditPO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEditPO.Name = "PanelEditPO"
        Me.PanelEditPO.Size = New System.Drawing.Size(1079, 293)
        Me.PanelEditPO.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnKembaliRev)
        Me.Panel2.Controls.Add(Me.BtnLanjutRevisi)
        Me.Panel2.Controls.Add(Me.BtnKeluarPO)
        Me.Panel2.Controls.Add(Me.BtnSimpanPO)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 293)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1079, 63)
        Me.Panel2.TabIndex = 0
        '
        'BtnKembaliRev
        '
        Me.BtnKembaliRev.ImageOptions.SvgImage = CType(resources.GetObject("BtnKembaliRev.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnKembaliRev.Location = New System.Drawing.Point(17, 9)
        Me.BtnKembaliRev.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKembaliRev.Name = "BtnKembaliRev"
        Me.BtnKembaliRev.Size = New System.Drawing.Size(128, 45)
        Me.BtnKembaliRev.TabIndex = 3
        Me.BtnKembaliRev.Text = "KEMBALI"
        Me.BtnKembaliRev.Visible = False
        '
        'BtnLanjutRevisi
        '
        Me.BtnLanjutRevisi.ImageOptions.SvgImage = CType(resources.GetObject("BtnLanjutRevisi.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnLanjutRevisi.Location = New System.Drawing.Point(932, 5)
        Me.BtnLanjutRevisi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLanjutRevisi.Name = "BtnLanjutRevisi"
        Me.BtnLanjutRevisi.Size = New System.Drawing.Size(128, 45)
        Me.BtnLanjutRevisi.TabIndex = 2
        Me.BtnLanjutRevisi.Text = "LANJUT"
        Me.BtnLanjutRevisi.Visible = False
        '
        'BtnKeluarPO
        '
        Me.BtnKeluarPO.ImageOptions.Image = CType(resources.GetObject("BtnKeluarPO.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnKeluarPO.Location = New System.Drawing.Point(644, 6)
        Me.BtnKeluarPO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKeluarPO.Name = "BtnKeluarPO"
        Me.BtnKeluarPO.Size = New System.Drawing.Size(116, 48)
        Me.BtnKeluarPO.TabIndex = 1
        Me.BtnKeluarPO.Text = "KELUAR"
        '
        'BtnSimpanPO
        '
        Me.BtnSimpanPO.ImageOptions.Image = CType(resources.GetObject("BtnSimpanPO.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSimpanPO.Location = New System.Drawing.Point(775, 6)
        Me.BtnSimpanPO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpanPO.Name = "BtnSimpanPO"
        Me.BtnSimpanPO.Size = New System.Drawing.Size(128, 45)
        Me.BtnSimpanPO.TabIndex = 0
        Me.BtnSimpanPO.Text = "SIMPAN"
        '
        'TidPO
        '
        Me.TidPO.Location = New System.Drawing.Point(740, 8)
        Me.TidPO.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TidPO.Name = "TidPO"
        Me.TidPO.Size = New System.Drawing.Size(40, 27)
        Me.TidPO.TabIndex = 125
        Me.TidPO.Visible = False
        '
        'Bar1
        '
        Me.Bar1.BarItemVertIndent = 9
        Me.Bar1.BarName = "Main menu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnProsesPO), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnRefresh), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnKirimPO), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnExit)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Main menu"
        '
        'BtnProsesPO
        '
        Me.BtnProsesPO.Caption = "PROSES PO"
        Me.BtnProsesPO.Id = 0
        Me.BtnProsesPO.ImageOptions.Image = CType(resources.GetObject("BtnProsesPO.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnProsesPO.ImageOptions.LargeImage = CType(resources.GetObject("BtnProsesPO.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnProsesPO.Name = "BtnProsesPO"
        Me.BtnProsesPO.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Caption = "REFRESH"
        Me.BtnRefresh.Id = 1
        Me.BtnRefresh.ImageOptions.Image = CType(resources.GetObject("BtnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnRefresh.ImageOptions.LargeImage = CType(resources.GetObject("BtnRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnKirimPO
        '
        Me.BtnKirimPO.Caption = "KIRIM PO"
        Me.BtnKirimPO.Id = 2
        Me.BtnKirimPO.ImageOptions.Image = CType(resources.GetObject("BtnKirimPO.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnKirimPO.ImageOptions.LargeImage = CType(resources.GetObject("BtnKirimPO.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnKirimPO.Name = "BtnKirimPO"
        Me.BtnKirimPO.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnEdit
        '
        Me.BtnEdit.Caption = "REVISI"
        Me.BtnEdit.Id = 3
        Me.BtnEdit.ImageOptions.Image = CType(resources.GetObject("BtnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageOptions.LargeImage = CType(resources.GetObject("BtnEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BtnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BtnPrint
        '
        Me.BtnPrint.Caption = "CETAK"
        Me.BtnPrint.Id = 5
        Me.BtnPrint.ImageOptions.Image = CType(resources.GetObject("BtnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageOptions.LargeImage = CType(resources.GetObject("BtnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnExit
        '
        Me.BtnExit.Caption = "KELUAR"
        Me.BtnExit.Id = 4
        Me.BtnExit.ImageOptions.Image = CType(resources.GetObject("BtnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnExit.ImageOptions.LargeImage = CType(resources.GetObject("BtnExit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BtnProsesPO, Me.BtnRefresh, Me.BtnKirimPO, Me.BtnEdit, Me.BtnExit, Me.BtnPrint})
        Me.barManager1.MainMenu = Me.Bar1
        Me.barManager1.MaxItemId = 6
        Me.barManager1.StatusBar = Me.bar3
        '
        'bar3
        '
        Me.bar3.BarName = "Status bar"
        Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3.DockCol = 0
        Me.bar3.DockRow = 0
        Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3.OptionsBar.AllowQuickCustomization = False
        Me.bar3.OptionsBar.DrawDragBorder = False
        Me.bar3.OptionsBar.UseWholeRow = True
        Me.bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlTop.Size = New System.Drawing.Size(1315, 50)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 601)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1315, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 50)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 551)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1315, 50)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 551)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListDO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1315, 551)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 11
        '
        'ListDO
        '
        Me.ListDO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDO.Location = New System.Drawing.Point(0, 40)
        Me.ListDO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListDO.Name = "ListDO"
        Me.ListDO.Size = New System.Drawing.Size(1315, 160)
        Me.ListDO.TabIndex = 6
        Me.ListDO.UseCompatibleStateImageBehavior = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TidPO)
        Me.Panel3.Controls.Add(Me.DTTanggal)
        Me.Panel3.Controls.Add(Me.RbAda)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1315, 40)
        Me.Panel3.TabIndex = 5
        '
        'RbAda
        '
        Me.RbAda.AutoSize = True
        Me.RbAda.Checked = True
        Me.RbAda.Location = New System.Drawing.Point(139, 6)
        Me.RbAda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RbAda.Name = "RbAda"
        Me.RbAda.Size = New System.Drawing.Size(135, 24)
        Me.RbAda.TabIndex = 2
        Me.RbAda.TabStop = True
        Me.RbAda.Text = "SUDAH ADA PE"
        Me.RbAda.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Order"
        '
        'PanelAlasan
        '
        Me.PanelAlasan.BackColor = System.Drawing.Color.Crimson
        Me.PanelAlasan.Controls.Add(Me.BatalRevisi)
        Me.PanelAlasan.Controls.Add(Me.BtnAlasan)
        Me.PanelAlasan.Controls.Add(Me.TAlasan)
        Me.PanelAlasan.Location = New System.Drawing.Point(409, 88)
        Me.PanelAlasan.Name = "PanelAlasan"
        Me.PanelAlasan.Size = New System.Drawing.Size(425, 182)
        Me.PanelAlasan.TabIndex = 1
        Me.PanelAlasan.TabStop = false
        Me.PanelAlasan.Text = "ALASAN REVISI"
        Me.PanelAlasan.Visible = false
        '
        'BatalRevisi
        '
        Me.BatalRevisi.ImageOptions.Image = CType(resources.GetObject("BatalRevisi.ImageOptions.Image"),System.Drawing.Image)
        Me.BatalRevisi.Location = New System.Drawing.Point(177, 126)
        Me.BatalRevisi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BatalRevisi.Name = "BatalRevisi"
        Me.BatalRevisi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BatalRevisi.Size = New System.Drawing.Size(101, 41)
        Me.BatalRevisi.TabIndex = 3
        Me.BatalRevisi.Text = "KELUAR"
        '
        'BtnAlasan
        '
        Me.BtnAlasan.ImageOptions.Image = CType(resources.GetObject("BtnAlasan.ImageOptions.Image"),System.Drawing.Image)
        Me.BtnAlasan.Location = New System.Drawing.Point(292, 126)
        Me.BtnAlasan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAlasan.Name = "BtnAlasan"
        Me.BtnAlasan.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnAlasan.Size = New System.Drawing.Size(112, 38)
        Me.BtnAlasan.TabIndex = 2
        Me.BtnAlasan.Text = "SIMPAN"
        '
        'TAlasan
        '
        Me.TAlasan.Location = New System.Drawing.Point(17, 55)
        Me.TAlasan.Name = "TAlasan"
        Me.TAlasan.Size = New System.Drawing.Size(385, 27)
        Me.TAlasan.TabIndex = 0
        '
        'KirimPOInt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelAlasan)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "KirimPOInt"
        Me.Size = New System.Drawing.Size(1315, 623)
        Me.SplitContainer2.Panel1.ResumeLayout(false)
        Me.SplitContainer2.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        CType(Me.barManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.PanelAlasan.ResumeLayout(false)
        Me.PanelAlasan.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents DTTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListPOPrd As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListPODsn As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelEditPO As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnKembaliRev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnLanjutRevisi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnKeluarPO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSimpanPO As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TidPO As System.Windows.Forms.TextBox
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BtnProsesPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnKirimPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnExit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListDO As System.Windows.Forms.ListView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RbAda As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelAlasan As System.Windows.Forms.GroupBox
    Friend WithEvents BatalRevisi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAlasan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TAlasan As System.Windows.Forms.TextBox

End Class
