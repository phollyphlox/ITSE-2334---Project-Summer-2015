<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExistingCustomerForm
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
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.listCustomerInfo = New System.Windows.Forms.ListBox()
        Me.groupCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.comboState = New System.Windows.Forms.ComboBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtDLNum = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.groupBusinessInfo = New System.Windows.Forms.GroupBox()
        Me.txtCustNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaverickDatabaseDataSet = New Maverick_Rental.MaverickDatabaseDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Maverick_Rental.MaverickDatabaseDataSetTableAdapters.CustomerTableAdapter()
        Me.groupCustomerInfo.SuspendLayout()
        Me.groupBusinessInfo.SuspendLayout()
        CType(Me.MaverickDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(100, 308)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(409, 321)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'listCustomerInfo
        '
        Me.listCustomerInfo.FormattingEnabled = True
        Me.listCustomerInfo.Location = New System.Drawing.Point(26, 57)
        Me.listCustomerInfo.Name = "listCustomerInfo"
        Me.listCustomerInfo.Size = New System.Drawing.Size(137, 212)
        Me.listCustomerInfo.TabIndex = 2
        '
        'groupCustomerInfo
        '
        Me.groupCustomerInfo.Controls.Add(Me.comboState)
        Me.groupCustomerInfo.Controls.Add(Me.txtFName)
        Me.groupCustomerInfo.Controls.Add(Me.Label3)
        Me.groupCustomerInfo.Controls.Add(Me.txtMI)
        Me.groupCustomerInfo.Controls.Add(Me.Label6)
        Me.groupCustomerInfo.Controls.Add(Me.txtPhoneNum)
        Me.groupCustomerInfo.Controls.Add(Me.txtLName)
        Me.groupCustomerInfo.Controls.Add(Me.Label5)
        Me.groupCustomerInfo.Controls.Add(Me.Label4)
        Me.groupCustomerInfo.Controls.Add(Me.txtZip)
        Me.groupCustomerInfo.Controls.Add(Me.txtDLNum)
        Me.groupCustomerInfo.Controls.Add(Me.txtStreet)
        Me.groupCustomerInfo.Controls.Add(Me.txtCity)
        Me.groupCustomerInfo.Location = New System.Drawing.Point(198, 155)
        Me.groupCustomerInfo.Name = "groupCustomerInfo"
        Me.groupCustomerInfo.Size = New System.Drawing.Size(428, 114)
        Me.groupCustomerInfo.TabIndex = 26
        Me.groupCustomerInfo.TabStop = False
        Me.groupCustomerInfo.Text = "Customer Info:"
        '
        'comboState
        '
        Me.comboState.FormattingEnabled = True
        Me.comboState.Location = New System.Drawing.Point(267, 69)
        Me.comboState.Name = "comboState"
        Me.comboState.Size = New System.Drawing.Size(55, 21)
        Me.comboState.TabIndex = 21
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(41, 13)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 20)
        Me.txtFName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Name:"
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(158, 13)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(40, 20)
        Me.txtMI.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Phone Number:"
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(308, 42)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNum.TabIndex = 12
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(215, 13)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 20)
        Me.txtLName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-3, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Drivers License:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(328, 69)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 11
        '
        'txtDLNum
        '
        Me.txtDLNum.Location = New System.Drawing.Point(85, 46)
        Me.txtDLNum.Name = "txtDLNum"
        Me.txtDLNum.Size = New System.Drawing.Size(100, 20)
        Me.txtDLNum.TabIndex = 7
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(51, 73)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(100, 20)
        Me.txtStreet.TabIndex = 8
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(158, 72)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 9
        '
        'groupBusinessInfo
        '
        Me.groupBusinessInfo.Controls.Add(Me.txtCustNum)
        Me.groupBusinessInfo.Controls.Add(Me.Label1)
        Me.groupBusinessInfo.Controls.Add(Me.txtOrg)
        Me.groupBusinessInfo.Controls.Add(Me.Label2)
        Me.groupBusinessInfo.Location = New System.Drawing.Point(198, 30)
        Me.groupBusinessInfo.Name = "groupBusinessInfo"
        Me.groupBusinessInfo.Size = New System.Drawing.Size(245, 100)
        Me.groupBusinessInfo.TabIndex = 25
        Me.groupBusinessInfo.TabStop = False
        Me.groupBusinessInfo.Text = "Business Info:"
        '
        'txtCustNum
        '
        Me.txtCustNum.Location = New System.Drawing.Point(139, 19)
        Me.txtCustNum.Name = "txtCustNum"
        Me.txtCustNum.ReadOnly = True
        Me.txtCustNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCustNum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Customer Number:"
        '
        'txtOrg
        '
        Me.txtOrg.Location = New System.Drawing.Point(139, 61)
        Me.txtOrg.Name = "txtOrg"
        Me.txtOrg.Size = New System.Drawing.Size(100, 20)
        Me.txtOrg.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Organization:"
        '
        'MaverickDatabaseDataSet
        '
        Me.MaverickDatabaseDataSet.DataSetName = "MaverickDatabaseDataSet"
        Me.MaverickDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.MaverickDatabaseDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ExistingCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 406)
        Me.Controls.Add(Me.groupCustomerInfo)
        Me.Controls.Add(Me.groupBusinessInfo)
        Me.Controls.Add(Me.listCustomerInfo)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "ExistingCustomerForm"
        Me.Text = "ExistingCustomerForm"
        Me.groupCustomerInfo.ResumeLayout(False)
        Me.groupCustomerInfo.PerformLayout()
        Me.groupBusinessInfo.ResumeLayout(False)
        Me.groupBusinessInfo.PerformLayout()
        CType(Me.MaverickDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents MaverickDatabaseDataSet As MaverickDatabaseDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As MaverickDatabaseDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents listCustomerInfo As ListBox
    Friend WithEvents groupCustomerInfo As GroupBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtDLNum As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents groupBusinessInfo As GroupBox
    Friend WithEvents txtCustNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comboState As ComboBox
End Class
