﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GeometriaProyecto.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Cuadrado() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Cuadrado", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Rectangulo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Rectangulo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Rombo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Rombo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Romboide() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Romboide", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Trapecio() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Trapecio", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Triangulo_equilatero() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Triangulo.equilatero", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Triangulo_escaleno01() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Triangulo.escaleno01", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property triangulo_isosceles() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("triangulo.isosceles", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Triangulo_rectangulo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Triangulo.rectangulo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
