<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KdBarangTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BarcodeTxt = New System.Windows.Forms.TextBox()
        Me.NmBarangTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbKelompok = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HrgBeliTxt = New System.Windows.Forms.TextBox()
        Me.FrmBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HrgJualTxt = New System.Windows.Forms.TextBox()
        Me.StockTxt = New System.Windows.Forms.TextBox()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariStock = New System.Windows.Forms.RadioButton()
        Me.CariNmBarang = New System.Windows.Forms.RadioButton()
        Me.CariKdBarang = New System.Windows.Forms.RadioButton()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.FrmBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang:"
        '
        'KdBarangTxt
        '
        Me.KdBarangTxt.Location = New System.Drawing.Point(144, 18)
        Me.KdBarangTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdBarangTxt.Name = "KdBarangTxt"
        Me.KdBarangTxt.Size = New System.Drawing.Size(165, 27)
        Me.KdBarangTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Barcode:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Barang:"
        '
        'BarcodeTxt
        '
        Me.BarcodeTxt.Location = New System.Drawing.Point(144, 58)
        Me.BarcodeTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BarcodeTxt.Name = "BarcodeTxt"
        Me.BarcodeTxt.Size = New System.Drawing.Size(232, 27)
        Me.BarcodeTxt.TabIndex = 4
        '
        'NmBarangTxt
        '
        Me.NmBarangTxt.Location = New System.Drawing.Point(144, 98)
        Me.NmBarangTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NmBarangTxt.Name = "NmBarangTxt"
        Me.NmBarangTxt.Size = New System.Drawing.Size(232, 27)
        Me.NmBarangTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kelompok:"
        '
        'CmbKelompok
        '
        Me.CmbKelompok.FormattingEnabled = True
        Me.CmbKelompok.Location = New System.Drawing.Point(144, 138)
        Me.CmbKelompok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbKelompok.Name = "CmbKelompok"
        Me.CmbKelompok.Size = New System.Drawing.Size(199, 28)
        Me.CmbKelompok.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Satuan:"
        '
        'CmbSatuan
        '
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(144, 180)
        Me.CmbSatuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(199, 28)
        Me.CmbSatuan.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(464, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Harga Beli:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(464, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Harga Jual:"
        '
        'HrgBeliTxt
        '
        Me.HrgBeliTxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FrmBarangBindingSource, "DataBindings", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.HrgBeliTxt.Location = New System.Drawing.Point(554, 18)
        Me.HrgBeliTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HrgBeliTxt.Name = "HrgBeliTxt"
        Me.HrgBeliTxt.Size = New System.Drawing.Size(132, 27)
        Me.HrgBeliTxt.TabIndex = 13
        '
        'FrmBarangBindingSource
        '
        Me.FrmBarangBindingSource.DataSource = GetType(MiniMarket.FrmBarang)
        '
        'HrgJualTxt
        '
        Me.HrgJualTxt.Location = New System.Drawing.Point(554, 58)
        Me.HrgJualTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HrgJualTxt.Name = "HrgJualTxt"
        Me.HrgJualTxt.Size = New System.Drawing.Size(132, 27)
        Me.HrgJualTxt.TabIndex = 14
        '
        'StockTxt
        '
        Me.StockTxt.Location = New System.Drawing.Point(554, 98)
        Me.StockTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StockTxt.Name = "StockTxt"
        Me.StockTxt.Size = New System.Drawing.Size(132, 27)
        Me.StockTxt.TabIndex = 15
        '
        'HapusBtn
        '
        Me.HapusBtn.BackColor = System.Drawing.Color.Transparent
        Me.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HapusBtn.Image = Global.MiniMarket.My.Resources.Resources.Dooffy_Characters_X1
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(631, 138)
        Me.HapusBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 75)
        Me.HapusBtn.TabIndex = 18
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = False
        '
        'UbahBtn
        '
        Me.UbahBtn.BackColor = System.Drawing.Color.Transparent
        Me.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UbahBtn.Image = Global.MiniMarket.My.Resources.Resources.Pixelkit_Swanky_Outlines_08_Wrench
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(549, 138)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 75)
        Me.UbahBtn.TabIndex = 17
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = False
        '
        'SimpanBtn
        '
        Me.SimpanBtn.BackColor = System.Drawing.Color.Transparent
        Me.SimpanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SimpanBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_1_Save
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(468, 138)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 75)
        Me.SimpanBtn.TabIndex = 16
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'BatalBtn
        '
        Me.BatalBtn.BackColor = System.Drawing.Color.Transparent
        Me.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatalBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_4_Refresh
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(712, 138)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(75, 75)
        Me.BatalBtn.TabIndex = 19
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = False
        '
        'TutupBtn
        '
        Me.TutupBtn.BackColor = System.Drawing.Color.Transparent
        Me.TutupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TutupBtn.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Stop
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(793, 138)
        Me.TutupBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 75)
        Me.TutupBtn.TabIndex = 20
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariStock)
        Me.GroupBox1.Controls.Add(Me.CariNmBarang)
        Me.GroupBox1.Controls.Add(Me.CariKdBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 223)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(600, 69)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Location = New System.Drawing.Point(339, 28)
        Me.CariDataTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(252, 27)
        Me.CariDataTxt.TabIndex = 22
        '
        'CariStock
        '
        Me.CariStock.AutoSize = True
        Me.CariStock.BackColor = System.Drawing.Color.Transparent
        Me.CariStock.Location = New System.Drawing.Point(260, 29)
        Me.CariStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariStock.Name = "CariStock"
        Me.CariStock.Size = New System.Drawing.Size(63, 24)
        Me.CariStock.TabIndex = 2
        Me.CariStock.TabStop = True
        Me.CariStock.Text = "Stock"
        Me.CariStock.UseVisualStyleBackColor = False
        '
        'CariNmBarang
        '
        Me.CariNmBarang.AutoSize = True
        Me.CariNmBarang.BackColor = System.Drawing.Color.Transparent
        Me.CariNmBarang.Location = New System.Drawing.Point(132, 29)
        Me.CariNmBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariNmBarang.Name = "CariNmBarang"
        Me.CariNmBarang.Size = New System.Drawing.Size(118, 24)
        Me.CariNmBarang.TabIndex = 1
        Me.CariNmBarang.TabStop = True
        Me.CariNmBarang.Text = "Nama Barang"
        Me.CariNmBarang.UseVisualStyleBackColor = False
        '
        'CariKdBarang
        '
        Me.CariKdBarang.AutoSize = True
        Me.CariKdBarang.BackColor = System.Drawing.Color.Transparent
        Me.CariKdBarang.Location = New System.Drawing.Point(8, 29)
        Me.CariKdBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariKdBarang.Name = "CariKdBarang"
        Me.CariKdBarang.Size = New System.Drawing.Size(113, 24)
        Me.CariKdBarang.TabIndex = 0
        Me.CariKdBarang.TabStop = True
        Me.CariKdBarang.Text = "Kode Barang"
        Me.CariKdBarang.UseVisualStyleBackColor = False
        '
        'DGBarang
        '
        Me.DGBarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGBarang.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(13, 302)
        Me.DGBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(970, 250)
        Me.DGBarang.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(464, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Stock:"
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg51
        Me.ClientSize = New System.Drawing.Size(1009, 561)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.StockTxt)
        Me.Controls.Add(Me.HrgJualTxt)
        Me.Controls.Add(Me.HrgBeliTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbSatuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmbKelompok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NmBarangTxt)
        Me.Controls.Add(Me.BarcodeTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KdBarangTxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.FrmBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KdBarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BarcodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmBarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HrgBeliTxt As System.Windows.Forms.TextBox
    Friend WithEvents HrgJualTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockTxt As System.Windows.Forms.TextBox
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariStock As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmBarang As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdBarang As System.Windows.Forms.RadioButton
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FrmBarangBindingSource As System.Windows.Forms.BindingSource
End Class
