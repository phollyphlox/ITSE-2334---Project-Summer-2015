' Sophia 8/6/2015
Public Class frmCustomerUpdate
    Private mCustomer As New Customer
    Private table As DataTable = mCustomer.Items

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddNewVehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVehiclesToolStripMenuItem.Click
        frmVehicles.Show()
    End Sub

    Private Sub AddNewPriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPriceToolStripMenuItem.Click
        '  frmPriceOptions.Show()
    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        frmNewRental.Show()
    End Sub

    Private Sub UpdateRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRentalToolStripMenuItem.Click
        frmRentalUpdate.Show()
    End Sub

    Private Sub SearchRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchRentalToolStripMenuItem.Click
        frmRentalCancel.Show()
    End Sub

    Private Sub frmCustomerUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim state() As String = {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA",
"KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
"NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX",
"UT", "VT", "VA", "WA", "WV", "WI", "WY"}
        cmbLicState.Items.AddRange(state)

        For i As Integer = 0 To table.Rows.Count - 1
            lsbCustomers.Items.Add(table.Rows(i)("Last Name") & ", " & table.Rows(i)("First Name"))
        Next

    End Sub

    Private Sub lsbCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbCustomers.SelectedIndexChanged
        Dim index As Integer = lsbCustomers.SelectedIndex
        txtFirstNameCU.Text = table.Rows(index)("First Name")
        txtLastNameCU.Text = table.Rows(index)("Last Name")
        txtMidInitialCU.Text = table.Rows(index)("Middle Initial")
        txtAddressCU.Text = table.Rows(index)("Street")
        txtCityCU.Text = table.Rows(index)("City")
        cmbLicState.SelectedItem = table.Rows(index)("State")
        txtZipCU.Text = table.Rows(index)("Zip-Code")
        txtDriversLicCU.Text = table.Rows(index)("DL #")
        txtAge.Text = table.Rows(index)("Age")
        txtPhone.Text = table.Rows(index)("Phone Number")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim key As Integer

        key = lsbCustomers.SelectedIndex + 1
        If mCustomer.UpdateCustomer("none", txtFirstNameCU.Text, txtMidInitialCU.Text, txtLastNameCU.Text, CInt(txtDriversLicCU.Text), "none", txtAddressCU.Text, txtCityCU.Text, cmbLicState.SelectedText, txtZipCU.Text, txtPhone.Text, txtAge.Text, key) Then
            lblInfo.Text = "Customer information has been updated."
            lsbCustomers.Items.Clear()
            For i As Integer = 0 To table.Rows.Count - 1
                lsbCustomers.Items.Add(table.Rows(i)("Last Name") & ", " & table.Rows(i)("First Name"))
            Next
        Else
            lblInfo.Text = Customer.ErrorMessage
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar < "0" OrElse e.KeyChar > "9" OrElse e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If
    End Sub
End Class