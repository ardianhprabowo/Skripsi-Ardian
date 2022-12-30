Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class KirimPOInt

    Dim Kirim As New EntryKirimPO
    Dim brske, brsdo, brsP As Integer
#Region "ListView"
    Private Sub ListHeaderdo()
        ListDO.FullRowSelect = True
        ListDO.MultiSelect = True
        ListDO.View = View.Details
        ListDO.CheckBoxes = True
        ListDO.Columns.Clear()
        ListDO.Items.Clear()
        ListDO.Columns.Add("NO.ORDER", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("DIVISI", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("TANGGAL", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("KLIEN", 170, HorizontalAlignment.Left)
        ListDO.Columns.Add("BRAND", 130, HorizontalAlignment.Left)
        ListDO.Columns.Add("NAMA PROYEK", 350, HorizontalAlignment.Left)
        ListDO.Columns.Add("SURVEI", 80, HorizontalAlignment.Left)
        ListDO.Columns.Add("DEADLINE", 150, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddtorder", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddivisi", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddklien", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idbrand", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idpe", 0, HorizontalAlignment.Left)
    End Sub
    Private Sub tampilDo()
        Dim s, nmproyek As String
        Dim i As Integer
        Dim tbl As New DataTable

        ListDO.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " select y.* from ("
        s = s & " select  a.*,b.klien as nmklien,c.brand, g.idpe,"
        s = s & " f.divisi as divisi from prd_dataorder a, klien b, brand c, proyek g,"
        s = s & " divisi f "
        s = s & " where a.idklien = b.idklien"
        s = s & " and a.idbrand = c.idbrand "
        s = s & " and a.iddivisi = f.iddivisi "
        s = s & " and a.iddtorder = g.iddtorder "
        s = s & " and a.idstatus_proyek in ('15')"
        s = s & " and a.time_closing is null ) y "
        da = New OdbcDataAdapter(s, conn)
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
                    .Add(tbl.Rows(i)("idpe"))
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub
    Private Sub ListHeadPrd()
        ListPOPrd.FullRowSelect = True
        ListPOPrd.MultiSelect = True
        ListPOPrd.View = View.Details
        ListPOPrd.CheckBoxes = True
        ListPOPrd.Columns.Clear()
        ListPOPrd.Items.Clear()
        ListPOPrd.Columns.Add("NO.PO", 120, HorizontalAlignment.Left)
        ListPOPrd.Columns.Add("TANGGAL", 100, HorizontalAlignment.Left)
        ListPOPrd.Columns.Add("KLIEN", 200, HorizontalAlignment.Left)
        ListPOPrd.Columns.Add("BRAND", 250, HorizontalAlignment.Left)
        ListPOPrd.Columns.Add("NOPE", 200, HorizontalAlignment.Left)
        ListPOPrd.Columns.Add("idpo", 0, HorizontalAlignment.Left)
        ListPOPrd.Columns.Add("STATUS KIRIM", 120, HorizontalAlignment.Left)
    End Sub
    Private Sub TampilPOProduksi()

        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable

        ListPOPrd.Items.Clear()
        ListPODsn.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " select * from view_poproduksi"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListPOPrd
                .Items.Add(tbl.Rows(i)("nopo"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("tanggal_po"))
                    .Add(tbl.Rows(i)("klien"))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("brand")), "", tbl.Rows(i)("brand")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("nope")), "", tbl.Rows(i)("nope")))
                    .Add(tbl.Rows(i)("idpo_prd"))
                    .Add(tbl.Rows(i)("status_kirimpo"))
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub

    Private Sub ListHeadDetail()
        ListPODsn.FullRowSelect = True
        ListPODsn.MultiSelect = True
        ListPODsn.View = View.Details
        'ListPODsn.CheckBoxes = True
        ListPODsn.Columns.Clear()
        ListPODsn.Items.Clear()
        ListPODsn.Columns.Add("TOKO", 200, HorizontalAlignment.Left)
        ListPODsn.Columns.Add("BARANG", 200, HorizontalAlignment.Left)
        ListPODsn.Columns.Add("PANJANG", 80, HorizontalAlignment.Right)
        ListPODsn.Columns.Add("LEBAR", 80, HorizontalAlignment.Right)
        ListPODsn.Columns.Add("TINGGI", 80, HorizontalAlignment.Right)
        ListPODsn.Columns.Add("SISI", 80, HorizontalAlignment.Right)
        ListPODsn.Columns.Add("JUMLAH", 80, HorizontalAlignment.Right)
    End Sub
    Private Sub TampilPODeTAIL()

        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable

        ListPODsn.Items.Clear()
        GGVM_conn()
        s = ""
        s = "select * from view_detailpo_kirim where idpo_prd ='" & TidPO.Text & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListPODsn
                .Items.Add(tbl.Rows(i)("toko"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("barang"))
                    '.Add(tbl.Rows(i)("brand"))
                    .Add(tbl.Rows(i)("panjang_prd"))
                    .Add(tbl.Rows(i)("lebar_prd"))
                    .Add(tbl.Rows(i)("tinggi_prd"))
                    .Add(tbl.Rows(i)("sisi_prd"))
                    .Add(tbl.Rows(i)("qty_prd"))
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub
#End Region

    Private Sub KirimPOInt_Load(sender As Object, e As EventArgs) Handles Me.Load
        DTTanggal.Format = DateTimePickerFormat.Custom
        DTTanggal.CustomFormat = "dd/MM/yyyy"
        ListHeaderdo()
        ListHeadPrd()
        ListHeadDetail()
        RbAda.Checked = True
        tampilDo()
        TampilPOProduksi()
    End Sub

    Private Sub BtnExit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExit.ItemClick
        Me.Dispose()
    End Sub

    Private Sub BtnProsesPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnProsesPO.ItemClick
        Dim ada As Boolean
        Dim count As Integer
        Dim c, s, nourut As String
        Dim tbl, tblid_prd, tblid_dsn, tblC, tbidtrans As DataTable
        Dim brs, jmldt As Integer
        Dim cmd As New OdbcCommand
        Dim thn, nopoprd, nopodsn As String
        Dim i As Integer

        Me.Cursor = Cursors.WaitCursor
        ada = False
        For i = 0 To ListDO.Items.Count - 1
            If ListDO.Items(i).Checked = True Then
                ada = True
                brs = i
                jmldt = jmldt + 1
            End If
        Next
        If ada = False Then
            Me.Cursor = Cursors.Default
            MsgBox(" Tidak ada DATA ORDER  yg akan dibuat PO !!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If jmldt > 1 Then
            MsgBox("Hanya 1(satu) DATA ORDER yang bisa dibuat PO !!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        GGVM_conn()
        For f As Integer = 0 To ListDO.Items.Count - 1
            If ListDO.Items(f).Checked = True Then
                c = ""
                c = c & " update prd_dataorder set"
                c = c & " idstatus_proyek ='16'"
                c = c & " where iddtorder = '" & ListDO.Items(f).SubItems(8).Text & "'"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                c = ""
                c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid) values "
                c = c & " ('" & ListDO.Items(f).SubItems(8).Text & "','16',now(),'" & userid & "')"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
            End If
        Next
        thn = Year(Now)
        'thn = Microsoft.VisualBasic.Right(DTTanggal.Text, 4)
        s = ""
        s = s & " select nopoint,thnpoint from counter"
        da = New OdbcDataAdapter(s, conn)
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        If thn = tbl.Rows(0)("thnpoint") Then
            count = tbl.Rows(0)("nopoint")
        Else
            count = 0
        End If
        count = count + 1
        nourut = Microsoft.VisualBasic.Right("00000" & count, 5)

        nopoprd = "PRD-" + nourut
        nopodsn = "DESAIN-" + nourut

        c = ""
        If count = 1 Then
            c = c & " update counter set nopoint = '" & count & "',"
            c = c & " thnpoint= '" & thn & "'"
        Else
            c = c & " update counter set nopoint = '" & count & "'"
        End If
        cmd = New OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()

        Dim tblB As DataTable
        s = ""
        s = s & " select b.brand,c.noorder from proyek a, brand b, prd_dataorder c "
        s = s & " where a.iddtorder ='" & ListDO.Items(brsdo).SubItems(8).Text & "'"
        s = s & " and a.idbrand = b.idbrand "
        s = s & " and a.iddtorder = c.iddtorder "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tblB = New DataTable
        tblB.Clear()
        da.Fill(tblB)

        'INPUT PO-PRODUKSI DAN PO-DESAIN
        c = ""
        c = c & " insert into po_produksi (nopo,brand,nope,"
        c = c & " tanggal_po) values "
        c = c & " ('" & nopoprd & "', '" & tblB.Rows(0)("brand") & "', '" & tblB.Rows(0)("noorder") & "', "
        c = c & "'" & Format(DTTanggal.Value, "yyyy/MM/dd") & "') "
        cmd = New OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()

        c = ""
        c = c & " insert into po_desain (nopo_dsn,brand,nope,tanggalpo_dsn) values"
        c = c & " ('" & nopodsn & "', '" & tblB.Rows(0)("brand") & "', '" & tblB.Rows(0)("noorder") & "','" & Format(DTTanggal.Value, "yyyy/MM/dd") & "')"
        cmd = New OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()

        'Ambil id max produksi dan desain
        s = ""
        s = s & " select max(idpo_prd)as idprd from po_produksi"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tblid_prd = New DataTable
        tblid_prd.Clear()
        da.Fill(tblid_prd)

        s = ""
        s = s & " select max(idpo_dsn)as iddsn from po_desain"
        da = New OdbcDataAdapter(s, conn)
        tblid_dsn = New DataTable
        tblid_dsn.Clear()
        da.Fill(tblid_dsn)

        s = ""
        s = s & " Select a.idtrans from prd_trans_detaildo_kirim a, prd_kirim_dataorder b,prd_toko c"
        s = s & " where a.iddtorder = b.iddtorder"
        s = s & " and a.idkirim = b.idkirim"
        s = s & " and b.idtoko = c.idtoko"
        s = s & " and a.iddtorder='" & ListDO.Items(brsdo).SubItems(8).Text & "'   "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbidtrans = New DataTable
        tbidtrans.Clear()
        da.Fill(tbidtrans)
        Dim row As DataRow
        For Each row In tbidtrans.Rows
            Dim strDetail As String
            strDetail = row("idtrans")
            'INPUT DETAIL_PO_PRD DAN DSN
            c = ""
            c = c & " insert into prd_detail_po_produksi (idtrans,idpo_prd) values ( "
            c = c & " '" & strDetail & "', '" & tblid_prd.Rows(0)("idprd") & "' ) "
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()


            c = ""
            c = c & " insert into prd_detail_po_desain (idtrans,idpo_dsn) values ( "
            c = c & " '" & strDetail & "', '" & tblid_dsn.Rows(0)("iddsn") & "' )  "
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
        Next row

        For i = 0 To tbidtrans.Rows.Count - 1

        Next

        s = ""
        s = s & " select count(*)as ada from prd_trans_do_poproduksi "
        s = s & " where iddtorder='" & ListDO.Items(brsdo).SubItems(8).Text & "'"
        s = s & " and idpo_prd ='" & tblid_prd.Rows(0)("idprd") & "'"
        s = s & " and idpo_dsn='" & tblid_dsn.Rows(0)("iddsn") & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tblC = New DataTable
        tblC.Clear()
        da.Fill(tblC)

        If tblC.Rows(0)("ada") = 0 Then
            c = ""
            c = c & " insert into prd_trans_do_poproduksi (iddtorder,idpo_prd,idpo_dsn) values"
            c = c & "('" & ListDO.Items(brsdo).SubItems(8).Text & "','" & tblid_prd.Rows(0)("idprd") & "','" & tblid_dsn.Rows(0)("iddsn") & "')"
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
        End If

        GGVM_conn_close()
        MsgBox("PROSES PEMBUATAN PO.PRODUKSI DAN PO.DESAIN SUDAH SELESAI!!.", MsgBoxStyle.Information, "Information")
        Call tampilDo()
        Call TampilPOProduksi()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ListDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDO.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        With Me.ListDO
            For Each check As ListViewItem In ListDO.CheckedItems
                check.Checked = False
            Next
            For Each item As ListViewItem In ListDO.SelectedItems
                item.Checked = True
                brsdo = item.Index
            Next
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ListPOPrd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPOPrd.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        With Me.ListPOPrd
            For Each check As ListViewItem In ListPOPrd.CheckedItems
                check.Checked = False
            Next
            For Each item As ListViewItem In ListPOPrd.SelectedItems
                item.Checked = True
                brske = item.Index
            Next
            TidPO.Text = ListPOPrd.Items(brske).SubItems(5).Text

        End With

        TampilPODeTAIL()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnKirimPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnKirimPO.ItemClick
        Dim s As String
        Dim tbl As DataTable
        Dim adaP As Boolean
        Dim jmlP As Integer


        adaP = False
        jmlP = 0
        For i = 0 To ListPOPrd.Items.Count - 1
            If ListPOPrd.Items(i).Checked = True Then
                adaP = True
                jmlP = jmlP + 1
            End If
        Next
        If adaP = False Then
            MsgBox("Tidak ada Data PO.PRODUKSI yang di-Kirim..!!!", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        Proses = "Kirim PO"
        GGVM_conn()

        s = ""
        s = s & " select if (lokasi is null,'', lokasi)as lks from po_produksi"
        s = s & " where idpo_prd='" & ListPOPrd.Items(brske).SubItems(5).Text & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        If tbl.Rows(0)("lks") = "" Then
            Panel1.Visible = True
            Kirim.TNoPO.Text = ListPOPrd.Items(brske).SubItems(0).Text
            Kirim.TKlien.Text = ListPOPrd.Items(brske).SubItems(2).Text
            Kirim.TBrand.Text = ListPOPrd.Items(brske).SubItems(3).Text
            Kirim.TNoDO.Text = ListPOPrd.Items(brske).SubItems(4).Text
            Kirim.TidPOProd.Text = ListPOPrd.Items(brske).SubItems(5).Text

            s = ""
            s = s & "select b.deadline_ki"
            s = s & " from prd_trans_do_poproduksi a, prd_dataorder b"
            s = s & " where a.iddtorder = b.iddtorder"
            s = s & " and idpo_prd='" & Kirim.TidPOProd.Text & "'"
            da = New OdbcDataAdapter(s, conn)
            'ds.Clear()
            tbl = New DataTable
            tbl.Clear()
            da.Fill(tbl)

            For i = 0 To tbl.Rows.Count - 1
                Kirim.DTDeadline.Text = tbl.Rows(i)("deadline_ki")
            Next
            ' Panel1.Visible = True
            PanelEditPO.Controls.Add(Kirim)
            PanelEditPO.Visible = True
            Kirim.Dock = DockStyle.Top
        Else
            MsgBox("Data sudah di-KIRIM !!...", MsgBoxStyle.Information, "Information")
        End If
        GGVM_conn_close()
        ListDO.Refresh()
        Call tampilDo()
        Call TampilPOProduksi()
    End Sub
    Private Sub clearEditPO()
        Kirim.TLokasiPasang.Text = ""
        Kirim.TNoPO.Text = ""
        Kirim.TidPOProd.Text = ""
        Kirim.TKota.Text = ""
        Kirim.TBrand.Text = ""
        Kirim.TKlien.Text = ""
    End Sub
    Private Sub BtnKeluarPO_Click(sender As Object, e As EventArgs) Handles BtnKeluarPO.Click
        'PanelAlasan.Visible = False
        Panel1.Visible = False
        PanelEditPO.Controls.Clear()
        Panel1.Visible = False
        clearEditPO()
    End Sub

    Private Sub BtnSimpanPO_Click(sender As Object, e As EventArgs) Handles BtnSimpanPO.Click
        GGVM_conn()
        Dim tgl As Date
        Dim tblC, tbl As DataTable
        Dim s, c As String

        Select Case Proses
            Case "Kirim PO"
                If Kirim.TLokasiPasang.Text = "" Then
                    MsgBox("Masukkan Lokasi PO..!!!", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
                If Kirim.TKota.Text = "" Then
                    MsgBox("Masukkan Region/Daerah PO..!!!", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
                tgl = Kirim.DTDeadline.Text
                For i = 0 To ListPOPrd.Items.Count - 1
                    c = ""
                    c = c & " update po_produksi set"
                    c = c & " kirim_po = now()"
                    c = c & " where idpo_prd ='" & ListPOPrd.Items(brske).SubItems(5).Text & "'"
                    cmd = New OdbcCommand(c, conn)
                    cmd.ExecuteNonQuery()

                    s = ""
                    s = s & " select iddtorder,idpo_dsn from prd_trans_do_poproduksi"
                    s = s & " where idpo_prd ='" & ListPOPrd.Items(brske).SubItems(5).Text & "'"
                    da = New OdbcDataAdapter(s, conn)
                    'ds.Clear()
                    tbl = New DataTable
                    tbl.Clear()
                    da.Fill(tbl)
                    Kirim.TidDo.Text = tbl.Rows(0)("iddtorder")
                    Kirim.TidPODsn.Text = tbl.Rows(0)("idpo_dsn")
                    For j = 0 To tbl.Rows.Count - 1

                        s = ""
                        s = s & " select count(*)as ada from prd_history_dataorder "
                        s = s & " where iddtorder = '" & tbl.Rows(j)("iddtorder") & "'"
                        s = s & " and idstatusproyek ='17'"
                        da = New OdbcDataAdapter(s, conn)
                        ' ds.Clear()
                        tblC = New DataTable
                        tblC.Clear()
                        da.Fill(tblC)

                        If tblC.Rows(0)("ada") = "0" Then

                            c = ""
                            c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid,idpo_prd) values "
                            c = c & " ('" & tbl.Rows(0)("iddtorder") & "','17',now(),'" & userid & "','" & ListPOPrd.Items(i).SubItems(5).Text & "')"
                            cmd = New OdbcCommand(c, conn)
                            cmd.ExecuteNonQuery()

                            c = ""
                            c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid,idpo_prd) values "
                            c = c & " ('" & tbl.Rows(0)("iddtorder") & "','18',now(),'" & userid & "','" & ListPOPrd.Items(i).SubItems(5).Text & "')"
                            cmd = New OdbcCommand(c, conn)
                            cmd.ExecuteNonQuery()

                            c = ""
                            c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid,idpo_prd) values "
                            c = c & " ('" & tbl.Rows(0)("iddtorder") & "','19',now(),'" & userid & "','" & ListPOPrd.Items(i).SubItems(5).Text & "')"
                            cmd = New OdbcCommand(c, conn)
                            cmd.ExecuteNonQuery()

                            sql = ""
                            sql = sql & " update prd_dataorder set "
                            sql = sql & " idstatus_proyek='18' "
                            sql = sql & " where iddtorder ='" & tbl.Rows(0)("iddtorder") & "'"
                            cmd = New OdbcCommand(sql, conn)
                            cmd.ExecuteNonQuery()

                            c = ""
                            c = c & " update po_poduksi set"
                            c = c & " lokasi ='" & Kirim.TLokasiPasang.Text & "',"
                            c = c & " region ='" & Kirim.TKota.Text & "',"
                            c = c & " deadline_produksi ='" & Format(Kirim.DTDeadlinePrd.Value, "yyyy-MM-dd") & "', "
                            c = c & " deadline_desain ='" & Format(Kirim.DTDeadlineDsn.Value, "yyyy-MM-dd") & "', "
                            c = c & " deadline_printing ='" & Format(Kirim.DTDeadlinePrt.Value, "yyyy-MM-dd") & "'"
                            c = c & " where idpo_prd ='" & Kirim.TidPOProd.Text & "'"
                            cmd = New OdbcCommand(c, conn)
                        End If
                    Next
                Next
                c = ""
                c = c & " update po_produksi set"
                c = c & " lokasi ='" & Kirim.TLokasiPasang.Text & "',"
                c = c & " region ='" & Kirim.TKota.Text & "',"
                c = c & " deadline_produksi ='" & Format(Kirim.DTDeadlinePrd.Value, "yyyy-MM-dd") & "', "
                c = c & " deadline_desain ='" & Format(Kirim.DTDeadlineDsn.Value, "yyyy-MM-dd") & "', "
                c = c & " deadline_printing ='" & Format(Kirim.DTDeadlinePrt.Value, "yyyy-MM-dd") & "'"
                c = c & " where idpo_prd ='" & Kirim.TidPOProd.Text & "'"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                sql = ""
                sql = sql & " update prd_dataorder set "
                sql = sql & " idstatus_proyek='18' "
                sql = sql & " where iddtorder ='" & Kirim.TidDo.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()

                sql = ""
                sql = sql & " update po_desain set"
                sql = sql & " proses_po_dsn = now() "
                sql = sql & " where idpo_dsn ='" & Kirim.TidPODsn.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()

                GGVM_conn_close()
                MsgBox("Data sudah di-KIRIM !!...", MsgBoxStyle.Information, "Information")
                Kirim.TNoPO.Text = ""
                Kirim.TidPOProd.Text = ""
                clearEditPO()
                TampilPOProduksi()
                Panel1.Visible = False
            Case "Revisi PO"
                If MsgBox("Apakah data ingin di Revisi??", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Pemberitahuan !!") = MsgBoxResult.Yes Then
                    Try
                        'PanelAlasan.Visible = False
                        MsgBox("Masukkan Alasan Revisi.", MsgBoxStyle.Exclamation)
                        PanelAlasan.Visible = True
                        TAlasan.Focus()
                    Catch ex As Exception
                        MsgBox("Data Gagal", MsgBoxStyle.Critical, "Message !!")
                        GGVM_conn_close()
                        Exit Sub
                    End Try
                End If
        End Select
    End Sub

    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEdit.ItemClick

    End Sub

    Private Sub BtnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRefresh.ItemClick
        Call tampilDo()
        Call TampilPOProduksi()
    End Sub

    Private Sub BtnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnPrint.ItemClick
        Dim ada As Boolean
        Dim brs, jmldt As Integer
        'Dim s, c As String
        'Dim tbl As DataTable

        ada = False
        jmldt = 0
        For i = 0 To ListPOPrd.Items.Count - 1
            If ListPOPrd.Items(i).Checked = True Then
                ada = True
                brs = i
                jmldt = jmldt + 1
            End If
        Next

        If ada = False Then
            MsgBox("Tidak ada data PO-INTERNAL yg dicetak, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If jmldt > 1 Then
            MsgBox("Hanya 1(satu) data PO-INTERNAL yang bisa Cetak !!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor


        Dim report As New XtraReport
        report = New ReportPOInternalP2P()
        ' Obtain a parameter and set its value.
        report.Parameters("idpo_prd").Value = ListPOPrd.Items(brs).SubItems(5).Text

        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        'report.Parameters("idpe").Visible = False

        Me.Cursor = Cursors.Default
        report.ShowPreview()
    End Sub
End Class
