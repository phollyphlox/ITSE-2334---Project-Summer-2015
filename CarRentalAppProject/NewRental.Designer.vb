<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewRental
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
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCarRentalApp = New System.Windows.Forms.Label()
        Me.lblCategoryCRA = New System.Windows.Forms.Label()
        Me.btnVehicleSearchCRA = New System.Windows.Forms.Button()
        Me.cmbCategoryCRA = New System.Windows.Forms.ComboBox()
        Me.lblPickupDateCRA = New System.Windows.Forms.Label()
        Me.dtpPickupDateCRA = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpReturnDateCRA = New System.Windows.Forms.DateTimePicker()
        Me.lblAgeCRA = New System.Windows.Forms.Label()
        Me.cmbAgeCRA = New System.Windows.Forms.ComboBox()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem, Me.HomeToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(578, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'lblCarRentalApp
        '
        Me.lblCarRentalApp.AutoSize = True
        Me.lblCarRentalApp.Location = New System.Drawing.Point(13, 39)
        Me.lblCarRentalApp.Name = "lblCarRentalApp"
        Me.lblCarRentalApp.Size = New System.Drawing.Size(112, 13)
        Me.lblCarRentalApp.TabIndex = 2
        Me.lblCarRentalApp.Text = "Car Rental Application"
        '
        'lblCategoryCRA
        '
        Me.lblCategoryCRA.AutoSize = True
        Me.lblCategoryCRA.Location = New System.Drawing.Point(70, 76)
        Me.lblCategoryCRA.Name = "lblCategoryCRA"
        Me.lblCategoryCRA.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoryCRA.TabIndex = 10
        Me.lblCategoryCRA.Text = "Category:"
        '
        'btnVehicleSearchCRA
        '
        Me.btnVehicleSearchCRA.Location = New System.Drawing.Point(132, 268)
        Me.btnVehicleSearchCRA.Name = "btnVehicleSearchCRA"
        Me.btnVehicleSearchCRA.Size = New System.Drawing.Size(106, 23)
        Me.btnVehicleSearchCRA.TabIndex = 6
        Me.btnVehicleSearchCRA.Text = "Vehicle Search"
        Me.btnVehicleSearchCRA.UseVisualStyleBackColor = True
        '
        'cmbCategoryCRA
        '
        Me.cmbCategoryCRA.FormattingEnabled = True
        Me.cmbCategoryCRA.Location = New System.Drawing.Point(132, 68)
        Me.cmbCategoryCRA.Name = "cmbCategoryCRA"
        Me.cmbCategoryCRA.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoryCRA.TabIndex = 8
        '
        'lblPickupDateCRA
        '
        Me.lblPickupDateCRA.AutoSize = True
        Me.lblPickupDateCRA.Location = New System.Drawing.Point(72, 108)
        Me.lblPickupDateCRA.Name = "lblPickupDateCRA"
        Me.lblPickupDateCRA.Size = New System.Drawing.Size(113, 13)
        Me.lblPickupDateCRA.TabIndex = 12
        Me.lblPickupDateCRA.Text = "Pickup Date and Time"
        '
        'dtpPickupDateCRA
        '
        Me.dtpPickupDateCRA.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.dtpPickupDateCRA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPickupDateCRA.Location = New System.Drawing.Point(132, 124)
        Me.dtpPickupDateCRA.Name = "dtpPickupDateCRA"
        Me.dtpPickupDateCRA.Size = New System.Drawing.Size(151, 20)
        Me.dtpPickupDateCRA.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Return Date and Time"
        '
        'dtpReturnDateCRA
        '
        Me.dtpReturnDateCRA.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.dtpReturnDateCRA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnDateCRA.Location = New System.Drawing.Point(132, 170)
        Me.dtpReturnDateCRA.Name = "dtpReturnDateCRA"
        Me.dtpReturnDateCRA.Size = New System.Drawing.Size(151, 20)
        Me.dtpReturnDateCRA.TabIndex = 15
        '
        'lblAgeCRA
        '
        Me.lblAgeCRA.AutoSize = True
        Me.lblAgeCRA.Location = New System.Drawing.Point(76, 210)
        Me.lblAgeCRA.Name = "lblAgeCRA"
        Me.lblAgeCRA.Size = New System.Drawing.Size(32, 13)
        Me.lblAgeCRA.TabIndex = 16
        Me.lblAgeCRA.Text = "AGE:"
        '
        'cmbAgeCRA
        '
        Me.cmbAgeCRA.Location = New System.Drawing.Point(132, 201)
        Me.cmbAgeCRA.Name = "cmbAgeCRA"
        Me.cmbAgeCRA.Size = New System.Drawing.Size(151, 21)
        Me.cmbAgeCRA.TabIndex = 17
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'HomeToolStripMenuItem1
        '
        Me.HomeToolStripMenuItem1.Name = "HomeToolStripMenuItem1"
        Me.HomeToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem1.Text = "Home"
        '
        'frmNewRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.cmbAgeCRA)
        Me.Controls.Add(Me.lblAgeCRA)
        Me.Controls.Add(Me.dtpReturnDateCRA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpPickupDateCRA)
        Me.Controls.Add(Me.lblPickupDateCRA)
        Me.Controls.Add(Me.lblCategoryCRA)
        Me.Controls.Add(Me.cmbCategoryCRA)
        Me.Controls.Add(Me.btnVehicleSearchCRA)
        Me.Controls.Add(Me.lblCarRentalApp)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewRental"
        Me.Text = "Mavericks Car Rental Company - New Rental"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCarRentalApp As System.Windows.Forms.Label
    Friend WithEvents lblCategoryCRA As System.Windows.Forms.Label
    Friend WithEvents btnVehicleSearchCRA As System.Windows.Forms.Button
    Friend WithEvents cmbCategoryCRA As System.Windows.Forms.ComboBox
    Friend WithEvents lblPickupDateCRA As System.Windows.Forms.Label
    Friend WithEvents dtpPickupDateCRA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpReturnDateCRA As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAgeCRA As System.Windows.Forms.Label
    Friend WithEvents cmbAgeCRA As System.Windows.Forms.ComboBox
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
