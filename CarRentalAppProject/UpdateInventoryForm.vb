Public Class UpdateInventoryForm

    Private Sub UpdateInventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Vehicle)

    End Sub
End Class