Public Class registroprod

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtCodprod.Text = "" Or txtNomprod.Text = "" Or txtProdPrice.Text = "" Or txtProdU.Text = "" Then
            MsgBox("Debe ingresar todos los datos del proveedor.")
        ElseIf txtProdU.Text > 999 Then
            MsgBox("Las existencias no pueden superar las 999 unidades")
        Else
            Dim cantfilas As Integer
            cantfilas = dgvProductos.Rows.Count - 1
            dgvProductos.Rows.Add()
            dgvProductos(0, cantfilas).Value = txtCodprod.Text
            dgvProductos(1, cantfilas).Value = txtNomprod.Text
            dgvProductos(2, cantfilas).Value = txtProdPrice.Text
            dgvProductos(3, cantfilas).Value = txtProdU.Text
        End If

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
End Class