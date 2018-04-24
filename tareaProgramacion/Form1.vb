Public Class Form1
    Private Sub vacio(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellido.TextChanged
        Panel1.Enabled = (txtNombre.Text <> "" And txtApellido.Text <> "")
    End Sub
End Class
