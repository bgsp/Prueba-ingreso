Public Class ingreso

    Private Sub ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim usuario As String = loguserTB.Text
        Dim password As String = logpassTB.Text

    End Sub

    

    Private Sub verpassCB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verpassCB.CheckedChanged
        If verpassCB.Checked = True Then
            logpassTB.PasswordChar = ""
        Else
            logpassTB.PasswordChar = "*"
        End If
    End Sub
    Private Sub logTB_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size = New Size(130, 45)
    End Sub
    Private Sub logTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


        If loguserTB.Text = "admin" And logpassTB.Text = "admin" Then
            MsgBox("Usuario logeado correctamente", MsgBoxStyle.OkOnly, "Usuario logeado")
            principal.Show()
        Else : MsgBox("Usuario incorrecto", MsgBoxStyle.Exclamation, "Error usuario")
        End If
        loguserTB.Text = ""
        logpassTB.Text = ""
    End Sub

    Private Sub regTB_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Size = New Size(130, 45)

    End Sub
    Private Sub regTB_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(119, 38)

    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(119, 38)

    End Sub
End Class
