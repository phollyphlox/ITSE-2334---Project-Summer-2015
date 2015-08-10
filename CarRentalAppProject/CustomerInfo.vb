' Sophia 8/6/2015

Public Class frmCustomerInfo
    Private mCustomer As New Customer
    Dim table As DataTable = mCustomer.Items

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmPaymentInvoice.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub frmCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Customer)
        Dim state() As String = {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA",
"KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
"NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX",
"UT", "VT", "VA", "WA", "WV", "WI", "WY"}
        cmbLicState.Items.AddRange(state)
        For i As Integer = 0 To table.Rows.Count - 1
            cmbCustomersList.Items.Add(table.Rows(i)("Last Name") & ", " & table.Rows(i)("First Name"))

        Next
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbCustomersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomersList.SelectedIndexChanged
        Dim index As Integer = cmbCustomersList.SelectedIndex
        FillingControls(index)

    End Sub
    Private Sub FillingControls(index As Integer)
        txtFirstName.Text = table.Rows(index)("First Name")
        txtLastName.Text = table.Rows(index)("Last Name")
        txtMiddleInitial.Text = table.Rows(index)("Middle Initial")
        txtAddress.Text = table.Rows(index)("Street")
        txtCity.Text = table.Rows(index)("City")
        cmbLicState.SelectedItem = table.Rows(index)("State")
        txtZip.Text = table.Rows(index)("Zip-Code")
        txtDriverLic.Text = table.Rows(index)("DL #")
        txtAge.Text = table.Rows(index)("Age")
        txtPhone.Text = table.Rows(index)("Phone Number")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim index As Integer = cmbCustomersList.SelectedIndex
        FillingControls(index)
    End Sub

    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        grpbDriverInfo.ShowDialog()
    End Sub

    Private Sub UpdateCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomersToolStripMenuItem.Click
        frmCustomerUpdate.Show()
    End Sub
End Class