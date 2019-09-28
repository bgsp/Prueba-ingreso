Public Class agregarempleado

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If nombreTB.Text = "" And apellidoTB.Text = "" And salarioTB.Text = "" Then
            MsgBox("Los campos con * no pueden estar vacios")
        Else
            MsgBox("Registro exitoso")

        End If
    End Sub

    Private Sub agregarempleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    
End Class