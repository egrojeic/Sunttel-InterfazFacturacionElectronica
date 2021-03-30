<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstablecerNumFacturaElectronicaFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDPOVentasFacturas = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PF = New System.Windows.Forms.TextBox()
        Me.NumFacturaElectronica = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cufe = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.IDPOVentasFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumFacturaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 30)
        Me.Panel1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSalir.Location = New System.Drawing.Point(353, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(225, 30)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Cerrar Ventana"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(353, 30)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Establecer!"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Factura"
        '
        'IDPOVentasFacturas
        '
        Me.IDPOVentasFacturas.Location = New System.Drawing.Point(94, 12)
        Me.IDPOVentasFacturas.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.IDPOVentasFacturas.Name = "IDPOVentasFacturas"
        Me.IDPOVentasFacturas.Size = New System.Drawing.Size(138, 20)
        Me.IDPOVentasFacturas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prefijp"
        '
        'PF
        '
        Me.PF.Location = New System.Drawing.Point(280, 11)
        Me.PF.Name = "PF"
        Me.PF.Size = New System.Drawing.Size(52, 20)
        Me.PF.TabIndex = 4
        '
        'NumFacturaElectronica
        '
        Me.NumFacturaElectronica.Location = New System.Drawing.Point(465, 12)
        Me.NumFacturaElectronica.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.NumFacturaElectronica.Name = "NumFacturaElectronica"
        Me.NumFacturaElectronica.Size = New System.Drawing.Size(89, 20)
        Me.NumFacturaElectronica.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "# Factura Electronica"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cufe"
        '
        'Cufe
        '
        Me.Cufe.Location = New System.Drawing.Point(21, 79)
        Me.Cufe.Multiline = True
        Me.Cufe.Name = "Cufe"
        Me.Cufe.Size = New System.Drawing.Size(533, 75)
        Me.Cufe.TabIndex = 8
        '
        'EstablecerNumFacturaElectronicaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 205)
        Me.Controls.Add(Me.Cufe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumFacturaElectronica)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDPOVentasFacturas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "EstablecerNumFacturaElectronicaFrm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Establecer..."
        Me.Panel1.ResumeLayout(False)
        CType(Me.IDPOVentasFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumFacturaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IDPOVentasFacturas As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents PF As TextBox
    Friend WithEvents NumFacturaElectronica As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cufe As TextBox
End Class
