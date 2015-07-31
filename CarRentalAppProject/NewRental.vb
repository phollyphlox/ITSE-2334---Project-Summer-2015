Public Class frmNewRental
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnVehicleSearchCRA_Click(sender As Object, e As EventArgs) Handles btnVehicleSearchCRA.Click
        frmNewRentalVehicleList.Show()
    End Sub
End Class
