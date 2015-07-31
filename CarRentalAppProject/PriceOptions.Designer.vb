<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPriceOptions
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVehicleRatePlans = New System.Windows.Forms.Label()
        Me.lsbPricePlans = New System.Windows.Forms.ListBox()
        Me.lblThePriceIs = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPriceList = New System.Windows.Forms.Label()
        Me.lblNewPricePlan = New System.Windows.Forms.Label()
        Me.txtNewPricePlan = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtNewPrice = New System.Windows.Forms.TextBox()
        Me.CancelRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(430, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(430, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 88
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
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRentalToolStripMenuItem, Me.UpdateRentalToolStripMenuItem, Me.CancelRentalToolStripMenuItem})
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
        Me.PriceOptionsToolStripMenuItem.Name = "PriceOptionsToolStripMenuItem"
        Me.PriceOptionsToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.PriceOptionsToolStripMenuItem.Text = "Price Options"
        '
        'lblVehicleRatePlans
        '
        Me.lblVehicleRatePlans.AutoSize = True
        Me.lblVehicleRatePlans.Location = New System.Drawing.Point(13, 24)
        Me.lblVehicleRatePlans.Name = "lblVehicleRatePlans"
        Me.lblVehicleRatePlans.Size = New System.Drawing.Size(98, 13)
        Me.lblVehicleRatePlans.TabIndex = 85
        Me.lblVehicleRatePlans.Text = "Vehicle Price Plans"
        '
        'lsbPricePlans
        '
        Me.lsbPricePlans.FormattingEnabled = True
        Me.lsbPricePlans.Location = New System.Drawing.Point(48, 85)
        Me.lsbPricePlans.Name = "lsbPricePlans"
        Me.lsbPricePlans.Size = New System.Drawing.Size(120, 186)
        Me.lsbPricePlans.TabIndex = 93
        '
        'lblThePriceIs
        '
        Me.lblThePriceIs.AutoSize = True
        Me.lblThePriceIs.Location = New System.Drawing.Point(221, 172)
        Me.lblThePriceIs.Name = "lblThePriceIs"
        Me.lblThePriceIs.Size = New System.Drawing.Size(66, 13)
        Me.lblThePriceIs.TabIndex = 94
        Me.lblThePriceIs.Text = "The Price is:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(293, 172)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 95
        '
        'lblPriceList
        '
        Me.lblPriceList.AutoSize = True
        Me.lblPriceList.Location = New System.Drawing.Point(16, 64)
        Me.lblPriceList.Name = "lblPriceList"
        Me.lblPriceList.Size = New System.Drawing.Size(91, 13)
        Me.lblPriceList.TabIndex = 96
        Me.lblPriceList.Text = "List of Price Plans"
        '
        'lblNewPricePlan
        '
        Me.lblNewPricePlan.AutoSize = True
        Me.lblNewPricePlan.Location = New System.Drawing.Point(19, 330)
        Me.lblNewPricePlan.Name = "lblNewPricePlan"
        Me.lblNewPricePlan.Size = New System.Drawing.Size(80, 13)
        Me.lblNewPricePlan.TabIndex = 97
        Me.lblNewPricePlan.Text = "NewPrice Plan:"
        '
        'txtNewPricePlan
        '
        Me.txtNewPricePlan.Location = New System.Drawing.Point(108, 322)
        Me.txtNewPricePlan.Name = "txtNewPricePlan"
        Me.txtNewPricePlan.Size = New System.Drawing.Size(122, 20)
        Me.txtNewPricePlan.TabIndex = 98
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(251, 330)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(59, 13)
        Me.lblPrice.TabIndex = 99
        Me.lblPrice.Text = "New Price:"
        '
        'txtNewPrice
        '
        Me.txtNewPrice.Location = New System.Drawing.Point(316, 322)
        Me.txtNewPrice.Name = "txtNewPrice"
        Me.txtNewPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPrice.TabIndex = 100
        '
        'CancelRentalToolStripMenuItem
        '
        Me.CancelRentalToolStripMenuItem.Name = "CancelRentalToolStripMenuItem"
        Me.CancelRentalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CancelRentalToolStripMenuItem.Text = "Cancel Rental"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'frmPriceOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.txtNewPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtNewPricePlan)
        Me.Controls.Add(Me.lblNewPricePlan)
        Me.Controls.Add(Me.lblPriceList)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblThePriceIs)
        Me.Controls.Add(Me.lsbPricePlans)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblVehicleRatePlans)
        Me.Name = "frmPriceOptions"
        Me.Text = "Mavericks Car Rental Company - Price Options"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewVehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVehicleRatePlans As System.Windows.Forms.Label
    Friend WithEvents lsbPricePlans As System.Windows.Forms.ListBox
    Friend WithEvents lblThePriceIs As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPriceList As System.Windows.Forms.Label
    Friend WithEvents lblNewPricePlan As System.Windows.Forms.Label
    Friend WithEvents txtNewPricePlan As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtNewPrice As System.Windows.Forms.TextBox
    Friend WithEvents CancelRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
