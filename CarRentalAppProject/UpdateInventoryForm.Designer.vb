<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateInventoryForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.New_Maverick_Car_RentalDataSet = New CarRentalAppProject.new_Maverick_Car_RentalDataSet()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.VehicleTableAdapter()
        Me.KeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MakeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuelTankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventorySaveButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KeyDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.VINDataGridViewTextBoxColumn, Me.MakeDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.ColorDataGridViewTextBoxColumn, Me.ConditionDataGridViewTextBoxColumn, Me.FuelTankDataGridViewTextBoxColumn, Me.AvailableDataGridViewCheckBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(95, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'New_Maverick_Car_RentalDataSet
        '
        Me.New_Maverick_Car_RentalDataSet.DataSetName = "new_Maverick_Car_RentalDataSet"
        Me.New_Maverick_Car_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'KeyDataGridViewTextBoxColumn
        '
        Me.KeyDataGridViewTextBoxColumn.DataPropertyName = "Key"
        Me.KeyDataGridViewTextBoxColumn.HeaderText = "Key"
        Me.KeyDataGridViewTextBoxColumn.Name = "KeyDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'VINDataGridViewTextBoxColumn
        '
        Me.VINDataGridViewTextBoxColumn.DataPropertyName = "VIN"
        Me.VINDataGridViewTextBoxColumn.HeaderText = "VIN"
        Me.VINDataGridViewTextBoxColumn.Name = "VINDataGridViewTextBoxColumn"
        '
        'MakeDataGridViewTextBoxColumn
        '
        Me.MakeDataGridViewTextBoxColumn.DataPropertyName = "Make"
        Me.MakeDataGridViewTextBoxColumn.HeaderText = "Make"
        Me.MakeDataGridViewTextBoxColumn.Name = "MakeDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'ColorDataGridViewTextBoxColumn
        '
        Me.ColorDataGridViewTextBoxColumn.DataPropertyName = "Color"
        Me.ColorDataGridViewTextBoxColumn.HeaderText = "Color"
        Me.ColorDataGridViewTextBoxColumn.Name = "ColorDataGridViewTextBoxColumn"
        '
        'ConditionDataGridViewTextBoxColumn
        '
        Me.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.HeaderText = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn"
        '
        'FuelTankDataGridViewTextBoxColumn
        '
        Me.FuelTankDataGridViewTextBoxColumn.DataPropertyName = "Fuel Tank"
        Me.FuelTankDataGridViewTextBoxColumn.HeaderText = "Fuel Tank"
        Me.FuelTankDataGridViewTextBoxColumn.Name = "FuelTankDataGridViewTextBoxColumn"
        '
        'AvailableDataGridViewCheckBoxColumn
        '
        Me.AvailableDataGridViewCheckBoxColumn.DataPropertyName = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.HeaderText = "Available"
        Me.AvailableDataGridViewCheckBoxColumn.Name = "AvailableDataGridViewCheckBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'InventorySaveButton
        '
        Me.InventorySaveButton.Location = New System.Drawing.Point(322, 290)
        Me.InventorySaveButton.Name = "InventorySaveButton"
        Me.InventorySaveButton.Size = New System.Drawing.Size(75, 23)
        Me.InventorySaveButton.TabIndex = 1
        Me.InventorySaveButton.Text = "Save"
        Me.InventorySaveButton.UseVisualStyleBackColor = True
        '
        'UpdateInventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 339)
        Me.Controls.Add(Me.InventorySaveButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UpdateInventoryForm"
        Me.Text = "UpdateInventoryForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.New_Maverick_Car_RentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents New_Maverick_Car_RentalDataSet As CarRentalAppProject.new_Maverick_Car_RentalDataSet
    Friend WithEvents VehicleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehicleTableAdapter As CarRentalAppProject.new_Maverick_Car_RentalDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents KeyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MakeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConditionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FuelTankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventorySaveButton As System.Windows.Forms.Button
End Class
