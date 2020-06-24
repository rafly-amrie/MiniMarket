Public Class FrmBarang
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblBarang As DataTable

    Private Sub FrmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Sub Data_Record()
        tblBarang = Proses.ExecuteQuery("Select * From tblbarang order by kode_barang asc")
        DGBarang.DataSource = tblBarang
        DGBarang.Columns(1).Width = 110
        DGBarang.Columns(2).Width = 216
    End Sub

    Sub Kelompok()
        tblBarang = Proses.ExecuteQuery("Select * From TblKelompok order by no asc")
        If tblBarang.Rows.Count = 0 Then
        Else
            CmbKelompok.Items.Clear()
            With tblBarang.Columns(1)
                For a = 0 To tblBarang.Rows.Count - 1
                    CmbKelompok.Items.Add(.Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub

    Sub Satuan()
        tblBarang = Proses.ExecuteQuery("Select * From TblSatuan order by no asc")
        If tblBarang.Rows.Count = 0 Then
        Else
            CmbSatuan.Items.Clear()
            With tblBarang.Columns(1)
                For a = 0 To tblBarang.Rows.Count - 1
                    CmbSatuan.Items.Add(.Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub

    Sub Kode_Otomatis()
        tblBarang = Proses.ExecuteQuery("Select * From TblBarang order by kode_barang desc")
        If tblBarang.Rows.Count = 0 Then
            KdBarangTxt.Text = "KB-001"
        Else
            With tblBarang.Rows(0)
                KdBarangTxt.Text = .Item("kode_barang")
            End With

            KdBarangTxt.Text = Val(Microsoft.VisualBasic.Mid(KdBarangTxt.Text, 4, 3)) + 1

            If Len(KdBarangTxt.Text) = 1 Then
                KdBarangTxt.Text = "KB-00" & KdBarangTxt.Text & ""
            ElseIf Len(KdBarangTxt.Text) = 2 Then
                KdBarangTxt.Text = "KB-0" & KdBarangTxt.Text & ""
            ElseIf Len(KdBarangTxt.Text) = 3 Then
                KdBarangTxt.Text = "KB-" & KdBarangTxt.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        BarcodeTxt.Text = ""
        NmBarangTxt.Text = ""
        CmbKelompok.Text = ""
        CmbSatuan.Text = ""
        HrgBeliTxt.Text = ""
        HrgJualTxt.Text = ""
        StockTxt.Text = "0"
        BarcodeTxt.Focus()

        Call Kode_Otomatis()
        Call Data_Record()
        Call Kelompok()
        Call Satuan()

        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False

    End Sub

    Private Sub HrgBeliTxt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles HrgBeliTxt.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                HrgBeliTxt.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub HrgJualTxt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles HrgJualTxt.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                HrgJualTxt.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub CariDataTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariKdBarang.Checked = True Then
            tblBarang = Proses.ExecuteQuery("Select * From TblBarang where kode_barang Like '%" & CariDataTxt.Text & "%'")
            If tblBarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblBarang
                CariDataTxt.Focus()
            Else
                DGBarang.DataSource = tblBarang
            End If

        ElseIf CariNmBarang.Checked = True Then
            tblBarang = Proses.ExecuteQuery("Select * From TblBarang where nama_barang Like '%" & CariDataTxt.Text & "%'")
        If tblBarang.Rows.Count = 0 Then
            DGBarang.DataSource = tblBarang
            CariDataTxt.Focus()
        Else
            DGBarang.DataSource = tblBarang
            End If

        ElseIf CariStock.Checked = True Then
            tblBarang = Proses.ExecuteQuery("Select * From TblBarang where stock Like '%" & CariDataTxt.Text & "%'")
            If tblBarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblBarang
                CariDataTxt.Focus()
            Else
                DGBarang.DataSource = tblBarang
            End If
        End If
    End Sub

    Private Sub DGBarang_DoubleClick(sender As Object, e As System.EventArgs) Handles DGBarang.DoubleClick
        KdBarangTxt.Text = DGBarang.SelectedCells(0).Value
        BarcodeTxt.Text = DGBarang.SelectedCells(1).Value
        NmBarangTxt.Text = DGBarang.SelectedCells(2).Value
        CmbKelompok.Text = DGBarang.SelectedCells(3).Value
        CmbSatuan.Text = DGBarang.SelectedCells(4).Value
        HrgBeliTxt.Text = DGBarang.SelectedCells(5).Value
        HrgJualTxt.Text = DGBarang.SelectedCells(6).Value
        StockTxt.Text = DGBarang.SelectedCells(7).Value

        SimpanBtn.Enabled = False : UbahBtn.Enabled = True : HapusBtn.Enabled = True
        BatalBtn.Enabled = True : TutupBtn.Enabled = True
    End Sub

    Private Sub CariKdBarang_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CariKdBarang.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariNmBarang_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CariNmBarang.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariStock_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CariStock.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub SimpanBtn_Click(sender As System.Object, e As System.EventArgs) Handles SimpanBtn.Click
        If BarcodeTxt.Text = "" Then BarcodeTxt.Focus() : Exit Sub
        If NmBarangTxt.Text = "" Then NmBarangTxt.Focus() : Exit Sub
        If CmbKelompok.Text = "" Then CmbKelompok.Focus() : Exit Sub
        If CmbSatuan.Text = "" Then CmbSatuan.Focus() : Exit Sub
        If HrgBeliTxt.Text = "" Then HrgBeliTxt.Focus() : Exit Sub
        If HrgJualTxt.Text = "" Then HrgJualTxt.Focus() : Exit Sub
        If StockTxt.Text = "" Then StockTxt.Focus() : Exit Sub

        SQL = "Insert Into TblBarang Values ('" & KdBarangTxt.Text & "', '" & BarcodeTxt.Text & "', '" & NmBarangTxt.Text & "', '" & CmbKelompok.Text & "', '" & CmbSatuan.Text & "', '" & HrgBeliTxt.Text & "', '" & HrgJualTxt.Text & "', '" & StockTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data baru berhasil disimpan!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub UbahBtn_Click(sender As System.Object, e As System.EventArgs) Handles UbahBtn.Click
        If BarcodeTxt.Text = "" Then BarcodeTxt.Focus() : Exit Sub
        If NmBarangTxt.Text = "" Then NmBarangTxt.Focus() : Exit Sub
        If CmbKelompok.Text = "" Then CmbKelompok.Focus() : Exit Sub
        If CmbSatuan.Text = "" Then CmbSatuan.Focus() : Exit Sub
        If HrgBeliTxt.Text = "" Then HrgBeliTxt.Focus() : Exit Sub
        If HrgJualTxt.Text = "" Then HrgJualTxt.Focus() : Exit Sub
        If StockTxt.Text = "" Then StockTxt.Focus() : Exit Sub

        SQL = "Update TblBarang Set kode_barcode ='" & BarcodeTxt.Text & "', nama_barang ='" & NmBarangTxt.Text & "', kelompok ='" & CmbKelompok.Text & "', satuan ='" & CmbSatuan.Text & "', harga_beli ='" & HrgBeliTxt.Text & "', harga_jual ='" & HrgJualTxt.Text & "', stock ='" & StockTxt.Text & "' where kode_barang = '" & KdBarangTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil diubah!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub HapusBtn_Click(sender As System.Object, e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete From TblBarang Where kode_barang ='" & KdBarangTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data berhasil dihapus!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BatalBtn_Click(sender As System.Object, e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdBarangTxt.Focus()
    End Sub

    Private Sub TutupBtn_Click(sender As System.Object, e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

End Class
