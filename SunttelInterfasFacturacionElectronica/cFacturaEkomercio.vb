Imports System.Xml

Public Class cFacturaEkomercio

    Dim dsArchivoPlano As dsArchivoPlano

    Public Sub New()
        dsArchivoPlano = New dsArchivoPlano()
    End Sub

    Public Function GeneraFileFacturaEkomercio(prmID As Integer) As dsArchivoPlano
        Dim tmpstrPath As String = ""

        Dim strResponse As XmlNode

        Dim strSQL As String = ""

        On Error Resume Next

        strSQL = "exec GetInfoFacturaTXT " & prmID.ToString
        LlenaDataSetGenerico(dsArchivoPlano.ArchivoPlano, "ArchivoPlano", strSQL, strConeccionDB)

        Return dsArchivoPlano

    End Function

    Public Function GeneraFileNotaCreditoEkomercio(prmID As Integer) As dsArchivoPlano
        Dim tmpstrPath As String = ""

        Dim strResponse As XmlNode

        Dim strSQL As String = ""

        On Error Resume Next

        strSQL = "exec GetInfoNotaCreditoTXT " & prmID.ToString
        LlenaDataSetGenerico(dsArchivoPlano.ArchivoPlano, "ArchivoPlano", strSQL, strConeccionDB)

        Return dsArchivoPlano

    End Function

End Class
