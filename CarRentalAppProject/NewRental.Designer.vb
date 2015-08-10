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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiclesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCategoryCRA = New System.Windows.Forms.Label()
        Me.btnVehicleSearchCRA = New System.Windows.Forms.Button()
        Me.cmbCategoryCRA = New System.Windows.Forms.ComboBox()
        Me.PriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.New_Maverick_Car_RentalDataSet = New CarRentalAppProject.new_Maverick_Car_RentalDataSet()
        Me.lblPickupDateCRA = New System.Windows.Forms.Label()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.VehicleTableAdapter()
        Me.dtpPickupDateCRA = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpReturnDateCRA = New System.Windows.Forms.DateTimePicker()
        Me.PriceTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.PriceTableAdapter()
        Me.PriceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PriceRentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.RentalTableAdapter()
        Me.PriceRentalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceRentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriceRentalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HomeToolStripMenuItem, Me.CustomersToolStripMenuItem, Me.VehiclesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(329, 24)
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
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
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
        'lblCategoryCRA
        '
        Me.lblCategoryCRA.AutoSize = True
        Me.lblCategoryCRA.Location = New System.Drawing.Point(60, 78)
        Me.lblCategoryCRA.Name = "lblCategoryCRA"
        Me.lblCategoryCRA.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoryCRA.TabIndex = 10
        Me.lblCategoryCRA.Text = "Category:"
        '
        'btnVehicleSearchCRA
        '
        Me.btnVehicleSearchCRA.Location = New System.Drawing.Point(102, 225)
        Me.btnVehicleSearchCRA.Name = "btnVehicleSearchCRA"
        Me.btnVehicleSearchCRA.Size = New System.Drawing.Size(106, 23)
        Me.btnVehicleSearchCRA.TabIndex = 6
        Me.btnVehicleSearchCRA.Text = "Vehicle Search"
        Me.btnVehicleSearchCRA.UseVisualStyleBackColor = True
        '
        'cmbCategoryCRA
        '
        Me.cmbCategoryCRA.DataSource = Me.PriceBindingSource
        Me.cmbCategoryCRA.DisplayMember = "Category"
        Me.cmbCategoryCRA.FormattingEnabled = True
        Me.cmbCategoryCRA.Location = New System.Drawing.Point(120, 75)
        Me.cmbCategoryCRA.Name = "cmbCategoryCRA"
        Me.cmbCategoryCRA.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoryCRA.TabIndex = 8
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
        'lblPickupDateCRA
        '
        Me.lblPickupDateCRA.AutoSize = True
        Me.lblPickupDateCRA.Location = New System.Drawing.Point(45, 130)
        Me.lblPickupDateCRA.Name = "lblPickupDateCRA"
        Me.lblPickupDateCRA.Size = New System.Drawing.Size(67, 13)
        Me.lblPickupDateCRA.TabIndex = 12
        Me.lblPickupDateCRA.Text = "Rental Date:"
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.New_Maverick_Car_RentalDataSet
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'dtpPickupDateCRA
        '
        Me.dtpPickupDateCRA.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.dtpPickupDateCRA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPickupDateCRA.Location = New System.Drawing.Point(120, 124)
        Me.dtpPickupDateCRA.Name = "dtpPickupDateCRA"
        Me.dtpPickupDateCRA.Size = New System.Drawing.Size(151, 20)
        Me.dtpPickupDateCRA.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Return Date:"
        '
        'dtpReturnDateCRA
        '
        Me.dtpReturnDateCRA.CustomFormat = "MM/dd/yyyy h:mm tt"
        Me.dtpReturnDateCRA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnDateCRA.Location = New System.Drawing.Point(120, 161)
        Me.dtpReturnDateCRA.Name = "dtpReturnDateCRA"
        Me.dtpReturnDateCRA.Size = New System.Drawing.Size(151, 20)
        Me.dtpReturnDateCRA.TabIndex = 15
        '
        'PriceTableAdapter
        '
        Me.PriceTableAdapter.ClearBeforeFill = True
        '
        'PriceBindingSource1
        '
        Me.PriceBindingSource1.DataMember = "Price"
        Me.PriceBindingSource1.DataSource = Me.New_Maverick_Car_RentalDataSet
        '
        'PriceRentalBindingSource
        '
        Me.PriceRentalBindingSource.DataMember = "PriceRental"
        Me.PriceRentalBindingSource.DataSource = Me.PriceBindingSource
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'PriceRentalBindingSource1
        '
        Me.PriceRentalBindingSource1.DataMember = "PriceRental"
        Me.PriceRentalBindingSource1.DataSource = Me.PriceBindingSource
        '
        'frmNewRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 324)
        Me.Controls.Add(Me.dtpReturnDateCRA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpPickupDateCRA)
        Me.Controls.Add(Me.lblPickupDateCRA)
        Me.Controls.Add(Me.lblCategoryCRA)
        Me.Controls.Add(Me.cmbCategoryCRA)
        Me.Controls.Add(Me.btnVehicleSearchCRA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewRental"
        Me.Text = "Mavericks Car Rental Company - New Rental"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceRentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriceRentalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiclesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCategoryCRA As System.Windows.Forms.Label
    Friend WithEvents btnVehicleSearchCRA As System.Windows.Forms.Button
    Friend WithEvents cmbCategoryCRA As System.Windows.Forms.ComboBox
    Friend WithEvents lblPickupDateCRA As System.Windows.Forms.Label
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents New_Maverick_Car_RentalDataSet As new_Maverick_Car_RentalDataSet
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As new_Maverick_Car_RentalDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents dtpPickupDateCRA As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpReturnDateCRA As DateTimePicker
    Friend WithEvents PriceBindingSource As BindingSource
    Friend WithEvents PriceTableAdapter As new_Maverick_Car_RentalDataSetTableAdapters.PriceTableAdapter
    Friend WithEvents PriceRentalBindingSource As BindingSource
    Friend WithEvents RentalTableAdapter As new_Maverick_Car_RentalDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents PriceBindingSource1 As BindingSource
    Friend WithEvents PriceRentalBindingSource1 As BindingSource
End Class
