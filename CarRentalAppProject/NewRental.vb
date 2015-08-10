Public Class frmNewRental
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnVehicleSearchCRA_Click(sender As Object, e As EventArgs) Handles btnVehicleSearchCRA.Click
        'RentalTableAdapter.Adapter.Update(Me.New_Maverick_Car_RentalDataSet.Rental.Date_RentedColumn)
        'RentalTableAdapter.Adapter.Update(Me.New_Maverick_Car_RentalDataSet.Rental.Date_ReturnedColumn)
        frmNewRentalVehicleList.Show()
        Me.Update()
        Me.Hide()

    End Sub

    Private Sub frmNewRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Rental)
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Price' table. You can move, or remove it, as needed.
        Me.PriceTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Price)
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Vehicle)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePage.Show()
        Me.Close()

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        frmCustomerInfo.Show()
        Me.Close()

    End Sub

    Private Sub VehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiclesToolStripMenuItem.Click
        frmVehicles.Show()
        Me.Close()

    End Sub

    Private Sub dtpPickupDateCRA_ValueChanged(sender As Object, e As EventArgs) Handles dtpPickupDateCRA.ValueChanged

        'RentalTableAdapter.Adapter.Update(Me.New_Maverick_Car_RentalDataSet.Rental.Date_RentedColumn)
    End Sub

    Private Sub dtpReturnDateCRA_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnDateCRA.ValueChanged
        'RentalTableAdapter.Adapter.Update(Me.New_Maverick_Car_RentalDataSet.Rental.Date_ReturnedColumn)

    End Sub
End Class
