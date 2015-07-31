<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalCancel
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
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbLastNameRC = New System.Windows.Forms.ComboBox()
        Me.lblLastNameSearchRC = New System.Windows.Forms.Label()
        Me.cmbInvoiceIdRC = New System.Windows.Forms.ComboBox()
        Me.lblInvoiceID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInvoiceIdRC = New System.Windows.Forms.Label()
        Me.txtInvoiceIdRC1 = New System.Windows.Forms.TextBox()
        Me.ckbSelectRC1 = New System.Windows.Forms.CheckBox()
        Me.lblSelectRC = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastNameRC1 = New System.Windows.Forms.TextBox()
        Me.txtFirstNameRC1 = New System.Windows.Forms.TextBox()
        Me.lblFirstNameRC = New System.Windows.Forms.Label()
        Me.txtFirstNameRC2 = New System.Windows.Forms.TextBox()
        Me.txtLastNameRC2 = New System.Windows.Forms.TextBox()
        Me.ckbSelectRC2 = New System.Windows.Forms.CheckBox()
        Me.txtInvoiceIdRC2 = New System.Windows.Forms.TextBox()
        Me.txtFirstNameRC3 = New System.Windows.Forms.TextBox()
        Me.txtLastNameRC3 = New System.Windows.Forms.TextBox()
        Me.ckbSelectRC3 = New System.Windows.Forms.CheckBox()
        Me.txtInvoiceIdRC3 = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
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
        'cmbLastNameRC
        '
        Me.cmbLastNameRC.FormattingEnabled = True
        Me.cmbLastNameRC.Location = New System.Drawing.Point(354, 56)
        Me.cmbLastNameRC.Name = "cmbLastNameRC"
        Me.cmbLastNameRC.Size = New System.Drawing.Size(121, 21)
        Me.cmbLastNameRC.TabIndex = 93
        '
        'lblLastNameSearchRC
        '
        Me.lblLastNameSearchRC.AutoSize = True
        Me.lblLastNameSearchRC.Location = New System.Drawing.Point(284, 65)
        Me.lblLastNameSearchRC.Name = "lblLastNameSearchRC"
        Me.lblLastNameSearchRC.Size = New System.Drawing.Size(61, 13)
        Me.lblLastNameSearchRC.TabIndex = 92
        Me.lblLastNameSearchRC.Text = "Last Name:"
        '
        'cmbInvoiceIdRC
        '
        Me.cmbInvoiceIdRC.FormattingEnabled = True
        Me.cmbInvoiceIdRC.Location = New System.Drawing.Point(109, 57)
        Me.cmbInvoiceIdRC.Name = "cmbInvoiceIdRC"
        Me.cmbInvoiceIdRC.Size = New System.Drawing.Size(121, 21)
        Me.cmbInvoiceIdRC.TabIndex = 91
        '
        'lblInvoiceID
        '
        Me.lblInvoiceID.AutoSize = True
        Me.lblInvoiceID.Location = New System.Drawing.Point(53, 65)
        Me.lblInvoiceID.Name = "lblInvoiceID"
        Me.lblInvoiceID.Size = New System.Drawing.Size(59, 13)
        Me.lblInvoiceID.TabIndex = 90
        Me.lblInvoiceID.Text = "Invoice ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Rental Cancel"
        '
        'lblInvoiceIdRC
        '
        Me.lblInvoiceIdRC.AutoSize = True
        Me.lblInvoiceIdRC.Location = New System.Drawing.Point(62, 117)
        Me.lblInvoiceIdRC.Name = "lblInvoiceIdRC"
        Me.lblInvoiceIdRC.Size = New System.Drawing.Size(59, 13)
        Me.lblInvoiceIdRC.TabIndex = 94
        Me.lblInvoiceIdRC.Text = "Invoice ID:"
        '
        'txtInvoiceIdRC1
        '
        Me.txtInvoiceIdRC1.Location = New System.Drawing.Point(65, 142)
        Me.txtInvoiceIdRC1.Name = "txtInvoiceIdRC1"
        Me.txtInvoiceIdRC1.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceIdRC1.TabIndex = 95
        '
        'ckbSelectRC1
        '
        Me.ckbSelectRC1.AutoSize = True
        Me.ckbSelectRC1.Location = New System.Drawing.Point(18, 148)
        Me.ckbSelectRC1.Name = "ckbSelectRC1"
        Me.ckbSelectRC1.Size = New System.Drawing.Size(15, 14)
        Me.ckbSelectRC1.TabIndex = 96
        Me.ckbSelectRC1.UseVisualStyleBackColor = True
        '
        'lblSelectRC
        '
        Me.lblSelectRC.AutoSize = True
        Me.lblSelectRC.Location = New System.Drawing.Point(12, 117)
        Me.lblSelectRC.Name = "lblSelectRC"
        Me.lblSelectRC.Size = New System.Drawing.Size(37, 13)
        Me.lblSelectRC.TabIndex = 97
        Me.lblSelectRC.Text = "Select"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(190, 117)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 98
        Me.lblLastName.Text = "Last Name:"
        '
        'txtLastNameRC1
        '
        Me.txtLastNameRC1.Location = New System.Drawing.Point(193, 142)
        Me.txtLastNameRC1.Name = "txtLastNameRC1"
        Me.txtLastNameRC1.Size = New System.Drawing.Size(100, 20)
        Me.txtLastNameRC1.TabIndex = 99
        '
        'txtFirstNameRC1
        '
        Me.txtFirstNameRC1.Location = New System.Drawing.Point(322, 142)
        Me.txtFirstNameRC1.Name = "txtFirstNameRC1"
        Me.txtFirstNameRC1.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNameRC1.TabIndex = 100
        '
        'lblFirstNameRC
        '
        Me.lblFirstNameRC.AutoSize = True
        Me.lblFirstNameRC.Location = New System.Drawing.Point(322, 117)
        Me.lblFirstNameRC.Name = "lblFirstNameRC"
        Me.lblFirstNameRC.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstNameRC.TabIndex = 101
        Me.lblFirstNameRC.Text = "First Name"
        '
        'txtFirstNameRC2
        '
        Me.txtFirstNameRC2.Location = New System.Drawing.Point(322, 181)
        Me.txtFirstNameRC2.Name = "txtFirstNameRC2"
        Me.txtFirstNameRC2.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNameRC2.TabIndex = 105
        '
        'txtLastNameRC2
        '
        Me.txtLastNameRC2.Location = New System.Drawing.Point(193, 181)
        Me.txtLastNameRC2.Name = "txtLastNameRC2"
        Me.txtLastNameRC2.Size = New System.Drawing.Size(100, 20)
        Me.txtLastNameRC2.TabIndex = 104
        '
        'ckbSelectRC2
        '
        Me.ckbSelectRC2.AutoSize = True
        Me.ckbSelectRC2.Location = New System.Drawing.Point(18, 187)
        Me.ckbSelectRC2.Name = "ckbSelectRC2"
        Me.ckbSelectRC2.Size = New System.Drawing.Size(15, 14)
        Me.ckbSelectRC2.TabIndex = 103
        Me.ckbSelectRC2.UseVisualStyleBackColor = True
        '
        'txtInvoiceIdRC2
        '
        Me.txtInvoiceIdRC2.Location = New System.Drawing.Point(65, 181)
        Me.txtInvoiceIdRC2.Name = "txtInvoiceIdRC2"
        Me.txtInvoiceIdRC2.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceIdRC2.TabIndex = 102
        '
        'txtFirstNameRC3
        '
        Me.txtFirstNameRC3.Location = New System.Drawing.Point(322, 222)
        Me.txtFirstNameRC3.Name = "txtFirstNameRC3"
        Me.txtFirstNameRC3.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstNameRC3.TabIndex = 109
        '
        'txtLastNameRC3
        '
        Me.txtLastNameRC3.Location = New System.Drawing.Point(193, 222)
        Me.txtLastNameRC3.Name = "txtLastNameRC3"
        Me.txtLastNameRC3.Size = New System.Drawing.Size(100, 20)
        Me.txtLastNameRC3.TabIndex = 108
        '
        'ckbSelectRC3
        '
        Me.ckbSelectRC3.AutoSize = True
        Me.ckbSelectRC3.Location = New System.Drawing.Point(18, 228)
        Me.ckbSelectRC3.Name = "ckbSelectRC3"
        Me.ckbSelectRC3.Size = New System.Drawing.Size(15, 14)
        Me.ckbSelectRC3.TabIndex = 107
        Me.ckbSelectRC3.UseVisualStyleBackColor = True
        '
        'txtInvoiceIdRC3
        '
        Me.txtInvoiceIdRC3.Location = New System.Drawing.Point(65, 222)
        Me.txtInvoiceIdRC3.Name = "txtInvoiceIdRC3"
        Me.txtInvoiceIdRC3.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceIdRC3.TabIndex = 106
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(193, 315)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 110
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(297, 314)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 111
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'frmRentalCancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 431)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtFirstNameRC3)
        Me.Controls.Add(Me.txtLastNameRC3)
        Me.Controls.Add(Me.ckbSelectRC3)
        Me.Controls.Add(Me.txtInvoiceIdRC3)
        Me.Controls.Add(Me.txtFirstNameRC2)
        Me.Controls.Add(Me.txtLastNameRC2)
        Me.Controls.Add(Me.ckbSelectRC2)
        Me.Controls.Add(Me.txtInvoiceIdRC2)
        Me.Controls.Add(Me.lblFirstNameRC)
        Me.Controls.Add(Me.txtFirstNameRC1)
        Me.Controls.Add(Me.txtLastNameRC1)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblSelectRC)
        Me.Controls.Add(Me.ckbSelectRC1)
        Me.Controls.Add(Me.txtInvoiceIdRC1)
        Me.Controls.Add(Me.lblInvoiceIdRC)
        Me.Controls.Add(Me.cmbLastNameRC)
        Me.Controls.Add(Me.lblLastNameSearchRC)
        Me.Controls.Add(Me.cmbInvoiceIdRC)
        Me.Controls.Add(Me.lblInvoiceID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmRentalCancel"
        Me.Text = "Mavericks Car Rental Company - Rental Cancel"
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
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewVehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriceOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewPriceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbLastNameRC As System.Windows.Forms.ComboBox
    Friend WithEvents lblLastNameSearchRC As System.Windows.Forms.Label
    Friend WithEvents cmbInvoiceIdRC As System.Windows.Forms.ComboBox
    Friend WithEvents lblInvoiceID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblInvoiceIdRC As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceIdRC1 As System.Windows.Forms.TextBox
    Friend WithEvents ckbSelectRC1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblSelectRC As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastNameRC1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstNameRC1 As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstNameRC As System.Windows.Forms.Label
    Friend WithEvents txtFirstNameRC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNameRC2 As System.Windows.Forms.TextBox
    Friend WithEvents ckbSelectRC2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtInvoiceIdRC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstNameRC3 As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNameRC3 As System.Windows.Forms.TextBox
    Friend WithEvents ckbSelectRC3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtInvoiceIdRC3 As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
