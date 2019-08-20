Public Class SolidosForm
    Public BANDERA As Boolean
    Private formula As New Ecuaciones
    Public a, b, c, d, R1, R2, R3 As Int16

    'Validacion de si tiene o no tiene un digito'
    Private Function Validacion() As Boolean
        If BANDERA = True Then
            MsgBox("Para Continuar debe rellenar campos vacios")
        Else
            Return True
        End If
        Return False
    End Function
    'reinicio de los numero '
    Private Sub NumeroCero()
        a = 0
        b = 0
        c = 0
        d = 0
        R1 = 0
        R2 = 0
        R3 = 0
    End Sub
    'Bototon de area del paralepipedo
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        NumeroCero()
        If A4P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf A4P2.Text.Length = 0 Then
            BANDERA = True
        ElseIf A4P3.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            'tomando el numero y asignadoselos a las diferentes label correspondiente
            a = A4P1.Text
            letraA1.Text = a
            letraA2.Text = a
            b = A4P2.Text
            letraB1.Text = b
            letraB2.Text = b
            c = A4P3.Text
            LetraC1.Text = c
            letraC2.Text = c
            R1 = (a * b)
            R2 = (a * c)
            R3 = (b * c)
            R1 = (R1 + R2 + R3)
            AR4.Text = (2 * (R1))
        End If
    End Sub
End Class