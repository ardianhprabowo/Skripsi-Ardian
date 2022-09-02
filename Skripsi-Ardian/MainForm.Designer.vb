<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordAccount = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.User_viewProfil = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.User_logout = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordMarketing = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Marketing_DataOrder = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator1 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.Marketing_DetailDO = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordDesain = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Desain_InternalPO = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordPrinting = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Printing_InternalPO = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordProduksi = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Produksi_InternalPO = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Produksi_AlokasiManpower = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.Produksi_ListPOSelesai = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.FluentDesignFormControl1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl()
        Me.FluentFormDefaultManager1 = New DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(Me.components)
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(273, 26)
        Me.FluentDesignFormContainer1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(859, 424)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'AccordionControl1
        '
        Me.AccordionControl1.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None
        Me.AccordionControl1.Appearance.AccordionControl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordAccount, Me.AccordMarketing, Me.AccordDesain, Me.AccordPrinting, Me.AccordProduksi, Me.AccordionControlElement1})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 26)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Overlay
        Me.AccordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always
        Me.AccordionControl1.Size = New System.Drawing.Size(273, 424)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'AccordAccount
        '
        Me.AccordAccount.Appearance.Normal.Options.UseTextOptions = True
        Me.AccordAccount.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccordAccount.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AccordAccount.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.User_viewProfil, Me.User_logout})
        Me.AccordAccount.Expanded = True
        Me.AccordAccount.HeaderIndent = 60
        Me.AccordAccount.Height = 90
        Me.AccordAccount.ImageOptions.Image = CType(resources.GetObject("AccordAccount.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordAccount.Name = "AccordAccount"
        Me.AccordAccount.Text = "Belum Login"
        '
        'User_viewProfil
        '
        Me.User_viewProfil.ImageOptions.Image = CType(resources.GetObject("User_viewProfil.ImageOptions.Image"), System.Drawing.Image)
        Me.User_viewProfil.Name = "User_viewProfil"
        Me.User_viewProfil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.User_viewProfil.Text = "View Profile"
        '
        'User_logout
        '
        Me.User_logout.ImageOptions.Image = CType(resources.GetObject("User_logout.ImageOptions.Image"), System.Drawing.Image)
        Me.User_logout.Name = "User_logout"
        Me.User_logout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.User_logout.Text = "Logout"
        '
        'AccordMarketing
        '
        Me.AccordMarketing.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.Marketing_DataOrder, Me.AccordionControlSeparator1, Me.Marketing_DetailDO})
        Me.AccordMarketing.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)})
        Me.AccordMarketing.ImageOptions.Image = CType(resources.GetObject("AccordMarketing.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordMarketing.Name = "AccordMarketing"
        Me.AccordMarketing.Text = "MARKETING"
        '
        'Marketing_DataOrder
        '
        Me.Marketing_DataOrder.ImageOptions.Image = CType(resources.GetObject("Marketing_DataOrder.ImageOptions.Image"), System.Drawing.Image)
        Me.Marketing_DataOrder.Name = "Marketing_DataOrder"
        Me.Marketing_DataOrder.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Marketing_DataOrder.Text = "DATA ORDER"
        '
        'AccordionControlSeparator1
        '
        Me.AccordionControlSeparator1.Name = "AccordionControlSeparator1"
        '
        'Marketing_DetailDO
        '
        Me.Marketing_DetailDO.ImageOptions.Image = CType(resources.GetObject("Marketing_DetailDO.ImageOptions.Image"), System.Drawing.Image)
        Me.Marketing_DetailDO.Name = "Marketing_DetailDO"
        Me.Marketing_DetailDO.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Marketing_DetailDO.Text = "DETAIL DATA ORDER"
        '
        'AccordDesain
        '
        Me.AccordDesain.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.Desain_InternalPO})
        Me.AccordDesain.ImageOptions.Image = CType(resources.GetObject("AccordDesain.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordDesain.Name = "AccordDesain"
        Me.AccordDesain.Text = "DESAIN"
        '
        'Desain_InternalPO
        '
        Me.Desain_InternalPO.ImageOptions.Image = CType(resources.GetObject("Desain_InternalPO.ImageOptions.Image"), System.Drawing.Image)
        Me.Desain_InternalPO.Name = "Desain_InternalPO"
        Me.Desain_InternalPO.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Desain_InternalPO.Text = "TERIMA P.O INTERNAL"
        '
        'AccordPrinting
        '
        Me.AccordPrinting.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.Printing_InternalPO})
        Me.AccordPrinting.ImageOptions.Image = CType(resources.GetObject("AccordPrinting.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordPrinting.Name = "AccordPrinting"
        Me.AccordPrinting.Text = "PRINTING"
        '
        'Printing_InternalPO
        '
        Me.Printing_InternalPO.ImageOptions.Image = CType(resources.GetObject("Printing_InternalPO.ImageOptions.Image"), System.Drawing.Image)
        Me.Printing_InternalPO.Name = "Printing_InternalPO"
        Me.Printing_InternalPO.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Printing_InternalPO.Text = "TERIMA P.O INTERNAL"
        '
        'AccordProduksi
        '
        Me.AccordProduksi.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.Produksi_InternalPO, Me.Produksi_AlokasiManpower, Me.Produksi_ListPOSelesai})
        Me.AccordProduksi.Expanded = True
        Me.AccordProduksi.ImageOptions.Image = CType(resources.GetObject("AccordProduksi.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordProduksi.Name = "AccordProduksi"
        Me.AccordProduksi.Text = "PRODUKSI"
        '
        'Produksi_InternalPO
        '
        Me.Produksi_InternalPO.ImageOptions.Image = CType(resources.GetObject("Produksi_InternalPO.ImageOptions.Image"), System.Drawing.Image)
        Me.Produksi_InternalPO.Name = "Produksi_InternalPO"
        Me.Produksi_InternalPO.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Produksi_InternalPO.Text = "TERIMA P.O INTERNAL"
        '
        'Produksi_AlokasiManpower
        '
        Me.Produksi_AlokasiManpower.ImageOptions.SvgImage = CType(resources.GetObject("Produksi_AlokasiManpower.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Produksi_AlokasiManpower.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.Produksi_AlokasiManpower.Name = "Produksi_AlokasiManpower"
        Me.Produksi_AlokasiManpower.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Produksi_AlokasiManpower.Text = "Alokasi Manpower"
        '
        'Produksi_ListPOSelesai
        '
        Me.Produksi_ListPOSelesai.ImageOptions.SvgImage = CType(resources.GetObject("Produksi_ListPOSelesai.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Produksi_ListPOSelesai.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.Produksi_ListPOSelesai.Name = "Produksi_ListPOSelesai"
        Me.Produksi_ListPOSelesai.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.Produksi_ListPOSelesai.Text = "List P.O Selesai"
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement1.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "EXIT"
        '
        'FluentDesignFormControl1
        '
        Me.FluentDesignFormControl1.FluentDesignForm = Me
        Me.FluentDesignFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.FluentDesignFormControl1.Manager = Me.FluentFormDefaultManager1
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1132, 26)
        Me.FluentDesignFormControl1.TabIndex = 2
        Me.FluentDesignFormControl1.TabStop = False
        '
        'FluentFormDefaultManager1
        '
        Me.FluentFormDefaultManager1.DockingEnabled = False
        Me.FluentFormDefaultManager1.Form = Me
        Me.FluentFormDefaultManager1.MaxItemId = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 450)
        Me.ControlBox = False
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "MainForm"
        Me.NavigationControl = Me.AccordionControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PROGRAM P2P "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentDesignFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FluentFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordMarketing As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents FluentDesignFormControl1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl
    Friend WithEvents FluentFormDefaultManager1 As DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager
    Friend WithEvents Marketing_DataOrder As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Marketing_DetailDO As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordDesain As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Desain_InternalPO As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordPrinting As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Printing_InternalPO As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordProduksi As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Produksi_InternalPO As DevExpress.XtraBars.Navigation.AccordionControlElement
    Private WithEvents AccordionControlSeparator1 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordAccount As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents User_viewProfil As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents User_logout As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Produksi_AlokasiManpower As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents Produksi_ListPOSelesai As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
