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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoreForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.VF_IDPOVentas_IDClientes_Nombre = New System.Windows.Forms.TextBox()
        Me.CF_IDPOVentas_IDClientes_Nombre = New System.Windows.Forms.CheckBox()
        Me.VF_IDPOVentas_IDClientes_Codigo = New System.Windows.Forms.TextBox()
        Me.CF_IDPOVentas_IDClientes_Codigo = New System.Windows.Forms.CheckBox()
        Me.VF_IDPOVentas_PO = New System.Windows.Forms.TextBox()
        Me.CF_IDPOVentas_PO = New System.Windows.Forms.CheckBox()
        Me.VF_CodFactura = New System.Windows.Forms.TextBox()
        Me.CF_CodFactura = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dsAux = New System.Data.DataSet()
        Me.Panel1.SuspendLayout()
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
        CType(Me.dsAux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1528, 265)
        Me.Panel1.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(89, 177)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 17)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Token Password"
        '
        'tokenPassword
        '
        Me.tokenPassword.Location = New System.Drawing.Point(209, 174)
        Me.tokenPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.tokenPassword.Name = "tokenPassword"
        Me.tokenPassword.Size = New System.Drawing.Size(639, 22)
        Me.tokenPassword.TabIndex = 26
        Me.tokenPassword.Text = "ce2e45d0d5f7479490663d1c113c892434d2da29"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(88, 145)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Token"
        '
        'tokenLogin
        '
        Me.tokenLogin.Location = New System.Drawing.Point(208, 142)
        Me.tokenLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.tokenLogin.Name = "tokenLogin"
        Me.tokenLogin.Size = New System.Drawing.Size(639, 22)
        Me.tokenLogin.TabIndex = 24
        Me.tokenLogin.Text = "cb310720e02e40c4b3c1dac8f7e271c8b2c2f528"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(732, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Intermediaria"
        '
        'IDEmpresaIntermediaria
        '
        Me.IDEmpresaIntermediaria.FormattingEnabled = True
        Me.IDEmpresaIntermediaria.Location = New System.Drawing.Point(736, 39)
        Me.IDEmpresaIntermediaria.Margin = New System.Windows.Forms.Padding(4)
        Me.IDEmpresaIntermediaria.Name = "IDEmpresaIntermediaria"
        Me.IDEmpresaIntermediaria.Size = New System.Drawing.Size(464, 24)
        Me.IDEmpresaIntermediaria.TabIndex = 21
        '
        'FInicioProduccion
        '
        Me.FInicioProduccion.Location = New System.Drawing.Point(581, 108)
        Me.FInicioProduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.FInicioProduccion.Name = "FInicioProduccion"
        Me.FInicioProduccion.Size = New System.Drawing.Size(265, 22)
        Me.FInicioProduccion.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(501, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "F. Final"
        '
        'FInicioPruebas
        '
        Me.FInicioPruebas.Location = New System.Drawing.Point(208, 108)
        Me.FInicioPruebas.Margin = New System.Windows.Forms.Padding(4)
        Me.FInicioPruebas.Name = "FInicioPruebas"
        Me.FInicioPruebas.Size = New System.Drawing.Size(265, 22)
        Me.FInicioPruebas.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "F. Inicio"
        '
        'lblLastTimeRan
        '
        Me.lblLastTimeRan.AutoSize = True
        Me.lblLastTimeRan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastTimeRan.Location = New System.Drawing.Point(664, 231)
        Me.lblLastTimeRan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastTimeRan.Name = "lblLastTimeRan"
        Me.lblLastTimeRan.Size = New System.Drawing.Size(118, 17)
        Me.lblLastTimeRan.TabIndex = 16
        Me.lblLastTimeRan.Text = "Last Time Ran:"
        '
        'lblTiempoRestanteNuevoCargue
        '
        Me.lblTiempoRestanteNuevoCargue.AutoSize = True
        Me.lblTiempoRestanteNuevoCargue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoRestanteNuevoCargue.Location = New System.Drawing.Point(241, 231)
        Me.lblTiempoRestanteNuevoCargue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTiempoRestanteNuevoCargue.Name = "lblTiempoRestanteNuevoCargue"
        Me.lblTiempoRestanteNuevoCargue.Size = New System.Drawing.Size(302, 17)
        Me.lblTiempoRestanteNuevoCargue.TabIndex = 15
        Me.lblTiempoRestanteNuevoCargue.Text = "Remaining Time for Next Upload (Mins): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Login Servicio"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(13, 231)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(115, 17)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status: Stoped"
        '
        'LoinIntermediario
        '
        Me.LoinIntermediario.Location = New System.Drawing.Point(209, 9)
        Me.LoinIntermediario.Margin = New System.Windows.Forms.Padding(4)
        Me.LoinIntermediario.Name = "LoinIntermediario"
        Me.LoinIntermediario.Size = New System.Drawing.Size(251, 22)
        Me.LoinIntermediario.TabIndex = 1
        Me.LoinIntermediario.Text = "maribelt@sunttelsoftware.com"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.Location = New System.Drawing.Point(1237, 114)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(256, 52)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "Save Config"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnDEtener
        '
        Me.btnDEtener.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDEtener.ImageIndex = 3
        Me.btnDEtener.Location = New System.Drawing.Point(1237, 59)
        Me.btnDEtener.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDEtener.Name = "btnDEtener"
        Me.btnDEtener.Size = New System.Drawing.Size(256, 48)
        Me.btnDEtener.TabIndex = 13
        Me.btnDEtener.Text = "Stop"
        Me.btnDEtener.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'btnCorrer
        '
        Me.btnCorrer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCorrer.ImageIndex = 2
        Me.btnCorrer.Location = New System.Drawing.Point(1237, 4)
        Me.btnCorrer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCorrer.Name = "btnCorrer"
        Me.btnCorrer.Size = New System.Drawing.Size(256, 48)
        Me.btnCorrer.TabIndex = 12
        Me.btnCorrer.Text = "Run"
        Me.btnCorrer.UseVisualStyleBackColor = True
        '
        'PasswordIntermediario
        '
        Me.PasswordIntermediario.Location = New System.Drawing.Point(600, 9)
        Me.PasswordIntermediario.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordIntermediario.Name = "PasswordIntermediario"
        Me.PasswordIntermediario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordIntermediario.Size = New System.Drawing.Size(109, 22)
        Me.PasswordIntermediario.TabIndex = 3
        Me.PasswordIntermediario.Text = "1234Asd@"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ruta Archivos a Enviar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Modo"
        '
        'RutaArchivosArmellini
        '
        Me.RutaArchivosArmellini.Location = New System.Drawing.Point(209, 41)
        Me.RutaArchivosArmellini.Margin = New System.Windows.Forms.Padding(4)
        Me.RutaArchivosArmellini.Name = "RutaArchivosArmellini"
        Me.RutaArchivosArmellini.Size = New System.Drawing.Size(449, 22)
        Me.RutaArchivosArmellini.TabIndex = 5
        Me.RutaArchivosArmellini.Text = "C:\ArchivosFacturasElectronicas"
        '
        'IDTiposEnvios
        '
        Me.IDTiposEnvios.FormattingEnabled = True
        Me.IDTiposEnvios.Location = New System.Drawing.Point(417, 75)
        Me.IDTiposEnvios.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTiposEnvios.Name = "IDTiposEnvios"
        Me.IDTiposEnvios.Size = New System.Drawing.Size(292, 24)
        Me.IDTiposEnvios.TabIndex = 9
        '
        'btnSelectFolder
        '
        Me.btnSelectFolder.Location = New System.Drawing.Point(668, 41)
        Me.btnSelectFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSelectFolder.Name = "btnSelectFolder"
        Me.btnSelectFolder.Size = New System.Drawing.Size(43, 25)
        Me.btnSelectFolder.TabIndex = 6
        Me.btnSelectFolder.UseVisualStyleBackColor = True
        '
        'FrecuenciaMins
        '
        Me.FrecuenciaMins.Location = New System.Drawing.Point(208, 75)
        Me.FrecuenciaMins.Margin = New System.Windows.Forms.Padding(4)
        Me.FrecuenciaMins.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.FrecuenciaMins.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FrecuenciaMins.Name = "FrecuenciaMins"
        Me.FrecuenciaMins.Size = New System.Drawing.Size(112, 22)
        Me.FrecuenciaMins.TabIndex = 8
        Me.FrecuenciaMins.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 78)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Frecuencia de Envío (Mins)"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 265)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1528, 416)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1520, 387)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Facturación"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(4, 58)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1512, 325)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dGridCurrentActivity)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(1504, 296)
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
        Me.dGridCurrentActivity.Location = New System.Drawing.Point(4, 4)
        Me.dGridCurrentActivity.Margin = New System.Windows.Forms.Padding(4)
        Me.dGridCurrentActivity.Name = "dGridCurrentActivity"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        Me.dGridCurrentActivity.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dGridCurrentActivity.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridCurrentActivity.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dGridCurrentActivity.RowTemplate.Height = 24
        Me.dGridCurrentActivity.Size = New System.Drawing.Size(1496, 258)
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
        Me.cMenuCola.Size = New System.Drawing.Size(232, 28)
        '
        'ForzarEnvíoDeFacturaToolStripMenuItem
        '
        Me.ForzarEnvíoDeFacturaToolStripMenuItem.Name = "ForzarEnvíoDeFacturaToolStripMenuItem"
        Me.ForzarEnvíoDeFacturaToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
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
        Me.Panel3.Location = New System.Drawing.Point(4, 262)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1496, 30)
        Me.Panel3.TabIndex = 137
        '
        'lblRecordsCurrentActivity
        '
        Me.lblRecordsCurrentActivity.AutoSize = True
        Me.lblRecordsCurrentActivity.ForeColor = System.Drawing.Color.LightBlue
        Me.lblRecordsCurrentActivity.Location = New System.Drawing.Point(15, 6)
        Me.lblRecordsCurrentActivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecordsCurrentActivity.Name = "lblRecordsCurrentActivity"
        Me.lblRecordsCurrentActivity.Size = New System.Drawing.Size(77, 17)
        Me.lblRecordsCurrentActivity.TabIndex = 0
        Me.lblRecordsCurrentActivity.Text = "Registro: 0"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dGridHistorial)
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(1504, 296)
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
        Me.dGridHistorial.Location = New System.Drawing.Point(4, 47)
        Me.dGridHistorial.Margin = New System.Windows.Forms.Padding(4)
        Me.dGridHistorial.Name = "dGridHistorial"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.dGridHistorial.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dGridHistorial.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGridHistorial.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dGridHistorial.RowTemplate.Height = 24
        Me.dGridHistorial.Size = New System.Drawing.Size(1496, 215)
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
        Me.Panel5.Location = New System.Drawing.Point(4, 4)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1496, 43)
        Me.Panel5.TabIndex = 141
        '
        'btnConsultarHistoria
        '
        Me.btnConsultarHistoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarHistoria.ImageIndex = 2
        Me.btnConsultarHistoria.Location = New System.Drawing.Point(837, 10)
        Me.btnConsultarHistoria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultarHistoria.Name = "btnConsultarHistoria"
        Me.btnConsultarHistoria.Size = New System.Drawing.Size(111, 26)
        Me.btnConsultarHistoria.TabIndex = 25
        Me.btnConsultarHistoria.Text = "Consultar"
        Me.btnConsultarHistoria.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(519, 10)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(309, 22)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(449, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Hasta"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(152, 10)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker2.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(33, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Consultar desde"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(4, 262)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1496, 30)
        Me.Panel4.TabIndex = 139
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.LightBlue
        Me.Label8.Location = New System.Drawing.Point(15, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Registro: 0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.VCF_Error)
        Me.Panel2.Controls.Add(Me.CF_Error)
        Me.Panel2.Controls.Add(Me.VF_IDPOVentas_IDClientes_Nombre)
        Me.Panel2.Controls.Add(Me.CF_IDPOVentas_IDClientes_Nombre)
        Me.Panel2.Controls.Add(Me.VF_IDPOVentas_IDClientes_Codigo)
        Me.Panel2.Controls.Add(Me.CF_IDPOVentas_IDClientes_Codigo)
        Me.Panel2.Controls.Add(Me.VF_IDPOVentas_PO)
        Me.Panel2.Controls.Add(Me.CF_IDPOVentas_PO)
        Me.Panel2.Controls.Add(Me.VF_CodFactura)
        Me.Panel2.Controls.Add(Me.CF_CodFactura)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1512, 54)
        Me.Panel2.TabIndex = 1
        '
        'VCF_Error
        '
        Me.VCF_Error.Location = New System.Drawing.Point(1181, 10)
        Me.VCF_Error.Margin = New System.Windows.Forms.Padding(4)
        Me.VCF_Error.Name = "VCF_Error"
        Me.VCF_Error.Size = New System.Drawing.Size(187, 22)
        Me.VCF_Error.TabIndex = 19
        '
        'CF_Error
        '
        Me.CF_Error.AutoSize = True
        Me.CF_Error.Location = New System.Drawing.Point(1109, 12)
        Me.CF_Error.Margin = New System.Windows.Forms.Padding(4)
        Me.CF_Error.Name = "CF_Error"
        Me.CF_Error.Size = New System.Drawing.Size(62, 21)
        Me.CF_Error.TabIndex = 18
        Me.CF_Error.Text = "Error"
        Me.CF_Error.UseVisualStyleBackColor = True
        '
        'VF_IDPOVentas_IDClientes_Nombre
        '
        Me.VF_IDPOVentas_IDClientes_Nombre.Location = New System.Drawing.Point(843, 10)
        Me.VF_IDPOVentas_IDClientes_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.VF_IDPOVentas_IDClientes_Nombre.Name = "VF_IDPOVentas_IDClientes_Nombre"
        Me.VF_IDPOVentas_IDClientes_Nombre.Size = New System.Drawing.Size(244, 22)
        Me.VF_IDPOVentas_IDClientes_Nombre.TabIndex = 17
        '
        'CF_IDPOVentas_IDClientes_Nombre
        '
        Me.CF_IDPOVentas_IDClientes_Nombre.AutoSize = True
        Me.CF_IDPOVentas_IDClientes_Nombre.Location = New System.Drawing.Point(757, 12)
        Me.CF_IDPOVentas_IDClientes_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.CF_IDPOVentas_IDClientes_Nombre.Name = "CF_IDPOVentas_IDClientes_Nombre"
        Me.CF_IDPOVentas_IDClientes_Nombre.Size = New System.Drawing.Size(73, 21)
        Me.CF_IDPOVentas_IDClientes_Nombre.TabIndex = 16
        Me.CF_IDPOVentas_IDClientes_Nombre.Text = "Cliente"
        Me.CF_IDPOVentas_IDClientes_Nombre.UseVisualStyleBackColor = True
        '
        'VF_IDPOVentas_IDClientes_Codigo
        '
        Me.VF_IDPOVentas_IDClientes_Codigo.Location = New System.Drawing.Point(616, 10)
        Me.VF_IDPOVentas_IDClientes_Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.VF_IDPOVentas_IDClientes_Codigo.Name = "VF_IDPOVentas_IDClientes_Codigo"
        Me.VF_IDPOVentas_IDClientes_Codigo.Size = New System.Drawing.Size(132, 22)
        Me.VF_IDPOVentas_IDClientes_Codigo.TabIndex = 15
        '
        'CF_IDPOVentas_IDClientes_Codigo
        '
        Me.CF_IDPOVentas_IDClientes_Codigo.AutoSize = True
        Me.CF_IDPOVentas_IDClientes_Codigo.Location = New System.Drawing.Point(477, 12)
        Me.CF_IDPOVentas_IDClientes_Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.CF_IDPOVentas_IDClientes_Codigo.Name = "CF_IDPOVentas_IDClientes_Codigo"
        Me.CF_IDPOVentas_IDClientes_Codigo.Size = New System.Drawing.Size(106, 21)
        Me.CF_IDPOVentas_IDClientes_Codigo.TabIndex = 14
        Me.CF_IDPOVentas_IDClientes_Codigo.Text = "Cod. Cliente"
        Me.CF_IDPOVentas_IDClientes_Codigo.UseVisualStyleBackColor = True
        '
        'VF_IDPOVentas_PO
        '
        Me.VF_IDPOVentas_PO.Location = New System.Drawing.Point(332, 10)
        Me.VF_IDPOVentas_PO.Margin = New System.Windows.Forms.Padding(4)
        Me.VF_IDPOVentas_PO.Name = "VF_IDPOVentas_PO"
        Me.VF_IDPOVentas_PO.Size = New System.Drawing.Size(132, 22)
        Me.VF_IDPOVentas_PO.TabIndex = 13
        '
        'CF_IDPOVentas_PO
        '
        Me.CF_IDPOVentas_PO.AutoSize = True
        Me.CF_IDPOVentas_PO.Location = New System.Drawing.Point(255, 12)
        Me.CF_IDPOVentas_PO.Margin = New System.Windows.Forms.Padding(4)
        Me.CF_IDPOVentas_PO.Name = "CF_IDPOVentas_PO"
        Me.CF_IDPOVentas_PO.Size = New System.Drawing.Size(59, 21)
        Me.CF_IDPOVentas_PO.TabIndex = 12
        Me.CF_IDPOVentas_PO.Text = "Cufe"
        Me.CF_IDPOVentas_PO.UseVisualStyleBackColor = True
        '
        'VF_CodFactura
        '
        Me.VF_CodFactura.Location = New System.Drawing.Point(123, 10)
        Me.VF_CodFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.VF_CodFactura.Name = "VF_CodFactura"
        Me.VF_CodFactura.Size = New System.Drawing.Size(115, 22)
        Me.VF_CodFactura.TabIndex = 11
        '
        'CF_CodFactura
        '
        Me.CF_CodFactura.AutoSize = True
        Me.CF_CodFactura.Location = New System.Drawing.Point(15, 12)
        Me.CF_CodFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.CF_CodFactura.Name = "CF_CodFactura"
        Me.CF_CodFactura.Size = New System.Drawing.Size(94, 21)
        Me.CF_CodFactura.TabIndex = 10
        Me.CF_CodFactura.Text = "Factura  #"
        Me.CF_CodFactura.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1520, 387)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Devoluciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'dsAux
        '
        Me.dsAux.DataSetName = "NewDataSet"
        '
        'CoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 681)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sunttel - Sistema Interfas de Facturación  Electrónica"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VCF_Error As TextBox
    Friend WithEvents CF_Error As CheckBox
    Friend WithEvents VF_IDPOVentas_IDClientes_Nombre As TextBox
    Friend WithEvents CF_IDPOVentas_IDClientes_Nombre As CheckBox
    Friend WithEvents VF_IDPOVentas_IDClientes_Codigo As TextBox
    Friend WithEvents CF_IDPOVentas_IDClientes_Codigo As CheckBox
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
End Class
