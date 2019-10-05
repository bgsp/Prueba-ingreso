Imports MySql.Data.MySqlClient
Imports System.Data
Module BasedeDatos
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password= '';database=panaderia")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
End Module
