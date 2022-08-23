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
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordMarketing = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlSeparator1 = New DevExpress.XtraBars.Navigation.AccordionControlSeparator()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordDesain = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordPrinting = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordProduksi = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement9 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
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
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(312, 33)
        Me.FluentDesignFormContainer1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(982, 567)
        Me.FluentDesignFormContainer1.TabIndex = 0
        '
        'AccordionControl1
        '
        Me.AccordionControl1.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None
        Me.AccordionControl1.Appearance.AccordionControl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordAccount, Me.AccordMarketing, Me.AccordDesain, Me.AccordPrinting, Me.AccordProduksi, Me.AccordionControlElement1})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 33)
        Me.AccordionControl1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Overlay
        Me.AccordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.AccordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
        Me.AccordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always
        Me.AccordionControl1.Size = New System.Drawing.Size(312, 567)
        Me.AccordionControl1.TabIndex = 1
        Me.AccordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        'AccordAccount
        '
        Me.AccordAccount.Appearance.Normal.Options.UseTextOptions = True
        Me.AccordAccount.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.AccordAccount.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.AccordAccount.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement4, Me.AccordionControlElement6})
        Me.AccordAccount.Expanded = True
        Me.AccordAccount.HeaderIndent = 60
        Me.AccordAccount.Height = 90
        Me.AccordAccount.ImageOptions.Image = CType(resources.GetObject("AccordAccount.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordAccount.Name = "AccordAccount"
        Me.AccordAccount.Text = "Belum Login"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement4.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "View Profile"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement6.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement6.Text = "Logout"
        '
        'AccordMarketing
        '
        Me.AccordMarketing.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement2, Me.AccordionControlSeparator1, Me.AccordionControlElement3})
        Me.AccordMarketing.Expanded = True
        Me.AccordMarketing.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)})
        Me.AccordMarketing.ImageOptions.Image = CType(resources.GetObject("AccordMarketing.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordMarketing.Name = "AccordMarketing"
        Me.AccordMarketing.Text = "MARKETING"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement2.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "DATA ORDER"
        '
        'AccordionControlSeparator1
        '
        Me.AccordionControlSeparator1.Name = "AccordionControlSeparator1"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement3.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "DETAIL DATA ORDER"
        '
        'AccordDesain
        '
        Me.AccordDesain.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement5})
        Me.AccordDesain.ImageOptions.Image = CType(resources.GetObject("AccordDesain.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordDesain.Name = "AccordDesain"
        Me.AccordDesain.Text = "DESAIN"
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement5.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement5.Text = "P.O INTERNAL"
        '
        'AccordPrinting
        '
        Me.AccordPrinting.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement8})
        Me.AccordPrinting.ImageOptions.Image = CType(resources.GetObject("AccordPrinting.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordPrinting.Name = "AccordPrinting"
        Me.AccordPrinting.Text = "PRINTING"
        '
        'AccordionControlElement8
        '
        Me.AccordionControlElement8.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement8.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement8.Name = "AccordionControlElement8"
        Me.AccordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement8.Text = "P.O INTERNAL"
        '
        'AccordProduksi
        '
        Me.AccordProduksi.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement9})
        Me.AccordProduksi.ImageOptions.Image = CType(resources.GetObject("AccordProduksi.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordProduksi.Name = "AccordProduksi"
        Me.AccordProduksi.Text = "PRODUKSI"
        '
        'AccordionControlElement9
        '
        Me.AccordionControlElement9.ImageOptions.Image = CType(resources.GetObject("AccordionControlElement9.ImageOptions.Image"), System.Drawing.Image)
        Me.AccordionControlElement9.Name = "AccordionControlElement9"
        Me.AccordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement9.Text = "P.O INTERNAL"
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
        Me.FluentDesignFormControl1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.FluentDesignFormControl1.Name = "FluentDesignFormControl1"
        Me.FluentDesignFormControl1.Size = New System.Drawing.Size(1294, 33)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 600)
        Me.ControlBox = False
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Controls.Add(Me.FluentDesignFormControl1)
        Me.FluentDesignFormControl = Me.FluentDesignFormControl1
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
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
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordDesain As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordPrinting As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordProduksi As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement9 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Private WithEvents AccordionControlSeparator1 As DevExpress.XtraBars.Navigation.AccordionControlSeparator
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordAccount As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
End Class
