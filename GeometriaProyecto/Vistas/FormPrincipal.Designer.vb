<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Titulo = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lateral = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnTriangulo = New System.Windows.Forms.Button()
        Me.BtnCuadrado = New System.Windows.Forms.Button()
        Me.BtnVectores = New System.Windows.Forms.Button()
        Me.BtnRomboide = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Contenedor = New System.Windows.Forms.Panel()
        Me.Titulo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Lateral.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Controls.Add(Me.TableLayoutPanel2)
        Me.Titulo.Controls.Add(Me.TableLayoutPanel1)
        Me.Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Titulo.ForeColor = System.Drawing.Color.White
        Me.Titulo.Location = New System.Drawing.Point(0, 0)
        Me.Titulo.MaximumSize = New System.Drawing.Size(1900, 120)
        Me.Titulo.MinimumSize = New System.Drawing.Size(1244, 100)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Padding = New System.Windows.Forms.Padding(10)
        Me.Titulo.Size = New System.Drawing.Size(1288, 100)
        Me.Titulo.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.3886!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.6114!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel2.MinimumSize = New System.Drawing.Size(522, 80)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(836, 80)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Gothic Std B", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proyecto Final de Geometria Analitica " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(694, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Integrantes :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(524, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Seccion :  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Profesora:    Luisa"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24501!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75498!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(846, 10)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(432, 80)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(432, 80)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "3-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "2-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(64, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(64, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(64, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Label10"
        '
        'Lateral
        '
        Me.Lateral.AutoSize = True
        Me.Lateral.BackColor = System.Drawing.Color.Transparent
        Me.Lateral.Controls.Add(Me.TableLayoutPanel3)
        Me.Lateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.Lateral.ForeColor = System.Drawing.Color.White
        Me.Lateral.Location = New System.Drawing.Point(0, 100)
        Me.Lateral.MaximumSize = New System.Drawing.Size(250, 0)
        Me.Lateral.MinimumSize = New System.Drawing.Size(250, 561)
        Me.Lateral.Name = "Lateral"
        Me.Lateral.Size = New System.Drawing.Size(250, 752)
        Me.Lateral.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button6, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnTriangulo, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnCuadrado, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnVectores, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnRomboide, 1, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(7)
        Me.TableLayoutPanel3.MaximumSize = New System.Drawing.Size(0, 700)
        Me.TableLayoutPanel3.MinimumSize = New System.Drawing.Size(170, 50)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 10
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(250, 700)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.Crimson
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(32, 637)
        Me.Button6.Margin = New System.Windows.Forms.Padding(7)
        Me.Button6.MaximumSize = New System.Drawing.Size(0, 300)
        Me.Button6.MinimumSize = New System.Drawing.Size(170, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(211, 56)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(28, 0)
        Me.Label11.MinimumSize = New System.Drawing.Size(206, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 42)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Opciones"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTriangulo
        '
        Me.BtnTriangulo.AutoSize = True
        Me.BtnTriangulo.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnTriangulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnTriangulo.FlatAppearance.BorderSize = 0
        Me.BtnTriangulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnTriangulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnTriangulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTriangulo.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTriangulo.ForeColor = System.Drawing.Color.White
        Me.BtnTriangulo.Location = New System.Drawing.Point(32, 49)
        Me.BtnTriangulo.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnTriangulo.MaximumSize = New System.Drawing.Size(0, 300)
        Me.BtnTriangulo.MinimumSize = New System.Drawing.Size(170, 50)
        Me.BtnTriangulo.Name = "BtnTriangulo"
        Me.BtnTriangulo.Size = New System.Drawing.Size(211, 56)
        Me.BtnTriangulo.TabIndex = 0
        Me.BtnTriangulo.Text = "Triangulo"
        Me.BtnTriangulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTriangulo.UseVisualStyleBackColor = False
        '
        'BtnCuadrado
        '
        Me.BtnCuadrado.AutoSize = True
        Me.BtnCuadrado.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnCuadrado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnCuadrado.FlatAppearance.BorderSize = 0
        Me.BtnCuadrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnCuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCuadrado.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCuadrado.ForeColor = System.Drawing.Color.White
        Me.BtnCuadrado.Location = New System.Drawing.Point(32, 119)
        Me.BtnCuadrado.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnCuadrado.MaximumSize = New System.Drawing.Size(0, 300)
        Me.BtnCuadrado.MinimumSize = New System.Drawing.Size(170, 50)
        Me.BtnCuadrado.Name = "BtnCuadrado"
        Me.BtnCuadrado.Size = New System.Drawing.Size(211, 56)
        Me.BtnCuadrado.TabIndex = 1
        Me.BtnCuadrado.Text = "Poligonos"
        Me.BtnCuadrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCuadrado.UseVisualStyleBackColor = False
        '
        'BtnVectores
        '
        Me.BtnVectores.AutoSize = True
        Me.BtnVectores.BackColor = System.Drawing.Color.OrangeRed
        Me.BtnVectores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnVectores.FlatAppearance.BorderSize = 0
        Me.BtnVectores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnVectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnVectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVectores.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVectores.ForeColor = System.Drawing.Color.White
        Me.BtnVectores.Location = New System.Drawing.Point(32, 490)
        Me.BtnVectores.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnVectores.MaximumSize = New System.Drawing.Size(0, 300)
        Me.BtnVectores.MinimumSize = New System.Drawing.Size(170, 50)
        Me.BtnVectores.Name = "BtnVectores"
        Me.BtnVectores.Size = New System.Drawing.Size(211, 56)
        Me.BtnVectores.TabIndex = 7
        Me.BtnVectores.Text = "Vectores"
        Me.BtnVectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVectores.UseVisualStyleBackColor = False
        '
        'BtnRomboide
        '
        Me.BtnRomboide.AutoSize = True
        Me.BtnRomboide.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnRomboide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnRomboide.FlatAppearance.BorderSize = 0
        Me.BtnRomboide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.BtnRomboide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnRomboide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRomboide.Font = New System.Drawing.Font("Candara", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRomboide.ForeColor = System.Drawing.Color.White
        Me.BtnRomboide.Location = New System.Drawing.Point(32, 189)
        Me.BtnRomboide.Margin = New System.Windows.Forms.Padding(7)
        Me.BtnRomboide.MaximumSize = New System.Drawing.Size(0, 300)
        Me.BtnRomboide.MinimumSize = New System.Drawing.Size(170, 50)
        Me.BtnRomboide.Name = "BtnRomboide"
        Me.BtnRomboide.Size = New System.Drawing.Size(211, 56)
        Me.BtnRomboide.TabIndex = 5
        Me.BtnRomboide.Text = "Solidos"
        Me.BtnRomboide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRomboide.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Contenedor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(250, 100)
        Me.Panel1.MinimumSize = New System.Drawing.Size(900, 560)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel1.Size = New System.Drawing.Size(1038, 752)
        Me.Panel1.TabIndex = 3
        '
        'Contenedor
        '
        Me.Contenedor.AutoSize = True
        Me.Contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Contenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.ForeColor = System.Drawing.Color.White
        Me.Contenedor.Location = New System.Drawing.Point(0, 10)
        Me.Contenedor.Margin = New System.Windows.Forms.Padding(10)
        Me.Contenedor.MinimumSize = New System.Drawing.Size(952, 709)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1036, 730)
        Me.Contenedor.TabIndex = 1
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1288, 852)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lateral)
        Me.Controls.Add(Me.Titulo)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        Me.Titulo.ResumeLayout(False)
        Me.Titulo.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Lateral.ResumeLayout(False)
        Me.Lateral.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Titulo As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Lateral As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnTriangulo As Button
    Friend WithEvents BtnCuadrado As Button
    Friend WithEvents BtnVectores As Button
    Friend WithEvents BtnRomboide As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Contenedor As Panel
End Class
