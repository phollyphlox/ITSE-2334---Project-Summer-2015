<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(197, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Maverick Car Rental Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(247, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "We get you there fast"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarRentalAppProject.My.Resources.Resources.Car
        Me.PictureBox1.Location = New System.Drawing.Point(185, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 306)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem, Me.PriceOptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
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
        Me.RentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRentalToolStripMenuItem, Me.UpdateRentalToolStripMenuItem})
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
        Me.CustomersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateCustomersToolStripMenuItem, Me.AddCustomerToolStripMenuItem})
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
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddCustomerToolStripMenuItem.Text = "Add Customer"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 509)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewVehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewPriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
