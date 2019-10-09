Imports MySql.Data.MySqlClient
Imports System.Data
Public Class principal
    Dim conex As New MySqlConnection("data source=localhost;user id=root; password= '';database=panaderia")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Private Sub catalogoPB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catalogoPB.Click
        gbproductos.Visible = True
        gbListaprod.Visible = True
        gbProv.Visible = False

    End Sub
    Private Sub catalogoPB_hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catalogoPB.MouseHover
        catalogoPB.Size = New Size(120, 100)
    End Sub
    Private Sub catalogoPB_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catalogoPB.MouseLeave
        catalogoPB.Size = New Size(110, 90)
    End Sub

    Private Sub empleadosPB_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleadosPB.MouseHover, Label2.MouseHover
        empleadosPB.Size = New Size(120, 93)

    End Sub

    Private Sub empleadosPB_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleadosPB.MouseLeave, Label2.MouseLeave
        empleadosPB.Size = New Size(110, 83)

    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedorPB.MouseLeave
        proveedorPB.Size = New Size(111, 101)
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedorPB.MouseHover
        proveedorPB.Size = New Size(121, 111)
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registroPB.MouseLeave
        registroPB.Size = New Size(110, 88)
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registroPB.MouseHover
        registroPB.Size = New Size(120, 98)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirPB.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirPB.MouseLeave
        salirPB.Size = New Size(129, 38)
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirPB.MouseHover
        salirPB.Size = New Size(139, 48)
    End Sub


    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        agregarempleado.Show()
    End Sub



    Private Sub AgregarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        registroprov.Show()
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        registroprod.Show()
    End Sub

    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbproductos.Visible = False
        gbListaprod.Visible = False
        gbProv.Visible = False
    End Sub
    Private Sub mostrarprovedores(ByVal dgvProv As DataGridView)
        Try
            sql = "select * from proveedores"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgvProv.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarlosproductos(ByVal dgvProd As DataGridView)
        Try
            sql = "select * from productos"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            dgvProd.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub actualizar_dgvProd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call mostrarlosproductos(dgvProd)
    End Sub

    Private Sub proveedorPB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedorPB.Click
        gbproductos.Visible = False
        gbListaprod.Visible = False
        gbProv.Visible = True

    End Sub

    Private Sub actualizar_dgProv(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Call mostrarprovedores(dgvProv)
    End Sub

    Private Sub EliminarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarProductoToolStripMenuItem.Click

    End Sub
End Class
