﻿Imports System.Data.Odbc

Public Class DetailToko
    Dim s As String
    Dim tbl As New DataTable
    Public Sub New()
        InitializeComponent()

        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill the SqlDataSource asynchronously
        AddHandler DataOrder.GetTextBoxText, AddressOf SetLabelText
        'TampilToko()
    End Sub
    Private Sub SetLabelText(ByVal myString As String)
        TIDOrder.Text = myString
        TampilToko()
    End Sub

    Private Sub DetailToko_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        ListHeaderToko()
        ListHeaderBarangPerToko()
        'TampilToko()
        LoadDetailForm()
    End Sub
    Private Sub DetailToko_Load(sender As Object, e As EventArgs) Handles Me.Load
       
    End Sub
#Region "Function"
    Private Sub ClearDetailTK()
        'TNamaTK.Text = ""
        'TKotaTK.Text = ""
        TBarangPrd.Text = ""
        TPPrd.Text = "0"
        TLPrd.Text = "0"
        TTPrd.Text = "0"
        ' TIdKirimTK.Text = ""
        TidTrans.Text = ""
        TidBarangPrd.Text = ""
        TSPrd.Text = "1"
        TKetTK.Text = ""
        TQtyPrd.Text = "1"
        CDeadKirim.Enabled = True
        CDeadKirim.Checked = False
        CSurvei.Enabled = True
        CSurvei.Checked = False
        CRealImple.Enabled = True
        CRealImple.Checked = False
        CRealKirim.Enabled = True
        CRealKirim.Checked = False
        CRealSurvei.Enabled = True
        CRealSurvei.Checked = False
        CRealTerimaBrg.Enabled = True
        CRealTerimaBrg.Checked = False



        BtnInsertDetail.Enabled = True
        BtnUpdateDetailTK.Enabled = True
        BtnSimpanDetailTK.Enabled = False
        BtnHapusBarang.Enabled = False
        BtnCetakFrm.Enabled = False
        ListToko.Enabled = True
    End Sub
    Private Sub ListHeaderToko()
        ListToko.FullRowSelect = True
        ListToko.MultiSelect = True
        ListToko.View = View.Details
        ListToko.CheckBoxes = True
        ListToko.Columns.Clear()
        ListToko.Items.Clear()
        ListToko.Columns.Add("TOKO", 120, HorizontalAlignment.Left)
        ListToko.Columns.Add("KOTA", 150, HorizontalAlignment.Left)
        ListToko.Columns.Add("IDToko", 1, HorizontalAlignment.Left)
        ListToko.Columns.Add("IDKirim", 1, HorizontalAlignment.Left)
        ListToko.Columns.Add("IDDtorder", 1, HorizontalAlignment.Left)
        ListToko.Columns.Add("Survei", 1, HorizontalAlignment.Left)
    End Sub
    Private Sub TampilToko()

        Dim s As String
        Dim i As Integer
        'Dim tbl As New DataTable

        Me.Cursor = Cursors.WaitCursor
        ListToko.Items.Clear()
        GGVM_conn()
        s = ""
        s = " select * from view_toko where iddtorder='" & TIDOrder.Text & "' "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        For i = 0 To tbl.Rows.Count - 1
            With ListToko
                .Items.Add(tbl.Rows(i)("toko"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("kota"))
                    .Add(tbl.Rows(i)("idtoko"))
                    .Add(tbl.Rows(i)("idkirim"))
                    .Add(tbl.Rows(i)("iddtorder"))
                    .Add(tbl.Rows(i)("survei"))
                End With
            End With
        Next
        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ListHeaderBarangPerToko()
        ListBarang.FullRowSelect = True
        ListBarang.MultiSelect = True
        ListBarang.View = View.Details
        ListBarang.CheckBoxes = True
        ListBarang.Columns.Clear()
        ListBarang.Items.Clear()
        ListBarang.Columns.Add("BARANG", 200, HorizontalAlignment.Left)
        ListBarang.Columns.Add("PANJANG", 120, HorizontalAlignment.Left)
        ListBarang.Columns.Add("LEBAR", 150, HorizontalAlignment.Left)
        ListBarang.Columns.Add("TINGGI", 150, HorizontalAlignment.Left)
        ListBarang.Columns.Add("SISI", 200, HorizontalAlignment.Left)
        ListBarang.Columns.Add("QTY", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("KETERANGAN", 100, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Deadline Survei", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Realisasi Survei", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Deadline Implementasi", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Realisasi Implementasi", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Deadline Kirim", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Realisasi Kirim", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("Realisasi Terima Barang", 50, HorizontalAlignment.Left)
        ListBarang.Columns.Add("IDTrans", 1, HorizontalAlignment.Left)
        ListBarang.Columns.Add("IDBarang", 1, HorizontalAlignment.Left)
    End Sub
    Private Sub TampilBarangPerToko()
        GGVM_conn()
        s = ""
        s = s & " select b.barang, c.panjang_prd, c.lebar_prd, c.tinggi_prd,c.sisi_prd,c.qty_prd, c.keterangan, c.deadline_survei,"
        s = s & " c.realisasi_survei, c.deadline_implementasi, c.realisasi_implementasi, c.deadline_kirim, c.realisasi_kirim, c.realisasi_terima_brg, "
        s = s & " c.idtrans, b.idbarang"
        s = s & " from prd_dataorder a,barang_penawaran b , prd_trans_detaildo_kirim c "
        s = s & "  where a.iddtorder = c.iddtorder And "
        s = s & " b.idbarang = c.idbarang_prd and c.idkirim = '" & TIdKirimTK.Text & "' "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        ListBarang.Items.Clear()
        For i = 0 To tbl.Rows.Count - 1
            With ListBarang
                .Items.Add(tbl.Rows(i)("barang"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("panjang_prd"))
                    .Add(tbl.Rows(i)("lebar_prd"))
                    .Add(tbl.Rows(i)("tinggi_prd"))
                    .Add(tbl.Rows(i)("sisi_prd"))
                    .Add(tbl.Rows(i)("qty_prd"))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("keterangan")), "", tbl.Rows(i)("keterangan")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("deadline_survei")), "", tbl.Rows(i)("deadline_survei")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("realisasi_survei")), "", tbl.Rows(i)("realisasi_survei")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("deadline_implementasi")), "", tbl.Rows(i)("deadline_implementasi")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("realisasi_implementasi")), "", tbl.Rows(i)("realisasi_implementasi")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("deadline_kirim")), "", tbl.Rows(i)("deadline_kirim")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("realisasi_kirim")), "", tbl.Rows(i)("realisasi_kirim")))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("realisasi_terima_brg")), "", tbl.Rows(i)("realisasi_terima_brg")))
                    .Add(tbl.Rows(i)("idtrans"))
                    .Add(tbl.Rows(i)("idbarang"))
                End With
            End With
        Next
        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub LoadDetailForm()

        TNamaTK.Text = ""
        TKotaTK.Text = ""
        TBarangPrd.Text = ""
        TPPrd.Text = "0"
        TLPrd.Text = "0"
        TTPrd.Text = "0"
        TIdKirimTK.Text = ""
        TidTrans.Text = ""
        TidBarangPrd.Text = ""
        TSPrd.Text = "1"
        TKetTK.Text = ""
        TQtyPrd.Text = "1"

        TNamaTK.Enabled = False
        TKotaTK.Enabled = False
        TBarangPrd.Enabled = False
        TPPrd.Enabled = False
        TLPrd.Enabled = False
        TTPrd.Enabled = False
        TSPrd.Enabled = False
        TKetTK.Enabled = False
        TQtyPrd.Enabled = False


        CDeadKirim.Enabled = False
        CDeadKirim.Checked = False
        CSurvei.Enabled = False
        CSurvei.Checked = False
        CRealImple.Enabled = False
        CRealImple.Checked = False
        CRealKirim.Enabled = False
        CRealKirim.Checked = False
        CRealSurvei.Enabled = False
        CRealSurvei.Checked = False
        CRealTerimaBrg.Enabled = False
        CRealTerimaBrg.Checked = False

        BtnInsertDetail.Enabled = False
        BtnUpdateDetailTK.Enabled = False
        BtnCetakFrm.Enabled = False
    End Sub
    Private Sub ViewModeTK()
        TBarangPrd.Enabled = False
        TTPrd.Enabled = False
        TLPrd.Enabled = False
        TPPrd.Enabled = False
        TSPrd.Enabled = False
        TQtyPrd.Enabled = False
        TKetTK.Enabled = False
        DTDeadlineImpleTK.Enabled = False
        DTRealImpleTK.Enabled = False
        DTDeadlineSurveiTK.Enabled = False
        DTRealSurveiTK.Enabled = False
        DTDeadlineKirimTK.Enabled = False
        DTTglTerima.Enabled = False
        BtnSimpanDetailTK.Enabled = False
        BtnUpdateDetailTK.Enabled = True
        BtnInsertDetail.Enabled = True
        TidBarangPrd.Text = ""
        TBarangPrd.Text = ""
        TPPrd.Text = "0"
        TLPrd.Text = "0"
        TTPrd.Text = "0"
        TidBarangPrd.Text = ""
        TSPrd.Text = "1"
        TKetTK.Text = ""
        TQtyPrd.Text = "1"
        DTDeadlineImpleTK.Format = DateTimePickerFormat.Custom
        DTDeadlineImpleTK.CustomFormat = "dd/MM/yyyy"
        DTDeadlineSurveiTK.Format = DateTimePickerFormat.Custom
        DTDeadlineSurveiTK.CustomFormat = "dd/MM/yyyy"
        DTRealImpleTK.Format = DateTimePickerFormat.Custom
        DTRealImpleTK.CustomFormat = "dd/MM/yyyy"
        DTRealSurveiTK.Format = DateTimePickerFormat.Custom
        DTRealSurveiTK.CustomFormat = "dd/MM/yyyy"
        DTTglTerima.Format = DateTimePickerFormat.Custom
        DTTglTerima.CustomFormat = "dd/MM/yyyy"
        DTDeadlineKirimTK.Format = DateTimePickerFormat.Custom
        DTDeadlineKirimTK.CustomFormat = "dd/MM/yyyy"
        DTRealKirimTK.Format = DateTimePickerFormat.Custom
        DTRealKirimTK.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub EditModeTK()
        TBarangPrd.Enabled = True
        TTPrd.Enabled = True
        TLPrd.Enabled = True
        TPPrd.Enabled = True
        TSPrd.Enabled = True
        TQtyPrd.Enabled = True
        TKetTK.Enabled = True
        BtnSimpanDetailTK.Enabled = True
        BtnInsertDetail.Enabled = False
        BtnUpdateDetailTK.Enabled = False
    End Sub
#End Region
#Region "Autocomplete"
    Private Sub AutoBarangPenawaran()
        GGVM_conn()
        sql = "select * from barang_penawaran where idsubkel='41'"
        da = New OdbcDataAdapter(sql, conn)
        ds = New DataSet
        da.Fill(ds)
        Dim BarangPE As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            BarangPE.Add(ds.Tables(0).Rows(i)("barang").ToString())
        Next
        With TBarangPrd
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = BarangPE
            .AutoCompleteMode = AutoCompleteMode.Suggest
        End With
        GGVM_conn_close()
    End Sub
#End Region
   

    Private Sub BtnInsertDetail_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnInsertDetail.ItemClick
        ProsesDetail = "EntryDetail"
        AutoBarangPenawaran()
        ClearDetailTK()
        BtnClose.Caption = "BATAL"
        ListToko.Enabled = True
        EditModeTK()
        For Each check As ListViewItem In ListBarang.CheckedItems
            check.Checked = False
        Next
        'BtnHapusBarang.Enabled = True
    End Sub

    
    Private Sub CSurvei_CheckedChanged(sender As Object, e As EventArgs) Handles CSurvei.CheckedChanged
        If CSurvei.Checked = True Then
            DTDeadlineSurveiTK.Enabled = True
            DTDeadlineImpleTK.Enabled = True
            DTDeadlineSurveiTK.Format = DateTimePickerFormat.Custom
            DTDeadlineSurveiTK.CustomFormat = "dd/MM/yyyy"
            DTDeadlineImpleTK.Format = DateTimePickerFormat.Custom
            DTDeadlineImpleTK.CustomFormat = "dd/MM/yyyy"
        Else
            DTDeadlineSurveiTK.Enabled = False
            DTDeadlineImpleTK.Enabled = False
            DTDeadlineSurveiTK.Format = DateTimePickerFormat.Custom
            DTDeadlineSurveiTK.CustomFormat = "dd/MM/yyyy"
            DTDeadlineImpleTK.Format = DateTimePickerFormat.Custom
            DTDeadlineImpleTK.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub CDeadKirim_CheckedChanged(sender As Object, e As EventArgs) Handles CDeadKirim.CheckedChanged
        If CDeadKirim.Checked = True Then
            DTDeadlineKirimTK.Enabled = True
            DTDeadlineImpleTK.Format = DateTimePickerFormat.Custom
            DTDeadlineImpleTK.CustomFormat = "dd/MM/yyyy"
        Else
            DTDeadlineKirimTK.Enabled = False
            DTDeadlineImpleTK.Format = DateTimePickerFormat.Custom
            DTDeadlineImpleTK.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub CRealSurvei_CheckedChanged(sender As Object, e As EventArgs) Handles CRealSurvei.CheckedChanged
        If CRealSurvei.Checked = True Then
            DTRealSurveiTK.Enabled = True
            DTRealSurveiTK.Format = DateTimePickerFormat.Custom
            DTRealSurveiTK.CustomFormat = "dd/MM/yyyy"
        Else
            DTRealSurveiTK.Enabled = False
            DTRealSurveiTK.Format = DateTimePickerFormat.Custom
            DTRealSurveiTK.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub CRealKirim_CheckedChanged(sender As Object, e As EventArgs) Handles CRealKirim.CheckedChanged
        If CRealKirim.Checked = True Then
            DTRealKirimTK.Enabled = True
            DTRealKirimTK.Format = DateTimePickerFormat.Custom
            DTRealKirimTK.CustomFormat = "dd/MM/yyyy"
        Else
            DTRealKirimTK.Enabled = False
            DTRealKirimTK.Format = DateTimePickerFormat.Custom
            DTRealKirimTK.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub CRealImple_CheckedChanged(sender As Object, e As EventArgs) Handles CRealImple.CheckedChanged
        If CRealImple.Checked = True Then
            DTRealImpleTK.Enabled = True
            DTRealImpleTK.Format = DateTimePickerFormat.Custom
            DTRealImpleTK.CustomFormat = "dd/MM/yyyy"
        Else
            DTRealImpleTK.Enabled = False
            DTRealImpleTK.Format = DateTimePickerFormat.Custom
            DTRealImpleTK.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub CRealTerimaBrg_CheckedChanged(sender As Object, e As EventArgs) Handles CRealTerimaBrg.CheckedChanged
        If CRealTerimaBrg.Checked = True Then
            CRealTerimaBrg.Enabled = True
            DTTglTerima.Format = DateTimePickerFormat.Custom
            DTTglTerima.CustomFormat = "dd/MM/yyyy"
        Else
            CRealTerimaBrg.Enabled = False
            DTTglTerima.Format = DateTimePickerFormat.Custom
            DTTglTerima.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub

    Private Sub ListToko_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListToko.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Dim tbrs As Integer
        With Me.ListToko
            For Each check As ListViewItem In ListToko.CheckedItems
                check.Checked = False
            Next
            For Each item As ListViewItem In ListToko.SelectedItems
                item.Checked = True
                tbrs = item.Index
                If item.Checked = True Then

                    BtnInsertDetail.Enabled = True
                Else

                    BtnInsertDetail.Enabled = False
                End If
            Next
        End With
        TNamaTK.Text = ListToko.Items(tbrs).SubItems(0).Text
        TidToko.Text = ListToko.Items(tbrs).SubItems(2).Text
        TKotaTK.Text = ListToko.Items(tbrs).SubItems(1).Text
        TIdKirimTK.Text = ListToko.Items(tbrs).SubItems(3).Text

        If ListToko.Items(tbrs).SubItems(5).Text = "N" Then
            CSurvei.Checked = False
        Else
            CSurvei.Checked = True
            TPPrd.Enabled = False
            TLPrd.Enabled = False
            TTPrd.Enabled = False
            TSPrd.Enabled = False
            TQtyPrd.Enabled = True
        End If
        TampilBarangPerToko()
        ListBarang.Enabled = True
        Me.Cursor = Cursors.Default
        ListToko.Enabled = False
        'BtnSimpanDetailTK.Enabled = True
        BtnClose.Caption = "BATAL"
    End Sub

    Private Sub BtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnClose.ItemClick
        If BtnClose.Caption = "BATAL" Then
            BtnClose.Caption = "TUTUP"
            LoadDetailForm()
            ListToko.Enabled = True
            ListBarang.Items.Clear()
            ListToko.Items.Clear()
            TampilToko()
        Else
            Me.Enabled = False
            Me.Dispose()
            TIDOrder.Text = ""
            ListToko.Enabled = False
        End If
    End Sub

    Private Sub BtnSimpanDetailTK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnSimpanDetailTK.ItemClick
        Dim c As String
        Select Case ProsesDetail
            Case "EntryDetail"
                GGVM_conn()
                If TidBarangPrd.Text = "" Then
                    Dim kd As String
                    'Count Kode Barang
                    s = ""
                    s = s & " Select max(idbarang)As id from barang_penawaran "
                    cmd = New OdbcCommand(s, conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    kd = "000000" + dr.GetString(0)
                    kd = Microsoft.VisualBasic.Right(kd, 6)

                    c = ""
                    c = c & "insert barang_penawaran (idsubkel,kdbarang,barang,keterangan)"
                    c = c & "values ('41', '" & kd & "' , '" & TBarangPrd.Text & "', 'Otomatis') "
                    cmd = New OdbcCommand(c, conn)
                    cmd.ExecuteNonQuery()

                    c = ""
                    c = c & " Select max(idbarang) As id from barang_penawaran "
                    da = New OdbcDataAdapter(c, conn)
                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        TidBarangPrd.Text = dt.Rows(0)("id")
                    End If
                End If

                s = ""
                s = s & " insert into prd_trans_detaildo_kirim (idkirim,iddtorder,idbarang_prd,panjang_prd,lebar_prd, "
                s = s & " tinggi_prd, sisi_prd, qty_prd,"
                If CSurvei.Checked = True Then
                    s = s & " deadline_survei, deadline_implementasi, "
                End If
                If CDeadKirim.Checked = True Then
                    s = s & " deadline_kirim, "
                End If
                If CRealSurvei.Checked = True Then
                    s = s & "realisasi_survei, "
                End If
                If CRealImple.Checked = True Then
                    s = s & " realisasi_implementasi, "
                End If
                If CRealTerimaBrg.Checked = True Then
                    s = s & " realisasi_terima_brg, "
                End If
                If CRealKirim.Checked = True Then
                    s = s & " realisasi_kirim, "
                End If
                s = s & "  keterangan ) "
                s = s & " values ( '" & TIdKirimTK.Text & "' , '" & TIDOrder.Text & "', '" & TidBarangPrd.Text & "', '" & TPPrd.Text & "', "
                s = s & " '" & TLPrd.Text & "', '" & TTPrd.Text & "', '" & TSPrd.Text & "', '" & TQtyPrd.Text & "', "
                If CSurvei.Checked = True Then
                    s = s & " '" & Format(DTDeadlineSurveiTK.Value, "yyyy/MM/dd") & "','" & Format(DTDeadlineImpleTK.Value, "yyyy/MM/dd") & "',  "
                End If
                If CDeadKirim.Checked = True Then
                    s = s & "'" & Format(DTDeadlineKirimTK.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealSurvei.Checked = True Then
                    s = s & "'" & Format(DTRealSurveiTK.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealImple.Checked = True Then
                    s = s & "'" & Format(DTRealImpleTK.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealTerimaBrg.Checked = True Then
                    s = s & "'" & Format(DTTglTerima.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealKirim.Checked = True Then
                    s = s & "'" & Format(DTRealKirimTK.Value, "yyyy/MM/dd") & "', "
                End If
                s = s & " '" & TKetTK.Text & "' ) "
                cmd = New OdbcCommand(s, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil ditambahkan !! ", MsgBoxStyle.Information, "Pemberitahuan !!")
                GGVM_conn_close()
                ViewModeTK()
                TampilBarangPerToko()
                BtnHapusBarang.Enabled = False
                'ListToko.Enabled = True
            Case "EditDetail"
                If TidBarangPrd.Text = "" Then
                    MsgBox(" Pilih dulu Data Barangnya !! ", MsgBoxStyle.Information, "Pemberitahuan !!")
                    Exit Sub
                End If
                GGVM_conn()
                s = ""
                s = s & " update prd_trans_detaildo_kirim set"
                s = s & " idbarang_prd = '" & TidBarangPrd.Text & "', panjang_prd = '" & TPPrd.Text & "', lebar_prd = '" & TLPrd.Text & "',tinggi_prd = '" & TTPrd.Text & "', "
                s = s & " sisi_prd = '" & TSPrd.Text & "',qty_prd = '" & TQtyPrd.Text & "', "
                If CSurvei.Checked = True Then
                    s = s & " deadline_survei ='" & Format(DTDeadlineSurveiTK.Value, "yyyy/MM/dd") & "', deadline_implementasi = '" & Format(DTDeadlineImpleTK.Value, "yyyy/MM/dd") & "',  "
                End If
                If CDeadKirim.Checked = True Then
                    s = s & " deadline_kirim = '" & Format(DTDeadlineKirimTK.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealSurvei.Checked = True Then
                    s = s & " realisasi_survei ='" & Format(DTRealSurveiTK.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealImple.Checked = True Then
                    s = s & " realisasi_implementasi = '" & Format(DTRealImpleTK.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealTerimaBrg.Checked = True Then
                    s = s & "realisasi_terima_brg'" & Format(DTTglTerima.Value, "yyyy/MM/dd") & "', "
                End If
                If CRealKirim.Checked = True Then
                    s = s & "realisasi_kirim = '" & Format(DTRealKirimTK.Value, "yyyy/MM/dd") & "', "
                End If
                s = s & " userupdate = '" & userid & "',"
                s = s & " keterangan = '" & TKetTK.Text & "' "
                s = s & " where idtrans = '" & TidTrans.Text & "' "
                cmd = New OdbcCommand(s, conn)
                cmd.ExecuteNonQuery()

                c = ""
                c = "update prd_dataorder set "
                c = c & " user_koreksi ='" & userid & "',time_koreksi=now()"
                c = c & " where iddtorder = '" & TIDOrder.Text & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                MsgBox("Data Berhasil diUpdate !! ", MsgBoxStyle.Information, "Pemberitahuan !!")
                GGVM_conn_close()
                ProsesDetail = "EntryDetail"
                'LoadDetailForm()
                ViewModeTK()
                ListBarang.Items.Clear()
                Call TampilBarangPerToko()
                BtnSimpanDetailTK.Caption = "SIMPAN " & vbCrLf & "DETAIL"
                'BtnInsertDetail.Enabled = True
                BtnUpdateDetailTK.Enabled = False

                BtnHapusBarang.Enabled = False
        End Select
    End Sub

    Private Sub ListBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBarang.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Dim brsbrg As Integer
        With Me.ListBarang
            For Each check As ListViewItem In ListBarang.CheckedItems
                check.Checked = False
            Next
            For Each item As ListViewItem In ListBarang.SelectedItems
                item.Checked = True
                brsbrg = item.Index
                If item.Checked = True Then
                    BtnUpdateDetailTK.Enabled = True
                Else
                    BtnUpdateDetailTK.Enabled = False
                End If
            Next
        End With
        TBarangPrd.Text = ListBarang.Items(brsbrg).SubItems(0).Text
        TPPrd.Text = ListBarang.Items(brsbrg).SubItems(1).Text
        TLPrd.Text = ListBarang.Items(brsbrg).SubItems(2).Text
        TTPrd.Text = ListBarang.Items(brsbrg).SubItems(3).Text
        TSPrd.Text = ListBarang.Items(brsbrg).SubItems(4).Text
        TQtyPrd.Text = ListBarang.Items(brsbrg).SubItems(5).Text
        TKetTK.Text = ListBarang.Items(brsbrg).SubItems(6).Text
        DTDeadlineSurveiTK.Text = ListBarang.Items(brsbrg).SubItems(7).Text
        DTRealSurveiTK.Text = ListBarang.Items(brsbrg).SubItems(8).Text
        DTDeadlineImpleTK.Text = ListBarang.Items(brsbrg).SubItems(9).Text
        DTRealImpleTK.Text = ListBarang.Items(brsbrg).SubItems(10).Text
        DTDeadlineKirimTK.Text = ListBarang.Items(brsbrg).SubItems(11).Text
        DTRealKirimTK.Text = ListBarang.Items(brsbrg).SubItems(12).Text
        DTTglTerima.Text = ListBarang.Items(brsbrg).SubItems(13).Text
        TidTrans.Text = ListBarang.Items(brsbrg).SubItems(14).Text
        TidBarangPrd.Text = ListBarang.Items(brsbrg).SubItems(15).Text

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnUpdateDetailTK_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnUpdateDetailTK.ItemClick
        EditModeTK()
        ProsesDetail = "EditDetail"
        'Call TampilToko()
        AutoBarangPenawaran()
        'ListToko.Enabled = True
        BtnHapusBarang.Enabled = True
    End Sub

    Private Sub BtnHapusBarang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHapusBarang.ItemClick
        Dim ada As Boolean
        Dim brs, jmldt As Integer
        ada = False
        jmldt = 0
        ListBarang.BeginUpdate()
        Dim I As Integer
        For I = ListBarang.Items.Count - 1 To 0 Step -1
            If ListBarang.Items(I).Checked = True Then
                ada = True
                brs = I
                jmldt = jmldt + 1
                If ada = False Then
                    MsgBox("Pilih Barangnya Dulu", MsgBoxStyle.Information)
                    Exit Sub
                End If
                For Each item As ListViewItem In ListBarang.CheckedItems
                    GGVM_conn()
                    Dim sql2 As String

                    sql2 = "DELETE FROM prd_trans_detaildo_kirim WHERE idtrans = ?"
                    cmd = New OdbcCommand
                    With cmd
                        .CommandText = (sql2)
                        .Parameters.Add("@idtrans", OdbcType.BigInt).Value = Convert.ToInt32(item.SubItems(14).Text)
                        .Connection = conn
                    End With
                    dr = cmd.ExecuteReader
                    Console.WriteLine(cmd.CommandText.ToString)
                    While dr.Read
                        Console.WriteLine(dr(0))
                        Console.WriteLine()
                    End While
                    Console.ReadLine()
                    conn.Close()
                    dr = Nothing
                    cmd = Nothing

                    MsgBox("Barang Berhasil diHapus")
                    Call TampilBarangPerToko()
                Next
            End If
        Next I
        ListBarang.EndUpdate()
    End Sub
End Class
