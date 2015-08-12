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
        Me.components = New System.ComponentModel.Container()
        Dim CategoryPriceLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.lblInvoiceInfo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_Maverick_Car_RentalDataSet = New CarRentalAppProject.new_Maverick_Car_RentalDataSet()
        Me.cmbCategoryPrice = New System.Windows.Forms.ComboBox()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtInsuranceFee = New System.Windows.Forms.TextBox()
        Me.lblInsuranceFee = New System.Windows.Forms.Label()
        Me.lblCarRentalApp = New System.Windows.Forms.Label()
        Me.grpInsurance = New System.Windows.Forms.GroupBox()
        Me.rbnPurchase = New System.Windows.Forms.RadioButton()
        Me.rbnPersonal = New System.Windows.Forms.RadioButton()
        Me.rbnWaiver = New System.Windows.Forms.RadioButton()
        Me.PriceTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.PriceTableAdapter()
        Me.TableAdapterManager = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.TableAdapterManager()
        Me.RentalTableAdapter1 = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.RentalTableAdapter()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblPrice = New System.Windows.Forms.Label()
        CategoryPriceLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbxCostDetails.SuspendLayout()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInsurance.SuspendLayout()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryPriceLabel
        '
        CategoryPriceLabel.AutoSize = True
        CategoryPriceLabel.Location = New System.Drawing.Point(49, 28)
        CategoryPriceLabel.Name = "CategoryPriceLabel"
        CategoryPriceLabel.Size = New System.Drawing.Size(52, 13)
        CategoryPriceLabel.TabIndex = 13
        CategoryPriceLabel.Text = "Category:"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 24)
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
        'lblPaymentInformation
        '
        Me.lblPaymentInformation.AutoSize = True
        Me.lblPaymentInformation.Location = New System.Drawing.Point(18, 146)
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
        Me.cmbExpMM.Location = New System.Drawing.Point(121, 311)
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
        Me.cmbExpYY.Location = New System.Drawing.Point(172, 311)
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
        Me.gbxCostDetails.Controls.Add(PriceLabel)
        Me.gbxCostDetails.Controls.Add(Me.lblPrice)
        Me.gbxCostDetails.Controls.Add(CategoryPriceLabel)
        Me.gbxCostDetails.Controls.Add(Me.cmbCategoryPrice)
        Me.gbxCostDetails.Controls.Add(Me.txtFinalTotal)
        Me.gbxCostDetails.Controls.Add(Me.lblFinalTotal)
        Me.gbxCostDetails.Controls.Add(Me.txtTax)
        Me.gbxCostDetails.Controls.Add(Me.lblTax)
        Me.gbxCostDetails.Controls.Add(Me.txtSubtotal)
        Me.gbxCostDetails.Controls.Add(Me.lblSubtotal)
        Me.gbxCostDetails.Controls.Add(Me.txtInsuranceFee)
        Me.gbxCostDetails.Controls.Add(Me.lblInsuranceFee)
        Me.gbxCostDetails.Location = New System.Drawing.Point(311, 68)
        Me.gbxCostDetails.Name = "gbxCostDetails"
        Me.gbxCostDetails.Size = New System.Drawing.Size(260, 243)
        Me.gbxCostDetails.TabIndex = 63
        Me.gbxCostDetails.TabStop = False
        Me.gbxCostDetails.Text = "Price Details"
        '
        'PriceBindingSource
        '
        Me.PriceBindingSource.DataMember = "Price"
        Me.PriceBindingSource.DataSource = Me.New_Maverick_Car_RentalDataSet
        '
        'New_Maverick_Car_RentalDataSet
        '
        Me.New_Maverick_Car_RentalDataSet.DataSetName = "new_Maverick_Car_RentalDataSet"
        Me.New_Maverick_Car_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCategoryPrice
        '
        Me.cmbCategoryPrice.DataSource = Me.PriceBindingSource
        Me.cmbCategoryPrice.DisplayMember = "Category"
        Me.cmbCategoryPrice.FormattingEnabled = True
        Me.cmbCategoryPrice.Location = New System.Drawing.Point(107, 25)
        Me.cmbCategoryPrice.Name = "cmbCategoryPrice"
        Me.cmbCategoryPrice.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoryPrice.TabIndex = 14
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Location = New System.Drawing.Point(147, 203)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Size = New System.Drawing.Size(49, 20)
        Me.txtFinalTotal.TabIndex = 11
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(82, 209)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(59, 13)
        Me.lblFinalTotal.TabIndex = 10
        Me.lblFinalTotal.Text = "Final Total:"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(147, 171)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(49, 20)
        Me.txtTax.TabIndex = 9
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(102, 178)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 8
        Me.lblTax.Text = "Tax:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(147, 145)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(49, 20)
        Me.txtSubtotal.TabIndex = 7
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(92, 152)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'txtInsuranceFee
        '
        Me.txtInsuranceFee.Location = New System.Drawing.Point(147, 113)
        Me.txtInsuranceFee.Name = "txtInsuranceFee"
        Me.txtInsuranceFee.Size = New System.Drawing.Size(49, 20)
        Me.txtInsuranceFee.TabIndex = 5
        '
        'lblInsuranceFee
        '
        Me.lblInsuranceFee.AutoSize = True
        Me.lblInsuranceFee.Location = New System.Drawing.Point(36, 120)
        Me.lblInsuranceFee.Name = "lblInsuranceFee"
        Me.lblInsuranceFee.Size = New System.Drawing.Size(105, 13)
        Me.lblInsuranceFee.TabIndex = 4
        Me.lblInsuranceFee.Text = "Purchase Insurance:"
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
        'grpInsurance
        '
        Me.grpInsurance.Controls.Add(Me.rbnPurchase)
        Me.grpInsurance.Controls.Add(Me.rbnPersonal)
        Me.grpInsurance.Controls.Add(Me.rbnWaiver)
        Me.grpInsurance.Location = New System.Drawing.Point(13, 82)
        Me.grpInsurance.Name = "grpInsurance"
        Me.grpInsurance.Size = New System.Drawing.Size(229, 46)
        Me.grpInsurance.TabIndex = 72
        Me.grpInsurance.TabStop = False
        Me.grpInsurance.Text = "Insurance:"
        '
        'rbnPurchase
        '
        Me.rbnPurchase.AutoSize = True
        Me.rbnPurchase.Location = New System.Drawing.Point(147, 20)
        Me.rbnPurchase.Name = "rbnPurchase"
        Me.rbnPurchase.Size = New System.Drawing.Size(70, 17)
        Me.rbnPurchase.TabIndex = 2
        Me.rbnPurchase.TabStop = True
        Me.rbnPurchase.Text = "Purchase"
        Me.rbnPurchase.UseVisualStyleBackColor = True
        '
        'rbnPersonal
        '
        Me.rbnPersonal.AutoSize = True
        Me.rbnPersonal.Location = New System.Drawing.Point(73, 18)
        Me.rbnPersonal.Name = "rbnPersonal"
        Me.rbnPersonal.Size = New System.Drawing.Size(66, 17)
        Me.rbnPersonal.TabIndex = 1
        Me.rbnPersonal.TabStop = True
        Me.rbnPersonal.Text = "Personal"
        Me.rbnPersonal.UseVisualStyleBackColor = True
        '
        'rbnWaiver
        '
        Me.rbnWaiver.AutoSize = True
        Me.rbnWaiver.Location = New System.Drawing.Point(8, 20)
        Me.rbnWaiver.Name = "rbnWaiver"
        Me.rbnWaiver.Size = New System.Drawing.Size(59, 17)
        Me.rbnWaiver.TabIndex = 0
        Me.rbnWaiver.TabStop = True
        Me.rbnWaiver.Text = "Waiver"
        Me.rbnWaiver.UseVisualStyleBackColor = True
        '
        'PriceTableAdapter
        '
        Me.PriceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.PriceTableAdapter = Me.PriceTableAdapter
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehicleTableAdapter = Nothing
        '
        'RentalTableAdapter1
        '
        Me.RentalTableAdapter1.ClearBeforeFill = True
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(67, 68)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 14
        PriceLabel.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PriceBindingSource, "Price", True))
        Me.lblPrice.Location = New System.Drawing.Point(107, 68)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.Text = "Label1"
        '
        'frmPaymentInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 432)
        Me.Controls.Add(Me.grpInsurance)
        Me.Controls.Add(Me.lblCarRentalApp)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblInvoiceInfo)
        Me.Name = "frmPaymentInvoice"
        Me.Text = "Mavericks Car Rental Company - Invoice and Payment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbxCostDetails.ResumeLayout(False)
        Me.gbxCostDetails.PerformLayout()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInsurance.ResumeLayout(False)
        Me.grpInsurance.PerformLayout()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblCarRentalApp As System.Windows.Forms.Label
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents rbnPurchase As System.Windows.Forms.RadioButton
    Friend WithEvents rbnPersonal As System.Windows.Forms.RadioButton
    Friend WithEvents rbnWaiver As System.Windows.Forms.RadioButton
    Friend WithEvents New_Maverick_Car_RentalDataSet As CarRentalAppProject.new_Maverick_Car_RentalDataSet
    Friend WithEvents PriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PriceTableAdapter As CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.PriceTableAdapter
    Friend WithEvents TableAdapterManager As CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmbCategoryPrice As System.Windows.Forms.ComboBox
    Friend WithEvents RentalTableAdapter1 As CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents RentalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblPrice As System.Windows.Forms.Label
End Class
