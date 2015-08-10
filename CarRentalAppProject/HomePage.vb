Public Class HomePage



    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changed to test github
    End Sub


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        frmNewRental.Show()
    End Sub

    Private Sub UpdateRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRentalToolStripMenuItem.Click
        frmRentalUpdate.Show()

    End Sub

    Private Sub UpdateCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCustomersToolStripMenuItem.Click
        frmCustomerUpdate.Show()
    End Sub

    Private Sub AddNewVehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVehiclesToolStripMenuItem.Click
        frmVehicles.Show()
    End Sub

    Private Sub AddNewPriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPriceToolStripMenuItem.Click
        frmPriceOptions.Show()
    End Sub

    Private Sub AddCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomerToolStripMenuItem.Click

    End Sub
End Class
