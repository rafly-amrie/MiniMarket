Public Class FrmSupplier
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblsupplier As DataTable

    Sub Data_Record()
        tblsupplier = Proses.ExecuteQuery("Select * From TblSupplier order by kode_supplier asc")
        DGSupplier.DataSource = tblsupplier
        DGSupplier.Columns(0).Width = 110
        DGSupplier.Columns(1).Width = 200
        DGSupplier.Columns(2).Width = 210
        DGSupplier.Columns(3).Width = 110
        DGSupplier.Columns(4).Width = 110
    End Sub

    Sub Kode_Otomatis()
        tblsupplier = Proses.ExecuteQuery("Select * From TblSupplier order by kode_supplier desc")
        If tblsupplier.Rows.Count = 0 Then
            KdSupplierTxt.Text = "KS-001"
        Else
            With tblsupplier.Rows(0)
                KdSupplierTxt.Text = .Item("kode_supplier")
            End With

            KdSupplierTxt.Text = Val(Microsoft.VisualBasic.Mid(KdSupplierTxt.Text, 4, 3)) + 1

            If Len(KdSupplierTxt.Text) = 1 Then
                KdSupplierTxt.Text = "KS-00" & KdSupplierTxt.Text & ""
            ElseIf Len(KdSupplierTxt.Text) = 2 Then
                KdSupplierTxt.Text = "KS-0" & KdSupplierTxt.Text & ""
            ElseIf Len(KdSupplierTxt.Text) = 3 Then
                KdSupplierTxt.Text = "KS-" & KdSupplierTxt.Text & ""
            End If

        End If
    End Sub

    Sub Bersih()
        KdSupplierTxt.Text = ""
        NmSupplierTxt.Text = ""
        AlmTxt.Text = ""
        TlpTxt.Text = ""
        KontakTxt.Text = ""
        NmSupplierTxt.Focus()

        Call Kode_Otomatis()
        Call Data_Record()

        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        TutupBtn.Enabled = True

    End Sub

    Private Sub FrmSupplier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub DGSupplier_DoubleClick(sender As Object, e As System.EventArgs) Handles DGSupplier.DoubleClick
        KdSupplierTxt.Text = DGSupplier.SelectedCells(0).Value
        NmSupplierTxt.Text = DGSupplier.SelectedCells(1).Value
        AlmTxt.Text = DGSupplier.SelectedCells(2).Value
        TlpTxt.Text = DGSupplier.SelectedCells(3).Value
        KontakTxt.Text = DGSupplier.SelectedCells(4).Value

        SimpanBtn.Enabled = False : UbahBtn.Enabled = True : HapusBtn.Enabled = True
        BatalBtn.Enabled = True : TutupBtn.Enabled = False
    End Sub

    Private Sub CariKdSupplier_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CariKdSupplier.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariNmSupplier_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CariNmSupplier.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariKontak_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CariKontak.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariDataTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariKdSupplier.Checked = True Then
            tblsupplier = Proses.ExecuteQuery("Select * From TblSupplier where Kode_Supplier Like '%" & CariDataTxt.Text & "%'")
            If tblsupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblsupplier
                CariDataTxt.Focus()
            Else
                DGSupplier.DataSource = tblsupplier
            End If

        ElseIf CariNmSupplier.Checked = True Then
            tblsupplier = Proses.ExecuteQuery("Select * From TblSupplier where Nama_Supplier Like '%" & CariDataTxt.Text & "%'")
            If tblsupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblsupplier
                CariDataTxt.Focus()
            Else
                DGSupplier.DataSource = tblsupplier
            End If

        ElseIf CariKontak.Checked = True Then
            tblsupplier = Proses.ExecuteQuery("Select * From TblSupplier where Kontak Like '%" & CariDataTxt.Text & "%'")
            If tblsupplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblsupplier
                CariDataTxt.Focus()
            Else
                DGSupplier.DataSource = tblsupplier
            End If
        End If
    End Sub

    Private Sub SimpanBtn_Click(sender As System.Object, e As System.EventArgs) Handles SimpanBtn.Click
        If KdSupplierTxt.Text = "" Then KdSupplierTxt.Focus() : Exit Sub
        If NmSupplierTxt.Text = "" Then NmSupplierTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        If KontakTxt.Text = "" Then KontakTxt.Focus() : Exit Sub

        SQL = "Insert Into tblsupplier Values ('" & KdSupplierTxt.Text & "', '" & NmSupplierTxt.Text & "', '" & AlmTxt.Text & "', '" & TlpTxt.Text & "', '" & KontakTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data baru telah disimpan euy !", "Penyimpan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub UbahBtn_Click(sender As System.Object, e As System.EventArgs) Handles UbahBtn.Click
        If KdSupplierTxt.Text = "" Then KdSupplierTxt.Focus() : Exit Sub
        If NmSupplierTxt.Text = "" Then NmSupplierTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        If KontakTxt.Text = "" Then KontakTxt.Focus() : Exit Sub

        SQL = "Update tblsupplier Set Nama_Supplier ='" & NmSupplierTxt.Text & "', Alamat ='" & AlmTxt.Text & "', Telepon ='" & TlpTxt.Text & "', Kontak ='" & KontakTxt.Text & "' where Kode_Supplier = '" & KdSupplierTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data  telah di Ubah euy !", "Perubahan Data Suskses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub HapusBtn_Click(sender As System.Object, e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete From TblSupplier Where Kode_Supplier ='" & KdSupplierTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah di Hapus euy !", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BatalBtn_Click(sender As System.Object, e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdSupplierTxt.Focus()
    End Sub

    Private Sub TutupBtn_Click(sender As System.Object, e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

    Private Sub KdSupplierTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdSupplierTxt.TextChanged

    End Sub
End Class