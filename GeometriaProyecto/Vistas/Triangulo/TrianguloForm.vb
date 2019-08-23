Public Class TrianguloForm
    Public BANDERA As Boolean
    Private formula As New Ecuaciones
    Public a, b, c, d, Re As Decimal
    Public raiz As Decimal

    'Validacion 
    Private Function Validacion() As Boolean
        If BANDERA = True Then
            MsgBox("Para Continuar debe rellenar campos vacios")
            Return False
        Else
            Return True
        End If
        Return False
    End Function
    'Numero en cero
    Private Sub NumeroCero()
        a = 0
        b = 0
        c = 0
        d = 0
    End Sub

    'Boton de triangulo 2 perimetro
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        If T2P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T2P2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = T2P1.Text
            b = T2P2.Text
            LabelT2P.Text = ((2 * a) + b)
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        If T2A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T2A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = T2A1.Text
            b = T2A2.Text
            Label44.Text = b
            raiz = ((a ^ 2) - ((b ^ 2) / 4))
            raiz = Math.Sqrt(raiz)
            c = ((b * raiz) / 2)
            LabelT2A.Text = (raiz)
        End If
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////////

    'Botones Triangulo 3
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        If T3P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T3P2.Text.Length = 0 Then
            BANDERA = True
        ElseIf T3P3.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then

            a = T3P1.Text
            b = T3P2.Text
            c = T3P3.Text

            LabelT3P.Text = formula.perimetro(a, b, c)
            T3A1.Text = ((formula.perimetro(a, b, c)) / 2)
            T3A2.Text = a
            T3A3.Text = b
            T3A4.Text = c

        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        BANDERA = True
        If T3A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T3A2.Text.Length = 0 Then
            BANDERA = True
        ElseIf T3A3.Text.Length = 0 Then
            BANDERA = True
        ElseIf T3A4.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If


        If Validacion() = True Then
            'asignado el valor a las variables
            a = T3A1.Text
            b = T3A2.Text
            c = T3A3.Text
            d = T3A4.Text
            Re = ((a) - (c)) * ((a) - (b)) * ((a) - (d))
            Re = (a * Re)
            raiz = Math.Sqrt(Re)
            RespuestaT3A.Text = ((raiz * c) / 2)
        End If


    End Sub

    '////////////////////////////////////////////////////////////////////////////

    'Triangulo 4
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        If T4P1.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = T4P1.Text
            LabelT4P.Text = (a * 3)
        End If
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        If T4A1.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = T4A1.Text
            raiz = Math.Sqrt(3)
            b = raiz / 4
            c = (b * (a ^ 2))
            LabelT4A.Text = (c)
        End If

    End Sub
    '/////////////////////////////////////////////////////

    'TRIANGULO 1    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
        If T1A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf T1A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = T1A1.Text
            b = T1A2.Text
            Resultado2.Text = formula.areat1(a, b)

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumeroCero()
        'Comprobando que los cuadros no estan vacios
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
            a = T1P1.Text
            b = T1P2.Text
            c = T1P3.Text

            Resultado1.Text = formula.perimetro(a, b, c)
        End If
    End Sub


End Class