Imports SunttelDll2007


Public Class EstablecerNumFacturaElectronicaFrm

    Dim _tmpIDPOVentas As Integer = 0

    Public Sub New(prmIDPOVentas As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        _tmpIDPOVentas = prmIDPOVentas

    End Sub

    Private Sub EstablecerNumFacturaElectronicaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDPOVentasFacturas.Value = _tmpIDPOVentas
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Dispose(True)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        EstablecerFacturaElectronica()
        Me.Dispose(True)

    End Sub

    Private Sub EstablecerFacturaElectronica()

        Dim strSQL As String = ""
        Dim objGestionData As New cGestionData


        strSQL = $"exec ForzarEnvioFacturaElectronica {IDPOVentasFacturas.Value}, '{Me.PF.Text}', {Me.NumFacturaElectronica.Value}, '{Me.Cufe.Text}'"
        objGestionData.GetDatoEscalar(strSQL, cGestionData.TipoConeccion.SQLServerConeccion, strConeccionDB)


    End Sub
End Class