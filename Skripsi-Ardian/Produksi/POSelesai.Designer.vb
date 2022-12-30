<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSelesai
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
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSelesai))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeadlineProduksi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKlien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidpo_prd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coliddtorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidstatus_proyek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltime_closhing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProduksiSelesai = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Query"
        Me.GridControl1.DataSource = Me.SqlDataSource1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(968, 354)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "127.0.0.1_skripsi_Connection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colHAL, Me.colBrand, Me.colDeadlineProduksi, Me.colKlien, Me.colidpo_prd, Me.coliddtorder, Me.colidstatus_proyek, Me.coltime_closhing, Me.colProduksiSelesai})
        Me.GridView1.DetailHeight = 357
        Me.GridView1.FixedLineWidth = 3
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "NOPE"
        Me.GridColumn1.MinWidth = 24
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 157
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "NOPO"
        Me.GridColumn2.MinWidth = 24
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 157
        '
        'colHAL
        '
        Me.colHAL.FieldName = "HAL"
        Me.colHAL.MinWidth = 24
        Me.colHAL.Name = "colHAL"
        Me.colHAL.Visible = True
        Me.colHAL.VisibleIndex = 2
        Me.colHAL.Width = 157
        '
        'colBrand
        '
        Me.colBrand.FieldName = "BRAND"
        Me.colBrand.MinWidth = 24
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 3
        Me.colBrand.Width = 157
        '
        'colDeadlineProduksi
        '
        Me.colDeadlineProduksi.FieldName = "DEADLINE_PRODUKSI"
        Me.colDeadlineProduksi.MinWidth = 24
        Me.colDeadlineProduksi.Name = "colDeadlineProduksi"
        Me.colDeadlineProduksi.Visible = True
        Me.colDeadlineProduksi.VisibleIndex = 4
        Me.colDeadlineProduksi.Width = 178
        '
        'colKlien
        '
        Me.colKlien.FieldName = "KLIEN"
        Me.colKlien.MinWidth = 24
        Me.colKlien.Name = "colKlien"
        Me.colKlien.Visible = True
        Me.colKlien.VisibleIndex = 5
        Me.colKlien.Width = 72
        '
        'colidpo_prd
        '
        Me.colidpo_prd.FieldName = "IDPO_PRD"
        Me.colidpo_prd.MinWidth = 24
        Me.colidpo_prd.Name = "colidpo_prd"
        Me.colidpo_prd.Width = 93
        '
        'coliddtorder
        '
        Me.coliddtorder.FieldName = "IDDTORDER"
        Me.coliddtorder.MinWidth = 24
        Me.coliddtorder.Name = "coliddtorder"
        Me.coliddtorder.Width = 93
        '
        'colidstatus_proyek
        '
        Me.colidstatus_proyek.FieldName = "IDSTATUS_PROYEK"
        Me.colidstatus_proyek.MinWidth = 24
        Me.colidstatus_proyek.Name = "colidstatus_proyek"
        Me.colidstatus_proyek.Width = 93
        '
        'coltime_closhing
        '
        Me.coltime_closhing.FieldName = "TIME_CLOSHING"
        Me.coltime_closhing.MinWidth = 24
        Me.coltime_closhing.Name = "coltime_closhing"
        Me.coltime_closhing.Width = 93
        '
        'colProduksiSelesai
        '
        Me.colProduksiSelesai.FieldName = "SELESAI PRODUKSi"
        Me.colProduksiSelesai.MinWidth = 24
        Me.colProduksiSelesai.Name = "colProduksiSelesai"
        Me.colProduksiSelesai.Visible = True
        Me.colProduksiSelesai.VisibleIndex = 6
        Me.colProduksiSelesai.Width = 222
        '
        'WindowsUIButtonPanel1
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.Image = CType(resources.GetObject("WindowsUIButtonImageOptions2.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions3.Image = CType(resources.GetObject("WindowsUIButtonImageOptions3.Image"), System.Drawing.Image)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("REFRESH", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CETAK", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("EXIT", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 354)
        Me.WindowsUIButtonPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(968, 97)
        Me.WindowsUIButtonPanel1.TabIndex = 3
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'POSelesai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "POSelesai"
        Me.Size = New System.Drawing.Size(968, 451)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeadlineProduksi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKlien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidpo_prd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coliddtorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidstatus_proyek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltime_closhing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduksiSelesai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

End Class
