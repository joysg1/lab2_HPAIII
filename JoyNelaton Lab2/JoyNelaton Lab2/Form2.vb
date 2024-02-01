Public Class Form2
    Dim nombre, cedula, msj, depart As String
    Dim aniosServicio As Integer
    Dim salarioBase, pAumentoAnt, pAumentoEst, aumentoAnt, aumentoEst, salarioTotal As Double

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Dim auto As Boolean


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mensaje()
        Aumentos()
        AutoGanador()

    End Sub



    Sub Aumentos()

        aniosServicio = Val(Form1.tbYears.Text)

        Select Case aniosServicio



            Case 0 To 4
                pAumentoAnt = 0.02
                auto = False

            Case 5 To 10
                pAumentoAnt = 0.06
                auto = False

            Case 11 To 20
                pAumentoAnt = 0.08
                auto = False

            Case Else
                pAumentoAnt = 0.12
                auto = True


        End Select

        If (Form1.rbMaster.Checked = True) Then
            pAumentoEst = 0.02

        Else
            pAumentoEst = 0.0
        End If


        salarioBase = Val(Form1.tbSalario.Text)

        lbSalarioBase.Text = salarioBase

        aumentoAnt = pAumentoAnt * salarioBase

        lbAumentoYears.Text = aumentoAnt

        aumentoEst = pAumentoEst * salarioBase

        lbAumentoStudy.Text = aumentoEst

        salarioTotal = salarioBase + aumentoAnt + aumentoEst

        lbSalarioTotal.Text = salarioTotal


    End Sub



    Sub Mensaje()

        nombre = Form1.tbNombre.Text
        cedula = Form1.tbCedula.Text
        aniosServicio = Val(Form1.tbYears.Text)
        depart = Form1.cbDepart.SelectedItem

        msj = nombre + " con cedula " + cedula + " del departamento de " + depart + " ha laborado " + Str(aniosServicio) + " años "

        lbMensaje.Text = msj
    End Sub


    Sub AutoGanador()

        If (auto = True) Then
            lbMensajeAuto.Text = "Felicitaciones el coolaborador es acreedor de un auto"
        Else
            lbMensajeAuto.Visible = False

        End If


    End Sub




End Class