Public Class FrmPembelian

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblBeli As DataTable
    Dim disc As Single

    Private Sub FrmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbSupplier.Enabled = True
        SimpanBtn.Enabled = False
        Call Bersih()
    End Sub

    Sub Data_Record()
        tblBeli = Proses.ExecuteQuery("Select No, Kode_Barang, Nama_Barang, Harga_Beli, Jumlah, Sub_Total From TblPembelian_rinci where faktur_pembelian = '" & LblFaktur.Text & "' order by tblPembelian_rinci.no asc")
        DGPembelian.DataSource = tblBeli
        DGPembelian.Columns(0).Width = 40
        DGPembelian.Columns(1).Width = 110
        DGPembelian.Columns(2).Width = 240
        DGPembelian.Columns(3).Width = 130
        DGPembelian.Columns(4).Width = 130
    End Sub

    Sub Supplier()
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier asc")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbSupplier.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbSupplier.Items.Add(.Table.Rows(a).Item(0) + "/" + .Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub

    Sub Barang()
        tblBeli = Proses.ExecuteQuery("Select * From TblBarang order by Kode_Barang asc")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbBarang.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbBarang.Items.Add(.Table.Rows(a).Item(0) + "/" + .Table.Rows(a).Item(2))
                Next a
            End With
        End If
    End Sub

    Sub Bersih()
        CmbBarang.Text = ""
        LblNmBarang.Text = ""
        LblHrg.Text = ""
        LblStock.Text = ""
        TxtJml.Text = ""

        CmbSupplier.Enabled = True
        CmbBarang.Enabled = True
        CmbSupplier.Focus()

        Call Supplier()
        Call Barang()
        Call Faktur_Otomatis()
        Call Data_Record()

        On Error Resume Next

        Dim Total_Seluruh As Single

        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            Total_Seluruh = Val(Total_Seluruh) + Val(DGPembelian.Item(5, i).Value)
        Next

        LblTotHrgKotor.Text = Total_Seluruh.ToString("#,#")
    End Sub

    Sub Faktur_Otomatis()
        tblBeli = Proses.ExecuteQuery("Select * From TblPembelian order by Faktur_Pembelian desc")
        If tblBeli.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tblBeli.Rows(0)
                LblFaktur.Text = .Item("Faktur_Pembelian")
            End With
            LblFaktur.Text = Val(LblFaktur.Text) + 1
            If Len(LblFaktur.Text) = 1 Then
                LblFaktur.Text = "000" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 2 Then
                LblFaktur.Text = "00" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 3 Then
                LblFaktur.Text = "0" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 4 Then
                LblFaktur.Text = "" & LblFaktur.Text & ""
            End If
        End If
    End Sub

    Private Sub CmbSupplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSupplier.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbSupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSupplier.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier Where kode_supplier = '" & Mid(CmbSupplier.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNmSupplier.Text = tblBeli.Rows(0).Item("Nama_Supplier")
        End If
    End Sub

    Private Sub CmbBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbBarang.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBarang.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblBarang Where kode_barang = '" & Mid(CmbBarang.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNmBarang.Text = tblBeli.Rows(0).Item("Nama_Barang")
            LblHrg.Text = tblBeli.Rows(0).Item("Harga_Beli")
            LblStock.Text = tblBeli.Rows(0).Item("Stock")
            TxtJml.Focus()
        End If
    End Sub

    Private Sub DiscTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscTxt.TextChanged
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"
        disc = (Val(Replace(LblTotHrgKotor.Text, ".", "") * DiscTxt.Text)) / 100
        LblTotHrgBersih.Text = (Val(Replace(LblTotHrgKotor.Text, ".", "")) - Val(disc)).ToString("#,#")
    End Sub

    Private Sub LblTotHrgBersih_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTotHrgBersih.TextChanged
        If LblTotHrgBersih.Text = "" Then LblTotHrgBersih.Text = "0"
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            tblBeli = Proses.ExecuteQuery("Select * From TblBarang Where kode_barang = '" & DGPembelian.Item(2, i).Value & "'")
            If tblBeli.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblBeli.Rows(0).Item("stock")) - Val(DGPembelian.Item(4, i).Value)
                SQL = "update TblBarang set stock = '" & CInt(Jumlah) & "' Where kode_barang = '" & DGPembelian.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "delete from TblPembelian_rinci where faktur_pembelian = '" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)

        LblTotHrgKotor.Text = "0"
        DiscTxt.Text = "0"
        LblTotHrgBersih.Text = "0"
        Call Bersih()
Keluar:
    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If LblTotHrgKotor.Text = "0" Then Exit Sub
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"

        SQL = "Insert Into TblPembelian Values ('" & LblFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(CmbSupplier.Text, 6) & "','" & DiscTxt.Text & "','" & Replace(LblTotHrgBersih.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        MsgBox("Pembelian Berhasil !")

        Call Bersih()
        CmbSupplier.Text = ""
        LblNmSupplier.Text = ""
        LblTotHrgKotor.Text = "0"
        LblTotHrgBersih.Text = "0"
        DiscTxt.Text = "0"
        CmbSupplier.Focus()
    End Sub

    Private Sub TxtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJml.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJml.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tblBeli = Proses.ExecuteQuery("Select * From TblPembelian_rinci Where faktur_pembelian = '" & LblFaktur.Text & "' and kode_barang = '" & Mid(CmbBarang.Text, 1, 6) & "'")
                If tblBeli.Rows.Count = 0 Then
                    Dim total = Val(LblHrg.Text) * Val(TxtJml.Text)
                    SQL = "Insert Into TblPembelian_rinci Values ('" & LblFaktur.Text & "','" & DGPembelian.RowCount & "','" & Mid(CmbBarang.Text, 1, 6) & "','" & LblNmBarang.Text & "','" & LblHrg.Text & "','" & TxtJml.Text & "','" & total & "')"
                    Proses.ExecuteNonQuery(SQL)

                    Dim stock = Val(LblStock.Text) + Val(TxtJml.Text)
                    SQL = "update tblbarang set stock ='" & stock & "' where kode_barang ='" & Mid(CmbBarang.Text, 1, 6) & "'"
                    Proses.ExecuteNonQuery(SQL)
                    SimpanBtn.Enabled = True
                Else
                    MsgBox("Proses pembelian tidak dapat dilakukan !")
                End If

                Call Bersih()
                Dim Total_Seluruh As Single
                Dim i As Integer
                i = DGPembelian.CurrentRow.Index
                For i = 0 To DGPembelian.Rows.Count - 1
                    Total_Seluruh = Val(Total_Seluruh) + Val(DGPembelian.Item(5, i).Value)

                Next
                LblTotHrgKotor.Text = Total_Seluruh.ToString("#,#")
                If DiscTxt.Text = "" Then DiscTxt.Text = "0"
                disc = (Val(Replace(LblTotHrgKotor.Text, ".", "") * DiscTxt.Text)) / 100
                LblTotHrgBersih.Text = (Val(Replace(LblTotHrgKotor.Text, ".", "")) - Val(disc)).ToString("#,#")
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

End Class
