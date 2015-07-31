<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerUpdate
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dtpDOBCU = New System.Windows.Forms.DateTimePicker()
        Me.lblDOBCU = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblDLStateCU = New System.Windows.Forms.Label()
        Me.lblDriversLicInfoCU = New System.Windows.Forms.Label()
        Me.lblCustUpdate = New System.Windows.Forms.Label()
        Me.lblDriverLicCU = New System.Windows.Forms.Label()
        Me.txtDriversLicCU = New System.Windows.Forms.TextBox()
        Me.txtZipCU = New System.Windows.Forms.TextBox()
        Me.lblLastNameCU = New System.Windows.Forms.Label()
        Me.lblZipCU = New System.Windows.Forms.Label()
        Me.lblFirstNameCU = New System.Windows.Forms.Label()
        Me.txtStateCU = New System.Windows.Forms.TextBox()
        Me.txtFirstNameCU = New System.Windows.Forms.TextBox()
        Me.lblStateCU = New System.Windows.Forms.Label()
        Me.lblMidInitialCU = New System.Windows.Forms.Label()
        Me.txtCityCU = New System.Windows.Forms.TextBox()
        Me.txtMidInitialCU = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.lblCityCU = New System.Windows.Forms.Label()
        Me.lblAddressCU = New System.Windows.Forms.Label()
        Me.txtAddressCU = New System.Windows.Forms.TextBox()
        Me.lsbCustomers = New System.Windows.Forms.ListBox()
        Me.lblCustomersList = New System.Windows.Forms.Label()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 46
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
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
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
        Me.NewRentalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewRentalToolStripMenuItem.Text = "New Rental"
        '
        'UpdateRentalToolStripMenuItem
        '
        Me.UpdateRentalToolStripMenuItem.Name = "UpdateRentalToolStripMenuItem"
        Me.UpdateRentalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateRentalToolStripMenuItem.Text = "Update Rental"
        '
        'SearchRentalToolStripMenuItem
        '
        Me.SearchRentalToolStripMenuItem.Name = "SearchRentalToolStripMenuItem"
        Me.SearchRentalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchRentalToolStripMenuItem.Text = "Cancel Rental"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
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
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(335, 386)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 76
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(451, 386)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 75
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dtpDOBCU
        '
        Me.dtpDOBCU.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.dtpDOBCU.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOBCU.Location = New System.Drawing.Point(386, 341)
        Me.dtpDOBCU.Name = "dtpDOBCU"
        Me.dtpDOBCU.Size = New System.Drawing.Size(149, 20)
        Me.dtpDOBCU.TabIndex = 74
        '
        'lblDOBCU
        '
        Me.lblDOBCU.AutoSize = True
        Me.lblDOBCU.Location = New System.Drawing.Point(285, 341)
        Me.lblDOBCU.Name = "lblDOBCU"
        Me.lblDOBCU.Size = New System.Drawing.Size(69, 13)
        Me.lblDOBCU.TabIndex = 73
        Me.lblDOBCU.Text = "Date of Birth:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(386, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 72
        '
        'lblDLStateCU
        '
        Me.lblDLStateCU.AutoSize = True
        Me.lblDLStateCU.Location = New System.Drawing.Point(327, 305)
        Me.lblDLStateCU.Name = "lblDLStateCU"
        Me.lblDLStateCU.Size = New System.Drawing.Size(35, 13)
        Me.lblDLStateCU.TabIndex = 71
        Me.lblDLStateCU.Text = "State:"
        '
        'lblDriversLicInfoCU
        '
        Me.lblDriversLicInfoCU.AutoSize = True
        Me.lblDriversLicInfoCU.Location = New System.Drawing.Point(218, 222)
        Me.lblDriversLicInfoCU.Name = "lblDriversLicInfoCU"
        Me.lblDriversLicInfoCU.Size = New System.Drawing.Size(135, 13)
        Me.lblDriversLicInfoCU.TabIndex = 70
        Me.lblDriversLicInfoCU.Text = "Drivers License Information"
        '
        'lblCustUpdate
        '
        Me.lblCustUpdate.AutoSize = True
        Me.lblCustUpdate.Location = New System.Drawing.Point(12, 24)
        Me.lblCustUpdate.Name = "lblCustUpdate"
        Me.lblCustUpdate.Size = New System.Drawing.Size(89, 13)
        Me.lblCustUpdate.TabIndex = 69
        Me.lblCustUpdate.Text = "Customer Update"
        '
        'lblDriverLicCU
        '
        Me.lblDriverLicCU.AutoSize = True
        Me.lblDriverLicCU.Location = New System.Drawing.Point(282, 262)
        Me.lblDriverLicCU.Name = "lblDriverLicCU"
        Me.lblDriverLicCU.Size = New System.Drawing.Size(83, 13)
        Me.lblDriverLicCU.TabIndex = 67
        Me.lblDriverLicCU.Text = "Drivers License:"
        '
        'txtDriversLicCU
        '
        Me.txtDriversLicCU.Location = New System.Drawing.Point(386, 255)
        Me.txtDriversLicCU.Name = "txtDriversLicCU"
        Me.txtDriversLicCU.Size = New System.Drawing.Size(100, 20)
        Me.txtDriversLicCU.TabIndex = 68
        '
        'txtZipCU
        '
        Me.txtZipCU.Location = New System.Drawing.Point(407, 173)
        Me.txtZipCU.Name = "txtZipCU"
        Me.txtZipCU.Size = New System.Drawing.Size(68, 20)
        Me.txtZipCU.TabIndex = 66
        '
        'lblLastNameCU
        '
        Me.lblLastNameCU.AutoSize = True
        Me.lblLastNameCU.Location = New System.Drawing.Point(414, 51)
        Me.lblLastNameCU.Name = "lblLastNameCU"
        Me.lblLastNameCU.Size = New System.Drawing.Size(61, 13)
        Me.lblLastNameCU.TabIndex = 57
        Me.lblLastNameCU.Text = "Last Name:"
        '
        'lblZipCU
        '
        Me.lblZipCU.AutoSize = True
        Me.lblZipCU.Location = New System.Drawing.Point(376, 181)
        Me.lblZipCU.Name = "lblZipCU"
        Me.lblZipCU.Size = New System.Drawing.Size(25, 13)
        Me.lblZipCU.TabIndex = 65
        Me.lblZipCU.Text = "Zip:"
        '
        'lblFirstNameCU
        '
        Me.lblFirstNameCU.AutoSize = True
        Me.lblFirstNameCU.Location = New System.Drawing.Point(209, 51)
        Me.lblFirstNameCU.Name = "lblFirstNameCU"
        Me.lblFirstNameCU.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstNameCU.TabIndex = 53
        Me.lblFirstNameCU.Text = "First Name:"
        '
        'txtStateCU
        '
        Me.txtStateCU.Location = New System.Drawing.Point(323, 174)
        Me.txtStateCU.Name = "txtStateCU"
        Me.txtStateCU.Size = New System.Drawing.Size(30, 20)
        Me.txtStateCU.TabIndex = 64
        '
        'txtFirstNameCU
        '
        Me.txtFirstNameCU.Location = New System.Drawing.Point(212, 67)
        Me.txtFirstNameCU.Name = "txtFirstNameCU"
        Me.txtFirstNameCU.Size = New System.Drawing.Size(119, 20)
        Me.txtFirstNameCU.TabIndex = 54
        '
        'lblStateCU
        '
        Me.lblStateCU.AutoSize = True
        Me.lblStateCU.Location = New System.Drawing.Point(282, 181)
        Me.lblStateCU.Name = "lblStateCU"
        Me.lblStateCU.Size = New System.Drawing.Size(35, 13)
        Me.lblStateCU.TabIndex = 63
        Me.lblStateCU.Text = "State:"
        '
        'lblMidInitialCU
        '
        Me.lblMidInitialCU.AutoSize = True
        Me.lblMidInitialCU.Location = New System.Drawing.Point(335, 51)
        Me.lblMidInitialCU.Name = "lblMidInitialCU"
        Me.lblMidInitialCU.Size = New System.Drawing.Size(68, 13)
        Me.lblMidInitialCU.TabIndex = 55
        Me.lblMidInitialCU.Text = "Middle Initial:"
        '
        'txtCityCU
        '
        Me.txtCityCU.Location = New System.Drawing.Point(323, 134)
        Me.txtCityCU.Name = "txtCityCU"
        Me.txtCityCU.Size = New System.Drawing.Size(152, 20)
        Me.txtCityCU.TabIndex = 62
        '
        'txtMidInitialCU
        '
        Me.txtMidInitialCU.Location = New System.Drawing.Point(356, 67)
        Me.txtMidInitialCU.Name = "txtMidInitialCU"
        Me.txtMidInitialCU.Size = New System.Drawing.Size(27, 20)
        Me.txtMidInitialCU.TabIndex = 56
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(417, 67)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(118, 20)
        Me.TextBox11.TabIndex = 58
        '
        'lblCityCU
        '
        Me.lblCityCU.AutoSize = True
        Me.lblCityCU.Location = New System.Drawing.Point(290, 141)
        Me.lblCityCU.Name = "lblCityCU"
        Me.lblCityCU.Size = New System.Drawing.Size(27, 13)
        Me.lblCityCU.TabIndex = 61
        Me.lblCityCU.Text = "City:"
        '
        'lblAddressCU
        '
        Me.lblAddressCU.AutoSize = True
        Me.lblAddressCU.Location = New System.Drawing.Point(275, 100)
        Me.lblAddressCU.Name = "lblAddressCU"
        Me.lblAddressCU.Size = New System.Drawing.Size(48, 13)
        Me.lblAddressCU.TabIndex = 59
        Me.lblAddressCU.Text = "Address:"
        '
        'txtAddressCU
        '
        Me.txtAddressCU.Location = New System.Drawing.Point(323, 93)
        Me.txtAddressCU.Name = "txtAddressCU"
        Me.txtAddressCU.Size = New System.Drawing.Size(152, 20)
        Me.txtAddressCU.TabIndex = 60
        '
        'lsbCustomers
        '
        Me.lsbCustomers.FormattingEnabled = True
        Me.lsbCustomers.Location = New System.Drawing.Point(15, 67)
        Me.lsbCustomers.Name = "lsbCustomers"
        Me.lsbCustomers.Size = New System.Drawing.Size(148, 316)
        Me.lsbCustomers.TabIndex = 77
        '
        'lblCustomersList
        '
        Me.lblCustomersList.AutoSize = True
        Me.lblCustomersList.Location = New System.Drawing.Point(12, 51)
        Me.lblCustomersList.Name = "lblCustomersList"
        Me.lblCustomersList.Size = New System.Drawing.Size(87, 13)
        Me.lblCustomersList.TabIndex = 78
        Me.lblCustomersList.Text = "List of Customers"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'frmCustomerUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.lblCustomersList)
        Me.Controls.Add(Me.lsbCustomers)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpDOBCU)
        Me.Controls.Add(Me.lblDOBCU)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblDLStateCU)
        Me.Controls.Add(Me.lblDriversLicInfoCU)
        Me.Controls.Add(Me.lblCustUpdate)
        Me.Controls.Add(Me.lblDriverLicCU)
        Me.Controls.Add(Me.txtDriversLicCU)
        Me.Controls.Add(Me.txtZipCU)
        Me.Controls.Add(Me.lblLastNameCU)
        Me.Controls.Add(Me.lblZipCU)
        Me.Controls.Add(Me.lblFirstNameCU)
        Me.Controls.Add(Me.txtStateCU)
        Me.Controls.Add(Me.txtFirstNameCU)
        Me.Controls.Add(Me.lblStateCU)
        Me.Controls.Add(Me.lblMidInitialCU)
        Me.Controls.Add(Me.txtCityCU)
        Me.Controls.Add(Me.txtMidInitialCU)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.lblCityCU)
        Me.Controls.Add(Me.lblAddressCU)
        Me.Controls.Add(Me.txtAddressCU)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmCustomerUpdate"
        Me.Text = "Mavericks Car Rental Company - Customer Update"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewVehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewPriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dtpDOBCU As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDOBCU As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDLStateCU As System.Windows.Forms.Label
    Friend WithEvents lblDriversLicInfoCU As System.Windows.Forms.Label
    Friend WithEvents lblCustUpdate As System.Windows.Forms.Label
    Friend WithEvents lblDriverLicCU As System.Windows.Forms.Label
    Friend WithEvents txtDriversLicCU As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCU As System.Windows.Forms.TextBox
    Friend WithEvents lblLastNameCU As System.Windows.Forms.Label
    Friend WithEvents lblZipCU As System.Windows.Forms.Label
    Friend WithEvents lblFirstNameCU As System.Windows.Forms.Label
    Friend WithEvents txtStateCU As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstNameCU As System.Windows.Forms.TextBox
    Friend WithEvents lblStateCU As System.Windows.Forms.Label
    Friend WithEvents lblMidInitialCU As System.Windows.Forms.Label
    Friend WithEvents txtCityCU As System.Windows.Forms.TextBox
    Friend WithEvents txtMidInitialCU As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents lblCityCU As System.Windows.Forms.Label
    Friend WithEvents lblAddressCU As System.Windows.Forms.Label
    Friend WithEvents txtAddressCU As System.Windows.Forms.TextBox
    Friend WithEvents lsbCustomers As System.Windows.Forms.ListBox
    Friend WithEvents lblCustomersList As System.Windows.Forms.Label
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
