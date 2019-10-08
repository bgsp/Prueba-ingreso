Imports MySql.Data.MySqlClient
Public Class registroprod
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password= '';database=panaderia")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Private Sub introducirproductos()
        Try
            comando = New MySqlCommand("insert into productos (nombre,precio,stock)" & Chr(13) &
                              "values (@nombre,@precio,@stock)", conex)
            comando.Parameters.AddWithValue("@nombre", txtNomprod.Text)
            comando.Parameters.AddWithValue("@precio", txtProdPrice.Text)
            comando.Parameters.AddWithValue("@stock", txtProdU.Text)
            comando.ExecuteNonQuery()
            MsgBox("Producto cargado correctamente", MsgBoxStyle.Information, vbOKOnly)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtNomprod.Text = "" Or txtProdPrice.Text = "" Or txtProdU.Text = "" Then
            MsgBox("Debe ingresar todos los datos del proveedor.", MsgBoxStyle.Exclamation)
        ElseIf txtProdU.Text > 999 Then
            MsgBox("Las existencias no pueden superar las 999 unidades")


        End If
        Call introducirproductos()

    End Sub


    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtCodprod.Text = ""
        txtNomprod.Text = ""
        txtProdPrice.Text = ""
        txtProdU.Text = ""
    End Sub

    Private Sub txtProdPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdPrice.TextChanged

    End Sub

    Private Sub txtProdPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdPrice.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNomprod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomprod.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub registroprod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conex.Open()

    End Sub

    Private Sub dgvProductos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRegProductos.CellContentClick

    End Sub

    
    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class