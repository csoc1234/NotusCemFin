﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace SAPContabilizacionEntrada
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="Config1Binding", [Namespace]:="urn:WS_ENTRADAS_LGWsd/Config1/document")>  _
    Partial Public Class WS_ENTRADAS_LG
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private executeZmmLgContabEntradasOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.BPColSysOP.My.MySettings.Default.BPColSysOP_SAPContabilizacionEntrada_WS_ENTRADAS_LG
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event executeZmmLgContabEntradasCompleted As executeZmmLgContabEntradasCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace:="urn:WS_ENTRADAS_LGVi", ResponseNamespace:="urn:WS_ENTRADAS_LGVi", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function executeZmmLgContabEntradas(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal iIndCaso As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal iClMovimiento As String, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal iEntradasCab As ZmmLgEntradasCab, <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal iConsultar As String, <System.Xml.Serialization.XmlArrayAttribute(IsNullable:=true), System.Xml.Serialization.XmlArrayItemAttribute([Namespace]:="urn:tables")> ByVal rMateriales() As ZmmLgMateriales, <System.Xml.Serialization.XmlArrayAttribute(IsNullable:=true), System.Xml.Serialization.XmlArrayItemAttribute([Namespace]:="urn:tables")> ByVal rSeriales() As ZmmLgSerialnumber) As <System.Xml.Serialization.XmlElementAttribute("Response", IsNullable:=true)> OutputContabLg
            Dim results() As Object = Me.Invoke("executeZmmLgContabEntradas", New Object() {iIndCaso, iClMovimiento, iEntradasCab, iConsultar, rMateriales, rSeriales})
            Return CType(results(0),OutputContabLg)
        End Function
        
        '''<remarks/>
        Public Overloads Sub executeZmmLgContabEntradasAsync(ByVal iIndCaso As String, ByVal iClMovimiento As String, ByVal iEntradasCab As ZmmLgEntradasCab, ByVal iConsultar As String, ByVal rMateriales() As ZmmLgMateriales, ByVal rSeriales() As ZmmLgSerialnumber)
            Me.executeZmmLgContabEntradasAsync(iIndCaso, iClMovimiento, iEntradasCab, iConsultar, rMateriales, rSeriales, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub executeZmmLgContabEntradasAsync(ByVal iIndCaso As String, ByVal iClMovimiento As String, ByVal iEntradasCab As ZmmLgEntradasCab, ByVal iConsultar As String, ByVal rMateriales() As ZmmLgMateriales, ByVal rSeriales() As ZmmLgSerialnumber, ByVal userState As Object)
            If (Me.executeZmmLgContabEntradasOperationCompleted Is Nothing) Then
                Me.executeZmmLgContabEntradasOperationCompleted = AddressOf Me.OnexecuteZmmLgContabEntradasOperationCompleted
            End If
            Me.InvokeAsync("executeZmmLgContabEntradas", New Object() {iIndCaso, iClMovimiento, iEntradasCab, iConsultar, rMateriales, rSeriales}, Me.executeZmmLgContabEntradasOperationCompleted, userState)
        End Sub
        
        Private Sub OnexecuteZmmLgContabEntradasOperationCompleted(ByVal arg As Object)
            If (Not (Me.executeZmmLgContabEntradasCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent executeZmmLgContabEntradasCompleted(Me, New executeZmmLgContabEntradasCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:tables")>  _
    Partial Public Class ZmmLgEntradasCab
        
        Private centroCostoField As String
        
        Private divisionField As String
        
        Private entregaFacturaField As String
        
        Private noOrdenField As String
        
        Private notaField As String
        
        Private pedidoDoccompField As String
        
        Private sociedadField As String
        
        Private textoCabField As String
        
        Private valeField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property centroCosto() As String
            Get
                Return Me.centroCostoField
            End Get
            Set
                Me.centroCostoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property division() As String
            Get
                Return Me.divisionField
            End Get
            Set
                Me.divisionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property entregaFactura() As String
            Get
                Return Me.entregaFacturaField
            End Get
            Set
                Me.entregaFacturaField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property noOrden() As String
            Get
                Return Me.noOrdenField
            End Get
            Set
                Me.noOrdenField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property nota() As String
            Get
                Return Me.notaField
            End Get
            Set
                Me.notaField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property pedidoDoccomp() As String
            Get
                Return Me.pedidoDoccompField
            End Get
            Set
                Me.pedidoDoccompField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property sociedad() As String
            Get
                Return Me.sociedadField
            End Get
            Set
                Me.sociedadField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property textoCab() As String
            Get
                Return Me.textoCabField
            End Get
            Set
                Me.textoCabField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property vale() As String
            Get
                Return Me.valeField
            End Get
            Set
                Me.valeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:tables")>  _
    Partial Public Class Bapiret2
        
        Private fieldField As String
        
        Private idField As String
        
        Private logMsgNoField As Integer
        
        Private logNoField As String
        
        Private messageField As String
        
        Private messageV1Field As String
        
        Private messageV2Field As String
        
        Private messageV3Field As String
        
        Private messageV4Field As String
        
        Private numberField As Integer
        
        Private parameterField As String
        
        Private rowField As Integer
        
        Private systemField As String
        
        Private typeField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property field() As String
            Get
                Return Me.fieldField
            End Get
            Set
                Me.fieldField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property id() As String
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property logMsgNo() As Integer
            Get
                Return Me.logMsgNoField
            End Get
            Set
                Me.logMsgNoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property logNo() As String
            Get
                Return Me.logNoField
            End Get
            Set
                Me.logNoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property message() As String
            Get
                Return Me.messageField
            End Get
            Set
                Me.messageField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property messageV1() As String
            Get
                Return Me.messageV1Field
            End Get
            Set
                Me.messageV1Field = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property messageV2() As String
            Get
                Return Me.messageV2Field
            End Get
            Set
                Me.messageV2Field = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property messageV3() As String
            Get
                Return Me.messageV3Field
            End Get
            Set
                Me.messageV3Field = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property messageV4() As String
            Get
                Return Me.messageV4Field
            End Get
            Set
                Me.messageV4Field = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property number() As Integer
            Get
                Return Me.numberField
            End Get
            Set
                Me.numberField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property parameter() As String
            Get
                Return Me.parameterField
            End Get
            Set
                Me.parameterField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property row() As Integer
            Get
                Return Me.rowField
            End Get
            Set
                Me.rowField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property system() As String
            Get
                Return Me.systemField
            End Get
            Set
                Me.systemField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:tables")>  _
    Partial Public Class OutputContabLg
        
        Private oMensajesField() As Bapiret2
        
        Private rMaterialesField() As ZmmLgMateriales
        
        Private rSerialesField() As ZmmLgSerialnumber
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(IsNullable:=true)>  _
        Public Property oMensajes() As Bapiret2()
            Get
                Return Me.oMensajesField
            End Get
            Set
                Me.oMensajesField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(IsNullable:=true)>  _
        Public Property rMateriales() As ZmmLgMateriales()
            Get
                Return Me.rMaterialesField
            End Get
            Set
                Me.rMaterialesField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayAttribute(IsNullable:=true)>  _
        Public Property rSeriales() As ZmmLgSerialnumber()
            Get
                Return Me.rSerialesField
            End Get
            Set
                Me.rSerialesField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:tables")>  _
    Partial Public Class ZmmLgMateriales
        
        Private almacenField As String
        
        Private almacenReceptField As String
        
        Private cantidadField As Double
        
        Private centroField As String
        
        Private centroReceptField As String
        
        Private destinatarioField As String
        
        Private fechaVencField As String
        
        Private loteField As String
        
        Private loteReceptField As String
        
        Private materialField As String
        
        Private materialReceptField As String
        
        Private posContableField As Integer
        
        Private posDocumentoField As Integer
        
        Private textoPosField As String
        
        Private unidadField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property almacen() As String
            Get
                Return Me.almacenField
            End Get
            Set
                Me.almacenField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property almacenRecept() As String
            Get
                Return Me.almacenReceptField
            End Get
            Set
                Me.almacenReceptField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property cantidad() As Double
            Get
                Return Me.cantidadField
            End Get
            Set
                Me.cantidadField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property centro() As String
            Get
                Return Me.centroField
            End Get
            Set
                Me.centroField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property centroRecept() As String
            Get
                Return Me.centroReceptField
            End Get
            Set
                Me.centroReceptField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property destinatario() As String
            Get
                Return Me.destinatarioField
            End Get
            Set
                Me.destinatarioField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property fechaVenc() As String
            Get
                Return Me.fechaVencField
            End Get
            Set
                Me.fechaVencField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property lote() As String
            Get
                Return Me.loteField
            End Get
            Set
                Me.loteField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property loteRecept() As String
            Get
                Return Me.loteReceptField
            End Get
            Set
                Me.loteReceptField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property material() As String
            Get
                Return Me.materialField
            End Get
            Set
                Me.materialField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property materialRecept() As String
            Get
                Return Me.materialReceptField
            End Get
            Set
                Me.materialReceptField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property posContable() As Integer
            Get
                Return Me.posContableField
            End Get
            Set
                Me.posContableField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property posDocumento() As Integer
            Get
                Return Me.posDocumentoField
            End Get
            Set
                Me.posDocumentoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property textoPos() As String
            Get
                Return Me.textoPosField
            End Get
            Set
                Me.textoPosField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property unidad() As String
            Get
                Return Me.unidadField
            End Get
            Set
                Me.unidadField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:tables")>  _
    Partial Public Class ZmmLgSerialnumber
        
        Private materialField As String
        
        Private noSerieField As String
        
        Private posContableField As Integer
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property material() As String
            Get
                Return Me.materialField
            End Get
            Set
                Me.materialField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)>  _
        Public Property noSerie() As String
            Get
                Return Me.noSerieField
            End Get
            Set
                Me.noSerieField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property posContable() As Integer
            Get
                Return Me.posContableField
            End Get
            Set
                Me.posContableField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub executeZmmLgContabEntradasCompletedEventHandler(ByVal sender As Object, ByVal e As executeZmmLgContabEntradasCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class executeZmmLgContabEntradasCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As OutputContabLg
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),OutputContabLg)
            End Get
        End Property
    End Class
End Namespace
