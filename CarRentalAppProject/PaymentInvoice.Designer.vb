<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentInvoice
    Inherits System.Windows.Forms.Form

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
        Me.lblInvoiceInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblInvoieID = New System.Windows.Forms.Label()
        Me.txtInvoiceID = New System.Windows.Forms.TextBox()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblPaymentInformation = New System.Windows.Forms.Label()
        Me.lblCCtype = New System.Windows.Forms.Label()
        Me.cmbCCtype = New System.Windows.Forms.ComboBox()
        Me.lblCCNumber = New System.Windows.Forms.Label()
        Me.txtCCNumber = New System.Windows.Forms.TextBox()
        Me.lblSecurityCode = New System.Windows.Forms.Label()
        Me.txtSecurityCode = New System.Windows.Forms.TextBox()
        Me.lblExpirationDate = New System.Windows.Forms.Label()
        Me.cmbExpMM = New System.Windows.Forms.ComboBox()
        Me.lblExpMM = New System.Windows.Forms.Label()
        Me.cmbExpYY = New System.Windows.Forms.ComboBox()
        Me.lblExpYY = New System.Windows.Forms.Label()
        Me.btnFinalizeInvoice = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbxCostDetails = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtInsuranceFee = New System.Windows.Forms.TextBox()
        Me.lblInsuranceFee = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.ckbInsurance = New System.Windows.Forms.CheckBox()
        Me.lblCarRentalApp = New System.Windows.Forms.Label()
        Me.ckbPersonalIns = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblView = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxCostDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInvoiceInfo
        '
        Me.lblInvoiceInfo.AutoSize = True
        Me.lblInvoiceInfo.Location = New System.Drawing.Point(21, 48)
        Me.lblInvoiceInfo.Name = "lblInvoiceInfo"
        Me.lblInvoiceInfo.Size = New System.Drawing.Size(97, 13)
        Me.lblInvoiceInfo.TabIndex = 0
        Me.lblInvoiceInfo.Text = "Invoice Information"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'VehiclesToolStripMenuItem
        '
        Me.VehiclesToolStripMenuItem.Name = "VehiclesToolStripMenuItem"
        Me.VehiclesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VehiclesToolStripMenuItem.Text = "Vehicles"
        '
        'PriceOptionsToolStripMenuItem
        '
        Me.PriceOptionsToolStripMenuItem.Name = "PriceOptionsToolStripMenuItem"
        Me.PriceOptionsToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PriceOptionsToolStripMenuItem.Text = "Price Options"
        '
        'lblInvoieID
        '
        Me.lblInvoieID.AutoSize = True
        Me.lblInvoieID.Location = New System.Drawing.Point(41, 75)
        Me.lblInvoieID.Name = "lblInvoieID"
        Me.lblInvoieID.Size = New System.Drawing.Size(59, 13)
        Me.lblInvoieID.TabIndex = 45
        Me.lblInvoieID.Text = "Invoice ID:"
        '
        'txtInvoiceID
        '
        Me.txtInvoiceID.Location = New System.Drawing.Point(97, 68)
        Me.txtInvoiceID.Name = "txtInvoiceID"
        Me.txtInvoiceID.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceID.TabIndex = 46
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(44, 101)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(73, 13)
        Me.lblEmployeeID.TabIndex = 47
        Me.lblEmployeeID.Text = "Employee ID: "
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(124, 93)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeID.TabIndex = 48
        '
        'lblPaymentInformation
        '
        Me.lblPaymentInformation.AutoSize = True
        Me.lblPaymentInformation.Location = New System.Drawing.Point(21, 165)
        Me.lblPaymentInformation.Name = "lblPaymentInformation"
        Me.lblPaymentInformation.Size = New System.Drawing.Size(103, 13)
        Me.lblPaymentInformation.TabIndex = 49
        Me.lblPaymentInformation.Text = "Payment Information"
        '
        'lblCCtype
        '
        Me.lblCCtype.AutoSize = True
        Me.lblCCtype.Location = New System.Drawing.Point(28, 190)
        Me.lblCCtype.Name = "lblCCtype"
        Me.lblCCtype.Size = New System.Drawing.Size(89, 13)
        Me.lblCCtype.TabIndex = 50
        Me.lblCCtype.Text = "Credit Card Type:"
        '
        'cmbCCtype
        '
        Me.cmbCCtype.FormattingEnabled = True
        Me.cmbCCtype.Location = New System.Drawing.Point(124, 181)
        Me.cmbCCtype.Name = "cmbCCtype"
        Me.cmbCCtype.Size = New System.Drawing.Size(121, 21)
        Me.cmbCCtype.TabIndex = 51
        '
        'lblCCNumber
        '
        Me.lblCCNumber.AutoSize = True
        Me.lblCCNumber.Location = New System.Drawing.Point(16, 222)
        Me.lblCCNumber.Name = "lblCCNumber"
        Me.lblCCNumber.Size = New System.Drawing.Size(102, 13)
        Me.lblCCNumber.TabIndex = 52
        Me.lblCCNumber.Text = "Credit Card Number:"
        '
        'txtCCNumber
        '
        Me.txtCCNumber.Location = New System.Drawing.Point(124, 214)
        Me.txtCCNumber.Name = "txtCCNumber"
        Me.txtCCNumber.Size = New System.Drawing.Size(162, 20)
        Me.txtCCNumber.TabIndex = 53
        '
        'lblSecurityCode
        '
        Me.lblSecurityCode.AutoSize = True
        Me.lblSecurityCode.Location = New System.Drawing.Point(41, 249)
        Me.lblSecurityCode.Name = "lblSecurityCode"
        Me.lblSecurityCode.Size = New System.Drawing.Size(76, 13)
        Me.lblSecurityCode.TabIndex = 54
        Me.lblSecurityCode.Text = "Security Code:"
        '
        'txtSecurityCode
        '
        Me.txtSecurityCode.Location = New System.Drawing.Point(124, 249)
        Me.txtSecurityCode.Name = "txtSecurityCode"
        Me.txtSecurityCode.Size = New System.Drawing.Size(100, 20)
        Me.txtSecurityCode.TabIndex = 55
        '
        'lblExpirationDate
        '
        Me.lblExpirationDate.AutoSize = True
        Me.lblExpirationDate.Location = New System.Drawing.Point(35, 286)
        Me.lblExpirationDate.Name = "lblExpirationDate"
        Me.lblExpirationDate.Size = New System.Drawing.Size(82, 13)
        Me.lblExpirationDate.TabIndex = 56
        Me.lblExpirationDate.Text = "Expiration Date:"
        '
        'cmbExpMM
        '
        Me.cmbExpMM.FormattingEnabled = True
        Me.cmbExpMM.Location = New System.Drawing.Point(124, 305)
        Me.cmbExpMM.Name = "cmbExpMM"
        Me.cmbExpMM.Size = New System.Drawing.Size(40, 21)
        Me.cmbExpMM.TabIndex = 57
        '
        'lblExpMM
        '
        Me.lblExpMM.AutoSize = True
        Me.lblExpMM.Location = New System.Drawing.Point(124, 286)
        Me.lblExpMM.Name = "lblExpMM"
        Me.lblExpMM.Size = New System.Drawing.Size(37, 13)
        Me.lblExpMM.TabIndex = 58
        Me.lblExpMM.Text = "Month"
        '
        'cmbExpYY
        '
        Me.cmbExpYY.FormattingEnabled = True
        Me.cmbExpYY.Location = New System.Drawing.Point(182, 305)
        Me.cmbExpYY.Name = "cmbExpYY"
        Me.cmbExpYY.Size = New System.Drawing.Size(52, 21)
        Me.cmbExpYY.TabIndex = 59
        '
        'lblExpYY
        '
        Me.lblExpYY.AutoSize = True
        Me.lblExpYY.Location = New System.Drawing.Point(182, 286)
        Me.lblExpYY.Name = "lblExpYY"
        Me.lblExpYY.Size = New System.Drawing.Size(29, 13)
        Me.lblExpYY.TabIndex = 60
        Me.lblExpYY.Text = "Year"
        '
        'btnFinalizeInvoice
        '
        Me.btnFinalizeInvoice.Location = New System.Drawing.Point(396, 370)
        Me.btnFinalizeInvoice.Name = "btnFinalizeInvoice"
        Me.btnFinalizeInvoice.Size = New System.Drawing.Size(100, 23)
        Me.btnFinalizeInvoice.TabIndex = 61
        Me.btnFinalizeInvoice.Text = "Finalize Invoice"
        Me.btnFinalizeInvoice.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(289, 369)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 62
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'gbxCostDetails
        '
        Me.gbxCostDetails.Controls.Add(Me.Label1)
        Me.gbxCostDetails.Controls.Add(Me.txtFinalTotal)
        Me.gbxCostDetails.Controls.Add(Me.lblFinalTotal)
        Me.gbxCostDetails.Controls.Add(Me.txtTax)
        Me.gbxCostDetails.Controls.Add(Me.lblTax)
        Me.gbxCostDetails.Controls.Add(Me.txtSubtotal)
        Me.gbxCostDetails.Controls.Add(Me.lblSubtotal)
        Me.gbxCostDetails.Controls.Add(Me.txtInsuranceFee)
        Me.gbxCostDetails.Controls.Add(Me.lblInsuranceFee)
        Me.gbxCostDetails.Controls.Add(Me.TextBox6)
        Me.gbxCostDetails.Controls.Add(Me.Label12)
        Me.gbxCostDetails.Location = New System.Drawing.Point(311, 68)
        Me.gbxCostDetails.Name = "gbxCostDetails"
        Me.gbxCostDetails.Size = New System.Drawing.Size(234, 221)
        Me.gbxCostDetails.TabIndex = 63
        Me.gbxCostDetails.TabStop = False
        Me.gbxCostDetails.Text = "Price Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Cost Per Day:"
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Location = New System.Drawing.Point(149, 165)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Size = New System.Drawing.Size(49, 20)
        Me.txtFinalTotal.TabIndex = 11
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(84, 171)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(59, 13)
        Me.lblFinalTotal.TabIndex = 10
        Me.lblFinalTotal.Text = "Final Total:"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(149, 133)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(49, 20)
        Me.txtTax.TabIndex = 9
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(104, 140)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 8
        Me.lblTax.Text = "Tax:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(149, 107)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(49, 20)
        Me.txtSubtotal.TabIndex = 7
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(94, 114)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'txtInsuranceFee
        '
        Me.txtInsuranceFee.Location = New System.Drawing.Point(149, 75)
        Me.txtInsuranceFee.Name = "txtInsuranceFee"
        Me.txtInsuranceFee.Size = New System.Drawing.Size(49, 20)
        Me.txtInsuranceFee.TabIndex = 5
        '
        'lblInsuranceFee
        '
        Me.lblInsuranceFee.AutoSize = True
        Me.lblInsuranceFee.Location = New System.Drawing.Point(38, 82)
        Me.lblInsuranceFee.Name = "lblInsuranceFee"
        Me.lblInsuranceFee.Size = New System.Drawing.Size(105, 13)
        Me.lblInsuranceFee.TabIndex = 4
        Me.lblInsuranceFee.Text = "Purchase Insurance:"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(149, 48)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(49, 20)
        Me.TextBox6.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(155, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Cost:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(21, 123)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(57, 13)
        Me.lblInsurance.TabIndex = 64
        Me.lblInsurance.Text = "Insurance:"
        '
        'ckbInsurance
        '
        Me.ckbInsurance.AutoSize = True
        Me.ckbInsurance.Location = New System.Drawing.Point(47, 143)
        Me.ckbInsurance.Name = "ckbInsurance"
        Me.ckbInsurance.Size = New System.Drawing.Size(60, 17)
        Me.ckbInsurance.TabIndex = 65
        Me.ckbInsurance.Text = "Waiver"
        Me.ckbInsurance.UseVisualStyleBackColor = True
        '
        'lblCarRentalApp
        '
        Me.lblCarRentalApp.AutoSize = True
        Me.lblCarRentalApp.Location = New System.Drawing.Point(10, 24)
        Me.lblCarRentalApp.Name = "lblCarRentalApp"
        Me.lblCarRentalApp.Size = New System.Drawing.Size(112, 13)
        Me.lblCarRentalApp.TabIndex = 66
        Me.lblCarRentalApp.Text = "Car Rental Application"
        '
        'ckbPersonalIns
        '
        Me.ckbPersonalIns.AutoSize = True
        Me.ckbPersonalIns.Location = New System.Drawing.Point(113, 143)
        Me.ckbPersonalIns.Name = "ckbPersonalIns"
        Me.ckbPersonalIns.Size = New System.Drawing.Size(67, 17)
        Me.ckbPersonalIns.TabIndex = 69
        Me.ckbPersonalIns.Text = "Personal"
        Me.ckbPersonalIns.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(182, 143)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 70
        Me.CheckBox1.Text = "Purchase"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblView
        '
        Me.lblView.AutoSize = True
        Me.lblView.Location = New System.Drawing.Point(13, 341)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(39, 13)
        Me.lblView.TabIndex = 71
        Me.lblView.Text = "Label2"
        '
        'frmPaymentInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ckbPersonalIns)
        Me.Controls.Add(Me.lblCarRentalApp)
        Me.Controls.Add(Me.ckbInsurance)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.gbxCostDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFinalizeInvoice)
        Me.Controls.Add(Me.lblExpYY)
        Me.Controls.Add(Me.cmbExpYY)
        Me.Controls.Add(Me.lblExpMM)
        Me.Controls.Add(Me.cmbExpMM)
        Me.Controls.Add(Me.lblExpirationDate)
        Me.Controls.Add(Me.txtSecurityCode)
        Me.Controls.Add(Me.lblSecurityCode)
        Me.Controls.Add(Me.txtCCNumber)
        Me.Controls.Add(Me.lblCCNumber)
        Me.Controls.Add(Me.cmbCCtype)
        Me.Controls.Add(Me.lblCCtype)
        Me.Controls.Add(Me.lblPaymentInformation)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.txtInvoiceID)
        Me.Controls.Add(Me.lblInvoieID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblInvoiceInfo)
        Me.Name = "frmPaymentInvoice"
        Me.Text = "Mavericks Car Rental Company - Invoice and Payment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxCostDetails.ResumeLayout(False)
        Me.gbxCostDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInvoiceInfo As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInvoieID As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentInformation As System.Windows.Forms.Label
    Friend WithEvents lblCCtype As System.Windows.Forms.Label
    Friend WithEvents cmbCCtype As System.Windows.Forms.ComboBox
    Friend WithEvents lblCCNumber As System.Windows.Forms.Label
    Friend WithEvents txtCCNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSecurityCode As System.Windows.Forms.Label
    Friend WithEvents txtSecurityCode As System.Windows.Forms.TextBox
    Friend WithEvents lblExpirationDate As System.Windows.Forms.Label
    Friend WithEvents cmbExpMM As System.Windows.Forms.ComboBox
    Friend WithEvents lblExpMM As System.Windows.Forms.Label
    Friend WithEvents cmbExpYY As System.Windows.Forms.ComboBox
    Friend WithEvents lblExpYY As System.Windows.Forms.Label
    Friend WithEvents btnFinalizeInvoice As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents gbxCostDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtFinalTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalTotal As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents txtInsuranceFee As System.Windows.Forms.TextBox
    Friend WithEvents lblInsuranceFee As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblInsurance As System.Windows.Forms.Label
    Friend WithEvents ckbInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents lblCarRentalApp As System.Windows.Forms.Label
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckbPersonalIns As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblView As System.Windows.Forms.Label
End Class
