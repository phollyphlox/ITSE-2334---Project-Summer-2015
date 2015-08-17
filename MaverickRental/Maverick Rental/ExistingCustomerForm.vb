Public Class ExistingCustomerForm
    Dim myCustomer As Customer
    Dim table As DataTable = Customer.adapter.GetData()

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If listCustomerInfo.SelectedIndex < 0 Then
            MessageBox.Show("Please selct a customer from the list")
            Exit Sub
        End If
        My.Forms.SelectVehicleForm.Show()
        chooseCustomer()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ExistingCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SharedAssets.newCustomer = False
        myCustomer = New Customer
        'TODO: This line of code loads data into the 'MaverickDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.MaverickDatabaseDataSet.Customer)
        comboState.Items.AddRange(SharedAssets.state)
        SharedAssets.addNames(listCustomerInfo, table)
    End Sub

    Private Sub FillingControls(index As Integer)
        If (table.Rows(index)("Organization").ToString.Length > 0) Then
            txtOrg.Text = table.Rows(index)("Organization")
        Else
            txtOrg.Text = "-None-"
        End If
        txtCustNum.Text = table.Rows(index)("Customer Number")
        txtFName.Text = table.Rows(index)("First Name")
        txtLName.Text = table.Rows(index)("Last Name")
        txtMI.Text = table.Rows(index)("Middle Initial")
        txtStreet.Text = table.Rows(index)("Street")
        txtCity.Text = table.Rows(index)("City")
        comboState.SelectedItem = table.Rows(index)("State")
        txtZip.Text = table.Rows(index)("Zip-Code")
        txtDLNum.Text = table.Rows(index)("DL #")
        txtPhoneNum.Text = table.Rows(index)("Phone Number")
    End Sub

    Private Sub listCustomerInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCustomerInfo.SelectedIndexChanged
        Dim index As Integer = listCustomerInfo.SelectedIndex
        FillingControls(index)
    End Sub
    Private Sub chooseCustomer()
        If txtCustNum.Text > 0 Then
            myCustomer = New Customer(txtCustNum.Text, txtFName.Text, txtMI.Text, txtLName.Text, txtDLNum.Text, txtStreet.Text, comboState.SelectedItem.ToString, txtZip.Text, txtPhoneNum.Text, txtOrg.Text)
            SharedAssets.currentCustomer = myCustomer
        End If
    End Sub
End Class