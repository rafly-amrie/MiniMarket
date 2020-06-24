<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPengguna))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KdPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NmPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UlgPassword = New System.Windows.Forms.TextBox()
        Me.LevelCbo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGPengguna = New System.Windows.Forms.DataGridView()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.CariBtn = New System.Windows.Forms.Button()
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pengguna"
        '
        'KdPenggunaTxt
        '
        Me.KdPenggunaTxt.Location = New System.Drawing.Point(140, 18)
        Me.KdPenggunaTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdPenggunaTxt.Name = "KdPenggunaTxt"
        Me.KdPenggunaTxt.Size = New System.Drawing.Size(132, 27)
        Me.KdPenggunaTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Pengguna"
        '
        'NmPenggunaTxt
        '
        Me.NmPenggunaTxt.Location = New System.Drawing.Point(140, 58)
        Me.NmPenggunaTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NmPenggunaTxt.Name = "NmPenggunaTxt"
        Me.NmPenggunaTxt.Size = New System.Drawing.Size(256, 27)
        Me.NmPenggunaTxt.TabIndex = 4
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(140, 98)
        Me.PasswordTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(256, 27)
        Me.PasswordTxt.TabIndex = 5
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UlgPassword
        '
        Me.UlgPassword.Location = New System.Drawing.Point(140, 138)
        Me.UlgPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UlgPassword.Name = "UlgPassword"
        Me.UlgPassword.Size = New System.Drawing.Size(256, 27)
        Me.UlgPassword.TabIndex = 6
        Me.UlgPassword.UseSystemPasswordChar = True
        '
        'LevelCbo
        '
        Me.LevelCbo.FormattingEnabled = True
        Me.LevelCbo.Location = New System.Drawing.Point(140, 178)
        Me.LevelCbo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LevelCbo.Name = "LevelCbo"
        Me.LevelCbo.Size = New System.Drawing.Size(256, 28)
        Me.LevelCbo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Ulang Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Level"
        '
        'DGPengguna
        '
        Me.DGPengguna.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.DGPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPengguna.Location = New System.Drawing.Point(20, 290)
        Me.DGPengguna.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGPengguna.Name = "DGPengguna"
        Me.DGPengguna.Size = New System.Drawing.Size(460, 250)
        Me.DGPengguna.TabIndex = 16
        '
        'TutupBtn
        '
        Me.TutupBtn.BackColor = System.Drawing.Color.Transparent
        Me.TutupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.TutupBtn.FlatAppearance.BorderSize = 5
        Me.TutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TutupBtn.Image = Global.MiniMarket.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Stop
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(319, 215)
        Me.TutupBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(70, 65)
        Me.TutupBtn.TabIndex = 15
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = False
        '
        'BatalBtn
        '
        Me.BatalBtn.BackColor = System.Drawing.Color.Transparent
        Me.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatAppearance.BorderSize = 5
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatalBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_4_Refresh
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(244, 215)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(70, 65)
        Me.BatalBtn.TabIndex = 14
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = False
        '
        'HapusBtn
        '
        Me.HapusBtn.BackColor = System.Drawing.Color.Transparent
        Me.HapusBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.HapusBtn.FlatAppearance.BorderSize = 5
        Me.HapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HapusBtn.Image = Global.MiniMarket.My.Resources.Resources.Dooffy_Characters_X1
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(170, 215)
        Me.HapusBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(70, 65)
        Me.HapusBtn.TabIndex = 13
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = False
        '
        'UbahBtn
        '
        Me.UbahBtn.BackColor = System.Drawing.Color.Transparent
        Me.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.BorderSize = 5
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UbahBtn.Image = Global.MiniMarket.My.Resources.Resources.Pixelkit_Swanky_Outlines_08_Wrench
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(95, 215)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(70, 65)
        Me.UbahBtn.TabIndex = 12
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = False
        '
        'SimpanBtn
        '
        Me.SimpanBtn.BackColor = System.Drawing.Color.Transparent
        Me.SimpanBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SimpanBtn.FlatAppearance.BorderSize = 5
        Me.SimpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SimpanBtn.Image = Global.MiniMarket.My.Resources.Resources.Custom_Icon_Design_Mono_General_1_Save
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(20, 215)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(70, 65)
        Me.SimpanBtn.TabIndex = 11
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = False
        '
        'CariBtn
        '
        Me.CariBtn.BackColor = System.Drawing.Color.Transparent
        Me.CariBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CariBtn.FlatAppearance.BorderSize = 0
        Me.CariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CariBtn.Image = Global.MiniMarket.My.Resources.Resources.search2
        Me.CariBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CariBtn.Location = New System.Drawing.Point(400, 242)
        Me.CariBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CariBtn.Name = "CariBtn"
        Me.CariBtn.Size = New System.Drawing.Size(80, 38)
        Me.CariBtn.TabIndex = 3
        Me.CariBtn.Text = "Cari"
        Me.CariBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CariBtn.UseVisualStyleBackColor = False
        '
        'FrmPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(499, 546)
        Me.Controls.Add(Me.DGPengguna)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LevelCbo)
        Me.Controls.Add(Me.UlgPassword)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.NmPenggunaTxt)
        Me.Controls.Add(Me.CariBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KdPenggunaTxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPengguna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengguna"
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KdPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CariBtn As System.Windows.Forms.Button
    Friend WithEvents NmPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UlgPassword As System.Windows.Forms.TextBox
    Friend WithEvents LevelCbo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents DGPengguna As System.Windows.Forms.DataGridView
End Class
