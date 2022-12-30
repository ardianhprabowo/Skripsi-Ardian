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
        Dim CustomSqlQuery3 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.RBTerima = New System.Windows.Forms.CheckBox()
        Me.RBSelesai = New System.Windows.Forms.CheckBox()
        Me.RBProses = New System.Windows.Forms.CheckBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnHapus = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.ListPekerja = New System.Windows.Forms.ListView()
        Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
        Me.ListManpower = New System.Windows.Forms.ListView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPO_PRD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTANGGAL_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOKASI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEADLINE_PRODUKSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSELESAI_PRODUKSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEADLINE_DESAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSELESAI_DESAIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEADLINE_PRINTING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSELESAI_PRINTING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIME_CLOSHING = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROSES_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTERIMA_PO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREGION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBRAND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSTATUS_PROYEK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKLIEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colstatus_kirimpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDdtorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BtnAcc = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnKeluar = New DevExpress.XtraEditors.SimpleButton()
        Me.ListBarang = New System.Windows.Forms.ListView()
        Me.BtnDaftar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddWorker = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GroupConfirm = New System.Windows.Forms.GroupBox()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CheckActivitas = New System.Windows.Forms.CheckedListBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TNIK = New System.Windows.Forms.TextBox()
        Me.TidDtorder = New System.Windows.Forms.TextBox()
        Me.TidPOprd = New System.Windows.Forms.TextBox()
        Me.TidAct_po = New System.Windows.Forms.TextBox()
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
        Me.GroupPacking = New DevExpress.XtraEditors.GroupControl()
        Me.ListPacking = New System.Windows.Forms.ListView()
        Me.BtnKonfirmasi = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupEdit = New System.Windows.Forms.GroupBox()
        Me.TidAktifitas = New System.Windows.Forms.TextBox()
        Me.BtnTutupEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSimpanEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEditStart = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CManpower = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CAktifitas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTEnd = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEditEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupConfirm.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupPacking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPacking.SuspendLayout()
        Me.GroupEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.RBTerima)
        Me.LayoutControl1.Controls.Add(Me.RBSelesai)
        Me.LayoutControl1.Controls.Add(Me.RBProses)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.BtnHapus)
        Me.LayoutControl1.Controls.Add(Me.BtnEdit)
        Me.LayoutControl1.Controls.Add(Me.ListPekerja)
        Me.LayoutControl1.Controls.Add(Me.BtnExit)
        Me.LayoutControl1.Controls.Add(Me.ListManpower)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.BtnAcc)
        Me.LayoutControl1.Controls.Add(Me.BtnKeluar)
        Me.LayoutControl1.Controls.Add(Me.ListBarang)
        Me.LayoutControl1.Controls.Add(Me.BtnDaftar)
        Me.LayoutControl1.Controls.Add(Me.BtnRefresh)
        Me.LayoutControl1.Controls.Add(Me.BtnAddWorker)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1})
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(0, 0, 683, 720)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1253, 652)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'RBTerima
        '
        Me.RBTerima.Checked = True
        Me.RBTerima.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RBTerima.Location = New System.Drawing.Point(29, 537)
        Me.RBTerima.Name = "RBTerima"
        Me.RBTerima.Size = New System.Drawing.Size(236, 25)
        Me.RBTerima.TabIndex = 19
        Me.RBTerima.Text = "TERIMA P.O"
        Me.RBTerima.UseVisualStyleBackColor = True
        '
        'RBSelesai
        '
        Me.RBSelesai.Location = New System.Drawing.Point(509, 537)
        Me.RBSelesai.Name = "RBSelesai"
        Me.RBSelesai.Size = New System.Drawing.Size(237, 25)
        Me.RBSelesai.TabIndex = 18
        Me.RBSelesai.Text = "SELESAI P.O"
        Me.RBSelesai.UseVisualStyleBackColor = True
        '
        'RBProses
        '
        Me.RBProses.Location = New System.Drawing.Point(269, 537)
        Me.RBProses.Name = "RBProses"
        Me.RBProses.Size = New System.Drawing.Size(236, 25)
        Me.RBProses.TabIndex = 17
        Me.RBProses.Text = "PROSES P.O"
        Me.RBProses.UseVisualStyleBackColor = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(430, 566)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(397, 27)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 16
        Me.SimpleButton2.Text = "REFRESH"
        '
        'BtnHapus
        '
        Me.BtnHapus.ImageOptions.Image = CType(resources.GetObject("BtnHapus.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnHapus.Location = New System.Drawing.Point(29, 566)
        Me.BtnHapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(397, 27)
        Me.BtnHapus.StyleController = Me.LayoutControl1
        Me.BtnHapus.TabIndex = 15
        Me.BtnHapus.Text = "HAPUS"
        '
        'BtnEdit
        '
        Me.BtnEdit.ImageOptions.Image = CType(resources.GetObject("BtnEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(831, 566)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(397, 27)
        Me.BtnEdit.StyleController = Me.LayoutControl1
        Me.BtnEdit.TabIndex = 13
        Me.BtnEdit.Text = "GANTI MANPOWER"
        '
        'ListPekerja
        '
        Me.ListPekerja.Location = New System.Drawing.Point(29, 55)
        Me.ListPekerja.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListPekerja.Name = "ListPekerja"
        Me.ListPekerja.Size = New System.Drawing.Size(1199, 507)
        Me.ListPekerja.TabIndex = 11
        Me.ListPekerja.UseCompatibleStateImageBehavior = False
        '
        'BtnExit
        '
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnExit.ImageOptions.Image = CType(resources.GetObject("BtnExit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(29, 566)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(1199, 27)
        Me.BtnExit.StyleController = Me.LayoutControl1
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "KELUAR"
        '
        'ListManpower
        '
        Me.ListManpower.Enabled = False
        Me.ListManpower.Location = New System.Drawing.Point(630, 55)
        Me.ListManpower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListManpower.Name = "ListManpower"
        Me.ListManpower.Size = New System.Drawing.Size(598, 445)
        Me.ListManpower.TabIndex = 9
        Me.ListManpower.UseCompatibleStateImageBehavior = False
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Query"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GridControl1.Location = New System.Drawing.Point(29, 32)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1199, 501)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "127.0.0.1_skripsi_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery3.Name = "Query"
        CustomSqlQuery3.Sql = resources.GetString("CustomSqlQuery3.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery3})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPO_PRD, Me.colNOPO, Me.colTANGGAL_PO, Me.colLOKASI, Me.colDEADLINE_PRODUKSI, Me.colSELESAI_PRODUKSI, Me.colDEADLINE_DESAIN, Me.colSELESAI_DESAIN, Me.colDEADLINE_PRINTING, Me.colSELESAI_PRINTING, Me.colTIME_CLOSHING, Me.colPROSES_PO, Me.colTERIMA_PO, Me.colREGION, Me.colBRAND, Me.colNOPE, Me.colIDSTATUS_PROYEK, Me.colKLIEN, Me.colstatus_kirimpo, Me.colIDdtorder})
        Me.GridView1.DetailHeight = 467
        Me.GridView1.FixedLineWidth = 3
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'colIDPO_PRD
        '
        Me.colIDPO_PRD.FieldName = "IDPO_PRD"
        Me.colIDPO_PRD.MinWidth = 25
        Me.colIDPO_PRD.Name = "colIDPO_PRD"
        Me.colIDPO_PRD.Width = 94
        '
        'colNOPO
        '
        Me.colNOPO.Caption = "NO. PO"
        Me.colNOPO.FieldName = "NOPO"
        Me.colNOPO.MinWidth = 25
        Me.colNOPO.Name = "colNOPO"
        Me.colNOPO.Visible = True
        Me.colNOPO.VisibleIndex = 1
        Me.colNOPO.Width = 94
        '
        'colTANGGAL_PO
        '
        Me.colTANGGAL_PO.Caption = "TANGGAL"
        Me.colTANGGAL_PO.FieldName = "TANGGAL_PO"
        Me.colTANGGAL_PO.MinWidth = 25
        Me.colTANGGAL_PO.Name = "colTANGGAL_PO"
        Me.colTANGGAL_PO.Visible = True
        Me.colTANGGAL_PO.VisibleIndex = 4
        Me.colTANGGAL_PO.Width = 94
        '
        'colLOKASI
        '
        Me.colLOKASI.Caption = "LOKASI"
        Me.colLOKASI.FieldName = "LOKASI"
        Me.colLOKASI.MinWidth = 25
        Me.colLOKASI.Name = "colLOKASI"
        Me.colLOKASI.Visible = True
        Me.colLOKASI.VisibleIndex = 5
        Me.colLOKASI.Width = 94
        '
        'colDEADLINE_PRODUKSI
        '
        Me.colDEADLINE_PRODUKSI.Caption = "DEADLINE"
        Me.colDEADLINE_PRODUKSI.FieldName = "DEADLINE_PRODUKSI"
        Me.colDEADLINE_PRODUKSI.MinWidth = 25
        Me.colDEADLINE_PRODUKSI.Name = "colDEADLINE_PRODUKSI"
        Me.colDEADLINE_PRODUKSI.Visible = True
        Me.colDEADLINE_PRODUKSI.VisibleIndex = 6
        Me.colDEADLINE_PRODUKSI.Width = 94
        '
        'colSELESAI_PRODUKSI
        '
        Me.colSELESAI_PRODUKSI.FieldName = "SELESAI_PRODUKSI"
        Me.colSELESAI_PRODUKSI.MinWidth = 25
        Me.colSELESAI_PRODUKSI.Name = "colSELESAI_PRODUKSI"
        Me.colSELESAI_PRODUKSI.Width = 94
        '
        'colDEADLINE_DESAIN
        '
        Me.colDEADLINE_DESAIN.FieldName = "DEADLINE_DESAIN"
        Me.colDEADLINE_DESAIN.MinWidth = 25
        Me.colDEADLINE_DESAIN.Name = "colDEADLINE_DESAIN"
        Me.colDEADLINE_DESAIN.Width = 94
        '
        'colSELESAI_DESAIN
        '
        Me.colSELESAI_DESAIN.FieldName = "SELESAI_DESAIN"
        Me.colSELESAI_DESAIN.MinWidth = 25
        Me.colSELESAI_DESAIN.Name = "colSELESAI_DESAIN"
        Me.colSELESAI_DESAIN.Width = 94
        '
        'colDEADLINE_PRINTING
        '
        Me.colDEADLINE_PRINTING.FieldName = "DEADLINE_PRINTING"
        Me.colDEADLINE_PRINTING.MinWidth = 25
        Me.colDEADLINE_PRINTING.Name = "colDEADLINE_PRINTING"
        Me.colDEADLINE_PRINTING.Width = 94
        '
        'colSELESAI_PRINTING
        '
        Me.colSELESAI_PRINTING.FieldName = "SELESAI_PRINTING"
        Me.colSELESAI_PRINTING.MinWidth = 25
        Me.colSELESAI_PRINTING.Name = "colSELESAI_PRINTING"
        Me.colSELESAI_PRINTING.Width = 94
        '
        'colTIME_CLOSHING
        '
        Me.colTIME_CLOSHING.FieldName = "TIME_CLOSHING"
        Me.colTIME_CLOSHING.MinWidth = 25
        Me.colTIME_CLOSHING.Name = "colTIME_CLOSHING"
        Me.colTIME_CLOSHING.Width = 94
        '
        'colPROSES_PO
        '
        Me.colPROSES_PO.FieldName = "PROSES_PO"
        Me.colPROSES_PO.MinWidth = 25
        Me.colPROSES_PO.Name = "colPROSES_PO"
        Me.colPROSES_PO.Width = 94
        '
        'colTERIMA_PO
        '
        Me.colTERIMA_PO.FieldName = "TERIMA_PO"
        Me.colTERIMA_PO.MinWidth = 25
        Me.colTERIMA_PO.Name = "colTERIMA_PO"
        Me.colTERIMA_PO.Visible = True
        Me.colTERIMA_PO.VisibleIndex = 7
        Me.colTERIMA_PO.Width = 94
        '
        'colREGION
        '
        Me.colREGION.Caption = "REGION"
        Me.colREGION.FieldName = "REGION"
        Me.colREGION.MinWidth = 25
        Me.colREGION.Name = "colREGION"
        Me.colREGION.Visible = True
        Me.colREGION.VisibleIndex = 8
        Me.colREGION.Width = 94
        '
        'colBRAND
        '
        Me.colBRAND.Caption = "BRAND"
        Me.colBRAND.FieldName = "BRAND"
        Me.colBRAND.MinWidth = 25
        Me.colBRAND.Name = "colBRAND"
        Me.colBRAND.Visible = True
        Me.colBRAND.VisibleIndex = 3
        Me.colBRAND.Width = 94
        '
        'colNOPE
        '
        Me.colNOPE.FieldName = "NOPE"
        Me.colNOPE.MinWidth = 25
        Me.colNOPE.Name = "colNOPE"
        Me.colNOPE.Visible = True
        Me.colNOPE.VisibleIndex = 9
        Me.colNOPE.Width = 94
        '
        'colIDSTATUS_PROYEK
        '
        Me.colIDSTATUS_PROYEK.FieldName = "IDSTATUS_PROYEK"
        Me.colIDSTATUS_PROYEK.MinWidth = 25
        Me.colIDSTATUS_PROYEK.Name = "colIDSTATUS_PROYEK"
        Me.colIDSTATUS_PROYEK.Width = 94
        '
        'colKLIEN
        '
        Me.colKLIEN.Caption = "KLIEN"
        Me.colKLIEN.FieldName = "KLIEN"
        Me.colKLIEN.MinWidth = 25
        Me.colKLIEN.Name = "colKLIEN"
        Me.colKLIEN.Visible = True
        Me.colKLIEN.VisibleIndex = 2
        Me.colKLIEN.Width = 94
        '
        'colstatus_kirimpo
        '
        Me.colstatus_kirimpo.Caption = "STATUS P.O"
        Me.colstatus_kirimpo.FieldName = "status_kirimpo"
        Me.colstatus_kirimpo.MinWidth = 25
        Me.colstatus_kirimpo.Name = "colstatus_kirimpo"
        Me.colstatus_kirimpo.Visible = True
        Me.colstatus_kirimpo.VisibleIndex = 10
        Me.colstatus_kirimpo.Width = 94
        '
        'colIDdtorder
        '
        Me.colIDdtorder.Caption = "GridColumn1"
        Me.colIDdtorder.FieldName = "IDDTORDER"
        Me.colIDdtorder.MinWidth = 25
        Me.colIDdtorder.Name = "colIDdtorder"
        Me.colIDdtorder.Width = 94
        '
        'BtnAcc
        '
        Me.BtnAcc.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnAcc.ImageOptions.Image = CType(resources.GetObject("BtnAcc.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAcc.Location = New System.Drawing.Point(750, 537)
        Me.BtnAcc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAcc.Name = "BtnAcc"
        Me.BtnAcc.Size = New System.Drawing.Size(237, 56)
        Me.BtnAcc.StyleController = Me.LayoutControl1
        Me.BtnAcc.TabIndex = 4
        Me.BtnAcc.Text = "TERIMA"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnKeluar.ImageOptions.Image = CType(resources.GetObject("BtnKeluar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnKeluar.Location = New System.Drawing.Point(991, 537)
        Me.BtnKeluar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(237, 56)
        Me.BtnKeluar.StyleController = Me.LayoutControl1
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "KELUAR"
        '
        'ListBarang
        '
        Me.ListBarang.Enabled = False
        Me.ListBarang.Location = New System.Drawing.Point(29, 55)
        Me.ListBarang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBarang.Name = "ListBarang"
        Me.ListBarang.Size = New System.Drawing.Size(597, 445)
        Me.ListBarang.TabIndex = 7
        Me.ListBarang.UseCompatibleStateImageBehavior = False
        '
        'BtnDaftar
        '
        Me.BtnDaftar.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnDaftar.Enabled = False
        Me.BtnDaftar.ImageOptions.Image = CType(resources.GetObject("BtnDaftar.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnDaftar.Location = New System.Drawing.Point(29, 566)
        Me.BtnDaftar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnDaftar.Name = "BtnDaftar"
        Me.BtnDaftar.Size = New System.Drawing.Size(717, 27)
        Me.BtnDaftar.StyleController = Me.LayoutControl1
        Me.BtnDaftar.TabIndex = 4
        Me.BtnDaftar.Text = "LIHAT ALOKASI PEKERJA"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.No
        Me.BtnRefresh.DialogResult = System.Windows.Forms.DialogResult.Retry
        Me.BtnRefresh.ImageOptions.Image = CType(resources.GetObject("BtnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(29, 504)
        Me.BtnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(1199, 27)
        Me.BtnRefresh.StyleController = Me.LayoutControl1
        Me.BtnRefresh.TabIndex = 5
        Me.BtnRefresh.Text = "REFRESH"
        '
        'BtnAddWorker
        '
        Me.BtnAddWorker.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAddWorker.Enabled = False
        Me.BtnAddWorker.ImageOptions.Image = CType(resources.GetObject("BtnAddWorker.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnAddWorker.Location = New System.Drawing.Point(29, 535)
        Me.BtnAddWorker.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAddWorker.Name = "BtnAddWorker"
        Me.BtnAddWorker.Size = New System.Drawing.Size(1199, 27)
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
        Me.Root.Size = New System.Drawing.Size(1253, 652)
        Me.Root.TextVisible = False
        '
        'tabbedControlGroup1
        '
        Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
        Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
        Me.tabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 12, 12)
        Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup3
        Me.tabbedControlGroup1.Size = New System.Drawing.Size(1233, 632)
        Me.tabbedControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, -2, 3, 0)
        Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlGroup4, Me.LayoutControlGroup2})
        Me.tabbedControlGroup1.Text = "Daftar Alokasi Pekerjaan"
        Me.tabbedControlGroup1.TextLocation = DevExpress.Utils.Locations.Bottom
        '
        'layoutControlGroup3
        '
        Me.layoutControlGroup3.CustomizationFormText = "Tab1"
        Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem19, Me.LayoutControlItem18, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem3})
        Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup3.Name = "layoutControlGroup3"
        Me.layoutControlGroup3.Size = New System.Drawing.Size(1203, 565)
        Me.layoutControlGroup3.Text = "Terima PO"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1203, 505)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.BtnKeluar
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "layoutControlItem3"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(962, 505)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(241, 60)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(241, 60)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(241, 60)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "layoutControlItem3"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.RBTerima
        Me.LayoutControlItem19.Location = New System.Drawing.Point(0, 505)
        Me.LayoutControlItem19.Name = "LayoutControlItem19"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(240, 29)
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem19.TextVisible = False
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.RBSelesai
        Me.LayoutControlItem18.Location = New System.Drawing.Point(480, 505)
        Me.LayoutControlItem18.Name = "LayoutControlItem18"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(241, 29)
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem18.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.RBProses
        Me.LayoutControlItem4.Location = New System.Drawing.Point(240, 505)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(240, 29)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.BtnDaftar
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "layoutControlItem1"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 534)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(196, 31)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(721, 31)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "layoutControlItem1"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.BtnAcc
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "layoutControlItem1"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(721, 505)
        Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(241, 60)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(241, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(241, 60)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "layoutControlItem1"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'layoutControlGroup4
        '
        Me.layoutControlGroup4.CustomizationFormText = "Tab2"
        Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem7, Me.LayoutControlItem10})
        Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup4.Name = "layoutControlGroup4"
        Me.layoutControlGroup4.Size = New System.Drawing.Size(1203, 565)
        Me.layoutControlGroup4.Text = "Alokasi Man Power"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ListBarang
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "DAFTAR BARANG/TOKO"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(601, 472)
        Me.LayoutControlItem6.Text = "DAFTAR BARANG/TOKO"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(179, 20)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.BtnRefresh
        Me.LayoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem9.CustomizationFormText = "layoutControlItem2"
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 472)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1203, 31)
        Me.LayoutControlItem9.Text = "layoutControlItem2"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.BtnExit
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 534)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(1203, 31)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.ListManpower
        Me.LayoutControlItem7.Location = New System.Drawing.Point(601, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(602, 472)
        Me.LayoutControlItem7.Text = "Daftar Manpower"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(179, 20)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.BtnAddWorker
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "layoutControlItem3"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 503)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(1203, 31)
        Me.LayoutControlItem10.Text = "layoutControlItem3"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Left
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Tab3"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem12, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1203, 565)
        Me.LayoutControlGroup2.Text = "Daftar Pekerja"
        Me.LayoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.ListPekerja
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(1203, 534)
        Me.LayoutControlItem12.Text = "DAFTAR ALOKASI PEKERJA"
        Me.LayoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(179, 20)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.BtnEdit
        Me.LayoutControlItem14.Location = New System.Drawing.Point(802, 534)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(401, 31)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.BtnHapus
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 534)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(401, 31)
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem16.TextVisible = False
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.SimpleButton2
        Me.LayoutControlItem17.Location = New System.Drawing.Point(401, 534)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(401, 31)
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem17.TextVisible = False
        '
        'GroupConfirm
        '
        Me.GroupConfirm.BackColor = System.Drawing.Color.Red
        Me.GroupConfirm.Controls.Add(Me.SplitContainerControl1)
        Me.GroupConfirm.Controls.Add(Me.BtnKonfirmasi)
        Me.GroupConfirm.Controls.Add(Me.SimpleButton1)
        Me.GroupConfirm.Location = New System.Drawing.Point(183, 36)
        Me.GroupConfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupConfirm.Name = "GroupConfirm"
        Me.GroupConfirm.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupConfirm.Size = New System.Drawing.Size(708, 492)
        Me.GroupConfirm.TabIndex = 11
        Me.GroupConfirm.TabStop = False
        Me.GroupConfirm.Text = "Konfirmasi Input Data"
        Me.GroupConfirm.Visible = False
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(3, 24)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.CheckActivitas)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupPacking)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(702, 402)
        Me.SplitContainerControl1.SplitterPosition = 326
        Me.SplitContainerControl1.TabIndex = 0
        '
        'CheckActivitas
        '
        Me.CheckActivitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckActivitas.FormattingEnabled = True
        Me.CheckActivitas.Location = New System.Drawing.Point(0, 181)
        Me.CheckActivitas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckActivitas.Name = "CheckActivitas"
        Me.CheckActivitas.Size = New System.Drawing.Size(326, 221)
        Me.CheckActivitas.TabIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.DTEnd)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.TNIK)
        Me.PanelControl1.Controls.Add(Me.TidDtorder)
        Me.PanelControl1.Controls.Add(Me.TidPOprd)
        Me.PanelControl1.Controls.Add(Me.TidAct_po)
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
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(326, 181)
        Me.PanelControl1.TabIndex = 0
        '
        'TNIK
        '
        Me.TNIK.Location = New System.Drawing.Point(246, 9)
        Me.TNIK.Name = "TNIK"
        Me.TNIK.Size = New System.Drawing.Size(46, 27)
        Me.TNIK.TabIndex = 13
        '
        'TidDtorder
        '
        Me.TidDtorder.Location = New System.Drawing.Point(206, 136)
        Me.TidDtorder.Name = "TidDtorder"
        Me.TidDtorder.Size = New System.Drawing.Size(53, 27)
        Me.TidDtorder.TabIndex = 12
        Me.TidDtorder.Visible = False
        '
        'TidPOprd
        '
        Me.TidPOprd.Location = New System.Drawing.Point(265, 136)
        Me.TidPOprd.Name = "TidPOprd"
        Me.TidPOprd.Size = New System.Drawing.Size(53, 27)
        Me.TidPOprd.TabIndex = 11
        Me.TidPOprd.Visible = False
        '
        'TidAct_po
        '
        Me.TidAct_po.Location = New System.Drawing.Point(194, 9)
        Me.TidAct_po.Name = "TidAct_po"
        Me.TidAct_po.Size = New System.Drawing.Size(46, 27)
        Me.TidAct_po.TabIndex = 10
        '
        'DTStart
        '
        Me.DTStart.Location = New System.Drawing.Point(147, 60)
        Me.DTStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTStart.Name = "DTStart"
        Me.DTStart.Size = New System.Drawing.Size(145, 27)
        Me.DTStart.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(146, 37)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(8, 20)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "0"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(148, 9)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(8, 20)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "0"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(135, 9)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ":"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(135, 37)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = ":"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(133, 65)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = ":"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 143)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(236, 20)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "TENTUKAN AKTIFITAS PEKERJAAN :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(6, 65)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 20)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "TANGGAL MULAI"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 37)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "BARANG DIPILIH"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 9)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "PEKERJA DIPILIH"
        '
        'GroupPacking
        '
        Me.GroupPacking.Controls.Add(Me.ListPacking)
        Me.GroupPacking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPacking.Location = New System.Drawing.Point(0, 0)
        Me.GroupPacking.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupPacking.Name = "GroupPacking"
        Me.GroupPacking.Size = New System.Drawing.Size(369, 402)
        Me.GroupPacking.TabIndex = 0
        Me.GroupPacking.Text = "Material Packing"
        '
        'ListPacking
        '
        Me.ListPacking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPacking.Location = New System.Drawing.Point(2, 29)
        Me.ListPacking.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListPacking.Name = "ListPacking"
        Me.ListPacking.Size = New System.Drawing.Size(365, 371)
        Me.ListPacking.TabIndex = 0
        Me.ListPacking.UseCompatibleStateImageBehavior = False
        '
        'BtnKonfirmasi
        '
        Me.BtnKonfirmasi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnKonfirmasi.ImageOptions.Image = CType(resources.GetObject("BtnKonfirmasi.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnKonfirmasi.Location = New System.Drawing.Point(3, 426)
        Me.BtnKonfirmasi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnKonfirmasi.Name = "BtnKonfirmasi"
        Me.BtnKonfirmasi.Size = New System.Drawing.Size(702, 31)
        Me.BtnKonfirmasi.TabIndex = 1
        Me.BtnKonfirmasi.Text = "KONFIRMASI"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(3, 457)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(702, 31)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "TUTUP"
        '
        'GroupEdit
        '
        Me.GroupEdit.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupEdit.Controls.Add(Me.BtnTutupEdit)
        Me.GroupEdit.Controls.Add(Me.BtnSimpanEdit)
        Me.GroupEdit.Controls.Add(Me.DateEditEnd)
        Me.GroupEdit.Controls.Add(Me.Label1)
        Me.GroupEdit.Controls.Add(Me.TidAktifitas)
        Me.GroupEdit.Controls.Add(Me.DateEditStart)
        Me.GroupEdit.Controls.Add(Me.Label10)
        Me.GroupEdit.Controls.Add(Me.CManpower)
        Me.GroupEdit.Controls.Add(Me.Label9)
        Me.GroupEdit.Controls.Add(Me.CAktifitas)
        Me.GroupEdit.Controls.Add(Me.Label5)
        Me.GroupEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupEdit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupEdit.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.GroupEdit.Location = New System.Drawing.Point(361, 149)
        Me.GroupEdit.Name = "GroupEdit"
        Me.GroupEdit.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupEdit.Size = New System.Drawing.Size(541, 285)
        Me.GroupEdit.TabIndex = 20
        Me.GroupEdit.TabStop = False
        Me.GroupEdit.Text = "GANTI MANPOWER"
        Me.GroupEdit.Visible = False
        '
        'TidAktifitas
        '
        Me.TidAktifitas.Location = New System.Drawing.Point(470, 12)
        Me.TidAktifitas.Name = "TidAktifitas"
        Me.TidAktifitas.Size = New System.Drawing.Size(46, 30)
        Me.TidAktifitas.TabIndex = 15
        Me.TidAktifitas.Visible = False
        '
        'BtnTutupEdit
        '
        Me.BtnTutupEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnTutupEdit.Appearance.Options.UseFont = True
        Me.BtnTutupEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnTutupEdit.ImageOptions.Image = CType(resources.GetObject("BtnTutupEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnTutupEdit.Location = New System.Drawing.Point(6, 239)
        Me.BtnTutupEdit.Name = "BtnTutupEdit"
        Me.BtnTutupEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnTutupEdit.Size = New System.Drawing.Size(189, 40)
        Me.BtnTutupEdit.TabIndex = 14
        Me.BtnTutupEdit.Text = "BATAL"
        '
        'BtnSimpanEdit
        '
        Me.BtnSimpanEdit.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSimpanEdit.Appearance.Options.UseFont = True
        Me.BtnSimpanEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSimpanEdit.ImageOptions.Image = CType(resources.GetObject("BtnSimpanEdit.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnSimpanEdit.Location = New System.Drawing.Point(346, 239)
        Me.BtnSimpanEdit.Name = "BtnSimpanEdit"
        Me.BtnSimpanEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.BtnSimpanEdit.Size = New System.Drawing.Size(189, 40)
        Me.BtnSimpanEdit.TabIndex = 13
        Me.BtnSimpanEdit.Text = "SIMPAN"
        '
        'DateEditStart
        '
        Me.DateEditStart.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateEditStart.Location = New System.Drawing.Point(6, 156)
        Me.DateEditStart.Name = "DateEditStart"
        Me.DateEditStart.Size = New System.Drawing.Size(529, 30)
        Me.DateEditStart.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(6, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "TANGGAL MULAI"
        '
        'CManpower
        '
        Me.CManpower.Dock = System.Windows.Forms.DockStyle.Top
        Me.CManpower.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.CManpower.FormattingEnabled = True
        Me.CManpower.Location = New System.Drawing.Point(6, 104)
        Me.CManpower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CManpower.Name = "CManpower"
        Me.CManpower.Size = New System.Drawing.Size(529, 29)
        Me.CManpower.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "NAMA PEKERJA"
        '
        'CAktifitas
        '
        Me.CAktifitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.CAktifitas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAktifitas.FormattingEnabled = True
        Me.CAktifitas.Location = New System.Drawing.Point(6, 52)
        Me.CAktifitas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CAktifitas.Name = "CAktifitas"
        Me.CAktifitas.Size = New System.Drawing.Size(529, 29)
        Me.CAktifitas.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "AKTIFITAS"
        '
        'DTEnd
        '
        Me.DTEnd.Location = New System.Drawing.Point(146, 95)
        Me.DTEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTEnd.Name = "DTEnd"
        Me.DTEnd.Size = New System.Drawing.Size(145, 27)
        Me.DTEnd.TabIndex = 16
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(132, 100)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(3, 20)
        Me.LabelControl10.TabIndex = 15
        Me.LabelControl10.Text = ":"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(5, 100)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(123, 20)
        Me.LabelControl11.TabIndex = 14
        Me.LabelControl11.Text = "TANGGAL SELESAI"
        '
        'DateEditEnd
        '
        Me.DateEditEnd.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateEditEnd.Location = New System.Drawing.Point(6, 209)
        Me.DateEditEnd.Name = "DateEditEnd"
        Me.DateEditEnd.Size = New System.Drawing.Size(529, 30)
        Me.DateEditEnd.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "TANGGAL MULAI"
        '
        'POProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupEdit)
        Me.Controls.Add(Me.GroupConfirm)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "POProduksi"
        Me.Size = New System.Drawing.Size(1253, 652)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupConfirm.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupPacking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPacking.ResumeLayout(False)
        Me.GroupEdit.ResumeLayout(False)
        Me.GroupEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents BtnAcc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnKeluar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents tabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents GroupPacking As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ListPacking As System.Windows.Forms.ListView
    Friend WithEvents BtnKonfirmasi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnHapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ListPekerja As System.Windows.Forms.ListView
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colIDPO_PRD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTANGGAL_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOKASI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEADLINE_PRODUKSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSELESAI_PRODUKSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEADLINE_DESAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSELESAI_DESAIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEADLINE_PRINTING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSELESAI_PRINTING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIME_CLOSHING As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROSES_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERIMA_PO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREGION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBRAND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSTATUS_PROYEK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKLIEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstatus_kirimpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDdtorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TidAct_po As System.Windows.Forms.TextBox
    Friend WithEvents TidDtorder As System.Windows.Forms.TextBox
    Friend WithEvents TidPOprd As System.Windows.Forms.TextBox
    Friend WithEvents RBTerima As System.Windows.Forms.CheckBox
    Friend WithEvents RBSelesai As System.Windows.Forms.CheckBox
    Friend WithEvents RBProses As System.Windows.Forms.CheckBox
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupEdit As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTutupEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSimpanEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEditStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CManpower As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CAktifitas As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TNIK As System.Windows.Forms.TextBox
    Friend WithEvents TidAktifitas As System.Windows.Forms.TextBox
    Friend WithEvents DTEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEditEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
