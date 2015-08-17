<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
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
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.txtInvoiceNum = New System.Windows.Forms.TextBox()
        Me.txtCustomerNum = New System.Windows.Forms.TextBox()
        Me.txtVin = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dateRented = New System.Windows.Forms.DateTimePicker()
        Me.dateReturned = New System.Windows.Forms.DateTimePicker()
        Me.checkPaid = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.txtPaymentInfo = New System.Windows.Forms.TextBox()
        Me.comboPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(273, 391)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(378, 391)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(75, 23)
        Me.btnGoBack.TabIndex = 1
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(475, 391)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(75, 23)
        Me.btnFinish.TabIndex = 2
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'txtInvoiceNum
        '
        Me.txtInvoiceNum.Location = New System.Drawing.Point(131, 39)
        Me.txtInvoiceNum.Name = "txtInvoiceNum"
        Me.txtInvoiceNum.ReadOnly = True
        Me.txtInvoiceNum.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoiceNum.TabIndex = 4
        '
        'txtCustomerNum
        '
        Me.txtCustomerNum.Location = New System.Drawing.Point(140, 85)
        Me.txtCustomerNum.Name = "txtCustomerNum"
        Me.txtCustomerNum.ReadOnly = True
        Me.txtCustomerNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerNum.TabIndex = 5
        '
        'txtVin
        '
        Me.txtVin.Location = New System.Drawing.Point(344, 39)
        Me.txtVin.Name = "txtVin"
        Me.txtVin.ReadOnly = True
        Me.txtVin.Size = New System.Drawing.Size(216, 20)
        Me.txtVin.TabIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(131, 270)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 8
        '
        'dateRented
        '
        Me.dateRented.Location = New System.Drawing.Point(395, 180)
        Me.dateRented.Name = "dateRented"
        Me.dateRented.Size = New System.Drawing.Size(200, 20)
        Me.dateRented.TabIndex = 9
        '
        'dateReturned
        '
        Me.dateReturned.Location = New System.Drawing.Point(395, 216)
        Me.dateReturned.Name = "dateReturned"
        Me.dateReturned.Size = New System.Drawing.Size(200, 20)
        Me.dateReturned.TabIndex = 10
        '
        'checkPaid
        '
        Me.checkPaid.AutoSize = True
        Me.checkPaid.Location = New System.Drawing.Point(58, 310)
        Me.checkPaid.Name = "checkPaid"
        Me.checkPaid.Size = New System.Drawing.Size(47, 17)
        Me.checkPaid.TabIndex = 11
        Me.checkPaid.Text = "Paid"
        Me.checkPaid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Invoice Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "VIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Customer Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Payment Method:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Date Rented:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(309, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Date Returned:"
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(35, 237)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(72, 13)
        Me.lblPaymentType.TabIndex = 19
        Me.lblPaymentType.Text = "Card Number:"
        '
        'txtPaymentInfo
        '
        Me.txtPaymentInfo.Location = New System.Drawing.Point(131, 234)
        Me.txtPaymentInfo.Name = "txtPaymentInfo"
        Me.txtPaymentInfo.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentInfo.TabIndex = 20
        '
        'comboPaymentMethod
        '
        Me.comboPaymentMethod.FormattingEnabled = True
        Me.comboPaymentMethod.Location = New System.Drawing.Point(131, 200)
        Me.comboPaymentMethod.Name = "comboPaymentMethod"
        Me.comboPaymentMethod.Size = New System.Drawing.Size(121, 21)
        Me.comboPaymentMethod.TabIndex = 21
        '
        'InvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 442)
        Me.Controls.Add(Me.comboPaymentMethod)
        Me.Controls.Add(Me.txtPaymentInfo)
        Me.Controls.Add(Me.lblPaymentType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkPaid)
        Me.Controls.Add(Me.dateReturned)
        Me.Controls.Add(Me.dateRented)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVin)
        Me.Controls.Add(Me.txtCustomerNum)
        Me.Controls.Add(Me.txtInvoiceNum)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "InvoiceForm"
        Me.Text = "InvoiceForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents btnFinish As System.Windows.Forms.Button
    Friend WithEvents txtInvoiceNum As TextBox
    Friend WithEvents txtCustomerNum As TextBox
    Friend WithEvents txtVin As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dateRented As DateTimePicker
    Friend WithEvents dateReturned As DateTimePicker
    Friend WithEvents checkPaid As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents txtPaymentInfo As TextBox
    Friend WithEvents comboPaymentMethod As ComboBox
End Class
