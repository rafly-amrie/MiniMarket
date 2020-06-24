<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuUtama))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HakAksesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KelompokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PenggunaTS = New System.Windows.Forms.ToolStripButton()
        Me.UbahPwdTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PelangganTS = New System.Windows.Forms.ToolStripButton()
        Me.SupplierTS = New System.Windows.Forms.ToolStripButton()
        Me.BarangTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PembelianTS = New System.Windows.Forms.ToolStripButton()
        Me.PenjualanTS = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsPengguna = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 55)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 350)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.UbahPasswordToolStripMenuItem, Me.HakAksesToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(54, 19)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.Image = CType(resources.GetObject("PenggunaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna   Ctrl+P"
        '
        'UbahPasswordToolStripMenuItem
        '
        Me.UbahPasswordToolStripMenuItem.Image = CType(resources.GetObject("UbahPasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UbahPasswordToolStripMenuItem.Name = "UbahPasswordToolStripMenuItem"
        Me.UbahPasswordToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UbahPasswordToolStripMenuItem.Text = "Ubah Password"
        '
        'HakAksesToolStripMenuItem
        '
        Me.HakAksesToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources._3592827_access_general_house_key_key_lock_key_login_office_107758
        Me.HakAksesToolStripMenuItem.Name = "HakAksesToolStripMenuItem"
        Me.HakAksesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.HakAksesToolStripMenuItem.Text = "Hak Akses"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.log_in_icon_icons2
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar   Ctrl+E"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KelompokToolStripMenuItem, Me.SatuanToolStripMenuItem, Me.ToolStripSeparator1, Me.PelangganToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 19)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'KelompokToolStripMenuItem
        '
        Me.KelompokToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Folder
        Me.KelompokToolStripMenuItem.Name = "KelompokToolStripMenuItem"
        Me.KelompokToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.KelompokToolStripMenuItem.Text = "Kelompok"
        '
        'SatuanToolStripMenuItem
        '
        Me.SatuanToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Folder
        Me.SatuanToolStripMenuItem.Name = "SatuanToolStripMenuItem"
        Me.SatuanToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SatuanToolStripMenuItem.Text = "Satuan"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_User_Group1
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Soft_Scraps_User_Administrator_Blue
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Business_Brief_case
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PembelianToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(67, 19)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RiwayatPembelianToolStripMenuItem})
        Me.PembelianToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Rockettheme_Ecommerce_Basket
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'RiwayatPembelianToolStripMenuItem
        '
        Me.RiwayatPembelianToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.history
        Me.RiwayatPembelianToolStripMenuItem.Name = "RiwayatPembelianToolStripMenuItem"
        Me.RiwayatPembelianToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.RiwayatPembelianToolStripMenuItem.Text = "Riwayat Pembelian"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RiwayatPenjualanToolStripMenuItem})
        Me.PenjualanToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.Iconshock_Real_Vista_Business_Competitors
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'RiwayatPenjualanToolStripMenuItem
        '
        Me.RiwayatPenjualanToolStripMenuItem.Image = Global.MiniMarket.My.Resources.Resources.history
        Me.RiwayatPenjualanToolStripMenuItem.Name = "RiwayatPenjualanToolStripMenuItem"
        Me.RiwayatPenjualanToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RiwayatPenjualanToolStripMenuItem.Text = "Riwayat Penjualan"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaTS, Me.UbahPwdTS, Me.ToolStripSeparator2, Me.PelangganTS, Me.SupplierTS, Me.BarangTS, Me.ToolStripSeparator3, Me.PembelianTS, Me.PenjualanTS})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(834, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PenggunaTS
        '
        Me.PenggunaTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PenggunaTS.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_User_Group
        Me.PenggunaTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PenggunaTS.Name = "PenggunaTS"
        Me.PenggunaTS.Size = New System.Drawing.Size(23, 22)
        Me.PenggunaTS.Text = "ToolStripButton1"
        '
        'UbahPwdTS
        '
        Me.UbahPwdTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UbahPwdTS.Image = CType(resources.GetObject("UbahPwdTS.Image"), System.Drawing.Image)
        Me.UbahPwdTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UbahPwdTS.Name = "UbahPwdTS"
        Me.UbahPwdTS.Size = New System.Drawing.Size(23, 22)
        Me.UbahPwdTS.Text = "ToolStripButton2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PelangganTS
        '
        Me.PelangganTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PelangganTS.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_User_Group
        Me.PelangganTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PelangganTS.Name = "PelangganTS"
        Me.PelangganTS.Size = New System.Drawing.Size(23, 22)
        Me.PelangganTS.Text = "ToolStripButton5"
        '
        'SupplierTS
        '
        Me.SupplierTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SupplierTS.Image = CType(resources.GetObject("SupplierTS.Image"), System.Drawing.Image)
        Me.SupplierTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SupplierTS.Name = "SupplierTS"
        Me.SupplierTS.Size = New System.Drawing.Size(23, 22)
        Me.SupplierTS.Text = "ToolStripButton4"
        '
        'BarangTS
        '
        Me.BarangTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BarangTS.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Business_Brief_case
        Me.BarangTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BarangTS.Name = "BarangTS"
        Me.BarangTS.Size = New System.Drawing.Size(23, 22)
        Me.BarangTS.Text = "ToolStripButton3"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'PembelianTS
        '
        Me.PembelianTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PembelianTS.Image = CType(resources.GetObject("PembelianTS.Image"), System.Drawing.Image)
        Me.PembelianTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PembelianTS.Name = "PembelianTS"
        Me.PembelianTS.Size = New System.Drawing.Size(23, 22)
        Me.PembelianTS.Text = "ToolStripButton6"
        '
        'PenjualanTS
        '
        Me.PenjualanTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PenjualanTS.Image = Global.MiniMarket.My.Resources.Resources.Iconshock_Real_Vista_Business_Competitors
        Me.PenjualanTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PenjualanTS.Name = "PenjualanTS"
        Me.PenjualanTS.Size = New System.Drawing.Size(23, 22)
        Me.PenjualanTS.Text = "ToolStripButton7"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.StatusStrip1.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsPengguna, Me.TsLevel, Me.TsJam, Me.TsTanggal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(834, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsPengguna
        '
        Me.TsPengguna.Name = "TsPengguna"
        Me.TsPengguna.Size = New System.Drawing.Size(61, 17)
        Me.TsPengguna.Text = "Pengguna"
        '
        'TsLevel
        '
        Me.TsLevel.Name = "TsLevel"
        Me.TsLevel.Size = New System.Drawing.Size(34, 17)
        Me.TsLevel.Text = "Level"
        '
        'TsJam
        '
        Me.TsJam.Name = "TsJam"
        Me.TsJam.Size = New System.Drawing.Size(28, 17)
        Me.TsJam.Text = "Jam"
        '
        'TsTanggal
        '
        Me.TsTanggal.Name = "TsTanggal"
        Me.TsTanggal.Size = New System.Drawing.Size(49, 17)
        Me.TsTanggal.Text = "Tanggal"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(834, 441)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SistemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UbahPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakAksesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KelompokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SatuanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggunaTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents UbahPwdTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BarangTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents SupplierTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents PelangganTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PembelianTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents PenjualanTS As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsPengguna As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TsLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TsJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TsTanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RiwayatPembelianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiwayatPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
