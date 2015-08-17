Public Class NewCustomerForm
    Private myCustomer As Customer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If txtOrg.Text.Length > 1 Then
            myCustomer = New Customer(-1, txtFName.Text, txtMI.Text, txtLName.Text, txtDLNum.Text, txtStreet.Text, txtCity.Text,
                                    comboState.SelectedItem, txtZip.Text, txtPhoneNum.Text)
        Else
            myCustomer = New Customer(txtFName.Text, txtMI.Text, txtLName.Text, txtDLNum.Text, txtStreet.Text, txtCity.Text,
                                   comboState.SelectedItem, txtZip.Text, txtPhoneNum.Text, txtOrg.Text)
        End If
        SharedAssets.currentCustomer = myCustomer
        My.Forms.SelectVehicleForm.Show()
        Me.Close()
    End Sub


    Private Sub NewCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboState.Items.AddRange(SharedAssets.state)
        SharedAssets.newCustomer = True
        myCustomer = New Customer
        txtCustNum.Text = myCustomer.customerNumber
    End Sub
End Class