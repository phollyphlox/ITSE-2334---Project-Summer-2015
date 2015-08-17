Public Class Vehicle
    Public Shared adapter As New MaverickDatabaseDataSetTableAdapters.VehicleTableAdapter
    Private vehicVin As String
    Private vehicCategory As Category
    Private vehicMake As String
    Private vehicModel As String
    Private vehicColor As String
    Private vehicAvailiable As Boolean
    Private vehicDescription As String

    Sub New()
        vehicVin = String.Empty
        vehicCategory = New Category
        vehicMake = String.Empty
        vehicModel = String.Empty
        vehicColor = String.Empty
        vehicAvailiable = False
        vehicDescription = String.Empty
    End Sub

    Sub New(ByVal vin As String, ByVal category As Category, ByVal make As String, ByVal model As String, ByVal color As String,
            ByVal availiable As Boolean, ByVal description As String)
        vehicVin = vin
        vehicCategory = category
        vehicMake = make
        vehicModel = model
        vehicColor = color
        vehicAvailiable = availiable
        vehicDescription = description
    End Sub
    Public ReadOnly Property vinNum
        Get
            Return vehicVin
        End Get
    End Property
End Class
