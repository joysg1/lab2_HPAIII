Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Verificar_Entrada()
        Form2.Show()

    End Sub


    Sub Verificar_Entrada()
        If (tbNombre.Text = "" Or tbCedula.Text = "" Or tbSalario.Text = "" Or tbYears.Text = "" Or cbDepart.Text = "Departamento" Or Val(tbSalario.Text) <= 0 Or Val(tbYears.Text) < 0) Then
            MsgBox("Favor verique los datos")
        End If
    End Sub



End Class


