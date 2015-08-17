Public Class VehicleMaintenaceForm

    Private Sub VehicleMaintenaceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaverickDatabaseDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.MaverickDatabaseDataSet.Vehicle)

    End Sub

    Private Sub FillByVehicleTableToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.VehicleTableAdapter.FillByVehicleTable(Me.MaverickDatabaseDataSet.Vehicle)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SaveChangesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveChangesToolStripMenuItem.Click
        Try
            Me.Validate()
            Me.VehicleBindingSource.EndEdit()
            Customer.adapter.Update(MaverickDatabaseDataSet)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try
    End Sub
End Class