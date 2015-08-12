<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalizeInvoice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtZipIR = New System.Windows.Forms.TextBox()
        Me.lblLastNameIR = New System.Windows.Forms.Label()
        Me.lblZipIR = New System.Windows.Forms.Label()
        Me.lblFirstNameIR = New System.Windows.Forms.Label()
        Me.txtStateIR = New System.Windows.Forms.TextBox()
        Me.txtFirstNameIR = New System.Windows.Forms.TextBox()
        Me.lblStateIR = New System.Windows.Forms.Label()
        Me.lblMidInitIR = New System.Windows.Forms.Label()
        Me.txtCityIR = New System.Windows.Forms.TextBox()
        Me.txtMidInitIR = New System.Windows.Forms.TextBox()
        Me.txtLastNameIR = New System.Windows.Forms.TextBox()
        Me.lblCityIR = New System.Windows.Forms.Label()
        Me.lblAddressIR = New System.Windows.Forms.Label()
        Me.txtAddressIR = New System.Windows.Forms.TextBox()
        Me.txtFuelTankIR = New System.Windows.Forms.TextBox()
        Me.lblFuelTankIR = New System.Windows.Forms.Label()
        Me.lblMakeIR = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtMakeIR = New System.Windows.Forms.TextBox()
        Me.txtDescriptionIR = New System.Windows.Forms.TextBox()
        Me.txtInvoiceIdIR = New System.Windows.Forms.TextBox()
        Me.lblInvoiceIdIR = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCardType = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblReturnDateIR = New System.Windows.Forms.Label()
        Me.lblPickupDateIR = New System.Windows.Forms.Label()
        Me.txtPickupDateIR = New System.Windows.Forms.TextBox()
        Me.txtReturnDateIR = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Review"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 45
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
        Me.RentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRentalToolStripMenuItem, Me.UpdateRentalToolStripMenuItem, Me.SearchRentalToolStripMenuItem})
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'NewRentalToolStripMenuItem
        '
        Me.NewRentalToolStripMenuItem.Name = "NewRentalToolStripMenuItem"
        Me.NewRentalToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NewRentalToolStripMenuItem.Text = "New Rental"
        '
        'UpdateRentalToolStripMenuItem
        '
        Me.UpdateRentalToolStripMenuItem.Name = "UpdateRentalToolStripMenuItem"
        Me.UpdateRentalToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.UpdateRentalToolStripMenuItem.Text = "Update Rental"
        '
        'SearchRentalToolStripMenuItem
        '
        Me.SearchRentalToolStripMenuItem.Name = "SearchRentalToolStripMenuItem"
        Me.SearchRentalToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.SearchRentalToolStripMenuItem.Text = "Cancel Rental"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateCustomersToolStripMenuItem})
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'UpdateCustomersToolStripMenuItem
        '
        Me.UpdateCustomersToolStripMenuItem.Name = "UpdateCustomersToolStripMenuItem"
        Me.UpdateCustomersToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.UpdateCustomersToolStripMenuItem.Text = "Update Customers"
        '
        'VehiclesToolStripMenuItem
        '
        Me.VehiclesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewVehiclesToolStripMenuItem})
        Me.VehiclesToolStripMenuItem.Name = "VehiclesToolStripMenuItem"
        Me.VehiclesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VehiclesToolStripMenuItem.Text = "Vehicles"
        '
        'AddNewVehiclesToolStripMenuItem
        '
        Me.AddNewVehiclesToolStripMenuItem.Name = "AddNewVehiclesToolStripMenuItem"
        Me.AddNewVehiclesToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AddNewVehiclesToolStripMenuItem.Text = "Vehicles List/Add/Update"
        '
        'PriceOptionsToolStripMenuItem
        '
        Me.PriceOptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewPriceToolStripMenuItem})
        Me.PriceOptionsToolStripMenuItem.Name = "PriceOptionsToolStripMenuItem"
        Me.PriceOptionsToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PriceOptionsToolStripMenuItem.Text = "Price Options"
        '
        'AddNewPriceToolStripMenuItem
        '
        Me.AddNewPriceToolStripMenuItem.Name = "AddNewPriceToolStripMenuItem"
        Me.AddNewPriceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AddNewPriceToolStripMenuItem.Text = "Price List/Add/Update"
        '
        'txtZipIR
        '
        Me.txtZipIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtZipIR.Enabled = False
        Me.txtZipIR.Location = New System.Drawing.Point(267, 214)
        Me.txtZipIR.Name = "txtZipIR"
        Me.txtZipIR.Size = New System.Drawing.Size(68, 20)
        Me.txtZipIR.TabIndex = 59
        '
        'lblLastNameIR
        '
        Me.lblLastNameIR.AutoSize = True
        Me.lblLastNameIR.Location = New System.Drawing.Point(300, 96)
        Me.lblLastNameIR.Name = "lblLastNameIR"
        Me.lblLastNameIR.Size = New System.Drawing.Size(61, 13)
        Me.lblLastNameIR.TabIndex = 50
        Me.lblLastNameIR.Text = "Last Name:"
        '
        'lblZipIR
        '
        Me.lblZipIR.AutoSize = True
        Me.lblZipIR.Location = New System.Drawing.Point(236, 222)
        Me.lblZipIR.Name = "lblZipIR"
        Me.lblZipIR.Size = New System.Drawing.Size(25, 13)
        Me.lblZipIR.TabIndex = 58
        Me.lblZipIR.Text = "Zip:"
        '
        'lblFirstNameIR
        '
        Me.lblFirstNameIR.AutoSize = True
        Me.lblFirstNameIR.Location = New System.Drawing.Point(14, 96)
        Me.lblFirstNameIR.Name = "lblFirstNameIR"
        Me.lblFirstNameIR.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstNameIR.TabIndex = 46
        Me.lblFirstNameIR.Text = "First Name:"
        '
        'txtStateIR
        '
        Me.txtStateIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtStateIR.Enabled = False
        Me.txtStateIR.Location = New System.Drawing.Point(183, 215)
        Me.txtStateIR.Name = "txtStateIR"
        Me.txtStateIR.Size = New System.Drawing.Size(30, 20)
        Me.txtStateIR.TabIndex = 57
        '
        'txtFirstNameIR
        '
        Me.txtFirstNameIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtFirstNameIR.Enabled = False
        Me.txtFirstNameIR.Location = New System.Drawing.Point(77, 89)
        Me.txtFirstNameIR.Name = "txtFirstNameIR"
        Me.txtFirstNameIR.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNameIR.TabIndex = 47
        '
        'lblStateIR
        '
        Me.lblStateIR.AutoSize = True
        Me.lblStateIR.Location = New System.Drawing.Point(142, 222)
        Me.lblStateIR.Name = "lblStateIR"
        Me.lblStateIR.Size = New System.Drawing.Size(35, 13)
        Me.lblStateIR.TabIndex = 56
        Me.lblStateIR.Text = "State:"
        '
        'lblMidInitIR
        '
        Me.lblMidInitIR.AutoSize = True
        Me.lblMidInitIR.Location = New System.Drawing.Point(193, 96)
        Me.lblMidInitIR.Name = "lblMidInitIR"
        Me.lblMidInitIR.Size = New System.Drawing.Size(68, 13)
        Me.lblMidInitIR.TabIndex = 48
        Me.lblMidInitIR.Text = "Middle Initial:"
        '
        'txtCityIR
        '
        Me.txtCityIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtCityIR.Enabled = False
        Me.txtCityIR.Location = New System.Drawing.Point(183, 175)
        Me.txtCityIR.Name = "txtCityIR"
        Me.txtCityIR.Size = New System.Drawing.Size(152, 20)
        Me.txtCityIR.TabIndex = 55
        '
        'txtMidInitIR
        '
        Me.txtMidInitIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtMidInitIR.Enabled = False
        Me.txtMidInitIR.Location = New System.Drawing.Point(267, 89)
        Me.txtMidInitIR.Name = "txtMidInitIR"
        Me.txtMidInitIR.Size = New System.Drawing.Size(27, 20)
        Me.txtMidInitIR.TabIndex = 49
        '
        'txtLastNameIR
        '
        Me.txtLastNameIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtLastNameIR.Enabled = False
        Me.txtLastNameIR.Location = New System.Drawing.Point(367, 89)
        Me.txtLastNameIR.Name = "txtLastNameIR"
        Me.txtLastNameIR.Size = New System.Drawing.Size(100, 20)
        Me.txtLastNameIR.TabIndex = 51
        '
        'lblCityIR
        '
        Me.lblCityIR.AutoSize = True
        Me.lblCityIR.Location = New System.Drawing.Point(150, 182)
        Me.lblCityIR.Name = "lblCityIR"
        Me.lblCityIR.Size = New System.Drawing.Size(27, 13)
        Me.lblCityIR.TabIndex = 54
        Me.lblCityIR.Text = "City:"
        '
        'lblAddressIR
        '
        Me.lblAddressIR.AutoSize = True
        Me.lblAddressIR.Location = New System.Drawing.Point(135, 141)
        Me.lblAddressIR.Name = "lblAddressIR"
        Me.lblAddressIR.Size = New System.Drawing.Size(48, 13)
        Me.lblAddressIR.TabIndex = 52
        Me.lblAddressIR.Text = "Address:"
        '
        'txtAddressIR
        '
        Me.txtAddressIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtAddressIR.Enabled = False
        Me.txtAddressIR.Location = New System.Drawing.Point(183, 134)
        Me.txtAddressIR.Name = "txtAddressIR"
        Me.txtAddressIR.Size = New System.Drawing.Size(152, 20)
        Me.txtAddressIR.TabIndex = 53
        '
        'txtFuelTankIR
        '
        Me.txtFuelTankIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtFuelTankIR.Enabled = False
        Me.txtFuelTankIR.Location = New System.Drawing.Point(301, 277)
        Me.txtFuelTankIR.Name = "txtFuelTankIR"
        Me.txtFuelTankIR.Size = New System.Drawing.Size(20, 20)
        Me.txtFuelTankIR.TabIndex = 67
        '
        'lblFuelTankIR
        '
        Me.lblFuelTankIR.AutoSize = True
        Me.lblFuelTankIR.Location = New System.Drawing.Point(261, 250)
        Me.lblFuelTankIR.Name = "lblFuelTankIR"
        Me.lblFuelTankIR.Size = New System.Drawing.Size(102, 13)
        Me.lblFuelTankIR.TabIndex = 66
        Me.lblFuelTankIR.Text = "Fuel Tank Capacity:"
        '
        'lblMakeIR
        '
        Me.lblMakeIR.AutoSize = True
        Me.lblMakeIR.Location = New System.Drawing.Point(17, 250)
        Me.lblMakeIR.Name = "lblMakeIR"
        Me.lblMakeIR.Size = New System.Drawing.Size(71, 13)
        Me.lblMakeIR.TabIndex = 62
        Me.lblMakeIR.Text = "Make/Model:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(142, 250)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 64
        Me.lblDescription.Text = "Description"
        '
        'txtMakeIR
        '
        Me.txtMakeIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtMakeIR.Enabled = False
        Me.txtMakeIR.Location = New System.Drawing.Point(19, 277)
        Me.txtMakeIR.Name = "txtMakeIR"
        Me.txtMakeIR.Size = New System.Drawing.Size(100, 20)
        Me.txtMakeIR.TabIndex = 63
        '
        'txtDescriptionIR
        '
        Me.txtDescriptionIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescriptionIR.Enabled = False
        Me.txtDescriptionIR.Location = New System.Drawing.Point(145, 277)
        Me.txtDescriptionIR.Name = "txtDescriptionIR"
        Me.txtDescriptionIR.Size = New System.Drawing.Size(116, 20)
        Me.txtDescriptionIR.TabIndex = 65
        '
        'txtInvoiceIdIR
        '
        Me.txtInvoiceIdIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtInvoiceIdIR.Enabled = False
        Me.txtInvoiceIdIR.Location = New System.Drawing.Point(219, 47)
        Me.txtInvoiceIdIR.Name = "txtInvoiceIdIR"
        Me.txtInvoiceIdIR.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceIdIR.TabIndex = 69
        '
        'lblInvoiceIdIR
        '
        Me.lblInvoiceIdIR.AutoSize = True
        Me.lblInvoiceIdIR.Location = New System.Drawing.Point(163, 54)
        Me.lblInvoiceIdIR.Name = "lblInvoiceIdIR"
        Me.lblInvoiceIdIR.Size = New System.Drawing.Size(59, 13)
        Me.lblInvoiceIdIR.TabIndex = 68
        Me.lblInvoiceIdIR.Text = "Invoice ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Order has been placed against "
        '
        'lblCardType
        '
        Me.lblCardType.AutoSize = True
        Me.lblCardType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardType.Location = New System.Drawing.Point(160, 368)
        Me.lblCardType.Name = "lblCardType"
        Me.lblCardType.Size = New System.Drawing.Size(56, 13)
        Me.lblCardType.TabIndex = 71
        Me.lblCardType.Text = "Card Type"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(245, 368)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "for this amount"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(327, 368)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblTotalAmount.TabIndex = 73
        Me.lblTotalAmount.Text = "Amount"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(374, 386)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 74
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(465, 386)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 75
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblReturnDateIR
        '
        Me.lblReturnDateIR.AutoSize = True
        Me.lblReturnDateIR.Location = New System.Drawing.Point(18, 341)
        Me.lblReturnDateIR.Name = "lblReturnDateIR"
        Me.lblReturnDateIR.Size = New System.Drawing.Size(112, 13)
        Me.lblReturnDateIR.TabIndex = 78
        Me.lblReturnDateIR.Text = "Return Date and Time"
        '
        'lblPickupDateIR
        '
        Me.lblPickupDateIR.AutoSize = True
        Me.lblPickupDateIR.Location = New System.Drawing.Point(17, 315)
        Me.lblPickupDateIR.Name = "lblPickupDateIR"
        Me.lblPickupDateIR.Size = New System.Drawing.Size(113, 13)
        Me.lblPickupDateIR.TabIndex = 76
        Me.lblPickupDateIR.Text = "Pickup Date and Time"
        '
        'txtPickupDateIR
        '
        Me.txtPickupDateIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtPickupDateIR.Enabled = False
        Me.txtPickupDateIR.Location = New System.Drawing.Point(145, 307)
        Me.txtPickupDateIR.Name = "txtPickupDateIR"
        Me.txtPickupDateIR.Size = New System.Drawing.Size(100, 20)
        Me.txtPickupDateIR.TabIndex = 80
        '
        'txtReturnDateIR
        '
        Me.txtReturnDateIR.BackColor = System.Drawing.SystemColors.Control
        Me.txtReturnDateIR.Enabled = False
        Me.txtReturnDateIR.Location = New System.Drawing.Point(145, 341)
        Me.txtReturnDateIR.Name = "txtReturnDateIR"
        Me.txtReturnDateIR.Size = New System.Drawing.Size(100, 20)
        Me.txtReturnDateIR.TabIndex = 81
        '
        'FinalizeInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.txtReturnDateIR)
        Me.Controls.Add(Me.txtPickupDateIR)
        Me.Controls.Add(Me.lblReturnDateIR)
        Me.Controls.Add(Me.lblPickupDateIR)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblCardType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtInvoiceIdIR)
        Me.Controls.Add(Me.lblInvoiceIdIR)
        Me.Controls.Add(Me.txtFuelTankIR)
        Me.Controls.Add(Me.lblFuelTankIR)
        Me.Controls.Add(Me.lblMakeIR)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtMakeIR)
        Me.Controls.Add(Me.txtDescriptionIR)
        Me.Controls.Add(Me.txtZipIR)
        Me.Controls.Add(Me.lblLastNameIR)
        Me.Controls.Add(Me.lblZipIR)
        Me.Controls.Add(Me.lblFirstNameIR)
        Me.Controls.Add(Me.txtStateIR)
        Me.Controls.Add(Me.txtFirstNameIR)
        Me.Controls.Add(Me.lblStateIR)
        Me.Controls.Add(Me.lblMidInitIR)
        Me.Controls.Add(Me.txtCityIR)
        Me.Controls.Add(Me.txtMidInitIR)
        Me.Controls.Add(Me.txtLastNameIR)
        Me.Controls.Add(Me.lblCityIR)
        Me.Controls.Add(Me.lblAddressIR)
        Me.Controls.Add(Me.txtAddressIR)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FinalizeInvoice"
        Me.Text = "Mavericks Car Rental Company - Invoice Finalized"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewVehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewPriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtZipIR As System.Windows.Forms.TextBox
    Friend WithEvents lblLastNameIR As System.Windows.Forms.Label
    Friend WithEvents lblZipIR As System.Windows.Forms.Label
    Friend WithEvents lblFirstNameIR As System.Windows.Forms.Label
    Friend WithEvents txtStateIR As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstNameIR As System.Windows.Forms.TextBox
    Friend WithEvents lblStateIR As System.Windows.Forms.Label
    Friend WithEvents lblMidInitIR As System.Windows.Forms.Label
    Friend WithEvents txtCityIR As System.Windows.Forms.TextBox
    Friend WithEvents txtMidInitIR As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNameIR As System.Windows.Forms.TextBox
    Friend WithEvents lblCityIR As System.Windows.Forms.Label
    Friend WithEvents lblAddressIR As System.Windows.Forms.Label
    Friend WithEvents txtAddressIR As System.Windows.Forms.TextBox
    Friend WithEvents txtFuelTankIR As System.Windows.Forms.TextBox
    Friend WithEvents lblFuelTankIR As System.Windows.Forms.Label
    Friend WithEvents lblMakeIR As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtMakeIR As System.Windows.Forms.TextBox
    Friend WithEvents txtDescriptionIR As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoiceIdIR As System.Windows.Forms.TextBox
    Friend WithEvents lblInvoiceIdIR As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCardType As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents lblReturnDateIR As System.Windows.Forms.Label
    Friend WithEvents lblPickupDateIR As System.Windows.Forms.Label
    Friend WithEvents txtPickupDateIR As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnDateIR As System.Windows.Forms.TextBox
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
