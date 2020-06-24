Public Class FrmPengguna
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblPengguna As DataTable

    Private Sub FrmPengguna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = 0
        Top = 0
        Call Bersih()
        LevelCbo.Items.Add("ADMIN")
        LevelCbo.Items.Add("OPERATOR")
    End Sub

    Private Sub FrmPengguna_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Data_Record()
    End Sub

    Sub Bersih()
        KdPenggunaTxt.Enabled = True : KdPenggunaTxt.Text = "" : NmPenggunaTxt.Text = ""
        PasswordTxt.Text = "" : UlgPassword.Text = "" : LevelCbo.Text = ""

        Call kode_otomatis()
        Call Data_Record()
        SimpanBtn.Enabled = True : UbahBtn.Enabled = False : HapusBtn.Enabled = False
        BatalBtn.Enabled = False : TutupBtn.Enabled = True : KdPenggunaTxt.Enabled = False
        PasswordTxt.Enabled = True : UlgPassword.Enabled = True
    End Sub

    Sub Data_Record()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna")
        DGPengguna.DataSource = tblPengguna
        DGPengguna.Columns(0).Width = 125
        DGPengguna.Columns(1).Width = 205
        DGPengguna.Columns(2).Visible = False
        DGPengguna.Columns(3).Width = 85
    End Sub

    Sub kode_otomatis()
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna order by Kode_Pengguna desc")
        If tblPengguna.Rows.Count = 0 Then
            KdPenggunaTxt.Text = "PGN-001"
        Else
            With tblPengguna.Rows(0)
                KdPenggunaTxt.Text = .Item("Kode_Pengguna")
                KdPenggunaTxt.Focus()
            End With

            KdPenggunaTxt.Text = Val(Microsoft.VisualBasic.Mid(KdPenggunaTxt.Text, 5, 3)) + 1
            If Len(KdPenggunaTxt.Text) = 1 Then
                KdPenggunaTxt.Text = "PGN-00" & KdPenggunaTxt.Text & ""
            ElseIf Len(KdPenggunaTxt.Text) = 2 Then
                KdPenggunaTxt.Text = "PGN-0" & KdPenggunaTxt.Text & ""
            ElseIf Len(KdPenggunaTxt.Text) = 3 Then
                KdPenggunaTxt.Text = "PGN-" & KdPenggunaTxt.Text & ""
            End If

        End If
    End Sub

    Private Sub SimpanBtn_Click(sender As System.Object, e As System.EventArgs) Handles SimpanBtn.Click
        If NmPenggunaTxt.Text = "" Then NmPenggunaTxt.Focus() : Exit Sub
        If PasswordTxt.Text = "" Then PasswordTxt.Focus() : Exit Sub
        If UlgPassword.Text = "" Then UlgPassword.Focus() : Exit Sub
        If LevelCbo.Text = "" Then LevelCbo.Focus() : Exit Sub

        If PasswordTxt.Text <> UlgPassword.Text Then MsgBox("Ulangi konfirmasi password salah!", MsgBoxStyle.Critical, "Password") : UlgPassword.Focus() : Exit Sub

        SQL = "Insert Into TblPengguna Values ('" & KdPenggunaTxt.Text & "', '" & NmPenggunaTxt.Text & "', '" & PasswordTxt.Text & "', '" & LevelCbo.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data baru berhasil disimpan!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub


    Private Sub UbahBtn_Click(sender As System.Object, e As System.EventArgs) Handles UbahBtn.Click
        If NmPenggunaTxt.Text = "" Then NmPenggunaTxt.Focus() : Exit Sub
        If LevelCbo.Text = "" Then LevelCbo.Focus() : Exit Sub

        SQL = "Update TblPengguna Set Nama_Pengguna ='" & NmPenggunaTxt.Text & "', Level ='" & LevelCbo.Text & "' where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dirubah!", "Perubahan data sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub HapusBtn_Click(sender As System.Object, e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete From TblPengguna Where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus euy !", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub


    Private Sub BatalBtn_Click(sender As System.Object, e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdPenggunaTxt.Focus()
    End Sub

    Private Sub TutupBtn_Click(sender As System.Object, e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub


    Private Sub CariBtn_Click(sender As System.Object, e As System.EventArgs) Handles CariBtn.Click
        KdPenggunaTxt.Text = InputBox("Masukkan kode pengguna !")
        If KdPenggunaTxt.Text = "" Then Call kode_otomatis() : NmPenggunaTxt.Focus() : Exit Sub
        tblPengguna = Proses.ExecuteQuery("Select * From TblPengguna Where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'")
        If tblPengguna.Rows.Count = 0 Then
            MessageBox.Show("Data Pengguna Tidak Ditemukan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NmPenggunaTxt.Focus()
            Call kode_otomatis()
        Else
            With tblPengguna.Rows(0)
                KdPenggunaTxt.Text = .Item("Kode_Pengguna")
                NmPenggunaTxt.Text = .Item("Nama_Pengguna")
                PasswordTxt.Text = .Item("Password")
                PasswordTxt.Enabled = False
                UlgPassword.Enabled = False
                LevelCbo.Text = .Item("level")
            End With
            SimpanBtn.Enabled = False : UbahBtn.Enabled = True
            HapusBtn.Enabled = True : BatalBtn.Enabled = True
        End If
    End Sub

    Private Sub DGPengguna_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGPengguna.DoubleClick
        KdPenggunaTxt.Text = DGPengguna.SelectedCells(0).Value
        NmPenggunaTxt.Text = DGPengguna.SelectedCells(1).Value
        PasswordTxt.Text = DGPengguna.SelectedCells(2).Value
        LevelCbo.Text = DGPengguna.SelectedCells(3).Value

        SimpanBtn.Enabled = False
        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        BatalBtn.Enabled = True
        TutupBtn.Enabled = False
    End Sub
End Class
