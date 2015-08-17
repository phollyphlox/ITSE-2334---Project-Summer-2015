Public Class SelectVehicleForm
    Dim myVehicle As New Vehicle
    Dim table As DataTable = Vehicle.adapter.GetData()
    Dim myCategory As New Category
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        If SharedAssets.newCustomer Then
            My.Forms.NewCustomerForm.Show()
            Me.Close()
        Else
            My.Forms.ExistingCustomerForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim myBool
        If txtAvailable.Text = "Yes" Then
            myBool = True
        Else
            myBool = False
        End If
        myCategory = New Category(comboCategory.SelectedItem.ToString)
        myVehicle = New Vehicle(txtVin.Text, myCategory, txtMake.Text, txtModel.Text, txtColor.Text, myBool, rtxtDescription.Text)
        SharedAssets.currentCategory = myCategory
        SharedAssets.currentVehicle = myVehicle
        My.Forms.InvoiceForm.Show()
        Me.Close()
    End Sub

    Private Sub SelectVehicleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboCategory.Items.AddRange(Category.categoryList)
        'TODO: This line of code loads data into the 'MaverickDatabaseDataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.MaverickDatabaseDataSet.Vehicle)
        For i As Integer = 0 To table.Rows.Count - 1
            listVehicleAvailable.Items.Add(table.Rows(i)("VIN"))
        Next
    End Sub

    Private Sub listVehicleAvailable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listVehicleAvailable.SelectedIndexChanged
        Dim index As Integer = listVehicleAvailable.SelectedIndex
        fillingControls(index)
    End Sub

    Private Sub fillingControls(index As Integer)
        txtVin.Text = table.Rows(index)("VIN")
        txtMake.Text = table.Rows(index)("Make")
        txtModel.Text = table.Rows(index)("Model")
        txtColor.Text = table.Rows(index)("Color")
        rtxtDescription.Text = table.Rows(index)("Description")
        comboCategory.SelectedItem = table.Rows(index)("Category")
        If table.Rows(index)("Available") = True Then
            txtAvailable.Text = "Yes"
        Else
            txtAvailable.Text = "No"
        End If
    End Sub
End Class