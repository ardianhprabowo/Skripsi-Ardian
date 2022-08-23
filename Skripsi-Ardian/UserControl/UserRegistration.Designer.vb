<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserRegistration))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.BtnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New DevExpress.XtraEditors.TextEdit()
        Me.THandphone = New DevExpress.XtraEditors.TextEdit()
        Me.TEmail = New DevExpress.XtraEditors.TextEdit()
        Me.TPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TUsername = New DevExpress.XtraEditors.TextEdit()
        Me.TFullname = New DevExpress.XtraEditors.TextEdit()
        Me.TKota = New DevExpress.XtraEditors.TextEdit()
        Me.Sby = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RB00 = New System.Windows.Forms.RadioButton()
        Me.RB13 = New System.Windows.Forms.RadioButton()
        Me.RB12 = New System.Windows.Forms.RadioButton()
        Me.RB11 = New System.Windows.Forms.RadioButton()
        Me.RB09 = New System.Windows.Forms.RadioButton()
        Me.RB10 = New System.Windows.Forms.RadioButton()
        Me.RB08 = New System.Windows.Forms.RadioButton()
        Me.RB07 = New System.Windows.Forms.RadioButton()
        Me.RB06 = New System.Windows.Forms.RadioButton()
        Me.RB05 = New System.Windows.Forms.RadioButton()
        Me.RB04 = New System.Windows.Forms.RadioButton()
        Me.RB03 = New System.Windows.Forms.RadioButton()
        Me.RB02 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New DevExpress.XtraEditors.GroupControl()
        Me.RB01 = New System.Windows.Forms.RadioButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextBox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THandphone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TKota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl2.Appearance.Options.UseForeColor = True
        Me.GroupControl2.CaptionImageOptions.SvgImage = CType(resources.GetObject("GroupControl2.CaptionImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.GroupControl2.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.GroupControl2.Controls.Add(Me.BtnClear)
        Me.GroupControl2.Controls.Add(Me.BtnOK)
        Me.GroupControl2.Controls.Add(Me.BtnSimpan)
        Me.GroupControl2.Controls.Add(Me.BtnUpdate)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.TextBox1)
        Me.GroupControl2.Controls.Add(Me.THandphone)
        Me.GroupControl2.Controls.Add(Me.TEmail)
        Me.GroupControl2.Controls.Add(Me.TPassword)
        Me.GroupControl2.Controls.Add(Me.TUsername)
        Me.GroupControl2.Controls.Add(Me.TFullname)
        Me.GroupControl2.Controls.Add(Me.TKota)
        Me.GroupControl2.Controls.Add(Me.Sby)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 206)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(955, 407)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "User Detail"
        '
        'BtnClear
        '
        Me.BtnClear.ImageOptions.SvgImage = CType(resources.GetObject("BtnClear.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnClear.Location = New System.Drawing.Point(436, 240)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(135, 52)
        Me.BtnClear.TabIndex = 25
        Me.BtnClear.Text = "CLEAR"
        '
        'BtnOK
        '
        Me.BtnOK.ImageOptions.SvgImage = CType(resources.GetObject("BtnOK.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnOK.Location = New System.Drawing.Point(596, 240)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(135, 52)
        Me.BtnOK.TabIndex = 25
        Me.BtnOK.Text = "OK"
        '
        'BtnSimpan
        '
        Me.BtnSimpan.ImageOptions.SvgImage = CType(resources.GetObject("BtnSimpan.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnSimpan.Location = New System.Drawing.Point(276, 240)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(135, 52)
        Me.BtnSimpan.TabIndex = 24
        Me.BtnSimpan.Text = "SIMPAN"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Enabled = False
        Me.BtnUpdate.ImageOptions.SvgImage = CType(resources.GetObject("BtnUpdate.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BtnUpdate.Location = New System.Drawing.Point(121, 240)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(135, 52)
        Me.BtnUpdate.TabIndex = 23
        Me.BtnUpdate.Text = "UPDATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(480, 146)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(480, 106)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 185)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(117, 145)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = ":"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 211)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 26)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Visible = False
        '
        'THandphone
        '
        Me.THandphone.Location = New System.Drawing.Point(499, 142)
        Me.THandphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.THandphone.Name = "THandphone"
        Me.THandphone.Properties.Mask.BeepOnError = True
        Me.THandphone.Properties.Mask.EditMask = "62 \d\d \d\d\d-\d\d\d-\d\d\d"
        Me.THandphone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.THandphone.Size = New System.Drawing.Size(232, 26)
        Me.THandphone.TabIndex = 16
        '
        'TEmail
        '
        Me.TEmail.Location = New System.Drawing.Point(499, 102)
        Me.TEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TEmail.Name = "TEmail"
        Me.TEmail.Size = New System.Drawing.Size(232, 26)
        Me.TEmail.TabIndex = 15
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(132, 182)
        Me.TPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TPassword.Properties.UseSystemPasswordChar = True
        Me.TPassword.Size = New System.Drawing.Size(232, 26)
        Me.TPassword.TabIndex = 14
        '
        'TUsername
        '
        Me.TUsername.Location = New System.Drawing.Point(132, 142)
        Me.TUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TUsername.Name = "TUsername"
        Me.TUsername.Size = New System.Drawing.Size(232, 26)
        Me.TUsername.TabIndex = 13
        '
        'TFullname
        '
        Me.TFullname.Location = New System.Drawing.Point(132, 100)
        Me.TFullname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TFullname.Name = "TFullname"
        Me.TFullname.Size = New System.Drawing.Size(232, 26)
        Me.TFullname.TabIndex = 12
        '
        'TKota
        '
        Me.TKota.Location = New System.Drawing.Point(132, 55)
        Me.TKota.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TKota.Name = "TKota"
        Me.TKota.Size = New System.Drawing.Size(232, 26)
        Me.TKota.TabIndex = 11
        '
        'Sby
        '
        Me.Sby.AutoSize = True
        Me.Sby.Location = New System.Drawing.Point(17, 58)
        Me.Sby.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Sby.Name = "Sby"
        Me.Sby.Size = New System.Drawing.Size(92, 24)
        Me.Sby.TabIndex = 10
        Me.Sby.Text = "Surabaya"
        Me.Sby.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fullname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Handphone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username *"
        '
        'RB00
        '
        Me.RB00.AutoSize = True
        Me.RB00.Location = New System.Drawing.Point(509, 80)
        Me.RB00.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB00.Name = "RB00"
        Me.RB00.Size = New System.Drawing.Size(191, 24)
        Me.RB00.TabIndex = 12
        Me.RB00.TabStop = True
        Me.RB00.Text = "Level 0 <Administrator>"
        Me.RB00.UseVisualStyleBackColor = True
        '
        'RB13
        '
        Me.RB13.AutoSize = True
        Me.RB13.Location = New System.Drawing.Point(509, 45)
        Me.RB13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB13.Name = "RB13"
        Me.RB13.Size = New System.Drawing.Size(152, 24)
        Me.RB13.TabIndex = 11
        Me.RB13.TabStop = True
        Me.RB13.Text = "Gudang SPG <13>"
        Me.RB13.UseVisualStyleBackColor = True
        '
        'RB12
        '
        Me.RB12.AutoSize = True
        Me.RB12.Location = New System.Drawing.Point(327, 151)
        Me.RB12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB12.Name = "RB12"
        Me.RB12.Size = New System.Drawing.Size(182, 24)
        Me.RB12.TabIndex = 10
        Me.RB12.TabStop = True
        Me.RB12.Text = "Gudang Produksi <12>"
        Me.RB12.UseVisualStyleBackColor = True
        '
        'RB11
        '
        Me.RB11.AutoSize = True
        Me.RB11.Location = New System.Drawing.Point(327, 115)
        Me.RB11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB11.Name = "RB11"
        Me.RB11.Size = New System.Drawing.Size(162, 24)
        Me.RB11.TabIndex = 9
        Me.RB11.TabStop = True
        Me.RB11.Text = "Gudang Event <11>"
        Me.RB11.UseVisualStyleBackColor = True
        '
        'RB09
        '
        Me.RB09.AutoSize = True
        Me.RB09.Location = New System.Drawing.Point(327, 45)
        Me.RB09.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB09.Name = "RB09"
        Me.RB09.Size = New System.Drawing.Size(121, 24)
        Me.RB09.TabIndex = 8
        Me.RB09.TabStop = True
        Me.RB09.Text = "Printing <09>"
        Me.RB09.UseVisualStyleBackColor = True
        '
        'RB10
        '
        Me.RB10.AutoSize = True
        Me.RB10.Location = New System.Drawing.Point(327, 80)
        Me.RB10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB10.Name = "RB10"
        Me.RB10.Size = New System.Drawing.Size(115, 24)
        Me.RB10.TabIndex = 8
        Me.RB10.TabStop = True
        Me.RB10.Text = "Desain <10>"
        Me.RB10.UseVisualStyleBackColor = True
        '
        'RB08
        '
        Me.RB08.AutoSize = True
        Me.RB08.Location = New System.Drawing.Point(172, 151)
        Me.RB08.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB08.Name = "RB08"
        Me.RB08.Size = New System.Drawing.Size(128, 24)
        Me.RB08.TabIndex = 7
        Me.RB08.TabStop = True
        Me.RB08.Text = "Purchase <08>"
        Me.RB08.UseVisualStyleBackColor = True
        '
        'RB07
        '
        Me.RB07.AutoSize = True
        Me.RB07.Location = New System.Drawing.Point(172, 115)
        Me.RB07.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB07.Name = "RB07"
        Me.RB07.Size = New System.Drawing.Size(82, 24)
        Me.RB07.TabIndex = 6
        Me.RB07.TabStop = True
        Me.RB07.Text = "IT <07>"
        Me.RB07.UseVisualStyleBackColor = True
        '
        'RB06
        '
        Me.RB06.AutoSize = True
        Me.RB06.Location = New System.Drawing.Point(172, 80)
        Me.RB06.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB06.Name = "RB06"
        Me.RB06.Size = New System.Drawing.Size(101, 24)
        Me.RB06.TabIndex = 5
        Me.RB06.TabStop = True
        Me.RB06.Text = "HRD <06>"
        Me.RB06.UseVisualStyleBackColor = True
        '
        'RB05
        '
        Me.RB05.AutoSize = True
        Me.RB05.Location = New System.Drawing.Point(172, 45)
        Me.RB05.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB05.Name = "RB05"
        Me.RB05.Size = New System.Drawing.Size(137, 24)
        Me.RB05.TabIndex = 4
        Me.RB05.TabStop = True
        Me.RB05.Text = "Marketing <05>"
        Me.RB05.UseVisualStyleBackColor = True
        '
        'RB04
        '
        Me.RB04.AutoSize = True
        Me.RB04.Location = New System.Drawing.Point(13, 151)
        Me.RB04.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB04.Name = "RB04"
        Me.RB04.Size = New System.Drawing.Size(120, 24)
        Me.RB04.TabIndex = 3
        Me.RB04.TabStop = True
        Me.RB04.Text = "Finance <04>"
        Me.RB04.UseVisualStyleBackColor = True
        '
        'RB03
        '
        Me.RB03.AutoSize = True
        Me.RB03.Location = New System.Drawing.Point(13, 115)
        Me.RB03.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB03.Name = "RB03"
        Me.RB03.Size = New System.Drawing.Size(96, 24)
        Me.RB03.TabIndex = 2
        Me.RB03.TabStop = True
        Me.RB03.Text = "SPG <03>"
        Me.RB03.UseVisualStyleBackColor = True
        '
        'RB02
        '
        Me.RB02.AutoSize = True
        Me.RB02.Location = New System.Drawing.Point(13, 80)
        Me.RB02.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB02.Name = "RB02"
        Me.RB02.Size = New System.Drawing.Size(114, 24)
        Me.RB02.TabIndex = 1
        Me.RB02.TabStop = True
        Me.RB02.Text = "EVENT <02>"
        Me.RB02.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Appearance.Options.UseForeColor = True
        Me.Panel1.CaptionImageOptions.SvgImage = CType(resources.GetObject("Panel1.CaptionImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Panel1.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.Panel1.Controls.Add(Me.RB00)
        Me.Panel1.Controls.Add(Me.RB13)
        Me.Panel1.Controls.Add(Me.RB12)
        Me.Panel1.Controls.Add(Me.RB11)
        Me.Panel1.Controls.Add(Me.RB09)
        Me.Panel1.Controls.Add(Me.RB10)
        Me.Panel1.Controls.Add(Me.RB08)
        Me.Panel1.Controls.Add(Me.RB07)
        Me.Panel1.Controls.Add(Me.RB06)
        Me.Panel1.Controls.Add(Me.RB05)
        Me.Panel1.Controls.Add(Me.RB04)
        Me.Panel1.Controls.Add(Me.RB03)
        Me.Panel1.Controls.Add(Me.RB02)
        Me.Panel1.Controls.Add(Me.RB01)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel1.Size = New System.Drawing.Size(955, 206)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Text = "Divisi"
        '
        'RB01
        '
        Me.RB01.AutoSize = True
        Me.RB01.Location = New System.Drawing.Point(13, 45)
        Me.RB01.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RB01.Name = "RB01"
        Me.RB01.Size = New System.Drawing.Size(126, 24)
        Me.RB01.TabIndex = 0
        Me.RB01.TabStop = True
        Me.RB01.Text = "Produksi <01>"
        Me.RB01.UseVisualStyleBackColor = True
        '
        'UserRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserRegistration"
        Me.Size = New System.Drawing.Size(955, 613)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextBox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THandphone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TKota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents THandphone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TFullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TKota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Sby As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB00 As System.Windows.Forms.RadioButton
    Friend WithEvents RB13 As System.Windows.Forms.RadioButton
    Friend WithEvents RB12 As System.Windows.Forms.RadioButton
    Friend WithEvents RB11 As System.Windows.Forms.RadioButton
    Friend WithEvents RB09 As System.Windows.Forms.RadioButton
    Friend WithEvents RB10 As System.Windows.Forms.RadioButton
    Friend WithEvents RB08 As System.Windows.Forms.RadioButton
    Friend WithEvents RB07 As System.Windows.Forms.RadioButton
    Friend WithEvents RB06 As System.Windows.Forms.RadioButton
    Friend WithEvents RB05 As System.Windows.Forms.RadioButton
    Friend WithEvents RB04 As System.Windows.Forms.RadioButton
    Friend WithEvents RB03 As System.Windows.Forms.RadioButton
    Friend WithEvents RB02 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RB01 As System.Windows.Forms.RadioButton

End Class
