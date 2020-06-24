Public Class FrmHistoryPenjualan

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHistory As DataTable

    Private Sub FrmHistoryPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        KeluarBtn.Enabled = True
    End Sub

    Private Sub KeluarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarBtn.Click
        Me.Close()
    End Sub

    Private Sub RbFaktur_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbFaktur.CheckedChanged
        CariData.Focus()
    End Sub

    Private Sub RbKdBarang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbKdBarang.CheckedChanged
        CariData.Focus()
    End Sub

    Sub Data_Record()
        tblHistory = Proses.ExecuteQuery("Select * from Vw_HistoryPenjualan")
        DGHistory.DataSource = tblHistory
        DGHistory.Columns(0).Width = 130
        DGHistory.Columns(1).Width = 125
        DGHistory.Columns(2).Width = 125
        DGHistory.Columns(3).Width = 125
        'DGHistory.Columns(4).Width = 125
        DGHistory.Columns(5).Width = 125
        'DGHistory.Columns(6).Width = 125
        DGHistory.Columns(7).Width = 125
    End Sub

    Private Sub CariData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariData.TextChanged

        If RbFaktur.Checked = True Then
            tblHistory = Proses.ExecuteQuery("Select * From Vw_HistoryPenjualan where Faktur_Penjualan Like '%" & CariData.Text & "%'")
            If tblHistory.Rows.Count = 0 Then
                DGHistory.DataSource = tblHistory
                CariData.Focus()
            Else
                DGHistory.DataSource = tblHistory
            End If

        ElseIf RbKdBarang.Checked = True Then
            tblHistory = Proses.ExecuteQuery("Select * From Vw_HistoryPenjualan where Kode_Pelanggan Like '%" & CariData.Text & "%'")
            If tblHistory.Rows.Count = 0 Then
                DGHistory.DataSource = tblHistory
                CariData.Focus()
            Else
                DGHistory.DataSource = tblHistory
            End If
        End If

    End Sub
End Class
