Public Class Form1
    Private Sub vacio(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellido.TextChanged
        grpboxGenero.Enabled = (txtNombre.Text <> "" AndAlso txtApellido.Text <> "")
    End Sub
    Private Sub rdoMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMasculino.CheckedChanged, rdoFemenino.CheckedChanged, rdoOtros.CheckedChanged
        MsgBox("Su nombre es " & txtNombre.Text & " " & txtApellido.Text & " y ha seleccionado el genero : " & sender.Text)
    End Sub
End Class
