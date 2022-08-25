<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailToko
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailToko))
        Me.BtnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnHapusBarang = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnUpdateDetailTK = New DevExpress.XtraBars.BarButtonItem()
        Me.CRealKirim = New System.Windows.Forms.CheckBox()
        Me.CDeadKirim = New System.Windows.Forms.CheckBox()
        Me.CRealImple = New System.Windows.Forms.CheckBox()
        Me.CRealSurvei = New System.Windows.Forms.CheckBox()
        Me.CRealTerimaBrg = New System.Windows.Forms.CheckBox()
        Me.DTDeadlineKirimTK = New System.Windows.Forms.DateTimePicker()
        Me.DTRealKirimTK = New System.Windows.Forms.DateTimePicker()
        Me.TIDOrder = New System.Windows.Forms.TextBox()
        Me.BtnSimpanDetailTK = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnInsertDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.TidToko = New System.Windows.Forms.TextBox()
        Me.CSurvei = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TKetTK = New System.Windows.Forms.TextBox()
        Me.DTTglTerima = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtnCetakFrm = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TIdKirimTK = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBarang = New System.Windows.Forms.ListView()
        Me.DTDeadlineImpleTK = New System.Windows.Forms.DateTimePicker()
        Me.DTRealImpleTK = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DTDeadlineSurveiTK = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TQtyPrd = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TSPrd = New System.Windows.Forms.TextBox()
        Me.DTRealSurveiTK = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ListToko = New System.Windows.Forms.ListView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TLPrd = New System.Windows.Forms.TextBox()
        Me.TPPrd = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TTPrd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TKotaTK = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TNamaTK = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TidBarangPrd = New System.Windows.Forms.TextBox()
        Me.TidTrans = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBarangPrd = New System.Windows.Forms.TextBox()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Caption = "TUTUP"
        Me.BtnClose.Id = 4
        Me.BtnClose.ImageOptions.SvgImage = CType(resources.GetObject("BtnClose.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnClose.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red
        Me.BtnClose.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White
        Me.BtnClose.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.BtnClose.ItemAppearance.Hovered.Options.UseForeColor = True
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnHapusBarang
        '
        Me.BtnHapusBarang.Caption = "HAPUS BARANG"
        Me.BtnHapusBarang.Enabled = False
        Me.BtnHapusBarang.Id = 7
        Me.BtnHapusBarang.ImageOptions.SvgImage = CType(resources.GetObject("BtnHapusBarang.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnHapusBarang.Name = "BtnHapusBarang"
        Me.BtnHapusBarang.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnUpdateDetailTK
        '
        Me.BtnUpdateDetailTK.Caption = "EDIT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DETAIL"
        Me.BtnUpdateDetailTK.Enabled = False
        Me.BtnUpdateDetailTK.Id = 2
        Me.BtnUpdateDetailTK.ImageOptions.SvgImage = CType(resources.GetObject("BtnUpdateDetailTK.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnUpdateDetailTK.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red
        Me.BtnUpdateDetailTK.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateDetailTK.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.BtnUpdateDetailTK.ItemAppearance.Hovered.Options.UseForeColor = True
        Me.BtnUpdateDetailTK.Name = "BtnUpdateDetailTK"
        Me.BtnUpdateDetailTK.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'CRealKirim
        '
        Me.CRealKirim.AutoSize = True
        Me.CRealKirim.Enabled = False
        Me.CRealKirim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CRealKirim.Location = New System.Drawing.Point(10, 322)
        Me.CRealKirim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CRealKirim.Name = "CRealKirim"
        Me.CRealKirim.Size = New System.Drawing.Size(128, 23)
        Me.CRealKirim.TabIndex = 93
        Me.CRealKirim.Text = "Realisasi Kirim"
        Me.CRealKirim.UseVisualStyleBackColor = True
        '
        'CDeadKirim
        '
        Me.CDeadKirim.AutoSize = True
        Me.CDeadKirim.Enabled = False
        Me.CDeadKirim.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CDeadKirim.Location = New System.Drawing.Point(12, 255)
        Me.CDeadKirim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CDeadKirim.Name = "CDeadKirim"
        Me.CDeadKirim.Size = New System.Drawing.Size(130, 23)
        Me.CDeadKirim.TabIndex = 92
        Me.CDeadKirim.Text = "Deadline Kirim"
        Me.CDeadKirim.UseVisualStyleBackColor = True
        '
        'CRealImple
        '
        Me.CRealImple.AutoSize = True
        Me.CRealImple.Enabled = False
        Me.CRealImple.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CRealImple.Location = New System.Drawing.Point(325, 252)
        Me.CRealImple.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CRealImple.Name = "CRealImple"
        Me.CRealImple.Size = New System.Drawing.Size(182, 23)
        Me.CRealImple.TabIndex = 91
        Me.CRealImple.Text = "Realisasi Implementasi"
        Me.CRealImple.UseVisualStyleBackColor = True
        '
        'CRealSurvei
        '
        Me.CRealSurvei.AutoSize = True
        Me.CRealSurvei.Enabled = False
        Me.CRealSurvei.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CRealSurvei.Location = New System.Drawing.Point(12, 288)
        Me.CRealSurvei.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CRealSurvei.Name = "CRealSurvei"
        Me.CRealSurvei.Size = New System.Drawing.Size(135, 23)
        Me.CRealSurvei.TabIndex = 90
        Me.CRealSurvei.Text = "Realisasi Survei"
        Me.CRealSurvei.UseVisualStyleBackColor = True
        '
        'CRealTerimaBrg
        '
        Me.CRealTerimaBrg.AutoSize = True
        Me.CRealTerimaBrg.Enabled = False
        Me.CRealTerimaBrg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CRealTerimaBrg.Location = New System.Drawing.Point(325, 288)
        Me.CRealTerimaBrg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CRealTerimaBrg.Name = "CRealTerimaBrg"
        Me.CRealTerimaBrg.Size = New System.Drawing.Size(190, 23)
        Me.CRealTerimaBrg.TabIndex = 88
        Me.CRealTerimaBrg.Text = "Realisasi Terima Barang"
        Me.CRealTerimaBrg.UseVisualStyleBackColor = True
        '
        'DTDeadlineKirimTK
        '
        Me.DTDeadlineKirimTK.Enabled = False
        Me.DTDeadlineKirimTK.Location = New System.Drawing.Point(160, 248)
        Me.DTDeadlineKirimTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTDeadlineKirimTK.Name = "DTDeadlineKirimTK"
        Me.DTDeadlineKirimTK.Size = New System.Drawing.Size(147, 27)
        Me.DTDeadlineKirimTK.TabIndex = 86
        '
        'DTRealKirimTK
        '
        Me.DTRealKirimTK.Enabled = False
        Me.DTRealKirimTK.Location = New System.Drawing.Point(159, 318)
        Me.DTRealKirimTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTRealKirimTK.Name = "DTRealKirimTK"
        Me.DTRealKirimTK.Size = New System.Drawing.Size(147, 27)
        Me.DTRealKirimTK.TabIndex = 84
        '
        'TIDOrder
        '
        Me.TIDOrder.Location = New System.Drawing.Point(268, 69)
        Me.TIDOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TIDOrder.Name = "TIDOrder"
        Me.TIDOrder.Size = New System.Drawing.Size(38, 27)
        Me.TIDOrder.TabIndex = 83
        Me.TIDOrder.Visible = False
        '
        'BtnSimpanDetailTK
        '
        Me.BtnSimpanDetailTK.Caption = "SIMPAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DETAIL"
        Me.BtnSimpanDetailTK.Enabled = False
        Me.BtnSimpanDetailTK.Id = 1
        Me.BtnSimpanDetailTK.ImageOptions.SvgImage = CType(resources.GetObject("BtnSimpanDetailTK.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSimpanDetailTK.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red
        Me.BtnSimpanDetailTK.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White
        Me.BtnSimpanDetailTK.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.BtnSimpanDetailTK.ItemAppearance.Hovered.Options.UseForeColor = True
        Me.BtnSimpanDetailTK.Name = "BtnSimpanDetailTK"
        Me.BtnSimpanDetailTK.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnInsertDetail
        '
        Me.BtnInsertDetail.Caption = "INPUT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DETAIL"
        Me.BtnInsertDetail.Enabled = False
        Me.BtnInsertDetail.Id = 0
        Me.BtnInsertDetail.ImageOptions.SvgImage = CType(resources.GetObject("BtnInsertDetail.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnInsertDetail.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red
        Me.BtnInsertDetail.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White
        Me.BtnInsertDetail.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.BtnInsertDetail.ItemAppearance.Hovered.Options.UseForeColor = True
        Me.BtnInsertDetail.Name = "BtnInsertDetail"
        Me.BtnInsertDetail.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'TidToko
        '
        Me.TidToko.Location = New System.Drawing.Point(381, 69)
        Me.TidToko.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TidToko.Name = "TidToko"
        Me.TidToko.Size = New System.Drawing.Size(38, 27)
        Me.TidToko.TabIndex = 82
        Me.TidToko.Visible = False
        '
        'CSurvei
        '
        Me.CSurvei.AutoSize = True
        Me.CSurvei.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CSurvei.Location = New System.Drawing.Point(10, 177)
        Me.CSurvei.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CSurvei.Name = "CSurvei"
        Me.CSurvei.Size = New System.Drawing.Size(112, 23)
        Me.CSurvei.TabIndex = 81
        Me.CSurvei.Text = "ADA SURVEI"
        Me.CSurvei.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(5, 358)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 20)
        Me.Label25.TabIndex = 79
        Me.Label25.Text = "Keterangan"
        '
        'TKetTK
        '
        Me.TKetTK.Location = New System.Drawing.Point(139, 356)
        Me.TKetTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TKetTK.Name = "TKetTK"
        Me.TKetTK.Size = New System.Drawing.Size(479, 27)
        Me.TKetTK.TabIndex = 78
        '
        'DTTglTerima
        '
        Me.DTTglTerima.Enabled = False
        Me.DTTglTerima.Location = New System.Drawing.Point(521, 284)
        Me.DTTglTerima.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTTglTerima.Name = "DTTglTerima"
        Me.DTTglTerima.Size = New System.Drawing.Size(153, 27)
        Me.DTTglTerima.TabIndex = 76
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(321, 215)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(162, 19)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Deadline Implementasi"
        '
        'BtnCetakFrm
        '
        Me.BtnCetakFrm.Caption = "CETAK " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "F. REQ"
        Me.BtnCetakFrm.Enabled = False
        Me.BtnCetakFrm.Id = 3
        Me.BtnCetakFrm.ImageOptions.SvgImage = CType(resources.GetObject("BtnCetakFrm.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnCetakFrm.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Red
        Me.BtnCetakFrm.ItemAppearance.Hovered.ForeColor = System.Drawing.Color.White
        Me.BtnCetakFrm.ItemAppearance.Hovered.Options.UseBackColor = True
        Me.BtnCetakFrm.ItemAppearance.Hovered.Options.UseForeColor = True
        Me.BtnCetakFrm.Name = "BtnCetakFrm"
        Me.BtnCetakFrm.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar1
        '
        Me.Bar1.BarItemHorzIndent = 30
        Me.Bar1.BarName = "Tools Input Detail"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.FloatLocation = New System.Drawing.Point(-1150, 207)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnInsertDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnSimpanDetailTK), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnUpdateDetailTK), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnHapusBarang), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnCetakFrm), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BtnInsertDetail, Me.BtnSimpanDetailTK, Me.BtnUpdateDetailTK, Me.BtnCetakFrm, Me.BtnClose, Me.BtnHapusBarang})
        Me.BarManager1.MaxItemId = 8
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1223, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 525)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1223, 51)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 525)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1223, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 525)
        '
        'TIdKirimTK
        '
        Me.TIdKirimTK.Location = New System.Drawing.Point(467, 69)
        Me.TIdKirimTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TIdKirimTK.Name = "TIdKirimTK"
        Me.TIdKirimTK.Size = New System.Drawing.Size(38, 27)
        Me.TIdKirimTK.TabIndex = 80
        Me.TIdKirimTK.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBarang)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(243, 391)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(980, 134)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAFTAR BARANG"
        '
        'ListBarang
        '
        Me.ListBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBarang.Location = New System.Drawing.Point(3, 24)
        Me.ListBarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBarang.Name = "ListBarang"
        Me.ListBarang.Size = New System.Drawing.Size(974, 106)
        Me.ListBarang.TabIndex = 1
        Me.ListBarang.UseCompatibleStateImageBehavior = False
        '
        'DTDeadlineImpleTK
        '
        Me.DTDeadlineImpleTK.Enabled = False
        Me.DTDeadlineImpleTK.Location = New System.Drawing.Point(521, 209)
        Me.DTDeadlineImpleTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTDeadlineImpleTK.Name = "DTDeadlineImpleTK"
        Me.DTDeadlineImpleTK.Size = New System.Drawing.Size(153, 27)
        Me.DTDeadlineImpleTK.TabIndex = 72
        '
        'DTRealImpleTK
        '
        Me.DTRealImpleTK.Enabled = False
        Me.DTRealImpleTK.Location = New System.Drawing.Point(521, 246)
        Me.DTRealImpleTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTRealImpleTK.Name = "DTRealImpleTK"
        Me.DTRealImpleTK.Size = New System.Drawing.Size(153, 27)
        Me.DTRealImpleTK.TabIndex = 70
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(7, 215)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 19)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "Deadline Survei"
        '
        'DTDeadlineSurveiTK
        '
        Me.DTDeadlineSurveiTK.Enabled = False
        Me.DTDeadlineSurveiTK.Location = New System.Drawing.Point(160, 209)
        Me.DTDeadlineSurveiTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTDeadlineSurveiTK.Name = "DTDeadlineSurveiTK"
        Me.DTDeadlineSurveiTK.Size = New System.Drawing.Size(147, 27)
        Me.DTDeadlineSurveiTK.TabIndex = 68
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(549, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 20)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "QTY"
        '
        'TQtyPrd
        '
        Me.TQtyPrd.Location = New System.Drawing.Point(590, 137)
        Me.TQtyPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TQtyPrd.Name = "TQtyPrd"
        Me.TQtyPrd.Size = New System.Drawing.Size(32, 27)
        Me.TQtyPrd.TabIndex = 66
        Me.TQtyPrd.Text = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(467, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 20)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "SISI"
        '
        'TSPrd
        '
        Me.TSPrd.Location = New System.Drawing.Point(507, 137)
        Me.TSPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TSPrd.Name = "TSPrd"
        Me.TSPrd.Size = New System.Drawing.Size(32, 27)
        Me.TSPrd.TabIndex = 62
        Me.TSPrd.Text = "1"
        '
        'DTRealSurveiTK
        '
        Me.DTRealSurveiTK.Enabled = False
        Me.DTRealSurveiTK.Location = New System.Drawing.Point(159, 284)
        Me.DTRealSurveiTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTRealSurveiTK.Name = "DTRealSurveiTK"
        Me.DTRealSurveiTK.Size = New System.Drawing.Size(147, 27)
        Me.DTRealSurveiTK.TabIndex = 64
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(362, 141)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 20)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "LEBAR"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ListToko)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(243, 525)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "PILIH TOKO :"
        '
        'ListToko
        '
        Me.ListToko.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListToko.Location = New System.Drawing.Point(2, 29)
        Me.ListToko.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListToko.Name = "ListToko"
        Me.ListToko.Size = New System.Drawing.Size(239, 494)
        Me.ListToko.TabIndex = 1
        Me.ListToko.UseCompatibleStateImageBehavior = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.CRealKirim)
        Me.GroupControl2.Controls.Add(Me.CDeadKirim)
        Me.GroupControl2.Controls.Add(Me.CRealImple)
        Me.GroupControl2.Controls.Add(Me.CRealSurvei)
        Me.GroupControl2.Controls.Add(Me.CRealTerimaBrg)
        Me.GroupControl2.Controls.Add(Me.DTDeadlineKirimTK)
        Me.GroupControl2.Controls.Add(Me.DTRealKirimTK)
        Me.GroupControl2.Controls.Add(Me.TIDOrder)
        Me.GroupControl2.Controls.Add(Me.TidToko)
        Me.GroupControl2.Controls.Add(Me.CSurvei)
        Me.GroupControl2.Controls.Add(Me.TIdKirimTK)
        Me.GroupControl2.Controls.Add(Me.Label25)
        Me.GroupControl2.Controls.Add(Me.TKetTK)
        Me.GroupControl2.Controls.Add(Me.DTTglTerima)
        Me.GroupControl2.Controls.Add(Me.Label21)
        Me.GroupControl2.Controls.Add(Me.DTDeadlineImpleTK)
        Me.GroupControl2.Controls.Add(Me.DTRealImpleTK)
        Me.GroupControl2.Controls.Add(Me.Label20)
        Me.GroupControl2.Controls.Add(Me.DTDeadlineSurveiTK)
        Me.GroupControl2.Controls.Add(Me.Label19)
        Me.GroupControl2.Controls.Add(Me.TQtyPrd)
        Me.GroupControl2.Controls.Add(Me.DTRealSurveiTK)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.TSPrd)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.TLPrd)
        Me.GroupControl2.Controls.Add(Me.TPPrd)
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.TTPrd)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.TKotaTK)
        Me.GroupControl2.Controls.Add(Me.Label11)
        Me.GroupControl2.Controls.Add(Me.TNamaTK)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.TidBarangPrd)
        Me.GroupControl2.Controls.Add(Me.TidTrans)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.TBarangPrd)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(243, 0)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(980, 391)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "DETAIL TOKO :"
        '
        'TLPrd
        '
        Me.TLPrd.Location = New System.Drawing.Point(420, 137)
        Me.TLPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TLPrd.Name = "TLPrd"
        Me.TLPrd.Size = New System.Drawing.Size(32, 27)
        Me.TLPrd.TabIndex = 60
        Me.TLPrd.Text = "0"
        '
        'TPPrd
        '
        Me.TPPrd.Location = New System.Drawing.Point(206, 137)
        Me.TPPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TPPrd.Name = "TPPrd"
        Me.TPPrd.Size = New System.Drawing.Size(32, 27)
        Me.TPPrd.TabIndex = 59
        Me.TPPrd.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(252, 141)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "TINGGI"
        '
        'TTPrd
        '
        Me.TTPrd.Location = New System.Drawing.Point(310, 137)
        Me.TTPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TTPrd.Name = "TTPrd"
        Me.TTPrd.Size = New System.Drawing.Size(32, 27)
        Me.TTPrd.TabIndex = 57
        Me.TTPrd.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(384, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 20)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Kota"
        '
        'TKotaTK
        '
        Me.TKotaTK.Location = New System.Drawing.Point(467, 34)
        Me.TKotaTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TKotaTK.Name = "TKotaTK"
        Me.TKotaTK.ReadOnly = True
        Me.TKotaTK.Size = New System.Drawing.Size(153, 27)
        Me.TKotaTK.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 20)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Nama TOKO"
        '
        'TNamaTK
        '
        Me.TNamaTK.Location = New System.Drawing.Point(139, 34)
        Me.TNamaTK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TNamaTK.Name = "TNamaTK"
        Me.TNamaTK.ReadOnly = True
        Me.TNamaTK.Size = New System.Drawing.Size(216, 27)
        Me.TNamaTK.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(138, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "PANJANG"
        '
        'TidBarangPrd
        '
        Me.TidBarangPrd.Location = New System.Drawing.Point(539, 69)
        Me.TidBarangPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TidBarangPrd.Name = "TidBarangPrd"
        Me.TidBarangPrd.Size = New System.Drawing.Size(38, 27)
        Me.TidBarangPrd.TabIndex = 51
        Me.TidBarangPrd.Visible = False
        '
        'TidTrans
        '
        Me.TidTrans.Location = New System.Drawing.Point(587, 69)
        Me.TidTrans.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TidTrans.Name = "TidTrans"
        Me.TidTrans.Size = New System.Drawing.Size(38, 27)
        Me.TidTrans.TabIndex = 50
        Me.TidTrans.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Masukkan  Barang"
        '
        'TBarangPrd
        '
        Me.TBarangPrd.Location = New System.Drawing.Point(139, 105)
        Me.TBarangPrd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBarangPrd.Name = "TBarangPrd"
        Me.TBarangPrd.Size = New System.Drawing.Size(481, 27)
        Me.TBarangPrd.TabIndex = 48
        '
        'DetailToko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "DetailToko"
        Me.Size = New System.Drawing.Size(1223, 576)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnHapusBarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnUpdateDetailTK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CRealKirim As System.Windows.Forms.CheckBox
    Friend WithEvents CDeadKirim As System.Windows.Forms.CheckBox
    Friend WithEvents CRealImple As System.Windows.Forms.CheckBox
    Friend WithEvents CRealSurvei As System.Windows.Forms.CheckBox
    Friend WithEvents CRealTerimaBrg As System.Windows.Forms.CheckBox
    Friend WithEvents DTDeadlineKirimTK As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTRealKirimTK As System.Windows.Forms.DateTimePicker
    Friend WithEvents TIDOrder As System.Windows.Forms.TextBox
    Friend WithEvents BtnSimpanDetailTK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnInsertDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TidToko As System.Windows.Forms.TextBox
    Friend WithEvents CSurvei As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TKetTK As System.Windows.Forms.TextBox
    Friend WithEvents DTTglTerima As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BtnCetakFrm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBarang As System.Windows.Forms.ListView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ListToko As System.Windows.Forms.ListView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TIdKirimTK As System.Windows.Forms.TextBox
    Friend WithEvents DTDeadlineImpleTK As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTRealImpleTK As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DTDeadlineSurveiTK As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TQtyPrd As System.Windows.Forms.TextBox
    Friend WithEvents DTRealSurveiTK As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TSPrd As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TLPrd As System.Windows.Forms.TextBox
    Friend WithEvents TPPrd As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TTPrd As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TKotaTK As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TNamaTK As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TidBarangPrd As System.Windows.Forms.TextBox
    Friend WithEvents TidTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBarangPrd As System.Windows.Forms.TextBox

End Class
