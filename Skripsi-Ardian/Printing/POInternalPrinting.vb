Imports System.Data.Odbc

Public Class POInternalPrinting
    Dim brske As Integer
    Dim s, c As String
    Private Sub ListHeadPrt()
        ListPOPrt.FullRowSelect = True
        ListPOPrt.MultiSelect = True
        ListPOPrt.View = View.Details
        ListPOPrt.CheckBoxes = True
        ListPOPrt.Columns.Clear()
        ListPOPrt.Items.Clear()
        ListPOPrt.Columns.Add("TOKO", 150, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("BRAND", 100, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("BARANG", 150, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("DEADLINE", 100, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("iddetaildsn", 0, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("idpoprd", 0, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("idpoprt", 0, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("idpodsn", 0, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("iddtorder", 0, HorizontalAlignment.Left)
        ListPOPrt.Columns.Add("STATUS PEKERJAAN", 150, HorizontalAlignment.Left)
    End Sub
    Private Sub ListHeadDetailPrt()
        ListDetailPrt.FullRowSelect = True
        ListDetailPrt.MultiSelect = True
        ListDetailPrt.View = View.Details
        ListDetailPrt.CheckBoxes = True
        ListDetailPrt.Columns.Clear()
        ListDetailPrt.Items.Clear()
        ListDetailPrt.Columns.Add("ITEM", 180, HorizontalAlignment.Left)
        ListDetailPrt.Columns.Add("P", 60, HorizontalAlignment.Right)
        ListDetailPrt.Columns.Add("L", 60, HorizontalAlignment.Right)
        ListDetailPrt.Columns.Add("T", 60, HorizontalAlignment.Right)
        ListDetailPrt.Columns.Add("JML", 60, HorizontalAlignment.Right)
        ListDetailPrt.Columns.Add("KETERANGAN", 120, HorizontalAlignment.Right)
        ListDetailPrt.Columns.Add("BAHAN", 150, HorizontalAlignment.Right)
        ListDetailPrt.Columns.Add("FINISHING", 150, HorizontalAlignment.Right)
    End Sub
    Private Sub TampilPOPrinting()

        Dim s As String
        Dim dt As New DataTable
        Dim nopo As String
        Dim toko As String
        ListPOPrt.Items.Clear()
        ListDetailPrt.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " SELECT * from view_poprinting "
        s = s & " order by nopo desc"
         cmd = New OdbcCommand(s, conn)
        dr = cmd.ExecuteReader
        ListPOPrt.Items.Clear()
        ListPOPrt.BeginUpdate()
        While dr.Read
            nopo = dr.Item("nopo")
            toko = dr.Item("toko")
            Dim statuspekerjaan As String = ""
            If IIf(IsDBNull(dr.Item("terima_po")).ToString, "", dr.Item("terima_po")).ToString <> "" And IIf(IsDBNull(dr.Item("time_closhing")).ToString, "", dr.Item("time_closhing")).ToString = "" Then
                statuspekerjaan = "Diterima"
            ElseIf IIf(IsDBNull(dr.Item("time_closhing")).ToString, "", dr.Item("time_closhing")).ToString <> "" And IIf(IsDBNull(dr.Item("terima_po")).ToString, "", dr.Item("terima_po")).ToString <> "" Then
                statuspekerjaan = "Selesai"
            Else
                statuspekerjaan = "Belum diTerima"
            End If
            Dim lvitem As New ListViewItem(toko)
            Try
                If ListPOPrt.Groups.Item(nopo).Header = nopo Then
                    lvitem.Group = ListPOPrt.Groups(nopo)
                    'lvitem.SubItems.Add(dr.Item("toko"))
                    lvitem.SubItems.Add(dr.Item("brand"))
                    lvitem.SubItems.Add(dr.Item("barang"))
                    lvitem.SubItems.Add(dr.Item("deadline_printing"))
                    lvitem.SubItems.Add(dr.Item("iddetail_dsn"))
                    lvitem.SubItems.Add(dr.Item("idpo_prd"))
                    lvitem.SubItems.Add(dr.Item("idpo_prt"))
                    lvitem.SubItems.Add(dr.Item("idpo_dsn"))
                    lvitem.SubItems.Add(dr.Item("iddtorder"))
                    lvitem.SubItems.Add(statuspekerjaan)
                    ListPOPrt.Items.Add(lvitem)
                End If
            Catch
                ListPOPrt.Groups.Add(New ListViewGroup(nopo, nopo))
                lvitem.Group = ListPOPrt.Groups(nopo)
                'lvitem.SubItems.Add(dr.Item("toko"))
                lvitem.SubItems.Add(dr.Item("brand"))
                lvitem.SubItems.Add(dr.Item("barang"))
                lvitem.SubItems.Add(dr.Item("deadline_printing"))
                lvitem.SubItems.Add(dr.Item("iddetail_dsn"))
                lvitem.SubItems.Add(dr.Item("idpo_prd"))
                lvitem.SubItems.Add(dr.Item("idpo_prt"))
                lvitem.SubItems.Add(dr.Item("idpo_dsn"))
                lvitem.SubItems.Add(dr.Item("iddtorder"))
                lvitem.SubItems.Add(statuspekerjaan)
                ListPOPrt.Items.Add(lvitem)
            End Try
        End While
        ListPOPrt.EndUpdate()
        GGVM_conn_close()
    End Sub
    Private Sub TampilDetailPrinting()

        Dim s As String
        Dim i As Integer
        Dim dt As New DataTable

        ListDetailPrt.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " SELECT * FROM `view_detailpo_printing` where iddetail_dsn = '" & ListPOPrt.Items(brske).SubItems(4).Text & "' "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            With ListDetailPrt
                .Items.Add(dt.Rows(i)("barang"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(IIf(IsDBNull(dt.Rows(i)("panjang_prt")), "", dt.Rows(i)("panjang_prt")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("tinggi_prt")), "", dt.Rows(i)("tinggi_prt")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("lebar_prt")), "", dt.Rows(i)("lebar_prt")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("qty_prt")), "", dt.Rows(i)("qty_prt")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("keterangan_prt")), "", dt.Rows(i)("keterangan_prt")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("bahan")), "", dt.Rows(i)("bahan")))
                    .Add(IIf(IsDBNull(dt.Rows(i)("finishing")), "", dt.Rows(i)("finishing")))
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub

    Private Sub FrmTerimaPOPrt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListHeadDetailPrt()
        ListHeadPrt()
        TampilPOPrinting()
    End Sub

    Private Sub ListPOPrt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPOPrt.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        With Me.ListPOPrt
            For Each check As ListViewItem In ListPOPrt.CheckedItems
                check.Checked = False
            Next
            For Each item As ListViewItem In ListPOPrt.SelectedItems
                item.Checked = True
                brske = item.Index
            Next
            'TIdBarang1.Text = ListDetailPODsn.Items(brske).SubItems(11).Text
        End With
        TampilDetailPrinting()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnSelesai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPOSelesai.ItemClick
        Dim ada, item As Boolean
        Dim jmldt, brs As Integer
        ada = False
        item = False
        jmldt = 0
        For i = 0 To ListPOPrt.Items.Count - 1
            If ListPOPrt.Items(i).Checked = True Then
                ada = True
                brs = i
                jmldt = jmldt + 1
            End If
        Next
        If ada = False Then
            MsgBox("Tidak ada data yang akan di Entry, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
            ListPOPrt.Focus()
            Exit Sub
        End If
        If jmldt > 1 Then
            MsgBox("Hanya 1(satu) data PO-PRINTING yg bisa di-Entry !!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Try
            GGVM_conn()
            s = ""
            s = s & " SELECT a.*,c.terima_po_prt FROM `prd_detail_po_desain` a "
            s = s & " INNER JOIN prd_detail_po_printing b on b.iddetail_dsn = a.iddetail_dsn "
            s = s & " INNER JOIN po_printing c on c.idpo_prt = b.idpo_prt "
            s = s & " where a.idpo_dsn ='" & ListPOPrt.Items(brske).SubItems(7).Text & "'"
            da = New OdbcDataAdapter(s, conn)
            dt = New DataTable
            dt.clear()
            da.Fill(dt)

            For Each rs As DataRow In dt.Rows
                If IsDBNull(rs("terima_po_prt")) Then ' Null check
                    MsgBox("PO Belum di Proses TERIMA !!..", MsgBoxStyle.Information, "Information")
                    Exit Sub
                ElseIf String.IsNullOrEmpty(rs("terima_po_prt").ToString()) Then ' Empty check
                    MsgBox("PO Belum di Proses TERIMA !!..", MsgBoxStyle.Information, "Information")
                    Exit Sub
                Else
                    s = ""
                    s = s & " update po_produksi set selesai_printing=now() "
                    s = s & " where idpo_prd ='" & ListPOPrt.Items(brske).SubItems(5).Text & "' "
                    cmd = New OdbcCommand(s, conn)
                    cmd.ExecuteNonQuery()

                    c = ""
                    c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid) values "
                    c = c & " ('" & ListPOPrt.Items(brske).SubItems(8).Text & "','24',now(),'" & userid & "')"
                    cmd = New OdbcCommand(c, conn)
                    cmd.ExecuteNonQuery()

                    sql = ""
                    sql = sql & " update po_printing set time_closhing_prt = now(), userclose_prt='" & userid & "' where idpo_prt = '" & ListPOPrt.Items(brske).SubItems(6).Text & "'"
                    cmd = New OdbcCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            ' kurang pengaman untuk inputan printing closing ke po_produksi



            MsgBox("Data PO sudah di-Selesai !!..", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
        GGVM_conn_close()
        TampilPOPrinting()
    End Sub

    Private Sub BtnTerimaPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTerimaPrint.ItemClick
        Dim ada, item As Boolean
        Dim jmldt, brs As Integer
        ada = False
        item = False
        jmldt = 0
        For i = 0 To ListPOPrt.Items.Count - 1
            If ListPOPrt.Items(i).Checked = True Then
                ada = True
                brs = i
                jmldt = jmldt + 1
            End If
        Next
        If ada = False Then
            MsgBox("Tidak ada data yang akan di Entry, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
            ListPOPrt.Focus()
            Exit Sub
        End If
        'If jmldt > 1 Then
        '    MsgBox("Hanya 1(satu) data PO-PRINTING yg bisa di-Entry !!...", MsgBoxStyle.Information, "Information")
        '    Exit Sub
        'End If
        Try
            GGVM_conn()
            s = ""
            s = s & " update po_printing set terima_po_prt =now() , userterima_prt ='" & userid & "' "
            s = s & " where idpo_prt ='" & ListPOPrt.Items(brske).SubItems(6).Text & "' "
            cmd = New OdbcCommand(s, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid) values "
            c = c & " ('" & ListPOPrt.Items(brske).SubItems(8).Text & "','23',now(),'" & userid & "')"
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            MsgBox("Data PO sudah di-Terima !!..", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            MsgBox("Terjadi kesalahan! " & ex.Message)
        End Try
        GGVM_conn_close()
        TampilPOPrinting()
    End Sub

    Private Sub BtnTutup_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnTutup.ItemClick
        Me.Dispose()
    End Sub
End Class
