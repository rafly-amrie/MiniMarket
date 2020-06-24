<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKelompok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKelompok))
        Me.KdKelompokTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KelompokTxt = New System.Windows.Forms.TextBox()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.DGKelompok = New System.Windows.Forms.DataGridView()
        CType(Me.DGKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KdKelompokTxt
        '
        Me.KdKelompokTxt.Location = New System.Drawing.Point(144, 20)
        Me.KdKelompokTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdKelompokTxt.Name = "KdKelompokTxt"
        Me.KdKelompokTxt.Size = New System.Drawing.Size(132, 27)
        Me.KdKelompokTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Kelompok:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kelompok:"
        '
        'KelompokTxt
        '
        Me.KelompokTxt.Location = New System.Drawing.Point(144, 60)
        Me.KelompokTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KelompokTxt.Name = "KelompokTxt"
        Me.KelompokTxt.Size = New System.Drawing.Size(247, 27)
        Me.KelompokTxt.TabIndex = 3
        '
        'SimpanBtn
        '
        Me.SimpanBtn.BackColor = System.Drawing.Color.Transparent
        Me.SimpanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.BorderSize = 0
        Me.SimpanBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SimpanBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_1_Save
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(144, 97)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 70)
        Me.SimpanBtn.TabIndex = 4
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'UbahBtn
        '
        Me.UbahBtn.BackColor = System.Drawing.Color.Transparent
        Me.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UbahBtn.Image = Global.MiniMarket.My.Resources.Resources.Pixelkit_Swanky_Outlines_08_Wrench
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(230, 97)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 70)
        Me.UbahBtn.TabIndex = 5
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = False
        '
        'HapusBtn
        '
        Me.HapusBtn.BackColor = System.Drawing.Color.Transparent
        Me.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.BorderSize = 0
        Me.HapusBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HapusBtn.Image = Global.MiniMarket.My.Resources.Resources.Dooffy_Characters_X1
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(316, 97)
        Me.HapusBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 70)
        Me.HapusBtn.TabIndex = 6
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = False
        '
        'DGKelompok
        '
        Me.DGKelompok.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKelompok.Location = New System.Drawing.Point(20, 177)
        Me.DGKelompok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGKelompok.Name = "DGKelompok"
        Me.DGKelompok.Size = New System.Drawing.Size(371, 352)
        Me.DGKelompok.TabIndex = 7
        '
        'FrmKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(404, 541)
        Me.Controls.Add(Me.DGKelompok)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.KelompokTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KdKelompokTxt)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmKelompok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kelompok"
        CType(Me.DGKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KdKelompokTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KelompokTxt As System.Windows.Forms.TextBox
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents DGKelompok As System.Windows.Forms.DataGridView
End Class
