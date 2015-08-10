' Sophia 8/7/2015
Public Class grpbDriverInfo

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnAddNewCustomer_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        Dim mCustomer As New Customer
        Dim result As Boolean
        result = mCustomer.AddCustomer("none", txtFirstName.Text, txtMiddleInitial.Text, txtLastName.Text, CInt(txtDriverLic.Text), "none", txtAddress.Text, txtCity.Text, cmbLicState.SelectedValue, txtZip.Text, txtPhone.Text, txtAge.Text)
        If result = False Then
            lblInfo.Text = Customer.ErrorMessage
        Else
            lblInfo.Text = "Customer is added."
        End If

    End Sub

    Private Sub grpbDriverInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim state() As String = {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA",
"KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
"NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX",
"UT", "VT", "VA", "WA", "WV", "WI", "WY"}
        cmbLicState.Items.AddRange(state)

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


    Private Sub txtDriverLic_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDriverLic.KeyPress
        If e.KeyChar < "0" OrElse e.KeyChar > "9" Then
            e.Handled = True
        End If
    End Sub

End Class