<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicles
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
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
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ckbAvailableAV = New System.Windows.Forms.CheckBox()
        Me.lblAvailabilty = New System.Windows.Forms.Label()
        Me.txtFuelTankAV = New System.Windows.Forms.TextBox()
        Me.lblCategoryAV = New System.Windows.Forms.Label()
        Me.lblFuelTankAV = New System.Windows.Forms.Label()
        Me.lblConditionAV = New System.Windows.Forms.Label()
        Me.txtConditionAV = New System.Windows.Forms.TextBox()
        Me.lblAddVehicle = New System.Windows.Forms.Label()
        Me.lblMakeAV = New System.Windows.Forms.Label()
        Me.txtMakeAV = New System.Windows.Forms.TextBox()
        Me.txtModelAV = New System.Windows.Forms.TextBox()
        Me.lblModelAV = New System.Windows.Forms.Label()
        Me.txtColorAV = New System.Windows.Forms.TextBox()
        Me.lblColorAV = New System.Windows.Forms.Label()
        Me.lsbVehicleList = New System.Windows.Forms.ListBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(182, 377)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 56
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(282, 377)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 55
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 52
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
        Me.VehiclesToolStripMenuItem.Name = "VehiclesToolStripMenuItem"
        Me.VehiclesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.VehiclesToolStripMenuItem.Text = "Vehicles"
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
        'ckbAvailableAV
        '
        Me.ckbAvailableAV.AutoSize = True
        Me.ckbAvailableAV.Location = New System.Drawing.Point(302, 313)
        Me.ckbAvailableAV.Name = "ckbAvailableAV"
        Me.ckbAvailableAV.Size = New System.Drawing.Size(15, 14)
        Me.ckbAvailableAV.TabIndex = 51
        Me.ckbAvailableAV.UseVisualStyleBackColor = True
        '
        'lblAvailabilty
        '
        Me.lblAvailabilty.AutoSize = True
        Me.lblAvailabilty.Location = New System.Drawing.Point(244, 313)
        Me.lblAvailabilty.Name = "lblAvailabilty"
        Me.lblAvailabilty.Size = New System.Drawing.Size(59, 13)
        Me.lblAvailabilty.TabIndex = 50
        Me.lblAvailabilty.Text = "Availability:"
        '
        'txtFuelTankAV
        '
        Me.txtFuelTankAV.Location = New System.Drawing.Point(353, 276)
        Me.txtFuelTankAV.Name = "txtFuelTankAV"
        Me.txtFuelTankAV.Size = New System.Drawing.Size(49, 20)
        Me.txtFuelTankAV.TabIndex = 49
        '
        'lblCategoryAV
        '
        Me.lblCategoryAV.AutoSize = True
        Me.lblCategoryAV.Location = New System.Drawing.Point(244, 62)
        Me.lblCategoryAV.Name = "lblCategoryAV"
        Me.lblCategoryAV.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoryAV.TabIndex = 46
        Me.lblCategoryAV.Text = "Category:"
        '
        'lblFuelTankAV
        '
        Me.lblFuelTankAV.AutoSize = True
        Me.lblFuelTankAV.Location = New System.Drawing.Point(244, 276)
        Me.lblFuelTankAV.Name = "lblFuelTankAV"
        Me.lblFuelTankAV.Size = New System.Drawing.Size(102, 13)
        Me.lblFuelTankAV.TabIndex = 45
        Me.lblFuelTankAV.Text = "Fuel Tank Capacity:"
        '
        'lblConditionAV
        '
        Me.lblConditionAV.AutoSize = True
        Me.lblConditionAV.Location = New System.Drawing.Point(244, 234)
        Me.lblConditionAV.Name = "lblConditionAV"
        Me.lblConditionAV.Size = New System.Drawing.Size(54, 13)
        Me.lblConditionAV.TabIndex = 43
        Me.lblConditionAV.Text = "Condition:"
        '
        'txtConditionAV
        '
        Me.txtConditionAV.Location = New System.Drawing.Point(302, 231)
        Me.txtConditionAV.Name = "txtConditionAV"
        Me.txtConditionAV.Size = New System.Drawing.Size(147, 20)
        Me.txtConditionAV.TabIndex = 44
        '
        'lblAddVehicle
        '
        Me.lblAddVehicle.AutoSize = True
        Me.lblAddVehicle.Location = New System.Drawing.Point(11, 32)
        Me.lblAddVehicle.Name = "lblAddVehicle"
        Me.lblAddVehicle.Size = New System.Drawing.Size(81, 13)
        Me.lblAddVehicle.TabIndex = 48
        Me.lblAddVehicle.Text = "List of Vehicles:"
        '
        'lblMakeAV
        '
        Me.lblMakeAV.AutoSize = True
        Me.lblMakeAV.Location = New System.Drawing.Point(244, 100)
        Me.lblMakeAV.Name = "lblMakeAV"
        Me.lblMakeAV.Size = New System.Drawing.Size(37, 13)
        Me.lblMakeAV.TabIndex = 37
        Me.lblMakeAV.Text = "Make:"
        '
        'txtMakeAV
        '
        Me.txtMakeAV.Location = New System.Drawing.Point(302, 100)
        Me.txtMakeAV.Name = "txtMakeAV"
        Me.txtMakeAV.Size = New System.Drawing.Size(100, 20)
        Me.txtMakeAV.TabIndex = 38
        '
        'txtModelAV
        '
        Me.txtModelAV.Location = New System.Drawing.Point(302, 143)
        Me.txtModelAV.Name = "txtModelAV"
        Me.txtModelAV.Size = New System.Drawing.Size(100, 20)
        Me.txtModelAV.TabIndex = 40
        '
        'lblModelAV
        '
        Me.lblModelAV.AutoSize = True
        Me.lblModelAV.Location = New System.Drawing.Point(244, 146)
        Me.lblModelAV.Name = "lblModelAV"
        Me.lblModelAV.Size = New System.Drawing.Size(39, 13)
        Me.lblModelAV.TabIndex = 39
        Me.lblModelAV.Text = "Model:"
        '
        'txtColorAV
        '
        Me.txtColorAV.Location = New System.Drawing.Point(302, 189)
        Me.txtColorAV.Name = "txtColorAV"
        Me.txtColorAV.Size = New System.Drawing.Size(100, 20)
        Me.txtColorAV.TabIndex = 42
        '
        'lblColorAV
        '
        Me.lblColorAV.AutoSize = True
        Me.lblColorAV.Location = New System.Drawing.Point(244, 196)
        Me.lblColorAV.Name = "lblColorAV"
        Me.lblColorAV.Size = New System.Drawing.Size(34, 13)
        Me.lblColorAV.TabIndex = 41
        Me.lblColorAV.Text = "Color:"
        '
        'lsbVehicleList
        '
        Me.lsbVehicleList.FormattingEnabled = True
        Me.lsbVehicleList.Location = New System.Drawing.Point(29, 63)
        Me.lsbVehicleList.Name = "lsbVehicleList"
        Me.lsbVehicleList.Size = New System.Drawing.Size(120, 290)
        Me.lsbVehicleList.TabIndex = 57
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(383, 377)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 58
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(302, 59)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategory.TabIndex = 59
        '
        'frmVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lsbVehicleList)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ckbAvailableAV)
        Me.Controls.Add(Me.lblAvailabilty)
        Me.Controls.Add(Me.txtFuelTankAV)
        Me.Controls.Add(Me.lblCategoryAV)
        Me.Controls.Add(Me.lblFuelTankAV)
        Me.Controls.Add(Me.lblConditionAV)
        Me.Controls.Add(Me.txtConditionAV)
        Me.Controls.Add(Me.lblAddVehicle)
        Me.Controls.Add(Me.lblMakeAV)
        Me.Controls.Add(Me.txtMakeAV)
        Me.Controls.Add(Me.txtModelAV)
        Me.Controls.Add(Me.lblModelAV)
        Me.Controls.Add(Me.txtColorAV)
        Me.Controls.Add(Me.lblColorAV)
        Me.Name = "frmVehicles"
        Me.Text = "Mavericks Car Rental Company - Vehicles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
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
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewPriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ckbAvailableAV As System.Windows.Forms.CheckBox
    Friend WithEvents lblAvailabilty As System.Windows.Forms.Label
    Friend WithEvents txtFuelTankAV As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoryAV As System.Windows.Forms.Label
    Friend WithEvents lblFuelTankAV As System.Windows.Forms.Label
    Friend WithEvents lblConditionAV As System.Windows.Forms.Label
    Friend WithEvents txtConditionAV As System.Windows.Forms.TextBox
    Friend WithEvents lblAddVehicle As System.Windows.Forms.Label
    Friend WithEvents lblMakeAV As System.Windows.Forms.Label
    Friend WithEvents txtMakeAV As System.Windows.Forms.TextBox
    Friend WithEvents txtModelAV As System.Windows.Forms.TextBox
    Friend WithEvents lblModelAV As System.Windows.Forms.Label
    Friend WithEvents txtColorAV As System.Windows.Forms.TextBox
    Friend WithEvents lblColorAV As System.Windows.Forms.Label
    Friend WithEvents lsbVehicleList As System.Windows.Forms.ListBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
