<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POInternalDesign
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
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POInternalDesign))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BtnEntryDsn = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnEditDsn = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnAccDsn = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRefreshDsn = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnSelesai = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnExitDsn = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCetakPO = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.KirimPrinting = New DevExpress.XtraBars.BarButtonItem()
        Me.KirimCutting = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.RbKirim = New System.Windows.Forms.RadioButton()
        Me.RbTerima = New System.Windows.Forms.RadioButton()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ListDetailPODsn = New System.Windows.Forms.ListView()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.ListPOPrint = New System.Windows.Forms.ListView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ListPOCutting = New System.Windows.Forms.ListView()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridPODsn = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidpo_dsn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnopo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidklien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidkota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeadline_desain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colselesai_desain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeadline_ki = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltime_closhing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkirim_po = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterima_po = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkirim_ppic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colklien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coliddtorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidpo_prd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPO_Produksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TidPE = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TKota = New DevExpress.XtraEditors.TextEdit()
        Me.PanelAlasan = New System.Windows.Forms.GroupBox()
        Me.BtnSimpanAlasan = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnTutupAlasan = New DevExpress.XtraEditors.SimpleButton()
        Me.TAlasan = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TKeterangan = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BtnSimpanDetail = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.idrevisi = New System.Windows.Forms.TextBox()
        Me.TidPOCut = New System.Windows.Forms.TextBox()
        Me.TidPoPrt = New System.Windows.Forms.TextBox()
        Me.TidFinishing = New System.Windows.Forms.TextBox()
        Me.TidDetailpoCut = New System.Windows.Forms.TextBox()
        Me.TidBahan = New System.Windows.Forms.TextBox()
        Me.CBahan = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TidDetailDsn = New System.Windows.Forms.TextBox()
        Me.TFinishing = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TidDetailPoPrt = New System.Windows.Forms.TextBox()
        Me.PanelP = New System.Windows.Forms.Panel()
        Me.Tj2 = New DevExpress.XtraEditors.TextEdit()
        Me.Tp2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Tl2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Tt2 = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PanelC = New System.Windows.Forms.Panel()
        Me.Tp3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Tl3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Tt3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Tj3 = New DevExpress.XtraEditors.TextEdit()
        Me.CSubKerjaan = New System.Windows.Forms.CheckBox()
        Me.CPrinting = New System.Windows.Forms.CheckBox()
        Me.CCutting = New System.Windows.Forms.CheckBox()
        Me.TBarang2 = New System.Windows.Forms.TextBox()
        Me.CMal = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TIdBarang2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TIdBrand = New System.Windows.Forms.TextBox()
        Me.TToko = New DevExpress.XtraEditors.TextEdit()
        Me.TBarang1 = New DevExpress.XtraEditors.TextEdit()
        Me.Tp1 = New DevExpress.XtraEditors.TextEdit()
        Me.TIdToko = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TIdpoprd = New System.Windows.Forms.TextBox()
        Me.Tl1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TIdBarang1 = New System.Windows.Forms.TextBox()
        Me.Tt1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tj1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBrand = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPODsn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TKota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAlasan.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelP.SuspendLayout()
        CType(Me.Tj2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tp2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tl2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tt2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelC.SuspendLayout()
        CType(Me.Tp3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tl3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tt3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tj3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TToko.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBarang1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tp1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tj1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BtnEntryDsn, Me.BtnEditDsn, Me.BtnAccDsn, Me.BtnRefreshDsn, Me.BtnExitDsn, Me.KirimPrinting, Me.KirimCutting, Me.BtnSelesai, Me.BtnCetakPO})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 2"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEntryDsn), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnEditDsn), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnAccDsn), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnRefreshDsn), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnSelesai), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnExitDsn), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnCetakPO)})
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.Text = "Menu Desain"
        '
        'BtnEntryDsn
        '
        Me.BtnEntryDsn.Caption = "ENTRY"
        Me.BtnEntryDsn.Enabled = False
        Me.BtnEntryDsn.Id = 2
        Me.BtnEntryDsn.ImageOptions.Image = CType(resources.GetObject("BtnEntryDsn.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEntryDsn.ImageOptions.LargeImage = CType(resources.GetObject("BtnEntryDsn.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnEntryDsn.Name = "BtnEntryDsn"
        Me.BtnEntryDsn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BtnEntryDsn.Size = New System.Drawing.Size(70, 30)
        '
        'BtnEditDsn
        '
        Me.BtnEditDsn.Caption = "EDIT"
        Me.BtnEditDsn.Enabled = False
        Me.BtnEditDsn.Id = 3
        Me.BtnEditDsn.ImageOptions.Image = CType(resources.GetObject("BtnEditDsn.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEditDsn.ImageOptions.LargeImage = CType(resources.GetObject("BtnEditDsn.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnEditDsn.Name = "BtnEditDsn"
        Me.BtnEditDsn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BtnEditDsn.Size = New System.Drawing.Size(70, 30)
        '
        'BtnAccDsn
        '
        Me.BtnAccDsn.ActAsDropDown = True
        Me.BtnAccDsn.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BtnAccDsn.Caption = "TERIMA PO"
        Me.BtnAccDsn.Enabled = False
        Me.BtnAccDsn.Id = 4
        Me.BtnAccDsn.ImageOptions.Image = CType(resources.GetObject("BtnAccDsn.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAccDsn.ImageOptions.LargeImage = CType(resources.GetObject("BtnAccDsn.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnAccDsn.Name = "BtnAccDsn"
        Me.BtnAccDsn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BtnAccDsn.Size = New System.Drawing.Size(100, 30)
        '
        'BtnRefreshDsn
        '
        Me.BtnRefreshDsn.Caption = "REFRESH"
        Me.BtnRefreshDsn.Id = 5
        Me.BtnRefreshDsn.ImageOptions.Image = CType(resources.GetObject("BtnRefreshDsn.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnRefreshDsn.ImageOptions.LargeImage = CType(resources.GetObject("BtnRefreshDsn.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnRefreshDsn.Name = "BtnRefreshDsn"
        Me.BtnRefreshDsn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BtnRefreshDsn.Size = New System.Drawing.Size(75, 30)
        '
        'BtnSelesai
        '
        Me.BtnSelesai.Caption = "SELESAI"
        Me.BtnSelesai.Enabled = False
        Me.BtnSelesai.Id = 12
        Me.BtnSelesai.ImageOptions.SvgImage = CType(resources.GetObject("BtnSelesai.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnExitDsn
        '
        Me.BtnExitDsn.Caption = "KELUAR"
        Me.BtnExitDsn.Id = 6
        Me.BtnExitDsn.ImageOptions.Image = CType(resources.GetObject("BtnExitDsn.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnExitDsn.ImageOptions.LargeImage = CType(resources.GetObject("BtnExitDsn.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnExitDsn.Name = "BtnExitDsn"
        Me.BtnExitDsn.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BtnExitDsn.Size = New System.Drawing.Size(70, 30)
        '
        'BtnCetakPO
        '
        Me.BtnCetakPO.Caption = "CETAK"
        Me.BtnCetakPO.Id = 13
        Me.BtnCetakPO.ImageOptions.SvgImage = CType(resources.GetObject("BtnCetakPO.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnCetakPO.Name = "BtnCetakPO"
        Me.BtnCetakPO.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.barDockControlTop.Appearance.Options.UseBackColor = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1072, 34)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 606)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1072, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 34)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 572)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1072, 34)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 572)
        '
        'KirimPrinting
        '
        Me.KirimPrinting.Caption = "KIRIM PO. PRINTING"
        Me.KirimPrinting.Id = 10
        Me.KirimPrinting.Name = "KirimPrinting"
        '
        'KirimCutting
        '
        Me.KirimCutting.Caption = "KIRIM PO. CUTTING"
        Me.KirimCutting.Id = 11
        Me.KirimCutting.Name = "KirimCutting"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1072, 241)
        Me.SplitContainerControl1.SplitterPosition = 71
        Me.SplitContainerControl1.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.RbKirim)
        Me.GroupControl1.Controls.Add(Me.RbTerima)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1072, 71)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "PILIH MENU"
        '
        'RbKirim
        '
        Me.RbKirim.BackColor = System.Drawing.Color.Transparent
        Me.RbKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.RbKirim.ForeColor = System.Drawing.Color.Black
        Me.RbKirim.Location = New System.Drawing.Point(2, 47)
        Me.RbKirim.Name = "RbKirim"
        Me.RbKirim.Size = New System.Drawing.Size(1068, 25)
        Me.RbKirim.TabIndex = 3
        Me.RbKirim.Text = "Pembuatan/Kirim PO. Printing"
        Me.RbKirim.UseVisualStyleBackColor = False
        '
        'RbTerima
        '
        Me.RbTerima.BackColor = System.Drawing.Color.Transparent
        Me.RbTerima.Dock = System.Windows.Forms.DockStyle.Top
        Me.RbTerima.ForeColor = System.Drawing.Color.Black
        Me.RbTerima.Location = New System.Drawing.Point(2, 22)
        Me.RbTerima.Name = "RbTerima"
        Me.RbTerima.Size = New System.Drawing.Size(1068, 25)
        Me.RbTerima.TabIndex = 4
        Me.RbTerima.Text = "Terima PO Produksi"
        Me.RbTerima.UseVisualStyleBackColor = False
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1072, 164)
        Me.SplitContainerControl2.SplitterPosition = 532
        Me.SplitContainerControl2.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.ListDetailPODsn)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(532, 164)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "DETAIL P.O INTERNAL DESAIN"
        '
        'ListDetailPODsn
        '
        Me.ListDetailPODsn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDetailPODsn.Enabled = False
        Me.ListDetailPODsn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListDetailPODsn.HideSelection = False
        Me.ListDetailPODsn.Location = New System.Drawing.Point(2, 22)
        Me.ListDetailPODsn.Name = "ListDetailPODsn"
        Me.ListDetailPODsn.Size = New System.Drawing.Size(528, 140)
        Me.ListDetailPODsn.TabIndex = 4
        Me.ListDetailPODsn.UseCompatibleStateImageBehavior = False
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.TabControl1.Size = New System.Drawing.Size(534, 164)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.ListPOPrint)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(526, 132)
        Me.XtraTabPage1.Text = "DETAIL P.O PRINTING"
        '
        'ListPOPrint
        '
        Me.ListPOPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPOPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListPOPrint.HideSelection = False
        Me.ListPOPrint.Location = New System.Drawing.Point(0, 0)
        Me.ListPOPrint.Name = "ListPOPrint"
        Me.ListPOPrint.Size = New System.Drawing.Size(526, 132)
        Me.ListPOPrint.TabIndex = 5
        Me.ListPOPrint.UseCompatibleStateImageBehavior = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ListPOCutting)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(526, 132)
        Me.XtraTabPage2.Text = "DETAIL P.O CUTTING"
        '
        'ListPOCutting
        '
        Me.ListPOCutting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPOCutting.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ListPOCutting.Location = New System.Drawing.Point(0, 0)
        Me.ListPOCutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListPOCutting.Name = "ListPOCutting"
        Me.ListPOCutting.Size = New System.Drawing.Size(526, 132)
        Me.ListPOCutting.TabIndex = 10
        Me.ListPOCutting.UseCompatibleStateImageBehavior = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "ENTRY"
        Me.BarButtonItem1.Enabled = False
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.ImageOptions.Image = CType(resources.GetObject("BarButtonItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarButtonItem1.Size = New System.Drawing.Size(70, 30)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "EDIT"
        Me.BarButtonItem2.Enabled = False
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarButtonItem2.Size = New System.Drawing.Size(70, 30)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.ActAsDropDown = True
        Me.BarButtonItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem3.Caption = "TERIMA PO"
        Me.BarButtonItem3.Enabled = False
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarButtonItem3.Size = New System.Drawing.Size(100, 30)
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "REFRESH"
        Me.BarButtonItem4.Id = 5
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarButtonItem4.Size = New System.Drawing.Size(75, 30)
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "SELESAI"
        Me.BarButtonItem5.Enabled = False
        Me.BarButtonItem5.Id = 12
        Me.BarButtonItem5.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "KELUAR"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem6.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem6.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarButtonItem6.Size = New System.Drawing.Size(70, 30)
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "CETAK"
        Me.BarButtonItem7.Id = 13
        Me.BarButtonItem7.ImageOptions.SvgImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1072, 34)
        Me.BarDockControl4.Manager = Nothing
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 572)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        ButtonImageOptions2.SvgImage = CType(resources.GetObject("ButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        ButtonImageOptions2.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.GroupControl3.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Tampil Pekerjaan Selesai", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, True, Nothing, True, False, True, Nothing, -1)})
        Me.GroupControl3.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl3.Location = New System.Drawing.Point(0, 275)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1072, 331)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "P.O INTERNAL DESAIN"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Query"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 27)
        Me.GridControl1.MainView = Me.GridPODsn
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1068, 302)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridPODsn})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_geogiven_vm_Connection-Kantor"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery2.Name = "Query"
        CustomSqlQuery2.Sql = "select * from view_tampilpo_dsn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY kirim_po DESC "
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridPODsn
        '
        Me.GridPODsn.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidpo_dsn, Me.colnopo, Me.colidklien, Me.colidkota, Me.coltanggal, Me.collokasi, Me.colbrand, Me.colnope, Me.coldeadline_desain, Me.colselesai_desain, Me.coldeadline_ki, Me.coltime_closhing, Me.colkirim_po, Me.colterima_po, Me.colkirim_ppic, Me.colklien, Me.coliddtorder, Me.colidpo_prd, Me.colPO_Produksi, Me.colStatus})
        Me.GridPODsn.GridControl = Me.GridControl1
        Me.GridPODsn.Name = "GridPODsn"
        Me.GridPODsn.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPODsn.OptionsFilter.AllowFilterEditor = False
        Me.GridPODsn.OptionsSelection.MultiSelect = True
        Me.GridPODsn.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridPODsn.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.GridPODsn.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridPODsn.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'colidpo_dsn
        '
        Me.colidpo_dsn.FieldName = "idpo_dsn"
        Me.colidpo_dsn.Name = "colidpo_dsn"
        '
        'colnopo
        '
        Me.colnopo.Caption = "No. P.O"
        Me.colnopo.FieldName = "nopo"
        Me.colnopo.Name = "colnopo"
        Me.colnopo.Visible = True
        Me.colnopo.VisibleIndex = 1
        '
        'colidklien
        '
        Me.colidklien.FieldName = "idklien"
        Me.colidklien.Name = "colidklien"
        '
        'colidkota
        '
        Me.colidkota.FieldName = "idkota"
        Me.colidkota.Name = "colidkota"
        '
        'coltanggal
        '
        Me.coltanggal.Caption = "Tanggal"
        Me.coltanggal.FieldName = "tanggal"
        Me.coltanggal.Name = "coltanggal"
        Me.coltanggal.Visible = True
        Me.coltanggal.VisibleIndex = 3
        '
        'collokasi
        '
        Me.collokasi.FieldName = "lokasi"
        Me.collokasi.Name = "collokasi"
        '
        'colbrand
        '
        Me.colbrand.Caption = "Brand"
        Me.colbrand.FieldName = "brand"
        Me.colbrand.Name = "colbrand"
        Me.colbrand.Visible = True
        Me.colbrand.VisibleIndex = 4
        '
        'colnope
        '
        Me.colnope.Caption = "No. PE"
        Me.colnope.FieldName = "nope"
        Me.colnope.Name = "colnope"
        Me.colnope.Visible = True
        Me.colnope.VisibleIndex = 5
        '
        'coldeadline_desain
        '
        Me.coldeadline_desain.Caption = "Deadline Desain"
        Me.coldeadline_desain.FieldName = "deadline_desain"
        Me.coldeadline_desain.Name = "coldeadline_desain"
        Me.coldeadline_desain.Visible = True
        Me.coldeadline_desain.VisibleIndex = 6
        '
        'colselesai_desain
        '
        Me.colselesai_desain.FieldName = "selesai_desain"
        Me.colselesai_desain.Name = "colselesai_desain"
        '
        'coldeadline_ki
        '
        Me.coldeadline_ki.Caption = "Deadline Kirim"
        Me.coldeadline_ki.FieldName = "deadline_ki"
        Me.coldeadline_ki.Name = "coldeadline_ki"
        Me.coldeadline_ki.Visible = True
        Me.coldeadline_ki.VisibleIndex = 7
        '
        'coltime_closhing
        '
        Me.coltime_closhing.FieldName = "time_closhing"
        Me.coltime_closhing.Name = "coltime_closhing"
        '
        'colkirim_po
        '
        Me.colkirim_po.FieldName = "kirim_po"
        Me.colkirim_po.Name = "colkirim_po"
        '
        'colterima_po
        '
        Me.colterima_po.FieldName = "terima_po"
        Me.colterima_po.Name = "colterima_po"
        '
        'colkirim_ppic
        '
        Me.colkirim_ppic.FieldName = "kirim_ppic"
        Me.colkirim_ppic.Name = "colkirim_ppic"
        '
        'colklien
        '
        Me.colklien.Caption = "Klien"
        Me.colklien.FieldName = "klien"
        Me.colklien.Name = "colklien"
        Me.colklien.Visible = True
        Me.colklien.VisibleIndex = 2
        '
        'coliddtorder
        '
        Me.coliddtorder.FieldName = "iddtorder"
        Me.coliddtorder.Name = "coliddtorder"
        '
        'colidpo_prd
        '
        Me.colidpo_prd.FieldName = "idpo_prd"
        Me.colidpo_prd.Name = "colidpo_prd"
        '
        'colPO_Produksi
        '
        Me.colPO_Produksi.FieldName = "PO_Produksi"
        Me.colPO_Produksi.Name = "colPO_Produksi"
        Me.colPO_Produksi.Visible = True
        Me.colPO_Produksi.VisibleIndex = 8
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tomato
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TidPE)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.TKota)
        Me.Panel2.Controls.Add(Me.PanelAlasan)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.TKeterangan)
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TIdBrand)
        Me.Panel2.Controls.Add(Me.TToko)
        Me.Panel2.Controls.Add(Me.TBarang1)
        Me.Panel2.Controls.Add(Me.Tp1)
        Me.Panel2.Controls.Add(Me.TIdToko)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TIdpoprd)
        Me.Panel2.Controls.Add(Me.Tl1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TIdBarang1)
        Me.Panel2.Controls.Add(Me.Tt1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Tj1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TBrand)
        Me.Panel2.Location = New System.Drawing.Point(168, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 451)
        Me.Panel2.TabIndex = 10
        Me.Panel2.Visible = False
        '
        'TidPE
        '
        Me.TidPE.Location = New System.Drawing.Point(598, 68)
        Me.TidPE.Name = "TidPE"
        Me.TidPE.Size = New System.Drawing.Size(100, 23)
        Me.TidPE.TabIndex = 178
        Me.TidPE.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(447, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(10, 13)
        Me.Label29.TabIndex = 177
        Me.Label29.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(380, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 175
        Me.Label30.Text = "KOTA"
        '
        'TKota
        '
        Me.TKota.Location = New System.Drawing.Point(463, 19)
        Me.TKota.Name = "TKota"
        Me.TKota.Size = New System.Drawing.Size(217, 22)
        Me.TKota.TabIndex = 176
        '
        'PanelAlasan
        '
        Me.PanelAlasan.BackColor = System.Drawing.Color.PaleVioletRed
        Me.PanelAlasan.Controls.Add(Me.BtnSimpanAlasan)
        Me.PanelAlasan.Controls.Add(Me.BtnTutupAlasan)
        Me.PanelAlasan.Controls.Add(Me.TAlasan)
        Me.PanelAlasan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAlasan.Location = New System.Drawing.Point(166, 111)
        Me.PanelAlasan.Name = "PanelAlasan"
        Me.PanelAlasan.Size = New System.Drawing.Size(396, 136)
        Me.PanelAlasan.TabIndex = 174
        Me.PanelAlasan.TabStop = False
        Me.PanelAlasan.Text = "MASUKKAN ALASAN REVISI"
        Me.PanelAlasan.Visible = False
        '
        'BtnSimpanAlasan
        '
        Me.BtnSimpanAlasan.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.BtnSimpanAlasan.Appearance.Options.UseFont = True
        Me.BtnSimpanAlasan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSimpanAlasan.ImageOptions.SvgImage = CType(resources.GetObject("BtnSimpanAlasan.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSimpanAlasan.Location = New System.Drawing.Point(3, 73)
        Me.BtnSimpanAlasan.Name = "BtnSimpanAlasan"
        Me.BtnSimpanAlasan.Size = New System.Drawing.Size(390, 30)
        Me.BtnSimpanAlasan.TabIndex = 30
        Me.BtnSimpanAlasan.Text = "SIMPAN"
        '
        'BtnTutupAlasan
        '
        Me.BtnTutupAlasan.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTutupAlasan.Appearance.Options.UseFont = True
        Me.BtnTutupAlasan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnTutupAlasan.ImageOptions.SvgImage = CType(resources.GetObject("BtnTutupAlasan.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnTutupAlasan.Location = New System.Drawing.Point(3, 103)
        Me.BtnTutupAlasan.Name = "BtnTutupAlasan"
        Me.BtnTutupAlasan.Size = New System.Drawing.Size(390, 30)
        Me.BtnTutupAlasan.TabIndex = 31
        Me.BtnTutupAlasan.Text = "Tutup"
        '
        'TAlasan
        '
        Me.TAlasan.Location = New System.Drawing.Point(14, 27)
        Me.TAlasan.Name = "TAlasan"
        Me.TAlasan.Size = New System.Drawing.Size(358, 22)
        Me.TAlasan.TabIndex = 0
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(133, 129)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 170
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(11, 129)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 13)
        Me.Label25.TabIndex = 169
        Me.Label25.Text = "KETERANGAN"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(135, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 13)
        Me.Label23.TabIndex = 168
        Me.Label23.Text = ":"
        '
        'TKeterangan
        '
        Me.TKeterangan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TKeterangan.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TKeterangan.Location = New System.Drawing.Point(149, 128)
        Me.TKeterangan.Name = "TKeterangan"
        Me.TKeterangan.Size = New System.Drawing.Size(426, 22)
        Me.TKeterangan.TabIndex = 43
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 408)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnSimpanDetail)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnClose)
        Me.SplitContainer1.Size = New System.Drawing.Size(721, 39)
        Me.SplitContainer1.SplitterDistance = 383
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 167
        '
        'BtnSimpanDetail
        '
        Me.BtnSimpanDetail.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.BtnSimpanDetail.Appearance.Options.UseFont = True
        Me.BtnSimpanDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnSimpanDetail.ImageOptions.Image = CType(resources.GetObject("BtnSimpanDetail.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSimpanDetail.Location = New System.Drawing.Point(0, 0)
        Me.BtnSimpanDetail.Name = "BtnSimpanDetail"
        Me.BtnSimpanDetail.Size = New System.Drawing.Size(383, 39)
        Me.BtnSimpanDetail.TabIndex = 29
        Me.BtnSimpanDetail.Text = "SIMPAN"
        '
        'BtnClose
        '
        Me.BtnClose.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Appearance.Options.UseFont = True
        Me.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnClose.ImageOptions.SvgImage = CType(resources.GetObject("BtnClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnClose.Location = New System.Drawing.Point(0, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(335, 39)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "Tutup"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MistyRose
        Me.Panel3.Controls.Add(Me.idrevisi)
        Me.Panel3.Controls.Add(Me.TidPOCut)
        Me.Panel3.Controls.Add(Me.TidPoPrt)
        Me.Panel3.Controls.Add(Me.TidFinishing)
        Me.Panel3.Controls.Add(Me.TidDetailpoCut)
        Me.Panel3.Controls.Add(Me.TidBahan)
        Me.Panel3.Controls.Add(Me.CBahan)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.TidDetailDsn)
        Me.Panel3.Controls.Add(Me.TFinishing)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.TidDetailPoPrt)
        Me.Panel3.Controls.Add(Me.PanelP)
        Me.Panel3.Controls.Add(Me.PanelC)
        Me.Panel3.Controls.Add(Me.CSubKerjaan)
        Me.Panel3.Controls.Add(Me.CPrinting)
        Me.Panel3.Controls.Add(Me.CCutting)
        Me.Panel3.Controls.Add(Me.TBarang2)
        Me.Panel3.Controls.Add(Me.CMal)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.TIdBarang2)
        Me.Panel3.Location = New System.Drawing.Point(54, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(638, 208)
        Me.Panel3.TabIndex = 159
        '
        'idrevisi
        '
        Me.idrevisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idrevisi.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.idrevisi.Location = New System.Drawing.Point(544, 165)
        Me.idrevisi.Name = "idrevisi"
        Me.idrevisi.Size = New System.Drawing.Size(20, 22)
        Me.idrevisi.TabIndex = 59
        Me.idrevisi.Visible = False
        '
        'TidPOCut
        '
        Me.TidPOCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TidPOCut.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TidPOCut.Location = New System.Drawing.Point(507, 113)
        Me.TidPOCut.Name = "TidPOCut"
        Me.TidPOCut.Size = New System.Drawing.Size(20, 22)
        Me.TidPOCut.TabIndex = 58
        Me.TidPOCut.Visible = False
        '
        'TidPoPrt
        '
        Me.TidPoPrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TidPoPrt.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TidPoPrt.Location = New System.Drawing.Point(507, 87)
        Me.TidPoPrt.Name = "TidPoPrt"
        Me.TidPoPrt.Size = New System.Drawing.Size(20, 22)
        Me.TidPoPrt.TabIndex = 57
        Me.TidPoPrt.Visible = False
        '
        'TidFinishing
        '
        Me.TidFinishing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TidFinishing.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TidFinishing.Location = New System.Drawing.Point(489, 173)
        Me.TidFinishing.Name = "TidFinishing"
        Me.TidFinishing.Size = New System.Drawing.Size(20, 22)
        Me.TidFinishing.TabIndex = 56
        Me.TidFinishing.Visible = False
        '
        'TidDetailpoCut
        '
        Me.TidDetailpoCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TidDetailpoCut.Location = New System.Drawing.Point(13, 104)
        Me.TidDetailpoCut.Name = "TidDetailpoCut"
        Me.TidDetailpoCut.ReadOnly = True
        Me.TidDetailpoCut.Size = New System.Drawing.Size(48, 20)
        Me.TidDetailpoCut.TabIndex = 173
        Me.TidDetailpoCut.Visible = False
        '
        'TidBahan
        '
        Me.TidBahan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TidBahan.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TidBahan.Location = New System.Drawing.Point(415, 140)
        Me.TidBahan.Name = "TidBahan"
        Me.TidBahan.Size = New System.Drawing.Size(20, 22)
        Me.TidBahan.TabIndex = 55
        Me.TidBahan.Visible = False
        '
        'CBahan
        '
        Me.CBahan.FormattingEnabled = True
        Me.CBahan.Location = New System.Drawing.Point(159, 140)
        Me.CBahan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBahan.Name = "CBahan"
        Me.CBahan.Size = New System.Drawing.Size(248, 23)
        Me.CBahan.TabIndex = 54
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label27.Location = New System.Drawing.Point(141, 141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(10, 13)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = ":"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(22, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 13)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "BAHAN"
        '
        'TidDetailDsn
        '
        Me.TidDetailDsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TidDetailDsn.Location = New System.Drawing.Point(13, 65)
        Me.TidDetailDsn.Name = "TidDetailDsn"
        Me.TidDetailDsn.ReadOnly = True
        Me.TidDetailDsn.Size = New System.Drawing.Size(48, 20)
        Me.TidDetailDsn.TabIndex = 166
        Me.TidDetailDsn.Visible = False
        '
        'TFinishing
        '
        Me.TFinishing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TFinishing.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TFinishing.Location = New System.Drawing.Point(159, 171)
        Me.TFinishing.Name = "TFinishing"
        Me.TFinishing.Size = New System.Drawing.Size(325, 22)
        Me.TFinishing.TabIndex = 51
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(141, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(22, 174)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "FINISHING"
        '
        'TidDetailPoPrt
        '
        Me.TidDetailPoPrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TidDetailPoPrt.Location = New System.Drawing.Point(26, 3)
        Me.TidDetailPoPrt.Name = "TidDetailPoPrt"
        Me.TidDetailPoPrt.ReadOnly = True
        Me.TidDetailPoPrt.Size = New System.Drawing.Size(48, 20)
        Me.TidDetailPoPrt.TabIndex = 165
        Me.TidDetailPoPrt.Visible = False
        '
        'PanelP
        '
        Me.PanelP.Controls.Add(Me.Tj2)
        Me.PanelP.Controls.Add(Me.Tp2)
        Me.PanelP.Controls.Add(Me.Label16)
        Me.PanelP.Controls.Add(Me.Label17)
        Me.PanelP.Controls.Add(Me.Tl2)
        Me.PanelP.Controls.Add(Me.Label15)
        Me.PanelP.Controls.Add(Me.Tt2)
        Me.PanelP.Controls.Add(Me.Label14)
        Me.PanelP.Location = New System.Drawing.Point(159, 50)
        Me.PanelP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelP.Name = "PanelP"
        Me.PanelP.Size = New System.Drawing.Size(332, 38)
        Me.PanelP.TabIndex = 48
        Me.PanelP.Visible = False
        '
        'Tj2
        '
        Me.Tj2.EditValue = "0"
        Me.Tj2.Location = New System.Drawing.Point(250, 19)
        Me.Tj2.Name = "Tj2"
        Me.Tj2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tj2.Size = New System.Drawing.Size(77, 22)
        Me.Tj2.TabIndex = 26
        '
        'Tp2
        '
        Me.Tp2.EditValue = "0"
        Me.Tp2.Location = New System.Drawing.Point(1, 19)
        Me.Tp2.Name = "Tp2"
        Me.Tp2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tp2.Size = New System.Drawing.Size(77, 22)
        Me.Tp2.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(84, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "LEBAR"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(1, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "PANJANG"
        '
        'Tl2
        '
        Me.Tl2.EditValue = "0"
        Me.Tl2.Location = New System.Drawing.Point(84, 19)
        Me.Tl2.Name = "Tl2"
        Me.Tl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tl2.Size = New System.Drawing.Size(77, 22)
        Me.Tl2.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(170, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "TINGGI"
        '
        'Tt2
        '
        Me.Tt2.EditValue = "0"
        Me.Tt2.Location = New System.Drawing.Point(167, 19)
        Me.Tt2.Name = "Tt2"
        Me.Tt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tt2.Size = New System.Drawing.Size(77, 22)
        Me.Tt2.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(253, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "JUMLAH"
        '
        'PanelC
        '
        Me.PanelC.Controls.Add(Me.Tp3)
        Me.PanelC.Controls.Add(Me.Label21)
        Me.PanelC.Controls.Add(Me.Label20)
        Me.PanelC.Controls.Add(Me.Tl3)
        Me.PanelC.Controls.Add(Me.Label19)
        Me.PanelC.Controls.Add(Me.Tt3)
        Me.PanelC.Controls.Add(Me.Label18)
        Me.PanelC.Controls.Add(Me.Tj3)
        Me.PanelC.Location = New System.Drawing.Point(159, 89)
        Me.PanelC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelC.Name = "PanelC"
        Me.PanelC.Size = New System.Drawing.Size(332, 44)
        Me.PanelC.TabIndex = 47
        Me.PanelC.Visible = False
        '
        'Tp3
        '
        Me.Tp3.EditValue = "0"
        Me.Tp3.Location = New System.Drawing.Point(1, 20)
        Me.Tp3.Name = "Tp3"
        Me.Tp3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tp3.Size = New System.Drawing.Size(77, 22)
        Me.Tp3.TabIndex = 31
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(84, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "LEBAR"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(1, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "PANJANG"
        '
        'Tl3
        '
        Me.Tl3.EditValue = "0"
        Me.Tl3.Location = New System.Drawing.Point(84, 20)
        Me.Tl3.Name = "Tl3"
        Me.Tl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tl3.Size = New System.Drawing.Size(77, 22)
        Me.Tl3.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(167, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "TINGGI"
        '
        'Tt3
        '
        Me.Tt3.EditValue = "0"
        Me.Tt3.Location = New System.Drawing.Point(167, 20)
        Me.Tt3.Name = "Tt3"
        Me.Tt3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tt3.Size = New System.Drawing.Size(77, 22)
        Me.Tt3.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(250, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "JUMLAH"
        '
        'Tj3
        '
        Me.Tj3.EditValue = "0"
        Me.Tj3.Location = New System.Drawing.Point(250, 20)
        Me.Tj3.Name = "Tj3"
        Me.Tj3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tj3.Size = New System.Drawing.Size(77, 22)
        Me.Tj3.TabIndex = 37
        '
        'CSubKerjaan
        '
        Me.CSubKerjaan.AutoSize = True
        Me.CSubKerjaan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CSubKerjaan.Location = New System.Drawing.Point(507, 25)
        Me.CSubKerjaan.Name = "CSubKerjaan"
        Me.CSubKerjaan.Size = New System.Drawing.Size(113, 17)
        Me.CSubKerjaan.TabIndex = 40
        Me.CSubKerjaan.Text = "SUB PEKERJAAN"
        Me.CSubKerjaan.UseVisualStyleBackColor = True
        '
        'CPrinting
        '
        Me.CPrinting.AutoSize = True
        Me.CPrinting.Enabled = False
        Me.CPrinting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CPrinting.Location = New System.Drawing.Point(65, 66)
        Me.CPrinting.Name = "CPrinting"
        Me.CPrinting.Size = New System.Drawing.Size(84, 17)
        Me.CPrinting.TabIndex = 39
        Me.CPrinting.Text = "PRINTING :"
        Me.CPrinting.UseVisualStyleBackColor = True
        '
        'CCutting
        '
        Me.CCutting.AutoSize = True
        Me.CCutting.Enabled = False
        Me.CCutting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CCutting.Location = New System.Drawing.Point(65, 105)
        Me.CCutting.Name = "CCutting"
        Me.CCutting.Size = New System.Drawing.Size(85, 17)
        Me.CCutting.TabIndex = 38
        Me.CCutting.Text = "CUTTING   :"
        Me.CCutting.UseVisualStyleBackColor = True
        '
        'TBarang2
        '
        Me.TBarang2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBarang2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TBarang2.Location = New System.Drawing.Point(159, 24)
        Me.TBarang2.Name = "TBarang2"
        Me.TBarang2.Size = New System.Drawing.Size(325, 22)
        Me.TBarang2.TabIndex = 28
        '
        'CMal
        '
        Me.CMal.AutoSize = True
        Me.CMal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CMal.Location = New System.Drawing.Point(507, 47)
        Me.CMal.Name = "CMal"
        Me.CMal.Size = New System.Drawing.Size(51, 17)
        Me.CMal.TabIndex = 27
        Me.CMal.Text = "MAL"
        Me.CMal.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(141, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(22, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "BARANG PRINTING"
        '
        'TIdBarang2
        '
        Me.TIdBarang2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIdBarang2.Location = New System.Drawing.Point(163, 3)
        Me.TIdBarang2.Name = "TIdBarang2"
        Me.TIdBarang2.ReadOnly = True
        Me.TIdBarang2.Size = New System.Drawing.Size(48, 20)
        Me.TIdBarang2.TabIndex = 161
        Me.TIdBarang2.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 15)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = ":"
        '
        'TIdBrand
        '
        Me.TIdBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIdBrand.Location = New System.Drawing.Point(80, 45)
        Me.TIdBrand.Name = "TIdBrand"
        Me.TIdBrand.ReadOnly = True
        Me.TIdBrand.Size = New System.Drawing.Size(48, 20)
        Me.TIdBrand.TabIndex = 164
        Me.TIdBrand.Visible = False
        '
        'TToko
        '
        Me.TToko.Location = New System.Drawing.Point(149, 16)
        Me.TToko.Name = "TToko"
        Me.TToko.Size = New System.Drawing.Size(217, 22)
        Me.TToko.TabIndex = 141
        '
        'TBarang1
        '
        Me.TBarang1.Location = New System.Drawing.Point(149, 63)
        Me.TBarang1.Name = "TBarang1"
        Me.TBarang1.Size = New System.Drawing.Size(309, 22)
        Me.TBarang1.TabIndex = 142
        '
        'Tp1
        '
        Me.Tp1.EditValue = "0"
        Me.Tp1.Location = New System.Drawing.Point(149, 103)
        Me.Tp1.Name = "Tp1"
        Me.Tp1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tp1.Size = New System.Drawing.Size(77, 22)
        Me.Tp1.TabIndex = 152
        '
        'TIdToko
        '
        Me.TIdToko.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIdToko.Location = New System.Drawing.Point(80, 21)
        Me.TIdToko.Name = "TIdToko"
        Me.TIdToko.ReadOnly = True
        Me.TIdToko.Size = New System.Drawing.Size(48, 20)
        Me.TIdToko.TabIndex = 163
        Me.TIdToko.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(232, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "LEBAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(149, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "PANJANG"
        '
        'TIdpoprd
        '
        Me.TIdpoprd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIdpoprd.Location = New System.Drawing.Point(490, 103)
        Me.TIdpoprd.Name = "TIdpoprd"
        Me.TIdpoprd.ReadOnly = True
        Me.TIdpoprd.Size = New System.Drawing.Size(48, 20)
        Me.TIdpoprd.TabIndex = 162
        Me.TIdpoprd.Visible = False
        '
        'Tl1
        '
        Me.Tl1.EditValue = "0"
        Me.Tl1.Location = New System.Drawing.Point(232, 103)
        Me.Tl1.Name = "Tl1"
        Me.Tl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tl1.Size = New System.Drawing.Size(77, 22)
        Me.Tl1.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "BARANG PRODUKSI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(135, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(315, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "TINGGI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "TOKO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(135, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = ":"
        '
        'TIdBarang1
        '
        Me.TIdBarang1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIdBarang1.Location = New System.Drawing.Point(469, 63)
        Me.TIdBarang1.Name = "TIdBarang1"
        Me.TIdBarang1.ReadOnly = True
        Me.TIdBarang1.Size = New System.Drawing.Size(48, 20)
        Me.TIdBarang1.TabIndex = 160
        Me.TIdBarang1.Visible = False
        '
        'Tt1
        '
        Me.Tt1.EditValue = "0"
        Me.Tt1.Location = New System.Drawing.Point(315, 103)
        Me.Tt1.Name = "Tt1"
        Me.Tt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tt1.Size = New System.Drawing.Size(77, 22)
        Me.Tt1.TabIndex = 156
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "BRAND"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(135, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = ":"
        '
        'Tj1
        '
        Me.Tj1.EditValue = "0"
        Me.Tj1.Location = New System.Drawing.Point(399, 103)
        Me.Tj1.Name = "Tj1"
        Me.Tj1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tj1.Size = New System.Drawing.Size(77, 22)
        Me.Tj1.TabIndex = 158
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(399, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "JUMLAH"
        '
        'TBrand
        '
        Me.TBrand.Location = New System.Drawing.Point(149, 39)
        Me.TBrand.Name = "TBrand"
        Me.TBrand.Size = New System.Drawing.Size(217, 22)
        Me.TBrand.TabIndex = 146
        '
        'POInternalDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "POInternalDesign"
        Me.Size = New System.Drawing.Size(1072, 606)
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemTextEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        CType(Me.SplitContainerControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl2.ResumeLayout(false)
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        CType(Me.TabControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabControl1.ResumeLayout(false)
        Me.XtraTabPage1.ResumeLayout(false)
        Me.XtraTabPage2.ResumeLayout(false)
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl3.ResumeLayout(false)
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridPODsn,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.TKota.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelAlasan.ResumeLayout(false)
        Me.PanelAlasan.PerformLayout
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.PanelP.ResumeLayout(false)
        Me.PanelP.PerformLayout
        CType(Me.Tj2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tp2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tl2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tt2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelC.ResumeLayout(false)
        Me.PanelC.PerformLayout
        CType(Me.Tp3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tl3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tt3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tj3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TToko.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TBarang1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tp1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tl1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tt1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Tj1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TBrand.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BtnEntryDsn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnEditDsn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnAccDsn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRefreshDsn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnSelesai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnExitDsn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCetakPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents KirimPrinting As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents KirimCutting As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RbKirim As System.Windows.Forms.RadioButton
    Friend WithEvents RbTerima As System.Windows.Forms.RadioButton
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ListDetailPODsn As System.Windows.Forms.ListView
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ListPOPrint As System.Windows.Forms.ListView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ListPOCutting As System.Windows.Forms.ListView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridPODsn As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents colidpo_dsn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnopo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidklien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidkota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeadline_desain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colselesai_desain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeadline_ki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltime_closhing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkirim_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterima_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkirim_ppic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colklien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coliddtorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidpo_prd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPO_Produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TKota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelAlasan As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSimpanAlasan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnTutupAlasan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TAlasan As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnSimpanDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents idrevisi As System.Windows.Forms.TextBox
    Friend WithEvents TidPOCut As System.Windows.Forms.TextBox
    Friend WithEvents TidPoPrt As System.Windows.Forms.TextBox
    Friend WithEvents TidFinishing As System.Windows.Forms.TextBox
    Friend WithEvents TidDetailpoCut As System.Windows.Forms.TextBox
    Friend WithEvents TidBahan As System.Windows.Forms.TextBox
    Friend WithEvents CBahan As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TidDetailDsn As System.Windows.Forms.TextBox
    Friend WithEvents TFinishing As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TidDetailPoPrt As System.Windows.Forms.TextBox
    Friend WithEvents PanelP As System.Windows.Forms.Panel
    Friend WithEvents Tj2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tp2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Tl2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Tt2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PanelC As System.Windows.Forms.Panel
    Friend WithEvents Tp3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Tl3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Tt3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Tj3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CSubKerjaan As System.Windows.Forms.CheckBox
    Friend WithEvents CPrinting As System.Windows.Forms.CheckBox
    Friend WithEvents CCutting As System.Windows.Forms.CheckBox
    Friend WithEvents TBarang2 As System.Windows.Forms.TextBox
    Friend WithEvents CMal As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TIdBarang2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TIdBrand As System.Windows.Forms.TextBox
    Friend WithEvents TToko As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TBarang1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tp1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TIdToko As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TIdpoprd As System.Windows.Forms.TextBox
    Friend WithEvents Tl1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TIdBarang1 As System.Windows.Forms.TextBox
    Friend WithEvents Tt1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tj1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TBrand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TidPE As System.Windows.Forms.TextBox

End Class
