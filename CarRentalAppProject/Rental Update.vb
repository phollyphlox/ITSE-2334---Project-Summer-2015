Public Class frmRentalUpdate

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FinalizeInvoice.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CancelRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelRentalToolStripMenuItem.Click
        frmRentalCancel.Show()
    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        frmNewRental.Show()
    End Sub

    Private Sub AddNewVehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVehiclesToolStripMenuItem.Click
        frmVehicles.Show()
    End Sub

    Private Sub UpdateCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomersToolStripMenuItem.Click
        frmCustomerUpdate.Show()
    End Sub

    Private Sub PriceOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriceOptionsToolStripMenuItem.Click
        '   frmPriceOptions.Show()
    End Sub

    Private Sub frmRentalUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class