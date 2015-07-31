Public Class frmNewRentalVehicleList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        frmCustomerInfo.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class