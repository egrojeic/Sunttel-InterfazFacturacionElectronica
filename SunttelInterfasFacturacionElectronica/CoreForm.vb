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
'Imports DemoGenFactura_int_tfhka_fel.ServiceEmision
'Imports DemoGenFactura_int_tfhka_fel.ServiceAdjuntos
Imports System.Xml.Serialization
Imports SunttelDll2007
Imports System.Xml
Imports System.Globalization



Public Class CoreForm

    Dim serviceClientEm As ServicioEmi.ServiceClient
    Dim serviceArchivos As ServicioAdjuntos.ServiceClient

    Dim serviceClientEkomercio As ServicioEkomercio.WSCFDBuilderPlusSoapClient

    Dim objSuperClass As cSuperDBDocMgr
    Dim cnn As cConeccionDB

    Dim Var_EstadoProceso As Integer = 0 ' 0 Detenido, 1 Corriendo
    Dim Var_UltimoMomentoCorrio As Date
    Dim Var_UltimoMomentoCorrioNC As Date

    Dim objDsMgr As cDsMgr

    Public SysFormatoFecha As String = ""



    Private Sub CoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.cmbCompania.DataSource = dsConexiones
        Me.cmbCompania.DisplayMember = "Conections.Compania"
        Me.cmbCompania.ValueMember = "Conections.IDAppParametros"

        Var_UltimoMomentoCorrio = Date.Now.AddDays(-1)
        Var_UltimoMomentoCorrioNC = Date.Now.AddDays(-1)

        EstablecerConfiguracionRegional()

    End Sub

    Public Sub EstablecerConfiguracionRegional()

        Dim StrString As String
        Dim ObjGestiondata As New cGestionData
        Dim tmpIDIdioma As Integer = 0

        StrString = "SELECT @@LangID"

        tmpIDIdioma = ObjGestiondata.GetDatoEscalar(StrString, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)

        SysFormatoFecha = IIf(tmpIDIdioma = 5, "dd/MM/yyyy", "yyyy/MM/dd")

        Dim forceDotCulture As CultureInfo
        forceDotCulture = Application.CurrentCulture.Clone()
        forceDotCulture.DateTimeFormat.DateSeparator = "/"
        forceDotCulture.DateTimeFormat.ShortDatePattern = SysFormatoFecha

        forceDotCulture.DateTimeFormat.AMDesignator = "AM"
        forceDotCulture.DateTimeFormat.PMDesignator = "PM"
        forceDotCulture.DateTimeFormat.LongTimePattern = "HH:mm"
        forceDotCulture.DateTimeFormat.TimeSeparator = ":"

        Application.CurrentCulture = forceDotCulture
    End Sub


    Private Sub CoreForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        'RegistraConfigSys()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim tmpAhora As Date = Now
        Dim tmpMinutes As Integer = 0
        Dim tmpSegundos As Integer = 0
        Dim tmpSegundosFaltan As Integer = 0

        tmpMinutes = FrecuenciaMins.Value - DateAndTime.DateDiff(DateInterval.Minute, Var_UltimoMomentoCorrio, Now)
        tmpSegundos = (FrecuenciaMins.Value * 60) - DateAndTime.DateDiff(DateInterval.Second, Var_UltimoMomentoCorrio, Now)

        tmpSegundosFaltan = 60 + (tmpSegundos - (tmpMinutes * 60))

        tmpMinutes = tmpMinutes - 1

        lblStatus.Text = "Status: Running"
        lblTiempoRestanteNuevoCargue.Text = "Remaining Time for Next Upload (Mins): " & tmpMinutes.ToString & ":" & Strings.Right("00" + tmpSegundosFaltan.ToString, 2)
        lblLastTimeRan.Text = "Last time ran: " & Var_UltimoMomentoCorrio

        Dim tmOKxTiempo As Boolean = False
        Dim tmpCurrentTimeAsMinutes As Integer = 0
        Dim tmpSendTimeAsMinutes As Integer = 0

        tmpSendTimeAsMinutes = (Me.HoraEnvio.Value.Hour * 60) + Me.HoraEnvio.Value.Minute
        tmpCurrentTimeAsMinutes = (Now.Hour * 60) + Now.Minute

        If FlagHoraDiaria.Checked Then
            tmOKxTiempo = (tmpSendTimeAsMinutes < tmpCurrentTimeAsMinutes)
        Else
            tmOKxTiempo = True
        End If

        If tmpMinutes < 0 And chkFacturas.Checked And tmOKxTiempo Then


            lblEjecutando.Text = "Consultando....."

            CreaColaEnvioFacturas()

            lblEjecutando.Text = "Recorriendo..."
            RecorrerDataFacturaEnvioAutomatico()

            Var_UltimoMomentoCorrio = Now

        Else

            'lblEjecutando.Text = "Esperando..."

        End If

    End Sub


    Private Sub RecorrerDataFacturaEnvioAutomatico()
        Dim rstCodigo As Integer = 0

        Dim CursorFE As dsCloaDocsFacturasXProcesar.InterfasFacturasRow

        lblEjecutando.Text = "Generando y enviando archivo"

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                For Each CursorFE In Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas
                    rstCodigo = EnviaArchivoFacturaElectronica(CursorFE.IDVentasFacturas, CursorFE.CodFactura)
                    CursorFE.FlagSent = If(rstCodigo = 200, 1, 0)
                Next
            Case "TXT"
                For Each CursorFE In Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas
                    rstCodigo = EnviaArchivoFEeKOMERCIO(CursorFE.IDVentasFacturas, CursorFE.CodFactura)
                    CursorFE.FlagSent = If(rstCodigo = 200, 1, 0)
                Next
        End Select

        ActualizaVistaFacturas()
    End Sub

    Private Function EnviaArchivoFEeKOMERCIO(prmIDVentasFactura As Integer, prmcodFactura As String) As Integer
        Dim strResuesta As String = ""
        Dim objFacturaElectronica = New cFacturaEkomercio
        Dim XMLResponse As XmlNode
        Dim objResponce As Object = vbNull

        Dim dsArchivoPlano As New dsArchivoPlano
        Dim strTextoPlano As String = ""
        Dim tmpCodigoFE As Integer = 0
        Dim tmpCodRespuesta As Integer = 0


        dsArchivoPlano = objFacturaElectronica.GeneraFileFacturaEkomercio(prmIDVentasFactura)
        ExportaTabla(dsArchivoPlano.ArchivoPlano, RutaArchivos.Text, "ID,Codigo", "FE" & prmIDVentasFactura & ".txt")

        Dim CursorAP As dsArchivoPlano.ArchivoPlanoRow

        For Each CursorAP In dsArchivoPlano.ArchivoPlano
            tmpCodigoFE = CursorAP.Codigo
            strTextoPlano += CursorAP.Texto
        Next

        Try
            objResponce = serviceClientEkomercio.procesarTextoPlanoToXML(TokenLogin.Text, TokenPassword.Text, LoinIntermediario.Text, strTextoPlano)
            XMLResponse = objResponce
            txtResponceFacturacion.Text = "Envio OK" & vbCr & vbCr & objResponce.ToString


        Catch ex As Exception

            txtResponceFacturacion.Text = "Error en Envio" & vbCr & vbCr & objResponce.ToString & vbCr & vbCr & ex.ToString
            tmpCodRespuesta = 0

            Exit Function

        End Try


        Dim tmpRutaArchivo As String = ""
        tmpRutaArchivo = RutaArchivos.Text & "\Response_FE" & prmIDVentasFactura & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivos.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivos.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(XmlNode))
        Serializer1.Serialize(MyFile, XMLResponse) ' // Objeto serializado
        MyFile.Close()


        Dim tmpConsecutivo As String = 0
        Dim tmpCufe As String = ""
        Dim tmpMensajes As String = ""
        Dim tmpError As String = ""
        Dim tmpMensajesValidacion As String = ""

        If XMLResponse.Name = "Error" Then
            tmpError = XMLResponse.InnerText
        Else
            tmpError = XMLResponse.Item("Error").InnerText

        End If


        If (tmpError.Trim.Length = 0) Then
            tmpCodRespuesta = 200
            tmpConsecutivo = PreFijo.Text + tmpCodigoFE.ToString
            tmpCufe = XMLResponse.Item("UUID").InnerXml
            tmpMensajes = ""
        Else
            tmpCodRespuesta = 0
            tmpMensajes = ""
            tmpCodigoFE = 0
        End If

        tmpError = Replace(tmpError, "'", "")

        Dim strSQL As String = ""
        strSQL = "exec ActualizaEstadoInterfas " & prmIDVentasFactura & ", '" & tmpCodRespuesta & "', '" & tmpConsecutivo & "', '" & tmpCufe & "', '" & If(IsNothing(tmpError), "", tmpError.Substring(0, If(tmpError.Length >= 999, 999, tmpError.Length))) & "', '" & tmpMensajesValidacion & "', " & tmpCodigoFE
        Dim objGestionData As New cGestionData
        objGestionData.GetDatoEscalar(strSQL, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)

        Return tmpCodRespuesta
    End Function

    Private Sub EnviaArchivoNotaCreditoeKOMERCIO(prmIDVentasDevoluciones As Integer, prmcodNota As String)
        Dim strResuesta As String = ""
        Dim objFacturaElectronica As New cFacturaEkomercio
        Dim XMLResponse As XmlNode
        Dim dsArchivoPlano As New dsArchivoPlano
        Dim strTextoPlano As String = ""
        Dim tmpCodigoFE As Integer = 0

        dsArchivoPlano = objFacturaElectronica.GeneraFileNotaCreditoEkomercio(prmIDVentasDevoluciones)
        ExportaTabla(dsArchivoPlano.ArchivoPlano, RutaArchivos.Text, "ID,Codigo", "NCE" & prmIDVentasDevoluciones & ".txt")

        Dim CursorAP As dsArchivoPlano.ArchivoPlanoRow

        For Each CursorAP In dsArchivoPlano.ArchivoPlano
            tmpCodigoFE = CursorAP.Codigo
            strTextoPlano += CursorAP.Texto
        Next

        Try
            XMLResponse = serviceClientEkomercio.procesarTextoPlanoToXML(TokenLogin.Text, TokenPassword.Text, LoinIntermediario.Text, strTextoPlano)

        Catch ex As Exception
            Dim NuevoError As dsErroresEnvio.ErrorEnvioDocumentosRow

            NuevoError = DsErroresEnvio1.ErrorEnvioDocumentos.NewErrorEnvioDocumentosRow

            With NuevoError
                .ErrorDesc = ex.Message
                .TiempoEnvio = Now
                .TipoDocumento = "NOTAS CREDITO"
                .IDDocto = prmIDVentasDevoluciones

            End With

            DsErroresEnvio1.ErrorEnvioDocumentos.AddErrorEnvioDocumentosRow(NuevoError)

            Exit Sub

        End Try




        Dim tmpRutaArchivo As String = ""
        tmpRutaArchivo = RutaArchivos.Text & "\Response_NCE" & prmIDVentasDevoluciones & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivos.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivos.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(XmlNode))
        Serializer1.Serialize(MyFile, XMLResponse) ' // Objeto serializado
        MyFile.Close()

        Dim tmpCodRespuesta As Integer = 0
        Dim tmpConsecutivo As String = 0
        Dim tmpCufe As String = ""
        Dim tmpMensajes As String = ""
        Dim tmpError As String = ""
        Dim tmpMensajesValidacion As String = ""

        If XMLResponse.Name = "Error" Then
            tmpError = XMLResponse.InnerText
        Else
            tmpError = XMLResponse.Item("Error").InnerText

        End If


        If (tmpError.Trim.Length = 0) Then
            tmpCodRespuesta = 200
            tmpConsecutivo = PreFijoNC.Text + tmpCodigoFE.ToString
            tmpCufe = XMLResponse.Item("UUID").InnerXml
            tmpMensajes = ""
        Else
            tmpCodRespuesta = 0
            tmpMensajes = ""
            tmpCodigoFE = 0
        End If

        tmpError = Replace(tmpError, "'", "")

        Dim strSQL As String = ""
        strSQL = "exec ActualizaEstadoInterfazNC " & prmIDVentasDevoluciones & ", '" & tmpCodRespuesta & "', '" & tmpConsecutivo & "', '" & tmpCufe & "', '" & If(IsNothing(tmpError), "", tmpError.Substring(0, If(tmpError.Length >= 999, 999, tmpError.Length))) & "', '" & tmpMensajesValidacion & "', " & tmpCodigoFE
        Dim objGestionData As New cGestionData
        objGestionData.GetDatoEscalar(strSQL, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)

        Exit Sub
    End Sub

    Private Sub CreaColaEnvioFacturas()

        Dim strSQL As String = ""
        strSQL = "exec CreaColaEnvio 1"

        lblEjecutando.Text = "A generar cola"

        Me.DsCloaDocsFacturasXProcesar1.Clear()
        LlenaDataSetGenerico(Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas, "InterfasFacturas", strSQL, strConeccionDB)

        lblEjecutando.Text = "Cola de envio Consulta: " & Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas.Count & " Records"

        lblUltimosRecs.Text = "Ultimos: " & Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas.Count & " Records"

    End Sub

    Private Sub ActualizaVistaFacturas()

        Dim strSQL As String = ""
        strSQL = "EXEC GetColaEnvio 1"
        Me.DsCloaDocsFacturasXProcesar1.Clear()
        LlenaDataSetGenerico(Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas, "InterfasFacturas", strSQL, strConeccionDB)

    End Sub

    Private Sub CreaColaEnvioNotasCredito()

        Dim strSQL As String = ""
        strSQL = "exec CreaColaEnvio 2"
        Me.DsNotasCreditoXProcesar1.Clear()
        LlenaDataSetGenerico(Me.DsNotasCreditoXProcesar1.InterfazNotasCredito, "InterfazNotasCredito", strSQL, strConeccionDB)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        objSuperClass.Guardar(True)
    End Sub

    Private Sub btnCorrer_Click(sender As Object, e As EventArgs) Handles btnCorrer.Click
        CorrerProceso()
    End Sub

    Private Sub CorrerProceso()
        Var_UltimoMomentoCorrio = Date.Now.AddDays(-1)
        Var_UltimoMomentoCorrioNC = Date.Now.AddDays(-1)

        If Var_EstadoProceso = 1 Then
            Exit Sub
        End If

        Var_EstadoProceso = 1

        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub ForzarEnvíoDeFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForzarEnvíoDeFacturaToolStripMenuItem.Click
        On Error GoTo ControlaError

        Dim tmpActualFila As DataRowView
        tmpActualFila = Me.dGridCurrentActivity.CurrentRow.DataBoundItem
        Dim tmpId As Integer = 0
        Dim tmpCodigo As Integer = 0
        Dim rstaCodigo As Integer = 0

        tmpId = tmpActualFila.Item("IDVentasFacturas")
        tmpCodigo = tmpActualFila.Item("CodFactura")

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                rstaCodigo = EnviaArchivoFacturaElectronica(tmpId, tmpCodigo)

                If rstaCodigo = 200 Then
                    objDsMgr.EstablecerValorCampo(dGridCurrentActivity, "FlagSent", 1)
                End If
            Case "TXT"
                EnviaArchivoFEeKOMERCIO(tmpId, tmpCodigo)
        End Select

        ActualizaVistaFacturas()
        Exit Sub
ControlaError:
        MessageBox.Show(Err.Description)
    End Sub

    Private Function EnviaArchivoFacturaElectronica(prmIDVentasFactura As Integer, prmCodigo As Integer) As Integer
        Dim strResuesta As String = ""

        Dim objDocto As ServicioEmi.FacturaGeneral

        Dim objFacturaElectronica As New cFacturaElectronica


        objDocto = objFacturaElectronica.GeneraFileFacturaFactory(prmIDVentasFactura, prmCodigo, PreFijo.Text, ConsecutivoDesde.Value)

        Dim tmpRutaArchivo As String = ""
        tmpRutaArchivo = RutaArchivos.Text & "\FE" & prmIDVentasFactura & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivos.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivos.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.FacturaGeneral))
        Serializer1.Serialize(MyFile, objDocto) ' // Objeto serializado
        MyFile.Close()

        If (chkEnPruebasDeArchivo.Checked) Then
            Exit Function
        End If

        Dim docRespuesta As ServicioEmi.DocumentResponse  '//objeto Response del metodo enviar

        Try
            docRespuesta = serviceClientEm.Enviar(Me.TokenLogin.Text.Trim(), Me.TokenPassword.Text.Trim(), objDocto, "0")

        Catch ex As Exception
            Dim NuevoError As dsErroresEnvio.ErrorEnvioDocumentosRow

            NuevoError = DsErroresEnvio1.ErrorEnvioDocumentos.NewErrorEnvioDocumentosRow

            With NuevoError
                .ErrorDesc = Var_EstadoProceso.ToString
                .TiempoEnvio = Now
                .TipoDocumento = "FACTURA"
                .IDDocto = prmIDVentasFactura

            End With

            DsErroresEnvio1.ErrorEnvioDocumentos.AddErrorEnvioDocumentosRow(NuevoError)


        End Try

        tmpRutaArchivo = RutaArchivos.Text & "\Response_FE" & prmIDVentasFactura & ".txt"
        Dim MyFile2 As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer2 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.DocumentResponse))
        Serializer2.Serialize(MyFile2, docRespuesta) ' // Objeto serializado
        MyFile.Close()

        Dim tmpCodRespuesta As Integer = 0
        Dim tmpConsecutivo As String = 0
        Dim tmpCufe As String = ""
        Dim tmpMensajes As String = ""
        Dim tmpResultado As String = ""
        Dim tmpHash As String = ""
        Dim tmpMensajesValidacion As String = ""
        Dim tmpCodigoFE As Integer = 0

        If (docRespuesta.codigo = 200 Or docRespuesta.codigo = 201) Then
            tmpCodRespuesta = docRespuesta.codigo
            tmpConsecutivo = docRespuesta.consecutivoDocumento
            tmpCufe = docRespuesta.cufe
            tmpMensajes = docRespuesta.mensaje
            tmpResultado = docRespuesta.resultado
            tmpCodigoFE = CInt(Replace(objDocto.consecutivoDocumento, Me.PreFijo.Text, ""))
        Else
            tmpCodRespuesta = docRespuesta.codigo
            tmpMensajes = docRespuesta.mensaje
            tmpResultado = docRespuesta.resultado
            tmpHash = docRespuesta.hash
            tmpCodigoFE = 0


            If Not IsNothing(docRespuesta.mensajesValidacion()) Then
                For i = 0 To docRespuesta.mensajesValidacion().Count - 1
                    tmpMensajesValidacion = tmpMensajesValidacion & " M.V " & i & " " & docRespuesta.mensajesValidacion(i).ToString()
                Next
            End If

        End If

        tmpMensajesValidacion = Replace(tmpMensajesValidacion, "'", "")

        Dim strSQL As String = ""
        strSQL = "exec ActualizaEstadoInterfas " & prmIDVentasFactura & ", '" & tmpCodRespuesta & "', '" & tmpConsecutivo & "', '" & tmpCufe & "', '" & tmpResultado & ": " & tmpMensajes & "', '" & tmpMensajesValidacion & "', " & tmpCodigoFE
        Dim objGestionData As New cGestionData
        objGestionData.GetDatoEscalar(strSQL, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)


        Return tmpCodRespuesta
    End Function

    Private Sub Filtrar()
        On Error Resume Next
        Me.objDsMgr.Filtrar(Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas, Panel2, Me.bsColaDocsFacturas)
    End Sub

    Private Sub CF_CodFactura_CheckedChanged(sender As Object, e As EventArgs) Handles CF_CodFactura.CheckedChanged
        Filtrar()
    End Sub

    Private Sub VF_CodFactura_TextChanged(sender As Object, e As EventArgs) Handles VF_CodFactura.TextChanged
        Filtrar()
    End Sub

    Private Sub CF_CodCliente_CheckedChanged(sender As Object, e As EventArgs) Handles CF_CodCliente.CheckedChanged
        Filtrar()
    End Sub

    Private Sub VF_CodCliente_TextChanged(sender As Object, e As EventArgs) Handles VF_CodCliente.TextChanged
        Filtrar()
    End Sub

    Private Sub CF_NomCliente_CheckedChanged(sender As Object, e As EventArgs) Handles CF_NomCliente.CheckedChanged
        Filtrar()
    End Sub

    Private Sub VF_NomCliente_TextChanged(sender As Object, e As EventArgs) Handles VF_NomCliente.TextChanged
        Filtrar()
    End Sub

    Private Sub cMenuCola_Opening(sender As Object, e As CancelEventArgs) Handles cMenuCola.Opening
        On Error GoTo ControlaError

        Dim tmpActualFila As DataRowView
        tmpActualFila = Me.dGridCurrentActivity.CurrentRow.DataBoundItem
        Dim tmpFlagSent As Integer = 0

        tmpFlagSent = tmpActualFila.Item("FlagSent")

        If tmpFlagSent = 0 Then
            Me.cMenuCola.Enabled = True
        Else
            Me.cMenuCola.Enabled = False
        End If

        Exit Sub
ControlaError:
        MessageBox.Show(Err.Description)
    End Sub

    Private Sub dGridCurrentActivity_Paint(sender As Object, e As PaintEventArgs) Handles dGridCurrentActivity.Paint
        On Error Resume Next
        Me.lblRecordsCurrentActivity.Text = "Registos: " & Me.bsColaDocsFacturas.Count
    End Sub

    Private Sub dgridColaNotasCredito_Paint(sender As Object, e As PaintEventArgs) Handles dgridColaNotasCredito.Paint
        On Error Resume Next
        Me.lblNumRegistrosNC.Text = "Registos: " & Me.bsColaNotasCredito.Count
    End Sub

    Private Sub FiltrarNotasCredito()
        On Error Resume Next
        Me.objDsMgr.Filtrar(Me.DsNotasCreditoXProcesar1.InterfazNotasCredito, PanelFiltroNC, Me.bsColaNotasCredito)
    End Sub

    Private Sub VF_Codigo_TextChanged(sender As Object, e As EventArgs) Handles VF_Codigo.TextChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub CF_Codigo_CheckedChanged(sender As Object, e As EventArgs) Handles CF_Codigo.CheckedChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub VF_AuxCampoNomCliente_TextChanged(sender As Object, e As EventArgs) Handles VF_AuxCampoNomCliente.TextChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub CF_AuxCampoNomCliente_CheckedChanged(sender As Object, e As EventArgs) Handles CF_AuxCampoNomCliente.CheckedChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub VF_AuxCampoCodCliente_TextChanged(sender As Object, e As EventArgs) Handles VF_AuxCampoCodCliente.TextChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub CF_AuxCampoCodCliente_CheckedChanged(sender As Object, e As EventArgs) Handles CF_AuxCampoCodCliente.CheckedChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub VF_AuxCampoCodFactura_TextChanged(sender As Object, e As EventArgs) Handles VF_AuxCampoCodFactura.TextChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub CF_AuxCampoCodFactura_CheckedChanged(sender As Object, e As EventArgs) Handles CF_AuxCampoCodFactura.CheckedChanged
        FiltrarNotasCredito()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        On Error GoTo ControlaError

        Dim tmpActualFila As DataRowView
        tmpActualFila = Me.dgridColaNotasCredito.CurrentRow.DataBoundItem
        Dim tmpId As Integer = 0
        Dim tmpCodigo As Integer = 0

        tmpId = tmpActualFila.Item("IDVentasDevoluciones")
        tmpCodigo = tmpActualFila.Item("Codigo")

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                EnviaArchivoNotaCreditoElectronica(tmpId, tmpCodigo)
            Case "TXT"
                EnviaArchivoNotaCreditoeKOMERCIO(tmpId, tmpCodigo)
        End Select

        Exit Sub
ControlaError:
        MessageBox.Show(Err.Description)
    End Sub

    Private Function EnviaArchivoNotaCreditoElectronica(prmIDVentasDevoluciones As Integer, prmCodigo As Integer) As String
        Dim strResuesta As String = ""

        Dim objDocto As ServicioEmi.FacturaGeneral
        Dim objFacturaElectronica As New cFacturaElectronica

        objDocto = objFacturaElectronica.GeneraFileNotaCreditoFactory(prmIDVentasDevoluciones, prmCodigo, PreFijo.Text, ConsecutivoDesde.Value)

        Dim tmpRutaArchivo As String = ""
        tmpRutaArchivo = RutaArchivos.Text & "\NCE" & prmIDVentasDevoluciones & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivos.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivos.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.FacturaGeneral))
        Serializer1.Serialize(MyFile, objDocto) ' // Objeto serializado
        MyFile.Close()

        Dim docRespuesta As ServicioEmi.DocumentResponse  '//objeto Response del metodo enviar

        Try
            docRespuesta = serviceClientEm.Enviar(Me.TokenLogin.Text.Trim(), Me.TokenPassword.Text.Trim(), objDocto, "0")

        Catch ex As Exception
            Dim NuevoError As dsErroresEnvio.ErrorEnvioDocumentosRow

            NuevoError = DsErroresEnvio1.ErrorEnvioDocumentos.NewErrorEnvioDocumentosRow

            With NuevoError
                .ErrorDesc = Var_EstadoProceso.ToString
                .TiempoEnvio = Now
                .TipoDocumento = "NOTAS CREDITO"
                .IDDocto = prmIDVentasDevoluciones

            End With

            DsErroresEnvio1.ErrorEnvioDocumentos.AddErrorEnvioDocumentosRow(NuevoError)

        End Try


        tmpRutaArchivo = RutaArchivos.Text & "\Response_NCE" & prmIDVentasDevoluciones & ".txt"
        Dim MyFile2 As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer2 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.DocumentResponse))
        Serializer2.Serialize(MyFile2, docRespuesta) ' // Objeto serializado
        MyFile.Close()

        Dim tmpCodRespuesta As Integer = 0
        Dim tmpConsecutivo As String = 0
        Dim tmpCufe As String = ""
        Dim tmpMensajes As String = ""
        Dim tmpResultado As String = ""
        Dim tmpHash As String = ""
        Dim tmpMensajesValidacion As String = ""
        Dim tmpCodigoFE As Integer = 0

        If (docRespuesta.codigo = 200 Or docRespuesta.codigo = 201) Then
            tmpCodRespuesta = docRespuesta.codigo
            tmpConsecutivo = docRespuesta.consecutivoDocumento
            tmpCufe = docRespuesta.cufe
            tmpMensajes = docRespuesta.mensaje
            tmpResultado = docRespuesta.resultado
            tmpCodigoFE = CInt(Replace(objDocto.consecutivoDocumento, Me.PreFijoNC.Text, ""))
        Else
            tmpCodRespuesta = docRespuesta.codigo
            tmpMensajes = docRespuesta.mensaje
            tmpResultado = docRespuesta.resultado
            tmpHash = docRespuesta.hash
            tmpCodigoFE = 0


            If Not IsNothing(docRespuesta.mensajesValidacion()) Then
                For i = 0 To docRespuesta.mensajesValidacion().Count - 1
                    tmpMensajesValidacion = tmpMensajesValidacion & " M.V " & i & " " & docRespuesta.mensajesValidacion(i).ToString()
                Next
            End If

        End If

        tmpMensajesValidacion = Replace(tmpMensajesValidacion, "'", "")

        Dim strSQL As String = ""
        strSQL = "exec ActualizaEstadoInterfazNC " & prmIDVentasDevoluciones & ", '" & tmpCodRespuesta & "', '" & tmpConsecutivo & "', '" & tmpCufe & "', '" & tmpResultado & ": " & tmpMensajes & "', '" & tmpMensajesValidacion & "', " & tmpCodigoFE
        Dim objGestionData As New cGestionData
        objGestionData.GetDatoEscalar(strSQL, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)


        Return strResuesta
    End Function

    Private Function EnviaArchivoNotaDebitoElectronica(prmIDVentasDevoluciones As Integer, prmCodigo As Integer) As String
        Dim strResuesta As String = ""

        Dim objDocto As ServicioEmi.FacturaGeneral
        Dim objFacturaElectronica As New cFacturaElectronica

        objDocto = objFacturaElectronica.GeneraFileNotaDebitoFactory(prmIDVentasDevoluciones, prmCodigo, PreFijo.Text, ConsecutivoDesde.Value)

        Dim tmpRutaArchivo As String = ""
        tmpRutaArchivo = RutaArchivos.Text & "\NDE" & prmIDVentasDevoluciones & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivos.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivos.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.FacturaGeneral))
        Serializer1.Serialize(MyFile, objDocto) ' // Objeto serializado
        MyFile.Close()

        Dim docRespuesta As ServicioEmi.DocumentResponse  '//objeto Response del metodo enviar

        docRespuesta = serviceClientEm.Enviar(Me.TokenLogin.Text.Trim(), Me.TokenPassword.Text.Trim(), objDocto, "0")

        tmpRutaArchivo = RutaArchivos.Text & "\Response_NDE" & prmIDVentasDevoluciones & ".txt"
        Dim MyFile2 As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer2 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.DocumentResponse))
        Serializer2.Serialize(MyFile2, docRespuesta) ' // Objeto serializado
        MyFile.Close()

        Dim tmpCodRespuesta As Integer = 0
        Dim tmpConsecutivo As String = 0
        Dim tmpCufe As String = ""
        Dim tmpMensajes As String = ""
        Dim tmpResultado As String = ""
        Dim tmpHash As String = ""
        Dim tmpMensajesValidacion As String = ""
        Dim tmpCodigoFE As Integer = 0

        'If (docRespuesta.codigo = 200 Or docRespuesta.codigo = 201) Then
        '    tmpCodRespuesta = docRespuesta.codigo
        '    tmpConsecutivo = docRespuesta.consecutivoDocumento
        '    tmpCufe = docRespuesta.cufe
        '    tmpMensajes = docRespuesta.mensaje
        '    tmpResultado = docRespuesta.resultado
        '    tmpCodigoFE = CInt(Replace(objDocto.consecutivoDocumento, Me.PreFijoNC.Text, ""))
        'Else
        '    tmpCodRespuesta = docRespuesta.codigo
        '    tmpMensajes = docRespuesta.mensaje
        '    tmpResultado = docRespuesta.resultado
        '    tmpHash = docRespuesta.hash
        '    tmpCodigoFE = 0


        '    If Not IsNothing(docRespuesta.mensajesValidacion()) Then
        '        For i = 0 To docRespuesta.mensajesValidacion().Count - 1
        '            tmpMensajesValidacion = tmpMensajesValidacion & " M.V " & i & " " & docRespuesta.mensajesValidacion(i).ToString()
        '        Next
        '    End If

        'End If

        'tmpMensajesValidacion = Replace(tmpMensajesValidacion, "'", "")

        'Dim strSQL As String = ""
        'strSQL = "exec ActualizaEstadoInterfazNC " & prmIDVentasDevoluciones & ", '" & tmpCodRespuesta & "', '" & tmpConsecutivo & "', '" & tmpCufe & "', '" & tmpResultado & ": " & tmpMensajes & "', '" & tmpMensajesValidacion & "', " & tmpCodigoFE
        'Dim objGestionData As New cGestionData
        'objGestionData.GetDatoEscalar(strSQL, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)


        Return strResuesta
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim tmpAhora As Date = Now
        Dim tmpMinutes As Integer = 0
        Dim tmpSegundos As Integer = 0
        Dim tmpSegundosFaltan As Integer = 0

        tmpMinutes = FrecuenciaMinsNC.Value - DateAndTime.DateDiff(DateInterval.Minute, Var_UltimoMomentoCorrioNC, Now)
        tmpSegundos = (FrecuenciaMinsNC.Value * 60) - DateAndTime.DateDiff(DateInterval.Second, Var_UltimoMomentoCorrioNC, Now)

        tmpSegundosFaltan = 60 + (tmpSegundos - (tmpMinutes * 60))

        tmpMinutes = tmpMinutes - 1

        lblStatusNC.Text = "N.C Status: Running"
        lblTiempoRestanteNuevoCargueNC.Text = "N.C Remaining Time for Next Upload (Mins): " & tmpMinutes.ToString & ":" & Strings.Right("00" + tmpSegundosFaltan.ToString, 2)
        lblLastTimeRanNC.Text = "N.C Last time ran: " & Var_UltimoMomentoCorrioNC

        Dim tmOKxTiempo As Boolean = False
        Dim tmpCurrentTimeAsMinutes As Integer = 0
        Dim tmpSendTimeAsMinutes As Integer = 0

        tmpSendTimeAsMinutes = (Me.HoraEnvio.Value.Hour * 60) + Me.HoraEnvio.Value.Minute
        tmpCurrentTimeAsMinutes = (Now.Hour * 60) + Now.Minute

        If FlagHoraDiaria.Checked Then
            tmOKxTiempo = (tmpSendTimeAsMinutes < tmpCurrentTimeAsMinutes)
        Else
            tmOKxTiempo = True
        End If

        If tmpMinutes < 0 And chkNotasCredito.Checked And tmOKxTiempo Then
            CreaColaEnvioNotasCredito()
            RecorrerDataNCEnvioAutomatico()

            Var_UltimoMomentoCorrioNC = Now
        End If
    End Sub

    Private Sub RecorrerDataNCEnvioAutomatico()
        Dim CursorNC As dsNotasCreditoXProcesar.InterfazNotasCreditoRow

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                For Each CursorNC In Me.DsNotasCreditoXProcesar1.InterfazNotasCredito
                    EnviaArchivoNotaCreditoElectronica(CursorNC.IDVentasDevoluciones, CursorNC.Codigo)

                    If Me.IDTiposEnvios.SelectedValue = 1 Then
                        EnviaArchivoNotaDebitoElectronica(CursorNC.IDVentasDevoluciones, CursorNC.Codigo)
                    End If
                Next
            Case "TXT"
                For Each CursorNC In Me.DsNotasCreditoXProcesar1.InterfazNotasCredito
                    EnviaArchivoNotaCreditoeKOMERCIO(CursorNC.IDVentasDevoluciones, CursorNC.Codigo)
                Next
        End Select

        ActualizaVistaNotasC()

    End Sub

    Private Sub ActualizaVistaNotasC()

        Dim strSQL As String = ""
        strSQL = "EXEC GetColaEnvio 2"
        Me.DsNotasCreditoXProcesar1.Clear()
        LlenaDataSetGenerico(Me.DsNotasCreditoXProcesar1.InterfazNotasCredito, "InterfazNotasCredito", strSQL, strConeccionDB)

    End Sub


    Private Sub cmbCompania_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCompania.SelectedIndexChanged
        On Error Resume Next
        ActualizaDatosConexion()
    End Sub

    Private Sub ActualizaDatosConexion()

        strConeccionDB = GetStringConeccionDB(Me.cmbCompania.SelectedItem("ServidorSQL"), Me.cmbCompania.SelectedItem("BaseDatos"), Me.cmbCompania.SelectedItem("Login"), Me.cmbCompania.SelectedItem("Password"))

        Dim ci As New Globalization.CultureInfo("en-US")
        Application.CurrentCulture = ci

        cnn = New cConeccionDB(strConeccionDB, cConeccionDB.TipoConeccion.SQLServerConeccion)
        objSuperClass = New cSuperDBDocMgr(strConeccionDB, cConeccionDB.TipoConeccion.SQLServerConeccion, "AppParametros", Me, cSuperDBDocMgr.TipoVista.WindowsForms_Vista, dsAux)

        objDsMgr = New cDsMgr(strConeccionDB, cDsMgr.TipoConeccion.SQLServerConeccion, cnn)

        FrecuenciaMins.Value = Me.cmbCompania.SelectedItem("FrecMins")
        FrecuenciaMinsNC.Value = Me.cmbCompania.SelectedItem("FrecMins")

        ConfiguraEndPoints(Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo"))

        objSuperClass.Show(Me.cmbCompania.SelectedItem("IDAppParametros"))
    End Sub

    Private Sub ConfiguraEndPoints(prmFormatoArchivo As String)

        Dim port As BasicHttpBinding = New BasicHttpBinding()
        port.MaxBufferPoolSize = Int32.MaxValue
        port.MaxBufferSize = Int32.MaxValue
        port.MaxReceivedMessageSize = Int32.MaxValue
        port.ReaderQuotas.MaxStringContentLength = Int32.MaxValue
        port.SendTimeout = TimeSpan.FromMinutes(2)
        port.ReceiveTimeout = TimeSpan.FromMinutes(2)


        Dim strEndPointEmision As String
        Dim strEndPointAdjuntos As String

        strEndPointEmision = Me.cmbCompania.SelectedItem("EndPointEmision")
        strEndPointAdjuntos = Me.cmbCompania.SelectedItem("EndPointAdjuntos")
        RutaArchivos.Text = Me.cmbCompania.SelectedItem("RutaArchivo")

        If prmFormatoArchivo = "XML" Then

            'Dim endPointEmision As EndpointAddress = New EndpointAddress("https://emision21.thefactoryhka.com.co/ws/v1.0/Service.svc?wsdl")
            'Dim endPointAdjuntos As EndpointAddress = New EndpointAddress("https://emision21.thefactoryhka.com.co/ws/adjuntos/Service.svc?wsdl")

            port.Security.Mode = BasicHttpSecurityMode.Transport ' para the factory

            Dim endPointEmision As EndpointAddress = New EndpointAddress(strEndPointEmision)
            Dim endPointAdjuntos As EndpointAddress = New EndpointAddress(strEndPointAdjuntos)

            serviceClientEm = New ServicioEmi.ServiceClient(port, endPointEmision)
            serviceArchivos = New ServicioAdjuntos.ServiceClient(port, endPointAdjuntos)
        End If

        If prmFormatoArchivo = "TXT" Then
            Dim endPointEmision As EndpointAddress = New EndpointAddress(strEndPointEmision)

            serviceClientEkomercio = New ServicioEkomercio.WSCFDBuilderPlusSoapClient(port, endPointEmision)
        End If
    End Sub

    Private Sub btnConsultarHistoria_Click(sender As Object, e As EventArgs) Handles btnConsultarHistoria.Click
        CargarHistoriaFacturas()
    End Sub

    Private Sub CargarHistoriaFacturas()
        Dim strWhere As String = ""

        strWhere = "CAST(FLOOR(CAST(StampTimeEnvio AS FLOAT)) AS DATETIME) BETWEEN '" & Me.dtpFInicialHistoryInvoices.Value.ToShortDateString & "' AND '" & dtpFFinalHistoryInvoices.Value.ToShortDateString & "'"

        objDsMgr.Cargar(Me.DsCloaDocsFacturasXProcesarHistoria, strWhere)

    End Sub

    Private Sub btnConsultaHistoriaNC_Click(sender As Object, e As EventArgs) Handles btnConsultaHistoriaNC.Click
        CargarHistoriaNC()
    End Sub

    Private Sub CargarHistoriaNC()
        Dim strWhere As String = ""

        strWhere = "CAST(FLOOR(CAST(StampTimeEnvio AS FLOAT)) AS DATETIME) BETWEEN '" & Me.dtpFInicialNC.Value.ToShortDateString & "' AND '" & dtpFFinalNC.Value.ToShortDateString & "'"
        objDsMgr.Cargar(Me.dsNotasCreditoHistoria, strWhere)

    End Sub

    Private Sub EstablecerNumeroDeFacturaElectronicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstablecerNumeroDeFacturaElectronicaToolStripMenuItem.Click

        Dim CurrentRow As DataRowView
        On Error Resume Next

        CurrentRow = Me.dGridHistorial.CurrentRow.DataBoundItem
        Dim tmpIDPOVentas As Integer = 0
        tmpIDPOVentas = CurrentRow.Item("IDVentasFacturas")

        Dim VistaEstablecerNumFacturaElectronica As New EstablecerNumFacturaElectronicaFrm(tmpIDPOVentas)
        VistaEstablecerNumFacturaElectronica.Show(Me)
    End Sub
End Class