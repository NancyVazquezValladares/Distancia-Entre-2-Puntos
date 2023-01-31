Public Class FrmPractica1

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        tbX1.Text = ""
        tbX2.Text = ""
        tbY1.Text = ""
        tbY2.Text = ""
        tbDistamcia.Text = ""

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim clase As Formula = New Formula()
        tbDistamcia.Text = clase.Formula(tbX2.Text, tbX1.Text, tbY2.Text, tbY1.Text)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class
