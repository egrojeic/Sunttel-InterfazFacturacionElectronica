Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module CoreModule

    Public Var_TipoServicio As Integer = 0
    Public Var_LoginServicio As String = ""
    Public Var_PasswordSevicio As String = ""
    Public Var_RutaArchivos As String = ""
    Public Var_FrecuenciaMinsSenso As Integer = 10

    Public ServidorSQL As String = ""
    Public BaseDatos As String = ""
    Public SysLogin As String = ""
    Public SysPassword As String = ""
    Public strConeccionDB As String = ""

    Public FormatoFecha As String = "yyyy-MM-dd"
    Public FormatoFechaHora As String = "yyyy-MM-dd HH:mm"
    Public FormatoDecimal As String = "####0.00"

    Public TiempoInicial As DateTime = Now
    Public dsConexiones As New dsConections


    Public Sub IniciaApp()
        On Error GoTo ControlaError

        Dim json As JObject
        Dim value As String = File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\Conections")

        json = JsonConvert.DeserializeObject(value)

        Dim tmpNuevaFila As dsConections.ConectionsRow

        For Each datajson In json("Conections")
            tmpNuevaFila = dsConexiones.Conections.NewConectionsRow
            With tmpNuevaFila
                .IDAppParametros = datajson("IDAppParametros")
                .Compania = datajson("Compania")
                .BaseDatos = datajson("BaseDatos")
                .FrecMins = datajson("FrecMins")
                .RutaArchivo = datajson("RutaArchivo")
                .ServidorSQL = datajson("ServidorSQL")
                .Login = datajson("Login")
                .Password = datajson("Password")
                .EndPointEmision = datajson("EndPointEmision")
                .EndPointAdjuntos = datajson("EndPointAdjuntos")
            End With

            dsConexiones.Conections.AddConectionsRow(tmpNuevaFila)
        Next


        'Var_RutaArchivos = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "Var_RutaArchivos", "c:\ArchivosFacturasElectronicas")
        'Var_FrecuenciaMinsSenso = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "FrecMins", "10")

        'ServidorSQL = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_S", "190.145.236.37,19433\MSSQLSERVER")
        'BaseDatos = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_B", "POS_INTERFAS_FACTURACION_ELECTRONICA")
        'SysLogin = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_L", "sa")
        'SysPassword = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_P", "HpMl110g7*")

        'strConeccionDB = GetStringConeccionDB(ServidorSQL, BaseDatos, SysLogin, SysPassword)
        Exit Sub
ControlaError:
        MessageBox.Show(Err.Description)

    End Sub


    Public Function GetStringConeccionDB(ByVal prmServidor As String, ByVal prmDB As String, ByVal prmLogin As String, ByVal prmPassword As String) As String
        Dim strRsta As String = ""
        strRsta = "Data Source = " & prmServidor & "; Initial Catalog = " & prmDB & "; User Id = " & prmLogin & "; Password = " & prmPassword
        Return strRsta
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
            .CommandTimeout = 0

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
        MessageBox.Show(strError + ": " & prmStrSQL)

    End Sub

    Public Sub ExportaTabla(ByVal prmDataTable As DataTable, ByVal prmDirectorio As String, Optional ByVal prmCamposNO As String = "", Optional ByVal NombreArchivo As String = "", Optional ByVal chrSeparador As String = "", Optional ByVal prmExtension As String = "")
        Dim Cursor As DataRow
        Dim tmpNombreArchivo As String = ""
        Dim tmpPathArchivo As String = ""
        Dim tmpStrArchivo As String = ""
        Dim tmpLinea As String = ""
        On Error GoTo ControlaError
        If NombreArchivo.Length > 0 Then
            tmpNombreArchivo = NombreArchivo
        Else
            tmpNombreArchivo = prmDataTable.TableName
        End If
        tmpPathArchivo = prmDirectorio.Trim & "\" & tmpNombreArchivo.Trim & prmExtension
        Dim Escritor As New StreamWriter(tmpPathArchivo, False, System.Text.Encoding.UTF8)

        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim CursorCampos As DataColumn



        For Each Cursor In prmDataTable.Rows
            If Cursor.RowState <> DataRowState.Deleted Then
                tmpLinea = ""
                For Each CursorCampos In prmDataTable.Columns
                    If Not (prmCamposNO.Contains(CursorCampos.ColumnName & ",") Or prmCamposNO.Contains("," & CursorCampos.ColumnName)) Then
                        If i = 0 Then
                            tmpLinea = Cursor.Item(CursorCampos.ColumnName)

                        Else
                            tmpLinea = tmpLinea & chrSeparador & Cursor.Item(CursorCampos.ColumnName)

                        End If
                        i = i + 1
                    Else
                        Dim a = "ajaja"
                    End If

                Next
                i = 0
                Escritor.WriteLine(tmpLinea)
            End If
        Next
        Escritor.Close()
        Exit Sub
ControlaError:
        Dim strError As String = Err.Description
    End Sub
End Module
