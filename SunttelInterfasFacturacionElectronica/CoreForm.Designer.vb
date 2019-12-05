<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoreForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoreForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ConsecutivoDesdeNC = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PreFijoNC = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FrecuenciaMinsNC = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblLastTimeRanNC = New System.Windows.Forms.Label()
        Me.lblTiempoRestanteNuevoCargueNC = New System.Windows.Forms.Label()
        Me.lblStatusNC = New System.Windows.Forms.Label()
        Me.ConsecutivoDesde = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PreFijo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tokenPassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tokenLogin = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IDEmpresaIntermediaria = New System.Windows.Forms.ComboBox()
        Me.FInicioProduccion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FInicioPruebas = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLastTimeRan = New System.Windows.Forms.Label()
        Me.lblTiempoRestanteNuevoCargue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.LoinIntermediario = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnDEtener = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCorrer = New System.Windows.Forms.Button()
        Me.PasswordIntermediario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RutaArchivosArmellini = New System.Windows.Forms.TextBox()
        Me.IDTiposEnvios = New System.Windows.Forms.ComboBox()
        Me.btnSelectFolder = New System.Windows.Forms.Button()
        Me.FrecuenciaMins = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dGridCurrentActivity = New System.Windows.Forms.DataGridView()
        Me.CodFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVentasFacturasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlagSentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DesErrorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StampTimeEnvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreArchivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CufeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTiposEnviosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMenuCola = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForzarEnvíoDeFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsColaDocsFacturas = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCloaDocsFacturasXProcesar1 = New SunttelInterfasFacturacionElectronica.dsCloaDocsFacturasXProcesar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblRecordsCurrentActivity = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dGridHistorial = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVentasFacturasDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlagSentDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesErrorDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StampTimeEnvioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreArchivoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTiposEnviosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CufeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodFacturaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsHistoria = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCloaDocsFacturasXProcesarHistoria = New SunttelInterfasFacturacionElectronica.dsCloaDocsFacturasXProcesar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnConsultarHistoria = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VCF_Error = New System.Windows.Forms.TextBox()
        Me.CF_Error = New System.Windows.Forms.CheckBox()
        Me.VF_NomCliente = New System.Windows.Forms.TextBox()
        Me.CF_NomCliente = New System.Windows.Forms.CheckBox()
        Me.VF_CodCliente = New System.Windows.Forms.TextBox()
        Me.CF_CodCliente = New System.Windows.Forms.CheckBox()
        Me.VF_IDPOVentas_PO = New System.Windows.Forms.TextBox()
        Me.CF_IDPOVentas_PO = New System.Windows.Forms.CheckBox()
        Me.VF_CodFactura = New System.Windows.Forms.TextBox()
        Me.CF_CodFactura = New System.Windows.Forms.CheckBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgridColaNotasCredito = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodClienteDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClienteDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreArchivoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StampTimeEnvioDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlagSentDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DesErrorDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensajesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoNCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodFacturaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CufeFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVentasFacturasDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTiposEnviosDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDVentasDevolucionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMenuColaNC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bsColaNotasCredito = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNotasCreditoXProcesar1 = New SunttelInterfasFacturacionElectronica.dsNotasCreditoXProcesar()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblNumRegistrosNC = New System.Windows.Forms.Label()
        Me.PanelFiltroNC = New System.Windows.Forms.Panel()
        Me.VF_Codigo = New System.Windows.Forms.TextBox()
        Me.CF_Codigo = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VF_AuxCampoNomCliente = New System.Windows.Forms.TextBox()
        Me.CF_AuxCampoNomCliente = New System.Windows.Forms.CheckBox()
        Me.VF_AuxCampoCodCliente = New System.Windows.Forms.TextBox()
        Me.CF_AuxCampoCodCliente = New System.Windows.Forms.CheckBox()
        Me.VF_AuxCampoCodFactura = New System.Windows.Forms.TextBox()
        Me.CF_AuxCampoCodFactura = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dsAux = New System.Data.DataSet()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.ConsecutivoDesdeNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrecuenciaMinsNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsecutivoDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrecuenciaMins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dGridCurrentActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cMenuCola.SuspendLayout()
        CType(Me.bsColaDocsFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCloaDocsFacturasXProcesar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dGridHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCloaDocsFacturasXProcesarHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgridColaNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMenuColaNC.SuspendLayout()
        CType(Me.bsColaNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNotasCreditoXProcesar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.PanelFiltroNC.SuspendLayout()
        CType(Me.dsAux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ConsecutivoDesdeNC)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.PreFijoNC)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.FrecuenciaMinsNC)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblLastTimeRanNC)
        Me.Panel1.Controls.Add(Me.lblTiempoRestanteNuevoCargueNC)
        Me.Panel1.Controls.Add(Me.lblStatusNC)
        Me.Panel1.Controls.Add(Me.ConsecutivoDesde)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PreFijo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.tokenPassword)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tokenLogin)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.IDEmpresaIntermediaria)
        Me.Panel1.Controls.Add(Me.FInicioProduccion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.FInicioPruebas)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblLastTimeRan)
        Me.Panel1.Controls.Add(Me.lblTiempoRestanteNuevoCargue)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.LoinIntermediario)
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.btnDEtener)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnCorrer)
        Me.Panel1.Controls.Add(Me.PasswordIntermediario)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.RutaArchivosArmellini)
        Me.Panel1.Controls.Add(Me.IDTiposEnvios)
        Me.Panel1.Controls.Add(Me.btnSelectFolder)
        Me.Panel1.Controls.Add(Me.FrecuenciaMins)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1140, 242)
        Me.Panel1.TabIndex = 4
        '
        'ConsecutivoDesdeNC
        '
        Me.ConsecutivoDesdeNC.Location = New System.Drawing.Point(687, 87)
        Me.ConsecutivoDesdeNC.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.ConsecutivoDesdeNC.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ConsecutivoDesdeNC.Name = "ConsecutivoDesdeNC"
        Me.ConsecutivoDesdeNC.Size = New System.Drawing.Size(84, 20)
        Me.ConsecutivoDesdeNC.TabIndex = 39
        Me.ConsecutivoDesdeNC.UseWaitCursor = True
        Me.ConsecutivoDesdeNC.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(643, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Desde"
        '
        'PreFijoNC
        '
        Me.PreFijoNC.Location = New System.Drawing.Point(597, 86)
        Me.PreFijoNC.Name = "PreFijoNC"
        Me.PreFijoNC.Size = New System.Drawing.Size(40, 20)
        Me.PreFijoNC.TabIndex = 37
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(550, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "PF N.C"
        '
        'FrecuenciaMinsNC
        '
        Me.FrecuenciaMinsNC.Location = New System.Drawing.Point(177, 87)
        Me.FrecuenciaMinsNC.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.FrecuenciaMinsNC.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FrecuenciaMinsNC.Name = "FrecuenciaMinsNC"
        Me.FrecuenciaMinsNC.Size = New System.Drawing.Size(63, 20)
        Me.FrecuenciaMinsNC.TabIndex = 35
        Me.FrecuenciaMinsNC.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(159, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Frecuencia de Envío N.C (Mins)"
        '
        'lblLastTimeRanNC
        '
        Me.lblLastTimeRanNC.AutoSize = True
        Me.lblLastTimeRanNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastTimeRanNC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLastTimeRanNC.Location = New System.Drawing.Point(498, 220)
        Me.lblLastTimeRanNC.Name = "lblLastTimeRanNC"
        Me.lblLastTimeRanNC.Size = New System.Drawing.Size(93, 13)
        Me.lblLastTimeRanNC.TabIndex = 33
        Me.lblLastTimeRanNC.Text = "Last Time Ran:"
        '
        'lblTiempoRestanteNuevoCargueNC
        '
        Me.lblTiempoRestanteNuevoCargueNC.AutoSize = True
        Me.lblTiempoRestanteNuevoCargueNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoRestanteNuevoCargueNC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTiempoRestanteNuevoCargueNC.Location = New System.Drawing.Point(181, 220)
        Me.lblTiempoRestanteNuevoCargueNC.Name = "lblTiempoRestanteNuevoCargueNC"
        Me.lblTiempoRestanteNuevoCargueNC.Size = New System.Drawing.Size(236, 13)
        Me.lblTiempoRestanteNuevoCargueNC.TabIndex = 32
        Me.lblTiempoRestanteNuevoCargueNC.Text = "Remaining Time for Next Upload (Mins): "
        '
        'lblStatusNC
        '
        Me.lblStatusNC.AutoSize = True
        Me.lblStatusNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusNC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblStatusNC.Location = New System.Drawing.Point(10, 220)
        Me.lblStatusNC.Name = "lblStatusNC"
        Me.lblStatusNC.Size = New System.Drawing.Size(91, 13)
        Me.lblStatusNC.TabIndex = 31
        Me.lblStatusNC.Text = "Status: Stoped"
        '
        'ConsecutivoDesde
        '
        Me.ConsecutivoDesde.Location = New System.Drawing.Point(686, 62)
        Me.ConsecutivoDesde.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.ConsecutivoDesde.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ConsecutivoDesde.Name = "ConsecutivoDesde"
        Me.ConsecutivoDesde.Size = New System.Drawing.Size(84, 20)
        Me.ConsecutivoDesde.TabIndex = 30
        Me.ConsecutivoDesde.UseWaitCursor = True
        Me.ConsecutivoDesde.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(642, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Desde"
        '
        'PreFijo
        '
        Me.PreFijo.Location = New System.Drawing.Point(575, 61)
        Me.PreFijo.Name = "PreFijo"
        Me.PreFijo.Size = New System.Drawing.Size(61, 20)
        Me.PreFijo.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(549, 63)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "PF"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(67, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Token Password"
        '
        'tokenPassword
        '
        Me.tokenPassword.Location = New System.Drawing.Point(157, 166)
        Me.tokenPassword.Name = "tokenPassword"
        Me.tokenPassword.Size = New System.Drawing.Size(480, 20)
        Me.tokenPassword.TabIndex = 26
        Me.tokenPassword.Text = "ce2e45d0d5f7479490663d1c113c892434d2da29"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(66, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Token"
        '
        'tokenLogin
        '
        Me.tokenLogin.Location = New System.Drawing.Point(156, 140)
        Me.tokenLogin.Name = "tokenLogin"
        Me.tokenLogin.Size = New System.Drawing.Size(480, 20)
        Me.tokenLogin.TabIndex = 24
        Me.tokenLogin.Text = "cb310720e02e40c4b3c1dac8f7e271c8b2c2f528"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(549, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Intermediaria"
        '
        'IDEmpresaIntermediaria
        '
        Me.IDEmpresaIntermediaria.FormattingEnabled = True
        Me.IDEmpresaIntermediaria.Location = New System.Drawing.Point(552, 32)
        Me.IDEmpresaIntermediaria.Name = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediaria.Size = New System.Drawing.Size(349, 21)
        Me.IDEmpresaIntermediaria.TabIndex = 21
        '
        'FInicioProduccion
        '
        Me.FInicioProduccion.Location = New System.Drawing.Point(436, 113)
        Me.FInicioProduccion.Name = "FInicioProduccion"
        Me.FInicioProduccion.Size = New System.Drawing.Size(200, 20)
        Me.FInicioProduccion.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(376, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "F. Final"
        '
        'FInicioPruebas
        '
        Me.FInicioPruebas.Location = New System.Drawing.Point(156, 113)
        Me.FInicioPruebas.Name = "FInicioPruebas"
        Me.FInicioPruebas.Size = New System.Drawing.Size(200, 20)
        Me.FInicioPruebas.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "F. Inicio"
        '
        'lblLastTimeRan
        '
        Me.lblLastTimeRan.AutoSize = True
        Me.lblLastTimeRan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastTimeRan.Location = New System.Drawing.Point(498, 193)
        Me.lblLastTimeRan.Name = "lblLastTimeRan"
        Me.lblLastTimeRan.Size = New System.Drawing.Size(93, 13)
        Me.lblLastTimeRan.TabIndex = 16
        Me.lblLastTimeRan.Text = "Last Time Ran:"
        '
        'lblTiempoRestanteNuevoCargue
        '
        Me.lblTiempoRestanteNuevoCargue.AutoSize = True
        Me.lblTiempoRestanteNuevoCargue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoRestanteNuevoCargue.Location = New System.Drawing.Point(181, 193)
        Me.lblTiempoRestanteNuevoCargue.Name = "lblTiempoRestanteNuevoCargue"
        Me.lblTiempoRestanteNuevoCargue.Size = New System.Drawing.Size(236, 13)
        Me.lblTiempoRestanteNuevoCargue.TabIndex = 15
        Me.lblTiempoRestanteNuevoCargue.Text = "Remaining Time for Next Upload (Mins): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Login Servicio"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(10, 193)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(91, 13)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status: Stoped"
        '
        'LoinIntermediario
        '
        Me.LoinIntermediario.Location = New System.Drawing.Point(157, 7)
        Me.LoinIntermediario.Name = "LoinIntermediario"
        Me.LoinIntermediario.Size = New System.Drawing.Size(189, 20)
        Me.LoinIntermediario.TabIndex = 1
        Me.LoinIntermediario.Text = "maribelt@sunttelsoftware.com"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.Location = New System.Drawing.Point(928, 93)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(192, 42)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Save Config"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnDEtener
        '
        Me.btnDEtener.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDEtener.ImageIndex = 3
        Me.btnDEtener.Location = New System.Drawing.Point(928, 48)
        Me.btnDEtener.Name = "btnDEtener"
        Me.btnDEtener.Size = New System.Drawing.Size(192, 39)
        Me.btnDEtener.TabIndex = 13
        Me.btnDEtener.Text = "Stop"
        Me.btnDEtener.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'btnCorrer
        '
        Me.btnCorrer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCorrer.ImageIndex = 2
        Me.btnCorrer.Location = New System.Drawing.Point(928, 3)
        Me.btnCorrer.Name = "btnCorrer"
        Me.btnCorrer.Size = New System.Drawing.Size(192, 39)
        Me.btnCorrer.TabIndex = 12
        Me.btnCorrer.Text = "Run"
        Me.btnCorrer.UseVisualStyleBackColor = True
        '
        'PasswordIntermediario
        '
        Me.PasswordIntermediario.Location = New System.Drawing.Point(450, 7)
        Me.PasswordIntermediario.Name = "PasswordIntermediario"
        Me.PasswordIntermediario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordIntermediario.Size = New System.Drawing.Size(83, 20)
        Me.PasswordIntermediario.TabIndex = 3
        Me.PasswordIntermediario.Text = "1234Asd@"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ruta Archivos a Enviar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Modo"
        '
        'RutaArchivosArmellini
        '
        Me.RutaArchivosArmellini.Location = New System.Drawing.Point(157, 33)
        Me.RutaArchivosArmellini.Name = "RutaArchivosArmellini"
        Me.RutaArchivosArmellini.Size = New System.Drawing.Size(338, 20)
        Me.RutaArchivosArmellini.TabIndex = 5
        Me.RutaArchivosArmellini.Text = "C:\ArchivosFacturasElectronicas"
        '
        'IDTiposEnvios
        '
        Me.IDTiposEnvios.FormattingEnabled = True
        Me.IDTiposEnvios.Location = New System.Drawing.Point(313, 61)
        Me.IDTiposEnvios.Name = "IDTiposEnvios"
        Me.IDTiposEnvios.Size = New System.Drawing.Size(220, 21)
        Me.IDTiposEnvios.TabIndex = 9
        '
        'btnSelectFolder
        '
        Me.btnSelectFolder.Location = New System.Drawing.Point(501, 33)
        Me.btnSelectFolder.Name = "btnSelectFolder"
        Me.btnSelectFolder.Size = New System.Drawing.Size(32, 20)
        Me.btnSelectFolder.TabIndex = 6
        Me.btnSelectFolder.UseVisualStyleBackColor = True
        '
        'FrecuenciaMins
        '
        Me.FrecuenciaMins.Location = New System.Drawing.Point(156, 61)
        Me.FrecuenciaMins.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.FrecuenciaMins.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FrecuenciaMins.Name = "FrecuenciaMins"
        Me.FrecuenciaMins.Size = New System.Drawing.Size(84, 20)
        Me.FrecuenciaMins.TabIndex = 8
        Me.FrecuenciaMins.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Frecuencia de Envío (Mins)"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 242)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1140, 409)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1132, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 47)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1126, 333)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dGridCurrentActivity)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1118, 307)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Transacciones en Cola"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dGridCurrentActivity
        '
        Me.dGridCurrentActivity.AllowUserToAddRows = False
        Me.dGridCurrentActivity.AllowUserToDeleteRows = False
        Me.dGridCurrentActivity.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        Me.dGridCurrentActivity.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dGridCurrentActivity.AutoGenerateColumns = False
        Me.dGridCurrentActivity.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dGridCurrentActivity.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dGridCurrentActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridCurrentActivity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodFacturaDataGridViewTextBoxColumn, Me.FFactura, Me.CodClienteDataGridViewTextBoxColumn, Me.NomClienteDataGridViewTextBoxColumn, Me.IDVentasFacturasDataGridViewTextBoxColumn, Me.FlagSentDataGridViewTextBoxColumn, Me.DesErrorDataGridViewTextBoxColumn, Me.StampTimeEnvioDataGridViewTextBoxColumn, Me.NombreArchivoDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.ConsecutivoDocumentoDataGridViewTextBoxColumn, Me.CufeDataGridViewTextBoxColumn, Me.ResultadoDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn, Me.IDTiposEnviosDataGridViewTextBoxColumn})
        Me.dGridCurrentActivity.ContextMenuStrip = Me.cMenuCola
        Me.dGridCurrentActivity.DataSource = Me.bsColaDocsFacturas
        Me.dGridCurrentActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dGridCurrentActivity.Location = New System.Drawing.Point(3, 3)
        Me.dGridCurrentActivity.Name = "dGridCurrentActivity"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        Me.dGridCurrentActivity.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dGridCurrentActivity.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridCurrentActivity.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dGridCurrentActivity.RowTemplate.Height = 24
        Me.dGridCurrentActivity.Size = New System.Drawing.Size(1112, 277)
        Me.dGridCurrentActivity.TabIndex = 138
        '
        'CodFacturaDataGridViewTextBoxColumn
        '
        Me.CodFacturaDataGridViewTextBoxColumn.DataPropertyName = "CodFactura"
        Me.CodFacturaDataGridViewTextBoxColumn.HeaderText = "CodFactura"
        Me.CodFacturaDataGridViewTextBoxColumn.Name = "CodFacturaDataGridViewTextBoxColumn"
        '
        'FFactura
        '
        Me.FFactura.DataPropertyName = "FFactura"
        Me.FFactura.HeaderText = "FFactura"
        Me.FFactura.Name = "FFactura"
        '
        'CodClienteDataGridViewTextBoxColumn
        '
        Me.CodClienteDataGridViewTextBoxColumn.DataPropertyName = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.HeaderText = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn.Name = "CodClienteDataGridViewTextBoxColumn"
        '
        'NomClienteDataGridViewTextBoxColumn
        '
        Me.NomClienteDataGridViewTextBoxColumn.DataPropertyName = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn.HeaderText = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn.Name = "NomClienteDataGridViewTextBoxColumn"
        '
        'IDVentasFacturasDataGridViewTextBoxColumn
        '
        Me.IDVentasFacturasDataGridViewTextBoxColumn.DataPropertyName = "IDVentasFacturas"
        Me.IDVentasFacturasDataGridViewTextBoxColumn.HeaderText = "ID. VentasFacturas"
        Me.IDVentasFacturasDataGridViewTextBoxColumn.Name = "IDVentasFacturasDataGridViewTextBoxColumn"
        '
        'FlagSentDataGridViewTextBoxColumn
        '
        Me.FlagSentDataGridViewTextBoxColumn.DataPropertyName = "FlagSent"
        Me.FlagSentDataGridViewTextBoxColumn.FalseValue = "0"
        Me.FlagSentDataGridViewTextBoxColumn.HeaderText = "Sent"
        Me.FlagSentDataGridViewTextBoxColumn.Name = "FlagSentDataGridViewTextBoxColumn"
        Me.FlagSentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FlagSentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FlagSentDataGridViewTextBoxColumn.TrueValue = "1"
        Me.FlagSentDataGridViewTextBoxColumn.Width = 70
        '
        'DesErrorDataGridViewTextBoxColumn
        '
        Me.DesErrorDataGridViewTextBoxColumn.DataPropertyName = "DesError"
        Me.DesErrorDataGridViewTextBoxColumn.HeaderText = "Error"
        Me.DesErrorDataGridViewTextBoxColumn.Name = "DesErrorDataGridViewTextBoxColumn"
        '
        'StampTimeEnvioDataGridViewTextBoxColumn
        '
        Me.StampTimeEnvioDataGridViewTextBoxColumn.DataPropertyName = "StampTimeEnvio"
        Me.StampTimeEnvioDataGridViewTextBoxColumn.HeaderText = "Stamp Time Envio"
        Me.StampTimeEnvioDataGridViewTextBoxColumn.Name = "StampTimeEnvioDataGridViewTextBoxColumn"
        '
        'NombreArchivoDataGridViewTextBoxColumn
        '
        Me.NombreArchivoDataGridViewTextBoxColumn.DataPropertyName = "NombreArchivo"
        Me.NombreArchivoDataGridViewTextBoxColumn.HeaderText = "Archivo"
        Me.NombreArchivoDataGridViewTextBoxColumn.Name = "NombreArchivoDataGridViewTextBoxColumn"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        '
        'ConsecutivoDocumentoDataGridViewTextBoxColumn
        '
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "ConsecutivoDocumento"
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn.HeaderText = "Consecutivo Documento"
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn.Name = "ConsecutivoDocumentoDataGridViewTextBoxColumn"
        '
        'CufeDataGridViewTextBoxColumn
        '
        Me.CufeDataGridViewTextBoxColumn.DataPropertyName = "Cufe"
        Me.CufeDataGridViewTextBoxColumn.HeaderText = "Cufe"
        Me.CufeDataGridViewTextBoxColumn.Name = "CufeDataGridViewTextBoxColumn"
        '
        'ResultadoDataGridViewTextBoxColumn
        '
        Me.ResultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.Name = "ResultadoDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'IDEmpresaIntermediariaDataGridViewTextBoxColumn
        '
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn.DataPropertyName = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn.HeaderText = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn.Name = "IDEmpresaIntermediariaDataGridViewTextBoxColumn"
        '
        'IDTiposEnviosDataGridViewTextBoxColumn
        '
        Me.IDTiposEnviosDataGridViewTextBoxColumn.DataPropertyName = "IDTiposEnvios"
        Me.IDTiposEnviosDataGridViewTextBoxColumn.HeaderText = "ID. Tipos Envio"
        Me.IDTiposEnviosDataGridViewTextBoxColumn.Name = "IDTiposEnviosDataGridViewTextBoxColumn"
        '
        'cMenuCola
        '
        Me.cMenuCola.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cMenuCola.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForzarEnvíoDeFacturaToolStripMenuItem})
        Me.cMenuCola.Name = "cMenuCola"
        Me.cMenuCola.Size = New System.Drawing.Size(197, 26)
        '
        'ForzarEnvíoDeFacturaToolStripMenuItem
        '
        Me.ForzarEnvíoDeFacturaToolStripMenuItem.Name = "ForzarEnvíoDeFacturaToolStripMenuItem"
        Me.ForzarEnvíoDeFacturaToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ForzarEnvíoDeFacturaToolStripMenuItem.Text = "Forzar Envío de Factura"
        '
        'bsColaDocsFacturas
        '
        Me.bsColaDocsFacturas.DataMember = "InterfasFacturas"
        Me.bsColaDocsFacturas.DataSource = Me.DsCloaDocsFacturasXProcesar1
        '
        'DsCloaDocsFacturasXProcesar1
        '
        Me.DsCloaDocsFacturasXProcesar1.DataSetName = "dsCloaDocsFacturasXProcesar"
        Me.DsCloaDocsFacturasXProcesar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.lblRecordsCurrentActivity)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 280)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1112, 24)
        Me.Panel3.TabIndex = 137
        '
        'lblRecordsCurrentActivity
        '
        Me.lblRecordsCurrentActivity.AutoSize = True
        Me.lblRecordsCurrentActivity.ForeColor = System.Drawing.Color.LightBlue
        Me.lblRecordsCurrentActivity.Location = New System.Drawing.Point(11, 5)
        Me.lblRecordsCurrentActivity.Name = "lblRecordsCurrentActivity"
        Me.lblRecordsCurrentActivity.Size = New System.Drawing.Size(58, 13)
        Me.lblRecordsCurrentActivity.TabIndex = 0
        Me.lblRecordsCurrentActivity.Text = "Registro: 0"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dGridHistorial)
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1118, 334)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Historial de Transacciones"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dGridHistorial
        '
        Me.dGridHistorial.AllowUserToAddRows = False
        Me.dGridHistorial.AllowUserToDeleteRows = False
        Me.dGridHistorial.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue
        Me.dGridHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dGridHistorial.AutoGenerateColumns = False
        Me.dGridHistorial.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dGridHistorial.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dGridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.IDVentasFacturasDataGridViewTextBoxColumn1, Me.FlagSentDataGridViewTextBoxColumn1, Me.DesErrorDataGridViewTextBoxColumn1, Me.StampTimeEnvioDataGridViewTextBoxColumn1, Me.NombreArchivoDataGridViewTextBoxColumn1, Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn1, Me.IDTiposEnviosDataGridViewTextBoxColumn1, Me.CodigoDataGridViewTextBoxColumn1, Me.ConsecutivoDocumentoDataGridViewTextBoxColumn1, Me.CufeDataGridViewTextBoxColumn1, Me.ResultadoDataGridViewTextBoxColumn1, Me.CodFacturaDataGridViewTextBoxColumn1, Me.CodClienteDataGridViewTextBoxColumn1, Me.NomClienteDataGridViewTextBoxColumn1, Me.FFacturaDataGridViewTextBoxColumn})
        Me.dGridHistorial.DataSource = Me.bsHistoria
        Me.dGridHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dGridHistorial.Location = New System.Drawing.Point(3, 38)
        Me.dGridHistorial.Name = "dGridHistorial"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.dGridHistorial.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dGridHistorial.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridHistorial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dGridHistorial.RowTemplate.Height = 24
        Me.dGridHistorial.Size = New System.Drawing.Size(1112, 269)
        Me.dGridHistorial.TabIndex = 140
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'IDVentasFacturasDataGridViewTextBoxColumn1
        '
        Me.IDVentasFacturasDataGridViewTextBoxColumn1.DataPropertyName = "IDVentasFacturas"
        Me.IDVentasFacturasDataGridViewTextBoxColumn1.HeaderText = "IDVentasFacturas"
        Me.IDVentasFacturasDataGridViewTextBoxColumn1.Name = "IDVentasFacturasDataGridViewTextBoxColumn1"
        '
        'FlagSentDataGridViewTextBoxColumn1
        '
        Me.FlagSentDataGridViewTextBoxColumn1.DataPropertyName = "FlagSent"
        Me.FlagSentDataGridViewTextBoxColumn1.HeaderText = "FlagSent"
        Me.FlagSentDataGridViewTextBoxColumn1.Name = "FlagSentDataGridViewTextBoxColumn1"
        '
        'DesErrorDataGridViewTextBoxColumn1
        '
        Me.DesErrorDataGridViewTextBoxColumn1.DataPropertyName = "DesError"
        Me.DesErrorDataGridViewTextBoxColumn1.HeaderText = "DesError"
        Me.DesErrorDataGridViewTextBoxColumn1.Name = "DesErrorDataGridViewTextBoxColumn1"
        '
        'StampTimeEnvioDataGridViewTextBoxColumn1
        '
        Me.StampTimeEnvioDataGridViewTextBoxColumn1.DataPropertyName = "StampTimeEnvio"
        Me.StampTimeEnvioDataGridViewTextBoxColumn1.HeaderText = "StampTimeEnvio"
        Me.StampTimeEnvioDataGridViewTextBoxColumn1.Name = "StampTimeEnvioDataGridViewTextBoxColumn1"
        '
        'NombreArchivoDataGridViewTextBoxColumn1
        '
        Me.NombreArchivoDataGridViewTextBoxColumn1.DataPropertyName = "NombreArchivo"
        Me.NombreArchivoDataGridViewTextBoxColumn1.HeaderText = "NombreArchivo"
        Me.NombreArchivoDataGridViewTextBoxColumn1.Name = "NombreArchivoDataGridViewTextBoxColumn1"
        '
        'IDEmpresaIntermediariaDataGridViewTextBoxColumn1
        '
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn1.DataPropertyName = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn1.HeaderText = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn1.Name = "IDEmpresaIntermediariaDataGridViewTextBoxColumn1"
        '
        'IDTiposEnviosDataGridViewTextBoxColumn1
        '
        Me.IDTiposEnviosDataGridViewTextBoxColumn1.DataPropertyName = "IDTiposEnvios"
        Me.IDTiposEnviosDataGridViewTextBoxColumn1.HeaderText = "IDTiposEnvios"
        Me.IDTiposEnviosDataGridViewTextBoxColumn1.Name = "IDTiposEnviosDataGridViewTextBoxColumn1"
        '
        'CodigoDataGridViewTextBoxColumn1
        '
        Me.CodigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn1.Name = "CodigoDataGridViewTextBoxColumn1"
        '
        'ConsecutivoDocumentoDataGridViewTextBoxColumn1
        '
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn1.DataPropertyName = "ConsecutivoDocumento"
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn1.HeaderText = "ConsecutivoDocumento"
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn1.Name = "ConsecutivoDocumentoDataGridViewTextBoxColumn1"
        '
        'CufeDataGridViewTextBoxColumn1
        '
        Me.CufeDataGridViewTextBoxColumn1.DataPropertyName = "Cufe"
        Me.CufeDataGridViewTextBoxColumn1.HeaderText = "Cufe"
        Me.CufeDataGridViewTextBoxColumn1.Name = "CufeDataGridViewTextBoxColumn1"
        '
        'ResultadoDataGridViewTextBoxColumn1
        '
        Me.ResultadoDataGridViewTextBoxColumn1.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn1.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn1.Name = "ResultadoDataGridViewTextBoxColumn1"
        '
        'CodFacturaDataGridViewTextBoxColumn1
        '
        Me.CodFacturaDataGridViewTextBoxColumn1.DataPropertyName = "CodFactura"
        Me.CodFacturaDataGridViewTextBoxColumn1.HeaderText = "CodFactura"
        Me.CodFacturaDataGridViewTextBoxColumn1.Name = "CodFacturaDataGridViewTextBoxColumn1"
        '
        'CodClienteDataGridViewTextBoxColumn1
        '
        Me.CodClienteDataGridViewTextBoxColumn1.DataPropertyName = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn1.HeaderText = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn1.Name = "CodClienteDataGridViewTextBoxColumn1"
        '
        'NomClienteDataGridViewTextBoxColumn1
        '
        Me.NomClienteDataGridViewTextBoxColumn1.DataPropertyName = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn1.HeaderText = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn1.Name = "NomClienteDataGridViewTextBoxColumn1"
        '
        'FFacturaDataGridViewTextBoxColumn
        '
        Me.FFacturaDataGridViewTextBoxColumn.DataPropertyName = "FFactura"
        Me.FFacturaDataGridViewTextBoxColumn.HeaderText = "FFactura"
        Me.FFacturaDataGridViewTextBoxColumn.Name = "FFacturaDataGridViewTextBoxColumn"
        '
        'bsHistoria
        '
        Me.bsHistoria.DataMember = "InterfasFacturas"
        Me.bsHistoria.DataSource = Me.DsCloaDocsFacturasXProcesarHistoria
        '
        'DsCloaDocsFacturasXProcesarHistoria
        '
        Me.DsCloaDocsFacturasXProcesarHistoria.DataSetName = "dsCloaDocsFacturasXProcesar"
        Me.DsCloaDocsFacturasXProcesarHistoria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Controls.Add(Me.btnConsultarHistoria)
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.DateTimePicker2)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1112, 35)
        Me.Panel5.TabIndex = 141
        '
        'btnConsultarHistoria
        '
        Me.btnConsultarHistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarHistoria.ImageIndex = 2
        Me.btnConsultarHistoria.Location = New System.Drawing.Point(628, 8)
        Me.btnConsultarHistoria.Name = "btnConsultarHistoria"
        Me.btnConsultarHistoria.Size = New System.Drawing.Size(83, 21)
        Me.btnConsultarHistoria.TabIndex = 25
        Me.btnConsultarHistoria.Text = "Consultar"
        Me.btnConsultarHistoria.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(389, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(337, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Hasta"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(114, 8)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(25, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Consultar desde"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 307)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1112, 24)
        Me.Panel4.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.LightBlue
        Me.Label8.Location = New System.Drawing.Point(11, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Registro: 0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.VCF_Error)
        Me.Panel2.Controls.Add(Me.CF_Error)
        Me.Panel2.Controls.Add(Me.VF_NomCliente)
        Me.Panel2.Controls.Add(Me.CF_NomCliente)
        Me.Panel2.Controls.Add(Me.VF_CodCliente)
        Me.Panel2.Controls.Add(Me.CF_CodCliente)
        Me.Panel2.Controls.Add(Me.VF_IDPOVentas_PO)
        Me.Panel2.Controls.Add(Me.CF_IDPOVentas_PO)
        Me.Panel2.Controls.Add(Me.VF_CodFactura)
        Me.Panel2.Controls.Add(Me.CF_CodFactura)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1126, 44)
        Me.Panel2.TabIndex = 1
        '
        'VCF_Error
        '
        Me.VCF_Error.Location = New System.Drawing.Point(886, 8)
        Me.VCF_Error.Name = "VCF_Error"
        Me.VCF_Error.Size = New System.Drawing.Size(141, 20)
        Me.VCF_Error.TabIndex = 19
        '
        'CF_Error
        '
        Me.CF_Error.AutoSize = True
        Me.CF_Error.Location = New System.Drawing.Point(832, 10)
        Me.CF_Error.Name = "CF_Error"
        Me.CF_Error.Size = New System.Drawing.Size(48, 17)
        Me.CF_Error.TabIndex = 18
        Me.CF_Error.Text = "Error"
        Me.CF_Error.UseVisualStyleBackColor = True
        '
        'VF_NomCliente
        '
        Me.VF_NomCliente.Location = New System.Drawing.Point(632, 8)
        Me.VF_NomCliente.Name = "VF_NomCliente"
        Me.VF_NomCliente.Size = New System.Drawing.Size(184, 20)
        Me.VF_NomCliente.TabIndex = 17
        '
        'CF_NomCliente
        '
        Me.CF_NomCliente.AutoSize = True
        Me.CF_NomCliente.Location = New System.Drawing.Point(568, 10)
        Me.CF_NomCliente.Name = "CF_NomCliente"
        Me.CF_NomCliente.Size = New System.Drawing.Size(58, 17)
        Me.CF_NomCliente.TabIndex = 16
        Me.CF_NomCliente.Text = "Cliente"
        Me.CF_NomCliente.UseVisualStyleBackColor = True
        '
        'VF_CodCliente
        '
        Me.VF_CodCliente.Location = New System.Drawing.Point(462, 8)
        Me.VF_CodCliente.Name = "VF_CodCliente"
        Me.VF_CodCliente.Size = New System.Drawing.Size(100, 20)
        Me.VF_CodCliente.TabIndex = 15
        '
        'CF_CodCliente
        '
        Me.CF_CodCliente.AutoSize = True
        Me.CF_CodCliente.Location = New System.Drawing.Point(358, 10)
        Me.CF_CodCliente.Name = "CF_CodCliente"
        Me.CF_CodCliente.Size = New System.Drawing.Size(83, 17)
        Me.CF_CodCliente.TabIndex = 14
        Me.CF_CodCliente.Text = "Cod. Cliente"
        Me.CF_CodCliente.UseVisualStyleBackColor = True
        '
        'VF_IDPOVentas_PO
        '
        Me.VF_IDPOVentas_PO.Location = New System.Drawing.Point(249, 8)
        Me.VF_IDPOVentas_PO.Name = "VF_IDPOVentas_PO"
        Me.VF_IDPOVentas_PO.Size = New System.Drawing.Size(100, 20)
        Me.VF_IDPOVentas_PO.TabIndex = 13
        '
        'CF_IDPOVentas_PO
        '
        Me.CF_IDPOVentas_PO.AutoSize = True
        Me.CF_IDPOVentas_PO.Location = New System.Drawing.Point(191, 10)
        Me.CF_IDPOVentas_PO.Name = "CF_IDPOVentas_PO"
        Me.CF_IDPOVentas_PO.Size = New System.Drawing.Size(48, 17)
        Me.CF_IDPOVentas_PO.TabIndex = 12
        Me.CF_IDPOVentas_PO.Text = "Cufe"
        Me.CF_IDPOVentas_PO.UseVisualStyleBackColor = True
        '
        'VF_CodFactura
        '
        Me.VF_CodFactura.Location = New System.Drawing.Point(92, 8)
        Me.VF_CodFactura.Name = "VF_CodFactura"
        Me.VF_CodFactura.Size = New System.Drawing.Size(87, 20)
        Me.VF_CodFactura.TabIndex = 11
        '
        'CF_CodFactura
        '
        Me.CF_CodFactura.AutoSize = True
        Me.CF_CodFactura.Location = New System.Drawing.Point(11, 10)
        Me.CF_CodFactura.Name = "CF_CodFactura"
        Me.CF_CodFactura.Size = New System.Drawing.Size(75, 17)
        Me.CF_CodFactura.TabIndex = 10
        Me.CF_CodFactura.Text = "Factura  #"
        Me.CF_CodFactura.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TabControl3)
        Me.TabPage5.Controls.Add(Me.PanelFiltroNC)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1132, 383)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Notas Crédito"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 47)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1126, 333)
        Me.TabControl3.TabIndex = 2
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgridColaNotasCredito)
        Me.TabPage6.Controls.Add(Me.Panel6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1118, 307)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Transacciones en Cola"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgridColaNotasCredito
        '
        Me.dgridColaNotasCredito.AllowUserToAddRows = False
        Me.dgridColaNotasCredito.AllowUserToDeleteRows = False
        Me.dgridColaNotasCredito.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue
        Me.dgridColaNotasCredito.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgridColaNotasCredito.AutoGenerateColumns = False
        Me.dgridColaNotasCredito.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgridColaNotasCredito.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dgridColaNotasCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridColaNotasCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn2, Me.FNotaDataGridViewTextBoxColumn, Me.CodClienteDataGridViewTextBoxColumn2, Me.NomClienteDataGridViewTextBoxColumn2, Me.NombreArchivoDataGridViewTextBoxColumn2, Me.StampTimeEnvioDataGridViewTextBoxColumn2, Me.FlagSentDataGridViewTextBoxColumn2, Me.DesErrorDataGridViewTextBoxColumn2, Me.ConsecutivoDocumentoDataGridViewTextBoxColumn2, Me.ResultadoDataGridViewTextBoxColumn2, Me.MensajesDataGridViewTextBoxColumn, Me.CodigoNCEDataGridViewTextBoxColumn, Me.CodFacturaDataGridViewTextBoxColumn2, Me.CufeFacturaDataGridViewTextBoxColumn, Me.IDVentasFacturasDataGridViewTextBoxColumn2, Me.IDTiposEnviosDataGridViewTextBoxColumn2, Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn2, Me.IDVentasDevolucionesDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn2})
        Me.dgridColaNotasCredito.ContextMenuStrip = Me.CMenuColaNC
        Me.dgridColaNotasCredito.DataSource = Me.bsColaNotasCredito
        Me.dgridColaNotasCredito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgridColaNotasCredito.Location = New System.Drawing.Point(3, 3)
        Me.dgridColaNotasCredito.Name = "dgridColaNotasCredito"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue
        Me.dgridColaNotasCredito.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgridColaNotasCredito.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgridColaNotasCredito.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dgridColaNotasCredito.RowTemplate.Height = 24
        Me.dgridColaNotasCredito.Size = New System.Drawing.Size(1112, 277)
        Me.dgridColaNotasCredito.TabIndex = 138
        '
        'CodigoDataGridViewTextBoxColumn2
        '
        Me.CodigoDataGridViewTextBoxColumn2.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn2.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn2.Name = "CodigoDataGridViewTextBoxColumn2"
        '
        'FNotaDataGridViewTextBoxColumn
        '
        Me.FNotaDataGridViewTextBoxColumn.DataPropertyName = "FNota"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.FNotaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.FNotaDataGridViewTextBoxColumn.HeaderText = "F. Nota"
        Me.FNotaDataGridViewTextBoxColumn.Name = "FNotaDataGridViewTextBoxColumn"
        '
        'CodClienteDataGridViewTextBoxColumn2
        '
        Me.CodClienteDataGridViewTextBoxColumn2.DataPropertyName = "CodCliente"
        Me.CodClienteDataGridViewTextBoxColumn2.HeaderText = "Cod Cliente"
        Me.CodClienteDataGridViewTextBoxColumn2.Name = "CodClienteDataGridViewTextBoxColumn2"
        '
        'NomClienteDataGridViewTextBoxColumn2
        '
        Me.NomClienteDataGridViewTextBoxColumn2.DataPropertyName = "NomCliente"
        Me.NomClienteDataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.NomClienteDataGridViewTextBoxColumn2.Name = "NomClienteDataGridViewTextBoxColumn2"
        Me.NomClienteDataGridViewTextBoxColumn2.Width = 200
        '
        'NombreArchivoDataGridViewTextBoxColumn2
        '
        Me.NombreArchivoDataGridViewTextBoxColumn2.DataPropertyName = "NombreArchivo"
        Me.NombreArchivoDataGridViewTextBoxColumn2.HeaderText = "Nombre Archivo"
        Me.NombreArchivoDataGridViewTextBoxColumn2.Name = "NombreArchivoDataGridViewTextBoxColumn2"
        '
        'StampTimeEnvioDataGridViewTextBoxColumn2
        '
        Me.StampTimeEnvioDataGridViewTextBoxColumn2.DataPropertyName = "StampTimeEnvio"
        DataGridViewCellStyle7.Format = "G"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.StampTimeEnvioDataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.StampTimeEnvioDataGridViewTextBoxColumn2.HeaderText = "Stamp Time Envio"
        Me.StampTimeEnvioDataGridViewTextBoxColumn2.Name = "StampTimeEnvioDataGridViewTextBoxColumn2"
        '
        'FlagSentDataGridViewTextBoxColumn2
        '
        Me.FlagSentDataGridViewTextBoxColumn2.DataPropertyName = "FlagSent"
        Me.FlagSentDataGridViewTextBoxColumn2.FalseValue = "0"
        Me.FlagSentDataGridViewTextBoxColumn2.HeaderText = "Sent"
        Me.FlagSentDataGridViewTextBoxColumn2.Name = "FlagSentDataGridViewTextBoxColumn2"
        Me.FlagSentDataGridViewTextBoxColumn2.ReadOnly = True
        Me.FlagSentDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FlagSentDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FlagSentDataGridViewTextBoxColumn2.TrueValue = "1"
        '
        'DesErrorDataGridViewTextBoxColumn2
        '
        Me.DesErrorDataGridViewTextBoxColumn2.DataPropertyName = "DesError"
        Me.DesErrorDataGridViewTextBoxColumn2.HeaderText = "DesError"
        Me.DesErrorDataGridViewTextBoxColumn2.Name = "DesErrorDataGridViewTextBoxColumn2"
        '
        'ConsecutivoDocumentoDataGridViewTextBoxColumn2
        '
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn2.DataPropertyName = "ConsecutivoDocumento"
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn2.HeaderText = "Consecutivo Documento"
        Me.ConsecutivoDocumentoDataGridViewTextBoxColumn2.Name = "ConsecutivoDocumentoDataGridViewTextBoxColumn2"
        '
        'ResultadoDataGridViewTextBoxColumn2
        '
        Me.ResultadoDataGridViewTextBoxColumn2.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn2.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn2.Name = "ResultadoDataGridViewTextBoxColumn2"
        '
        'MensajesDataGridViewTextBoxColumn
        '
        Me.MensajesDataGridViewTextBoxColumn.DataPropertyName = "Mensajes"
        Me.MensajesDataGridViewTextBoxColumn.HeaderText = "Mensajes"
        Me.MensajesDataGridViewTextBoxColumn.Name = "MensajesDataGridViewTextBoxColumn"
        '
        'CodigoNCEDataGridViewTextBoxColumn
        '
        Me.CodigoNCEDataGridViewTextBoxColumn.DataPropertyName = "CodigoNCE"
        Me.CodigoNCEDataGridViewTextBoxColumn.HeaderText = "CodigoNCE"
        Me.CodigoNCEDataGridViewTextBoxColumn.Name = "CodigoNCEDataGridViewTextBoxColumn"
        '
        'CodFacturaDataGridViewTextBoxColumn2
        '
        Me.CodFacturaDataGridViewTextBoxColumn2.DataPropertyName = "CodFactura"
        Me.CodFacturaDataGridViewTextBoxColumn2.HeaderText = "Cod Factura"
        Me.CodFacturaDataGridViewTextBoxColumn2.Name = "CodFacturaDataGridViewTextBoxColumn2"
        '
        'CufeFacturaDataGridViewTextBoxColumn
        '
        Me.CufeFacturaDataGridViewTextBoxColumn.DataPropertyName = "CufeFactura"
        Me.CufeFacturaDataGridViewTextBoxColumn.HeaderText = "Cufe Factura"
        Me.CufeFacturaDataGridViewTextBoxColumn.Name = "CufeFacturaDataGridViewTextBoxColumn"
        '
        'IDVentasFacturasDataGridViewTextBoxColumn2
        '
        Me.IDVentasFacturasDataGridViewTextBoxColumn2.DataPropertyName = "IDVentasFacturas"
        Me.IDVentasFacturasDataGridViewTextBoxColumn2.HeaderText = "IDVentasFacturas"
        Me.IDVentasFacturasDataGridViewTextBoxColumn2.Name = "IDVentasFacturasDataGridViewTextBoxColumn2"
        '
        'IDTiposEnviosDataGridViewTextBoxColumn2
        '
        Me.IDTiposEnviosDataGridViewTextBoxColumn2.DataPropertyName = "IDTiposEnvios"
        Me.IDTiposEnviosDataGridViewTextBoxColumn2.HeaderText = "IDTiposEnvios"
        Me.IDTiposEnviosDataGridViewTextBoxColumn2.Name = "IDTiposEnviosDataGridViewTextBoxColumn2"
        '
        'IDEmpresaIntermediariaDataGridViewTextBoxColumn2
        '
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn2.DataPropertyName = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn2.HeaderText = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediariaDataGridViewTextBoxColumn2.Name = "IDEmpresaIntermediariaDataGridViewTextBoxColumn2"
        '
        'IDVentasDevolucionesDataGridViewTextBoxColumn
        '
        Me.IDVentasDevolucionesDataGridViewTextBoxColumn.DataPropertyName = "IDVentasDevoluciones"
        Me.IDVentasDevolucionesDataGridViewTextBoxColumn.HeaderText = "IDVentasDevoluciones"
        Me.IDVentasDevolucionesDataGridViewTextBoxColumn.Name = "IDVentasDevolucionesDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn2
        '
        Me.IDDataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn2.Name = "IDDataGridViewTextBoxColumn2"
        '
        'CMenuColaNC
        '
        Me.CMenuColaNC.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMenuColaNC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.CMenuColaNC.Name = "cMenuCola"
        Me.CMenuColaNC.Size = New System.Drawing.Size(226, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 22)
        Me.ToolStripMenuItem1.Text = "Forzar Envío de Nota Credito"
        '
        'bsColaNotasCredito
        '
        Me.bsColaNotasCredito.DataMember = "InterfazNotasCredito"
        Me.bsColaNotasCredito.DataSource = Me.DsNotasCreditoXProcesar1
        '
        'DsNotasCreditoXProcesar1
        '
        Me.DsNotasCreditoXProcesar1.DataSetName = "dsNotasCreditoXProcesar"
        Me.DsNotasCreditoXProcesar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Controls.Add(Me.lblNumRegistrosNC)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 280)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1112, 24)
        Me.Panel6.TabIndex = 137
        '
        'lblNumRegistrosNC
        '
        Me.lblNumRegistrosNC.AutoSize = True
        Me.lblNumRegistrosNC.ForeColor = System.Drawing.Color.LightBlue
        Me.lblNumRegistrosNC.Location = New System.Drawing.Point(11, 5)
        Me.lblNumRegistrosNC.Name = "lblNumRegistrosNC"
        Me.lblNumRegistrosNC.Size = New System.Drawing.Size(58, 13)
        Me.lblNumRegistrosNC.TabIndex = 0
        Me.lblNumRegistrosNC.Text = "Registro: 0"
        '
        'PanelFiltroNC
        '
        Me.PanelFiltroNC.BackColor = System.Drawing.Color.LightGray
        Me.PanelFiltroNC.Controls.Add(Me.VF_Codigo)
        Me.PanelFiltroNC.Controls.Add(Me.CF_Codigo)
        Me.PanelFiltroNC.Controls.Add(Me.TextBox1)
        Me.PanelFiltroNC.Controls.Add(Me.CheckBox1)
        Me.PanelFiltroNC.Controls.Add(Me.VF_AuxCampoNomCliente)
        Me.PanelFiltroNC.Controls.Add(Me.CF_AuxCampoNomCliente)
        Me.PanelFiltroNC.Controls.Add(Me.VF_AuxCampoCodCliente)
        Me.PanelFiltroNC.Controls.Add(Me.CF_AuxCampoCodCliente)
        Me.PanelFiltroNC.Controls.Add(Me.VF_AuxCampoCodFactura)
        Me.PanelFiltroNC.Controls.Add(Me.CF_AuxCampoCodFactura)
        Me.PanelFiltroNC.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFiltroNC.Location = New System.Drawing.Point(3, 3)
        Me.PanelFiltroNC.Name = "PanelFiltroNC"
        Me.PanelFiltroNC.Size = New System.Drawing.Size(1126, 44)
        Me.PanelFiltroNC.TabIndex = 3
        '
        'VF_Codigo
        '
        Me.VF_Codigo.Location = New System.Drawing.Point(87, 8)
        Me.VF_Codigo.Name = "VF_Codigo"
        Me.VF_Codigo.Size = New System.Drawing.Size(87, 20)
        Me.VF_Codigo.TabIndex = 21
        '
        'CF_Codigo
        '
        Me.CF_Codigo.AutoSize = True
        Me.CF_Codigo.Location = New System.Drawing.Point(11, 10)
        Me.CF_Codigo.Name = "CF_Codigo"
        Me.CF_Codigo.Size = New System.Drawing.Size(75, 17)
        Me.CF_Codigo.TabIndex = 20
        Me.CF_Codigo.Text = "Nota C.  #"
        Me.CF_Codigo.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(886, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 19
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(832, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Error"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'VF_AuxCampoNomCliente
        '
        Me.VF_AuxCampoNomCliente.Location = New System.Drawing.Point(632, 8)
        Me.VF_AuxCampoNomCliente.Name = "VF_AuxCampoNomCliente"
        Me.VF_AuxCampoNomCliente.Size = New System.Drawing.Size(184, 20)
        Me.VF_AuxCampoNomCliente.TabIndex = 17
        '
        'CF_AuxCampoNomCliente
        '
        Me.CF_AuxCampoNomCliente.AutoSize = True
        Me.CF_AuxCampoNomCliente.Location = New System.Drawing.Point(568, 10)
        Me.CF_AuxCampoNomCliente.Name = "CF_AuxCampoNomCliente"
        Me.CF_AuxCampoNomCliente.Size = New System.Drawing.Size(58, 17)
        Me.CF_AuxCampoNomCliente.TabIndex = 16
        Me.CF_AuxCampoNomCliente.Text = "Cliente"
        Me.CF_AuxCampoNomCliente.UseVisualStyleBackColor = True
        '
        'VF_AuxCampoCodCliente
        '
        Me.VF_AuxCampoCodCliente.Location = New System.Drawing.Point(462, 8)
        Me.VF_AuxCampoCodCliente.Name = "VF_AuxCampoCodCliente"
        Me.VF_AuxCampoCodCliente.Size = New System.Drawing.Size(100, 20)
        Me.VF_AuxCampoCodCliente.TabIndex = 15
        '
        'CF_AuxCampoCodCliente
        '
        Me.CF_AuxCampoCodCliente.AutoSize = True
        Me.CF_AuxCampoCodCliente.Location = New System.Drawing.Point(368, 10)
        Me.CF_AuxCampoCodCliente.Name = "CF_AuxCampoCodCliente"
        Me.CF_AuxCampoCodCliente.Size = New System.Drawing.Size(83, 17)
        Me.CF_AuxCampoCodCliente.TabIndex = 14
        Me.CF_AuxCampoCodCliente.Text = "Cod. Cliente"
        Me.CF_AuxCampoCodCliente.UseVisualStyleBackColor = True
        '
        'VF_AuxCampoCodFactura
        '
        Me.VF_AuxCampoCodFactura.Location = New System.Drawing.Point(265, 8)
        Me.VF_AuxCampoCodFactura.Name = "VF_AuxCampoCodFactura"
        Me.VF_AuxCampoCodFactura.Size = New System.Drawing.Size(87, 20)
        Me.VF_AuxCampoCodFactura.TabIndex = 11
        '
        'CF_AuxCampoCodFactura
        '
        Me.CF_AuxCampoCodFactura.AutoSize = True
        Me.CF_AuxCampoCodFactura.Location = New System.Drawing.Point(186, 10)
        Me.CF_AuxCampoCodFactura.Name = "CF_AuxCampoCodFactura"
        Me.CF_AuxCampoCodFactura.Size = New System.Drawing.Size(75, 17)
        Me.CF_AuxCampoCodFactura.TabIndex = 10
        Me.CF_AuxCampoCodFactura.Text = "Factura  #"
        Me.CF_AuxCampoCodFactura.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'dsAux
        '
        Me.dsAux.DataSetName = "NewDataSet"
        '
        'Timer2
        '
        '
        'CoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 651)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sunttel - Sistema Interfas de Facturación  Electrónica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ConsecutivoDesdeNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrecuenciaMinsNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsecutivoDesde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrecuenciaMins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dGridCurrentActivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cMenuCola.ResumeLayout(False)
        CType(Me.bsColaDocsFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCloaDocsFacturasXProcesar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dGridHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCloaDocsFacturasXProcesarHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgridColaNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMenuColaNC.ResumeLayout(False)
        CType(Me.bsColaNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNotasCreditoXProcesar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelFiltroNC.ResumeLayout(False)
        Me.PanelFiltroNC.PerformLayout()
        CType(Me.dsAux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLastTimeRan As Label
    Friend WithEvents lblTiempoRestanteNuevoCargue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents LoinIntermediario As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnDEtener As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCorrer As Button
    Friend WithEvents PasswordIntermediario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RutaArchivosArmellini As TextBox
    Friend WithEvents IDTiposEnvios As ComboBox
    Friend WithEvents btnSelectFolder As Button
    Friend WithEvents FrecuenciaMins As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VCF_Error As TextBox
    Friend WithEvents CF_Error As CheckBox
    Friend WithEvents VF_NomCliente As TextBox
    Friend WithEvents CF_NomCliente As CheckBox
    Friend WithEvents VF_CodCliente As TextBox
    Friend WithEvents CF_CodCliente As CheckBox
    Friend WithEvents VF_IDPOVentas_PO As TextBox
    Friend WithEvents CF_IDPOVentas_PO As CheckBox
    Friend WithEvents VF_CodFactura As TextBox
    Friend WithEvents CF_CodFactura As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents dsAux As DataSet
    Friend WithEvents FInicioProduccion As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents FInicioPruebas As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dGridCurrentActivity As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblRecordsCurrentActivity As Label
    Friend WithEvents dGridHistorial As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents bsColaDocsFacturas As BindingSource
    Friend WithEvents DsCloaDocsFacturasXProcesar1 As dsCloaDocsFacturasXProcesar
    Friend WithEvents CodFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FFactura As DataGridViewTextBoxColumn
    Friend WithEvents CodClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDVentasFacturasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FlagSentDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DesErrorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StampTimeEnvioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreArchivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConsecutivoDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CufeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDEmpresaIntermediariaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTiposEnviosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents IDEmpresaIntermediaria As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnConsultarHistoria As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDVentasFacturasDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FlagSentDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DesErrorDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StampTimeEnvioDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreArchivoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDEmpresaIntermediariaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDTiposEnviosDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ConsecutivoDocumentoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CufeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodFacturaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodClienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NomClienteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsHistoria As BindingSource
    Friend WithEvents DsCloaDocsFacturasXProcesarHistoria As dsCloaDocsFacturasXProcesar
    Friend WithEvents cMenuCola As ContextMenuStrip
    Friend WithEvents ForzarEnvíoDeFacturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label13 As Label
    Friend WithEvents tokenPassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tokenLogin As TextBox
    Friend WithEvents ConsecutivoDesde As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents PreFijo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgridColaNotasCredito As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblNumRegistrosNC As Label
    Friend WithEvents PanelFiltroNC As Panel
    Friend WithEvents VF_Codigo As TextBox
    Friend WithEvents CF_Codigo As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents VF_AuxCampoNomCliente As TextBox
    Friend WithEvents CF_AuxCampoNomCliente As CheckBox
    Friend WithEvents VF_AuxCampoCodCliente As TextBox
    Friend WithEvents CF_AuxCampoCodCliente As CheckBox
    Friend WithEvents VF_AuxCampoCodFactura As TextBox
    Friend WithEvents CF_AuxCampoCodFactura As CheckBox
    Friend WithEvents DsNotasCreditoXProcesar1 As dsNotasCreditoXProcesar
    Friend WithEvents bsColaNotasCredito As BindingSource
    Friend WithEvents CMenuColaNC As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CodigoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FNotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodClienteDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NomClienteDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NombreArchivoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents StampTimeEnvioDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FlagSentDataGridViewTextBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DesErrorDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ConsecutivoDocumentoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MensajesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoNCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodFacturaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CufeFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDVentasFacturasDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDTiposEnviosDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDEmpresaIntermediariaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDVentasDevolucionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblLastTimeRanNC As Label
    Friend WithEvents lblTiempoRestanteNuevoCargueNC As Label
    Friend WithEvents lblStatusNC As Label
    Friend WithEvents FrecuenciaMinsNC As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents ConsecutivoDesdeNC As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents PreFijoNC As TextBox
    Friend WithEvents Label18 As Label
End Class
