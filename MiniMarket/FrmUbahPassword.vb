Public Class FrmUbahPassword
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblUbahPsw As DataTable

    Sub bersih()
        PswLamaTxt.Text = ""
        PswBaruTxt.Text = ""
        PswLamaTxt.Focus()
    End Sub

    Private Sub UbahBtn_Click(sender As System.Object, e As System.EventArgs) Handles UbahBtn.Click
        If PswLamaTxt.Text = "" Then PswLamaTxt.Focus() : Exit Sub
        If PswBaruTxt.Text = "" Then PswBaruTxt.Focus() : Exit Sub

        tblUbahPsw = Proses.ExecuteQuery("Select * From TblPengguna Where password = '" & PswLamaTxt.Text & "'")
        If tblUbahPsw.Rows.Count = 0 Then
            MessageBox.Show("Perubahan password gagal!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PswLamaTxt.Text = "" : PswBaruTxt.Text = "" : PswLamaTxt.Focus()

        Else
            SQL = "Update TblPengguna Set password = '" & PswBaruTxt.Text & "' where Kode_Pengguna = '" & FrmMenuUtama.TsPengguna.Text & "'"
        Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Perubahan password sukses!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
            Me.Close()
        End If
    End Sub

    Private Sub BatalBtn_Click(sender As System.Object, e As System.EventArgs) Handles BatalBtn.Click
        Me.Close()
    End Sub

    Private Sub FrmUbahPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class