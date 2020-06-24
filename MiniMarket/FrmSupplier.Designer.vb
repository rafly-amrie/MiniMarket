<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplier))
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariKontak = New System.Windows.Forms.RadioButton()
        Me.CariNmSupplier = New System.Windows.Forms.RadioButton()
        Me.CariKdSupplier = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.NmSupplierTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KdSupplierTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.TlpTxt = New System.Windows.Forms.TextBox()
        Me.KontakTxt = New System.Windows.Forms.TextBox()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGSupplier
        '
        Me.DGSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGSupplier.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(13, 314)
        Me.DGSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(788, 195)
        Me.DGSupplier.TabIndex = 45
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Location = New System.Drawing.Point(365, 28)
        Me.CariDataTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(252, 27)
        Me.CariDataTxt.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariKontak)
        Me.GroupBox1.Controls.Add(Me.CariNmSupplier)
        Me.GroupBox1.Controls.Add(Me.CariKdSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 235)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(637, 69)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariKontak
        '
        Me.CariKontak.AutoSize = True
        Me.CariKontak.Location = New System.Drawing.Point(279, 29)
        Me.CariKontak.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariKontak.Name = "CariKontak"
        Me.CariKontak.Size = New System.Drawing.Size(73, 24)
        Me.CariKontak.TabIndex = 2
        Me.CariKontak.TabStop = True
        Me.CariKontak.Text = "Kontak"
        Me.CariKontak.UseVisualStyleBackColor = True
        '
        'CariNmSupplier
        '
        Me.CariNmSupplier.AutoSize = True
        Me.CariNmSupplier.Location = New System.Drawing.Point(141, 29)
        Me.CariNmSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariNmSupplier.Name = "CariNmSupplier"
        Me.CariNmSupplier.Size = New System.Drawing.Size(126, 24)
        Me.CariNmSupplier.TabIndex = 1
        Me.CariNmSupplier.TabStop = True
        Me.CariNmSupplier.Text = "Nama Supplier"
        Me.CariNmSupplier.UseVisualStyleBackColor = True
        '
        'CariKdSupplier
        '
        Me.CariKdSupplier.AutoSize = True
        Me.CariKdSupplier.Location = New System.Drawing.Point(8, 29)
        Me.CariKdSupplier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariKdSupplier.Name = "CariKdSupplier"
        Me.CariKdSupplier.Size = New System.Drawing.Size(121, 24)
        Me.CariKdSupplier.TabIndex = 0
        Me.CariKdSupplier.TabStop = True
        Me.CariKdSupplier.Text = "Kode Supplier"
        Me.CariKdSupplier.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Kontak:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Telepon:"
        '
        'AlmTxt
        '
        Me.AlmTxt.Location = New System.Drawing.Point(133, 88)
        Me.AlmTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(232, 58)
        Me.AlmTxt.TabIndex = 28
        '
        'NmSupplierTxt
        '
        Me.NmSupplierTxt.Location = New System.Drawing.Point(133, 51)
        Me.NmSupplierTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NmSupplierTxt.Name = "NmSupplierTxt"
        Me.NmSupplierTxt.Size = New System.Drawing.Size(232, 27)
        Me.NmSupplierTxt.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Alamat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nama Supplier:"
        '
        'KdSupplierTxt
        '
        Me.KdSupplierTxt.Location = New System.Drawing.Point(133, 14)
        Me.KdSupplierTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdSupplierTxt.Name = "KdSupplierTxt"
        Me.KdSupplierTxt.Size = New System.Drawing.Size(125, 27)
        Me.KdSupplierTxt.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Kode Supplier:"
        '
        'TutupBtn
        '
        Me.TutupBtn.BackColor = System.Drawing.Color.Transparent
        Me.TutupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TutupBtn.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Stop
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(704, 160)
        Me.TutupBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(70, 65)
        Me.TutupBtn.TabIndex = 43
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = False
        '
        'BatalBtn
        '
        Me.BatalBtn.BackColor = System.Drawing.Color.Transparent
        Me.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatalBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_4_Refresh
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(622, 160)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(70, 65)
        Me.BatalBtn.TabIndex = 42
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = False
        '
        'HapusBtn
        '
        Me.HapusBtn.BackColor = System.Drawing.Color.Transparent
        Me.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HapusBtn.Image = Global.MiniMarket.My.Resources.Resources.Dooffy_Characters_X1
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(541, 160)
        Me.HapusBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(70, 65)
        Me.HapusBtn.TabIndex = 41
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = False
        '
        'UbahBtn
        '
        Me.UbahBtn.BackColor = System.Drawing.Color.Transparent
        Me.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UbahBtn.Image = Global.MiniMarket.My.Resources.Resources.Pixelkit_Swanky_Outlines_08_Wrench
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(460, 160)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(70, 65)
        Me.UbahBtn.TabIndex = 40
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = False
        '
        'SimpanBtn
        '
        Me.SimpanBtn.BackColor = System.Drawing.Color.Transparent
        Me.SimpanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SimpanBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_1_Save
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(378, 160)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(70, 65)
        Me.SimpanBtn.TabIndex = 39
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'TlpTxt
        '
        Me.TlpTxt.Location = New System.Drawing.Point(133, 156)
        Me.TlpTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TlpTxt.Name = "TlpTxt"
        Me.TlpTxt.Size = New System.Drawing.Size(125, 27)
        Me.TlpTxt.TabIndex = 46
        '
        'KontakTxt
        '
        Me.KontakTxt.Location = New System.Drawing.Point(133, 193)
        Me.KontakTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KontakTxt.Name = "KontakTxt"
        Me.KontakTxt.Size = New System.Drawing.Size(125, 27)
        Me.KontakTxt.TabIndex = 47
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(853, 572)
        Me.Controls.Add(Me.KontakTxt)
        Me.Controls.Add(Me.TlpTxt)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmSupplierTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KdSupplierTxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Supplier"
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariKontak As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmSupplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KdSupplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TlpTxt As System.Windows.Forms.TextBox
    Friend WithEvents KontakTxt As System.Windows.Forms.TextBox
End Class
