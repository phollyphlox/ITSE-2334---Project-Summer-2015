Public Class InvoiceForm
    Dim myInvoice As New Invoice
    Dim returnValueChange As Boolean = False
    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateRented.Value = Today
        addAcceptedPaymentMethods(comboPaymentMethod)
        lblPaymentType.Visible = False
        txtPaymentInfo.Visible = False
        txtCustomerNum.Text = SharedAssets.currentCustomer.customerNumber
        txtVin.Text = SharedAssets.currentVehicle.vinNum
        txtInvoiceNum.Text = myInvoice.invNum
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        My.Forms.SelectVehicleForm.Show()
        Me.Close()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        myInvoice = New Invoice(comboPaymentMethod.SelectedItem, dateRented.Value, dateReturned.Value, checkPaid.Checked, Convert.ToDouble(txtTotal.Text))
        SharedAssets.currentInvoice = myInvoice
        If SharedAssets.newCustomer Then
            Customer.addCustomerToDatabase(SharedAssets.currentCustomer)
        End If
        Invoice.addInvoiceToDatabase(SharedAssets.currentInvoice, SharedAssets.currentVehicle, SharedAssets.currentCustomer)
    End Sub
    Private Sub addAcceptedPaymentMethods(ByRef formObject)
        formObject.Items.Add("Credit Card")
        formObject.Items.Add("Debit Card")
        formObject.Items.Add("EPay")
        formObject.Items.Add("Paypal")
        formObject.Items.Add("Cash")
    End Sub

    Private Sub comboPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPaymentMethod.SelectedIndexChanged
        Select Case comboPaymentMethod.SelectedIndex
            Case 0
                lblPaymentType.Text = "Card Number:"
                lblPaymentType.Visible = True
                txtPaymentInfo.Visible = True
            Case 1
                lblPaymentType.Text = "Card Number:"
                lblPaymentType.Visible = True
                txtPaymentInfo.Visible = True
            Case 2
                lblPaymentType.Text = "EPay Name:"
                lblPaymentType.Visible = True
                txtPaymentInfo.Visible = True
            Case 3
                lblPaymentType.Text = "Paypal Account:"
                lblPaymentType.Visible = True
                txtPaymentInfo.Visible = True
            Case 4
                lblPaymentType.Visible = False
                txtPaymentInfo.Visible = False
        End Select
    End Sub
    Public Function calculateTotal(ByVal dateRent As Date, ByVal dateReturn As Date)
        Dim days = dateReturn - dateRent
        Dim countDays = days.Days
        Dim total = countDays * SharedAssets.currentCategory.thisPrice
        Return total
    End Function

    Private Sub dateRented_ValueChanged(sender As Object, e As EventArgs) Handles dateRented.ValueChanged

    End Sub

    Private Sub dateReturned_ValueChanged(sender As Object, e As EventArgs) Handles dateReturned.ValueChanged
        returnValueChange = True
        getTotal(returnValueChange)
    End Sub
    Private Sub getTotal(ByVal returnChange As Boolean)
        If returnChange Then
            txtTotal.Text = calculateTotal(dateRented.Value, dateReturned.Value)
        End If
    End Sub
End Class