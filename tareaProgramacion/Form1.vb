Public Class Form1
    Private Sub vacio(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtEdad.TextChanged
        grpboxGenero.Enabled = (txtNombre.Text <> "" AndAlso txtEdad.Text <> "")
    End Sub
    Private Sub Mostrar_Mensaje(sender As Object, e As EventArgs) Handles rdoMasculino.Click, rdoFemenino.Click, rdoOtros.Click
        MsgBox("Su nombre es " & txtNombre.Text & " y usted tiene " & txtEdad.Text & " años. Ha seleccionado el genero : " & sender.Text)
    End Sub
End Class
