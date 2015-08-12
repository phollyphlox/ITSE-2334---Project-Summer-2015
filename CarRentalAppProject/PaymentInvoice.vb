'
Public Class frmPaymentInvoice
    'Public repPaymentInv As NewPaymentInv

    Dim carRentalCost As Double = 0
    Dim cInsurance As Double = 0
    Dim subTotal As Double = 0
    Dim cTax As Double = 0
    Dim finalTotal As Double = 0

    'Private Property NewPaymentInv As Date



    Private Sub frmPaymentInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet1.Price' table. You can move, or remove it, as needed.
        Me.PriceTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Price)


        'TODO: This line of code loads data into the 'New_Maverick_Car_RentalDataSet.Price' table. You can move, or remove it, as needed.
        Me.PriceTableAdapter.Fill(Me.New_Maverick_Car_RentalDataSet.Price)

        cmbCCtype.Items.Add("American Express")
        cmbCCtype.Items.Add("Dinners Club")
        cmbCCtype.Items.Add("Discover")
        cmbCCtype.Items.Add("MasterCard")
        cmbCCtype.Items.Add("Visa")

        cmbExpMM.Items.Add("01")
        cmbExpMM.Items.Add("02")
        cmbExpMM.Items.Add("03")
        cmbExpMM.Items.Add("04")
        cmbExpMM.Items.Add("05")
        cmbExpMM.Items.Add("06")
        cmbExpMM.Items.Add("07")
        cmbExpMM.Items.Add("08")
        cmbExpMM.Items.Add("09")
        cmbExpMM.Items.Add("10")
        cmbExpMM.Items.Add("11")
        cmbExpMM.Items.Add("12")

        cmbExpYY.Items.Add("2015")
        cmbExpYY.Items.Add("2016")
        cmbExpYY.Items.Add("2017")
        cmbExpYY.Items.Add("2018")
        cmbExpYY.Items.Add("2019")
        cmbExpYY.Items.Add("2020")
        cmbExpYY.Items.Add("2021")

        '' Generate a random invoice ID

        ''run a query to get the max value of the Invoice ID, Use this valuse as the starting value in the random generator
        'Dim RanInv As Integer = 0
        'Dim randGen As New Random
        'RanInv = randGen.Next(1, 10000)
        'txtInvoiceID.Text = Convert.ToString(RanInv)
        ''Get Car Rental Cost
    End Sub

    Private Sub btnFinalizeInvoice_Click(sender As Object, e As EventArgs) Handles btnFinalizeInvoice.Click

        Try
            Dim newRentalRow As new_Maverick_Car_RentalDataSet.RentalRow
            newRentalRow = Me.New_Maverick_Car_RentalDataSet.Rental.NewRentalRow()
            'newRentalRow.VIN = NewPaymentInv.cVIN
            'newRentalRow.Key = NewPaymentInv.cKey
            'newRentalRow.Category = "Eco"
            newRentalRow.Category = NewPaymentInv.shareCategory
            newRentalRow.Payment_Method = Convert.ToString(cmbCCtype.SelectedItem)
            newRentalRow.Date_Rented = NewPaymentInv.shareRentalDate
            newRentalRow.Date_Returned = NewPaymentInv.shareReturnDate
            'MessageBox.Show(newRentalRow.Date_Rented & "    " & newRentalRow.Date_Returned & "    " & newRentalRow.Category)
            newRentalRow.Total = CDbl(txtFinalTotal.Text)



            Me.New_Maverick_Car_RentalDataSet.Rental.Rows.Add(newRentalRow)
            Me.RentalTableAdapter1.Update(Me.New_Maverick_Car_RentalDataSet.Rental)
            'Me.RentalTableAdapter1.Update(Me.New_Maverick_Car_RentalDataSet.Rental)


            'RentalBindingSource.AddNew()
            'RentalTableAdapter1.Insert("12345", 121213459, Convert.ToString(cmbCategoryPrice.SelectedItem), Convert.ToString(cmbCCtype.SelectedItem), CDate("08/10/2015"), CDate("08/22/2015"), True, CDec(txtFinalTotal.Text))

            'Me.RentalTableAdapter1.Fill(Me.New_Maverick_Car_RentalDataSet.Rental)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Write Error")
        End Try
        Me.Hide()
        FinalizeInvoice.Show()



    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmNewRental.Show()
    End Sub


    Private Sub rbnWaiver_CheckedChanged(sender As Object, e As EventArgs) Handles rbnWaiver.CheckedChanged
        'Calcualte Final Total

        Double.TryParse(lblPrice.Text, carRentalCost)

        txtInsuranceFee.Text = "0"
        Double.TryParse(txtInsuranceFee.Text, cInsurance)

        subTotal = carRentalCost + cInsurance
        txtSubtotal.Text = Convert.ToString(subTotal)

        cTax = subTotal * 0.0825
        txtTax.Text = Convert.ToString(cTax)

        finalTotal = subTotal + cTax
        txtFinalTotal.Text = Convert.ToString(finalTotal)
    End Sub

    Private Sub rbnPersonal_CheckedChanged(sender As Object, e As EventArgs) Handles rbnPersonal.CheckedChanged
        'Calcualte Final Total

        Double.TryParse(lblPrice.Text, carRentalCost)

        txtInsuranceFee.Text = "0"
        Double.TryParse(txtInsuranceFee.Text, cInsurance)

        subTotal = carRentalCost + cInsurance
        txtSubtotal.Text = Convert.ToString(subTotal)

        cTax = subTotal * 0.0825
        txtTax.Text = Convert.ToString(cTax)

        finalTotal = subTotal + cTax
        txtFinalTotal.Text = Convert.ToString(finalTotal)
    End Sub

    Private Sub rbnPurchase_CheckedChanged(sender As Object, e As EventArgs) Handles rbnPurchase.CheckedChanged
        'Calcualte Final Total

        Double.TryParse(lblPrice.Text, carRentalCost)

        txtInsuranceFee.Text = "35"
        Double.TryParse(txtInsuranceFee.Text, cInsurance)

        subTotal = carRentalCost + cInsurance
        txtSubtotal.Text = Convert.ToString(subTotal)

        cTax = subTotal * 0.0825
        txtTax.Text = Convert.ToString(cTax)

        finalTotal = subTotal + cTax
        txtFinalTotal.Text = Convert.ToString(finalTotal)
    End Sub

    Private Sub cmbCategoryPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoryPrice.SelectedIndexChanged
        rbnPersonal.Checked = False
        rbnPurchase.Checked = False
        rbnWaiver.Checked = False

        txtInsuranceFee.Text = "0"
        txtTax.Text = "0"
        txtSubtotal.Text = "0"
        txtFinalTotal.Text = "0"
    End Sub


End Class