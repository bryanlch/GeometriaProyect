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
    'boton area de un rombo'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NumeroCero()
        If P3A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P3A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P3A1.Text
            b = P3A2.Text
            P3.Text = ((a * b) / 2)
        End If

    End Sub
    'boton de Perimetro de un rombo'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        NumeroCero()
        If P3P1.Text.Length = 0 Then
            BANDERA = True
        End If
        If Validacion() = True Then
            a = P3P1.Text
            A3.Text = (a * 4)
        End If
    End Sub
    'AREA DE UN ROMBOIDE'
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NumeroCero()
        If P4A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P4A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P4A1.Text
            b = P4A2.Text
            P4.Text = (a * b)
        End If
    End Sub
    'boton perimetro de un romboide
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NumeroCero()
        If P4P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P4P2.Text.Length = 0 Then
            BANDERA = True
        ElseIf P4P3.Text.Length = 0 Then
            BANDERA = True
        ElseIf P4P4.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P4P1.Text
            b = P4P2.Text
            c = P4P3.Text
            d = P4P4.Text
            A4.Text = (a + b + c + d)
        End If
    End Sub
    'boton de area DE UN TRAPECIO
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        NumeroCero()
        If P5A1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P5A2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P5A1.Text
            b = P5A2.Text
            A5.Text = ((a * b) / 2)
        End If
    End Sub
    'BOTON DE UN PERIMETRO DE UN TRAPECIO
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        NumeroCero()
        If P5P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf P5P2.Text.Length = 0 Then
            BANDERA = True
        ElseIf P5P3.Text.Length = 0 Then
            BANDERA = True
        ElseIf P5P4.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If

        If Validacion() = True Then
            a = P5P1.Text
            b = P5P2.Text
            c = P5P3.Text
            d = P5P4.Text
            A5.Text = (a + b + c + d)
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