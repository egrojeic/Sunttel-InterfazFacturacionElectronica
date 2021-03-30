Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.ServiceModel
Imports System.IO
Imports System.Xml.Serialization
Imports SunttelDll2007
Imports System.Data.SqlClient

Public Class cFacturaElectronica

    Dim serviceClient As ServicioEmi.ServiceClient
    Dim serviceArchivos As ServicioAdjuntos.ServiceClient

    Public PathFileFactura As String = ""
    Public IDDocto As Integer = 0
    Public strErrorEnvio As String = ""


    Public Sub New()

        serviceClient = New ServicioEmi.ServiceClient()
        serviceArchivos = New ServicioAdjuntos.ServiceClient()

    End Sub

    Public Function GeneraFileFacturaFactory(prmID As Integer, prmCodConsecutivoDocumento As Integer, prmPrefijo As String, prmConsDesde As Integer, Optional prmNumDecimales As Integer = 2) As ServicioEmi.FacturaGeneral
        Dim tmpstrPath As String = ""

        IDDocto = prmID

        Dim CodConsecutivoFactura As Integer = prmCodConsecutivoDocumento
        Dim strSQL As String = ""
        Dim dsFactura As New dsConsultaFactura
        On Error Resume Next


        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 1"
        LlenaDataSetGenerico(dsFactura.InfoGeneral, "InfoGeneral", strSQL, strConeccionDB)

        Dim DocFactura As New ServicioEmi.FacturaGeneral

        DocFactura.cantidadDecimales = prmNumDecimales
        DocFactura.consecutivoDocumento = dsFactura.InfoGeneral(0).consecutivoDocumento
        DocFactura.fechaEmision = dsFactura.InfoGeneral(0).fechaEmision
        DocFactura.fechaFinPeriodoFacturacion = dsFactura.InfoGeneral(0).fechaFinPeriodoFacturacion
        DocFactura.fechaInicioPeriodoFacturacion = dsFactura.InfoGeneral(0).fechaInicioPeriodoFacturacion
        DocFactura.fechaPagoImpuestos = dsFactura.InfoGeneral(0).fechaPagoImpuestos
        DocFactura.fechaVencimiento = dsFactura.InfoGeneral(0).fechaVencimiento
        DocFactura.cantidadDecimales = dsFactura.InfoGeneral(0).cantidadDecimales
        DocFactura.moneda = dsFactura.InfoGeneral(0).moneda
        DocFactura.propina = dsFactura.InfoGeneral(0).propina
        DocFactura.rangoNumeracion = dsFactura.InfoGeneral(0).rangoNumeracion
        DocFactura.redondeoAplicado = dsFactura.InfoGeneral(0).redondeoAplicado
        DocFactura.tipoDocumento = dsFactura.InfoGeneral(0).tipoDocumento
        DocFactura.tipoOperacion = dsFactura.InfoGeneral(0).tipoOperacion
        DocFactura.totalAnticipos = CDec(dsFactura.InfoGeneral(0).totalAnticipos).ToString(FormatoDecimal)
        DocFactura.totalBaseImponible = CDec(dsFactura.InfoGeneral(0).totalBaseImponible).ToString(FormatoDecimal)
        DocFactura.totalBrutoConImpuesto = CDec(dsFactura.InfoGeneral(0).totalBrutoConImpuesto).ToString(FormatoDecimal)
        DocFactura.totalCargosAplicados = dsFactura.InfoGeneral(0).totalCargosAplicados
        DocFactura.totalDescuentos = CDec(dsFactura.InfoGeneral(0).totalDescuentos).ToString(FormatoDecimal)
        DocFactura.totalMonto = CDec(dsFactura.InfoGeneral(0).totalMonto).ToString(FormatoDecimal)
        DocFactura.totalProductos = dsFactura.InfoGeneral(0).totalProductos
        DocFactura.totalSinImpuestos = CDec(dsFactura.InfoGeneral(0).totalSinImpuestos).ToString(FormatoDecimal)

        ' A que se refiere con esto?
#Region "AUTORIZADO"

        DocFactura.autorizado = Nothing
#End Region


#Region "INFO CLIENTE"

        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 2"
        LlenaDataSetGenerico(dsFactura.InfoCliente, "InfoCliente", strSQL, strConeccionDB)

        Dim cliente As New ServicioEmi.Cliente()

        'cliente.actividadEconomicaCIIU = "0010" 'TODOS APLICAN EL MISMO CIUU? no es obligatorio el campo
        cliente.apellido = dsFactura.InfoCliente(0).apellido

        'Destinatario
        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 2, 1"
        LlenaDataSetGenerico(dsFactura.InfoDestinatario, "InfoDestinatario", strSQL, strConeccionDB)

        If dsFactura.InfoDestinatario.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDestinatario As dsConsultaFactura.InfoDestinatarioRow

            ReDim cliente.destinatario(dsFactura.InfoDestinatario.Rows.Count - 1)

            For Each CursorDestinatario In dsFactura.InfoDestinatario

                Dim destinatario As New ServicioEmi.Destinatario()
                destinatario.canalDeEntrega = CursorDestinatario.canalDeEntrega
                destinatario.email = Split(Replace(CursorDestinatario.eMail, " ", ""), ",")
                destinatario.fechaProgramada = CursorDestinatario.fechaProgramada
                destinatario.mensajePersonalizado = CursorDestinatario.mensajePersonalizado
                destinatario.nitProveedorReceptor = CursorDestinatario.nitProveedorReceptor
                destinatario.telefono = CursorDestinatario.telefono
                cliente.destinatario(i) = destinatario

                i = i + 1
            Next
        End If

        'Condicion Pago
        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 2, 2"
        LlenaDataSetGenerico(dsFactura.InfoCondicionPago, "InfoCondicionPago", strSQL, strConeccionDB)

        If dsFactura.InfoCondicionPago.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorCondicionPago As dsConsultaFactura.InfoCondicionPagoRow

            ReDim DocFactura.condicionPago(dsFactura.InfoCondicionPago.Rows.Count - 1)

            For Each CursorCondicionPago In dsFactura.InfoCondicionPago

                Dim condicionpago As New ServicioEmi.CondicionDePago()
                condicionpago.codigoEvento = CursorCondicionPago.codigoEvento
                condicionpago.comentario = CursorCondicionPago.comentario
                condicionpago.duracionPeriodo = CursorCondicionPago.duracionPeriodo
                condicionpago.duracionPeriodoMedida = CursorCondicionPago.duracionPeriodoMedida
                condicionpago.fechaVencimiento = CursorCondicionPago.fechaVencimiento
                condicionpago.identificador = CursorCondicionPago.identificador
                condicionpago.medioPagoAsociado = CursorCondicionPago.medioPagoAsociado
                condicionpago.monto = CursorCondicionPago.monto
                condicionpago.montoMulta = CursorCondicionPago.montoMulta
                condicionpago.montoPenalidad = CursorCondicionPago.montoPenalidad
                condicionpago.periodoDesde = CursorCondicionPago.periodoDesde
                condicionpago.periodoHasta = CursorCondicionPago.periodoHasta
                condicionpago.porcentajeDescuento = CursorCondicionPago.porcentajeDescuento
                condicionpago.porcentajePago = CursorCondicionPago.porcentajePago
                condicionpago.referenciaAnticipo = CursorCondicionPago.referenciaAnticipo
                DocFactura.condicionPago(i) = condicionpago

                i = i + 1
            Next
        End If

        'Detalles Tributarios  ' Que es esto de Detalles Tributarios?
        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 2, 3"
        LlenaDataSetGenerico(dsFactura.DetallesTributarios, "DetallesTributarios", strSQL, strConeccionDB)

        If dsFactura.DetallesTributarios.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDetallesTributarios As dsConsultaFactura.DetallesTributariosRow

            ReDim cliente.detallesTributarios(dsFactura.DetallesTributarios.Rows.Count - 1)

            For Each CursorDetallesTributarios In dsFactura.DetallesTributarios

                Dim detallesTributarios As New ServicioEmi.Tributos()
                detallesTributarios.codigoImpuesto = CursorDetallesTributarios.codigoImpuesto
                cliente.detallesTributarios(i) = detallesTributarios

                i = i + 1
            Next
        End If


        Dim correoEntrega(1) As String
        correoEntrega(0) = dsFactura.InfoCliente(0).destinatario1Email

        Dim direccionCliente As New ServicioEmi.Direccion()

        direccionCliente.aCuidadoDe = dsFactura.InfoCliente(0).direccionFiscalCuidadoDe
        direccionCliente.aLaAtencionDe = dsFactura.InfoCliente(0).direccionFiscalAaLaAtencionDe
        direccionCliente.bloque = dsFactura.InfoCliente(0).direccionFiscalBloque
        direccionCliente.buzon = dsFactura.InfoCliente(0).direccionFiscalBuzon
        direccionCliente.calle = dsFactura.InfoCliente(0).direccionFiscalCalle
        direccionCliente.calleAdicional = dsFactura.InfoCliente(0).direccionFiscalCalleAdicional
        direccionCliente.ciudad = dsFactura.InfoCliente(0).direccionFiscalCiudad
        direccionCliente.codigoDepartamento = dsFactura.InfoCliente(0).direccionFiscalCodigoDepartamento
        direccionCliente.correccionHusoHorario = dsFactura.InfoCliente(0).direccionFiscalCorreccionHusoHorario
        direccionCliente.departamento = dsFactura.InfoCliente(0).direccionFiscalDepartamento
        direccionCliente.departamentoOrg = dsFactura.InfoCliente(0).direccionFiscalDepartamentoOrg
        direccionCliente.direccion = dsFactura.InfoCliente(0).direccionFiscalDireccion
        direccionCliente.distrito = dsFactura.InfoCliente(0).direccionFiscalDistrito
        direccionCliente.habitacion = dsFactura.InfoCliente(0).direccionFiscalHabitacion
        direccionCliente.lenguaje = dsFactura.InfoCliente(0).direccionFiscalLenguaje
        direccionCliente.localizacion = Nothing
        direccionCliente.municipio = dsFactura.InfoCliente(0).direccionFiscalMunicipio
        direccionCliente.nombreEdificio = dsFactura.InfoCliente(0).direccionFiscalNombreEdificio
        direccionCliente.numeroEdificio = dsFactura.InfoCliente(0).direccionFiscalNumeroEdificio
        direccionCliente.numeroParcela = dsFactura.InfoCliente(0).direccionFiscalNumeroParcela
        direccionCliente.pais = dsFactura.InfoCliente(0).direccionFiscalPais
        direccionCliente.piso = dsFactura.InfoCliente(0).direccionFiscalPiso
        direccionCliente.region = dsFactura.InfoCliente(0).direccionFiscalRegion
        direccionCliente.subDivision = dsFactura.InfoCliente(0).direccionFiscalSubDivision
        direccionCliente.ubicacion = dsFactura.InfoCliente(0).direccionFiscalUbicacion
        direccionCliente.zonaPostal = dsFactura.InfoCliente(0).direccionFiscalZonaPostal
        cliente.direccionCliente = direccionCliente

        Dim direccionFiscal As New ServicioEmi.Direccion()
        direccionFiscal.aCuidadoDe = dsFactura.InfoCliente(0).direccionFiscalCuidadoDe
        direccionFiscal.aLaAtencionDe = dsFactura.InfoCliente(0).direccionFiscalAaLaAtencionDe
        direccionFiscal.bloque = dsFactura.InfoCliente(0).direccionFiscalBloque
        direccionFiscal.buzon = dsFactura.InfoCliente(0).direccionFiscalBuzon
        direccionFiscal.calle = dsFactura.InfoCliente(0).direccionFiscalCalle
        direccionFiscal.calleAdicional = dsFactura.InfoCliente(0).direccionFiscalCalleAdicional
        direccionFiscal.ciudad = dsFactura.InfoCliente(0).direccionFiscalCiudad
        direccionFiscal.codigoDepartamento = dsFactura.InfoCliente(0).direccionFiscalCodigoDepartamento
        direccionFiscal.correccionHusoHorario = dsFactura.InfoCliente(0).direccionFiscalCorreccionHusoHorario
        direccionFiscal.departamento = dsFactura.InfoCliente(0).direccionFiscalDepartamento
        direccionFiscal.departamentoOrg = dsFactura.InfoCliente(0).direccionFiscalDepartamentoOrg
        direccionFiscal.direccion = dsFactura.InfoCliente(0).direccionFiscalDireccion
        direccionFiscal.distrito = dsFactura.InfoCliente(0).direccionFiscalDistrito
        direccionFiscal.habitacion = dsFactura.InfoCliente(0).direccionFiscalHabitacion
        direccionFiscal.lenguaje = dsFactura.InfoCliente(0).direccionFiscalLenguaje
        direccionFiscal.localizacion = Nothing
        direccionFiscal.municipio = dsFactura.InfoCliente(0).direccionFiscalMunicipio
        direccionFiscal.nombreEdificio = dsFactura.InfoCliente(0).direccionFiscalNombreEdificio
        direccionFiscal.numeroEdificio = dsFactura.InfoCliente(0).direccionFiscalNumeroEdificio
        direccionFiscal.numeroParcela = dsFactura.InfoCliente(0).direccionFiscalNumeroParcela
        direccionFiscal.pais = dsFactura.InfoCliente(0).direccionFiscalPais
        direccionFiscal.piso = dsFactura.InfoCliente(0).direccionFiscalPiso
        direccionFiscal.region = dsFactura.InfoCliente(0).direccionFiscalRegion
        direccionFiscal.subDivision = dsFactura.InfoCliente(0).direccionFiscalSubDivision
        direccionFiscal.ubicacion = dsFactura.InfoCliente(0).direccionFiscalUbicacion
        direccionFiscal.zonaPostal = dsFactura.InfoCliente(0).direccionFiscalZonaPostal
        cliente.direccionFiscal = direccionFiscal


        cliente.email = dsFactura.InfoCliente(0).clienteeEmail
        cliente.extras = Nothing

        Dim informacionLegalCliente As New ServicioEmi.InformacionLegal()
        informacionLegalCliente.codigoEstablecimiento = dsFactura.InfoCliente(0).informacionLegalClienteCodigoEstablecimiento
        informacionLegalCliente.nombreRegistroRUT = dsFactura.InfoCliente(0).informacionLegalClienteNombreRegistroRUT
        informacionLegalCliente.numeroIdentificacion = dsFactura.InfoCliente(0).informacionLegalClienteNumeroIdentificacion
        informacionLegalCliente.numeroIdentificacionDV = dsFactura.InfoCliente(0).ClienteNumeroIdentificacionDV
        informacionLegalCliente.numeroMatriculaMercantil = dsFactura.InfoCliente(0).ClienteNumeroMatriculaMercantil
        informacionLegalCliente.prefijoFacturacion = dsFactura.InfoCliente(0).ClientePrefijoFacturacion
        informacionLegalCliente.tipoIdentificacion = dsFactura.InfoCliente(0).informacionLegalClienteTipoIdentificacion
        cliente.informacionLegalCliente = informacionLegalCliente

        cliente.nombreComercial = dsFactura.InfoCliente(0).clienteNombreComercial
        cliente.nombreContacto = dsFactura.InfoCliente(0).clienteNombreContacto
        cliente.nombreRazonSocial = dsFactura.InfoCliente(0).clienteNombreRazonSocial
        cliente.nota = dsFactura.InfoCliente(0).clienteNota
        cliente.notificar = dsFactura.InfoCliente(0).clienteNotificar
        cliente.numeroDocumento = dsFactura.InfoCliente(0).clienteNumeroDocumento
        cliente.numeroIdentificacionDV = dsFactura.InfoCliente(0).ClienteNumeroIdentificacionDV


        'Obligaciones  ' Que es esto de Obligaciones?
        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 2, 4"
        LlenaDataSetGenerico(dsFactura.Obligaciones, "Obligaciones", strSQL, strConeccionDB)

        If dsFactura.Obligaciones.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorObligaciones As dsConsultaFactura.ObligacionesRow

            ReDim cliente.responsabilidadesRut(dsFactura.Obligaciones.Rows.Count - 1)

            For Each CursorObligaciones In dsFactura.Obligaciones

                Dim Obligaciones As New ServicioEmi.Obligaciones()
                Obligaciones.obligaciones = CursorObligaciones.obligaciones
                Obligaciones.regimen = CursorObligaciones.regimen
                cliente.responsabilidadesRut(i) = Obligaciones

                i = i + 1
            Next
        End If

        cliente.segundoNombre = dsFactura.InfoCliente(0).clienteSegundoNombre
        cliente.telefax = dsFactura.InfoCliente(0).clienteTelefax
        cliente.telefono = dsFactura.InfoCliente(0).clienteTelefono
        cliente.tipoIdentificacion = dsFactura.InfoCliente(0).clienteTipoIdentificacion
        cliente.tipoPersona = dsFactura.InfoCliente(0).clienteTipoPersona

        DocFactura.cliente = cliente

#End Region

        ' Cuales son las posibilidades?
#Region "CONDICIONES DE PAGO"
        DocFactura.condicionPago = Nothing

#End Region


#Region "ANTICIPOS"

        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 7"
        LlenaDataSetGenerico(dsFactura.InfoAnticipos, "InfoAnticipos", strSQL, strConeccionDB)

        If dsFactura.InfoAnticipos.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorAnticipos As dsConsultaFactura.InfoAnticiposRow

            ReDim DocFactura.anticipos(dsFactura.InfoAnticipos.Rows.Count - 1)

            For Each CursorAnticipos In dsFactura.InfoAnticipos

                Dim anticipos As ServicioEmi.Anticipos = New ServicioEmi.Anticipos()

                anticipos.fechaDeRecibido = CDate(CursorAnticipos.fechaDeRecibido).ToString(FormatoFecha)
                anticipos.fechadePago = CursorAnticipos.fechadePago
                anticipos.horaDePago = CursorAnticipos.horaDePago
                anticipos.id = CursorAnticipos.id
                anticipos.instrucciones = CursorAnticipos.instrucciones
                anticipos.montoPagado = CDec(CursorAnticipos.montoPagado).ToString(FormatoDecimal)
                DocFactura.anticipos(i) = anticipos

                i = i + 1
            Next

        End If

#End Region


        ' Para que sirve esta parte?
#Region "Documentos Referenciados"

        DocFactura.documentosReferenciados = Nothing
#End Region

        ' Como se llena/ A que se refiere?
#Region "Entrega de Mercancia"

        DocFactura.entregaMercancia = Nothing

#End Region

        ' Que son extras?
#Region "Extras"

        DocFactura.extras = Nothing

#End Region

#Region "Impuestos Generales"


        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 3"
        LlenaDataSetGenerico(dsFactura.InfoImpuestos, "InfoImpuestos", strSQL, strConeccionDB)

        If dsFactura.InfoImpuestos.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorImpuestosGrls As dsConsultaFactura.InfoImpuestosRow

            ReDim DocFactura.impuestosGenerales(dsFactura.InfoImpuestos.Rows.Count - 1)

            For Each CursorImpuestosGrls In dsFactura.InfoImpuestos

                Dim impuestoGeneral1 As ServicioEmi.FacturaImpuestos = New ServicioEmi.FacturaImpuestos()

                impuestoGeneral1.baseImponibleTOTALImp = CDec(CursorImpuestosGrls.impuestoGeneral1BaseImponibleTOTALImp).ToString(FormatoDecimal)
                impuestoGeneral1.codigoTOTALImp = CursorImpuestosGrls.impuestoGeneral1CodigoTOTALImp
                impuestoGeneral1.controlInterno = CursorImpuestosGrls.impuestoGeneral1ControlInterno
                impuestoGeneral1.porcentajeTOTALImp = If(CursorImpuestosGrls.Flag3Decimales = 1, CDec(CursorImpuestosGrls.impuestoGeneral1PorcentajeTOTALImp).ToString("####0.000"), CDec(CursorImpuestosGrls.impuestoGeneral1PorcentajeTOTALImp).ToString(FormatoDecimal))
                impuestoGeneral1.unidadMedida = CursorImpuestosGrls.impuestoGeneral1UnidadMedida
                impuestoGeneral1.unidadMedidaTributo = CursorImpuestosGrls.impuestoGeneral1UnidadMedidaTributo
                impuestoGeneral1.valorTOTALImp = CDec(CursorImpuestosGrls.impuestoGeneral1ValorTOTALImp).ToString(FormatoDecimal)
                impuestoGeneral1.valorTributoUnidad = CursorImpuestosGrls.impuestoGeneral1ValorTributoUnidad
                DocFactura.impuestosGenerales(i) = impuestoGeneral1

                i = i + 1
            Next

        End If

#End Region

        ' Que diferencia tiene con Impuestos Generales
#Region "Impuestos Totales"

        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 6"
        LlenaDataSetGenerico(dsFactura.InfoImpuestosTotales, "InfoImpuestosTotales", strSQL, strConeccionDB)

        If dsFactura.InfoImpuestosTotales.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorInfoImpuestosTotales As dsConsultaFactura.InfoImpuestosTotalesRow

            ReDim DocFactura.impuestosTotales(dsFactura.InfoImpuestosTotales.Rows.Count - 1)

            For Each CursorInfoImpuestosTotales In dsFactura.InfoImpuestosTotales

                Dim impuestoTotal As ServicioEmi.ImpuestosTotales = New ServicioEmi.ImpuestosTotales()

                impuestoTotal.montoTotal = CDec(CursorInfoImpuestosTotales.montoTotal).ToString(FormatoDecimal)
                impuestoTotal.codigoTOTALImp = CursorInfoImpuestosTotales.codigoTOTALImp
                DocFactura.impuestosTotales(i) = impuestoTotal

                i = i + 1
            Next

        End If

#End Region

        ' Que debe ir aqui?
#Region "Informacion Adicional"

        DocFactura.informacionAdicional = Nothing




#End Region

        ' Como se llena?
#Region "Medios de Pago"

        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 4"
        LlenaDataSetGenerico(dsFactura.InfoMediosPago, "InfoMediosPago", strSQL, strConeccionDB)

        If dsFactura.InfoMediosPago.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorInfoMediosPago As dsConsultaFactura.InfoMediosPagoRow

            ReDim DocFactura.mediosDePago(dsFactura.InfoMediosPago.Rows.Count - 1)

            For Each CursorInfoMediosPago In dsFactura.InfoMediosPago

                Dim medioPago1 As ServicioEmi.MediosDePago = New ServicioEmi.MediosDePago()

                medioPago1.codigoBanco = CursorInfoMediosPago.medioPagoCodigoBanco
                medioPago1.codigoCanalPago = CursorInfoMediosPago.medioPagoCodigoCanalPago
                medioPago1.codigoReferencia = CursorInfoMediosPago.medioPagoCodigoReferencia
                medioPago1.fechaDeVencimiento = CDate(CursorInfoMediosPago.medioPagoFechaDeVencimiento).ToString(FormatoFecha)
                medioPago1.medioPago = CursorInfoMediosPago.medioPagoMedioPago
                medioPago1.metodoDePago = CursorInfoMediosPago.medioPago1MetodoDePago
                medioPago1.nombreBanco = CursorInfoMediosPago.medioPagoNombreBanco
                medioPago1.numeroDeReferencia = CursorInfoMediosPago.medioPagoNumeroDeReferencia
                medioPago1.numeroDias = CursorInfoMediosPago.medioPagoNumeroDias
                medioPago1.numeroTransferencia = CursorInfoMediosPago.medioPagoNumeroTransferencia
                DocFactura.mediosDePago(i) = medioPago1

                i = i + 1
            Next

        End If


#End Region

#Region "Orden de Compra"

        If (dsFactura.InfoGeneral(0).InformacionAdicional.Length > 0) Then
            Dim newOCompra As New ServicioEmi.OrdenDeCompra
            ReDim DocFactura.ordenDeCompra(0)

            newOCompra.numeroOrden = dsFactura.InfoGeneral(0).InformacionAdicional
            DocFactura.ordenDeCompra(0) = newOCompra

        Else
            DocFactura.ordenDeCompra = Nothing
        End If




#End Region

#Region "Tasa de Cambio"
        DocFactura.tasaDeCambio = Nothing

#End Region

#Region "Tasa De Cambio Alternativa"
        DocFactura.tasaDeCambioAlternativa = Nothing
#End Region

#Region "Terminos Entrega"
        DocFactura.terminosEntrega = Nothing

#End Region

#Region "Detalle De Factura"


        strSQL = "exec GetInfoFactura " & prmID.ToString & ", 5"
        LlenaDataSetGenerico(dsFactura.InfoDetallesFactura, "InfoDetallesFactura", strSQL, strConeccionDB)

        If dsFactura.InfoDetallesFactura.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDetalles As dsConsultaFactura.InfoDetallesFacturaRow

            ReDim DocFactura.detalleDeFactura(dsFactura.InfoDetallesFactura.Rows.Count - 1)

            For Each CursorDetalles In dsFactura.InfoDetallesFactura

                Dim producto1 As New ServicioEmi.FacturaDetalle()
                producto1.cantidadPorEmpaque = CursorDetalles.cantidadPorEmpaque
                producto1.cantidadReal = CInt(CursorDetalles.cantidadReal)
                producto1.cantidadRealUnidadMedida = CursorDetalles.cantidadRealUnidadMedida
                producto1.cantidadUnidades = CInt(CursorDetalles.cantidadUnidades)
                producto1.codigoFabricante = CursorDetalles.codigoFabricante 'Nothing
                producto1.codigoIdentificadorPais = Nothing
                producto1.codigoProducto = CursorDetalles.codigoProducto
                producto1.codigoTipoPrecio = CursorDetalles.codigoTipoPrecio ' Nothing
                producto1.descripcion = CursorDetalles.descripcion
                producto1.descripcionTecnica = CursorDetalles.descripcionTecnica
                '    producto1.detalleAdicionalNombre = null; //debe ser eliminado
                '    producto1.detalleAdicionalValor = null; //debe ser eliminado
                producto1.documentosReferenciados = Nothing
                producto1.estandarCodigo = CursorDetalles.estandarCodigo
                producto1.estandarCodigoID = CursorDetalles.estandarCodigoID ' Nothing
                producto1.estandarCodigoIdentificador = CursorDetalles.estandarCodigoIdentificador ' Nothing
                producto1.estandarCodigoNombre = CursorDetalles.estandarCodigoNombre
                producto1.estandarCodigoProducto = CursorDetalles.estandarCodigoProducto
                producto1.estandarOrganizacion = CursorDetalles.estandarOrganizacion
                producto1.estandarSubCodigoProducto = CursorDetalles.estandarSubCodigoProducto

                ReDim producto1.impuestosDetalles(0)
                Dim impuesto1 As ServicioEmi.FacturaImpuestos = New ServicioEmi.FacturaImpuestos()
                impuesto1.baseImponibleTOTALImp = CDec(CursorDetalles.impuesto1_baseImponibleTOTALImp).ToString(FormatoDecimal)
                impuesto1.codigoTOTALImp = CursorDetalles.impuesto1_codigoTOTALImp
                impuesto1.controlInterno = CursorDetalles.impuesto1_controlInterno
                impuesto1.porcentajeTOTALImp = CDec(CursorDetalles.impuesto1_porcentajeTOTALImp).ToString(FormatoDecimal)
                impuesto1.unidadMedida = CursorDetalles.impuesto1_unidadMedida
                impuesto1.unidadMedidaTributo = CursorDetalles.impuesto1_unidadMedidaTributo
                impuesto1.valorTOTALImp = CDec(CursorDetalles.impuesto1_valorTOTALImp).ToString(FormatoDecimal)
                impuesto1.valorTributoUnidad = CursorDetalles.impuesto1_valorTributoUnidad
                producto1.impuestosDetalles(0) = impuesto1

                ReDim producto1.impuestosTotales(0)
                Dim impuestoTOTAL1 As ServicioEmi.ImpuestosTotales = New ServicioEmi.ImpuestosTotales
                impuestoTOTAL1.codigoTOTALImp = CursorDetalles.impuesto1_codigoTOTALImp
                impuestoTOTAL1.montoTotal = CDec(CursorDetalles.impuesto1_valorTOTALImp).ToString(FormatoDecimal)
                producto1.impuestosTotales(0) = impuestoTOTAL1

                producto1.informacionAdicional = Nothing
                producto1.mandatorioNumeroIdentificacion = Nothing
                producto1.mandatorioNumeroIdentificacionDV = Nothing
                producto1.mandatorioTipoIdentificacion = Nothing
                producto1.marca = CursorDetalles.marca
                producto1.modelo = Nothing
                producto1.muestraGratis = "0"
                producto1.nombreFabricante = Nothing
                producto1.nota = Nothing
                producto1.precioReferencia = Nothing
                producto1.precioTotal = CDec(CursorDetalles.precioTotal).ToString(FormatoDecimal)
                producto1.precioTotalSinImpuestos = CDec(CursorDetalles.precioTotalSinImpuestos).ToString(FormatoDecimal)
                producto1.precioVentaUnitario = CDec(CursorDetalles.precioVentaUnitario).ToString(FormatoDecimal)
                producto1.secuencia = CursorDetalles.secuencia
                producto1.seriales = Nothing
                producto1.subCodigoFabricante = Nothing
                producto1.subCodigoProducto = Nothing
                producto1.tipoAIU = Nothing
                producto1.unidadMedida = CursorDetalles.unidadMedida


                'CargosDescuentos
                If CursorDetalles.porcentaje <> 0 Then
                    ReDim producto1.cargosDescuentos(0)
                    Dim cargosDescuentos As ServicioEmi.CargosDescuentos = New ServicioEmi.CargosDescuentos
                    cargosDescuentos.codigo = CursorDetalles.codigoDescuento
                    cargosDescuentos.descripcion = CursorDetalles.descripcionDescuento
                    cargosDescuentos.indicador = CursorDetalles.indicadorDescuento
                    cargosDescuentos.monto = CDec(CursorDetalles.montoDescuento).ToString(FormatoDecimal)
                    cargosDescuentos.montoBase = CDec(CursorDetalles.montoBaseDescuento).ToString(FormatoDecimal)
                    cargosDescuentos.porcentaje = CDec(CursorDetalles.porcentaje).ToString(FormatoDecimal)
                    cargosDescuentos.secuencia = CursorDetalles.secuencia
                    producto1.cargosDescuentos(0) = cargosDescuentos
                End If


                DocFactura.detalleDeFactura(i) = producto1
                i = i + 1
            Next
        End If


#End Region


        Return DocFactura

    End Function

    Public Function GeneraFileNotaCreditoFactory(prmID As Integer, prmCodConsecutivoDocumento As Integer, prmPrefijo As String, prmConsDesde As Integer, Optional prmNumDecimales As Integer = 2) As ServicioEmi.FacturaGeneral
        Dim tmpstrPath As String = ""

        Dim strSQL As String = ""
        Dim dsFactura As New dsConsultaFactura
        On Error Resume Next


        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 1"
        LlenaDataSetGenerico(dsFactura.InfoGeneral, "InfoGeneral", strSQL, strConeccionDB)

        Dim DocNotaCredito As New ServicioEmi.FacturaGeneral

        DocNotaCredito.cantidadDecimales = prmNumDecimales
        DocNotaCredito.consecutivoDocumento = dsFactura.InfoGeneral(0).consecutivoDocumento
        DocNotaCredito.fechaEmision = dsFactura.InfoGeneral(0).fechaEmision
        DocNotaCredito.fechaFinPeriodoFacturacion = dsFactura.InfoGeneral(0).fechaFinPeriodoFacturacion
        DocNotaCredito.fechaInicioPeriodoFacturacion = dsFactura.InfoGeneral(0).fechaInicioPeriodoFacturacion
        DocNotaCredito.fechaPagoImpuestos = dsFactura.InfoGeneral(0).fechaPagoImpuestos
        DocNotaCredito.fechaVencimiento = dsFactura.InfoGeneral(0).fechaVencimiento
        DocNotaCredito.cantidadDecimales = dsFactura.InfoGeneral(0).cantidadDecimales
        DocNotaCredito.moneda = dsFactura.InfoGeneral(0).moneda
        DocNotaCredito.propina = dsFactura.InfoGeneral(0).propina
        DocNotaCredito.rangoNumeracion = dsFactura.InfoGeneral(0).rangoNumeracion
        DocNotaCredito.redondeoAplicado = dsFactura.InfoGeneral(0).redondeoAplicado
        DocNotaCredito.tipoDocumento = dsFactura.InfoGeneral(0).tipoDocumento
        DocNotaCredito.tipoOperacion = dsFactura.InfoGeneral(0).tipoOperacion
        DocNotaCredito.totalAnticipos = CDec(dsFactura.InfoGeneral(0).totalAnticipos).ToString(FormatoDecimal)
        DocNotaCredito.totalBaseImponible = CDec(dsFactura.InfoGeneral(0).totalBaseImponible).ToString(FormatoDecimal)
        DocNotaCredito.totalBrutoConImpuesto = CDec(dsFactura.InfoGeneral(0).totalBrutoConImpuesto).ToString(FormatoDecimal)
        DocNotaCredito.totalCargosAplicados = dsFactura.InfoGeneral(0).totalCargosAplicados
        DocNotaCredito.totalDescuentos = CDec(dsFactura.InfoGeneral(0).totalDescuentos).ToString(FormatoDecimal)
        DocNotaCredito.totalMonto = CDec(dsFactura.InfoGeneral(0).totalMonto).ToString(FormatoDecimal)
        DocNotaCredito.totalProductos = dsFactura.InfoGeneral(0).totalProductos
        DocNotaCredito.totalSinImpuestos = CDec(dsFactura.InfoGeneral(0).totalSinImpuestos).ToString(FormatoDecimal)


#Region "INFO CLIENTE"

        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 2"
        LlenaDataSetGenerico(dsFactura.InfoCliente, "InfoCliente", strSQL, strConeccionDB)

        Dim cliente As New ServicioEmi.Cliente()
        cliente.apellido = dsFactura.InfoCliente(0).apellido

        'Destinatario
        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 2, 1"
        LlenaDataSetGenerico(dsFactura.InfoDestinatario, "InfoDestinatario", strSQL, strConeccionDB)

        If dsFactura.InfoDestinatario.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDestinatario As dsConsultaFactura.InfoDestinatarioRow

            ReDim cliente.destinatario(dsFactura.InfoDestinatario.Rows.Count - 1)

            For Each CursorDestinatario In dsFactura.InfoDestinatario

                Dim destinatario As New ServicioEmi.Destinatario()
                destinatario.canalDeEntrega = CursorDestinatario.canalDeEntrega
                destinatario.email = Split(Replace(CursorDestinatario.eMail, " ", ""), ",")
                destinatario.fechaProgramada = CursorDestinatario.fechaProgramada
                destinatario.mensajePersonalizado = CursorDestinatario.mensajePersonalizado
                destinatario.nitProveedorReceptor = CursorDestinatario.nitProveedorReceptor
                destinatario.telefono = CursorDestinatario.telefono
                cliente.destinatario(i) = destinatario

                i = i + 1
            Next
        End If


        'Detalles Tributarios  ' Que es esto de Detalles Tributarios?
        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 2, 3"
        LlenaDataSetGenerico(dsFactura.DetallesTributarios, "DetallesTributarios", strSQL, strConeccionDB)

        If dsFactura.DetallesTributarios.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDetallesTributarios As dsConsultaFactura.DetallesTributariosRow

            ReDim cliente.detallesTributarios(dsFactura.DetallesTributarios.Rows.Count - 1)

            For Each CursorDetallesTributarios In dsFactura.DetallesTributarios

                Dim detallesTributarios As New ServicioEmi.Tributos()
                detallesTributarios.codigoImpuesto = CursorDetallesTributarios.codigoImpuesto
                cliente.detallesTributarios(i) = detallesTributarios

                i = i + 1
            Next
        End If


        Dim correoEntrega(1) As String
        correoEntrega(0) = dsFactura.InfoCliente(0).destinatario1Email

        Dim direccionFiscal As New ServicioEmi.Direccion()
        direccionFiscal.aCuidadoDe = dsFactura.InfoCliente(0).direccionFiscalCuidadoDe
        direccionFiscal.aLaAtencionDe = dsFactura.InfoCliente(0).direccionFiscalAaLaAtencionDe
        direccionFiscal.bloque = dsFactura.InfoCliente(0).direccionFiscalBloque
        direccionFiscal.buzon = dsFactura.InfoCliente(0).direccionFiscalBuzon
        direccionFiscal.calle = dsFactura.InfoCliente(0).direccionFiscalCalle
        direccionFiscal.calleAdicional = dsFactura.InfoCliente(0).direccionFiscalCalleAdicional
        direccionFiscal.ciudad = dsFactura.InfoCliente(0).direccionFiscalCiudad
        direccionFiscal.codigoDepartamento = dsFactura.InfoCliente(0).direccionFiscalCodigoDepartamento
        direccionFiscal.correccionHusoHorario = dsFactura.InfoCliente(0).direccionFiscalCorreccionHusoHorario
        direccionFiscal.departamento = dsFactura.InfoCliente(0).direccionFiscalDepartamento
        direccionFiscal.departamentoOrg = dsFactura.InfoCliente(0).direccionFiscalDepartamentoOrg
        direccionFiscal.direccion = dsFactura.InfoCliente(0).direccionFiscalDireccion
        direccionFiscal.distrito = dsFactura.InfoCliente(0).direccionFiscalDistrito
        direccionFiscal.habitacion = dsFactura.InfoCliente(0).direccionFiscalHabitacion
        direccionFiscal.lenguaje = dsFactura.InfoCliente(0).direccionFiscalLenguaje
        direccionFiscal.localizacion = Nothing
        direccionFiscal.municipio = dsFactura.InfoCliente(0).direccionFiscalMunicipio
        direccionFiscal.nombreEdificio = dsFactura.InfoCliente(0).direccionFiscalNombreEdificio
        direccionFiscal.numeroEdificio = dsFactura.InfoCliente(0).direccionFiscalNumeroEdificio
        direccionFiscal.numeroParcela = dsFactura.InfoCliente(0).direccionFiscalNumeroParcela
        direccionFiscal.pais = dsFactura.InfoCliente(0).direccionFiscalPais
        direccionFiscal.piso = dsFactura.InfoCliente(0).direccionFiscalPiso
        direccionFiscal.region = dsFactura.InfoCliente(0).direccionFiscalRegion
        direccionFiscal.subDivision = dsFactura.InfoCliente(0).direccionFiscalSubDivision
        direccionFiscal.ubicacion = dsFactura.InfoCliente(0).direccionFiscalUbicacion
        direccionFiscal.zonaPostal = dsFactura.InfoCliente(0).direccionFiscalZonaPostal
        cliente.direccionFiscal = direccionFiscal


        cliente.email = dsFactura.InfoCliente(0).clienteeEmail
        cliente.extras = Nothing

        Dim informacionLegalCliente As New ServicioEmi.InformacionLegal()
        informacionLegalCliente.codigoEstablecimiento = dsFactura.InfoCliente(0).informacionLegalClienteCodigoEstablecimiento
        informacionLegalCliente.nombreRegistroRUT = dsFactura.InfoCliente(0).informacionLegalClienteNombreRegistroRUT
        informacionLegalCliente.numeroIdentificacion = dsFactura.InfoCliente(0).informacionLegalClienteNumeroIdentificacion
        informacionLegalCliente.numeroIdentificacionDV = dsFactura.InfoCliente(0).ClienteNumeroIdentificacionDV
        informacionLegalCliente.numeroMatriculaMercantil = dsFactura.InfoCliente(0).ClienteNumeroMatriculaMercantil
        informacionLegalCliente.prefijoFacturacion = dsFactura.InfoCliente(0).ClientePrefijoFacturacion
        informacionLegalCliente.tipoIdentificacion = dsFactura.InfoCliente(0).informacionLegalClienteTipoIdentificacion
        cliente.informacionLegalCliente = informacionLegalCliente

        cliente.nombreComercial = dsFactura.InfoCliente(0).clienteNombreComercial
        cliente.nombreContacto = dsFactura.InfoCliente(0).clienteNombreContacto
        cliente.nombreRazonSocial = dsFactura.InfoCliente(0).clienteNombreRazonSocial
        cliente.nota = dsFactura.InfoCliente(0).clienteNota
        cliente.notificar = dsFactura.InfoCliente(0).clienteNotificar
        cliente.numeroDocumento = dsFactura.InfoCliente(0).clienteNumeroDocumento
        cliente.numeroIdentificacionDV = dsFactura.InfoCliente(0).ClienteNumeroIdentificacionDV


        'Obligaciones  ' Que es esto de Obligaciones?
        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 2, 4"
        LlenaDataSetGenerico(dsFactura.Obligaciones, "Obligaciones", strSQL, strConeccionDB)

        If dsFactura.Obligaciones.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorObligaciones As dsConsultaFactura.ObligacionesRow

            ReDim cliente.responsabilidadesRut(dsFactura.Obligaciones.Rows.Count - 1)

            For Each CursorObligaciones In dsFactura.Obligaciones

                Dim Obligaciones As New ServicioEmi.Obligaciones()
                Obligaciones.obligaciones = CursorObligaciones.obligaciones
                Obligaciones.regimen = CursorObligaciones.regimen
                cliente.responsabilidadesRut(i) = Obligaciones

                i = i + 1
            Next
        End If

        cliente.segundoNombre = dsFactura.InfoCliente(0).clienteSegundoNombre
        cliente.telefax = dsFactura.InfoCliente(0).clienteTelefax
        cliente.telefono = dsFactura.InfoCliente(0).clienteTelefono
        cliente.tipoIdentificacion = dsFactura.InfoCliente(0).clienteTipoIdentificacion
        cliente.tipoPersona = dsFactura.InfoCliente(0).clienteTipoPersona

        DocNotaCredito.cliente = cliente

#End Region

#Region "Documentos Referenciados"

        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 7"
        LlenaDataSetGenerico(dsFactura.InfoDocumentosReferenciados, "InfoDocumentosReferenciados", strSQL, strConeccionDB)

        If dsFactura.InfoDocumentosReferenciados.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDocumentosRef As dsConsultaFactura.InfoDocumentosReferenciadosRow

            ReDim DocNotaCredito.documentosReferenciados(dsFactura.InfoDocumentosReferenciados.Rows.Count - 1)

            For Each CursorDocumentosRef In dsFactura.InfoDocumentosReferenciados

                Dim documentosRef As New ServicioEmi.DocumentoReferenciado()
                documentosRef.codigoEstatusDocumento = CursorDocumentosRef.codigoEstatusDocumento
                documentosRef.codigoInterno = CursorDocumentosRef.codigoInterno
                documentosRef.cufeDocReferenciado = CursorDocumentosRef.cufeDocReferenciado
                documentosRef.descripcion = Split(CursorDocumentosRef.descripcion, "¬")
                documentosRef.fecha = CDate(CursorDocumentosRef.fecha).ToString(FormatoFecha)
                documentosRef.fechaFinValidez = CursorDocumentosRef.fechaFinValidez
                documentosRef.fechaInicioValidez = CursorDocumentosRef.fechaInicioValidez
                documentosRef.numeroDocumento = CursorDocumentosRef.numeroDocumento
                documentosRef.tipoCUFE = CursorDocumentosRef.tipoCUFE
                documentosRef.tipoDocumento = CursorDocumentosRef.tipoDocumento
                documentosRef.tipoDocumentoCodigo = CursorDocumentosRef.tipoDocumento

                DocNotaCredito.documentosReferenciados(i) = documentosRef

                i = i + 1
            Next
        End If

#End Region

        ' Que son extras?
#Region "Extras"

        DocNotaCredito.extras = Nothing

#End Region

#Region "Impuestos Generales"

        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 3"
        LlenaDataSetGenerico(dsFactura.InfoImpuestos, "InfoImpuestos", strSQL, strConeccionDB)

        If dsFactura.InfoImpuestos.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorImpuestosGrls As dsConsultaFactura.InfoImpuestosRow

            ReDim DocNotaCredito.impuestosGenerales(dsFactura.InfoImpuestos.Rows.Count - 1)

            For Each CursorImpuestosGrls In dsFactura.InfoImpuestos

                Dim impuestoGeneral1 As ServicioEmi.FacturaImpuestos = New ServicioEmi.FacturaImpuestos()

                impuestoGeneral1.baseImponibleTOTALImp = CDec(CursorImpuestosGrls.impuestoGeneral1BaseImponibleTOTALImp).ToString(FormatoDecimal)
                impuestoGeneral1.codigoTOTALImp = CursorImpuestosGrls.impuestoGeneral1CodigoTOTALImp
                impuestoGeneral1.controlInterno = CursorImpuestosGrls.impuestoGeneral1ControlInterno
                impuestoGeneral1.porcentajeTOTALImp = If(CursorImpuestosGrls.Flag3Decimales = 1, CDec(CursorImpuestosGrls.impuestoGeneral1PorcentajeTOTALImp).ToString("####0.000"), CDec(CursorImpuestosGrls.impuestoGeneral1PorcentajeTOTALImp).ToString(FormatoDecimal))
                impuestoGeneral1.unidadMedida = CursorImpuestosGrls.impuestoGeneral1UnidadMedida
                impuestoGeneral1.unidadMedidaTributo = CursorImpuestosGrls.impuestoGeneral1UnidadMedidaTributo
                impuestoGeneral1.valorTOTALImp = CDec(CursorImpuestosGrls.impuestoGeneral1ValorTOTALImp).ToString(FormatoDecimal)
                impuestoGeneral1.valorTributoUnidad = CursorImpuestosGrls.impuestoGeneral1ValorTributoUnidad
                DocNotaCredito.impuestosGenerales(i) = impuestoGeneral1

                i = i + 1
            Next

        End If

#End Region

        ' Que diferencia tiene con Impuestos Generales
#Region "Impuestos Totales"

        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 6"
        LlenaDataSetGenerico(dsFactura.InfoImpuestosTotales, "InfoImpuestosTotales", strSQL, strConeccionDB)

        If dsFactura.InfoImpuestosTotales.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorInfoImpuestosTotales As dsConsultaFactura.InfoImpuestosTotalesRow

            ReDim DocNotaCredito.impuestosTotales(dsFactura.InfoImpuestosTotales.Rows.Count - 1)

            For Each CursorInfoImpuestosTotales In dsFactura.InfoImpuestosTotales

                Dim impuestoTotal As ServicioEmi.ImpuestosTotales = New ServicioEmi.ImpuestosTotales()

                impuestoTotal.montoTotal = CDec(CursorInfoImpuestosTotales.montoTotal).ToString(FormatoDecimal)
                impuestoTotal.codigoTOTALImp = CursorInfoImpuestosTotales.codigoTOTALImp
                DocNotaCredito.impuestosTotales(i) = impuestoTotal

                i = i + 1
            Next

        End If

#End Region


        ' Como se llena?
#Region "Medios de Pago"

        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 4"
        LlenaDataSetGenerico(dsFactura.InfoMediosPago, "InfoMediosPago", strSQL, strConeccionDB)

        If dsFactura.InfoMediosPago.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorInfoMediosPago As dsConsultaFactura.InfoMediosPagoRow

            ReDim DocNotaCredito.mediosDePago(dsFactura.InfoMediosPago.Rows.Count - 1)

            For Each CursorInfoMediosPago In dsFactura.InfoMediosPago

                Dim medioPago1 As ServicioEmi.MediosDePago = New ServicioEmi.MediosDePago()

                medioPago1.codigoBanco = CursorInfoMediosPago.medioPagoCodigoBanco
                medioPago1.codigoCanalPago = CursorInfoMediosPago.medioPagoCodigoCanalPago
                medioPago1.codigoReferencia = CursorInfoMediosPago.medioPagoCodigoReferencia
                medioPago1.fechaDeVencimiento = CDate(CursorInfoMediosPago.medioPagoFechaDeVencimiento).ToString(FormatoFecha)
                medioPago1.medioPago = CursorInfoMediosPago.medioPagoMedioPago
                medioPago1.metodoDePago = CursorInfoMediosPago.medioPago1MetodoDePago
                medioPago1.nombreBanco = CursorInfoMediosPago.medioPagoNombreBanco
                medioPago1.numeroDeReferencia = CursorInfoMediosPago.medioPagoNumeroDeReferencia
                medioPago1.numeroDias = CursorInfoMediosPago.medioPagoNumeroDias
                medioPago1.numeroTransferencia = CursorInfoMediosPago.medioPagoNumeroTransferencia
                DocNotaCredito.mediosDePago(i) = medioPago1

                i = i + 1
            Next

        End If


#End Region

#Region "Detalle De Factura"


        strSQL = "exec GetInfoNotaCredito " & prmID.ToString & ", 5"
        LlenaDataSetGenerico(dsFactura.InfoDetallesFactura, "InfoDetallesFactura", strSQL, strConeccionDB)

        If dsFactura.InfoDetallesFactura.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDetalles As dsConsultaFactura.InfoDetallesFacturaRow

            ReDim DocNotaCredito.detalleDeFactura(dsFactura.InfoDetallesFactura.Rows.Count - 1)

            For Each CursorDetalles In dsFactura.InfoDetallesFactura

                Dim producto1 As New ServicioEmi.FacturaDetalle()
                producto1.cantidadPorEmpaque = CursorDetalles.cantidadPorEmpaque
                producto1.cantidadReal = CInt(CursorDetalles.cantidadReal)
                producto1.cantidadRealUnidadMedida = CursorDetalles.cantidadRealUnidadMedida
                producto1.cantidadUnidades = CInt(CursorDetalles.cantidadUnidades)
                producto1.codigoFabricante = CursorDetalles.codigoFabricante 'Nothing
                producto1.codigoIdentificadorPais = Nothing
                producto1.codigoProducto = CursorDetalles.codigoProducto
                producto1.codigoTipoPrecio = CursorDetalles.codigoTipoPrecio ' Nothing
                producto1.descripcion = CursorDetalles.descripcion
                producto1.descripcionTecnica = CursorDetalles.descripcionTecnica
                producto1.documentosReferenciados = Nothing
                producto1.estandarCodigo = CursorDetalles.estandarCodigo
                producto1.estandarCodigoID = CursorDetalles.estandarCodigoID ' Nothing
                producto1.estandarCodigoIdentificador = CursorDetalles.estandarCodigoIdentificador ' Nothing
                producto1.estandarCodigoNombre = CursorDetalles.estandarCodigoNombre
                producto1.estandarCodigoProducto = CursorDetalles.estandarCodigoProducto
                producto1.estandarOrganizacion = CursorDetalles.estandarOrganizacion
                producto1.estandarSubCodigoProducto = CursorDetalles.estandarSubCodigoProducto

                ReDim producto1.impuestosDetalles(0)
                Dim impuesto1 As ServicioEmi.FacturaImpuestos = New ServicioEmi.FacturaImpuestos()
                impuesto1.baseImponibleTOTALImp = CDec(CursorDetalles.impuesto1_baseImponibleTOTALImp).ToString(FormatoDecimal)
                impuesto1.codigoTOTALImp = CursorDetalles.impuesto1_codigoTOTALImp
                impuesto1.controlInterno = CursorDetalles.impuesto1_controlInterno
                impuesto1.porcentajeTOTALImp = CDec(CursorDetalles.impuesto1_porcentajeTOTALImp).ToString(FormatoDecimal)
                impuesto1.unidadMedida = CursorDetalles.impuesto1_unidadMedida
                impuesto1.unidadMedidaTributo = CursorDetalles.impuesto1_unidadMedidaTributo
                impuesto1.valorTOTALImp = CDec(CursorDetalles.impuesto1_valorTOTALImp).ToString(FormatoDecimal)
                impuesto1.valorTributoUnidad = CursorDetalles.impuesto1_valorTributoUnidad
                producto1.impuestosDetalles(0) = impuesto1

                ReDim producto1.impuestosTotales(0)
                Dim impuestoTOTAL1 As ServicioEmi.ImpuestosTotales = New ServicioEmi.ImpuestosTotales
                impuestoTOTAL1.codigoTOTALImp = CursorDetalles.impuesto1_codigoTOTALImp
                impuestoTOTAL1.montoTotal = CDec(CursorDetalles.impuesto1_valorTOTALImp).ToString(FormatoDecimal)
                producto1.impuestosTotales(0) = impuestoTOTAL1

                producto1.informacionAdicional = Nothing
                producto1.mandatorioNumeroIdentificacion = Nothing
                producto1.mandatorioNumeroIdentificacionDV = Nothing
                producto1.mandatorioTipoIdentificacion = Nothing
                producto1.marca = CursorDetalles.marca
                producto1.modelo = Nothing
                producto1.muestraGratis = "0"
                producto1.nombreFabricante = Nothing
                producto1.nota = Nothing
                producto1.precioReferencia = Nothing
                producto1.precioTotal = CDec(CursorDetalles.precioTotal).ToString(FormatoDecimal)
                producto1.precioTotalSinImpuestos = CDec(CursorDetalles.precioTotalSinImpuestos).ToString(FormatoDecimal)
                producto1.precioVentaUnitario = CDec(CursorDetalles.precioVentaUnitario).ToString(FormatoDecimal)
                producto1.secuencia = CursorDetalles.secuencia
                producto1.seriales = Nothing
                producto1.subCodigoFabricante = Nothing
                producto1.subCodigoProducto = Nothing
                producto1.tipoAIU = Nothing
                producto1.unidadMedida = CursorDetalles.unidadMedida


                'CargosDescuentos
                If CursorDetalles.porcentaje <> 0 Then
                    producto1.cargosDescuentos(0) = New ServicioEmi.CargosDescuentos
                    Dim cargosDescuentos As ServicioEmi.CargosDescuentos = New ServicioEmi.CargosDescuentos
                    cargosDescuentos.codigo = CursorDetalles.codigoDescuento
                    cargosDescuentos.descripcion = CursorDetalles.descripcionDescuento
                    cargosDescuentos.indicador = CursorDetalles.indicadorDescuento
                    cargosDescuentos.monto = CursorDetalles.montoDescuento
                    cargosDescuentos.montoBase = CursorDetalles.montoBaseDescuento
                    cargosDescuentos.porcentaje = CursorDetalles.porcentaje
                    producto1.cargosDescuentos(0) = cargosDescuentos
                End If


                DocNotaCredito.detalleDeFactura(i) = producto1
                i = i + 1
            Next
        End If


#End Region


        Return DocNotaCredito

    End Function

    Public Function GeneraFileNotaDebitoFactory(prmID As Integer, prmCodConsecutivoDocumento As Integer, prmPrefijo As String, prmConsDesde As Integer, Optional prmNumDecimales As Integer = 2) As ServicioEmi.FacturaGeneral
        Dim tmpstrPath As String = ""

        Dim strSQL As String = ""
        Dim dsFactura As New dsConsultaFactura
        On Error Resume Next


        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 1"
        LlenaDataSetGenerico(dsFactura.InfoGeneral, "InfoGeneral", strSQL, strConeccionDB)

        Dim DocNotaCredito As New ServicioEmi.FacturaGeneral

        DocNotaCredito.cantidadDecimales = prmNumDecimales
        DocNotaCredito.consecutivoDocumento = dsFactura.InfoGeneral(0).consecutivoDocumento
        DocNotaCredito.fechaEmision = dsFactura.InfoGeneral(0).fechaEmision
        DocNotaCredito.fechaFinPeriodoFacturacion = dsFactura.InfoGeneral(0).fechaFinPeriodoFacturacion
        DocNotaCredito.fechaInicioPeriodoFacturacion = dsFactura.InfoGeneral(0).fechaInicioPeriodoFacturacion
        DocNotaCredito.fechaPagoImpuestos = dsFactura.InfoGeneral(0).fechaPagoImpuestos
        DocNotaCredito.fechaVencimiento = dsFactura.InfoGeneral(0).fechaVencimiento
        DocNotaCredito.cantidadDecimales = dsFactura.InfoGeneral(0).cantidadDecimales
        DocNotaCredito.moneda = dsFactura.InfoGeneral(0).moneda
        DocNotaCredito.propina = dsFactura.InfoGeneral(0).propina
        DocNotaCredito.rangoNumeracion = dsFactura.InfoGeneral(0).rangoNumeracion
        DocNotaCredito.redondeoAplicado = dsFactura.InfoGeneral(0).redondeoAplicado
        DocNotaCredito.tipoDocumento = dsFactura.InfoGeneral(0).tipoDocumento
        DocNotaCredito.tipoOperacion = dsFactura.InfoGeneral(0).tipoOperacion
        DocNotaCredito.totalAnticipos = CDec(dsFactura.InfoGeneral(0).totalAnticipos).ToString(FormatoDecimal)
        DocNotaCredito.totalBaseImponible = CDec(dsFactura.InfoGeneral(0).totalBaseImponible).ToString(FormatoDecimal)
        DocNotaCredito.totalBrutoConImpuesto = CDec(dsFactura.InfoGeneral(0).totalBrutoConImpuesto).ToString(FormatoDecimal)
        DocNotaCredito.totalCargosAplicados = dsFactura.InfoGeneral(0).totalCargosAplicados
        DocNotaCredito.totalDescuentos = CDec(dsFactura.InfoGeneral(0).totalDescuentos).ToString(FormatoDecimal)
        DocNotaCredito.totalMonto = CDec(dsFactura.InfoGeneral(0).totalMonto).ToString(FormatoDecimal)
        DocNotaCredito.totalProductos = dsFactura.InfoGeneral(0).totalProductos
        DocNotaCredito.totalSinImpuestos = CDec(dsFactura.InfoGeneral(0).totalSinImpuestos).ToString(FormatoDecimal)


#Region "INFO CLIENTE"

        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 2"
        LlenaDataSetGenerico(dsFactura.InfoCliente, "InfoCliente", strSQL, strConeccionDB)

        Dim cliente As New ServicioEmi.Cliente()
        cliente.apellido = dsFactura.InfoCliente(0).apellido

        'Destinatario
        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 2, 1"
        LlenaDataSetGenerico(dsFactura.InfoDestinatario, "InfoDestinatario", strSQL, strConeccionDB)

        If dsFactura.InfoDestinatario.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDestinatario As dsConsultaFactura.InfoDestinatarioRow

            ReDim cliente.destinatario(dsFactura.InfoDestinatario.Rows.Count - 1)

            For Each CursorDestinatario In dsFactura.InfoDestinatario

                Dim destinatario As New ServicioEmi.Destinatario()
                destinatario.canalDeEntrega = CursorDestinatario.canalDeEntrega
                destinatario.email = Split(Replace(CursorDestinatario.eMail, " ", ""), ",")
                destinatario.fechaProgramada = CursorDestinatario.fechaProgramada
                destinatario.mensajePersonalizado = CursorDestinatario.mensajePersonalizado
                destinatario.nitProveedorReceptor = CursorDestinatario.nitProveedorReceptor
                destinatario.telefono = CursorDestinatario.telefono
                cliente.destinatario(i) = destinatario

                i = i + 1
            Next
        End If


        'Detalles Tributarios  ' Que es esto de Detalles Tributarios?
        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 2, 3"
        LlenaDataSetGenerico(dsFactura.DetallesTributarios, "DetallesTributarios", strSQL, strConeccionDB)

        If dsFactura.DetallesTributarios.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDetallesTributarios As dsConsultaFactura.DetallesTributariosRow

            ReDim cliente.detallesTributarios(dsFactura.DetallesTributarios.Rows.Count - 1)

            For Each CursorDetallesTributarios In dsFactura.DetallesTributarios

                Dim detallesTributarios As New ServicioEmi.Tributos()
                detallesTributarios.codigoImpuesto = CursorDetallesTributarios.codigoImpuesto
                cliente.detallesTributarios(i) = detallesTributarios

                i = i + 1
            Next
        End If


        Dim correoEntrega(1) As String
        correoEntrega(0) = dsFactura.InfoCliente(0).destinatario1Email

        Dim direccionFiscal As New ServicioEmi.Direccion()
        direccionFiscal.aCuidadoDe = dsFactura.InfoCliente(0).direccionFiscalCuidadoDe
        direccionFiscal.aLaAtencionDe = dsFactura.InfoCliente(0).direccionFiscalAaLaAtencionDe
        direccionFiscal.bloque = dsFactura.InfoCliente(0).direccionFiscalBloque
        direccionFiscal.buzon = dsFactura.InfoCliente(0).direccionFiscalBuzon
        direccionFiscal.calle = dsFactura.InfoCliente(0).direccionFiscalCalle
        direccionFiscal.calleAdicional = dsFactura.InfoCliente(0).direccionFiscalCalleAdicional
        direccionFiscal.ciudad = dsFactura.InfoCliente(0).direccionFiscalCiudad
        direccionFiscal.codigoDepartamento = dsFactura.InfoCliente(0).direccionFiscalCodigoDepartamento
        direccionFiscal.correccionHusoHorario = dsFactura.InfoCliente(0).direccionFiscalCorreccionHusoHorario
        direccionFiscal.departamento = dsFactura.InfoCliente(0).direccionFiscalDepartamento
        direccionFiscal.departamentoOrg = dsFactura.InfoCliente(0).direccionFiscalDepartamentoOrg
        direccionFiscal.direccion = dsFactura.InfoCliente(0).direccionFiscalDireccion
        direccionFiscal.distrito = dsFactura.InfoCliente(0).direccionFiscalDistrito
        direccionFiscal.habitacion = dsFactura.InfoCliente(0).direccionFiscalHabitacion
        direccionFiscal.lenguaje = dsFactura.InfoCliente(0).direccionFiscalLenguaje
        direccionFiscal.localizacion = Nothing
        direccionFiscal.municipio = dsFactura.InfoCliente(0).direccionFiscalMunicipio
        direccionFiscal.nombreEdificio = dsFactura.InfoCliente(0).direccionFiscalNombreEdificio
        direccionFiscal.numeroEdificio = dsFactura.InfoCliente(0).direccionFiscalNumeroEdificio
        direccionFiscal.numeroParcela = dsFactura.InfoCliente(0).direccionFiscalNumeroParcela
        direccionFiscal.pais = dsFactura.InfoCliente(0).direccionFiscalPais
        direccionFiscal.piso = dsFactura.InfoCliente(0).direccionFiscalPiso
        direccionFiscal.region = dsFactura.InfoCliente(0).direccionFiscalRegion
        direccionFiscal.subDivision = dsFactura.InfoCliente(0).direccionFiscalSubDivision
        direccionFiscal.ubicacion = dsFactura.InfoCliente(0).direccionFiscalUbicacion
        direccionFiscal.zonaPostal = dsFactura.InfoCliente(0).direccionFiscalZonaPostal
        cliente.direccionFiscal = direccionFiscal


        cliente.email = dsFactura.InfoCliente(0).clienteeEmail
        cliente.extras = Nothing

        Dim informacionLegalCliente As New ServicioEmi.InformacionLegal()
        informacionLegalCliente.codigoEstablecimiento = dsFactura.InfoCliente(0).informacionLegalClienteCodigoEstablecimiento
        informacionLegalCliente.nombreRegistroRUT = dsFactura.InfoCliente(0).informacionLegalClienteNombreRegistroRUT
        informacionLegalCliente.numeroIdentificacion = dsFactura.InfoCliente(0).informacionLegalClienteNumeroIdentificacion
        informacionLegalCliente.numeroIdentificacionDV = dsFactura.InfoCliente(0).ClienteNumeroIdentificacionDV
        informacionLegalCliente.numeroMatriculaMercantil = dsFactura.InfoCliente(0).ClienteNumeroMatriculaMercantil
        informacionLegalCliente.prefijoFacturacion = dsFactura.InfoCliente(0).ClientePrefijoFacturacion
        informacionLegalCliente.tipoIdentificacion = dsFactura.InfoCliente(0).informacionLegalClienteTipoIdentificacion
        cliente.informacionLegalCliente = informacionLegalCliente

        cliente.nombreComercial = dsFactura.InfoCliente(0).clienteNombreComercial
        cliente.nombreContacto = dsFactura.InfoCliente(0).clienteNombreContacto
        cliente.nombreRazonSocial = dsFactura.InfoCliente(0).clienteNombreRazonSocial
        cliente.nota = dsFactura.InfoCliente(0).clienteNota
        cliente.notificar = dsFactura.InfoCliente(0).clienteNotificar
        cliente.numeroDocumento = dsFactura.InfoCliente(0).clienteNumeroDocumento
        cliente.numeroIdentificacionDV = dsFactura.InfoCliente(0).ClienteNumeroIdentificacionDV


        'Obligaciones  ' Que es esto de Obligaciones?
        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 2, 4"
        LlenaDataSetGenerico(dsFactura.Obligaciones, "Obligaciones", strSQL, strConeccionDB)

        If dsFactura.Obligaciones.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorObligaciones As dsConsultaFactura.ObligacionesRow

            ReDim cliente.responsabilidadesRut(dsFactura.Obligaciones.Rows.Count - 1)

            For Each CursorObligaciones In dsFactura.Obligaciones

                Dim Obligaciones As New ServicioEmi.Obligaciones()
                Obligaciones.obligaciones = CursorObligaciones.obligaciones
                Obligaciones.regimen = CursorObligaciones.regimen
                cliente.responsabilidadesRut(i) = Obligaciones

                i = i + 1
            Next
        End If

        cliente.segundoNombre = dsFactura.InfoCliente(0).clienteSegundoNombre
        cliente.telefax = dsFactura.InfoCliente(0).clienteTelefax
        cliente.telefono = dsFactura.InfoCliente(0).clienteTelefono
        cliente.tipoIdentificacion = dsFactura.InfoCliente(0).clienteTipoIdentificacion
        cliente.tipoPersona = dsFactura.InfoCliente(0).clienteTipoPersona

        DocNotaCredito.cliente = cliente

#End Region

#Region "Documentos Referenciados"

        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 7"
        LlenaDataSetGenerico(dsFactura.InfoDocumentosReferenciados, "InfoDocumentosReferenciados", strSQL, strConeccionDB)

        If dsFactura.InfoDocumentosReferenciados.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDocumentosRef As dsConsultaFactura.InfoDocumentosReferenciadosRow

            ReDim DocNotaCredito.documentosReferenciados(dsFactura.InfoDocumentosReferenciados.Rows.Count - 1)

            For Each CursorDocumentosRef In dsFactura.InfoDocumentosReferenciados

                Dim documentosRef As New ServicioEmi.DocumentoReferenciado()
                documentosRef.codigoEstatusDocumento = CursorDocumentosRef.codigoEstatusDocumento
                documentosRef.codigoInterno = CursorDocumentosRef.codigoInterno
                documentosRef.cufeDocReferenciado = CursorDocumentosRef.cufeDocReferenciado
                documentosRef.descripcion = Split(CursorDocumentosRef.descripcion, "¬")
                documentosRef.fecha = CDate(CursorDocumentosRef.fecha).ToString(FormatoFecha)
                documentosRef.fechaFinValidez = CursorDocumentosRef.fechaFinValidez
                documentosRef.fechaInicioValidez = CursorDocumentosRef.fechaInicioValidez
                documentosRef.numeroDocumento = CursorDocumentosRef.numeroDocumento
                documentosRef.tipoCUFE = CursorDocumentosRef.tipoCUFE
                documentosRef.tipoDocumento = CursorDocumentosRef.tipoDocumento
                documentosRef.tipoDocumentoCodigo = CursorDocumentosRef.tipoDocumento

                DocNotaCredito.documentosReferenciados(i) = documentosRef

                i = i + 1
            Next
        End If

#End Region

        ' Que son extras?
#Region "Extras"

        DocNotaCredito.extras = Nothing

#End Region

#Region "Impuestos Generales"

        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 3"
        LlenaDataSetGenerico(dsFactura.InfoImpuestos, "InfoImpuestos", strSQL, strConeccionDB)

        If dsFactura.InfoImpuestos.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorImpuestosGrls As dsConsultaFactura.InfoImpuestosRow

            ReDim DocNotaCredito.impuestosGenerales(dsFactura.InfoImpuestos.Rows.Count - 1)

            For Each CursorImpuestosGrls In dsFactura.InfoImpuestos

                Dim impuestoGeneral1 As ServicioEmi.FacturaImpuestos = New ServicioEmi.FacturaImpuestos()

                impuestoGeneral1.baseImponibleTOTALImp = CDec(CursorImpuestosGrls.impuestoGeneral1BaseImponibleTOTALImp).ToString(FormatoDecimal)
                impuestoGeneral1.codigoTOTALImp = CursorImpuestosGrls.impuestoGeneral1CodigoTOTALImp
                impuestoGeneral1.controlInterno = CursorImpuestosGrls.impuestoGeneral1ControlInterno
                impuestoGeneral1.porcentajeTOTALImp = If(CursorImpuestosGrls.Flag3Decimales = 1, CDec(CursorImpuestosGrls.impuestoGeneral1PorcentajeTOTALImp).ToString("####0.000"), CDec(CursorImpuestosGrls.impuestoGeneral1PorcentajeTOTALImp).ToString(FormatoDecimal))
                impuestoGeneral1.unidadMedida = CursorImpuestosGrls.impuestoGeneral1UnidadMedida
                impuestoGeneral1.unidadMedidaTributo = CursorImpuestosGrls.impuestoGeneral1UnidadMedidaTributo
                impuestoGeneral1.valorTOTALImp = CDec(CursorImpuestosGrls.impuestoGeneral1ValorTOTALImp).ToString(FormatoDecimal)
                impuestoGeneral1.valorTributoUnidad = CursorImpuestosGrls.impuestoGeneral1ValorTributoUnidad
                DocNotaCredito.impuestosGenerales(i) = impuestoGeneral1

                i = i + 1
            Next

        End If

#End Region

        ' Que diferencia tiene con Impuestos Generales
#Region "Impuestos Totales"

        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 6"
        LlenaDataSetGenerico(dsFactura.InfoImpuestosTotales, "InfoImpuestosTotales", strSQL, strConeccionDB)

        If dsFactura.InfoImpuestosTotales.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorInfoImpuestosTotales As dsConsultaFactura.InfoImpuestosTotalesRow

            ReDim DocNotaCredito.impuestosTotales(dsFactura.InfoImpuestosTotales.Rows.Count - 1)

            For Each CursorInfoImpuestosTotales In dsFactura.InfoImpuestosTotales

                Dim impuestoTotal As ServicioEmi.ImpuestosTotales = New ServicioEmi.ImpuestosTotales()

                impuestoTotal.montoTotal = CDec(CursorInfoImpuestosTotales.montoTotal).ToString(FormatoDecimal)
                impuestoTotal.codigoTOTALImp = CursorInfoImpuestosTotales.codigoTOTALImp
                DocNotaCredito.impuestosTotales(i) = impuestoTotal

                i = i + 1
            Next

        End If

#End Region


        ' Como se llena?
#Region "Medios de Pago"

        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 4"
        LlenaDataSetGenerico(dsFactura.InfoMediosPago, "InfoMediosPago", strSQL, strConeccionDB)

        If dsFactura.InfoMediosPago.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorInfoMediosPago As dsConsultaFactura.InfoMediosPagoRow

            ReDim DocNotaCredito.mediosDePago(dsFactura.InfoMediosPago.Rows.Count - 1)

            For Each CursorInfoMediosPago In dsFactura.InfoMediosPago

                Dim medioPago1 As ServicioEmi.MediosDePago = New ServicioEmi.MediosDePago()

                medioPago1.codigoBanco = CursorInfoMediosPago.medioPagoCodigoBanco
                medioPago1.codigoCanalPago = CursorInfoMediosPago.medioPagoCodigoCanalPago
                medioPago1.codigoReferencia = CursorInfoMediosPago.medioPagoCodigoReferencia
                medioPago1.fechaDeVencimiento = CDate(CursorInfoMediosPago.medioPagoFechaDeVencimiento).ToString(FormatoFecha)
                medioPago1.medioPago = CursorInfoMediosPago.medioPagoMedioPago
                medioPago1.metodoDePago = CursorInfoMediosPago.medioPago1MetodoDePago
                medioPago1.nombreBanco = CursorInfoMediosPago.medioPagoNombreBanco
                medioPago1.numeroDeReferencia = CursorInfoMediosPago.medioPagoNumeroDeReferencia
                medioPago1.numeroDias = CursorInfoMediosPago.medioPagoNumeroDias
                medioPago1.numeroTransferencia = CursorInfoMediosPago.medioPagoNumeroTransferencia
                DocNotaCredito.mediosDePago(i) = medioPago1

                i = i + 1
            Next

        End If


#End Region

#Region "Detalle De Factura"


        strSQL = "exec GetInfoNotaDebito " & prmID.ToString & ", 5"
        LlenaDataSetGenerico(dsFactura.InfoDetallesFactura, "InfoDetallesFactura", strSQL, strConeccionDB)

        If dsFactura.InfoDetallesFactura.Rows.Count > 0 Then

            Dim i As Integer = 0
            Dim CursorDetalles As dsConsultaFactura.InfoDetallesFacturaRow

            ReDim DocNotaCredito.detalleDeFactura(dsFactura.InfoDetallesFactura.Rows.Count - 1)

            For Each CursorDetalles In dsFactura.InfoDetallesFactura

                Dim producto1 As New ServicioEmi.FacturaDetalle()
                producto1.cantidadPorEmpaque = CursorDetalles.cantidadPorEmpaque
                producto1.cantidadReal = CInt(CursorDetalles.cantidadReal)
                producto1.cantidadRealUnidadMedida = CursorDetalles.cantidadRealUnidadMedida
                producto1.cantidadUnidades = CInt(CursorDetalles.cantidadUnidades)
                producto1.codigoFabricante = CursorDetalles.codigoFabricante 'Nothing
                producto1.codigoIdentificadorPais = Nothing
                producto1.codigoProducto = CursorDetalles.codigoProducto
                producto1.codigoTipoPrecio = CursorDetalles.codigoTipoPrecio ' Nothing
                producto1.descripcion = CursorDetalles.descripcion
                producto1.descripcionTecnica = CursorDetalles.descripcionTecnica
                producto1.documentosReferenciados = Nothing
                producto1.estandarCodigo = CursorDetalles.estandarCodigo
                producto1.estandarCodigoID = CursorDetalles.estandarCodigoID ' Nothing
                producto1.estandarCodigoIdentificador = CursorDetalles.estandarCodigoIdentificador ' Nothing
                producto1.estandarCodigoNombre = CursorDetalles.estandarCodigoNombre
                producto1.estandarCodigoProducto = CursorDetalles.estandarCodigoProducto
                producto1.estandarOrganizacion = CursorDetalles.estandarOrganizacion
                producto1.estandarSubCodigoProducto = CursorDetalles.estandarSubCodigoProducto

                ReDim producto1.impuestosDetalles(0)
                Dim impuesto1 As ServicioEmi.FacturaImpuestos = New ServicioEmi.FacturaImpuestos()
                impuesto1.baseImponibleTOTALImp = CDec(CursorDetalles.impuesto1_baseImponibleTOTALImp).ToString(FormatoDecimal)
                impuesto1.codigoTOTALImp = CursorDetalles.impuesto1_codigoTOTALImp
                impuesto1.controlInterno = CursorDetalles.impuesto1_controlInterno
                impuesto1.porcentajeTOTALImp = CDec(CursorDetalles.impuesto1_porcentajeTOTALImp).ToString(FormatoDecimal)
                impuesto1.unidadMedida = CursorDetalles.impuesto1_unidadMedida
                impuesto1.unidadMedidaTributo = CursorDetalles.impuesto1_unidadMedidaTributo
                impuesto1.valorTOTALImp = CDec(CursorDetalles.impuesto1_valorTOTALImp).ToString(FormatoDecimal)
                impuesto1.valorTributoUnidad = CursorDetalles.impuesto1_valorTributoUnidad
                producto1.impuestosDetalles(0) = impuesto1

                ReDim producto1.impuestosTotales(0)
                Dim impuestoTOTAL1 As ServicioEmi.ImpuestosTotales = New ServicioEmi.ImpuestosTotales
                impuestoTOTAL1.codigoTOTALImp = CursorDetalles.impuesto1_codigoTOTALImp
                impuestoTOTAL1.montoTotal = CDec(CursorDetalles.impuesto1_valorTOTALImp).ToString(FormatoDecimal)
                producto1.impuestosTotales(0) = impuestoTOTAL1

                producto1.informacionAdicional = Nothing
                producto1.mandatorioNumeroIdentificacion = Nothing
                producto1.mandatorioNumeroIdentificacionDV = Nothing
                producto1.mandatorioTipoIdentificacion = Nothing
                producto1.marca = CursorDetalles.marca
                producto1.modelo = Nothing
                producto1.muestraGratis = "0"
                producto1.nombreFabricante = Nothing
                producto1.nota = Nothing
                producto1.precioReferencia = Nothing
                producto1.precioTotal = CDec(CursorDetalles.precioTotal).ToString(FormatoDecimal)
                producto1.precioTotalSinImpuestos = CDec(CursorDetalles.precioTotalSinImpuestos).ToString(FormatoDecimal)
                producto1.precioVentaUnitario = CDec(CursorDetalles.precioVentaUnitario).ToString(FormatoDecimal)
                producto1.secuencia = CursorDetalles.secuencia
                producto1.seriales = Nothing
                producto1.subCodigoFabricante = Nothing
                producto1.subCodigoProducto = Nothing
                producto1.tipoAIU = Nothing
                producto1.unidadMedida = CursorDetalles.unidadMedida


                'CargosDescuentos
                If CursorDetalles.porcentaje <> 0 Then
                    producto1.cargosDescuentos(0) = New ServicioEmi.CargosDescuentos
                    Dim cargosDescuentos As ServicioEmi.CargosDescuentos = New ServicioEmi.CargosDescuentos
                    cargosDescuentos.codigo = CursorDetalles.codigoDescuento
                    cargosDescuentos.descripcion = CursorDetalles.descripcionDescuento
                    cargosDescuentos.indicador = CursorDetalles.indicadorDescuento
                    cargosDescuentos.monto = CursorDetalles.montoDescuento
                    cargosDescuentos.montoBase = CursorDetalles.montoBaseDescuento
                    cargosDescuentos.porcentaje = CursorDetalles.porcentaje
                    producto1.cargosDescuentos(0) = cargosDescuentos
                End If


                DocNotaCredito.detalleDeFactura(i) = producto1
                i = i + 1
            Next
        End If


#End Region


        Return DocNotaCredito

    End Function

    Public Sub LlenaDataSetGenerico(ByVal prmDataTable As DataTable, ByVal prmTablaConsulta As String, Optional ByVal prmStrSQL As String = "", Optional ByVal StringConeccion As String = "", Optional ByVal FlagOrderByNombre As Boolean = False)
        Dim cnn As SqlConnection
        Dim Adaptador As Object
        Dim TablaDataSet As String = prmDataTable.TableName
        Dim tempStrConeccion As String
        On Error GoTo ControlaError

        If StringConeccion.Length > 0 Then
            tempStrConeccion = StringConeccion
        Else
            tempStrConeccion = strConeccionDB
        End If


        cnn = New SqlConnection(tempStrConeccion)
        Dim Comando As New SqlCommand

        Adaptador = New SqlDataAdapter(Comando)


        With Adaptador.SelectCommand
            .Connection = cnn
            If prmStrSQL.Length = 0 Then
                If FlagOrderByNombre Then
                    .CommandText = "SELECT  ID, RTRIM(Nombre) AS Nombre  FROM " & prmTablaConsulta & " ORDER BY Nombre ASC"
                Else
                    .CommandText = "SELECT ID, RTRIM(Nombre) AS Nombre FROM " & prmTablaConsulta
                End If

            Else
                .CommandText = prmStrSQL
            End If

        End With
        Adaptador.TableMappings.Add(prmTablaConsulta, TablaDataSet)
        Adaptador.Fill(prmDataTable)
        Exit Sub
ControlaError:
        Dim strError As String = Err.Description


    End Sub


End Class
