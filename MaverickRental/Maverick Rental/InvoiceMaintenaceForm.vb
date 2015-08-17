Public Class InvoiceMaintenaceForm

    Private Sub InvoiceMaintenaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaverickDatabaseDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.MaverickDatabaseDataSet.Rental)

    End Sub

    Private Sub SaveChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveChangesToolStripMenuItem.Click
        Try
            Me.Validate()
            Me.RentalBindingSource.EndEdit()
            Customer.adapter.Update(MaverickDatabaseDataSet)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class