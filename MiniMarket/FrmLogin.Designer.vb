<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KdPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PswTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.LevelCbo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'KdPenggunaTxt
        '
        Me.KdPenggunaTxt.Location = New System.Drawing.Point(103, 14)
        Me.KdPenggunaTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.KdPenggunaTxt.Name = "KdPenggunaTxt"
        Me.KdPenggunaTxt.Size = New System.Drawing.Size(225, 27)
        Me.KdPenggunaTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password :"
        '
        'PswTxt
        '
        Me.PswTxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PswTxt.Location = New System.Drawing.Point(103, 51)
        Me.PswTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PswTxt.Name = "PswTxt"
        Me.PswTxt.Size = New System.Drawing.Size(225, 27)
        Me.PswTxt.TabIndex = 3
        Me.PswTxt.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(13, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Level :"
        '
        'BatalBtn
        '
        Me.BatalBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BatalBtn.BackColor = System.Drawing.Color.Transparent
        Me.BatalBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BatalBtn.FlatAppearance.BorderSize = 0
        Me.BatalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BatalBtn.Image = Global.MiniMarket.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BatalBtn.Location = New System.Drawing.Point(238, 126)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(90, 50)
        Me.BatalBtn.TabIndex = 7
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BatalBtn.UseVisualStyleBackColor = False
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.OkBtn.BackColor = System.Drawing.Color.Transparent
        Me.OkBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.OkBtn.FlatAppearance.BorderSize = 0
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OkBtn.Image = Global.MiniMarket.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OkBtn.Location = New System.Drawing.Point(103, 126)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(90, 50)
        Me.OkBtn.TabIndex = 6
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'LevelCbo
        '
        Me.LevelCbo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LevelCbo.FormattingEnabled = True
        Me.LevelCbo.Location = New System.Drawing.Point(103, 88)
        Me.LevelCbo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LevelCbo.Name = "LevelCbo"
        Me.LevelCbo.Size = New System.Drawing.Size(225, 28)
        Me.LevelCbo.TabIndex = 8
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.bg5
        Me.ClientSize = New System.Drawing.Size(344, 186)
        Me.Controls.Add(Me.LevelCbo)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PswTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KdPenggunaTxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 11.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KdPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PswTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents LevelCbo As System.Windows.Forms.ComboBox
End Class
