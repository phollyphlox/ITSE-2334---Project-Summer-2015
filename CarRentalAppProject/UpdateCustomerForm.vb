Public Class UpdateCustomerForm

    Private Sub UpdateRentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Customer)
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Rental)

    End Sub
End Class