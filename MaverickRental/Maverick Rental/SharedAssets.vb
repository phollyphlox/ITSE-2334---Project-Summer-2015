Public Class SharedAssets
    Public Shared newCustomer As Boolean 'This lets the program know if we are renting to a new customer and chooses forms.
    Public Shared currentCustomer As Customer
    Public Shared currentVehicle As Vehicle
    Public Shared currentCategory As Category
    Public Shared currentInvoice As Invoice

    Public Shared Sub addNames(ByRef formObject, ByRef table)
        For i As Integer = 0 To table.Rows.Count - 1
            formObject.Items.Add(table.Rows(i)("Last Name") & ", " & table.Rows(i)("First Name"))
        Next
    End Sub
    Public Shared state() As String = {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA",
                                       "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
                                       "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX",
                                       "UT", "VT", "VA", "WA", "WV", "WI", "WY"}
End Class
