Imports System.Data.SqlClient


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

	Public TiempoInicial As DateTime = Now


    Public Sub IniciaApp()


        Var_RutaArchivos = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "Var_RutaArchivos", "c:\ArchivosFacturasElectronicas")
        Var_FrecuenciaMinsSenso = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "FrecMins", "10")

        ServidorSQL = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_S", "190.145.236.37,19433\MSSQLSERVER")
        BaseDatos = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_B", "POS_INTERFAS_FACTURACION_ELECTRONICA")
        SysLogin = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_L", "sa")
        SysPassword = GetSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_P", "HpMl110g7*")

        strConeccionDB = GetStringConeccionDB(ServidorSQL, BaseDatos, SysLogin, SysPassword)


	End Sub

    Public Function GetStringConeccionDB(ByVal prmServidor As String, ByVal prmDB As String, ByVal prmLogin As String, ByVal prmPassword As String) As String
        Dim strRsta As String = ""
        strRsta = "Data Source = " & prmServidor & "; Initial Catalog = " & prmDB & "; User Id = " & prmLogin & "; Password = " & prmPassword
        Return strRsta
    End Function

    Public Sub RegistraConfigSys()
		On Error GoTo ControlaError


        SaveSetting(System.Windows.Forms.Application.ProductName, "Startup", "Var_RutaArchivos", Var_RutaArchivos)
        SaveSetting(System.Windows.Forms.Application.ProductName, "Startup", "FrecMins", Var_FrecuenciaMinsSenso)

		SaveSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_S", ServidorSQL)
		SaveSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_B", BaseDatos)
		SaveSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_L", SysLogin)
		SaveSetting(System.Windows.Forms.Application.ProductName, "Startup", "HXS_P", SysPassword)



		Exit Sub
ControlaError:
        MessageBox.Show(Err.Description)
    End Sub


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

End Module
