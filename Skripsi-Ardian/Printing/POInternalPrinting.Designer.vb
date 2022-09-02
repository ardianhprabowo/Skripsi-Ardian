<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POInternalPrinting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POInternalPrinting))
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar2 = New DevExpress.XtraBars.Bar()
        Me.BtnTerimaPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnPOSelesai = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnTutup = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListPOPrt = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListDetailPrt = New System.Windows.Forms.ListView()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BtnTerimaPrint, Me.BtnPOSelesai, Me.BtnTutup})
        Me.barManager1.MainMenu = Me.bar2
        Me.barManager1.MaxItemId = 3
        '
        'bar2
        '
        Me.bar2.BarItemVertIndent = 7
        Me.bar2.BarName = "Main menu"
        Me.bar2.DockCol = 0
        Me.bar2.DockRow = 0
        Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BtnTerimaPrint), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnPOSelesai), New DevExpress.XtraBars.LinkPersistInfo(Me.BtnTutup)})
        Me.bar2.OptionsBar.AllowQuickCustomization = False
        Me.bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None
        Me.bar2.OptionsBar.DisableCustomization = True
        Me.bar2.OptionsBar.DrawBorder = False
        Me.bar2.OptionsBar.MultiLine = True
        Me.bar2.OptionsBar.UseWholeRow = True
        Me.bar2.Text = "Main menu"
        '
        'BtnTerimaPrint
        '
        Me.BtnTerimaPrint.Caption = "Terima PO"
        Me.BtnTerimaPrint.Id = 0
        Me.BtnTerimaPrint.ImageOptions.SvgImage = CType(resources.GetObject("BtnTerimaPrint.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnTerimaPrint.Name = "BtnTerimaPrint"
        Me.BtnTerimaPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnPOSelesai
        '
        Me.BtnPOSelesai.Caption = "SELESAI PROSES"
        Me.BtnPOSelesai.Id = 1
        Me.BtnPOSelesai.ImageOptions.SvgImage = CType(resources.GetObject("BtnPOSelesai.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnPOSelesai.Name = "BtnPOSelesai"
        Me.BtnPOSelesai.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BtnTutup
        '
        Me.BtnTutup.Caption = "TUTUP"
        Me.BtnTutup.Id = 2
        Me.BtnTutup.ImageOptions.SvgImage = CType(resources.GetObject("BtnTutup.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(905, 37)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 474)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(905, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 37)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 437)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(905, 37)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 437)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 37)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(905, 437)
        Me.SplitContainer1.SplitterDistance = 455
        Me.SplitContainer1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListPOPrt)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 437)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PO. Printing"
        '
        'ListPOPrt
        '
        Me.ListPOPrt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListPOPrt.Location = New System.Drawing.Point(3, 19)
        Me.ListPOPrt.Name = "ListPOPrt"
        Me.ListPOPrt.Size = New System.Drawing.Size(449, 415)
        Me.ListPOPrt.TabIndex = 0
        Me.ListPOPrt.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListDetailPrt)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(446, 437)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail PO. Printing"
        '
        'ListDetailPrt
        '
        Me.ListDetailPrt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListDetailPrt.Location = New System.Drawing.Point(3, 19)
        Me.ListDetailPrt.Name = "ListDetailPrt"
        Me.ListDetailPrt.Size = New System.Drawing.Size(440, 415)
        Me.ListDetailPrt.TabIndex = 2
        Me.ListDetailPrt.UseCompatibleStateImageBehavior = False
        '
        'POInternalPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "POInternalPrinting"
        Me.Size = New System.Drawing.Size(905, 474)
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BtnTerimaPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnPOSelesai As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnTutup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListPOPrt As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListDetailPrt As System.Windows.Forms.ListView

End Class
