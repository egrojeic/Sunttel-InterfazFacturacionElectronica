﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace ServicioAdjuntos
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="CargarAdjuntos", [Namespace]:="http://schemas.datacontract.org/2004/07/ServiceSoap.UBL2._0.Models.Object"),  _
     System.SerializableAttribute()>  _
    Partial Public Class CargarAdjuntos
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private archivoField() As Byte
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private emailField() As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private enviarField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private formatoField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private nombreField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private numeroDocumentoField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private tipoField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property archivo() As Byte()
            Get
                Return Me.archivoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.archivoField, value) <> true) Then
                    Me.archivoField = value
                    Me.RaisePropertyChanged("archivo")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property email() As String()
            Get
                Return Me.emailField
            End Get
            Set
                If (Object.ReferenceEquals(Me.emailField, value) <> true) Then
                    Me.emailField = value
                    Me.RaisePropertyChanged("email")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property enviar() As String
            Get
                Return Me.enviarField
            End Get
            Set
                If (Object.ReferenceEquals(Me.enviarField, value) <> true) Then
                    Me.enviarField = value
                    Me.RaisePropertyChanged("enviar")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property formato() As String
            Get
                Return Me.formatoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.formatoField, value) <> true) Then
                    Me.formatoField = value
                    Me.RaisePropertyChanged("formato")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property nombre() As String
            Get
                Return Me.nombreField
            End Get
            Set
                If (Object.ReferenceEquals(Me.nombreField, value) <> true) Then
                    Me.nombreField = value
                    Me.RaisePropertyChanged("nombre")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property numeroDocumento() As String
            Get
                Return Me.numeroDocumentoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.numeroDocumentoField, value) <> true) Then
                    Me.numeroDocumentoField = value
                    Me.RaisePropertyChanged("numeroDocumento")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property tipo() As String
            Get
                Return Me.tipoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.tipoField, value) <> true) Then
                    Me.tipoField = value
                    Me.RaisePropertyChanged("tipo")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="UploadAttachmentResponse", [Namespace]:="http://schemas.datacontract.org/2004/07/ServiceSoap.UBL2._0.Response"),  _
     System.SerializableAttribute()>  _
    Partial Public Class UploadAttachmentResponse
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private codigoField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mensajeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private mensajesValidacionField() As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private resultadoField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property codigo() As Integer
            Get
                Return Me.codigoField
            End Get
            Set
                If (Me.codigoField.Equals(value) <> true) Then
                    Me.codigoField = value
                    Me.RaisePropertyChanged("codigo")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mensaje() As String
            Get
                Return Me.mensajeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.mensajeField, value) <> true) Then
                    Me.mensajeField = value
                    Me.RaisePropertyChanged("mensaje")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property mensajesValidacion() As String()
            Get
                Return Me.mensajesValidacionField
            End Get
            Set
                If (Object.ReferenceEquals(Me.mensajesValidacionField, value) <> true) Then
                    Me.mensajesValidacionField = value
                    Me.RaisePropertyChanged("mensajesValidacion")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property resultado() As String
            Get
                Return Me.resultadoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.resultadoField, value) <> true) Then
                    Me.resultadoField = value
                    Me.RaisePropertyChanged("resultado")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServicioAdjuntos.IService")>  _
    Public Interface IService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/CargarAdjuntos", ReplyAction:="http://tempuri.org/IService/CargarAdjuntosResponse")>  _
        Function CargarAdjuntos(ByVal tokenEmpresa As String, ByVal tokenPassword As String, ByVal adjunto As ServicioAdjuntos.CargarAdjuntos) As ServicioAdjuntos.UploadAttachmentResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService/CargarAdjuntos", ReplyAction:="http://tempuri.org/IService/CargarAdjuntosResponse")>  _
        Function CargarAdjuntosAsync(ByVal tokenEmpresa As String, ByVal tokenPassword As String, ByVal adjunto As ServicioAdjuntos.CargarAdjuntos) As System.Threading.Tasks.Task(Of ServicioAdjuntos.UploadAttachmentResponse)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IServiceChannel
        Inherits ServicioAdjuntos.IService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceClient
        Inherits System.ServiceModel.ClientBase(Of ServicioAdjuntos.IService)
        Implements ServicioAdjuntos.IService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function CargarAdjuntos(ByVal tokenEmpresa As String, ByVal tokenPassword As String, ByVal adjunto As ServicioAdjuntos.CargarAdjuntos) As ServicioAdjuntos.UploadAttachmentResponse Implements ServicioAdjuntos.IService.CargarAdjuntos
            Return MyBase.Channel.CargarAdjuntos(tokenEmpresa, tokenPassword, adjunto)
        End Function
        
        Public Function CargarAdjuntosAsync(ByVal tokenEmpresa As String, ByVal tokenPassword As String, ByVal adjunto As ServicioAdjuntos.CargarAdjuntos) As System.Threading.Tasks.Task(Of ServicioAdjuntos.UploadAttachmentResponse) Implements ServicioAdjuntos.IService.CargarAdjuntosAsync
            Return MyBase.Channel.CargarAdjuntosAsync(tokenEmpresa, tokenPassword, adjunto)
        End Function
    End Class
End Namespace
