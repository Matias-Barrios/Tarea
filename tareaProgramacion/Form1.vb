Public Class Form1
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Panel1.Enabled = (txtNombre.Text <> "" And txtApellido.Text <> "")
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        Panel1.Enabled = (txtNombre.Text <> "" And txtApellido.Text <> "")
    End Sub
End Class
