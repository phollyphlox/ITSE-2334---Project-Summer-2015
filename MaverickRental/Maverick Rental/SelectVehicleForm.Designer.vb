<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectVehicleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.listVehicleAvailable = New System.Windows.Forms.ListBox()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.comboCategory = New System.Windows.Forms.ComboBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.MaverickDatabaseDataSet = New Maverick_Rental.MaverickDatabaseDataSet()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter = New Maverick_Rental.MaverickDatabaseDataSetTableAdapters.VehicleTableAdapter()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        CType(Me.MaverickDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(270, 388)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(361, 388)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Go back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(470, 388)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 2
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'listVehicleAvailable
        '
        Me.listVehicleAvailable.FormattingEnabled = True
        Me.listVehicleAvailable.Location = New System.Drawing.Point(12, 26)
        Me.listVehicleAvailable.Name = "listVehicleAvailable"
        Me.listVehicleAvailable.Size = New System.Drawing.Size(177, 381)
        Me.listVehicleAvailable.TabIndex = 3
        '
        'rtxtDescription
        '
        Me.rtxtDescription.Location = New System.Drawing.Point(491, 237)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.Size = New System.Drawing.Size(206, 105)
        Me.rtxtDescription.TabIndex = 5
        Me.rtxtDescription.Text = ""
        '
        'txtVin
        '
        Me.txtVin.Location = New System.Drawing.Point(303, 26)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.Size = New System.Drawing.Size(100, 20)
        Me.txtVin.TabIndex = 6
        '
        'comboCategory
        '
        Me.comboCategory.FormattingEnabled = True
        Me.comboCategory.Location = New System.Drawing.Point(470, 24)
        Me.comboCategory.Name = "comboCategory"
        Me.comboCategory.Size = New System.Drawing.Size(121, 21)
        Me.comboCategory.TabIndex = 7
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(244, 84)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(100, 20)
        Me.txtMake.TabIndex = 8
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(470, 91)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 9
        '
        'MaverickDatabaseDataSet
        '
        Me.MaverickDatabaseDataSet.DataSetName = "MaverickDatabaseDataSet"
        Me.MaverickDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.MaverickDatabaseDataSet
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'txtAvailable
        '
        Me.txtAvailable.Location = New System.Drawing.Point(398, 155)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(100, 20)
        Me.txtAvailable.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Available:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "VIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Category:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Make:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Model:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cars Available:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(498, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(233, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Color:"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(273, 208)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 22
        '
        'SelectVehicleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 453)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.comboCategory)
        Me.Controls.Add(Me.txtVin)
        Me.Controls.Add(Me.rtxtDescription)
        Me.Controls.Add(Me.listVehicleAvailable)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "SelectVehicleForm"
        Me.Text = "SelectVehicleForm"
        CType(Me.MaverickDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents listVehicleAvailable As ListBox
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents txtVin As TextBox
    Friend WithEvents comboCategory As ComboBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents MaverickDatabaseDataSet As MaverickDatabaseDataSet
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As MaverickDatabaseDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtColor As TextBox
End Class
