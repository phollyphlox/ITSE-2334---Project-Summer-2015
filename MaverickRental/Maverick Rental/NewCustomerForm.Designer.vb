<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCustomerForm
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.txtCustNum = New System.Windows.Forms.TextBox()
        Me.txtOrg = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtDLNum = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.groupBusinessInfo = New System.Windows.Forms.GroupBox()
        Me.groupCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.comboState = New System.Windows.Forms.ComboBox()
        Me.groupBusinessInfo.SuspendLayout()
        Me.groupCustomerInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(74, 286)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(179, 286)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(75, 23)
        Me.btnContinue.TabIndex = 1
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'txtCustNum
        '
        Me.txtCustNum.Location = New System.Drawing.Point(139, 19)
        Me.txtCustNum.Name = "txtCustNum"
        Me.txtCustNum.ReadOnly = True
        Me.txtCustNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCustNum.TabIndex = 2
        '
        'txtOrg
        '
        Me.txtOrg.Location = New System.Drawing.Point(139, 61)
        Me.txtOrg.Name = "txtOrg"
        Me.txtOrg.Size = New System.Drawing.Size(100, 20)
        Me.txtOrg.TabIndex = 3
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(41, 13)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 20)
        Me.txtFName.TabIndex = 4
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(158, 13)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(40, 20)
        Me.txtMI.TabIndex = 5
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(215, 13)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 20)
        Me.txtLName.TabIndex = 6
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
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(328, 69)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 11
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(308, 42)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNum.TabIndex = 12
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Organization:"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Drivers License:"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Phone Number:"
        '
        'groupBusinessInfo
        '
        Me.groupBusinessInfo.Controls.Add(Me.txtCustNum)
        Me.groupBusinessInfo.Controls.Add(Me.Label1)
        Me.groupBusinessInfo.Controls.Add(Me.txtOrg)
        Me.groupBusinessInfo.Controls.Add(Me.Label2)
        Me.groupBusinessInfo.Location = New System.Drawing.Point(33, 26)
        Me.groupBusinessInfo.Name = "groupBusinessInfo"
        Me.groupBusinessInfo.Size = New System.Drawing.Size(245, 100)
        Me.groupBusinessInfo.TabIndex = 21
        Me.groupBusinessInfo.TabStop = False
        Me.groupBusinessInfo.Text = "Business Info:"
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
        Me.groupCustomerInfo.Location = New System.Drawing.Point(33, 132)
        Me.groupCustomerInfo.Name = "groupCustomerInfo"
        Me.groupCustomerInfo.Size = New System.Drawing.Size(428, 108)
        Me.groupCustomerInfo.TabIndex = 22
        Me.groupCustomerInfo.TabStop = False
        Me.groupCustomerInfo.Text = "Customer Info:"
        '
        'comboState
        '
        Me.comboState.FormattingEnabled = True
        Me.comboState.Location = New System.Drawing.Point(271, 69)
        Me.comboState.Name = "comboState"
        Me.comboState.Size = New System.Drawing.Size(44, 21)
        Me.comboState.TabIndex = 20
        '
        'NewCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 324)
        Me.Controls.Add(Me.groupCustomerInfo)
        Me.Controls.Add(Me.groupBusinessInfo)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "NewCustomerForm"
        Me.Text = "NewCustomerForm"
        Me.groupBusinessInfo.ResumeLayout(False)
        Me.groupBusinessInfo.PerformLayout()
        Me.groupCustomerInfo.ResumeLayout(False)
        Me.groupCustomerInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnContinue As System.Windows.Forms.Button
    Friend WithEvents txtCustNum As System.Windows.Forms.TextBox
    Friend WithEvents txtOrg As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtMI As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtDLNum As System.Windows.Forms.TextBox
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents groupBusinessInfo As System.Windows.Forms.GroupBox
    Friend WithEvents groupCustomerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents comboState As ComboBox
End Class
