<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceMaintenaceForm
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
        Me.InvoiceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRentedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReturnedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaverickDatabaseDataSet = New Maverick_Rental.MaverickDatabaseDataSet()
        Me.RentalTableAdapter = New Maverick_Rental.MaverickDatabaseDataSetTableAdapters.RentalTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaverickDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceNumberDataGridViewTextBoxColumn, Me.VINDataGridViewTextBoxColumn, Me.CustomerNumberDataGridViewTextBoxColumn, Me.PaymentMethodDataGridViewTextBoxColumn, Me.DateRentedDataGridViewTextBoxColumn, Me.DateReturnedDataGridViewTextBoxColumn, Me.PaidDataGridViewCheckBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RentalBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 253)
        Me.DataGridView1.TabIndex = 0
        '
        'InvoiceNumberDataGridViewTextBoxColumn
        '
        Me.InvoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "Invoice Number"
        Me.InvoiceNumberDataGridViewTextBoxColumn.HeaderText = "Invoice Number"
        Me.InvoiceNumberDataGridViewTextBoxColumn.Name = "InvoiceNumberDataGridViewTextBoxColumn"
        '
        'VINDataGridViewTextBoxColumn
        '
        Me.VINDataGridViewTextBoxColumn.DataPropertyName = "VIN"
        Me.VINDataGridViewTextBoxColumn.HeaderText = "VIN"
        Me.VINDataGridViewTextBoxColumn.Name = "VINDataGridViewTextBoxColumn"
        '
        'CustomerNumberDataGridViewTextBoxColumn
        '
        Me.CustomerNumberDataGridViewTextBoxColumn.DataPropertyName = "Customer Number"
        Me.CustomerNumberDataGridViewTextBoxColumn.HeaderText = "Customer Number"
        Me.CustomerNumberDataGridViewTextBoxColumn.Name = "CustomerNumberDataGridViewTextBoxColumn"
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        '
        'DateRentedDataGridViewTextBoxColumn
        '
        Me.DateRentedDataGridViewTextBoxColumn.DataPropertyName = "Date Rented"
        Me.DateRentedDataGridViewTextBoxColumn.HeaderText = "Date Rented"
        Me.DateRentedDataGridViewTextBoxColumn.Name = "DateRentedDataGridViewTextBoxColumn"
        '
        'DateReturnedDataGridViewTextBoxColumn
        '
        Me.DateReturnedDataGridViewTextBoxColumn.DataPropertyName = "Date Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.HeaderText = "Date Returned"
        Me.DateReturnedDataGridViewTextBoxColumn.Name = "DateReturnedDataGridViewTextBoxColumn"
        '
        'PaidDataGridViewCheckBoxColumn
        '
        Me.PaidDataGridViewCheckBoxColumn.DataPropertyName = "Paid"
        Me.PaidDataGridViewCheckBoxColumn.HeaderText = "Paid"
        Me.PaidDataGridViewCheckBoxColumn.Name = "PaidDataGridViewCheckBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "Rental"
        Me.RentalBindingSource.DataSource = Me.MaverickDatabaseDataSet
        '
        'MaverickDatabaseDataSet
        '
        Me.MaverickDatabaseDataSet.DataSetName = "MaverickDatabaseDataSet"
        Me.MaverickDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(844, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveChangesToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SaveChangesToolStripMenuItem
        '
        Me.SaveChangesToolStripMenuItem.Name = "SaveChangesToolStripMenuItem"
        Me.SaveChangesToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.SaveChangesToolStripMenuItem.Text = "Save Changes"
        '
        'InvoiceMaintenaceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 277)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InvoiceMaintenaceForm"
        Me.Text = "InvoiceMaintenaceForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaverickDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MaverickDatabaseDataSet As Maverick_Rental.MaverickDatabaseDataSet
    Friend WithEvents RentalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RentalTableAdapter As Maverick_Rental.MaverickDatabaseDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents InvoiceNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRentedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateReturnedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveChangesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
