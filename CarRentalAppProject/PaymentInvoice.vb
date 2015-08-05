Public Class frmPaymentInvoice
    Private objPaymentInv As New NewPaymentInv
    Private Sub frmPaymentInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ' Generate a random invoice ID
        'run a query to get the max value of the Invoice ID, Use this valuse as the starting value in the random generator
        'Dim RanInv As Integer = 0
        'Dim randGen As New Random
        'RanInv = randGen.Next(1, 10000)
        'txtInvoiceID.Text = ToString(RanInv)
    End Sub

    Private Sub btnFinalizeInvoice_Click(sender As Object, e As EventArgs) Handles btnFinalizeInvoice.Click
        objPaymentInv.InvoiceId = txtInvoiceID.Text
        objPaymentInv.EmployeeID = txtEmployeeID.Text
        objPaymentInv.CreditCardType = cmbCCtype.SelectedItem
        objPaymentInv.CreditCardNum = txtCCNumber.Text
        objPaymentInv.FinalTotal = txtFinalTotal.Text
        ' FinalizeInvoice.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub




    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lblView.Text = objPaymentInv.ToString()
    End Sub
End Class