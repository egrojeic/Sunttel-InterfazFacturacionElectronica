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



Public Class CoreForm

    Dim serviceClientEm As ServicioEmi.ServiceClient
    Dim serviceArchivos As ServicioAdjuntos.ServiceClient

    Dim objSuperClass As cSuperDBDocMgr
    Dim cnn As cConeccionDB

    Dim Var_EstadoProceso As Integer = 0 ' 0 Detenido, 1 Corriendo
    Dim Var_UltimoMomentoCorrio As Date
    Dim Var_UltimoMomentoCorrioNC As Date

    Dim objDsMgr As cDsMgr


    Private Sub CoreForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbCompania.DataSource = dsConexiones
        Me.cmbCompania.DisplayMember = "Conections.Compania"
        Me.cmbCompania.ValueMember = "Conections.IDAppParametros"

        Var_UltimoMomentoCorrio = Date.Now.AddDays(-1)

    End Sub

    Private Sub CoreForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        RegistraConfigSys()
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

        If tmpMinutes < 0 Then

            CreaColaEnvioFacturas()
            RecorrerDataFacturaEnvioAutomatico()

            Var_UltimoMomentoCorrio = Now


        End If

    End Sub


    Private Sub RecorrerDataFacturaEnvioAutomatico()
        Dim CursorFE As dsCloaDocsFacturasXProcesar.InterfasFacturasRow

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                For Each CursorFE In Me.DsCloaDocsFacturasXProcesar1.InterfasFacturas
                    EnviaArchivoFacturaElectronica(CursorFE.IDVentasFacturas, CursorFE.CodFactura)
                Next
        End Select

    End Sub

    Private Sub CreaColaEnvioFacturas()

        Dim strSQL As String = ""
        strSQL = "exec CreaColaEnvio 1"
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

        tmpId = tmpActualFila.Item("IDVentasFacturas")
        tmpCodigo = tmpActualFila.Item("CodFactura")

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                EnviaArchivoFacturaElectronica(tmpId, tmpCodigo)
        End Select

        Exit Sub
ControlaError:
        MessageBox.Show(Err.Description)
    End Sub

    Private Function EnviaArchivoFacturaElectronica(prmIDVentasFactura As Integer, prmCodigo As Integer) As String
        Dim strResuesta As String = ""

        Dim objDocto As ServicioEmi.FacturaGeneral

        Dim objFacturaElectronica As New cFacturaElectronica


        objDocto = objFacturaElectronica.GeneraFileFacturaFactory(prmIDVentasFactura, prmCodigo, PreFijo.Text, ConsecutivoDesde.Value)

        Dim tmpRutaArchivo As String = ""
        tmpRutaArchivo = RutaArchivosArmellini.Text & "\FE" & prmIDVentasFactura & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivosArmellini.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivosArmellini.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.FacturaGeneral))
        Serializer1.Serialize(MyFile, objDocto) ' // Objeto serializado
        MyFile.Close()


        Dim docRespuesta As ServicioEmi.DocumentResponse  '//objeto Response del metodo enviar

        docRespuesta = serviceClientEm.Enviar(Me.TokenLogin.Text.Trim(), Me.TokenPassword.Text.Trim(), objDocto, "0")

        tmpRutaArchivo = RutaArchivosArmellini.Text & "\Response_FE" & prmIDVentasFactura & ".txt"
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

        If (docRespuesta.codigo = 200) Then
            tmpCodRespuesta = docRespuesta.codigo
            tmpConsecutivo = docRespuesta.consecutivoDocumento
            tmpCufe = docRespuesta.cufe
            tmpMensajes = docRespuesta.mensaje
            tmpResultado = docRespuesta.resultado
            tmpCodigoFE = CInt(objDocto.consecutivoDocumento)
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


        Return strResuesta
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
        tmpRutaArchivo = RutaArchivosArmellini.Text & "\NCE" & prmIDVentasDevoluciones & ".txt"

        If Not System.IO.Directory.Exists(RutaArchivosArmellini.Text) Then
            System.IO.Directory.CreateDirectory(RutaArchivosArmellini.Text)
        End If

        Dim MyFile As StreamWriter = New StreamWriter(tmpRutaArchivo) '//ruta y name del archivo request a almecenar
        Dim Serializer1 As XmlSerializer = New XmlSerializer(GetType(ServicioEmi.FacturaGeneral))
        Serializer1.Serialize(MyFile, objDocto) ' // Objeto serializado
        MyFile.Close()


        Dim docRespuesta As ServicioEmi.DocumentResponse  '//objeto Response del metodo enviar

        docRespuesta = serviceClientEm.Enviar(Me.TokenLogin.Text.Trim(), Me.TokenPassword.Text.Trim(), objDocto, "0")

        tmpRutaArchivo = RutaArchivosArmellini.Text & "\Response_NCE" & prmIDVentasDevoluciones & ".txt"
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

        If (docRespuesta.codigo = 200) Then
            tmpCodRespuesta = docRespuesta.codigo
            tmpConsecutivo = docRespuesta.consecutivoDocumento
            tmpCufe = docRespuesta.cufe
            tmpMensajes = docRespuesta.mensaje
            tmpResultado = docRespuesta.resultado
            tmpCodigoFE = CInt(objDocto.consecutivoDocumento)
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

        If tmpMinutes < 0 Then

            CreaColaEnvioNotasCredito()
            RecorrerDataNCEnvioAutomatico()

            Var_UltimoMomentoCorrio = Now


        End If
    End Sub

    Private Sub RecorrerDataNCEnvioAutomatico()
        Dim CursorNC As dsNotasCreditoXProcesar.InterfazNotasCreditoRow

        Select Case Me.IDEmpresaIntermediaria.SelectedItem("FormatoArchivo")
            Case "XML"
                For Each CursorNC In Me.DsNotasCreditoXProcesar1.InterfazNotasCredito
                    EnviaArchivoNotaCreditoElectronica(CursorNC.IDVentasDevoluciones, CursorNC.Codigo)
                Next
        End Select

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

        Dim port As BasicHttpBinding = New BasicHttpBinding()
        port.MaxBufferPoolSize = Int32.MaxValue
        port.MaxBufferSize = Int32.MaxValue
        port.MaxReceivedMessageSize = Int32.MaxValue
        port.ReaderQuotas.MaxStringContentLength = Int32.MaxValue
        port.SendTimeout = TimeSpan.FromMinutes(2)
        port.ReceiveTimeout = TimeSpan.FromMinutes(2)
        'Dim endPointEmision As EndpointAddress = New EndpointAddress("http://testubl21.thefactoryhka.com.co/ws/v1.0/Service.svc?wsdl")
        'Dim endPointAdjuntos As EndpointAddress = New EndpointAddress("http://testubl21.thefactoryhka.com.co/ws/adjuntos/Service.svc?wsdl")

        Dim strEndPointEmision As String
        Dim strEndPointAdjuntos As String

        strEndPointEmision = Me.cmbCompania.SelectedItem("EndPointEmision")
        strEndPointAdjuntos = Me.cmbCompania.SelectedItem("EndPointAdjuntos")

        Dim endPointEmision As EndpointAddress = New EndpointAddress(strEndPointEmision)
        Dim endPointAdjuntos As EndpointAddress = New EndpointAddress(strEndPointAdjuntos)

        serviceClientEm = New ServicioEmi.ServiceClient(port, endPointEmision)
        serviceArchivos = New ServicioAdjuntos.ServiceClient(port, endPointAdjuntos)

        objSuperClass.Show(Me.cmbCompania.SelectedItem("IDAppParametros"))
    End Sub
End Class