Public Class principal

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catalogoPB.Click

    End Sub
    Private Sub PictureBox1_hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catalogoPB.MouseHover
        catalogoPB.Size = New Size(145, 76)
    End Sub
    Private Sub picturebox1_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles catalogoPB.MouseLeave
        catalogoPB.Size = New Size(138, 69)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleadosPB.Click

    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleadosPB.MouseHover, Label2.MouseHover
        empleadosPB.Size = New Size(120, 95)

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empleadosPB.MouseLeave, Label2.MouseLeave
        empleadosPB.Size = New Size(113, 88)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedorPB.Click

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registroPB.Click

    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedorPB.MouseLeave
        proveedorPB.Size = New Size(113, 92)
    End Sub

    Private Sub PictureBox3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proveedorPB.MouseHover
        proveedorPB.Size = New Size(120, 100)
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registroPB.MouseLeave
        registroPB.Size = New Size(100, 83)
    End Sub

    Private Sub PictureBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registroPB.MouseHover
        registroPB.Size = New Size(107, 90)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirPB.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirPB.MouseLeave
        salirPB.Size = New Size(115, 38)
    End Sub

    Private Sub PictureBox5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salirPB.MouseHover
        salirPB.Size = New Size(122, 45)
    End Sub


    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        agregarempleado.Show()
    End Sub



    Private Sub AgregarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem1.Click
        registroprov.Show()
    End Sub
End Class
