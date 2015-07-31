Public Class frmPriceOptions

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddNewVehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVehiclesToolStripMenuItem.Click
        frmVehicles.Show()
    End Sub

    Private Sub UpdateCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomersToolStripMenuItem.Click
        frmCustomerUpdate.Show()
    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        frmNewRental.Show()
    End Sub

    Private Sub UpdateRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRentalToolStripMenuItem.Click
        frmRentalUpdate.Show()
    End Sub

    Private Sub CancelRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelRentalToolStripMenuItem.Click
        frmRentalCancel.Show()
    End Sub
End Class