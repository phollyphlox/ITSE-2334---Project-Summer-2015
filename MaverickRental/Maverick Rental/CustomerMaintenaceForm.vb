Public Class CustomerMaintenaceForm

    Private Sub CustomerMaintenaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaverickDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.MaverickDatabaseDataSet.Customer)

    End Sub

    Private Sub SaveChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveChangesToolStripMenuItem.Click
        Try
            Me.Validate()
            Me.CustomerBindingSource.EndEdit()
            Customer.adapter.Update(MaverickDatabaseDataSet)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class