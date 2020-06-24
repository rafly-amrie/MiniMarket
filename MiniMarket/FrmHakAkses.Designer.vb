<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHakAkses))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbLevel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkPengguna = New System.Windows.Forms.CheckBox()
        Me.ChkPembelian = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkPenjualan = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkPelanggan = New System.Windows.Forms.CheckBox()
        Me.ChkSupplier = New System.Windows.Forms.CheckBox()
        Me.ChkBarang = New System.Windows.Forms.CheckBox()
        Me.ChkSatuan = New System.Windows.Forms.CheckBox()
        Me.ChkJenis = New System.Windows.Forms.CheckBox()
        Me.ChkAkses = New System.Windows.Forms.CheckBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level:"
        '
        'CmbLevel
        '
        Me.CmbLevel.FormattingEnabled = True
        Me.CmbLevel.Location = New System.Drawing.Point(67, 14)
        Me.CmbLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbLevel.Name = "CmbLevel"
        Me.CmbLevel.Size = New System.Drawing.Size(160, 28)
        Me.CmbLevel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ChkPengguna)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 60)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(211, 111)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem"
        '
        'ChkPengguna
        '
        Me.ChkPengguna.AutoSize = True
        Me.ChkPengguna.Location = New System.Drawing.Point(8, 29)
        Me.ChkPengguna.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkPengguna.Name = "ChkPengguna"
        Me.ChkPengguna.Size = New System.Drawing.Size(93, 24)
        Me.ChkPengguna.TabIndex = 3
        Me.ChkPengguna.Text = "Pengguna"
        Me.ChkPengguna.UseVisualStyleBackColor = True
        '
        'ChkPembelian
        '
        Me.ChkPembelian.AutoSize = True
        Me.ChkPembelian.Location = New System.Drawing.Point(8, 29)
        Me.ChkPembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkPembelian.Name = "ChkPembelian"
        Me.ChkPembelian.Size = New System.Drawing.Size(97, 24)
        Me.ChkPembelian.TabIndex = 3
        Me.ChkPembelian.Text = "Pembelian"
        Me.ChkPembelian.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ChkPenjualan)
        Me.GroupBox2.Controls.Add(Me.ChkPembelian)
        Me.GroupBox2.Location = New System.Drawing.Point(235, 60)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(267, 111)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'ChkPenjualan
        '
        Me.ChkPenjualan.AutoSize = True
        Me.ChkPenjualan.Location = New System.Drawing.Point(8, 65)
        Me.ChkPenjualan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkPenjualan.Name = "ChkPenjualan"
        Me.ChkPenjualan.Size = New System.Drawing.Size(91, 24)
        Me.ChkPenjualan.TabIndex = 4
        Me.ChkPenjualan.Text = "Penjualan"
        Me.ChkPenjualan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ChkPelanggan)
        Me.GroupBox3.Controls.Add(Me.ChkSupplier)
        Me.GroupBox3.Controls.Add(Me.ChkBarang)
        Me.GroupBox3.Controls.Add(Me.ChkSatuan)
        Me.GroupBox3.Controls.Add(Me.ChkJenis)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 180)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(211, 231)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Master Data"
        '
        'ChkPelanggan
        '
        Me.ChkPelanggan.AutoSize = True
        Me.ChkPelanggan.Location = New System.Drawing.Point(8, 171)
        Me.ChkPelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkPelanggan.Name = "ChkPelanggan"
        Me.ChkPelanggan.Size = New System.Drawing.Size(97, 24)
        Me.ChkPelanggan.TabIndex = 7
        Me.ChkPelanggan.Text = "Pelanggan"
        Me.ChkPelanggan.UseVisualStyleBackColor = True
        '
        'ChkSupplier
        '
        Me.ChkSupplier.AutoSize = True
        Me.ChkSupplier.Location = New System.Drawing.Point(8, 135)
        Me.ChkSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkSupplier.Name = "ChkSupplier"
        Me.ChkSupplier.Size = New System.Drawing.Size(83, 24)
        Me.ChkSupplier.TabIndex = 6
        Me.ChkSupplier.Text = "Supplier"
        Me.ChkSupplier.UseVisualStyleBackColor = True
        '
        'ChkBarang
        '
        Me.ChkBarang.AutoSize = True
        Me.ChkBarang.Location = New System.Drawing.Point(8, 100)
        Me.ChkBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkBarang.Name = "ChkBarang"
        Me.ChkBarang.Size = New System.Drawing.Size(75, 24)
        Me.ChkBarang.TabIndex = 5
        Me.ChkBarang.Text = "Barang"
        Me.ChkBarang.UseVisualStyleBackColor = True
        '
        'ChkSatuan
        '
        Me.ChkSatuan.AutoSize = True
        Me.ChkSatuan.Location = New System.Drawing.Point(8, 65)
        Me.ChkSatuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkSatuan.Name = "ChkSatuan"
        Me.ChkSatuan.Size = New System.Drawing.Size(73, 24)
        Me.ChkSatuan.TabIndex = 4
        Me.ChkSatuan.Text = "Satuan"
        Me.ChkSatuan.UseVisualStyleBackColor = True
        '
        'ChkJenis
        '
        Me.ChkJenis.AutoSize = True
        Me.ChkJenis.Location = New System.Drawing.Point(8, 29)
        Me.ChkJenis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkJenis.Name = "ChkJenis"
        Me.ChkJenis.Size = New System.Drawing.Size(110, 24)
        Me.ChkJenis.TabIndex = 3
        Me.ChkJenis.Text = "Jenis Barang"
        Me.ChkJenis.UseVisualStyleBackColor = True
        '
        'ChkAkses
        '
        Me.ChkAkses.AutoSize = True
        Me.ChkAkses.ForeColor = System.Drawing.Color.Red
        Me.ChkAkses.Location = New System.Drawing.Point(235, 429)
        Me.ChkAkses.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkAkses.Name = "ChkAkses"
        Me.ChkAkses.Size = New System.Drawing.Size(95, 24)
        Me.ChkAkses.TabIndex = 8
        Me.ChkAkses.Text = "Hak Akses"
        Me.ChkAkses.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.BackColor = System.Drawing.Color.Transparent
        Me.OkBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.OkBtn.FlatAppearance.BorderSize = 0
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkBtn.Location = New System.Drawing.Point(16, 420)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(211, 35)
        Me.OkBtn.TabIndex = 9
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(514, 461)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.ChkAkses)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbLevel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmHakAkses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hak Akses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPelanggan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBarang As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkJenis As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAkses As System.Windows.Forms.CheckBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
End Class
