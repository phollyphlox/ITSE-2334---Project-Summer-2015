Public Class NewPaymentInv

    'Payment and Invoice Section
    Public Property InvoiceId As String
    Public Property EmployeeID As String
    Public Property CreditCardType As String
    Public Property CreditCardNum As String
    Public Property CCSecurityCode As String
    Public Property FinalTotal As String
    Private mCalcTotal As Double

    Public Property CalcTotal As Double
        Get
            Return mCalcTotal
        End Get
        Set(ByVal value As Double)
            mCalcTotal = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return InvoiceId & ", " & EmployeeID & ", " & CreditCardType & ", " & CreditCardNum & ", " & FinalTotal
    End Function
End Class
