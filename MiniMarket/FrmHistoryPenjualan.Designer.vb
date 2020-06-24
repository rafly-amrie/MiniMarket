<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoryPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistoryPenjualan))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CariData = New System.Windows.Forms.TextBox()
        Me.RbKdBarang = New System.Windows.Forms.RadioButton()
        Me.RbFaktur = New System.Windows.Forms.RadioButton()
        Me.DGHistory = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KeluarBtn = New System.Windows.Forms.Button()
        CType(Me.DGHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(442, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DAFTAR TRANSAKSI PENJUALAN BARANG"
        '
        'CariData
        '
        Me.CariData.Location = New System.Drawing.Point(198, 27)
        Me.CariData.Name = "CariData"
        Me.CariData.Size = New System.Drawing.Size(260, 27)
        Me.CariData.TabIndex = 2
        '
        'RbKdBarang
        '
        Me.RbKdBarang.AutoSize = True
        Me.RbKdBarang.Location = New System.Drawing.Point(79, 28)
        Me.RbKdBarang.Name = "RbKdBarang"
        Me.RbKdBarang.Size = New System.Drawing.Size(113, 24)
        Me.RbKdBarang.TabIndex = 1
        Me.RbKdBarang.TabStop = True
        Me.RbKdBarang.Text = "Kode Barang"
        Me.RbKdBarang.UseVisualStyleBackColor = True
        '
        'RbFaktur
        '
        Me.RbFaktur.AutoSize = True
        Me.RbFaktur.Location = New System.Drawing.Point(7, 28)
        Me.RbFaktur.Name = "RbFaktur"
        Me.RbFaktur.Size = New System.Drawing.Size(66, 24)
        Me.RbFaktur.TabIndex = 0
        Me.RbFaktur.TabStop = True
        Me.RbFaktur.Text = "Faktur"
        Me.RbFaktur.UseVisualStyleBackColor = True
        '
        'DGHistory
        '
        Me.DGHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGHistory.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHistory.Location = New System.Drawing.Point(17, 149)
        Me.DGHistory.Name = "DGHistory"
        Me.DGHistory.Size = New System.Drawing.Size(1000, 350)
        Me.DGHistory.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CariData)
        Me.GroupBox1.Controls.Add(Me.RbKdBarang)
        Me.GroupBox1.Controls.Add(Me.RbFaktur)
        Me.GroupBox1.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(465, 65)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Transaksi Berdasarkan:"
        '
        'KeluarBtn
        '
        Me.KeluarBtn.BackColor = System.Drawing.Color.Transparent
        Me.KeluarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.KeluarBtn.FlatAppearance.BorderSize = 0
        Me.KeluarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.KeluarBtn.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeluarBtn.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Stop
        Me.KeluarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KeluarBtn.Location = New System.Drawing.Point(922, 93)
        Me.KeluarBtn.Name = "KeluarBtn"
        Me.KeluarBtn.Size = New System.Drawing.Size(95, 50)
        Me.KeluarBtn.TabIndex = 6
        Me.KeluarBtn.Text = "Keluar"
        Me.KeluarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KeluarBtn.UseVisualStyleBackColor = False
        '
        'FrmHistoryPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 511)
        Me.Controls.Add(Me.KeluarBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGHistory)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHistoryPenjualan"
        Me.Text = "FrmHistoryPenjualan"
        CType(Me.DGHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KeluarBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CariData As System.Windows.Forms.TextBox
    Friend WithEvents RbKdBarang As System.Windows.Forms.RadioButton
    Friend WithEvents RbFaktur As System.Windows.Forms.RadioButton
    Friend WithEvents DGHistory As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
