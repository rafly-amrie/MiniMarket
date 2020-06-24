<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNmPelanggan = New System.Windows.Forms.TextBox()
        Me.CmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNmBarang = New System.Windows.Forms.TextBox()
        Me.BarangTxt = New System.Windows.Forms.TextBox()
        Me.LblHrg = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.TextBox()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.LblFaktur = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblTotHrga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pelanggan:"
        '
        'LblNmPelanggan
        '
        Me.LblNmPelanggan.BackColor = System.Drawing.Color.White
        Me.LblNmPelanggan.Location = New System.Drawing.Point(143, 148)
        Me.LblNmPelanggan.Name = "LblNmPelanggan"
        Me.LblNmPelanggan.Size = New System.Drawing.Size(175, 20)
        Me.LblNmPelanggan.TabIndex = 1
        '
        'CmbPelanggan
        '
        Me.CmbPelanggan.FormattingEnabled = True
        Me.CmbPelanggan.Location = New System.Drawing.Point(143, 95)
        Me.CmbPelanggan.Name = "CmbPelanggan"
        Me.CmbPelanggan.Size = New System.Drawing.Size(175, 21)
        Me.CmbPelanggan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Pelanggan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Barang:"
        '
        'LblNmBarang
        '
        Me.LblNmBarang.BackColor = System.Drawing.Color.White
        Me.LblNmBarang.Location = New System.Drawing.Point(324, 201)
        Me.LblNmBarang.Name = "LblNmBarang"
        Me.LblNmBarang.Size = New System.Drawing.Size(175, 20)
        Me.LblNmBarang.TabIndex = 5
        '
        'BarangTxt
        '
        Me.BarangTxt.BackColor = System.Drawing.Color.Black
        Me.BarangTxt.ForeColor = System.Drawing.Color.White
        Me.BarangTxt.Location = New System.Drawing.Point(143, 200)
        Me.BarangTxt.Name = "BarangTxt"
        Me.BarangTxt.Size = New System.Drawing.Size(175, 20)
        Me.BarangTxt.TabIndex = 6
        '
        'LblHrg
        '
        Me.LblHrg.BackColor = System.Drawing.Color.White
        Me.LblHrg.Location = New System.Drawing.Point(505, 201)
        Me.LblHrg.Name = "LblHrg"
        Me.LblHrg.Size = New System.Drawing.Size(175, 20)
        Me.LblHrg.TabIndex = 7
        Me.LblHrg.Text = "0"
        '
        'LblStock
        '
        Me.LblStock.BackColor = System.Drawing.Color.White
        Me.LblStock.Location = New System.Drawing.Point(686, 200)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(87, 20)
        Me.LblStock.TabIndex = 8
        Me.LblStock.Text = "0"
        '
        'TxtJml
        '
        Me.TxtJml.BackColor = System.Drawing.Color.White
        Me.TxtJml.Location = New System.Drawing.Point(779, 200)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(87, 20)
        Me.TxtJml.TabIndex = 9
        '
        'LblFaktur
        '
        Me.LblFaktur.BackColor = System.Drawing.Color.Yellow
        Me.LblFaktur.Location = New System.Drawing.Point(691, 95)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(175, 20)
        Me.LblFaktur.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(566, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Faktur Pembelian:"
        '
        'DGPenjualan
        '
        Me.DGPenjualan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPenjualan.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(12, 252)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.Size = New System.Drawing.Size(854, 212)
        Me.DGPenjualan.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(603, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Sub Total:"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.Location = New System.Drawing.Point(682, 470)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(184, 20)
        Me.LblSubTotal.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(409, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "[F1] - BAYAR | [F2] - BARANG | [F3] - BATAL | [ESC] - KELUAR"
        '
        'LblTotHrga
        '
        Me.LblTotHrga.BackColor = System.Drawing.Color.White
        Me.LblTotHrga.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotHrga.Location = New System.Drawing.Point(12, 12)
        Me.LblTotHrga.Multiline = True
        Me.LblTotHrga.Name = "LblTotHrga"
        Me.LblTotHrga.Size = New System.Drawing.Size(854, 51)
        Me.LblTotHrga.TabIndex = 16
        Me.LblTotHrga.Text = "0"
        Me.LblTotHrga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(682, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Stock:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(775, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Jumlah:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(148, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Kode:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Nama:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(501, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Harga:"
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(873, 502)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTotHrga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblHrg)
        Me.Controls.Add(Me.BarangTxt)
        Me.Controls.Add(Me.LblNmBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbPelanggan)
        Me.Controls.Add(Me.LblNmPelanggan)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNmPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents CmbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents BarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents LblHrg As System.Windows.Forms.TextBox
    Friend WithEvents LblStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents LblFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblTotHrga As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
