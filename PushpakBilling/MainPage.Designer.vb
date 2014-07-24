<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.cmbSet = New System.Windows.Forms.ComboBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lnkInvoice = New System.Windows.Forms.LinkLabel()
        Me.lnkChallan = New System.Windows.Forms.LinkLabel()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lnkTax = New System.Windows.Forms.LinkLabel()
        Me.lnkItemMaster = New System.Windows.Forms.LinkLabel()
        Me.ExpandablePanel1.SuspendLayout()
        Me.pnlImage.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpandablePanel1
        '
        Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.ExpandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ExpandablePanel1.Controls.Add(Me.lnkItemMaster)
        Me.ExpandablePanel1.Controls.Add(Me.lnkTax)
        Me.ExpandablePanel1.Controls.Add(Me.btnSet)
        Me.ExpandablePanel1.Controls.Add(Me.cmbSet)
        Me.ExpandablePanel1.Controls.Add(Me.LinkLabel1)
        Me.ExpandablePanel1.Controls.Add(Me.PictureBox1)
        Me.ExpandablePanel1.Controls.Add(Me.lnkInvoice)
        Me.ExpandablePanel1.Controls.Add(Me.lnkChallan)
        Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ExpandablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.ExpandablePanel1.Name = "ExpandablePanel1"
        Me.ExpandablePanel1.Size = New System.Drawing.Size(200, 702)
        Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.ExpandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandablePanel1.Style.GradientAngle = 90
        Me.ExpandablePanel1.TabIndex = 1
        Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
        Me.ExpandablePanel1.TitleText = "Main Panel"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(77, 200)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(46, 23)
        Me.btnSet.TabIndex = 8
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'cmbSet
        '
        Me.cmbSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSet.FormattingEnabled = True
        Me.cmbSet.Location = New System.Drawing.Point(40, 170)
        Me.cmbSet.Name = "cmbSet"
        Me.cmbSet.Size = New System.Drawing.Size(121, 24)
        Me.cmbSet.TabIndex = 7
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(40, 148)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Set FinancialYear"
        '
        'lnkInvoice
        '
        Me.lnkInvoice.AutoSize = True
        Me.lnkInvoice.BackColor = System.Drawing.Color.Transparent
        Me.lnkInvoice.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkInvoice.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkInvoice.Location = New System.Drawing.Point(47, 67)
        Me.lnkInvoice.Name = "lnkInvoice"
        Me.lnkInvoice.Size = New System.Drawing.Size(106, 16)
        Me.lnkInvoice.TabIndex = 2
        Me.lnkInvoice.TabStop = True
        Me.lnkInvoice.Text = "Invoice Section"
        '
        'lnkChallan
        '
        Me.lnkChallan.AutoSize = True
        Me.lnkChallan.BackColor = System.Drawing.Color.Transparent
        Me.lnkChallan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkChallan.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkChallan.Location = New System.Drawing.Point(46, 40)
        Me.lnkChallan.Name = "lnkChallan"
        Me.lnkChallan.Size = New System.Drawing.Size(109, 16)
        Me.lnkChallan.TabIndex = 1
        Me.lnkChallan.TabStop = True
        Me.lnkChallan.Text = "Challan Section"
        '
        'bgWorker
        '
        '
        'pnlImage
        '
        Me.pnlImage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlImage.Controls.Add(Me.Label1)
        Me.pnlImage.Controls.Add(Me.pic1)
        Me.pnlImage.Location = New System.Drawing.Point(371, 317)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(200, 72)
        Me.pnlImage.TabIndex = 106
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.PushpakBilling.My.Resources.Resources.developed_by_info_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 652)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lnkTax
        '
        Me.lnkTax.AutoSize = True
        Me.lnkTax.BackColor = System.Drawing.Color.Transparent
        Me.lnkTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkTax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkTax.Location = New System.Drawing.Point(59, 94)
        Me.lnkTax.Name = "lnkTax"
        Me.lnkTax.Size = New System.Drawing.Size(83, 16)
        Me.lnkTax.TabIndex = 9
        Me.lnkTax.TabStop = True
        Me.lnkTax.Text = "Tax Section"
        '
        'lnkItemMaster
        '
        Me.lnkItemMaster.AutoSize = True
        Me.lnkItemMaster.BackColor = System.Drawing.Color.Transparent
        Me.lnkItemMaster.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkItemMaster.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkItemMaster.Location = New System.Drawing.Point(59, 121)
        Me.lnkItemMaster.Name = "lnkItemMaster"
        Me.lnkItemMaster.Size = New System.Drawing.Size(82, 16)
        Me.lnkItemMaster.TabIndex = 10
        Me.lnkItemMaster.TabStop = True
        Me.lnkItemMaster.Text = "Item Master"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 702)
        Me.Controls.Add(Me.pnlImage)
        Me.Controls.Add(Me.ExpandablePanel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pushpak Traders Billing Server"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ExpandablePanel1.ResumeLayout(False)
        Me.ExpandablePanel1.PerformLayout()
        Me.pnlImage.ResumeLayout(False)
        Me.pnlImage.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Friend WithEvents lnkInvoice As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkChallan As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents cmbSet As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents pnlImage As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents lnkItemMaster As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkTax As System.Windows.Forms.LinkLabel
End Class
