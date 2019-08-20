Public Class FormPrincipal
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub
    'Para mandar a llamar los form al panel contenedor'
    Private Sub NewWindows(Of MiForm As {Form, New})()
        Dim Formulario As Form
        Formulario = Contenedor.Controls.OfType(Of MiForm)().FirstOrDefault() 'Busca el formulario esta en la coleccion
        'si formulario existe
        If Formulario Is Nothing Then
            Formulario = New MiForm()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            Formulario.AutoSize = True
            Contenedor.Controls.Add(Formulario)
            Contenedor.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
            AddHandler Formulario.FormClosed, AddressOf Me.Close
        Else

            If Formulario.WindowState = FormWindowState.Minimized Then
                Formulario.WindowState = FormWindowState.Normal
            End If

            Formulario.BringToFront()
        End If


    End Sub
#Region "Botones funcionalidades "
    'Botones Funcionalidades
    'Boton triangulo

    Private Sub BtnTriangulo_Click(sender As Object, e As EventArgs) Handles BtnTriangulo.Click
        NewWindows(Of TrianguloForm)()

    End Sub

    Private Sub BtnCuadrado_Click(sender As Object, e As EventArgs) Handles BtnCuadrado.Click
        NewWindows(Of CuadradoForm)()

    End Sub

    Private Sub BtnRomboide_Click(sender As Object, e As EventArgs) Handles BtnRomboide.Click
        NewWindows(Of SolidosForm)()

    End Sub


#End Region
End Class