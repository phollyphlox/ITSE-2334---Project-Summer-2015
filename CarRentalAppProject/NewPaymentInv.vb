Public Class NewPaymentInv

    'Payment and Invoice Section
    Public Shared Property mCategory As String
    Public Shared Property mRentalDate As Date
    Public Shared Property mReturnDate As Date
    Public Shared Property shareCategory As String
        Get
            Return mCategory
        End Get
        Set(ByVal value As String)
            mCategory = value
        End Set
    End Property
    Public Shared Property shareRentalDate As Date
        Get
            Return mRentalDate
        End Get
        Set(ByVal value As Date)
            mRentalDate = value
        End Set
    End Property
    Public Shared Property shareReturnDate As Date
        Get
            Return mReturnDate
        End Get
        Set(ByVal value As Date)
            mReturnDate = value
        End Set
    End Property

    'Vehicle Section
    Public Shared Property mKey As Integer
    Public Shared Property mVIN As String
    Public Shared Property cKey As Integer
        Get
            Return mKey
        End Get
        Set(ByVal value As Integer)
            mKey = value
        End Set
    End Property
    Public Shared Property cVIN As String
        Get
            Return mVIN
        End Get
        Set(ByVal value As String)
            mVIN = value
        End Set
    End Property

End Class
