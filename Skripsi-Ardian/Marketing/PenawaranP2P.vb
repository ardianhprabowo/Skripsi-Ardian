Imports System.Data.Odbc
Imports DevExpress.XtraReports.UI

Public Class PenawaranP2P
    Dim pbrs, brsdtl As Integer
    Dim brs As Integer
    Dim tbl As New DataTable
    Dim s As String
    'Dim urutpe As String
    'Dim dataOrder As New DataManager
    Dim subttl, ppn, grand As Decimal
    Private Sub FrmPenawaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTTanggal.Format = DateTimePickerFormat.Custom
        DTTanggal.CustomFormat = "dd/MM/yyyy"

        ListHeaderdo()
        ListHeaderPE()
        ListHeaderDETAIL()
        TampilDO()
        TampilPE()
    End Sub
    Private Sub TampilDetailDo()
        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable

        Me.Cursor = Cursors.WaitCursor
        ListDetailDO.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " select * from view_detaildo where idpe='" & TIdPE.Text & "' "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListDetailDO
                .Items.Add(tbl.Rows(i)("barang"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(FormatNumber(tbl.Rows(i)("harga_barang"), 0, , , TriState.True))
                    .Add(tbl.Rows(i)("panjang_pe"))
                    .Add(tbl.Rows(i)("tinggi_pe"))
                    .Add(tbl.Rows(i)("lebar_pe"))
                    .Add(tbl.Rows(i)("size_pe"))
                    .Add(tbl.Rows(i)("sisi_pe"))
                    .Add(tbl.Rows(i)("measure_pe"))
                    .Add(tbl.Rows(i)("qty_pe"))
                    .Add(FormatNumber(tbl.Rows(i)("harga_PE"), 0, , , TriState.True))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("material")), "", tbl.Rows(i)("material")))
                    .Add(tbl.Rows(i)("keterangan"))
                    .Add(tbl.Rows(i)("qty_TOKO"))
                    '.Add(tbl.Rows(i)("idbarang"))
                    '.Add(IIf(IsDBNull(tbl.Rows(i)("idmaterial")), "", tbl.Rows(i)("idmaterial")))
                    .Add(tbl.Rows(i)("iddetailpe"))
                    '.Add(tbl.Rows(i)("SATUAN"))
                End With
            End With
        Next
        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ListHeaderDETAIL()
        ListDetailDO.FullRowSelect = True
        ListDetailDO.MultiSelect = True
        ListDetailDO.View = View.Details
        'ListDetailDO.CheckBoxes = True
        ListDetailDO.Columns.Clear()
        ListDetailDO.Items.Clear()
        ListDetailDO.Columns.Add("BARANG", 200, HorizontalAlignment.Left)
        'ListDetailDO.Columns.Add("LINE", 80, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("HARGA", 75, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("PANJANG", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("TINGGI", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("LEBAR", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("P x T", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("SISI", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("MEASURE", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("QTY", 80, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("TOTAL", 130, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("MATERIAL", 100, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("KETERANGAN", 200, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("QTY-TK", 80, HorizontalAlignment.Right)
        'ListDetailDO.Columns.Add("idbarang", 10, HorizontalAlignment.Left)
        'ListDetailDO.Columns.Add("idmaterial", 10, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("iddetaildo", 0, HorizontalAlignment.Left)
        ' ListDetailDO.Columns.Add("NOKONTRAK", 100, HorizontalAlignment.Left)
        'ListDetailDO.Columns.Add("UNIT", 70, HorizontalAlignment.Left)

    End Sub
    Private Sub ListHeaderdo()
        ListDO.FullRowSelect = True
        ListDO.MultiSelect = True
        ListDO.View = View.Details
        ListDO.CheckBoxes = True
        ListDO.Columns.Clear()
        ListDO.Items.Clear()
        ListDO.Columns.Add("NO.ORDER", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("DIVISI", 150, HorizontalAlignment.Left)
        ListDO.Columns.Add("TANGGAL", 75, HorizontalAlignment.Left)
        ListDO.Columns.Add("KLIEN", 200, HorizontalAlignment.Left)
        ListDO.Columns.Add("BRAND", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("NAMA PROYEK", 350, HorizontalAlignment.Left)
        ListDO.Columns.Add("SURVEI", 80, HorizontalAlignment.Left)
        ListDO.Columns.Add("DEADLINE", 150, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddtorder", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddivisi", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddklien", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idbrand", 0, HorizontalAlignment.Left)

    End Sub

    Private Sub ListHeaderPE()
        ListPE.FullRowSelect = True
        ListPE.MultiSelect = True
        ListPE.View = View.Details
        ListPE.CheckBoxes = True
        ListPE.Columns.Clear()
        ListPE.Items.Clear()
        ListPE.Columns.Add("NO.PE", 100, HorizontalAlignment.Left)
        ListPE.Columns.Add("KLIEN", 200, HorizontalAlignment.Left)
        ListPE.Columns.Add("BRAND", 125, HorizontalAlignment.Left)
        ListPE.Columns.Add("TANGGAL", 100, HorizontalAlignment.Left)
        ListPE.Columns.Add("HAL", 150, HorizontalAlignment.Left)
        ListPE.Columns.Add("NOMINAL", 130, HorizontalAlignment.Right)
        ListPE.Columns.Add("PPN", 130, HorizontalAlignment.Right)
        ListPE.Columns.Add("GRANDTTL", 150, HorizontalAlignment.Right)
        ListPE.Columns.Add("idpe", 1, HorizontalAlignment.Left)
        ListPE.Columns.Add("iddtorder", 1, HorizontalAlignment.Left)
        ListPE.Columns.Add("idklien", 1, HorizontalAlignment.Left)
        ListPE.Columns.Add("idbrand", 1, HorizontalAlignment.Left)
        ListPE.Columns.Add("KETERANGAN", 200, HorizontalAlignment.Left)
        ListPE.Columns.Add("PEMBUAT PE", 100, HorizontalAlignment.Left)
        ListPE.Columns.Add("JABATAN", 100, HorizontalAlignment.Left)
        ListPE.Columns.Add("MENYETUJUI", 100, HorizontalAlignment.Left)
        ListPE.Columns.Add("JABATAN S", 100, HorizontalAlignment.Left)

    End Sub

    Private Sub TampilDO()

        Dim s, nmproyek As String
        Dim i As Integer
        Dim tbl As New DataTable

        Me.Cursor = Cursors.WaitCursor
        ListDO.Items.Clear()
        GGVM_conn()
        s = ""
        s = s & " select * from view_datado where idstatus_proyek = '11'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListDO
                .Items.Add(tbl.Rows(i)("noorder"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("divisi")) '1
                    .Add(tbl.Rows(i)("tglorder")) '2
                    .Add(tbl.Rows(i)("nmklien")) '3
                    .Add(tbl.Rows(i)("brand")) '4
                    nmproyek = Fungsi.replaceNewLine(tbl.Rows(i)("namaorder"), False) '5
                    .Add(nmproyek)
                    .Add(tbl.Rows(i)("survei")) '6
                    .Add(tbl.Rows(i)("deadline_ki")) '7
                    .Add(tbl.Rows(i)("iddtorder")) ' 8
                    .Add(tbl.Rows(i)("iddivisi")) '9
                    .Add(tbl.Rows(i)("idklien")) '10
                    .Add(tbl.Rows(i)("idbrand")) '11
                End With
            End With
        Next
        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub TampilPE()
        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable

        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()
        ListPE.Items.Clear()
        s = " SELECT * FROM view_penawaran "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        'GGVM_conn_close()

        For i = 0 To tbl.Rows.Count - 1
            With ListPE
                .Items.Add(tbl.Rows(i)("nope"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("nmklien"))
                    .Add(tbl.Rows(i)("brand"))
                    .Add(tbl.Rows(i)("tanggal"))
                    .Add(tbl.Rows(i)("hal"))
                    .Add(FormatNumber(tbl.Rows(i)("nominal"), 0, , , TriState.True))
                    .Add(FormatNumber(tbl.Rows(i)("nominal_ppn"), 0, , , TriState.True))
                    .Add(FormatNumber(tbl.Rows(i)("grandtotal"), 0, , , TriState.True))
                    .Add(tbl.Rows(i)("idpe"))
                    .Add(tbl.Rows(i)("iddtorder"))
                    .Add(tbl.Rows(i)("idklien"))
                    .Add(tbl.Rows(i)("idbrand"))
                    .Add(Fungsi.replaceNewLine(tbl.Rows(i)("ket"), False))
                    .Add(tbl.Rows(i)("pembuat"))
                    .Add(tbl.Rows(i)("jabatanp"))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("setujupe")), "", tbl.Rows(i)("setujupe")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("jabatansetujupe")), "", tbl.Rows(i)("jabatansetujupe")))
                End With
            End With
        Next
        Me.Cursor = Cursors.Default
        GGVM_conn_close()
    End Sub
    Private Sub ListPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPE.SelectedIndexChanged
        Dim brs As Integer

        Me.Cursor = Cursors.WaitCursor
        With Me.ListPE
            For Each check As ListViewItem In ListPE.CheckedItems
                check.Checked = False
            Next

            For Each item As ListViewItem In ListPE.SelectedItems
                item.Checked = True
                brs = item.Index
            Next
            BtnAccPE.Enabled = True
        End With
        TIdPE.Text = ListPE.Items(brs).SubItems(8).Text
        TidDO.Text = ListPE.Items(brs).SubItems(9).Text
        TNoPE.Text = ListPE.Items(brs).SubItems(0).Text
        TKlien.Text = ListPE.Items(brs).SubItems(1).Text
        TBrand.Text = ListPE.Items(brs).SubItems(2).Text
        THal.Text = ListPE.Items(brs).SubItems(4).Text
        TTotal.Text = ListPE.Items(brs).SubItems(5).Text
        TPpn.Text = ListPE.Items(brs).SubItems(6).Text
        TGrandTotal.Text = ListPE.Items(brs).SubItems(7).Text
        TKeterangan.Text = ListPE.Items(brs).SubItems(12).Text
        TPembuat.Text = ListPE.Items(brs).SubItems(13).Text
        TJabatanP.Text = ListPE.Items(brs).SubItems(14).Text
        TSetuju.Text = ListPE.Items(brs).SubItems(15).Text
        TJabatanS.Text = ListPE.Items(brs).SubItems(16).Text
        GGVM_conn()
        s = " SELECT if( nope like '%GGVM%','1',nope) as nope1 FROM proyek where idpe = '" & TIdPE.Text & "' "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If tbl.Rows(0)("nope1") = "1" Then
            RbGG.Checked = True
        End If
        TampilDetailDo()
        'GGVM_conn_close()
    End Sub

    Private Sub TPembuat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPembuat.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            TJabatanP.Focus()
        End If
    End Sub
    Private Sub HitungNominal()
        GGVM_conn()
        s = ""
        s = s & " select sum(harga_penawaran)as ttl from prd_detail_penawaran"
        s = s & " where iddtorder ='" & TidDO.Text & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If Not IsDBNull(tbl.Rows(0)("ttl")) Then
            subttl = tbl.Rows(0)("ttl")
        Else
            subttl = 0
        End If
        ppn = subttl * (11 / 100)
        grand = subttl + ppn
    End Sub

    Private Sub BtnProsesPE_Click(sender As Object, e As EventArgs) Handles BtnProsesPE.Click
        'Dim f As New FrmCost
        Dim cmd As New OdbcCommand
        Dim ada As Boolean
        Dim brs, jmldt As Integer
        Dim c, s As String
        Dim tbl As DataTable

        ada = False
        jmldt = 0
        For i = 0 To ListDO.Items.Count - 1
            If ListDO.Items(i).Checked = True Then
                ada = True
                brs = i
                jmldt = jmldt + 1
            End If
        Next

        If ada = False Then
            MsgBox("Tidak ada DATA ORDER yang akan dibuat PENAWARAN, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        If jmldt > 1 Then
            MsgBox("Hanya 1(satu) DATA ORDER yang bisa dibuat PENAWARAN !!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        Dim urutpe As String
        Dim bln As String
        Dim thn As String

        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()

        TidDO.Text = ListDO.Items(brs).SubItems(8).Text

        Dim namaalias As String = ListDO.Items(brs).SubItems(4).Text

        's = ""
        's = s & " select alias from klien where id ='" & ListDO.Items(brs).SubItems(13).Text & "'"
        'da = New Odbc.OdbcDataAdapter(s, conn)
        ''ds.Clear()
        'tbl = New DataTable
        'tbl.Clear()
        'da.Fill(tbl)
        Dim divisiid As String
        Dim pembuat As String = ""
        c = ""
        c = c & " select ttd_maju_lpj from user where username='" & userid & "'"
        da = New OdbcDataAdapter(c, conn)
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        pembuat = tbl.Rows(0)("ttd_maju_lpj")

        divisiid = ListDO.Items(brs).SubItems(9).Text

        divisiid = Microsoft.VisualBasic.Right("0" & divisiid, 2)
        urutpe = Microsoft.VisualBasic.Trim(ListDO.Items(brs).SubItems(0).Text)
        bln = bulan(DTTanggal.Text)
        thn = Microsoft.VisualBasic.Right(DTTanggal.Text, 4)
        If RbGG.Checked = True Then
            urutpe = urutpe + "/GGVM/" + divisiid + "/" + bln + "/" + thn
        End If


        'hitung nominal

        HitungNominal()
        'insert tabel penawaran
        c = ""
        c = c & " insert proyek (iddtorder,nope,tanggal_proyek,"
        c = c & " hal,keterangan_pe,idklien,idbrand,nominal,ppn,nominal_ppn,grandtotal,userinput, time_input_pe,pembuat,jabatanp) values "
        c = c & " ('" & ListDO.Items(brs).SubItems(8).Text & "','" & urutpe & "','" & Format(DTTanggal.Value, "yyyy/MM/dd") & "',"
        c = c & " '" & ListDO.Items(brs).SubItems(5).Text & "','" & TKeterangan.Text & "','" & ListDO.Items(brs).SubItems(10).Text & "','" & ListDO.Items(brs).SubItems(11).Text & "'," & subttl & ",10," & ppn & "," & grand & ","
        c = c & " '" & userid & "', now() , '" & pembuat & "','" & TJabatanP.Text & "' )"
        cmd = New OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()

        s = ""
        s = s & " select max(idpe)as id from proyek "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        c = ""
        c = c & " update prd_detail_penawaran set "
        c = c & " idpe ='" & tbl.Rows(0)("id") & "'"
        c = c & " where iddtorder = '" & ListDO.Items(brs).SubItems(8).Text & "'"
        cmd = New OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()

        c = ""
        c = c & " update prd_dataorder set"
        c = c & " idstatus_proyek ='12'"
        c = c & " where iddtorder = '" & ListDO.Items(brs).SubItems(8).Text & "'"
        cmd = New Odbc.OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()

        c = ""
        c = c & " insert prd_history_dataorder (iddtorder,idpe,idstatusproyek,waktu,userid) values "
        c = c & " ('" & ListDO.Items(brs).SubItems(8).Text & "','" & tbl.Rows(0)("id") & "','12',now(),'" & userid & "')"
        cmd = New Odbc.OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()
        Me.Cursor = Cursors.Default

        MsgBox("Proses Pembuatan PE Selesai !!..", MsgBoxStyle.Information, "Information")
        GGVM_conn_close()
        TampilDO()
        TampilPE()
    End Sub

    Private Sub BtnEditPE_Click(sender As Object, e As EventArgs) Handles BtnEditPE.Click
        'Dim f As New FrmCost
        Dim a As New StatusSurvei
        Dim cmd As New OdbcCommand
        Dim ada As Boolean
        Dim brs, jmldt As Integer
        Dim c, nmKet As String

        If BtnEditPE.Text = "EDIT PE" Then
            ada = False
            jmldt = 0
            For i = 0 To ListPE.Items.Count - 1
                If ListPE.Items(i).Checked = True Then
                    ada = True
                    brs = i
                    jmldt = jmldt + 1
                End If
            Next

            If ada = False Then
                MsgBox("Tidak ada data Detail Penawaran yang akan di Edit/Hapus Item, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If

            If jmldt > 1 Then
                MsgBox("Hanya 1(satu) data Detail Penawaran yg bisa di Edit/Hapus !!...", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If

            BtnProsesPE.Enabled = False
            'BtnEdit.Enabled = False
            BtnCetak.Enabled = False
            BtnKeluar.Text = "BATAL"
            BtnEditPE.Text = "SIMPAN"

            THal.ReadOnly = False
            TKeterangan.ReadOnly = False
            RbGG.Enabled = False
            TPembuat.ReadOnly = False
            TJabatanP.ReadOnly = False
            THal.Focus()

            a.TIDDtOrder.Text = TidDO.Text
            'a.ShowDialog()
        Else
            Me.Cursor = Cursors.WaitCursor
            GGVM_conn()
            nmKet = Fungsi.replaceNewLine(TKeterangan.Text, True)

            HitungNominal()

            c = ""
            c = c & " update proyek set"
            c = c & " hal = '" & THal.Text & "',"
            c = c & " keterangan = '" & nmKet & "',"
            c = c & " pembuat = '" & TPembuat.Text & "',"
            c = c & " jabatanP = '" & TJabatanP.Text & "' ,"
            c = c & "nominal = '" & subttl & "', "
            c = c & "ppn = '11' , "
            c = c & " nominal_ppn ='" & ppn & "',grandtotal ='" & grand & "' , time_update_pe = now(), userupdate='" & userid & "'"
            c = c & " where idpe = '" & TIdPE.Text & "'"
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
            GGVM_conn_close()

            BtnProsesPE.Enabled = True
            BtnEditPE.Enabled = True
            BtnCetak.Enabled = True
            BtnKeluar.Text = "KELUAR"
            BtnEditPE.Text = "EDIT PE"
            THal.ReadOnly = True
            TKeterangan.ReadOnly = True
            TPembuat.ReadOnly = True
            TJabatanP.ReadOnly = True
            TSetuju.ReadOnly = True
            TJabatanS.ReadOnly = True
            RbGG.Enabled = True
            RbGG.Checked = True
            ClearData()
            Me.Cursor = Cursors.Default
            MsgBox("Data PENAWARAN sudah di-Edit !!..", MsgBoxStyle.Information, "Information")
        End If
    End Sub
    Public Sub ClearData()


        TNoPE.Text = ""
        TIdPE.Text = ""
        TKlien.Text = ""
        TBrand.Text = ""
        THal.Text = ""
        TKeterangan.Text = ""
        TTotal.Text = "0"
        TPpn.Text = "0"
        TGrandTotal.Text = "0"
        TPembuat.Text = ""
        TJabatanP.Text = ""
        TSetuju.Text = ""
        TJabatanS.Text = ""
    End Sub
    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        'Dim f As New FrmCetak
        'Dim cmd As New OdbcCommand
        'Dim ada As Boolean
        'Dim brs, jmldt As Integer

        'ada = False
        'jmldt = 0
        'For i = 0 To ListPE.Items.Count - 1
        '    If ListPE.Items(i).Checked = True Then
        '        ada = True
        '        brs = i
        '        jmldt = jmldt + 1
        '    End If
        'Next

        'If ada = False Then
        '    MsgBox("Tidak ada data Penawaran yang akan di Cetak, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
        '    Exit Sub
        'End If

        'If jmldt > 1 Then
        '    MsgBox("Hanya 1(satu) data PENAWARAN yang bisa Cetak !!...", MsgBoxStyle.Information, "Information")
        '    Exit Sub
        'End If
        'Dim report As New XtraReport
        'If RbGG.Checked = True Then
        '    report = New PenawaranGG()
        'ElseIf RbBIG.Checked = True Then
        '    report = New ReportPenawaranP2P()
        'End If

        '' Obtain a parameter and set its value.
        'report.Parameters("idpe").Value = ListPE.Items(brs).SubItems(9).Text

        '' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        ''report.Parameters("idpe").Visible = False
        'report.ShowPreview()
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Me.Dispose()
        Exit Sub
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        TampilDO()
        TampilPE()
    End Sub

    Private Sub ListDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDO.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        With Me.ListDO

            For Each check As ListViewItem In ListDO.CheckedItems
                check.Checked = False
            Next


            For Each item As ListViewItem In ListDO.SelectedItems
                brs = item.Index
                item.Checked = True
            Next

            TidDO.Text = ListDO.Items(brs).SubItems(8).Text
            TBrand.Text = ListDO.Items(brs).SubItems(4).Text
            TKlien.Text = ListDO.Items(brs).SubItems(3).Text
            THal.Text = ListDO.Items(brs).SubItems(5).Text
            TKeterangan.Text = "Guna Melegkapi "
            TGrandTotal.Text = grand
            TPpn.Text = ppn
            TTotal.Text = subttl
            'TJabatanS.Text = ListDO.Items(brs).SubItems(3).Text
        End With
        THal.ReadOnly = False
        TKeterangan.ReadOnly = False
        TSetuju.Enabled = True
        TSetuju.ReadOnly = False
        TJabatanS.Enabled = True
        TJabatanS.ReadOnly = False
        RbGG.Enabled = True
        RbGG.Checked = True
        HitungNominal()
        'ClearData()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnAccPE_Click(sender As Object, e As EventArgs) Handles BtnAccPE.Click
        TSetuju.ReadOnly = False
        TJabatanS.ReadOnly = False
        Dim c, s As String
        If TSetuju.Text = "" AndAlso TJabatanS.Text = "" Then
            MsgBox("Masukkan Nama dan Jabatan Klien !!...", MsgBoxStyle.Information, "Information")
            Exit Sub
        Else
            GGVM_conn()
            s = ""
            s = s & " update proyek set time_update_pe = now(), userupdate='" & userid & "', accklien = '" & TSetuju.Text & "', jabatanklien='" & TJabatanS.Text & "'"
            cmd = New OdbcCommand(s, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " update prd_dataorder set"
            c = c & " idstatus_proyek = '15' "
            c = c & " where iddtorder = '" & TidDO.Text & "'"
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " insert prd_history_dataorder (iddtorder,idpe,idstatusproyek,waktu,userid) values "
            c = c & " ('" & TidDO.Text & "','" & TIdPE.Text & "','15',now(),'" & userid & "')"
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()



            TampilPE()
            MsgBox("Penawaran Sudah di Status Approval !!...", MsgBoxStyle.Information, "Information")
            TSetuju.ReadOnly = True
            TJabatanS.ReadOnly = True
        End If

        GGVM_conn_close()
       
    End Sub
End Class
