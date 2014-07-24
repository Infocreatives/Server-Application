<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tax
    Inherits DevComponents.DotNetBar.Office2007Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSelectProduct = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlC0 = New DevComponents.DotNetBar.PanelEx()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtNetAmount = New System.Windows.Forms.TextBox()
        Me.txtVatAmount = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.pnlSlNo = New System.Windows.Forms.Panel()
        Me.txtS21 = New System.Windows.Forms.TextBox()
        Me.txtS20 = New System.Windows.Forms.TextBox()
        Me.txtS19 = New System.Windows.Forms.TextBox()
        Me.txtS18 = New System.Windows.Forms.TextBox()
        Me.txtS17 = New System.Windows.Forms.TextBox()
        Me.txtS16 = New System.Windows.Forms.TextBox()
        Me.txtS15 = New System.Windows.Forms.TextBox()
        Me.txtS14 = New System.Windows.Forms.TextBox()
        Me.txtS13 = New System.Windows.Forms.TextBox()
        Me.txtS12 = New System.Windows.Forms.TextBox()
        Me.txtS11 = New System.Windows.Forms.TextBox()
        Me.txtS10 = New System.Windows.Forms.TextBox()
        Me.txtS9 = New System.Windows.Forms.TextBox()
        Me.txtS8 = New System.Windows.Forms.TextBox()
        Me.txtS7 = New System.Windows.Forms.TextBox()
        Me.txtS6 = New System.Windows.Forms.TextBox()
        Me.txtS5 = New System.Windows.Forms.TextBox()
        Me.txtS4 = New System.Windows.Forms.TextBox()
        Me.txtS3 = New System.Windows.Forms.TextBox()
        Me.txtS2 = New System.Windows.Forms.TextBox()
        Me.pnlA = New System.Windows.Forms.Panel()
        Me.txtA17 = New System.Windows.Forms.TextBox()
        Me.txtA16 = New System.Windows.Forms.TextBox()
        Me.txtA15 = New System.Windows.Forms.TextBox()
        Me.txtA14 = New System.Windows.Forms.TextBox()
        Me.txtA13 = New System.Windows.Forms.TextBox()
        Me.txtA12 = New System.Windows.Forms.TextBox()
        Me.txtA11 = New System.Windows.Forms.TextBox()
        Me.txtA10 = New System.Windows.Forms.TextBox()
        Me.txtA9 = New System.Windows.Forms.TextBox()
        Me.txtA8 = New System.Windows.Forms.TextBox()
        Me.txtA7 = New System.Windows.Forms.TextBox()
        Me.txtA6 = New System.Windows.Forms.TextBox()
        Me.txtA5 = New System.Windows.Forms.TextBox()
        Me.txtA4 = New System.Windows.Forms.TextBox()
        Me.pnlR = New System.Windows.Forms.Panel()
        Me.txtR17 = New System.Windows.Forms.TextBox()
        Me.txtR16 = New System.Windows.Forms.TextBox()
        Me.txtR15 = New System.Windows.Forms.TextBox()
        Me.txtR14 = New System.Windows.Forms.TextBox()
        Me.tctR13 = New System.Windows.Forms.TextBox()
        Me.txtR12 = New System.Windows.Forms.TextBox()
        Me.txtR11 = New System.Windows.Forms.TextBox()
        Me.txtR10 = New System.Windows.Forms.TextBox()
        Me.txtR9 = New System.Windows.Forms.TextBox()
        Me.txtR8 = New System.Windows.Forms.TextBox()
        Me.txtR7 = New System.Windows.Forms.TextBox()
        Me.txtR6 = New System.Windows.Forms.TextBox()
        Me.txtR5 = New System.Windows.Forms.TextBox()
        Me.txtR4 = New System.Windows.Forms.TextBox()
        Me.pnlQ = New System.Windows.Forms.Panel()
        Me.txtQ21 = New System.Windows.Forms.TextBox()
        Me.txtQ20 = New System.Windows.Forms.TextBox()
        Me.txtQ19 = New System.Windows.Forms.TextBox()
        Me.txtQ18 = New System.Windows.Forms.TextBox()
        Me.txtQ17 = New System.Windows.Forms.TextBox()
        Me.txtQ16 = New System.Windows.Forms.TextBox()
        Me.txtQ15 = New System.Windows.Forms.TextBox()
        Me.txtQ14 = New System.Windows.Forms.TextBox()
        Me.txtQ13 = New System.Windows.Forms.TextBox()
        Me.txtQ12 = New System.Windows.Forms.TextBox()
        Me.txtQ11 = New System.Windows.Forms.TextBox()
        Me.txtQ10 = New System.Windows.Forms.TextBox()
        Me.txtQ9 = New System.Windows.Forms.TextBox()
        Me.txtQ8 = New System.Windows.Forms.TextBox()
        Me.txtQ7 = New System.Windows.Forms.TextBox()
        Me.txtQ6 = New System.Windows.Forms.TextBox()
        Me.txtQ5 = New System.Windows.Forms.TextBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.pnlSP = New System.Windows.Forms.Panel()
        Me.txtP21 = New System.Windows.Forms.TextBox()
        Me.txtP20 = New System.Windows.Forms.TextBox()
        Me.txtP19 = New System.Windows.Forms.TextBox()
        Me.txtP18 = New System.Windows.Forms.TextBox()
        Me.txtP17 = New System.Windows.Forms.TextBox()
        Me.txtP16 = New System.Windows.Forms.TextBox()
        Me.txtP15 = New System.Windows.Forms.TextBox()
        Me.txtP14 = New System.Windows.Forms.TextBox()
        Me.txtP13 = New System.Windows.Forms.TextBox()
        Me.txtP12 = New System.Windows.Forms.TextBox()
        Me.txtP11 = New System.Windows.Forms.TextBox()
        Me.txtP10 = New System.Windows.Forms.TextBox()
        Me.txtP9 = New System.Windows.Forms.TextBox()
        Me.txtP8 = New System.Windows.Forms.TextBox()
        Me.txtP7 = New System.Windows.Forms.TextBox()
        Me.txtP6 = New System.Windows.Forms.TextBox()
        Me.txtP5 = New System.Windows.Forms.TextBox()
        Me.txtP4 = New System.Windows.Forms.TextBox()
        Me.txtP3 = New System.Windows.Forms.TextBox()
        Me.txtP2 = New System.Windows.Forms.TextBox()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.pnlBottom.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlC0.SuspendLayout()
        Me.pnlSlNo.SuspendLayout()
        Me.pnlA.SuspendLayout()
        Me.pnlR.SuspendLayout()
        Me.pnlQ.SuspendLayout()
        Me.pnlSP.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(9, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(57, 25)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(72, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(57, 25)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(135, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 25)
        Me.btnClose.TabIndex = 53
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(366, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 14)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "*"
        '
        'cmbSelectProduct
        '
        Me.cmbSelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSelectProduct.FormattingEnabled = True
        Me.cmbSelectProduct.Location = New System.Drawing.Point(122, 3)
        Me.cmbSelectProduct.Name = "cmbSelectProduct"
        Me.cmbSelectProduct.Size = New System.Drawing.Size(238, 22)
        Me.cmbSelectProduct.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 14)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Choose Product :"
        '
        'bgWorker
        '
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.btnSave)
        Me.pnlBottom.Controls.Add(Me.btnClear)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Location = New System.Drawing.Point(728, 652)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(200, 36)
        Me.pnlBottom.TabIndex = 73
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.pnlC0)
        Me.pnlMain.Location = New System.Drawing.Point(-1, 37)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(942, 610)
        Me.pnlMain.TabIndex = 103
        '
        'pnlC0
        '
        Me.pnlC0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlC0.CanvasColor = System.Drawing.SystemColors.Control
        Me.pnlC0.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pnlC0.Controls.Add(Me.txtVat)
        Me.pnlC0.Controls.Add(Me.txtAmount)
        Me.pnlC0.Controls.Add(Me.txtNetAmount)
        Me.pnlC0.Controls.Add(Me.txtVatAmount)
        Me.pnlC0.Controls.Add(Me.txtTotalAmount)
        Me.pnlC0.Controls.Add(Me.pnlSlNo)
        Me.pnlC0.Controls.Add(Me.pnlA)
        Me.pnlC0.Controls.Add(Me.pnlR)
        Me.pnlC0.Controls.Add(Me.pnlQ)
        Me.pnlC0.Controls.Add(Me.pnlSP)
        Me.pnlC0.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlC0.Location = New System.Drawing.Point(0, 0)
        Me.pnlC0.Name = "pnlC0"
        Me.pnlC0.Size = New System.Drawing.Size(925, 735)
        Me.pnlC0.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pnlC0.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pnlC0.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pnlC0.Style.BackgroundImage = Global.PushpakBilling.My.Resources.Resources.Honda_Wmk_C_copy
        Me.pnlC0.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pnlC0.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pnlC0.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pnlC0.Style.GradientAngle = 90
        Me.pnlC0.TabIndex = 0
        Me.pnlC0.Visible = False
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(666, 587)
        Me.txtVat.MaxLength = 2
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(34, 22)
        Me.txtVat.TabIndex = 6
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Location = New System.Drawing.Point(20, 662)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(543, 62)
        Me.txtAmount.TabIndex = 9
        '
        'txtNetAmount
        '
        Me.txtNetAmount.Location = New System.Drawing.Point(716, 687)
        Me.txtNetAmount.MaxLength = 12
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.Size = New System.Drawing.Size(174, 22)
        Me.txtNetAmount.TabIndex = 8
        '
        'txtVatAmount
        '
        Me.txtVatAmount.Location = New System.Drawing.Point(716, 589)
        Me.txtVatAmount.MaxLength = 12
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.Size = New System.Drawing.Size(174, 22)
        Me.txtVatAmount.TabIndex = 7
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(716, 544)
        Me.txtTotalAmount.MaxLength = 12
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(174, 22)
        Me.txtTotalAmount.TabIndex = 5
        '
        'pnlSlNo
        '
        Me.pnlSlNo.BackColor = System.Drawing.Color.Silver
        Me.pnlSlNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSlNo.Controls.Add(Me.txtS21)
        Me.pnlSlNo.Controls.Add(Me.txtS20)
        Me.pnlSlNo.Controls.Add(Me.txtS19)
        Me.pnlSlNo.Controls.Add(Me.txtS18)
        Me.pnlSlNo.Controls.Add(Me.txtS17)
        Me.pnlSlNo.Controls.Add(Me.txtS16)
        Me.pnlSlNo.Controls.Add(Me.txtS15)
        Me.pnlSlNo.Controls.Add(Me.txtS14)
        Me.pnlSlNo.Controls.Add(Me.txtS13)
        Me.pnlSlNo.Controls.Add(Me.txtS12)
        Me.pnlSlNo.Controls.Add(Me.txtS11)
        Me.pnlSlNo.Controls.Add(Me.txtS10)
        Me.pnlSlNo.Controls.Add(Me.txtS9)
        Me.pnlSlNo.Controls.Add(Me.txtS8)
        Me.pnlSlNo.Controls.Add(Me.txtS7)
        Me.pnlSlNo.Controls.Add(Me.txtS6)
        Me.pnlSlNo.Controls.Add(Me.txtS5)
        Me.pnlSlNo.Controls.Add(Me.txtS4)
        Me.pnlSlNo.Controls.Add(Me.txtS3)
        Me.pnlSlNo.Controls.Add(Me.txtS2)
        Me.pnlSlNo.Location = New System.Drawing.Point(18, 215)
        Me.pnlSlNo.Name = "pnlSlNo"
        Me.pnlSlNo.Size = New System.Drawing.Size(60, 441)
        Me.pnlSlNo.TabIndex = 0
        '
        'txtS21
        '
        Me.txtS21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS21.Location = New System.Drawing.Point(0, -1)
        Me.txtS21.MaxLength = 2
        Me.txtS21.Name = "txtS21"
        Me.txtS21.Size = New System.Drawing.Size(58, 22)
        Me.txtS21.TabIndex = 0
        '
        'txtS20
        '
        Me.txtS20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS20.Location = New System.Drawing.Point(0, 21)
        Me.txtS20.MaxLength = 2
        Me.txtS20.Name = "txtS20"
        Me.txtS20.Size = New System.Drawing.Size(58, 22)
        Me.txtS20.TabIndex = 1
        '
        'txtS19
        '
        Me.txtS19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS19.Location = New System.Drawing.Point(0, 43)
        Me.txtS19.MaxLength = 2
        Me.txtS19.Name = "txtS19"
        Me.txtS19.Size = New System.Drawing.Size(58, 22)
        Me.txtS19.TabIndex = 2
        '
        'txtS18
        '
        Me.txtS18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS18.Location = New System.Drawing.Point(0, 65)
        Me.txtS18.MaxLength = 2
        Me.txtS18.Name = "txtS18"
        Me.txtS18.Size = New System.Drawing.Size(58, 22)
        Me.txtS18.TabIndex = 3
        '
        'txtS17
        '
        Me.txtS17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS17.Location = New System.Drawing.Point(0, 87)
        Me.txtS17.MaxLength = 2
        Me.txtS17.Name = "txtS17"
        Me.txtS17.Size = New System.Drawing.Size(58, 22)
        Me.txtS17.TabIndex = 4
        '
        'txtS16
        '
        Me.txtS16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS16.Location = New System.Drawing.Point(0, 109)
        Me.txtS16.MaxLength = 2
        Me.txtS16.Name = "txtS16"
        Me.txtS16.Size = New System.Drawing.Size(58, 22)
        Me.txtS16.TabIndex = 5
        '
        'txtS15
        '
        Me.txtS15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS15.Location = New System.Drawing.Point(0, 131)
        Me.txtS15.MaxLength = 2
        Me.txtS15.Name = "txtS15"
        Me.txtS15.Size = New System.Drawing.Size(58, 22)
        Me.txtS15.TabIndex = 6
        '
        'txtS14
        '
        Me.txtS14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS14.Location = New System.Drawing.Point(0, 153)
        Me.txtS14.MaxLength = 2
        Me.txtS14.Name = "txtS14"
        Me.txtS14.Size = New System.Drawing.Size(58, 22)
        Me.txtS14.TabIndex = 7
        '
        'txtS13
        '
        Me.txtS13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS13.Location = New System.Drawing.Point(0, 175)
        Me.txtS13.MaxLength = 2
        Me.txtS13.Name = "txtS13"
        Me.txtS13.Size = New System.Drawing.Size(58, 22)
        Me.txtS13.TabIndex = 8
        '
        'txtS12
        '
        Me.txtS12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS12.Location = New System.Drawing.Point(0, 197)
        Me.txtS12.MaxLength = 2
        Me.txtS12.Name = "txtS12"
        Me.txtS12.Size = New System.Drawing.Size(58, 22)
        Me.txtS12.TabIndex = 9
        '
        'txtS11
        '
        Me.txtS11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS11.Location = New System.Drawing.Point(0, 219)
        Me.txtS11.MaxLength = 2
        Me.txtS11.Name = "txtS11"
        Me.txtS11.Size = New System.Drawing.Size(58, 22)
        Me.txtS11.TabIndex = 10
        '
        'txtS10
        '
        Me.txtS10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS10.Location = New System.Drawing.Point(0, 241)
        Me.txtS10.MaxLength = 2
        Me.txtS10.Name = "txtS10"
        Me.txtS10.Size = New System.Drawing.Size(58, 22)
        Me.txtS10.TabIndex = 11
        '
        'txtS9
        '
        Me.txtS9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS9.Location = New System.Drawing.Point(0, 263)
        Me.txtS9.MaxLength = 2
        Me.txtS9.Name = "txtS9"
        Me.txtS9.Size = New System.Drawing.Size(58, 22)
        Me.txtS9.TabIndex = 12
        '
        'txtS8
        '
        Me.txtS8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS8.Location = New System.Drawing.Point(0, 285)
        Me.txtS8.MaxLength = 2
        Me.txtS8.Name = "txtS8"
        Me.txtS8.Size = New System.Drawing.Size(58, 22)
        Me.txtS8.TabIndex = 13
        '
        'txtS7
        '
        Me.txtS7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS7.Location = New System.Drawing.Point(0, 307)
        Me.txtS7.MaxLength = 2
        Me.txtS7.Name = "txtS7"
        Me.txtS7.Size = New System.Drawing.Size(58, 22)
        Me.txtS7.TabIndex = 14
        '
        'txtS6
        '
        Me.txtS6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS6.Location = New System.Drawing.Point(0, 329)
        Me.txtS6.MaxLength = 2
        Me.txtS6.Name = "txtS6"
        Me.txtS6.Size = New System.Drawing.Size(58, 22)
        Me.txtS6.TabIndex = 15
        '
        'txtS5
        '
        Me.txtS5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS5.Location = New System.Drawing.Point(0, 351)
        Me.txtS5.MaxLength = 2
        Me.txtS5.Name = "txtS5"
        Me.txtS5.Size = New System.Drawing.Size(58, 22)
        Me.txtS5.TabIndex = 16
        '
        'txtS4
        '
        Me.txtS4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS4.Location = New System.Drawing.Point(0, 373)
        Me.txtS4.MaxLength = 2
        Me.txtS4.Name = "txtS4"
        Me.txtS4.Size = New System.Drawing.Size(58, 22)
        Me.txtS4.TabIndex = 17
        '
        'txtS3
        '
        Me.txtS3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS3.Location = New System.Drawing.Point(0, 395)
        Me.txtS3.MaxLength = 2
        Me.txtS3.Name = "txtS3"
        Me.txtS3.Size = New System.Drawing.Size(58, 22)
        Me.txtS3.TabIndex = 18
        '
        'txtS2
        '
        Me.txtS2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtS2.Location = New System.Drawing.Point(0, 417)
        Me.txtS2.MaxLength = 2
        Me.txtS2.Name = "txtS2"
        Me.txtS2.Size = New System.Drawing.Size(58, 22)
        Me.txtS2.TabIndex = 19
        '
        'pnlA
        '
        Me.pnlA.BackColor = System.Drawing.Color.Silver
        Me.pnlA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlA.Controls.Add(Me.txtA17)
        Me.pnlA.Controls.Add(Me.txtA16)
        Me.pnlA.Controls.Add(Me.txtA15)
        Me.pnlA.Controls.Add(Me.txtA14)
        Me.pnlA.Controls.Add(Me.txtA13)
        Me.pnlA.Controls.Add(Me.txtA12)
        Me.pnlA.Controls.Add(Me.txtA11)
        Me.pnlA.Controls.Add(Me.txtA10)
        Me.pnlA.Controls.Add(Me.txtA9)
        Me.pnlA.Controls.Add(Me.txtA8)
        Me.pnlA.Controls.Add(Me.txtA7)
        Me.pnlA.Controls.Add(Me.txtA6)
        Me.pnlA.Controls.Add(Me.txtA5)
        Me.pnlA.Controls.Add(Me.txtA4)
        Me.pnlA.Location = New System.Drawing.Point(716, 215)
        Me.pnlA.Name = "pnlA"
        Me.pnlA.Size = New System.Drawing.Size(176, 309)
        Me.pnlA.TabIndex = 4
        '
        'txtA17
        '
        Me.txtA17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA17.Location = New System.Drawing.Point(0, -1)
        Me.txtA17.MaxLength = 10
        Me.txtA17.Name = "txtA17"
        Me.txtA17.Size = New System.Drawing.Size(174, 22)
        Me.txtA17.TabIndex = 0
        '
        'txtA16
        '
        Me.txtA16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA16.Location = New System.Drawing.Point(0, 21)
        Me.txtA16.MaxLength = 10
        Me.txtA16.Name = "txtA16"
        Me.txtA16.Size = New System.Drawing.Size(174, 22)
        Me.txtA16.TabIndex = 1
        '
        'txtA15
        '
        Me.txtA15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA15.Location = New System.Drawing.Point(0, 43)
        Me.txtA15.MaxLength = 10
        Me.txtA15.Name = "txtA15"
        Me.txtA15.Size = New System.Drawing.Size(174, 22)
        Me.txtA15.TabIndex = 2
        '
        'txtA14
        '
        Me.txtA14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA14.Location = New System.Drawing.Point(0, 65)
        Me.txtA14.MaxLength = 10
        Me.txtA14.Name = "txtA14"
        Me.txtA14.Size = New System.Drawing.Size(174, 22)
        Me.txtA14.TabIndex = 3
        '
        'txtA13
        '
        Me.txtA13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA13.Location = New System.Drawing.Point(0, 87)
        Me.txtA13.MaxLength = 10
        Me.txtA13.Name = "txtA13"
        Me.txtA13.Size = New System.Drawing.Size(174, 22)
        Me.txtA13.TabIndex = 4
        '
        'txtA12
        '
        Me.txtA12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA12.Location = New System.Drawing.Point(0, 109)
        Me.txtA12.MaxLength = 10
        Me.txtA12.Name = "txtA12"
        Me.txtA12.Size = New System.Drawing.Size(174, 22)
        Me.txtA12.TabIndex = 5
        '
        'txtA11
        '
        Me.txtA11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA11.Location = New System.Drawing.Point(0, 131)
        Me.txtA11.MaxLength = 10
        Me.txtA11.Name = "txtA11"
        Me.txtA11.Size = New System.Drawing.Size(174, 22)
        Me.txtA11.TabIndex = 6
        '
        'txtA10
        '
        Me.txtA10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA10.Location = New System.Drawing.Point(0, 153)
        Me.txtA10.MaxLength = 10
        Me.txtA10.Name = "txtA10"
        Me.txtA10.Size = New System.Drawing.Size(174, 22)
        Me.txtA10.TabIndex = 7
        '
        'txtA9
        '
        Me.txtA9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA9.Location = New System.Drawing.Point(0, 175)
        Me.txtA9.MaxLength = 10
        Me.txtA9.Name = "txtA9"
        Me.txtA9.Size = New System.Drawing.Size(174, 22)
        Me.txtA9.TabIndex = 8
        '
        'txtA8
        '
        Me.txtA8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA8.Location = New System.Drawing.Point(0, 197)
        Me.txtA8.MaxLength = 10
        Me.txtA8.Name = "txtA8"
        Me.txtA8.Size = New System.Drawing.Size(174, 22)
        Me.txtA8.TabIndex = 9
        '
        'txtA7
        '
        Me.txtA7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA7.Location = New System.Drawing.Point(0, 219)
        Me.txtA7.MaxLength = 10
        Me.txtA7.Name = "txtA7"
        Me.txtA7.Size = New System.Drawing.Size(174, 22)
        Me.txtA7.TabIndex = 10
        '
        'txtA6
        '
        Me.txtA6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA6.Location = New System.Drawing.Point(0, 241)
        Me.txtA6.MaxLength = 10
        Me.txtA6.Name = "txtA6"
        Me.txtA6.Size = New System.Drawing.Size(174, 22)
        Me.txtA6.TabIndex = 11
        '
        'txtA5
        '
        Me.txtA5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA5.Location = New System.Drawing.Point(0, 263)
        Me.txtA5.MaxLength = 10
        Me.txtA5.Name = "txtA5"
        Me.txtA5.Size = New System.Drawing.Size(174, 22)
        Me.txtA5.TabIndex = 12
        '
        'txtA4
        '
        Me.txtA4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtA4.Location = New System.Drawing.Point(0, 285)
        Me.txtA4.MaxLength = 10
        Me.txtA4.Name = "txtA4"
        Me.txtA4.Size = New System.Drawing.Size(174, 22)
        Me.txtA4.TabIndex = 13
        '
        'pnlR
        '
        Me.pnlR.BackColor = System.Drawing.Color.Silver
        Me.pnlR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlR.Controls.Add(Me.txtR17)
        Me.pnlR.Controls.Add(Me.txtR16)
        Me.pnlR.Controls.Add(Me.txtR15)
        Me.pnlR.Controls.Add(Me.txtR14)
        Me.pnlR.Controls.Add(Me.tctR13)
        Me.pnlR.Controls.Add(Me.txtR12)
        Me.pnlR.Controls.Add(Me.txtR11)
        Me.pnlR.Controls.Add(Me.txtR10)
        Me.pnlR.Controls.Add(Me.txtR9)
        Me.pnlR.Controls.Add(Me.txtR8)
        Me.pnlR.Controls.Add(Me.txtR7)
        Me.pnlR.Controls.Add(Me.txtR6)
        Me.pnlR.Controls.Add(Me.txtR5)
        Me.pnlR.Controls.Add(Me.txtR4)
        Me.pnlR.Location = New System.Drawing.Point(581, 214)
        Me.pnlR.Name = "pnlR"
        Me.pnlR.Size = New System.Drawing.Size(128, 309)
        Me.pnlR.TabIndex = 3
        '
        'txtR17
        '
        Me.txtR17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR17.Location = New System.Drawing.Point(0, -1)
        Me.txtR17.MaxLength = 7
        Me.txtR17.Name = "txtR17"
        Me.txtR17.Size = New System.Drawing.Size(126, 22)
        Me.txtR17.TabIndex = 0
        '
        'txtR16
        '
        Me.txtR16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR16.Location = New System.Drawing.Point(0, 21)
        Me.txtR16.MaxLength = 7
        Me.txtR16.Name = "txtR16"
        Me.txtR16.Size = New System.Drawing.Size(126, 22)
        Me.txtR16.TabIndex = 1
        '
        'txtR15
        '
        Me.txtR15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR15.Location = New System.Drawing.Point(0, 43)
        Me.txtR15.MaxLength = 7
        Me.txtR15.Name = "txtR15"
        Me.txtR15.Size = New System.Drawing.Size(126, 22)
        Me.txtR15.TabIndex = 2
        '
        'txtR14
        '
        Me.txtR14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR14.Location = New System.Drawing.Point(0, 65)
        Me.txtR14.MaxLength = 7
        Me.txtR14.Name = "txtR14"
        Me.txtR14.Size = New System.Drawing.Size(126, 22)
        Me.txtR14.TabIndex = 3
        '
        'tctR13
        '
        Me.tctR13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tctR13.Location = New System.Drawing.Point(0, 87)
        Me.tctR13.MaxLength = 7
        Me.tctR13.Name = "tctR13"
        Me.tctR13.Size = New System.Drawing.Size(126, 22)
        Me.tctR13.TabIndex = 4
        '
        'txtR12
        '
        Me.txtR12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR12.Location = New System.Drawing.Point(0, 109)
        Me.txtR12.MaxLength = 7
        Me.txtR12.Name = "txtR12"
        Me.txtR12.Size = New System.Drawing.Size(126, 22)
        Me.txtR12.TabIndex = 5
        '
        'txtR11
        '
        Me.txtR11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR11.Location = New System.Drawing.Point(0, 131)
        Me.txtR11.MaxLength = 7
        Me.txtR11.Name = "txtR11"
        Me.txtR11.Size = New System.Drawing.Size(126, 22)
        Me.txtR11.TabIndex = 6
        '
        'txtR10
        '
        Me.txtR10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR10.Location = New System.Drawing.Point(0, 153)
        Me.txtR10.MaxLength = 7
        Me.txtR10.Name = "txtR10"
        Me.txtR10.Size = New System.Drawing.Size(126, 22)
        Me.txtR10.TabIndex = 7
        '
        'txtR9
        '
        Me.txtR9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR9.Location = New System.Drawing.Point(0, 175)
        Me.txtR9.MaxLength = 7
        Me.txtR9.Name = "txtR9"
        Me.txtR9.Size = New System.Drawing.Size(126, 22)
        Me.txtR9.TabIndex = 8
        '
        'txtR8
        '
        Me.txtR8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR8.Location = New System.Drawing.Point(0, 197)
        Me.txtR8.MaxLength = 7
        Me.txtR8.Name = "txtR8"
        Me.txtR8.Size = New System.Drawing.Size(126, 22)
        Me.txtR8.TabIndex = 9
        '
        'txtR7
        '
        Me.txtR7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR7.Location = New System.Drawing.Point(0, 219)
        Me.txtR7.MaxLength = 7
        Me.txtR7.Name = "txtR7"
        Me.txtR7.Size = New System.Drawing.Size(126, 22)
        Me.txtR7.TabIndex = 10
        '
        'txtR6
        '
        Me.txtR6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR6.Location = New System.Drawing.Point(0, 241)
        Me.txtR6.MaxLength = 7
        Me.txtR6.Name = "txtR6"
        Me.txtR6.Size = New System.Drawing.Size(126, 22)
        Me.txtR6.TabIndex = 11
        '
        'txtR5
        '
        Me.txtR5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR5.Location = New System.Drawing.Point(0, 263)
        Me.txtR5.MaxLength = 7
        Me.txtR5.Name = "txtR5"
        Me.txtR5.Size = New System.Drawing.Size(126, 22)
        Me.txtR5.TabIndex = 12
        '
        'txtR4
        '
        Me.txtR4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtR4.Location = New System.Drawing.Point(0, 285)
        Me.txtR4.MaxLength = 7
        Me.txtR4.Name = "txtR4"
        Me.txtR4.Size = New System.Drawing.Size(126, 22)
        Me.txtR4.TabIndex = 13
        '
        'pnlQ
        '
        Me.pnlQ.BackColor = System.Drawing.Color.Silver
        Me.pnlQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQ.Controls.Add(Me.txtQ21)
        Me.pnlQ.Controls.Add(Me.txtQ20)
        Me.pnlQ.Controls.Add(Me.txtQ19)
        Me.pnlQ.Controls.Add(Me.txtQ18)
        Me.pnlQ.Controls.Add(Me.txtQ17)
        Me.pnlQ.Controls.Add(Me.txtQ16)
        Me.pnlQ.Controls.Add(Me.txtQ15)
        Me.pnlQ.Controls.Add(Me.txtQ14)
        Me.pnlQ.Controls.Add(Me.txtQ13)
        Me.pnlQ.Controls.Add(Me.txtQ12)
        Me.pnlQ.Controls.Add(Me.txtQ11)
        Me.pnlQ.Controls.Add(Me.txtQ10)
        Me.pnlQ.Controls.Add(Me.txtQ9)
        Me.pnlQ.Controls.Add(Me.txtQ8)
        Me.pnlQ.Controls.Add(Me.txtQ7)
        Me.pnlQ.Controls.Add(Me.txtQ6)
        Me.pnlQ.Controls.Add(Me.txtQ5)
        Me.pnlQ.Controls.Add(Me.txtQ4)
        Me.pnlQ.Controls.Add(Me.txtQ3)
        Me.pnlQ.Controls.Add(Me.txtQ2)
        Me.pnlQ.Location = New System.Drawing.Point(480, 214)
        Me.pnlQ.Name = "pnlQ"
        Me.pnlQ.Size = New System.Drawing.Size(88, 441)
        Me.pnlQ.TabIndex = 2
        '
        'txtQ21
        '
        Me.txtQ21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ21.Location = New System.Drawing.Point(0, -1)
        Me.txtQ21.MaxLength = 3
        Me.txtQ21.Name = "txtQ21"
        Me.txtQ21.Size = New System.Drawing.Size(86, 22)
        Me.txtQ21.TabIndex = 0
        '
        'txtQ20
        '
        Me.txtQ20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ20.Location = New System.Drawing.Point(0, 21)
        Me.txtQ20.MaxLength = 3
        Me.txtQ20.Name = "txtQ20"
        Me.txtQ20.Size = New System.Drawing.Size(86, 22)
        Me.txtQ20.TabIndex = 1
        '
        'txtQ19
        '
        Me.txtQ19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ19.Location = New System.Drawing.Point(0, 43)
        Me.txtQ19.MaxLength = 3
        Me.txtQ19.Name = "txtQ19"
        Me.txtQ19.Size = New System.Drawing.Size(86, 22)
        Me.txtQ19.TabIndex = 2
        '
        'txtQ18
        '
        Me.txtQ18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ18.Location = New System.Drawing.Point(0, 65)
        Me.txtQ18.MaxLength = 3
        Me.txtQ18.Name = "txtQ18"
        Me.txtQ18.Size = New System.Drawing.Size(86, 22)
        Me.txtQ18.TabIndex = 3
        '
        'txtQ17
        '
        Me.txtQ17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ17.Location = New System.Drawing.Point(0, 87)
        Me.txtQ17.MaxLength = 3
        Me.txtQ17.Name = "txtQ17"
        Me.txtQ17.Size = New System.Drawing.Size(86, 22)
        Me.txtQ17.TabIndex = 4
        '
        'txtQ16
        '
        Me.txtQ16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ16.Location = New System.Drawing.Point(0, 109)
        Me.txtQ16.MaxLength = 3
        Me.txtQ16.Name = "txtQ16"
        Me.txtQ16.Size = New System.Drawing.Size(86, 22)
        Me.txtQ16.TabIndex = 5
        '
        'txtQ15
        '
        Me.txtQ15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ15.Location = New System.Drawing.Point(0, 131)
        Me.txtQ15.MaxLength = 3
        Me.txtQ15.Name = "txtQ15"
        Me.txtQ15.Size = New System.Drawing.Size(86, 22)
        Me.txtQ15.TabIndex = 6
        '
        'txtQ14
        '
        Me.txtQ14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ14.Location = New System.Drawing.Point(0, 153)
        Me.txtQ14.MaxLength = 3
        Me.txtQ14.Name = "txtQ14"
        Me.txtQ14.Size = New System.Drawing.Size(86, 22)
        Me.txtQ14.TabIndex = 7
        '
        'txtQ13
        '
        Me.txtQ13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ13.Location = New System.Drawing.Point(0, 175)
        Me.txtQ13.MaxLength = 3
        Me.txtQ13.Name = "txtQ13"
        Me.txtQ13.Size = New System.Drawing.Size(86, 22)
        Me.txtQ13.TabIndex = 8
        '
        'txtQ12
        '
        Me.txtQ12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ12.Location = New System.Drawing.Point(0, 197)
        Me.txtQ12.MaxLength = 3
        Me.txtQ12.Name = "txtQ12"
        Me.txtQ12.Size = New System.Drawing.Size(86, 22)
        Me.txtQ12.TabIndex = 9
        '
        'txtQ11
        '
        Me.txtQ11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ11.Location = New System.Drawing.Point(0, 219)
        Me.txtQ11.MaxLength = 3
        Me.txtQ11.Name = "txtQ11"
        Me.txtQ11.Size = New System.Drawing.Size(86, 22)
        Me.txtQ11.TabIndex = 10
        '
        'txtQ10
        '
        Me.txtQ10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ10.Location = New System.Drawing.Point(0, 241)
        Me.txtQ10.MaxLength = 3
        Me.txtQ10.Name = "txtQ10"
        Me.txtQ10.Size = New System.Drawing.Size(86, 22)
        Me.txtQ10.TabIndex = 11
        '
        'txtQ9
        '
        Me.txtQ9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ9.Location = New System.Drawing.Point(0, 263)
        Me.txtQ9.MaxLength = 3
        Me.txtQ9.Name = "txtQ9"
        Me.txtQ9.Size = New System.Drawing.Size(86, 22)
        Me.txtQ9.TabIndex = 12
        '
        'txtQ8
        '
        Me.txtQ8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ8.Location = New System.Drawing.Point(0, 285)
        Me.txtQ8.MaxLength = 3
        Me.txtQ8.Name = "txtQ8"
        Me.txtQ8.Size = New System.Drawing.Size(86, 22)
        Me.txtQ8.TabIndex = 13
        '
        'txtQ7
        '
        Me.txtQ7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ7.Location = New System.Drawing.Point(0, 307)
        Me.txtQ7.MaxLength = 3
        Me.txtQ7.Name = "txtQ7"
        Me.txtQ7.Size = New System.Drawing.Size(86, 22)
        Me.txtQ7.TabIndex = 14
        '
        'txtQ6
        '
        Me.txtQ6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ6.Location = New System.Drawing.Point(0, 329)
        Me.txtQ6.MaxLength = 3
        Me.txtQ6.Name = "txtQ6"
        Me.txtQ6.Size = New System.Drawing.Size(86, 22)
        Me.txtQ6.TabIndex = 15
        '
        'txtQ5
        '
        Me.txtQ5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ5.Location = New System.Drawing.Point(0, 351)
        Me.txtQ5.MaxLength = 3
        Me.txtQ5.Name = "txtQ5"
        Me.txtQ5.Size = New System.Drawing.Size(86, 22)
        Me.txtQ5.TabIndex = 16
        '
        'txtQ4
        '
        Me.txtQ4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ4.Location = New System.Drawing.Point(0, 373)
        Me.txtQ4.MaxLength = 3
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(86, 22)
        Me.txtQ4.TabIndex = 17
        '
        'txtQ3
        '
        Me.txtQ3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ3.Location = New System.Drawing.Point(0, 395)
        Me.txtQ3.MaxLength = 3
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.Size = New System.Drawing.Size(86, 22)
        Me.txtQ3.TabIndex = 18
        '
        'txtQ2
        '
        Me.txtQ2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtQ2.Location = New System.Drawing.Point(0, 417)
        Me.txtQ2.MaxLength = 3
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.Size = New System.Drawing.Size(86, 22)
        Me.txtQ2.TabIndex = 19
        '
        'pnlSP
        '
        Me.pnlSP.BackColor = System.Drawing.Color.Silver
        Me.pnlSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSP.Controls.Add(Me.txtP21)
        Me.pnlSP.Controls.Add(Me.txtP20)
        Me.pnlSP.Controls.Add(Me.txtP19)
        Me.pnlSP.Controls.Add(Me.txtP18)
        Me.pnlSP.Controls.Add(Me.txtP17)
        Me.pnlSP.Controls.Add(Me.txtP16)
        Me.pnlSP.Controls.Add(Me.txtP15)
        Me.pnlSP.Controls.Add(Me.txtP14)
        Me.pnlSP.Controls.Add(Me.txtP13)
        Me.pnlSP.Controls.Add(Me.txtP12)
        Me.pnlSP.Controls.Add(Me.txtP11)
        Me.pnlSP.Controls.Add(Me.txtP10)
        Me.pnlSP.Controls.Add(Me.txtP9)
        Me.pnlSP.Controls.Add(Me.txtP8)
        Me.pnlSP.Controls.Add(Me.txtP7)
        Me.pnlSP.Controls.Add(Me.txtP6)
        Me.pnlSP.Controls.Add(Me.txtP5)
        Me.pnlSP.Controls.Add(Me.txtP4)
        Me.pnlSP.Controls.Add(Me.txtP3)
        Me.pnlSP.Controls.Add(Me.txtP2)
        Me.pnlSP.Location = New System.Drawing.Point(91, 214)
        Me.pnlSP.Name = "pnlSP"
        Me.pnlSP.Size = New System.Drawing.Size(386, 441)
        Me.pnlSP.TabIndex = 1
        '
        'txtP21
        '
        Me.txtP21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP21.Location = New System.Drawing.Point(0, -1)
        Me.txtP21.MaxLength = 45
        Me.txtP21.Name = "txtP21"
        Me.txtP21.Size = New System.Drawing.Size(384, 22)
        Me.txtP21.TabIndex = 0
        '
        'txtP20
        '
        Me.txtP20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP20.Location = New System.Drawing.Point(0, 21)
        Me.txtP20.MaxLength = 45
        Me.txtP20.Name = "txtP20"
        Me.txtP20.Size = New System.Drawing.Size(384, 22)
        Me.txtP20.TabIndex = 1
        '
        'txtP19
        '
        Me.txtP19.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP19.Location = New System.Drawing.Point(0, 43)
        Me.txtP19.MaxLength = 45
        Me.txtP19.Name = "txtP19"
        Me.txtP19.Size = New System.Drawing.Size(384, 22)
        Me.txtP19.TabIndex = 2
        '
        'txtP18
        '
        Me.txtP18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP18.Location = New System.Drawing.Point(0, 65)
        Me.txtP18.MaxLength = 45
        Me.txtP18.Name = "txtP18"
        Me.txtP18.Size = New System.Drawing.Size(384, 22)
        Me.txtP18.TabIndex = 3
        '
        'txtP17
        '
        Me.txtP17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP17.Location = New System.Drawing.Point(0, 87)
        Me.txtP17.MaxLength = 45
        Me.txtP17.Name = "txtP17"
        Me.txtP17.Size = New System.Drawing.Size(384, 22)
        Me.txtP17.TabIndex = 4
        '
        'txtP16
        '
        Me.txtP16.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP16.Location = New System.Drawing.Point(0, 109)
        Me.txtP16.MaxLength = 45
        Me.txtP16.Name = "txtP16"
        Me.txtP16.Size = New System.Drawing.Size(384, 22)
        Me.txtP16.TabIndex = 5
        '
        'txtP15
        '
        Me.txtP15.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP15.Location = New System.Drawing.Point(0, 131)
        Me.txtP15.MaxLength = 45
        Me.txtP15.Name = "txtP15"
        Me.txtP15.Size = New System.Drawing.Size(384, 22)
        Me.txtP15.TabIndex = 6
        '
        'txtP14
        '
        Me.txtP14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP14.Location = New System.Drawing.Point(0, 153)
        Me.txtP14.MaxLength = 45
        Me.txtP14.Name = "txtP14"
        Me.txtP14.Size = New System.Drawing.Size(384, 22)
        Me.txtP14.TabIndex = 7
        '
        'txtP13
        '
        Me.txtP13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP13.Location = New System.Drawing.Point(0, 175)
        Me.txtP13.MaxLength = 45
        Me.txtP13.Name = "txtP13"
        Me.txtP13.Size = New System.Drawing.Size(384, 22)
        Me.txtP13.TabIndex = 8
        '
        'txtP12
        '
        Me.txtP12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP12.Location = New System.Drawing.Point(0, 197)
        Me.txtP12.MaxLength = 45
        Me.txtP12.Name = "txtP12"
        Me.txtP12.Size = New System.Drawing.Size(384, 22)
        Me.txtP12.TabIndex = 9
        '
        'txtP11
        '
        Me.txtP11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP11.Location = New System.Drawing.Point(0, 219)
        Me.txtP11.MaxLength = 45
        Me.txtP11.Name = "txtP11"
        Me.txtP11.Size = New System.Drawing.Size(384, 22)
        Me.txtP11.TabIndex = 10
        '
        'txtP10
        '
        Me.txtP10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP10.Location = New System.Drawing.Point(0, 241)
        Me.txtP10.MaxLength = 45
        Me.txtP10.Name = "txtP10"
        Me.txtP10.Size = New System.Drawing.Size(384, 22)
        Me.txtP10.TabIndex = 11
        '
        'txtP9
        '
        Me.txtP9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP9.Location = New System.Drawing.Point(0, 263)
        Me.txtP9.MaxLength = 45
        Me.txtP9.Name = "txtP9"
        Me.txtP9.Size = New System.Drawing.Size(384, 22)
        Me.txtP9.TabIndex = 12
        '
        'txtP8
        '
        Me.txtP8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP8.Location = New System.Drawing.Point(0, 285)
        Me.txtP8.MaxLength = 45
        Me.txtP8.Name = "txtP8"
        Me.txtP8.Size = New System.Drawing.Size(384, 22)
        Me.txtP8.TabIndex = 13
        '
        'txtP7
        '
        Me.txtP7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP7.Location = New System.Drawing.Point(0, 307)
        Me.txtP7.MaxLength = 45
        Me.txtP7.Name = "txtP7"
        Me.txtP7.Size = New System.Drawing.Size(384, 22)
        Me.txtP7.TabIndex = 14
        '
        'txtP6
        '
        Me.txtP6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP6.Location = New System.Drawing.Point(0, 329)
        Me.txtP6.MaxLength = 45
        Me.txtP6.Name = "txtP6"
        Me.txtP6.Size = New System.Drawing.Size(384, 22)
        Me.txtP6.TabIndex = 15
        '
        'txtP5
        '
        Me.txtP5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP5.Location = New System.Drawing.Point(0, 351)
        Me.txtP5.MaxLength = 45
        Me.txtP5.Name = "txtP5"
        Me.txtP5.Size = New System.Drawing.Size(384, 22)
        Me.txtP5.TabIndex = 16
        '
        'txtP4
        '
        Me.txtP4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP4.Location = New System.Drawing.Point(0, 373)
        Me.txtP4.MaxLength = 45
        Me.txtP4.Name = "txtP4"
        Me.txtP4.Size = New System.Drawing.Size(384, 22)
        Me.txtP4.TabIndex = 17
        '
        'txtP3
        '
        Me.txtP3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP3.Location = New System.Drawing.Point(0, 395)
        Me.txtP3.MaxLength = 45
        Me.txtP3.Name = "txtP3"
        Me.txtP3.Size = New System.Drawing.Size(384, 22)
        Me.txtP3.TabIndex = 18
        '
        'txtP2
        '
        Me.txtP2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtP2.Location = New System.Drawing.Point(0, 417)
        Me.txtP2.MaxLength = 45
        Me.txtP2.Name = "txtP2"
        Me.txtP2.Size = New System.Drawing.Size(384, 22)
        Me.txtP2.TabIndex = 19
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlImage.Controls.Add(Me.Label1)
        Me.pnlImage.Controls.Add(Me.pic1)
        Me.pnlImage.Location = New System.Drawing.Point(370, 310)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(200, 72)
        Me.pnlImage.TabIndex = 104
        Me.pnlImage.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Processing .."
        '
        'pic1
        '
        Me.pic1.Image = Global.PushpakBilling.My.Resources.Resources.Loader
        Me.pic1.Location = New System.Drawing.Point(21, 44)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(159, 18)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.cmbSelectProduct)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Location = New System.Drawing.Point(277, 5)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(386, 29)
        Me.pnlTop.TabIndex = 105
        '
        'lblNote
        '
        Me.lblNote.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.Red
        Me.lblNote.Location = New System.Drawing.Point(-4, 650)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(579, 35)
        Me.lblNote.TabIndex = 108
        Me.lblNote.Text = "Note : In the line you want to display the Engine number , put 'xxxxxxxxxx' after" & _
    " text                and for Chassis Number put 'yyyyyyyyyy' after text ."
        '
        'Tax
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 693)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlImage)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlBottom)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "Tax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tax Print"
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlC0.ResumeLayout(False)
        Me.pnlC0.PerformLayout()
        Me.pnlSlNo.ResumeLayout(False)
        Me.pnlSlNo.PerformLayout()
        Me.pnlA.ResumeLayout(False)
        Me.pnlA.PerformLayout()
        Me.pnlR.ResumeLayout(False)
        Me.pnlR.PerformLayout()
        Me.pnlQ.ResumeLayout(False)
        Me.pnlQ.PerformLayout()
        Me.pnlSP.ResumeLayout(False)
        Me.pnlSP.PerformLayout()
        Me.pnlImage.ResumeLayout(False)
        Me.pnlImage.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSelectProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Private WithEvents pnlC0 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtNetAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtVatAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents pnlSlNo As System.Windows.Forms.Panel
    Friend WithEvents txtS21 As System.Windows.Forms.TextBox
    Friend WithEvents txtS20 As System.Windows.Forms.TextBox
    Friend WithEvents txtS19 As System.Windows.Forms.TextBox
    Friend WithEvents txtS18 As System.Windows.Forms.TextBox
    Friend WithEvents txtS17 As System.Windows.Forms.TextBox
    Friend WithEvents txtS16 As System.Windows.Forms.TextBox
    Friend WithEvents txtS15 As System.Windows.Forms.TextBox
    Friend WithEvents txtS14 As System.Windows.Forms.TextBox
    Friend WithEvents txtS13 As System.Windows.Forms.TextBox
    Friend WithEvents txtS12 As System.Windows.Forms.TextBox
    Friend WithEvents txtS11 As System.Windows.Forms.TextBox
    Friend WithEvents txtS10 As System.Windows.Forms.TextBox
    Friend WithEvents txtS9 As System.Windows.Forms.TextBox
    Friend WithEvents txtS8 As System.Windows.Forms.TextBox
    Friend WithEvents txtS7 As System.Windows.Forms.TextBox
    Friend WithEvents txtS6 As System.Windows.Forms.TextBox
    Friend WithEvents txtS5 As System.Windows.Forms.TextBox
    Friend WithEvents txtS4 As System.Windows.Forms.TextBox
    Friend WithEvents txtS3 As System.Windows.Forms.TextBox
    Friend WithEvents txtS2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlA As System.Windows.Forms.Panel
    Friend WithEvents txtA17 As System.Windows.Forms.TextBox
    Friend WithEvents txtA16 As System.Windows.Forms.TextBox
    Friend WithEvents txtA15 As System.Windows.Forms.TextBox
    Friend WithEvents txtA14 As System.Windows.Forms.TextBox
    Friend WithEvents txtA13 As System.Windows.Forms.TextBox
    Friend WithEvents txtA12 As System.Windows.Forms.TextBox
    Friend WithEvents txtA11 As System.Windows.Forms.TextBox
    Friend WithEvents txtA10 As System.Windows.Forms.TextBox
    Friend WithEvents txtA9 As System.Windows.Forms.TextBox
    Friend WithEvents txtA8 As System.Windows.Forms.TextBox
    Friend WithEvents txtA7 As System.Windows.Forms.TextBox
    Friend WithEvents txtA6 As System.Windows.Forms.TextBox
    Friend WithEvents txtA5 As System.Windows.Forms.TextBox
    Friend WithEvents txtA4 As System.Windows.Forms.TextBox
    Friend WithEvents pnlR As System.Windows.Forms.Panel
    Friend WithEvents txtR17 As System.Windows.Forms.TextBox
    Friend WithEvents txtR16 As System.Windows.Forms.TextBox
    Friend WithEvents txtR15 As System.Windows.Forms.TextBox
    Friend WithEvents txtR14 As System.Windows.Forms.TextBox
    Friend WithEvents tctR13 As System.Windows.Forms.TextBox
    Friend WithEvents txtR12 As System.Windows.Forms.TextBox
    Friend WithEvents txtR11 As System.Windows.Forms.TextBox
    Friend WithEvents txtR10 As System.Windows.Forms.TextBox
    Friend WithEvents txtR9 As System.Windows.Forms.TextBox
    Friend WithEvents txtR8 As System.Windows.Forms.TextBox
    Friend WithEvents txtR7 As System.Windows.Forms.TextBox
    Friend WithEvents txtR6 As System.Windows.Forms.TextBox
    Friend WithEvents txtR5 As System.Windows.Forms.TextBox
    Friend WithEvents txtR4 As System.Windows.Forms.TextBox
    Friend WithEvents pnlQ As System.Windows.Forms.Panel
    Friend WithEvents txtQ21 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ20 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ19 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ18 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ17 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ16 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ15 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ14 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ13 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ12 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ11 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ10 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ9 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ8 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ7 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ6 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ5 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlSP As System.Windows.Forms.Panel
    Friend WithEvents txtP21 As System.Windows.Forms.TextBox
    Friend WithEvents txtP20 As System.Windows.Forms.TextBox
    Friend WithEvents txtP19 As System.Windows.Forms.TextBox
    Friend WithEvents txtP18 As System.Windows.Forms.TextBox
    Friend WithEvents txtP17 As System.Windows.Forms.TextBox
    Friend WithEvents txtP16 As System.Windows.Forms.TextBox
    Friend WithEvents txtP15 As System.Windows.Forms.TextBox
    Friend WithEvents txtP14 As System.Windows.Forms.TextBox
    Friend WithEvents txtP13 As System.Windows.Forms.TextBox
    Friend WithEvents txtP12 As System.Windows.Forms.TextBox
    Friend WithEvents txtP11 As System.Windows.Forms.TextBox
    Friend WithEvents txtP10 As System.Windows.Forms.TextBox
    Friend WithEvents txtP9 As System.Windows.Forms.TextBox
    Friend WithEvents txtP8 As System.Windows.Forms.TextBox
    Friend WithEvents txtP7 As System.Windows.Forms.TextBox
    Friend WithEvents txtP6 As System.Windows.Forms.TextBox
    Friend WithEvents txtP5 As System.Windows.Forms.TextBox
    Friend WithEvents txtP4 As System.Windows.Forms.TextBox
    Friend WithEvents txtP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtP2 As System.Windows.Forms.TextBox
    Friend WithEvents pnlImage As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblNote As System.Windows.Forms.Label

End Class
