Public Class MainForm


    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.CustomerMaintenaceForm.Show()
    End Sub

    Private Sub NewRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewRentalToolStripMenuItem.Click
        'Message box checking customer status <DM>
        Dim response = MsgBox("Is this a new customer?", MsgBoxStyle.YesNoCancel, "Customer Status")
        If response = MsgBoxResult.Yes Then
            'Enter new customer if yes is chosen. <DM>
            My.Forms.NewCustomerForm.Show()
        ElseIf response = MsgBoxResult.No Then
            'Choose existing customer if no is chosen. <DM>
            My.Forms.ExistingCustomerForm.Show()
        Else
            'Do nothing if cancel is chosen. <DM>
        End If
    End Sub

    Private Sub VehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleToolStripMenuItem.Click
        My.Forms.VehicleMaintenaceForm.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        My.Forms.InvoiceMaintenaceForm.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        My.Forms.CategoryMaintenanceForm.Show()
    End Sub
End Class
