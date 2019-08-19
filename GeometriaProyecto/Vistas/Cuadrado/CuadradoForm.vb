Public Class Cuadrado
    Public BANDERA As Boolean
    Private formula As New Ecuaciones
    Public a, b, c, d, Re As Int16
    'Boton de area de rectangulo
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NumeroCero()
        If P2A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P2A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P2A1.Text
            b = P2A2.Text
            P2.Text = (a * b)
        End If
    End Sub
    'Boton del perimetro de un rectangulo'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NumeroCero()
        If P2P1.Text.Length = 0 Then
            BANDERA = True
        End If
        If Validacion() = True Then
            a = P2P1.Text
            A2.Text = (a * 4)
        End If
    End Sub
    'Boton de perimetro de un cuadrado'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumeroCero()
        If P1P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P1P2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P1P1.Text
            b = P1P2.Text
            A1.Text = (a * b)
        End If

    End Sub

    'Boton del area del cuadrado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NumeroCero()
        If P1A1.Text.Length = 0 Then
            BANDERA = True
        End If
        If Validacion() = True Then
            a = P1A1.Text
            P1.Text = (a ^ 2)
        End If
    End Sub
    'Validacion de si tiene o no tiene un digito'
    Private Function Validacion() As Boolean
        If BANDERA = True Then
            MsgBox("Para Continuar debe rellenar campos vacios")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub NumeroCero()
        a = 0
        b = 0
        c = 0
        d = 0
    End Sub
End Class