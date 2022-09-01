<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailDataOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailDataOrder))
        Dim CustomSqlQuery2 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim QueryParameter1 As DevExpress.DataAccess.Sql.QueryParameter = New DevExpress.DataAccess.Sql.QueryParameter()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim ButtonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Dim ButtonImageOptions2 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ListDetailDO = New System.Windows.Forms.ListView()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.FlyoutPanel1 = New DevExpress.Utils.FlyoutPanel()
        Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlyoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlyoutPanel1.SuspendLayout()
        CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl2)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.ListDetailDO)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.WindowsUIButtonPanel1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1190, 425)
        Me.SplitContainerControl1.SplitterPosition = 188
        Me.SplitContainerControl1.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Query"
        Me.GridControl2.DataSource = Me.SqlDataSource1
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1190, 188)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "Local_DBGeogivenVM"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "Query"
        CustomSqlQuery1.Sql = resources.GetString("CustomSqlQuery1.Sql")
        CustomSqlQuery2.Name = "DetailDO"
        QueryParameter1.Name = "iddtorder"
        QueryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
        QueryParameter1.Value = New DevExpress.DataAccess.Expression("?iddtorder", GetType(Integer))
        CustomSqlQuery2.Parameters.Add(QueryParameter1)
        CustomSqlQuery2.Sql = "select * from view_detaildo2 "
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1, CustomSqlQuery2})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66})
        Me.GridView3.DetailHeight = 262
        Me.GridView3.FixedLineWidth = 1
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView3.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.GridView3.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow
        Me.GridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "iddtorder"
        Me.GridColumn34.MinWidth = 22
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Width = 82
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "iddivisi"
        Me.GridColumn35.MinWidth = 22
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Width = 82
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "No. Order"
        Me.GridColumn36.FieldName = "noorder"
        Me.GridColumn36.MinWidth = 22
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 1
        Me.GridColumn36.Width = 67
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Tanggal"
        Me.GridColumn37.FieldName = "tglorder"
        Me.GridColumn37.MinWidth = 22
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 2
        Me.GridColumn37.Width = 68
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "idklien"
        Me.GridColumn38.MinWidth = 22
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Width = 82
        '
        'GridColumn39
        '
        Me.GridColumn39.FieldName = "idbrand"
        Me.GridColumn39.MinWidth = 22
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Width = 66
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Nama Order"
        Me.GridColumn40.FieldName = "namaorder"
        Me.GridColumn40.MinWidth = 22
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 3
        Me.GridColumn40.Width = 85
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Survei"
        Me.GridColumn41.FieldName = "survei"
        Me.GridColumn41.MinWidth = 22
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 7
        Me.GridColumn41.Width = 54
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "iddivisi_survei"
        Me.GridColumn42.MinWidth = 22
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Width = 101
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "deadline_survei"
        Me.GridColumn43.MinWidth = 22
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Width = 110
        '
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "status_kirim"
        Me.GridColumn44.MinWidth = 22
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Width = 88
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Deadline Kirim"
        Me.GridColumn45.FieldName = "deadline_ki"
        Me.GridColumn45.MinWidth = 22
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 8
        Me.GridColumn45.Width = 87
        '
        'GridColumn46
        '
        Me.GridColumn46.FieldName = "idstatus_proyek"
        Me.GridColumn46.MinWidth = 22
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Width = 111
        '
        'GridColumn47
        '
        Me.GridColumn47.FieldName = "deadline_design"
        Me.GridColumn47.MinWidth = 22
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Width = 115
        '
        'GridColumn48
        '
        Me.GridColumn48.FieldName = "selesai_design"
        Me.GridColumn48.MinWidth = 22
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.Width = 103
        '
        'GridColumn49
        '
        Me.GridColumn49.FieldName = "deadline_printing"
        Me.GridColumn49.MinWidth = 22
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Width = 122
        '
        'GridColumn50
        '
        Me.GridColumn50.FieldName = "selesai_printing"
        Me.GridColumn50.MinWidth = 22
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Width = 110
        '
        'GridColumn51
        '
        Me.GridColumn51.FieldName = "deadline_produksi"
        Me.GridColumn51.MinWidth = 22
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Width = 127
        '
        'GridColumn52
        '
        Me.GridColumn52.FieldName = "selesai_produksi"
        Me.GridColumn52.MinWidth = 22
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.Width = 115
        '
        'GridColumn53
        '
        Me.GridColumn53.FieldName = "user_input"
        Me.GridColumn53.MinWidth = 22
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.Width = 80
        '
        'GridColumn54
        '
        Me.GridColumn54.FieldName = "time_input"
        Me.GridColumn54.MinWidth = 22
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.Width = 82
        '
        'GridColumn55
        '
        Me.GridColumn55.FieldName = "user_koreksi"
        Me.GridColumn55.MinWidth = 22
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.Width = 90
        '
        'GridColumn56
        '
        Me.GridColumn56.FieldName = "time_koreksi"
        Me.GridColumn56.MinWidth = 22
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.Width = 93
        '
        'GridColumn57
        '
        Me.GridColumn57.FieldName = "revisi"
        Me.GridColumn57.MinWidth = 22
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.Width = 51
        '
        'GridColumn58
        '
        Me.GridColumn58.FieldName = "user_batal"
        Me.GridColumn58.MinWidth = 22
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.Width = 80
        '
        'GridColumn59
        '
        Me.GridColumn59.FieldName = "time_batal"
        Me.GridColumn59.MinWidth = 22
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.Width = 82
        '
        'GridColumn60
        '
        Me.GridColumn60.FieldName = "alasan_batal"
        Me.GridColumn60.MinWidth = 22
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.Width = 93
        '
        'GridColumn61
        '
        Me.GridColumn61.FieldName = "time_closing"
        Me.GridColumn61.MinWidth = 22
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.Width = 94
        '
        'GridColumn62
        '
        Me.GridColumn62.FieldName = "sim_code"
        Me.GridColumn62.MinWidth = 22
        Me.GridColumn62.Name = "GridColumn62"
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "Klien"
        Me.GridColumn63.FieldName = "nmklien"
        Me.GridColumn63.MinWidth = 22
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 4
        Me.GridColumn63.Width = 66
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Brand"
        Me.GridColumn64.FieldName = "brand"
        Me.GridColumn64.MinWidth = 22
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 5
        Me.GridColumn64.Width = 55
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Divisi"
        Me.GridColumn65.FieldName = "divisi"
        Me.GridColumn65.MinWidth = 22
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 6
        Me.GridColumn65.Width = 51
        '
        'GridColumn66
        '
        Me.GridColumn66.FieldName = "idtrans"
        Me.GridColumn66.MinWidth = 22
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.Width = 60
        '
        'ListDetailDO
        '
        Me.ListDetailDO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDetailDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListDetailDO.GridLines = True
        Me.ListDetailDO.Location = New System.Drawing.Point(0, 0)
        Me.ListDetailDO.Name = "ListDetailDO"
        Me.ListDetailDO.Size = New System.Drawing.Size(1082, 231)
        Me.ListDetailDO.TabIndex = 90
        Me.ListDetailDO.UseCompatibleStateImageBehavior = False
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.BackColor = System.Drawing.Color.SteelBlue
        WindowsUIButtonImageOptions1.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions1.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        WindowsUIButtonImageOptions2.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        WindowsUIButtonImageOptions3.SvgImage = CType(resources.GetObject("WindowsUIButtonImageOptions3.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Detail D.O", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Keluar", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(1082, 0)
        Me.WindowsUIButtonPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(108, 231)
        Me.WindowsUIButtonPanel1.TabIndex = 0
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'FlyoutPanel1
        '
        Me.FlyoutPanel1.Controls.Add(Me.FlyoutPanelControl1)
        Me.FlyoutPanel1.Location = New System.Drawing.Point(60, 26)
        Me.FlyoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlyoutPanel1.Name = "FlyoutPanel1"
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelHeight = 34
        Me.FlyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom
        ButtonImageOptions2.SvgImage = CType(resources.GetObject("ButtonImageOptions2.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.FlyoutPanel1.OptionsButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.Utils.PeekFormButton("|", True, ButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, False, Nothing, True, False, True, Nothing, -1, False), New DevExpress.Utils.PeekFormButton("Tutup", True, ButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, "Tutup", -1, False)})
        Me.FlyoutPanel1.OptionsButtonPanel.ShowButtonPanel = True
        Me.FlyoutPanel1.OwnerControl = Me
        Me.FlyoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 34)
        Me.FlyoutPanel1.Size = New System.Drawing.Size(1017, 378)
        Me.FlyoutPanel1.TabIndex = 2
        '
        'FlyoutPanelControl1
        '
        Me.FlyoutPanelControl1.AutoSize = True
        Me.FlyoutPanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel1
        Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.FlyoutPanelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
        Me.FlyoutPanelControl1.Size = New System.Drawing.Size(1017, 344)
        Me.FlyoutPanelControl1.TabIndex = 0
        '
        'DetailDataOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlyoutPanel1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DetailDataOrder"
        Me.Size = New System.Drawing.Size(1190, 425)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlyoutPanel1,System.ComponentModel.ISupportInitialize).EndInit
        Me.FlyoutPanel1.ResumeLayout(false)
        Me.FlyoutPanel1.PerformLayout
        CType(Me.FlyoutPanelControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents FlyoutPanel1 As DevExpress.Utils.FlyoutPanel
    Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents ListDetailDO As System.Windows.Forms.ListView

End Class
