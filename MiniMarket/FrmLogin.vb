Public Class FrmLogin
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblLogin As DataTable

    Sub Bersih()
        KdPenggunaTxt.Enabled = True : KdPenggunaTxt.Text = "" : PswTxt.Text = "" : LevelCbo.Text = ""
    End Sub

    Sub Login()
        If KdPenggunaTxt.Text = "" Then KdPenggunaTxt.Focus() : Exit Sub
        If PswTxt.Text = "" Then PswTxt.Focus() : Exit Sub
        If LevelCbo.Text = "" Then LevelCbo.Focus() : Exit Sub
        tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where Kode_Pengguna = '" & KdPenggunaTxt.Text & "' and password = '" & PswTxt.Text & "'")
        If tblLogin.Rows.Count = 0 Then
            MessageBox.Show("cek kembali password!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            KdPenggunaTxt.Focus()
        Else
            FrmMenuUtama.TsPengguna.Text = KdPenggunaTxt.Text
            FrmMenuUtama.TsLevel.Text = LevelCbo.Text
            Me.Hide()
            FrmMenuUtama.Show()
        End If
    End Sub

    Private Sub KdPenggunaTxt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles KdPenggunaTxt.KeyPress
        If e.KeyChar = Chr(13) Then
            tblLogin = Proses.ExecuteQuery("Select * From TblPengguna Where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'")
            If tblLogin.Rows.Count = 0 Then
                MessageBox.Show("Kode tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KdPenggunaTxt.Focus() : LevelCbo.Text = ""
            Else
                LevelCbo.Text = tblLogin.Rows(0).Item("level")
                PswTxt.Focus()
            End If
        End If
    End Sub

    Private Sub PswTxt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PswTxt.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub OkBtn_Click(sender As System.Object, e As System.EventArgs) Handles OkBtn.Click
        Call Login()
    End Sub

    Private Sub BatalBtn_Click(sender As System.Object, e As System.EventArgs) Handles BatalBtn.Click
        End
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = 0
        Top = 0
        Call Bersih()
        LevelCbo.Items.Add("ADMIN")
        LevelCbo.Items.Add("OPERATOR")
    End Sub

End Class
