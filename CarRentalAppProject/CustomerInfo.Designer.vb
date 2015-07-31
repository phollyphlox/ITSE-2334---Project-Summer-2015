<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerInfo
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
        Me.txtDriverLic = New System.Windows.Forms.TextBox()
        Me.lblDriversLic = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.tstFirstName = New System.Windows.Forms.TextBox()
        Me.lblMidInit = New System.Windows.Forms.Label()
        Me.tstMiddleInitial = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCustInfoPageHdr = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblDriverInfo = New System.Windows.Forms.Label()
        Me.lblLicState = New System.Windows.Forms.Label()
        Me.txtLicState = New System.Windows.Forms.TextBox()
        Me.lblDriverDOB = New System.Windows.Forms.Label()
        Me.dtpDriverDOB = New System.Windows.Forms.DateTimePicker()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCarRentalApp = New System.Windows.Forms.Label()
        Me.cmbCustomersList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddNewCustomer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDriverLic
        '
        Me.txtDriverLic.Location = New System.Drawing.Point(390, 268)
        Me.txtDriverLic.Name = "txtDriverLic"
        Me.txtDriverLic.Size = New System.Drawing.Size(100, 20)
        Me.txtDriverLic.TabIndex = 15
        '
        'lblDriversLic
        '
        Me.lblDriversLic.AutoSize = True
        Me.lblDriversLic.Location = New System.Drawing.Point(286, 275)
        Me.lblDriversLic.Name = "lblDriversLic"
        Me.lblDriversLic.Size = New System.Drawing.Size(83, 13)
        Me.lblDriversLic.TabIndex = 14
        Me.lblDriversLic.Text = "Drivers License:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(316, 194)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(30, 20)
        Me.txtState.TabIndex = 11
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(275, 201)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(243, 47)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'tstFirstName
        '
        Me.tstFirstName.Location = New System.Drawing.Point(246, 72)
        Me.tstFirstName.Name = "tstFirstName"
        Me.tstFirstName.Size = New System.Drawing.Size(100, 20)
        Me.tstFirstName.TabIndex = 1
        '
        'lblMidInit
        '
        Me.lblMidInit.AutoSize = True
        Me.lblMidInit.Location = New System.Drawing.Point(353, 47)
        Me.lblMidInit.Name = "lblMidInit"
        Me.lblMidInit.Size = New System.Drawing.Size(68, 13)
        Me.lblMidInit.TabIndex = 2
        Me.lblMidInit.Text = "Middle Initial:"
        '
        'tstMiddleInitial
        '
        Me.tstMiddleInitial.Location = New System.Drawing.Point(373, 72)
        Me.tstMiddleInitial.Name = "tstMiddleInitial"
        Me.tstMiddleInitial.Size = New System.Drawing.Size(27, 20)
        Me.tstMiddleInitial.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(436, 47)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(439, 72)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(268, 120)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 6
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(316, 113)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(152, 20)
        Me.txtAddress.TabIndex = 7
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(283, 161)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(316, 154)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(152, 20)
        Me.txtCity.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
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
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'PriceOptionsToolStripMenuItem
        '
        Me.PriceOptionsToolStripMenuItem.Name = "PriceOptionsToolStripMenuItem"
        Me.PriceOptionsToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PriceOptionsToolStripMenuItem.Text = "Price Options"
        '
        'lblCustInfoPageHdr
        '
        Me.lblCustInfoPageHdr.AutoSize = True
        Me.lblCustInfoPageHdr.Location = New System.Drawing.Point(21, 47)
        Me.lblCustInfoPageHdr.Name = "lblCustInfoPageHdr"
        Me.lblCustInfoPageHdr.Size = New System.Drawing.Size(106, 13)
        Me.lblCustInfoPageHdr.TabIndex = 45
        Me.lblCustInfoPageHdr.Text = "Customer Information"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(369, 201)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(25, 13)
        Me.lblZip.TabIndex = 12
        Me.lblZip.Text = "Zip:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(400, 193)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(68, 20)
        Me.txtZip.TabIndex = 13
        '
        'lblDriverInfo
        '
        Me.lblDriverInfo.AutoSize = True
        Me.lblDriverInfo.Location = New System.Drawing.Point(243, 239)
        Me.lblDriverInfo.Name = "lblDriverInfo"
        Me.lblDriverInfo.Size = New System.Drawing.Size(135, 13)
        Me.lblDriverInfo.TabIndex = 46
        Me.lblDriverInfo.Text = "Drivers License Information"
        '
        'lblLicState
        '
        Me.lblLicState.AutoSize = True
        Me.lblLicState.Location = New System.Drawing.Point(331, 318)
        Me.lblLicState.Name = "lblLicState"
        Me.lblLicState.Size = New System.Drawing.Size(35, 13)
        Me.lblLicState.TabIndex = 47
        Me.lblLicState.Text = "State:"
        '
        'txtLicState
        '
        Me.txtLicState.Location = New System.Drawing.Point(390, 311)
        Me.txtLicState.Name = "txtLicState"
        Me.txtLicState.Size = New System.Drawing.Size(100, 20)
        Me.txtLicState.TabIndex = 48
        '
        'lblDriverDOB
        '
        Me.lblDriverDOB.AutoSize = True
        Me.lblDriverDOB.Location = New System.Drawing.Point(297, 361)
        Me.lblDriverDOB.Name = "lblDriverDOB"
        Me.lblDriverDOB.Size = New System.Drawing.Size(69, 13)
        Me.lblDriverDOB.TabIndex = 49
        Me.lblDriverDOB.Text = "Date of Birth:"
        '
        'dtpDriverDOB
        '
        Me.dtpDriverDOB.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.dtpDriverDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDriverDOB.Location = New System.Drawing.Point(390, 354)
        Me.dtpDriverDOB.Name = "dtpDriverDOB"
        Me.dtpDriverDOB.Size = New System.Drawing.Size(149, 20)
        Me.dtpDriverDOB.TabIndex = 50
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(420, 396)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 51
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(303, 396)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 52
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'VehiclesToolStripMenuItem
        '
        Me.VehiclesToolStripMenuItem.Name = "VehiclesToolStripMenuItem"
        Me.VehiclesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VehiclesToolStripMenuItem.Text = "Vehicles"
        '
        'lblCarRentalApp
        '
        Me.lblCarRentalApp.AutoSize = True
        Me.lblCarRentalApp.Location = New System.Drawing.Point(12, 24)
        Me.lblCarRentalApp.Name = "lblCarRentalApp"
        Me.lblCarRentalApp.Size = New System.Drawing.Size(112, 13)
        Me.lblCarRentalApp.TabIndex = 53
        Me.lblCarRentalApp.Text = "Car Rental Application"
        '
        'cmbCustomersList
        '
        Me.cmbCustomersList.FormattingEnabled = True
        Me.cmbCustomersList.Location = New System.Drawing.Point(24, 96)
        Me.cmbCustomersList.Name = "cmbCustomersList"
        Me.cmbCustomersList.Size = New System.Drawing.Size(148, 21)
        Me.cmbCustomersList.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "List of Customers"
        '
        'btnAddNewCustomer
        '
        Me.btnAddNewCustomer.Location = New System.Drawing.Point(160, 396)
        Me.btnAddNewCustomer.Name = "btnAddNewCustomer"
        Me.btnAddNewCustomer.Size = New System.Drawing.Size(112, 23)
        Me.btnAddNewCustomer.TabIndex = 56
        Me.btnAddNewCustomer.Text = "Add New Customer"
        Me.btnAddNewCustomer.UseVisualStyleBackColor = True
        '
        'frmCustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.btnAddNewCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCustomersList)
        Me.Controls.Add(Me.lblCarRentalApp)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.dtpDriverDOB)
        Me.Controls.Add(Me.lblDriverDOB)
        Me.Controls.Add(Me.txtLicState)
        Me.Controls.Add(Me.lblLicState)
        Me.Controls.Add(Me.lblDriverInfo)
        Me.Controls.Add(Me.lblCustInfoPageHdr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblDriversLic)
        Me.Controls.Add(Me.txtDriverLic)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.tstFirstName)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblMidInit)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.tstMiddleInitial)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Name = "frmCustomerInfo"
        Me.Text = "Mavericks Car Rental Company - Customer Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDriverLic As System.Windows.Forms.TextBox
    Friend WithEvents lblDriversLic As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents tstFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblMidInit As System.Windows.Forms.Label
    Friend WithEvents tstMiddleInitial As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCustInfoPageHdr As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblDriverInfo As System.Windows.Forms.Label
    Friend WithEvents lblLicState As System.Windows.Forms.Label
    Friend WithEvents txtLicState As System.Windows.Forms.TextBox
    Friend WithEvents lblDriverDOB As System.Windows.Forms.Label
    Friend WithEvents dtpDriverDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCarRentalApp As System.Windows.Forms.Label
    Friend WithEvents cmbCustomersList As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddNewCustomer As System.Windows.Forms.Button
End Class
