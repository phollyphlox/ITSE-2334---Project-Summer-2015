Public Class Invoice

    Public Shared adapter As New MaverickDatabaseDataSetTableAdapters.RentalTableAdapter
    Private invNumber As Integer
    Private invPaymentMethod As String
    Private invDateRented As Date
    Private invDateReturned As Date
    Private invPaid As Boolean
    Private invTotal As Double

    Sub New()
        invNumber = adapter.GetData.Count + 1
        invPaymentMethod = String.Empty
        invDateReturned = Date.Today
        invDateRented = Date.Today
        invPaid = False
        invTotal = 0.0
    End Sub

    Sub New(ByVal payMethod As String, ByVal rent As Date, ByVal rentReturn As Date, ByVal paid As Boolean, ByVal total As Double)
        invNumber = adapter.GetData.Count + 1
        invPaymentMethod = payMethod
        invDateReturned = rentReturn
        invDateRented = rent
        invPaid = paid
        invTotal = total
    End Sub
    Public ReadOnly Property invNum
        Get
            Return invNumber
        End Get
    End Property
    Public Shared Sub addInvoiceToDatabase(inv As Invoice, vehic As Vehicle, cust As Customer)
        adapter.Insert(vehic.vinNum, cust.customerNumber, inv.invPaymentMethod, inv.invDateRented, inv.invDateReturned, inv.invPaid, inv.invTotal)
    End Sub
End Class
