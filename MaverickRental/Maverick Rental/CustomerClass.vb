Public Class Customer
    Public Shared adapter As New MaverickDatabaseDataSetTableAdapters.CustomerTableAdapter
    Public Shared mavData As New MaverickDatabaseDataSet
    Private custNum As Integer
    Private custOrg As String
    Private custFName As String
    Private custMidInit As String
    Private custLName As String
    Private custDLNum As String
    Private custStreet As String
    Private custCity As String
    Private custState As String
    Private custZip As String
    Private custPhoneNum As String
    Private custAge As String
    Sub New()
        custNum = adapter.GetData.Count + 1
        custOrg = String.Empty
        custFName = String.Empty
        custMidInit = String.Empty
        custLName = String.Empty
        custDLNum = String.Empty
        custStreet = String.Empty
        custCity = String.Empty
        custState = String.Empty
        custZip = String.Empty
        custPhoneNum = String.Empty
    End Sub
    Sub New(ByVal num As Integer, ByVal fname As String, ByVal midInit As String, ByVal lname As String, ByVal dlNum As String,
            ByVal street As String, ByVal city As String, ByVal state As String, ByVal zip As String,
            ByVal phoneNum As String, Optional ByVal org As String = "-None-")
        If num = -1 Then
            custNum = adapter.GetData.Count + 1
        Else
            custNum = num
        End If

        If org <> "-None-" Then
            custOrg = org
        End If
        custFName = fname
        custMidInit = midInit
        custLName = lname
        custDLNum = dlNum
        custStreet = street
        custCity = city
        custState = state
        custZip = zip
        custPhoneNum = phoneNum

    End Sub
    ReadOnly Property customerNumber
        Get
            Return custNum
        End Get
    End Property
    Public Shared Sub addCustomerToDatabase(cust As Customer)
        adapter.Insert(cust.custOrg, cust.custFName, cust.custMidInit, cust.custLName, cust.custDLNum, cust.custStreet, cust.custCity,
                       cust.custState, cust.custZip, cust.custPhoneNum)
    End Sub

End Class
