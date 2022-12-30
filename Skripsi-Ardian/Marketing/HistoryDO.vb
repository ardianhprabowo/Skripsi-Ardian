Public Class HistoryDO

    Dim pbrs As Integer

    Private Sub FrmHistoryPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListHeaderdo()
        TampilDO()
        HeaderDetail()
    End Sub

    Private Sub ListHeaderdo()
        ListDO.FullRowSelect = True
        ListDO.MultiSelect = True
        ListDO.View = View.Details
        ListDO.CheckBoxes = True
        ListDO.Columns.Clear()
        ListDO.Items.Clear()
        ListDO.Columns.Add("NO.ORDER", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("DIVISI", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("TANGGAL", 75, HorizontalAlignment.Left)
        ListDO.Columns.Add("KLIEN", 150, HorizontalAlignment.Left)
        ListDO.Columns.Add("BRAND", 130, HorizontalAlignment.Left)
        ListDO.Columns.Add("NAMA PROYEK", 350, HorizontalAlignment.Left)
        ListDO.Columns.Add("SURVEI", 80, HorizontalAlignment.Left)
        ListDO.Columns.Add("DEADLINE", 150, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddtorder", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddivisi", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddklien", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idbrand", 0, HorizontalAlignment.Left)

    End Sub

    Private Sub TampilDO()

        Dim s, nmproyek As String
        Dim i As Integer
        Dim tbl As New DataTable

        ListDO.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " select y.* from ("
        s = s & " select  a.*,b.klien as nmklien,c.brand,f.divisi as divisi "
        s = s & " from prd_dataorder a, klien b, brand c,  divisi f  "
        s = s & " where a.idklien = b.idklien"
        s = s & " and a.idbrand = c.idbrand "
        s = s & " and a.iddivisi = f.iddivisi "
        's = s & " and a.idstatus_proyek in ('1')"
        ''If TIdDivisi.Text <> "" Then
        's = s & " and a.iddivisi='" & TIdDivisi.Text & "' "
        'End If
        s = s & "  ) y "
        s = s & " order by y.tglorder DESC "
        's = s & " left join trans_do_survei x on y.iddtorder = x.iddtorder "
        's = s & " where x.idtrans is null "
        da = New Odbc.OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListDO
                .Items.Add(tbl.Rows(i)("noorder"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("divisi"))
                    .Add(tbl.Rows(i)("tglorder"))
                    .Add(tbl.Rows(i)("nmklien"))
                    .Add(tbl.Rows(i)("brand"))
                    nmproyek = replaceNewLine(tbl.Rows(i)("namaorder"), False)
                    .Add(nmproyek)
                    .Add(tbl.Rows(i)("survei"))
                    .Add(tbl.Rows(i)("deadline_ki"))
                    .Add(tbl.Rows(i)("iddtorder"))
                    .Add(tbl.Rows(i)("iddivisi"))
                    .Add(tbl.Rows(i)("idklien"))
                    .Add(tbl.Rows(i)("idbrand"))
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub

    Private Sub ListDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDO.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        With Me.ListDO

            For Each item As ListViewItem In ListDO.SelectedItems
                pbrs = item.Index
            Next

        End With
        TampilDetail()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub HeaderDetail()
        ListDetail.FullRowSelect = True
        ListDetail.MultiSelect = True
        ListDetail.View = View.Details
        ' ListDetail.CheckBoxes = True
        ListDetail.Columns.Clear()
        ListDetail.Items.Clear()
        ListDetail.Columns.Add("STATUS PENAWARAN", 450, HorizontalAlignment.Left)
        ListDetail.Columns.Add("TANGGAL", 150, HorizontalAlignment.Left)
        ListDetail.Columns.Add("USERID", 100, HorizontalAlignment.Left)
        ListDetail.Columns.Add("ALASAN", 300, HorizontalAlignment.Left)
    End Sub

    Private Sub TampilDetail()
        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable

        ListDetail.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " select a.idstatusproyek,b.status_proyek,a.waktu,a.userid,"
        s = s & " if (a.alasan is null,'',a.alasan) as alasan"
        s = s & " from prd_history_dataorder a, status_proyek b"
        s = s & " where a.idstatusproyek = b.idstatus_proyek"
        s = s & " and a.iddtorder = '" & ListDO.Items(pbrs).SubItems(8).Text & "'"
        s = s & " order by a.idhistory desc"
        da = New Odbc.OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            If tbl.Rows.Count = 0 Then
                Exit Sub
            End If
            For i = 0 To tbl.Rows.Count - 1
                With ListDetail
                    .Items.Add(tbl.Rows(i)("status_proyek"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(tbl.Rows(i)("waktu"))
                        .Add(tbl.Rows(i)("userid"))
                        .Add(tbl.Rows(i)("alasan"))
                    End With
                End With
            Next
        End If
        GGVM_conn_close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TampilDO()
    End Sub
End Class
