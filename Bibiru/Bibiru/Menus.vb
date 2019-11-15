Public Class Menus
    Private Sub Menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click
        Libros.Show()
    End Sub

    Private Sub BtnAlumnos_Click(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        Alumnoso.Show()
    End Sub

    Private Sub BtnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Prestamos.Show()
    End Sub
End Class