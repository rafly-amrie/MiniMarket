<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPelanggan))
        Me.CariKdPelanggan = New System.Windows.Forms.RadioButton()
        Me.TlpTxt = New System.Windows.Forms.TextBox()
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.CariNmPelanggan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.NmPelangganTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KdPelangganTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CariKdPelanggan
        '
        Me.CariKdPelanggan.AutoSize = True
        Me.CariKdPelanggan.Location = New System.Drawing.Point(8, 29)
        Me.CariKdPelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariKdPelanggan.Name = "CariKdPelanggan"
        Me.CariKdPelanggan.Size = New System.Drawing.Size(135, 24)
        Me.CariKdPelanggan.TabIndex = 0
        Me.CariKdPelanggan.TabStop = True
        Me.CariKdPelanggan.Text = "Kode Pelanggan"
        Me.CariKdPelanggan.UseVisualStyleBackColor = True
        '
        'TlpTxt
        '
        Me.TlpTxt.Location = New System.Drawing.Point(144, 158)
        Me.TlpTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TlpTxt.Name = "TlpTxt"
        Me.TlpTxt.Size = New System.Drawing.Size(125, 27)
        Me.TlpTxt.TabIndex = 63
        '
        'DGPelanggan
        '
        Me.DGPelanggan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGPelanggan.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPelanggan.Location = New System.Drawing.Point(13, 274)
        Me.DGPelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.Size = New System.Drawing.Size(784, 195)
        Me.DGPelanggan.TabIndex = 62
        '
        'CariNmPelanggan
        '
        Me.CariNmPelanggan.AutoSize = True
        Me.CariNmPelanggan.Location = New System.Drawing.Point(155, 29)
        Me.CariNmPelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariNmPelanggan.Name = "CariNmPelanggan"
        Me.CariNmPelanggan.Size = New System.Drawing.Size(140, 24)
        Me.CariNmPelanggan.TabIndex = 1
        Me.CariNmPelanggan.TabStop = True
        Me.CariNmPelanggan.Text = "Nama Pelanggan"
        Me.CariNmPelanggan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariNmPelanggan)
        Me.GroupBox1.Controls.Add(Me.CariKdPelanggan)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(17, 195)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(571, 69)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Location = New System.Drawing.Point(305, 28)
        Me.CariDataTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(252, 27)
        Me.CariDataTxt.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Location = New System.Drawing.Point(13, 161)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Telepon:"
        '
        'AlmTxt
        '
        Me.AlmTxt.Location = New System.Drawing.Point(144, 89)
        Me.AlmTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(232, 58)
        Me.AlmTxt.TabIndex = 53
        '
        'NmPelangganTxt
        '
        Me.NmPelangganTxt.Location = New System.Drawing.Point(144, 49)
        Me.NmPelangganTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NmPelangganTxt.Name = "NmPelangganTxt"
        Me.NmPelangganTxt.Size = New System.Drawing.Size(232, 27)
        Me.NmPelangganTxt.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Location = New System.Drawing.Point(13, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Alamat:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nama Pelanggan:"
        '
        'KdPelangganTxt
        '
        Me.KdPelangganTxt.Location = New System.Drawing.Point(144, 14)
        Me.KdPelangganTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdPelangganTxt.Name = "KdPelangganTxt"
        Me.KdPelangganTxt.Size = New System.Drawing.Size(125, 27)
        Me.KdPelangganTxt.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Kode Pelanggan:"
        '
        'TutupBtn
        '
        Me.TutupBtn.BackColor = System.Drawing.Color.Transparent
        Me.TutupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.TutupBtn.FlatAppearance.BorderSize = 0
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TutupBtn.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Stop
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(722, 111)
        Me.TutupBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 70)
        Me.TutupBtn.TabIndex = 60
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
        Me.BatalBtn.Location = New System.Drawing.Point(640, 111)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(75, 70)
        Me.BatalBtn.TabIndex = 59
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
        Me.HapusBtn.Location = New System.Drawing.Point(559, 111)
        Me.HapusBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 70)
        Me.HapusBtn.TabIndex = 58
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
        Me.UbahBtn.Location = New System.Drawing.Point(478, 111)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 70)
        Me.UbahBtn.TabIndex = 57
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
        Me.SimpanBtn.Location = New System.Drawing.Point(396, 111)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 70)
        Me.SimpanBtn.TabIndex = 56
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'FrmPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(814, 486)
        Me.Controls.Add(Me.TlpTxt)
        Me.Controls.Add(Me.DGPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.NmPelangganTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KdPelangganTxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pelanggan"
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CariKdPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents TlpTxt As System.Windows.Forms.TextBox
    Friend WithEvents DGPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents CariNmPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KdPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
