Public Class SolidosForm
    Public BANDERA As Boolean
    Private formula As New Ecuaciones
    Public a, b, c, d, R1, R2, R3 As Int16
    'declaracion de la constante pi'
    Private Const PI = 3.14159265358979
#Region "Comprobadores de campo"
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
    'BOton de area del cono'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NumeroCero()
        If A3C1.Text.Length = 0 Then
            BANDERA = True
        ElseIf A3C2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = A3C1.Text
            Radio1.Text = a
            b = A3C2.Text
            R2 = (PI * (a ^ 2))
            R3 = (PI * b * a)
            R1 = (R2 + R3)
            A3.Text = (R1)
        End If
    End Sub
    'boton de volumen del cono'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        NumeroCero()
        If V3C1.Text.Length = 0 Then
            BANDERA = True
        ElseIf V3C2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = V3C1.Text
            b = V3C2.Text
            R2 = (PI * (a ^ 2))
            R3 = (R2 * b)
            R1 = (R3 / 3)
            V3.Text = (R1)
        End If
    End Sub
    'Boton de area de la esfera'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NumeroCero()
        If A2E.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = A2E.Text
            R1 = (4 * PI * (a ^ 2))
            A2.Text = (R1)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        NumeroCero()
        If V2E.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = V2E.Text
            R1 = ((4 / 3) * (PI * (a ^ 3)))
            V2.Text = (R1)
        End If
    End Sub
#End Region

    'Boton de volumen del cubo'
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NumeroCero()
        If V4C1.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = V4C1.Text
            V4.Text = (a ^ 3)
        End If

    End Sub

    'Boton de Area del cubo'
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NumeroCero()
        If A4C1.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = A4C1.Text
            A4.Text = ((a ^ 2) * 6)
        End If
    End Sub

    'Boton Area del cilindro'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NumeroCero()
        If A1C1.Text.Length = 0 Then
            BANDERA = True
        ElseIf A1C2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = A1C1.Text
            Radio2.Text = a
            b = A1C2.Text
            c = a
            R2 = ((2 * PI) * a)
            R3 = (b + c)
            R1 = (R2 * R3)
            A1.Text = (R1)
        End If
    End Sub

    'Boton de Volumen del cilindro'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumeroCero()
        If V1C1.Text.Length = 0 Then
            BANDERA = True
        ElseIf V1C2.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = V1C1.Text
            b = V1C2.Text
            V1.Text = (PI * (a ^ 2) * b)
        End If
    End Sub

    'Boton de Volumen del Parelepipedo'
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        NumeroCero()
        If V5P1.Text.Length = 0 Then
            BANDERA = True
        ElseIf V5P2.Text.Length = 0 Then
            BANDERA = True
        ElseIf V5P3.Text.Length = 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        If Validacion() = True Then
            a = V5P1.Text
            b = V5P2.Text
            c = V5P3.Text
            V5.Text = (a * b * c)
        End If
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