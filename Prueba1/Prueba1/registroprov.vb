Imports MySql.Data.MySqlClient
Public Class registroprov
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password= '';database=panaderia")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub introducirproveedores()
        Try
            comando = New MySqlCommand("insert into proveedores (rut,direccion,nombre,telefono)" & Chr(13) &
                                       "values (@rut,@direccion,@nombre,@telefono)", conex)
            comando.Parameters.AddWithValue("@rut", txtRUT.Text)
            comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text)
            comando.Parameters.AddWithValue("@telefono", txtTelefono.Text)
            MsgBox("Proveedor cargado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        Call introducirproveedores()
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