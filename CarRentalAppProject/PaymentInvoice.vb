Public Class frmPaymentInvoice

    Private Sub btnFinalizeInvoice_Click(sender As Object, e As EventArgs) Handles btnFinalizeInvoice.Click
        FinalizeInvoice.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class