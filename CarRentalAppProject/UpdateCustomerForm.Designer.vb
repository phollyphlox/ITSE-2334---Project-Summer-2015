<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateCustomerForm
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
        Me.New_Maverick_Car_RentalDataSet = New CarRentalAppProject.new_Maverick_Car_RentalDataSet()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.RentalTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleInitialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditCardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewMaverickCarRentalDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.CustomerTableAdapter()
        Me.customerSaveButton = New System.Windows.Forms.Button()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewMaverickCarRentalDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'New_Maverick_Car_RentalDataSet
        '
        Me.New_Maverick_Car_RentalDataSet.DataSetName = "new_Maverick_Car_RentalDataSet"
        Me.New_Maverick_Car_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "Rental"
        Me.RentalBindingSource.DataSource = Me.New_Maverick_Car_RentalDataSet
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.OrganizationDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleInitialDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DLDataGridViewTextBoxColumn, Me.CreditCardDataGridViewTextBoxColumn, Me.StreetDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(78, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(513, 193)
        Me.DataGridView1.TabIndex = 0
        '
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "Key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "Key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        '
        'OrganizationDataGridViewTextBoxColumn
        '
        Me.OrganizationDataGridViewTextBoxColumn.DataPropertyName = "Organization"
        Me.OrganizationDataGridViewTextBoxColumn.HeaderText = "Organization"
        Me.OrganizationDataGridViewTextBoxColumn.Name = "OrganizationDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleInitialDataGridViewTextBoxColumn
        '
        Me.MiddleInitialDataGridViewTextBoxColumn.DataPropertyName = "Middle Initial"
        Me.MiddleInitialDataGridViewTextBoxColumn.HeaderText = "Middle Initial"
        Me.MiddleInitialDataGridViewTextBoxColumn.Name = "MiddleInitialDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'DLDataGridViewTextBoxColumn
        '
        Me.DLDataGridViewTextBoxColumn.DataPropertyName = "DL #"
        Me.DLDataGridViewTextBoxColumn.HeaderText = "DL #"
        Me.DLDataGridViewTextBoxColumn.Name = "DLDataGridViewTextBoxColumn"
        '
        'CreditCardDataGridViewTextBoxColumn
        '
        Me.CreditCardDataGridViewTextBoxColumn.DataPropertyName = "Credit Card #"
        Me.CreditCardDataGridViewTextBoxColumn.HeaderText = "Credit Card #"
        Me.CreditCardDataGridViewTextBoxColumn.Name = "CreditCardDataGridViewTextBoxColumn"
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "Street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "Street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "Zip-Code"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "Zip-Code"
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.NewMaverickCarRentalDataSetBindingSource
        '
        'NewMaverickCarRentalDataSetBindingSource
        '
        Me.NewMaverickCarRentalDataSetBindingSource.DataSource = Me.New_Maverick_Car_RentalDataSet
        Me.NewMaverickCarRentalDataSetBindingSource.Position = 0
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'customerSaveButton
        '
        Me.customerSaveButton.Location = New System.Drawing.Point(296, 274)
        Me.customerSaveButton.Name = "customerSaveButton"
        Me.customerSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.customerSaveButton.TabIndex = 1
        Me.customerSaveButton.Text = "Save"
        Me.customerSaveButton.UseVisualStyleBackColor = True
        '
        'UpdateCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 329)
        Me.Controls.Add(Me.customerSaveButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UpdateCustomerForm"
        Me.Text = "CustomerUpdateForm"
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewMaverickCarRentalDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents New_Maverick_Car_RentalDataSet As CarRentalAppProject.new_Maverick_Car_RentalDataSet
    Friend WithEvents RentalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentalTableAdapter As CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NewMaverickCarRentalDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrganizationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleInitialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditCardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customerSaveButton As System.Windows.Forms.Button
End Class
