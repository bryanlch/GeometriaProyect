Public Class TrianguloEcuacionForm
    Public BANDERA As Boolean
    Private Function Validacion() As Boolean
        If BANDERA = True Then
            MsgBox("Para Continuar debe rellenar campos vacios")
        Else
            Return True
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If T1P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T1P2.Text.Length = 0 Then
            BANDERA = True
        ElseIf T1P3.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            MsgBox("funciona")
        End If


    End Sub


End Class