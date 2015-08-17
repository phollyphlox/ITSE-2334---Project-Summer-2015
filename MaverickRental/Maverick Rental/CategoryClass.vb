Public Class Category
    Public Shared categoryList() As String = {"Eco", "Fs", "Lux", "Ms"}
    Private category As String
    Private price As Double
    Sub New()
        category = String.Empty
        price = 0.0
    End Sub
    Sub New(type As String)
        If type = "Eco" Then
            category = "Eco"
            price = 10.95
        ElseIf type = "Fs"
            category = "Fs"
            price = 30.95
        ElseIf type = "Lux"
            category = "Lux"
            price = 40.95
        ElseIf type = "Ms"
            category = "Ms"
            price = 20.95
        Else
            MessageBox.Show("This type is not valid.")
        End If
    End Sub
    ReadOnly Property thisPrice
        Get
            Return price
        End Get
    End Property
End Class
