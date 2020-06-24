Public Class FrmBayar

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tbljual As DataTable
    Dim disc As Single

    Sub Bersih()
        LblSubTotal.Text = ""
        DiscTxt.Text = ""
        LblGrandTotal.Text = "0"
        BayarTxt.Text = "0"
        LblKembali.Text = "0"
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If BayarTxt.Text = "0" Then Exit Sub
        If BayarTxt.Text < Replace(LblGrandTotal.Text, ".", "") Then MsgBox("Pembayaran tidak cukup", MsgBoxStyle.Critical, "Bayar")

        SQL = "Insert Into Tblpenjualan Values ('" & FrmPenjualan.LblFaktur.Text & "','" &
            Format(Now, "yyyy/MM/dd") & "','" &
            Microsoft.VisualBasic.Left(FrmPenjualan.CmbPelanggan.Text, 7) & "','" &
            Replace(LblSubTotal.Text, ".", "") & "','" & DiscTxt.Text & "','" &
            Replace(LblGrandTotal.Text, ".", "") & "','" & BayarTxt.Text & "','" &
            Replace(LblKembali.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)

        Call Bersih()

        FrmPenjualan.Bersih()
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub

    Private Sub FrmBayar_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        DiscTxt.Focus()
    End Sub

    Private Sub DiscTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscTxt.TextChanged
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"
        disc = (Val(Replace(LblSubTotal.Text, ".", "") * DiscTxt.Text)) / 100

        LblGrandTotal.Text = (Val(Replace(LblSubTotal.Text, ".", "")) - Val(disc)).ToString("#,#")
    End Sub

    Private Sub LblGrandTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblGrandTotal.TextChanged
        If LblGrandTotal.Text = "" Then LblGrandTotal.Text = "0"
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub

    Private Sub BayarTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BayarTxt.TextChanged
        If BayarTxt.Text = "" Then BayarTxt.Text = "0"
        Dim Kembali As Single
        Kembali = Replace(LblKembali.Text, ".", "")
        LblKembali.Text = Kembali.ToString("#,#")
        If LblKembali.Text = "" Then LblKembali.Text = "0"
    End Sub
End Class