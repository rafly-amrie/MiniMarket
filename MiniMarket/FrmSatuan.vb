Public Class FrmSatuan

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblsatuan As DataTable

    Sub Data_Record()
        tblsatuan = Proses.ExecuteQuery("Select * From TblSatuan order by No asc")
        DGSatuan.DataSource = tblsatuan
        DGSatuan.Columns(0).Width = 160
        DGSatuan.Columns(1).Width = 160
    End Sub

    Sub kode_otomatis()
        tblsatuan = Proses.ExecuteQuery("Select * From TblSatuan order by No desc")
        If tblsatuan.Rows.Count = 0 Then
            KdSatuanTxt.Text = "STN-001"
        Else
            With tblsatuan.Rows(0)
                KdSatuanTxt.Text = .Item("No")
                KdSatuanTxt.Focus()
            End With

            KdSatuanTxt.Text = Val(Microsoft.VisualBasic.Mid(KdSatuanTxt.Text, 5, 3)) + 1

            If Len(KdSatuanTxt.Text) = 1 Then
                KdSatuanTxt.Text = "STN-00" & KdSatuanTxt.Text & ""
            ElseIf Len(KdSatuanTxt.Text) = 2 Then
                KdSatuanTxt.Text = "STN-0" & KdSatuanTxt.Text & ""
            ElseIf Len(KdSatuanTxt.Text) = 3 Then
                KdSatuanTxt.Text = "STN-" & KdSatuanTxt.Text & ""
            End If
        End If
    End Sub

    Sub bersih()
        Call Data_Record()
        Call kode_otomatis()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        KdSatuanTxt.Enabled = False
        SatuanTxt.Text = ""
        SatuanTxt.Focus()
    End Sub

    Private Sub FrmSatuan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call bersih()
    End Sub


    Private Sub SimpanBtn_Click(sender As System.Object, e As System.EventArgs) Handles SimpanBtn.Click
        If SatuanTxt.Text = "" Then SatuanTxt.Focus() : Exit Sub

        SQL = "Insert Into TblSatuan Values ('" & KdSatuanTxt.Text & "','" & SatuanTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub UbahBtn_Click(sender As System.Object, e As System.EventArgs) Handles UbahBtn.Click
        If SatuanTxt.Text = "" Then SatuanTxt.Focus() : Exit Sub

        SQL = "Update TblSatuan set Satuan = '" & SatuanTxt.Text & "' Where No = '" & KdSatuanTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub HapusBtn_Click(sender As System.Object, e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete from tblSatuan Where No = '" & KdSatuanTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub DGSatuan_DoubleClick(sender As Object, e As System.EventArgs) Handles DGSatuan.DoubleClick
        KdSatuanTxt.Text = DGSatuan.SelectedCells(0).Value
        SatuanTxt.Text = DGSatuan.SelectedCells(1).Value

        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        SimpanBtn.Enabled = False
    End Sub
End Class
