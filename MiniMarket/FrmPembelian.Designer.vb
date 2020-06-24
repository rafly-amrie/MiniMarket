<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPembelian))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNmSupplier = New System.Windows.Forms.TextBox()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbBarang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNmBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblHrg = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblFaktur = New System.Windows.Forms.TextBox()
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotHrgKotor = New System.Windows.Forms.TextBox()
        Me.DiscTxt = New System.Windows.Forms.TextBox()
        Me.LblTotHrgBersih = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier"
        '
        'LblNmSupplier
        '
        Me.LblNmSupplier.Location = New System.Drawing.Point(126, 41)
        Me.LblNmSupplier.Name = "LblNmSupplier"
        Me.LblNmSupplier.Size = New System.Drawing.Size(203, 23)
        Me.LblNmSupplier.TabIndex = 1
        '
        'CmbSupplier
        '
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(126, 12)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(203, 23)
        Me.CmbSupplier.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Supplier"
        '
        'CmbBarang
        '
        Me.CmbBarang.FormattingEnabled = True
        Me.CmbBarang.Location = New System.Drawing.Point(126, 90)
        Me.CmbBarang.Name = "CmbBarang"
        Me.CmbBarang.Size = New System.Drawing.Size(203, 23)
        Me.CmbBarang.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Barang"
        '
        'LblNmBarang
        '
        Me.LblNmBarang.BackColor = System.Drawing.Color.White
        Me.LblNmBarang.Location = New System.Drawing.Point(346, 92)
        Me.LblNmBarang.Name = "LblNmBarang"
        Me.LblNmBarang.Size = New System.Drawing.Size(203, 23)
        Me.LblNmBarang.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nama Barang"
        '
        'LblHrg
        '
        Me.LblHrg.BackColor = System.Drawing.Color.White
        Me.LblHrg.Location = New System.Drawing.Point(557, 92)
        Me.LblHrg.Name = "LblHrg"
        Me.LblHrg.Size = New System.Drawing.Size(116, 23)
        Me.LblHrg.TabIndex = 8
        Me.LblHrg.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(560, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Harga"
        '
        'LblStock
        '
        Me.LblStock.BackColor = System.Drawing.Color.White
        Me.LblStock.Location = New System.Drawing.Point(681, 92)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(58, 23)
        Me.LblStock.TabIndex = 10
        Me.LblStock.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(684, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Stock"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(749, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jumlah Beli"
        '
        'TxtJml
        '
        Me.TxtJml.Location = New System.Drawing.Point(746, 92)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(87, 23)
        Me.TxtJml.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(342, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Faktur Pembelian"
        '
        'LblFaktur
        '
        Me.LblFaktur.BackColor = System.Drawing.Color.Yellow
        Me.LblFaktur.Location = New System.Drawing.Point(469, 12)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(145, 23)
        Me.LblFaktur.TabIndex = 14
        '
        'DGPembelian
        '
        Me.DGPembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPembelian.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPembelian.Location = New System.Drawing.Point(14, 130)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.Size = New System.Drawing.Size(819, 296)
        Me.DGPembelian.TabIndex = 16
        '
        'SimpanBtn
        '
        Me.SimpanBtn.BackColor = System.Drawing.Color.Transparent
        Me.SimpanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SimpanBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SimpanBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_1_Save
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(17, 433)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(87, 69)
        Me.SimpanBtn.TabIndex = 17
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'BatalBtn
        '
        Me.BatalBtn.BackColor = System.Drawing.Color.Transparent
        Me.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatalBtn.Image = Global.MiniMarket.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(112, 433)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(87, 69)
        Me.BatalBtn.TabIndex = 18
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(613, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Harga Kotor :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(613, 495)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Harga Bersih :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(613, 465)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Diskon % :"
        '
        'LblTotHrgKotor
        '
        Me.LblTotHrgKotor.BackColor = System.Drawing.Color.White
        Me.LblTotHrgKotor.ForeColor = System.Drawing.Color.Black
        Me.LblTotHrgKotor.Location = New System.Drawing.Point(717, 432)
        Me.LblTotHrgKotor.Name = "LblTotHrgKotor"
        Me.LblTotHrgKotor.Size = New System.Drawing.Size(116, 23)
        Me.LblTotHrgKotor.TabIndex = 22
        Me.LblTotHrgKotor.Text = "0"
        Me.LblTotHrgKotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscTxt
        '
        Me.DiscTxt.Location = New System.Drawing.Point(717, 462)
        Me.DiscTxt.Name = "DiscTxt"
        Me.DiscTxt.Size = New System.Drawing.Size(116, 23)
        Me.DiscTxt.TabIndex = 23
        '
        'LblTotHrgBersih
        '
        Me.LblTotHrgBersih.ForeColor = System.Drawing.Color.Red
        Me.LblTotHrgBersih.Location = New System.Drawing.Point(717, 492)
        Me.LblTotHrgBersih.Name = "LblTotHrgBersih"
        Me.LblTotHrgBersih.Size = New System.Drawing.Size(116, 23)
        Me.LblTotHrgBersih.TabIndex = 24
        Me.LblTotHrgBersih.Text = "0"
        Me.LblTotHrgBersih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 6.25!)
        Me.Label12.Location = New System.Drawing.Point(776, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 12)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "*tekan enter"
        '
        'FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(844, 531)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LblTotHrgBersih)
        Me.Controls.Add(Me.DiscTxt)
        Me.Controls.Add(Me.LblTotHrgKotor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.DGPembelian)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblHrg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblNmBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbSupplier)
        Me.Controls.Add(Me.LblNmSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNmSupplier As System.Windows.Forms.TextBox
    Friend WithEvents CmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblHrg As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblStock As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblFaktur As System.Windows.Forms.TextBox
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblTotHrgKotor As System.Windows.Forms.TextBox
    Friend WithEvents DiscTxt As System.Windows.Forms.TextBox
    Friend WithEvents LblTotHrgBersih As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
