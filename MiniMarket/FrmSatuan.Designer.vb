<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSatuan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSatuan))
        Me.DGSatuan = New System.Windows.Forms.DataGridView()
        Me.SatuanTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KdSatuanTxt = New System.Windows.Forms.TextBox()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        CType(Me.DGSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGSatuan
        '
        Me.DGSatuan.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGSatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSatuan.Location = New System.Drawing.Point(13, 163)
        Me.DGSatuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGSatuan.Name = "DGSatuan"
        Me.DGSatuan.Size = New System.Drawing.Size(370, 350)
        Me.DGSatuan.TabIndex = 15
        '
        'SatuanTxt
        '
        Me.SatuanTxt.Location = New System.Drawing.Point(120, 51)
        Me.SatuanTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SatuanTxt.Name = "SatuanTxt"
        Me.SatuanTxt.Size = New System.Drawing.Size(252, 27)
        Me.SatuanTxt.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Satuan:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode Satuan:"
        '
        'KdSatuanTxt
        '
        Me.KdSatuanTxt.Location = New System.Drawing.Point(120, 14)
        Me.KdSatuanTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdSatuanTxt.Name = "KdSatuanTxt"
        Me.KdSatuanTxt.Size = New System.Drawing.Size(132, 27)
        Me.KdSatuanTxt.TabIndex = 8
        '
        'HapusBtn
        '
        Me.HapusBtn.BackColor = System.Drawing.Color.Transparent
        Me.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HapusBtn.Image = Global.MiniMarket.My.Resources.Resources.Dooffy_Characters_X1
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(283, 88)
        Me.HapusBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(70, 65)
        Me.HapusBtn.TabIndex = 14
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
        Me.UbahBtn.Location = New System.Drawing.Point(202, 88)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(70, 65)
        Me.UbahBtn.TabIndex = 13
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
        Me.SimpanBtn.Location = New System.Drawing.Point(120, 88)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(70, 65)
        Me.SimpanBtn.TabIndex = 12
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'FrmSatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(395, 526)
        Me.Controls.Add(Me.DGSatuan)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.SatuanTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KdSatuanTxt)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSatuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satuan"
        CType(Me.DGSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGSatuan As System.Windows.Forms.DataGridView
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents SatuanTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KdSatuanTxt As System.Windows.Forms.TextBox
End Class
