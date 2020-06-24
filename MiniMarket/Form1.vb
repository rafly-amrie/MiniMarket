Public Class FrmMenuUtama

    Private Sub FrmMenuUtama_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim ask = MessageBox.Show("Anda yakin mau menutup aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim ask = MessageBox.Show("Anda yakin mau Log Out?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            FrmLogin.Show()
        End If
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggunaToolStripMenuItem.Click
        FrmPengguna.Show()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        FrmUbahPassword.Show()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HakAksesToolStripMenuItem.Click
        FrmHakAkses.Show()
    End Sub

    Private Sub KelompokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelompokToolStripMenuItem.Click
        FrmKelompok.Show()
    End Sub

    Private Sub SatuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SatuanToolStripMenuItem.Click
        FrmSatuan.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        FrmSupplier.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        FrmPembelian.Show()
    End Sub

    Private Sub RiwayatPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RiwayatPembelianToolStripMenuItem.Click
        FrmHistoryPembelian.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrmPenjualan.Show()
    End Sub
    
    Private Sub PenggunaTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggunaTS.Click
        FrmPengguna.Show()
    End Sub

    Private Sub UbahPwdTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahPwdTS.Click
        FrmUbahPassword.Show()
    End Sub

    Private Sub PelangganTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganTS.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub SupplierTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierTS.Click
        FrmSupplier.Show()
    End Sub

    Private Sub BarangTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangTS.Click
        FrmBarang.Show()
    End Sub

    Private Sub PembelianTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianTS.Click
        FrmPembelian.Show()
    End Sub

    Private Sub PenjualanTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanTS.Click
        FrmPenjualan.Show()
    End Sub

    Private Sub RiwayatPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RiwayatPenjualanToolStripMenuItem.Click
        FrmHistoryPenjualan.Show()
    End Sub
End Class
