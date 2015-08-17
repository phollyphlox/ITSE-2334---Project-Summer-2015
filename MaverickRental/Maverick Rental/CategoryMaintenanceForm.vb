Public Class CategoryMaintenanceForm

    Private Sub CategoryMaintenanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaverickDatabaseDataSet.Price' table. You can move, or remove it, as needed.
        Me.PriceTableAdapter.Fill(Me.MaverickDatabaseDataSet.Price)

    End Sub

    Private Sub SaveChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveChangesToolStripMenuItem.Click
        Try
            Me.Validate()
            Me.PriceBindingSource.EndEdit()
            Customer.adapter.Update(MaverickDatabaseDataSet)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class