<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.peImage = New DevExpress.XtraEditors.PictureEdit()
        Me.FrmLoginLayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.TPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TUsername = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TextEdit2item = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TextEdit1item = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2item = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton1item = New DevExpress.XtraLayout.LayoutControlItem()
        Me.peImageitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.peImage.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FrmLoginLayoutControl1ConvertedLayout,System.ComponentModel.ISupportInitialize).BeginInit
        Me.FrmLoginLayoutControl1ConvertedLayout.SuspendLayout
        CType(Me.TPassword.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TUsername.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit2item,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TextEdit1item,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SimpleButton2item,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SimpleButton1item,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.peImageitem,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BehaviorManager1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'peImage
        '
        Me.peImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.peImage.EditValue = CType(resources.GetObject("peImage.EditValue"),Object)
        Me.peImage.Location = New System.Drawing.Point(12, 12)
        Me.peImage.Margin = New System.Windows.Forms.Padding(5)
        Me.peImage.Name = "peImage"
        Me.peImage.Properties.AllowFocused = false
        Me.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peImage.Properties.Appearance.Options.UseBackColor = true
        Me.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peImage.Properties.ShowMenu = false
        Me.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.peImage.Size = New System.Drawing.Size(327, 251)
        Me.peImage.StyleController = Me.FrmLoginLayoutControl1ConvertedLayout
        Me.peImage.TabIndex = 14
        '
        'FrmLoginLayoutControl1ConvertedLayout
        '
        Me.FrmLoginLayoutControl1ConvertedLayout.Controls.Add(Me.TPassword)
        Me.FrmLoginLayoutControl1ConvertedLayout.Controls.Add(Me.TUsername)
        Me.FrmLoginLayoutControl1ConvertedLayout.Controls.Add(Me.SimpleButton2)
        Me.FrmLoginLayoutControl1ConvertedLayout.Controls.Add(Me.SimpleButton1)
        Me.FrmLoginLayoutControl1ConvertedLayout.Controls.Add(Me.peImage)
        Me.FrmLoginLayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmLoginLayoutControl1ConvertedLayout.Location = New System.Drawing.Point(1, 1)
        Me.FrmLoginLayoutControl1ConvertedLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FrmLoginLayoutControl1ConvertedLayout.Name = "FrmLoginLayoutControl1ConvertedLayout"
        Me.FrmLoginLayoutControl1ConvertedLayout.Root = Me.LayoutControlGroup1
        Me.FrmLoginLayoutControl1ConvertedLayout.Size = New System.Drawing.Size(351, 366)
        Me.FrmLoginLayoutControl1ConvertedLayout.TabIndex = 23
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(94, 297)
        Me.TPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TPassword.Properties.UseSystemPasswordChar = True
        Me.TPassword.Size = New System.Drawing.Size(245, 26)
        Me.TPassword.StyleController = Me.FrmLoginLayoutControl1ConvertedLayout
        Me.TPassword.TabIndex = 20
        '
        'TUsername
        '
        Me.TUsername.Location = New System.Drawing.Point(94, 267)
        Me.TUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Size = New System.Drawing.Size(245, 26)
        Me.TUsername.StyleController = Me.FrmLoginLayoutControl1ConvertedLayout
        Me.TUsername.TabIndex = 19
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 327)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(129, 27)
        Me.SimpleButton2.StyleController = Me.FrmLoginLayoutControl1ConvertedLayout
        Me.SimpleButton2.TabIndex = 16
        Me.SimpleButton2.Text = "TUTUP"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SimpleButton1.Location = New System.Drawing.Point(145, 327)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(194, 27)
        Me.SimpleButton1.StyleController = Me.FrmLoginLayoutControl1ConvertedLayout
        Me.SimpleButton1.TabIndex = 15
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "LOGIN"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LayoutControlGroup1.AppearanceGroup.BackColor2 = System.Drawing.Color.Beige
        Me.LayoutControlGroup1.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseBackColor = True
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TextEdit2item, Me.TextEdit1item, Me.SimpleButton2item, Me.SimpleButton1item, Me.peImageitem})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(351, 366)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'TextEdit2item
        '
        Me.TextEdit2item.Control = Me.TPassword
        Me.TextEdit2item.Location = New System.Drawing.Point(0, 285)
        Me.TextEdit2item.Name = "TextEdit2item"
        Me.TextEdit2item.Size = New System.Drawing.Size(331, 30)
        Me.TextEdit2item.Text = "PASSWORD"
        Me.TextEdit2item.TextLocation = DevExpress.Utils.Locations.Left
        Me.TextEdit2item.TextSize = New System.Drawing.Size(79, 20)
        '
        'TextEdit1item
        '
        Me.TextEdit1item.Control = Me.TUsername
        Me.TextEdit1item.Location = New System.Drawing.Point(0, 255)
        Me.TextEdit1item.Name = "TextEdit1item"
        Me.TextEdit1item.Size = New System.Drawing.Size(331, 30)
        Me.TextEdit1item.Text = "USERNAME"
        Me.TextEdit1item.TextLocation = DevExpress.Utils.Locations.Left
        Me.TextEdit1item.TextSize = New System.Drawing.Size(79, 20)
        '
        'SimpleButton2item
        '
        Me.SimpleButton2item.Control = Me.SimpleButton2
        Me.SimpleButton2item.Location = New System.Drawing.Point(0, 315)
        Me.SimpleButton2item.Name = "SimpleButton2item"
        Me.SimpleButton2item.Size = New System.Drawing.Size(133, 31)
        Me.SimpleButton2item.TextSize = New System.Drawing.Size(0, 0)
        Me.SimpleButton2item.TextVisible = False
        '
        'SimpleButton1item
        '
        Me.SimpleButton1item.Control = Me.SimpleButton1
        Me.SimpleButton1item.Location = New System.Drawing.Point(133, 315)
        Me.SimpleButton1item.Name = "SimpleButton1item"
        Me.SimpleButton1item.Size = New System.Drawing.Size(198, 31)
        Me.SimpleButton1item.TextSize = New System.Drawing.Size(0, 0)
        Me.SimpleButton1item.TextVisible = False
        '
        'peImageitem
        '
        Me.peImageitem.Control = Me.peImage
        Me.peImageitem.Location = New System.Drawing.Point(0, 0)
        Me.peImageitem.Name = "peImageitem"
        Me.peImageitem.Size = New System.Drawing.Size(331, 255)
        Me.peImageitem.TextSize = New System.Drawing.Size(0, 0)
        Me.peImageitem.TextVisible = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.SimpleButton1
        Me.ActiveGlowColor = System.Drawing.Color.Red
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SimpleButton2
        Me.ClientSize = New System.Drawing.Size(353, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.FrmLoginLayoutControl1ConvertedLayout)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.IconOptions.Image = CType(resources.GetObject("FrmLogin.IconOptions.Image"), System.Drawing.Image)
        Me.IconOptions.LargeImage = CType(resources.GetObject("FrmLogin.IconOptions.LargeImage"), System.Drawing.Image)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmLogin"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AUTENTIKASI"
        CType(Me.peImage.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FrmLoginLayoutControl1ConvertedLayout,System.ComponentModel.ISupportInitialize).EndInit
        Me.FrmLoginLayoutControl1ConvertedLayout.ResumeLayout(false)
        CType(Me.TPassword.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TUsername.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit2item,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextEdit1item,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SimpleButton2item,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SimpleButton1item,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.peImageitem,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BehaviorManager1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Private WithEvents peImage As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FrmLoginLayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents TextEdit2item As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit1item As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2item As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1item As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents peImageitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
