<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POProduksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POProduksi))
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnHapus = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSelesai = New DevExpress.XtraEditors.SimpleButton()
        Me.ListPekerja = New System.Windows.Forms.ListView()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.ListManpower = New System.Windows.Forms.ListView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colidpo_prd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnopo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidklien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collokasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnope = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeadline_produksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colselesai_produksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeadline_desain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colselesai_desain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeadline_printing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colselesai_printing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldeadline_ki = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltime_closhing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkirim_po = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colproses_po = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colterima_po = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkirim_ppic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidpe = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coliddivisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colklien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus_kirimpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcatatan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnAcc = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnRevisi = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnKeluar = New DevExpress.XtraEditors.SimpleButton()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.RadioGroup()
        Me.ListBarang = New System.Windows.Forms.ListView()
        Me.BtnDaftar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddWorker = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupConfirm = New System.Windows.Forms.GroupBox()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CheckActivitas = New System.Windows.Forms.CheckedListBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DTStart = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ListPacking = New System.Windows.Forms.ListView()
        Me.BtnKonfirmasi = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupConfirm.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.BtnHapus)
        Me.LayoutControl1.Controls.Add(Me.BtnClose)
        Me.LayoutControl1.Controls.Add(Me.BtnEdit)
        Me.LayoutControl1.Controls.Add(Me.BtnSelesai)
        Me.LayoutControl1.Controls.Add(Me.ListPekerja)
        Me.LayoutControl1.Controls.Add(Me.BtnExit)
        Me.LayoutControl1.Controls.Add(Me.ListManpower)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.BtnAcc)
        Me.LayoutControl1.Controls.Add(Me.BtnRevisi)
        Me.LayoutControl1.Controls.Add(Me.BtnKeluar)
        Me.LayoutControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.LayoutControl1.Controls.Add(Me.ListBarang)
        Me.LayoutControl1.Controls.Add(Me.BtnDaftar)
        Me.LayoutControl1.Controls.Add(Me.BtnRefresh)
        Me.LayoutControl1.Controls.Add(Me.BtnAddWorker)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-794, 0, 683, 720)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(841, 371)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(345, 300)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(155, 22)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 16
        Me.SimpleButton2.Text = "REFRESH"
        '
        'BtnHapus
        '
        Me.BtnHapus.ImageOptions.Image = CType(resources.GetObject("BtnHapus.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnHapus.Location = New System.Drawing.Point(186, 300)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(155, 22)
        Me.BtnHapus.StyleController = Me.LayoutControl1
        Me.BtnHapus.TabIndex = 15
        Me.BtnHapus.Text = "HAPUS"
        '
        'BtnClose
        '
        Me.BtnClose.ImageOptions.Image = CType(resources.GetObject("BtnClose.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(27, 300)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(155, 22)
        Me.BtnClose.StyleController = Me.LayoutControl1
        Me.BtnClose.TabIndex = 14
        Me.BtnClose.Text = "TUTUP"
        '
        'BtnEdit
        '
        Me.BtnEdit.ImageOptions.Image = CType(resources.GetObject("BtnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(666, 300)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(152, 22)
        Me.BtnEdit.StyleController = Me.LayoutControl1
        Me.BtnEdit.TabIndex = 13
        Me.BtnEdit.Text = "GANTI MANPOWER"
        '
        'BtnSelesai
        '
        Me.BtnSelesai.ImageOptions.Image = CType(resources.GetObject("BtnSelesai.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSelesai.Location = New System.Drawing.Point(504, 300)
        Me.BtnSelesai.Name = "BtnSelesai"
        Me.BtnSelesai.Size = New System.Drawing.Size(158, 22)
        Me.BtnSelesai.StyleController = Me.LayoutControl1
        Me.BtnSelesai.TabIndex = 12
        Me.BtnSelesai.Text = "SELESAIKAN PEKERJAAN"
        '
        'ListPekerja
        '
        Me.ListPekerja.Location = New System.Drawing.Point(27, 45)
        Me.ListPekerja.Name = "ListPekerja"
        Me.ListPekerja.Size = New System.Drawing.Size(791, 251)
        Me.ListPekerja.TabIndex = 11
        Me.ListPekerja.UseCompatibleStateImageBehavior = False
        '
        'BtnExit
        '
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnExit.ImageOptions.Image = CType(resources.GetObject("BtnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(27, 300)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(791, 22)
        Me.BtnExit.StyleController = Me.LayoutControl1
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "KELUAR"
        '
        'ListManpower
        '
        Me.ListManpower.Location = New System.Drawing.Point(424, 45)
        Me.ListManpower.Name = "ListManpower"
        Me.ListManpower.Size = New System.Drawing.Size(394, 199)
        Me.ListManpower.TabIndex = 9
        Me.ListManpower.UseCompatibleStateImageBehavior = False
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Query"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Location = New System.Drawing.Point(27, 27)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(791, 242)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_geogiven_vm_Connection-Kantor"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colidpo_prd, Me.colnopo, Me.colidklien, Me.coltanggal, Me.collokasi, Me.colbrand, Me.colnope, Me.coldeadline_produksi, Me.colselesai_produksi, Me.coldeadline_desain, Me.colselesai_desain, Me.coldeadline_printing, Me.colselesai_printing, Me.coldeadline_ki, Me.coltime_closhing, Me.colkirim_po, Me.colproses_po, Me.colterima_po, Me.colkirim_ppic, Me.colidpe, Me.coliddivisi, Me.colklien, Me.colstatus_kirimpo, Me.colcatatan})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colidpo_prd
        '
        Me.colidpo_prd.FieldName = "idpo_prd"
        Me.colidpo_prd.Name = "colidpo_prd"
        '
        'colnopo
        '
        Me.colnopo.Caption = "NO. PO"
        Me.colnopo.FieldName = "nopo"
        Me.colnopo.Name = "colnopo"
        Me.colnopo.Visible = True
        Me.colnopo.VisibleIndex = 0
        '
        'colidklien
        '
        Me.colidklien.FieldName = "idklien"
        Me.colidklien.Name = "colidklien"
        '
        'coltanggal
        '
        Me.coltanggal.Caption = "TANGGAL"
        Me.coltanggal.FieldName = "tanggal"
        Me.coltanggal.Name = "coltanggal"
        Me.coltanggal.Visible = True
        Me.coltanggal.VisibleIndex = 1
        '
        'collokasi
        '
        Me.collokasi.Caption = "LOKASI"
        Me.collokasi.FieldName = "lokasi"
        Me.collokasi.Name = "collokasi"
        Me.collokasi.Visible = True
        Me.collokasi.VisibleIndex = 4
        '
        'colbrand
        '
        Me.colbrand.Caption = "BRAND"
        Me.colbrand.FieldName = "brand"
        Me.colbrand.Name = "colbrand"
        Me.colbrand.Visible = True
        Me.colbrand.VisibleIndex = 3
        '
        'colnope
        '
        Me.colnope.Caption = "NO. PE"
        Me.colnope.FieldName = "nope"
        Me.colnope.Name = "colnope"
        Me.colnope.Visible = True
        Me.colnope.VisibleIndex = 5
        '
        'coldeadline_produksi
        '
        Me.coldeadline_produksi.Caption = "DEADLINE"
        Me.coldeadline_produksi.FieldName = "deadline_produksi"
        Me.coldeadline_produksi.Name = "coldeadline_produksi"
        Me.coldeadline_produksi.Visible = True
        Me.coldeadline_produksi.VisibleIndex = 6
        '
        'colselesai_produksi
        '
        Me.colselesai_produksi.FieldName = "selesai_produksi"
        Me.colselesai_produksi.Name = "colselesai_produksi"
        '
        'coldeadline_desain
        '
        Me.coldeadline_desain.FieldName = "deadline_desain"
        Me.coldeadline_desain.Name = "coldeadline_desain"
        '
        'colselesai_desain
        '
        Me.colselesai_desain.FieldName = "selesai_desain"
        Me.colselesai_desain.Name = "colselesai_desain"
        '
        'coldeadline_printing
        '
        Me.coldeadline_printing.FieldName = "deadline_printing"
        Me.coldeadline_printing.Name = "coldeadline_printing"
        '
        'colselesai_printing
        '
        Me.colselesai_printing.FieldName = "selesai_printing"
        Me.colselesai_printing.Name = "colselesai_printing"
        '
        'coldeadline_ki
        '
        Me.coldeadline_ki.Caption = "DEADLINE KIRIM"
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
        'colproses_po
        '
        Me.colproses_po.FieldName = "proses_po"
        Me.colproses_po.Name = "colproses_po"
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
        'colidpe
        '
        Me.colidpe.FieldName = "idpe"
        Me.colidpe.Name = "colidpe"
        '
        'coliddivisi
        '
        Me.coliddivisi.FieldName = "iddivisi"
        Me.coliddivisi.Name = "coliddivisi"
        '
        'colklien
        '
        Me.colklien.Caption = "KLIEN"
        Me.colklien.FieldName = "klien"
        Me.colklien.Name = "colklien"
        Me.colklien.Visible = True
        Me.colklien.VisibleIndex = 2
        '
        'colstatus_kirimpo
        '
        Me.colstatus_kirimpo.FieldName = "status_kirimpo"
        Me.colstatus_kirimpo.Name = "colstatus_kirimpo"
        '
        'colcatatan
        '
        Me.colcatatan.Caption = "CATATAN"
        Me.colcatatan.FieldName = "catatan"
        Me.colcatatan.Name = "colcatatan"
        Me.colcatatan.Visible = True
        Me.colcatatan.VisibleIndex = 8
        '
        'BtnAcc
        '
        Me.BtnAcc.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnAcc.Location = New System.Drawing.Point(592, 273)
        Me.BtnAcc.Name = "BtnAcc"
        Me.BtnAcc.Size = New System.Drawing.Size(66, 23)
        Me.BtnAcc.StyleController = Me.LayoutControl1
        Me.BtnAcc.TabIndex = 4
        Me.BtnAcc.Text = "TERIMA"
        '
        'BtnRevisi
        '
        Me.BtnRevisi.DialogResult = System.Windows.Forms.DialogResult.No
        Me.BtnRevisi.Location = New System.Drawing.Point(672, 273)
        Me.BtnRevisi.Name = "BtnRevisi"
        Me.BtnRevisi.Size = New System.Drawing.Size(66, 23)
        Me.BtnRevisi.StyleController = Me.LayoutControl1
        Me.BtnRevisi.TabIndex = 5
        Me.BtnRevisi.Text = "REVISI"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnKeluar.Location = New System.Drawing.Point(752, 273)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(66, 23)
        Me.BtnKeluar.StyleController = Me.LayoutControl1
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "KELUAR"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(171, 273)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "TERIMA PO. PRODUKSI", True, Nothing, "TERIMA PO. PRODUKSI"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "PROSES PO. PRODUKSI", True, Nothing, "PROSES PO. PRODUKSI"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "PRODUKSI SELESAI", True, Nothing, "PRODUKSI SELESAI")})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(417, 49)
        Me.ComboBoxEdit1.StyleController = Me.LayoutControl1
        Me.ComboBoxEdit1.TabIndex = 8
        '
        'ListBarang
        '
        Me.ListBarang.Location = New System.Drawing.Point(27, 45)
        Me.ListBarang.Name = "ListBarang"
        Me.ListBarang.Size = New System.Drawing.Size(393, 199)
        Me.ListBarang.TabIndex = 7
        Me.ListBarang.UseCompatibleStateImageBehavior = False
        '
        'BtnDaftar
        '
        Me.BtnDaftar.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnDaftar.ImageOptions.Image = CType(resources.GetObject("BtnDaftar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnDaftar.Location = New System.Drawing.Point(592, 300)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(226, 22)
        Me.BtnDaftar.StyleController = Me.LayoutControl1
        Me.BtnDaftar.TabIndex = 4
        Me.BtnDaftar.Text = "LIHAT ALOKASI PEKERJA"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnRefresh.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.BtnRefresh.ImageOptions.Image = CType(resources.GetObject("BtnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(27, 248)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(791, 22)
        Me.BtnRefresh.StyleController = Me.LayoutControl1
        Me.BtnRefresh.TabIndex = 5
        Me.BtnRefresh.Text = "REFRESH"
        '
        'BtnAddWorker
        '
        Me.BtnAddWorker.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAddWorker.ImageOptions.Image = CType(resources.GetObject("BtnAddWorker.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAddWorker.Location = New System.Drawing.Point(27, 274)
        Me.BtnAddWorker.Name = "BtnAddWorker"
        Me.BtnAddWorker.Size = New System.Drawing.Size(791, 22)
        Me.BtnAddWorker.StyleController = Me.LayoutControl1
        Me.BtnAddWorker.TabIndex = 6
        Me.BtnAddWorker.Text = "TAMBAH PEKERJA"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(652, 254)
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(841, 371)
        Me.Root.TextVisible = False
        '
        'tabbedControlGroup1
        '
        Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
        Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
        Me.tabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
        Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup4
        Me.tabbedControlGroup1.Size = New System.Drawing.Size(821, 351)
        Me.tabbedControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, -2, 2, 0)
        Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlGroup4, Me.LayoutControlGroup2})
        Me.tabbedControlGroup1.Text = "Daftar Alokasi Pekerjaan"
        Me.tabbedControlGroup1.TextLocation = DevExpress.Utils.Locations.Bottom
        '
        'layoutControlGroup4
        '
        Me.layoutControlGroup4.CustomizationFormText = "Tab2"
        Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem7, Me.LayoutControlItem10})
        Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup4.Name = "layoutControlGroup4"
        Me.layoutControlGroup4.Size = New System.Drawing.Size(795, 299)
        Me.layoutControlGroup4.Text = "Alokasi Man Power"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ListBarang
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "DAFTAR BARANG/TOKO"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(397, 221)
        Me.LayoutControlItem6.Text = "DAFTAR BARANG/TOKO"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(141, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.BtnRefresh
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "layoutControlItem2"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 221)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(795, 26)
        Me.LayoutControlItem9.Text = "layoutControlItem2"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.BtnExit
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 273)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(795, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.ListManpower
        Me.LayoutControlItem7.Location = New System.Drawing.Point(397, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(398, 221)
        Me.LayoutControlItem7.Text = "Daftar Manpower"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(141, 15)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.BtnAddWorker
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "layoutControlItem3"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 247)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(795, 26)
        Me.LayoutControlItem10.Text = "layoutControlItem3"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'layoutControlGroup3
        '
        Me.layoutControlGroup3.CustomizationFormText = "Tab1"
        Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.emptySpaceItem3, Me.emptySpaceItem2, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.LayoutControlItem8})
        Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup3.Name = "layoutControlGroup3"
        Me.layoutControlGroup3.Size = New System.Drawing.Size(795, 299)
        Me.layoutControlGroup3.Text = "Terima PO"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(795, 246)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.BtnAcc
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "layoutControlItem1"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(565, 246)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "layoutControlItem1"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.BtnRevisi
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "layoutControlItem2"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(645, 246)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "layoutControlItem2"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'emptySpaceItem3
        '
        Me.emptySpaceItem3.AllowHotTrack = False
        Me.emptySpaceItem3.CustomizationFormText = "emptySpaceItem1"
        Me.emptySpaceItem3.Location = New System.Drawing.Point(715, 246)
        Me.emptySpaceItem3.MaxSize = New System.Drawing.Size(10, 27)
        Me.emptySpaceItem3.MinSize = New System.Drawing.Size(10, 27)
        Me.emptySpaceItem3.Name = "emptySpaceItem3"
        Me.emptySpaceItem3.Size = New System.Drawing.Size(10, 27)
        Me.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.emptySpaceItem3.Text = "emptySpaceItem1"
        Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'emptySpaceItem2
        '
        Me.emptySpaceItem2.AllowHotTrack = False
        Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
        Me.emptySpaceItem2.Location = New System.Drawing.Point(635, 246)
        Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(10, 27)
        Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 27)
        Me.emptySpaceItem2.Name = "emptySpaceItem2"
        Me.emptySpaceItem2.Size = New System.Drawing.Size(10, 27)
        Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.BtnKeluar
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "layoutControlItem3"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(725, 246)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(70, 27)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "layoutControlItem3"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlItem2.Control = Me.ComboBoxEdit1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 246)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(565, 53)
        Me.LayoutControlItem2.Text = "Pilih Aksi :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(141, 15)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.BtnDaftar
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "layoutControlItem1"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(565, 273)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(230, 26)
        Me.LayoutControlItem8.Text = "layoutControlItem1"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(795, 299)
        Me.LayoutControlGroup2.Text = "Daftar Pekerja"
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.ListPekerja
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(795, 273)
        Me.LayoutControlItem12.Text = "DAFTAR ALOKASI PEKERJA"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(141, 15)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.BtnSelesai
        Me.LayoutControlItem13.Location = New System.Drawing.Point(477, 273)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(162, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.BtnEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(639, 273)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(156, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.BtnClose
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 273)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.BtnHapus
        Me.LayoutControlItem16.Location = New System.Drawing.Point(159, 273)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SimpleButton2
        Me.LayoutControlItem17.Location = New System.Drawing.Point(318, 273)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(159, 26)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'GroupConfirm
        '
        Me.GroupConfirm.BackColor = System.Drawing.Color.Red
        Me.GroupConfirm.Controls.Add(Me.SplitContainerControl1)
        Me.GroupConfirm.Controls.Add(Me.BtnKonfirmasi)
        Me.GroupConfirm.Controls.Add(Me.SimpleButton1)
        Me.GroupConfirm.Location = New System.Drawing.Point(160, 119)
        Me.GroupConfirm.Name = "GroupConfirm"
        Me.GroupConfirm.Size = New System.Drawing.Size(258, 180)
        Me.GroupConfirm.TabIndex = 11
        Me.GroupConfirm.TabStop = False
        Me.GroupConfirm.Text = "Konfirmasi Input Data"
        Me.GroupConfirm.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(3, 19)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CheckActivitas)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(252, 112)
        Me.SplitContainerControl1.SplitterPosition = 285
        Me.SplitContainerControl1.TabIndex = 0
        '
        'CheckActivitas
        '
        Me.CheckActivitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckActivitas.FormattingEnabled = True
        Me.CheckActivitas.Location = New System.Drawing.Point(0, 103)
        Me.CheckActivitas.Name = "CheckActivitas"
        Me.CheckActivitas.Size = New System.Drawing.Size(246, 9)
        Me.CheckActivitas.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.DTStart)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(246, 103)
        Me.PanelControl1.TabIndex = 0
        '
        'DTStart
        '
        Me.DTStart.Location = New System.Drawing.Point(109, 43)
        Me.DTStart.Name = "DTStart"
        Me.DTStart.Size = New System.Drawing.Size(127, 23)
        Me.DTStart.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(109, 28)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(6, 15)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "0"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(109, 7)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(6, 15)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "0"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(98, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(3, 15)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ":"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(100, 28)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(3, 15)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = ":"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(100, 49)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(3, 15)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(3, 82)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(186, 15)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "TENTUKAN AKTIFITAS PEKERJAAN :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 49)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 15)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "TANGGAL"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(89, 15)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "BARANG DIPILIH"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(87, 15)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "PEKERJA DIPILIH"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ListPacking)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(0, 0)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Material Packing"
        '
        'ListPacking
        '
        Me.ListPacking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPacking.Location = New System.Drawing.Point(0, 21)
        Me.ListPacking.Name = "ListPacking"
        Me.ListPacking.Size = New System.Drawing.Size(0, 0)
        Me.ListPacking.TabIndex = 0
        Me.ListPacking.UseCompatibleStateImageBehavior = False
        '
        'BtnKonfirmasi
        '
        Me.BtnKonfirmasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnKonfirmasi.ImageOptions.Image = CType(resources.GetObject("BtnKonfirmasi.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnKonfirmasi.Location = New System.Drawing.Point(3, 131)
        Me.BtnKonfirmasi.Name = "BtnKonfirmasi"
        Me.BtnKonfirmasi.Size = New System.Drawing.Size(252, 23)
        Me.BtnKonfirmasi.TabIndex = 1
        Me.BtnKonfirmasi.Text = "KONFIRMASI"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 154)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(252, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "TUTUP"
        '
        'POProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupConfirm)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "POProduksi"
        Me.Size = New System.Drawing.Size(841, 371)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupConfirm.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents colidpo_prd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnopo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidklien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collokasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnope As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeadline_produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colselesai_produksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeadline_desain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colselesai_desain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeadline_printing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colselesai_printing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldeadline_ki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltime_closhing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkirim_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproses_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colterima_po As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkirim_ppic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidpe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coliddivisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colklien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus_kirimpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcatatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnAcc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRevisi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnKeluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListManpower As System.Windows.Forms.ListView
    Friend WithEvents ListBarang As System.Windows.Forms.ListView
    Friend WithEvents BtnDaftar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddWorker As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupConfirm As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents CheckActivitas As System.Windows.Forms.CheckedListBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DTStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ListPacking As System.Windows.Forms.ListView
    Friend WithEvents BtnKonfirmasi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnHapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSelesai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListPekerja As System.Windows.Forms.ListView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem

End Class
