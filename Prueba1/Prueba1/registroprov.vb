Public Class registroprov

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub dgvAlumnos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If txtRUT.Text = "" Or txtDireccion.Text = "" Or txtNombre.Text = "" Or txtTelefono.Text = "" Then
            MsgBox("Debe ingresar todos los datos del proveedor.")
        Else
            Dim cantfilas As Integer
            cantfilas = dgvProveedores.Rows.Count - 1
            dgvProveedores.Rows.Add()
            dgvProveedores(0, cantfilas).Value = txtRUT.Text
            dgvProveedores(1, cantfilas).Value = txtDireccion.Text
            dgvProveedores(2, cantfilas).Value = txtNombre.Text
            dgvProveedores(3, cantfilas).Value = txtTelefono.Text
        End If

    End Sub


    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        txtRUT.Text = ""
        txtDireccion.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class