<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUbahPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUbahPassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PswLamaTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PswBaruTxt = New System.Windows.Forms.TextBox()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Lama"
        '
        'PswLamaTxt
        '
        Me.PswLamaTxt.Location = New System.Drawing.Point(132, 14)
        Me.PswLamaTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PswLamaTxt.Name = "PswLamaTxt"
        Me.PswLamaTxt.Size = New System.Drawing.Size(296, 27)
        Me.PswLamaTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password Baru"
        '
        'PswBaruTxt
        '
        Me.PswBaruTxt.Location = New System.Drawing.Point(132, 51)
        Me.PswBaruTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PswBaruTxt.Name = "PswBaruTxt"
        Me.PswBaruTxt.Size = New System.Drawing.Size(296, 27)
        Me.PswBaruTxt.TabIndex = 3
        '
        'BatalBtn
        '
        Me.BatalBtn.BackColor = System.Drawing.Color.Transparent
        Me.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatalBtn.Image = Global.MiniMarket.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BatalBtn.Location = New System.Drawing.Point(338, 88)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 50)
        Me.BatalBtn.TabIndex = 9
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BatalBtn.UseVisualStyleBackColor = False
        '
        'UbahBtn
        '
        Me.UbahBtn.BackColor = System.Drawing.Color.Transparent
        Me.UbahBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.UbahBtn.FlatAppearance.BorderSize = 0
        Me.UbahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UbahBtn.Image = Global.MiniMarket.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UbahBtn.Location = New System.Drawing.Point(132, 88)
        Me.UbahBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(90, 50)
        Me.UbahBtn.TabIndex = 8
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UbahBtn.UseVisualStyleBackColor = False
        '
        'FrmUbahPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(437, 166)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.PswBaruTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PswLamaTxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmUbahPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ubah Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PswLamaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PswBaruTxt As System.Windows.Forms.TextBox
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
End Class
