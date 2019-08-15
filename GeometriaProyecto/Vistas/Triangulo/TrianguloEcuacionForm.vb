Public Class TrianguloEcuacionForm
    Public BANDERA As Boolean
    Private formula As New Ecuaciones
    Public a, b, c As Int16
    Public valor As String
    Private Function Validacion() As Boolean
        If BANDERA = True Then
            MsgBox("Para Continuar debe rellenar campos vacios")
        Else
            Return True
        End If
    End Function

    Private Function Vacio(a, b, c) As Boolean
        If a.Length = 0 Then
            Return True
        ElseIf b.Length = 0 Then
            Return True
        ElseIf c.Text.Length = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = T2P1.Text
        b = T2P2.Text
        c = T2P3.Text
        BANDERA = Vacio(a, b, c)
        If Validacion() = True Then
            Resultado1.Text = formula.perimetro(a, b, c)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = T3P1.Text
        b = T3P2.Text
        c = T3P3.Text
        BANDERA = Vacio(a, b, c)
        If Validacion() = True Then
            Resultado1.Text = formula.perimetro(a, b, c)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        a = T4P1.Text
        b = T4P2.Text
        c = T4P3.Text
        BANDERA = Vacio(a, b, c)
        If Validacion() = True Then
            Resultado1.Text = formula.perimetro(a, b, c)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If T1A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T1A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        a = T1A1.Text
        b = T1A2.Text
        If Validacion() = True Then
            Resultado2.Text = formula.areat1(a, b)

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = T1P1.Text
        b = T1P2.Text
        c = T1P3.Text
        BANDERA = Vacio(a, b, c)
        If Validacion() = True Then
            Resultado1.Text = formula.perimetro(a, b, c)
        End If
    End Sub


End Class