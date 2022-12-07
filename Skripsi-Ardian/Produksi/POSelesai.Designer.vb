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
        Me.colidpe = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(847, 265)
        Me.GridControl1.TabIndex = 2
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colHAL, Me.colBrand, Me.colDeadlineProduksi, Me.colKlien, Me.colidpo_prd, Me.coliddtorder, Me.colidpe, Me.colidstatus_proyek, Me.coltime_closhing, Me.colProduksiSelesai})
        Me.GridView1.DetailHeight = 268
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "NO. PE"
        Me.GridColumn1.MinWidth = 21
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 81
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "NO. PO"
        Me.GridColumn2.MinWidth = 21
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 81
        '
        'colHAL
        '
        Me.colHAL.FieldName = "HAL"
        Me.colHAL.MinWidth = 21
        Me.colHAL.Name = "colHAL"
        Me.colHAL.Visible = True
        Me.colHAL.VisibleIndex = 2
        Me.colHAL.Width = 81
        '
        'colBrand
        '
        Me.colBrand.FieldName = "Brand"
        Me.colBrand.MinWidth = 21
        Me.colBrand.Name = "colBrand"
        Me.colBrand.Visible = True
        Me.colBrand.VisibleIndex = 3
        Me.colBrand.Width = 81
        '
        'colDeadlineProduksi
        '
        Me.colDeadlineProduksi.FieldName = "Deadline Produksi"
        Me.colDeadlineProduksi.MinWidth = 21
        Me.colDeadlineProduksi.Name = "colDeadlineProduksi"
        Me.colDeadlineProduksi.Visible = True
        Me.colDeadlineProduksi.VisibleIndex = 4
        Me.colDeadlineProduksi.Width = 81
        '
        'colKlien
        '
        Me.colKlien.FieldName = "Klien"
        Me.colKlien.MinWidth = 21
        Me.colKlien.Name = "colKlien"
        Me.colKlien.Visible = True
        Me.colKlien.VisibleIndex = 5
        Me.colKlien.Width = 81
        '
        'colidpo_prd
        '
        Me.colidpo_prd.FieldName = "idpo_prd"
        Me.colidpo_prd.MinWidth = 21
        Me.colidpo_prd.Name = "colidpo_prd"
        Me.colidpo_prd.Width = 81
        '
        'coliddtorder
        '
        Me.coliddtorder.FieldName = "iddtorder"
        Me.coliddtorder.MinWidth = 21
        Me.coliddtorder.Name = "coliddtorder"
        Me.coliddtorder.Width = 81
        '
        'colidpe
        '
        Me.colidpe.FieldName = "idpe"
        Me.colidpe.MinWidth = 21
        Me.colidpe.Name = "colidpe"
        Me.colidpe.Width = 81
        '
        'colidstatus_proyek
        '
        Me.colidstatus_proyek.FieldName = "idstatus_proyek"
        Me.colidstatus_proyek.MinWidth = 21
        Me.colidstatus_proyek.Name = "colidstatus_proyek"
        Me.colidstatus_proyek.Width = 81
        '
        'coltime_closhing
        '
        Me.coltime_closhing.FieldName = "time_closhing"
        Me.coltime_closhing.MinWidth = 21
        Me.coltime_closhing.Name = "coltime_closhing"
        Me.coltime_closhing.Width = 81
        '
        'colProduksiSelesai
        '
        Me.colProduksiSelesai.FieldName = "Produksi Selesai"
        Me.colProduksiSelesai.MinWidth = 21
        Me.colProduksiSelesai.Name = "colProduksiSelesai"
        Me.colProduksiSelesai.Visible = True
        Me.colProduksiSelesai.VisibleIndex = 6
        Me.colProduksiSelesai.Width = 81
        '
        'WindowsUIButtonPanel1
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.Image = CType(resources.GetObject("WindowsUIButtonImageOptions2.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions3.Image = CType(resources.GetObject("WindowsUIButtonImageOptions3.Image"), System.Drawing.Image)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("REFRESH", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("CETAK", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("EXIT", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 265)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(847, 73)
        Me.WindowsUIButtonPanel1.TabIndex = 3
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'POSelesai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.Name = "POSelesai"
        Me.Size = New System.Drawing.Size(847, 338)
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
    Friend WithEvents colidpe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidstatus_proyek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltime_closhing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProduksiSelesai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

End Class
