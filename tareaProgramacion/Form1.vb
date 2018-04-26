Public Class Form1
    Private Sub vacio(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtEdad.TextChanged
        grpboxGenero.Enabled = (txtNombre.Text.Trim <> "" AndAlso txtEdad.Text.Trim <> "")
    End Sub
    Private Sub Mostrar_Mensaje(sender As Object, e As EventArgs) Handles rdoMasculino.Click, rdoFemenino.Click, rdoOtros.Click
        MsgBox("Su nombre es " & txtNombre.Text & " y usted tiene " & txtEdad.Text & " años. Ha seleccionado el genero : " & sender.Text)
    End Sub
    Private Sub sub_solo_numeros(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEdad.KeyPress
        If Not e.KeyChar.ToString Like "[0-9]" And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub sub_solo_letras(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not e.KeyChar.ToString Like "[a-zA-Z ]" And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class
