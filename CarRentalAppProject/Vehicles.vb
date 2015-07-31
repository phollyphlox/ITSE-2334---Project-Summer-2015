Public Class frmVehicles

    Private Sub UpdateCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomersToolStripMenuItem.Click
        frmCustomerUpdate.Show()
    End Sub

    Private Sub AddNewPriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPriceToolStripMenuItem.Click
        frmPriceOptions.Show()
    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        frmNewRental.Show()
    End Sub
End Class