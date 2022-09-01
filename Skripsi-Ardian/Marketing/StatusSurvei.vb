Imports System.Data.Odbc

Public Class StatusSurvei
    Dim GrandTotal, Harga As Decimal
    Public Sub New()
        AddHandler DetailDataOrder.GetDataOrder, AddressOf SetLabelText
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub SetLabelText(ByVal idDO As String)
        TIDDtOrder.Text = idDO
    End Sub
#Region "Fungsi"
    Private Sub Entry()
        CBarangPE.Checked = True
        TBarangPE.ReadOnly = False
        BtnEntry.Enabled = False
        BtnEntryS.Enabled = False
        BtnEdit.Enabled = False
        BtnEditS.Enabled = False
        BtnSimpanPE.Visible = False
        BtnHitungPE.Enabled = True
        BtnHitungPE.Visible = True
        BtnKeluar.Caption = "BATAL"
        CBarangPE.Enabled = True
        TPanjangPE.Text = TPanjangPRD.Text
        TPanjangPE.ReadOnly = False
        TLebarPE.Text = TLebarPRD.Text
        TLebarPE.ReadOnly = False
        TTinggiPE.Text = TTinggiPRD.Text
        TTinggiPE.ReadOnly = False
        TSisiPE.Text = "1"
        TSisiPE.ReadOnly = False
        TJmlPE.Text = TQty2.Text
        TJmlPE.ReadOnly = False
        THargaPE.Text = "0"
        THarga.ReadOnly = False
        THarga.Text = "0"
        THargaPE.ReadOnly = False
        TKeterangan.Text = ""
        TKeterangan.ReadOnly = False
        TMaterialPE.ReadOnly = False
        TSizePE.Text = "0"
        TMeasurePE.Text = "0"
        TJmlTK.Text = "0"
        TIdTrans.Text = ""
        Proses = "entryPE"
    End Sub
    Private Sub ClearPE()
        TIdDetailPE.Text = ""
        CBarangPE.Checked = False
        CBarangPE.Enabled = False
        TBarangPE.Text = ""
        TBarangPE.ReadOnly = True
        TIdBarangPE.Text = ""
        TMaterialPE.Text = ""
        TMaterialPE.ReadOnly = True
        TIDMaterialPE.Text = ""
        TPanjangPE.Text = "0"
        TPanjangPE.ReadOnly = True
        TTinggiPE.Text = "0"
        TTinggiPE.ReadOnly = True
        TLebarPE.Text = "0"
        TLebarPE.ReadOnly = True
        TSisiPE.Text = "1"
        TSisiPE.ReadOnly = True
        TJmlPE.Text = "1"
        TJmlPE.ReadOnly = True
        TSizePE.Text = "0"
        TSizePE.ReadOnly = True
        TMeasurePE.Text = "0"
        TMeasurePE.ReadOnly = True
        TJmlTK.Text = "0"
        TJmlTK.ReadOnly = True
        THarga.Text = "0"
        THarga.ReadOnly = True
        THargaPE.Text = "0"
        TIdTrans.Text = ""
        THargaPE.ReadOnly = True
        BtnSimpanPE.Visible = False
        BtnHitungPE.Visible = True
        TKeterangan.Text = ""
        TKeterangan.ReadOnly = True
    End Sub
    Private Sub ClearPRD()
        TIdKirim.Text = ""
        TDist.Text = ""
        TToko.Text = ""
        TBarangPRD.Text = ""
        TIdBarangPRD.Text = ""
        TIdMaterialPRD.Text = ""
        TMaterialPRD.ReadOnly = True
        TMaterialPRD.Text = ""
        TPanjangPRD.Text = "0"
        TPanjangPRD.ReadOnly = True
        TTinggiPRD.Text = "0"
        TTinggiPRD.ReadOnly = True
        TLebarPRD.Text = "0"
        TLebarPRD.ReadOnly = True
        TSisiPRD.Text = "1"
        TSisiPRD.ReadOnly = True
        TQty2.Text = "1"
        TQty2.ReadOnly = True
        TKet2.Text = ""
        TKet2.ReadOnly = True
    End Sub
    Private Sub AutoMaterialPE()
        Dim s As String
        GGVM_conn()
        s = "select material FROM prd_material_kontrak "
        da = New OdbcDataAdapter(s, conn)
        ds = New DataSet
        da.Fill(ds)
        Dim MaterialPE As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            MaterialPE.Add(ds.Tables(0).Rows(i)("material").ToString())
        Next
        With TMaterialPE
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = MaterialPE
            .AutoCompleteMode = AutoCompleteMode.Suggest
        End With
        'GGVM_conn_close()
    End Sub
    Private Sub AutoBarangPE()
        Dim s As String
        GGVM_conn()
        s = ""
        s = s & " select a.barang FROM barang_penawaran a "
        s = s & " left join trans_brg_produksi b on a.idbarang = b.idbarangmkt "
        s = s & " where a.idsubkel ='41'"
        s = s & " group by a.barang "
        da = New OdbcDataAdapter(s, conn)
        ds = New DataSet
        da.Fill(ds)
        Dim BarangPE As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            BarangPE.Add(ds.Tables(0).Rows(i)("barang").ToString())
        Next
        With TBarangPE
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = BarangPE
            .AutoCompleteMode = AutoCompleteMode.Suggest
        End With
        GGVM_conn_close()
    End Sub

    Private Sub AutoMaterialPRD()
        Dim s As String
        GGVM_conn()
        s = ""
        s = s & " select material,idmaterial FROM prd_material_kontrak "
        da = New OdbcDataAdapter(s, conn)
        ds = New DataSet
        da.Fill(ds)
        Dim MaterialPRD As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            MaterialPRD.Add(ds.Tables(0).Rows(i)("material").ToString())
        Next
        With TMaterialPRD
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = MaterialPRD
            .AutoCompleteMode = AutoCompleteMode.Suggest
        End With
        GGVM_conn_close()
    End Sub
#End Region
    
    Private Sub ListHeaderdo()
        ListDetailDO.FullRowSelect = True
        ListDetailDO.MultiSelect = True
        ListDetailDO.View = View.Details
        ListDetailDO.CheckBoxes = True
        ListDetailDO.Columns.Clear()
        ListDetailDO.Items.Clear()
        ListDetailDO.Columns.Add("BARANG", 200, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("TOKO", 100, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("KOTA", 100, HorizontalAlignment.Right)
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
        ListDetailDO.Columns.Add("KETERANGAN", 100, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("QTY-TK", 80, HorizontalAlignment.Right)
        ListDetailDO.Columns.Add("idbarang", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("idmaterial", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("iddetaildo", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("SATUAN", 1, HorizontalAlignment.Left)
    End Sub
    Private Sub ListHeaderDist()
        ListDist.FullRowSelect = True
        ListDist.MultiSelect = True
        ListDist.View = View.Details
        ListDist.CheckBoxes = True
        ListDist.Columns.Clear()
        ListDist.Items.Clear()
        ListDist.Columns.Add("BARANG", 200, HorizontalAlignment.Left)
        ListDist.Columns.Add("DISTRIBUTOR", 120, HorizontalAlignment.Left)
        ListDist.Columns.Add("TOKO", 100, HorizontalAlignment.Right)
        ListDist.Columns.Add("KOTA", 100, HorizontalAlignment.Right)
        ListDist.Columns.Add("PANJANG", 100, HorizontalAlignment.Right)
        ListDist.Columns.Add("TINGGI", 100, HorizontalAlignment.Right)
        ListDist.Columns.Add("LEBAR", 100, HorizontalAlignment.Right)
        ListDist.Columns.Add("SISI", 100, HorizontalAlignment.Right)
        ListDist.Columns.Add("QTY", 100, HorizontalAlignment.Left)
        ListDist.Columns.Add("MATERIAL", 100, HorizontalAlignment.Left)
        ListDist.Columns.Add("idkirim", 10, HorizontalAlignment.Left)
        ListDist.Columns.Add("idbarangprd", 10, HorizontalAlignment.Left)
        ListDist.Columns.Add("idmaterial", 10, HorizontalAlignment.Left)
        ListDist.Columns.Add("idtrans", 10, HorizontalAlignment.Left)
        ListDist.Columns.Add("keterangan", 200, HorizontalAlignment.Left)
    End Sub
    Private Sub TampilDetailDo()
        Dim s As String
        Dim i As Integer
        ListDetailDO.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()
        s = ""
        s = s & " select * from view_detaildo2"
        s = s & " where iddtorder='" & TIDDtOrder.Text & "' "
        s = s & " GROUP BY iddetailpe "
        da = New OdbcDataAdapter(s, conn)
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            With ListDetailDO
                .Items.Add(dt.Rows(i)("barang"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dt.Rows(i)("toko"))
                    .Add(dt.Rows(i)("kota"))
                    .Add(FormatNumber(dt.Rows(i)("harga_barang"), 0, , , TriState.True))
                    .Add(dt.Rows(i)("panjang_pe"))
                    .Add(dt.Rows(i)("tinggi_pe"))
                    .Add(dt.Rows(i)("lebar_pe"))
                    .Add(dt.Rows(i)("size_pe"))
                    .Add(dt.Rows(i)("sisi_pe"))
                    .Add(dt.Rows(i)("measure_pe"))
                    .Add(dt.Rows(i)("qty_pe"))
                    .Add(FormatNumber(dt.Rows(i)("harga_PE"), 0, , , TriState.True))
                    .Add(IIf(IsDBNull(dt.Rows(i)("material")), "", dt.Rows(i)("material")))
                    .Add(dt.Rows(i)("keterangan"))
                    .Add(dt.Rows(i)("qty_TOKO"))
                    .Add(dt.Rows(i)("idbarang"))
                    .Add(IIf(IsDBNull(dt.Rows(i)("idmaterial")), "", dt.Rows(i)("idmaterial")))
                    .Add(dt.Rows(i)("iddetailpe"))
                    .Add(dt.Rows(i)("SATUAN"))
                End With
            End With
        Next
        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TampilKirim()
        Dim s As String
        Dim i As Integer

        ListDist.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()
        s = ""
        s = s & " select * from view_tampilkirim "
        s = s & " where iddtorder= '" & TIDDtOrder.Text & "' "
        'If TIdDetailPE.Text <> "" Then
        '    s = s & " and iddetailpe='" & TIdDetailPE.Text & "'"
        'End If
        s = s & " order by toko"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)

        For i = 0 To dt.Rows.Count - 1
            With ListDist
                .Items.Add(dt.Rows(i)("barangprd"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(IIf(IsDBNull(dt.Rows(i)("distributor")), "", dt.Rows(i)("distributor")))
                    .Add(dt.Rows(i)("toko"))
                    .Add(dt.Rows(i)("kota"))
                    .Add(dt.Rows(i)("panjang_prd"))
                    .Add(dt.Rows(i)("tinggi_prd"))
                    .Add(dt.Rows(i)("lebar_prd"))
                    .Add(dt.Rows(i)("sisi_prd"))
                    .Add(IIf(IsDBNull(dt.Rows(i)("material")), "", dt.Rows(i)("material")))
                    .Add(dt.Rows(i)("idkirim"))
                    .Add(dt.Rows(i)("idbarang_prd"))
                    .Add(IIf(IsDBNull(dt.Rows(i)("idmaterial")), "", dt.Rows(i)("idmaterial")))
                    .Add(dt.Rows(i)("idtrans"))
                    .Add(dt.Rows(i)("keterangan"))
                    .Add(dt.Rows(i)("qty_prd"))
                End With
            End With
        Next

        'GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TampilDO()

        Dim s, nmproyek As String
        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()
        s = ""
        s = s & " select y.* from ("
        s = s & " select  a.*,b.nama as nmklien,c.brand,f.nama as divisi "
        s = s & " from prd_dataorder a, klien b, brand c,  divisi f  "
        s = s & " where a.idklien = b.id"
        s = s & " and a.idbrand = c.idbrand "
        s = s & " and a.iddivisi = f.id_divisi "
        's = s & " and a.idstatus_proyek in ('1')"
        s = s & " and a.time_closing is null ) y "
        ' s = s & " left join trans_do_survei x on y.iddtorder = x.iddtorder "
        s = s & " where y.iddtorder ='" & TIDDtOrder.Text & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)

        LabelControl2.Text = dt.Rows(0)("noorder")
        LabelControl3.Text = dt.Rows(0)("nmklien")
        LabelControl5.Text = dt.Rows(0)("brand")
        nmproyek = replaceNewLine(dt.Rows(0)("namaorder"), False)
        LabelControl7.Text = dt.Rows(0)("namaorder")
        TIDDtOrder.Text = dt.Rows(0)("iddtorder")
        TidKlien.Text = dt.Rows(0)("idklien")

        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub StatusSurvei_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListHeaderdo()
        ListHeaderDist()
        TampilDO()
        TampilDetailDo()
        TampilKirim()
        AutoMaterialPE()
    End Sub

    Private Sub BtnSimpanPE_Click(sender As Object, e As EventArgs) Handles BtnSimpanPE.Click
        Dim c, s As String
        Dim sql1 As String

        BtnSimpanPE.Enabled = False
        BtnEntryS.Enabled = False
        BtnSimpanS.Enabled = False

        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()
        Select Case Proses
            Case "entryPE"
                If ListDist.CheckedIndices.Count > 0 Then
                    For i = 0 To ListDist.CheckedIndices.Count - 1
                        If TIdBarangPE.Text = "" Then
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
                            c = c & "values ('41', '" & kd & "' , '" & TBarangPE.Text & "', 'Otomatis') "
                            cmd = New OdbcCommand(c, conn)
                            cmd.ExecuteNonQuery()

                            c = ""
                            c = c & " Select max(idbarang) As id from barang_penawaran "
                            da = New OdbcDataAdapter(c, conn)
                            dt = New DataTable
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                TIdBarangPE.Text = dt.Rows(0)("id")
                            End If
                        End If

                        If TIDMaterialPE.Text = "" Then

                            c = ""
                            c = c & "insert prd_material_kontrak (material,status)"
                            c = c & "values ('" & TMaterialPE.Text & "', '1') "
                            cmd = New OdbcCommand(c, conn)
                            cmd.ExecuteNonQuery()

                            c = ""
                            c = c & " Select max(idmaterial) As id from prd_material_kontrak "
                            da = New OdbcDataAdapter(c, conn)
                            dt = New DataTable
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                TIDMaterialPE.Text = dt.Rows(0)("id")
                            End If
                        End If

                        If TIDMaterialPE.Text = "" AndAlso TMeasurePE.Text <> "0" Then
                            MsgBox("Input Data Material Dulu", MsgBoxStyle.Information, "Informasi")
                            BtnHitungPE.Enabled = True
                            BtnHitungPE.Visible = True
                            BtnSimpanPE.Visible = False
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If

                        If THarga.Text <> "0" Then
                            sql = ""
                            sql = sql & " update barang_penawaran set harga_pe = '" & Harga & "'"
                            sql = sql & " where idbarang ='" & TIdBarangPE.Text & "'"
                            cmd = New OdbcCommand(sql, conn)
                            cmd.ExecuteNonQuery()
                        End If

                        s = ""
                        s = "select count(idbarangmkt) as idmkt from trans_brg_produksi where idbarangmkt ='" & TIdBarangPE.Text & "'  and idbarangprd='" & TIdBarangPRD.Text & "' "
                        cmd = New OdbcCommand(s, conn)
                        dr = cmd.ExecuteReader
                        dr.Read()
                        If dr.Item("idmkt") <> "1" Then
                            sql1 = "insert into trans_brg_produksi (idbarangmkt,idbarangprd) values (?,?) "
                            cmd = New OdbcCommand
                            With cmd
                                .CommandText = (sql1)
                                .Parameters.Add("@idbarangmkt", OdbcType.BigInt).Value = Convert.ToInt32(TIdBarangPE.Text)
                                .Parameters.Add("@idbarangprd", OdbcType.BigInt).Value = Convert.ToInt32(ListDist.Items(ListDist.CheckedIndices(i)).SubItems(10).Text)
                                .Connection = conn
                            End With
                            dr = cmd.ExecuteReader
                            Console.WriteLine(cmd.CommandText.ToString)
                            While dr.Read
                                Console.WriteLine(dr(0))
                                Console.WriteLine()
                            End While
                            Console.ReadLine()
                        End If
                    Next
                End If

                c = ""
                c = c & " insert into prd_detail_penawaran ( iddtorder,idbarang,barang,keterangan,"
                If TIDMaterialPE.Text <> "" Then
                    c = c & " idmaterial, "
                End If
                c = c & " panjang_pe, lebar_pe, tinggi_pe,"
                c = c & " size_pe,sisi_pe,measure_pe,qty_pe,harga_barang,harga_pe) values "
                c = c & " ('" & TIDDtOrder.Text & "','" & TIdBarangPE.Text & "','" & TBarangPE.Text & "','" & TKeterangan.Text & "',"
                If TIDMaterialPE.Text <> "" Then
                    c = c & "'" & TIDMaterialPE.Text & "',"
                End If
                c = c & "'" & TPanjangPE.Text & "','" & TLebarPE.Text & "','" & TTinggiPE.Text & "',"
                c = c & " '" & TSizePE.Text & "','" & TSisiPE.Text & "','" & TMeasurePE.Text & "','" & TJmlPE.Text & "','" & Harga & "','" & GrandTotal & "')"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                s = ""
                s = s & " select max(iddetailpe)as id from prd_detail_penawaran "
                s = s & " where iddtorder ='" & TIDDtOrder.Text & "'"
                da = New OdbcDataAdapter(s, conn)
                ds.Clear()
                dt = New DataTable
                dt.Clear()
                da.Fill(dt)
                TIdDetailPE.Text = dt.Rows(0)("id")

                c = ""
                c = c & " select iddetailpe from prd_trans_detaildo_kirim where idtrans in (" & TextBox1.Text & ") "
                cmd = New OdbcCommand(c, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    sql = ""
                    sql = sql & " update prd_trans_detaildo_kirim set "
                    sql = sql & " iddetailpe ='" & TIdDetailPE.Text & "',"
                    sql = sql & " idbarang_pe ='" & TIdBarangPE.Text & "'"
                    sql = sql & " where idtrans in (" & TextBox1.Text & ") and iddetailpe is null and idbarang_pe is null"
                    cmd = New OdbcCommand(sql, conn)
                    cmd.ExecuteNonQuery()
                End If



                Me.Cursor = Cursors.Default
                MsgBox("Detail Penawaran sudah di-SIMPAN !!..", MsgBoxStyle.Information, "Information")

            Case "editPE"
                If TIDMaterialPE.Text = "" Then

                    c = ""
                    c = c & "insert prd_material_kontrak (material,status)"
                    c = c & "values ('" & TMaterialPE.Text & "', '1') "
                    cmd = New OdbcCommand(c, conn)
                    cmd.ExecuteNonQuery()

                    c = ""
                    c = c & " Select max(idmaterial) As id from prd_material_kontrak "
                    da = New OdbcDataAdapter(c, conn)
                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        TMaterialPE.Text = dt.Rows(0)("id")
                    End If
                End If
                c = ""
                c = c & " update prd_detail_penawaran set"
                c = c & " idbarang = '" & TIdBarangPE.Text & "',"
                c = c & " barang = '" & TBarangPE.Text & "',"
                c = c & " keterangan ='" & TKeterangan.Text & "',"
                c = c & " idmaterial ='" & TIDMaterialPE.Text & "',"
                c = c & " panjang_pe= " & TPanjangPE.Text & ","
                c = c & " lebar_pe = " & TLebarPE.Text & ","
                c = c & " tinggi_pe = " & TTinggiPE.Text & ","
                c = c & " size_pe = " & TSizePE.Text & ","
                c = c & " sisi_pe = " & TSisiPE.Text & ","
                c = c & " measure_pe =" & TMeasurePE.Text & ","
                c = c & " qty_pe = " & TJmlPE.Text & ","
                c = c & " harga_barang =" & Harga & ","
                c = c & " harga_pe = " & GrandTotal & ""
                c = c & " where iddetailpe ='" & TIdDetailPE.Text & "'"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                MsgBox("Detail Penawaran sudah di-EDIT !!..", MsgBoxStyle.Information, "Information")

            Case "hapusPE"
                c = ""
                c = c & " delete from prd_detail_penawaran"
                c = c & " where iddetailpe ='" & TIdDetailPE.Text & "'"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                sql = sql & " update prd_trans_detaildo_kirim set iddetailpe = null"
                sql = sql & " where iddetailpe = '" & TIdDetailPE.Text & "'"
                cmd = New OdbcCommand(sql, conn)
                cmd.ExecuteNonQuery()

                Me.Cursor = Cursors.Default
                MsgBox("Detail Penawaran sudah di-Hapus !!..", MsgBoxStyle.Information, "Information")
                BtnSimpanPE.Text = "SIMPAN PENAWARAN"
        End Select

        Me.Cursor = Cursors.Default
        s = ""
        s = s & " select count(*)as jml from prd_trans_detaildo_kirim"
        s = s & " where iddtorder ='" & TIDDtOrder.Text & "'"
        s = s & " and iddetailpe = '" & TIdDetailPE.Text & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        dt = New DataTable
        dt.Clear()
        da.Fill(dt)
        TJmlTK.Text = dt.Rows(0)("jml")
        If TJmlTK.Text > 0 Then
            c = ""
            c = c & " update prd_detail_penawaran set "
            c = c & " qty_toko='" & TJmlTK.Text & "'"
            c = c & " where iddetailpe ='" & TIdDetailPE.Text & "'"
            cmd = New OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
        End If
        GGVM_conn_close()
        'tombol 
        BtnEntry.Enabled = True
        BtnEntryS.Enabled = False
        BtnEdit.Enabled = True
        BtnEditS.Enabled = True
        BtnSimpanPE.Visible = False
        BtnSimpanS.Enabled = False
        BtnHitungPE.Visible = True
        BtnHitungPE.Enabled = False
        BtnKeluar.Caption = "KELUAR"
        TextBox1.Text = ""
        Me.Cursor = Cursors.Default
        ClearPE()
        ClearPRD()
        TampilDetailDo()
        TampilKirim()
    End Sub

    Private Sub BtnHitungPE_Click(sender As Object, e As EventArgs) Handles BtnHitungPE.Click
        Dim s, v As Decimal
        If TPanjangPE.Text = "0" Or TTinggiPE.Text = "0" Or TLebarPE.Text = "0" Then
            MsgBox("Lengkapi Data Panjang atau Tinggi atau Lebar-nya !!", MsgBoxStyle.Information, "Pemberitahuan !!")
            Exit Sub
            TPanjangPE.Focus()
        Else
            s = (Val(CDec(TPanjangPE.Text)) * Val(CDec(TTinggiPE.Text))) / 10000
            v = (Val(CDec(TPanjangPE.Text)) * Val(CDec(TTinggiPE.Text)) * Val(CDec(TLebarPE.Text))) / 10000

        End If
        Dim a As String = String.Format("{0:0.000}", s)
        TSizePE.Text = a
        'TSizePE.Text = Format(Val(s), "##,##")
        Dim b As String = String.Format("{0:0.000}", v)
        TVolume.Text = b
        'TLebarPE.Text = FormatNumber(TLebarPE.Text, 0, , , TriState.True)


        Dim m As Decimal
        If TSisiPE.Text = "" Or TSizePE.Text = "" Then
            MsgBox("Data Sisi dan Size Belum lengkap !!", MsgBoxStyle.Information, "Pemberitahuan !!")
            Exit Sub
            TSisiPE.Focus()
        Else
            m = Val(CDec(TSisiPE.Text)) * Val(CDec(TSizePE.Text))
        End If
        'Dim mes As String = String.Format("{0:0.000}", m)
        'TMeasurePE.Text = mes
        Dim h, hpe As Decimal
        Dim j As Integer
        j = Val(CInt(TJmlPE.Text))
        m = Val(CDec(TMeasurePE.Text))
        h = Val(CDec(THarga.Text))
        If m = "0" Then 'Jika 2S
            hpe = j * h
        Else
            hpe = m * h * j
        End If
        'THargaPE.Text = hpe

        'GrandTotal = hpe
        GrandTotal = FormatNumber(hpe, 0, , , TriState.True)
        Harga = FormatNumber(h, 0, , , TriState.True)
        'THarga.Text = "Rp. " & Format(h, "###,###,###")
        THargaPE.Text = "Rp." & Format(hpe, "###,###,###")



        BtnHitungPE.Visible = False
        BtnHitungPE.Enabled = False
        BtnSimpanPE.Visible = True
        BtnSimpanPE.Enabled = True
        BtnSimpanPE.Focus()
    End Sub

    Private Sub BtnSimpanS_Click(sender As Object, e As EventArgs) Handles BtnSimpanS.Click
        Dim c, s As String

        Me.Cursor = Cursors.WaitCursor
        Select Case Proses
            Case "entryPRD"

                GGVM_conn()

                If TIdMaterialPRD.Text = "" Then

                    c = ""
                    c = c & "insert prd_material_kontrak (material,status)"
                    c = c & "values ('" & TMaterialPRD.Text & "', '1') "
                    cmd = New OdbcCommand(c, conn)
                    cmd.ExecuteNonQuery()

                    c = ""
                    c = c & " Select max(idmaterial) As id from prd_material_kontrak "
                    da = New OdbcDataAdapter(c, conn)
                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        TIdMaterialPRD.Text = dt.Rows(0)("id")
                    End If
                    Me.Cursor = Cursors.Default
                End If

                If CDetailBarang.Checked = True Then
                    s = ""
                    s = s & " insert into prd_trans_detaildo_kirim (idkirim,iddtorder,idbarang_prd,panjang_prd,lebar_prd, "
                    s = s & " tinggi_prd, sisi_prd, qty_prd,"
                    s = s & "  keterangan ) "
                    s = s & " values ( '" & TIdKirim.Text & "' , '" & TIDDtOrder.Text & "', '" & TIdBarangPRD.Text & "', '" & TPanjangPRD.Text & "', "
                    s = s & " '" & TLebarPRD.Text & "', '" & TTinggiPRD.Text & "', '" & TSisiPRD.Text & "', '" & TQty2.Text & "', "
                Else
                    s = ""
                    s = s & " update prd_trans_detaildo_kirim set "
                    s = s & " panjang_prd = '" & TPanjangPRD.Text & "', "
                    s = s & " lebar_prd = '" & TLebarPRD.Text & "',tinggi_prd = '" & TTinggiPRD.Text & "', sisi_prd = '" & TSisiPRD.Text & "',  "
                    s = s & " idmaterial = '" & TIdMaterialPRD.Text & "', qty_prd = '" & TQty2.Text & "', keterangan = '" & TKet2.Text & "'"
                    s = s & " where idtrans = '" & TIdTrans.Text & "' "
                    cmd = New OdbcCommand(s, conn)
                    cmd.ExecuteNonQuery()
                End If



                Me.Cursor = Cursors.Default
                MsgBox("Data Survei sudah di-SIMPAN !!..", MsgBoxStyle.Information, "Information")
                GGVM_conn_close()

            Case "editPRD"
                GGVM_conn()

                If TIdMaterialPRD.Text = "" Then

                    c = ""
                    c = c & "insert prd_material_kontrak (material,status)"
                    c = c & "values ('" & TMaterialPRD.Text & "', '1') "
                    cmd = New OdbcCommand(c, conn)
                    cmd.ExecuteNonQuery()

                    c = ""
                    c = c & " Select max(idmaterial) As id from prd_material_kontrak "
                    da = New OdbcDataAdapter(c, conn)
                    dt = New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        TIdMaterialPRD.Text = dt.Rows(0)("id")
                    End If
                    Me.Cursor = Cursors.Default
                End If

                c = ""
                c = c & "  update prd_trans_detaildo_kirim set "
                c = c & " idkirim = '" & TIdKirim.Text & "',"
                c = c & " iddtorder = '" & TIDDtOrder.Text & "',"
                c = c & " idbarang_prd = '" & TIdBarangPRD.Text & "',"
                c = c & " idmaterial = '" & TIdMaterialPRD.Text & "',"
                c = c & " panjang_prd='" & TPanjangPRD.Text & "', "
                c = c & " lebar_prd = '" & TLebarPRD.Text & "', "
                c = c & " tinggi_prd = '" & TTinggiPRD.Text & "', "
                c = c & " sisi_prd = '" & TSisiPE.Text & "', "
                c = c & " qty_prd = '" & TQty2.Text & "',"
                c = c & " keterangan = '" & TKet2.Text & "'"
                c = c & " where idtrans = '" & TIdTrans.Text & "'"
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                MsgBox("Data Survei sudah di-EDIT !!..", MsgBoxStyle.Information, "Information")
                GGVM_conn_close()
            Case "hapusPRD"
                GGVM_conn()
                c = ""
                c = c & " delete from prd_trans_detaildo_kirim "
                c = c & " where idtrans = '" & TIdTrans.Text & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
                MsgBox("Data Survei sudah di-HAPUS !!..", MsgBoxStyle.Information, "Information")
                GGVM_conn_close()
        End Select

        'tombol 
        BtnEntry.Enabled = True
        BtnEntryS.Enabled = False
        BtnEdit.Enabled = True
        BtnEditS.Enabled = True
        BtnSimpanPE.Visible = False
        BtnSimpanS.Enabled = False
        BtnHitungPE.Visible = True
        BtnHitungPE.Enabled = False
        BtnKeluar.Caption = "KELUAR"
        TPanjangPRD.ReadOnly = True
        TLebarPRD.ReadOnly = True
        TSisiPRD.ReadOnly = True
        TTinggiPRD.ReadOnly = True
        TMaterialPRD.ReadOnly = True
        ClearPE()
        ClearPRD()

        TampilDetailDo()
        TampilKirim()
    End Sub

    Private Sub BtnEntry_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEntry.ItemClick
        Dim s As String
        GGVM_conn()
        s = "select * from prd_detail_penawaran where iddtorder ='" & TIDDtOrder.Text & "'"
        da = New OdbcDataAdapter(s, conn)
        dt = New DataTable
        dt.clear()
        da.Fill(dt)

        If TIdTrans.Text = "" Then
            For Each rs As DataRow In dt.Rows
                If IsDBNull(rs("idpe")) Then ' Null check
                    MsgBox("Pilih Barang yang akan dijadikan Penawaran !!..", MsgBoxStyle.Information, "Information")
                    Exit Sub
                ElseIf String.IsNullOrEmpty(rs("idpe").ToString()) Then ' Empty check
                    MsgBox("Ada Barang yang belum di  masukkan ke Penawaran !!..", MsgBoxStyle.Information, "Information")
                    Exit Sub
                Else
                    Entry()
                End If
            Next
            MsgBox("Pilih Salah Satu Barang Untuk Melanjutkan !!..", MsgBoxStyle.Information, "Information")
            Exit Sub
        Else
            'GGVM_conn()
            sql = ""
            sql = sql & "select idmaterial from prd_trans_detaildo_kirim "
            sql = sql & " where iddtorder ='" & TIDDtOrder.Text & "'"
            da = New OdbcDataAdapter(sql, conn)
            'ds.Clear()
            dt = New DataTable
            dt.Clear()
            da.Fill(dt)
            For Each rs As DataRow In dt.Rows
                If IsDBNull(rs("idmaterial")) Then ' Null check
                    MsgBox("Masukkan Material Barang Survei, Dahulu !!..", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
            Next
            Entry()
        End If
    End Sub

    Private Sub BtnEditS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEditS.ItemClick

        Dim ada As Boolean
        Dim jml As Integer

        ada = False
        jml = 0
        For i = 0 To ListDist.Items.Count - 1
            If ListDist.Items(i).Checked = True Then
                ada = True
                jml = jml + 1
            End If
        Next

        If ada = False Then
            MsgBox("Tidak ada data Survei per Distributor/Toko yg di-EDIT !!..", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If jml > 1 Then
            MsgBox(" Hanya 1(satu) data Survei per Distributor/Toko yg dapat di-EDIT !!..", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If

        AutoMaterialPRD()
        Select Case MsgBox(" YES --> untuk EDIT data, NO --> untuk HAPUS data ?...", MsgBoxStyle.YesNoCancel, "Question")
            Case vbYes
                Proses = "editPRD"
            Case vbNo
                Proses = "hapusPRD"
        End Select
        TMaterialPRD.ReadOnly = False
        BtnEntry.Enabled = False
        BtnEntryS.Enabled = False
        BtnEdit.Enabled = False
        BtnEditS.Enabled = False
        BtnSimpanS.Enabled = True
        BtnKeluar.Caption = "BATAL"
        TPanjangPRD.ReadOnly = False
        TLebarPRD.ReadOnly = False
        TTinggiPRD.ReadOnly = False
        TSisiPRD.ReadOnly = False
        ' TLebarPRD.ReadOnly = False
        TKet2.ReadOnly = False
        TQty2.ReadOnly = False
        TQty2.Enabled = True
        TTinggiPRD.Enabled = True
    End Sub

    Private Sub BtnRefresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRefresh.ItemClick
        TampilDetailDo()
        TampilKirim()
    End Sub

    Private Sub BtnEntryS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEntryS.ItemClick
        BtnEntry.Enabled = False
        BtnEntryS.Enabled = False
        BtnEdit.Enabled = False
        BtnEditS.Enabled = False
        BtnSimpanS.Enabled = True
        BtnKeluar.Caption = "BATAL"
        Proses = "entryPRD"
        AutoMaterialPRD()
        TMaterialPRD.ReadOnly = False
        TMaterialPRD.Text = TMaterialPE.Text
        TIdMaterialPRD.Text = TIDMaterialPE.Text
        TPanjangPRD.Text = TPanjangPE.Text
        TPanjangPRD.ReadOnly = False
        TTinggiPRD.Text = TTinggiPE.Text
        TTinggiPRD.ReadOnly = False
        TLebarPRD.Text = TLebarPE.Text
        TLebarPRD.ReadOnly = False
        TSisiPRD.Text = TSisiPRD.Text
        TSisiPRD.ReadOnly = False
        TQty2.Text = "1"
        TQty2.ReadOnly = False
        TKet2.ReadOnly = False
        TKet2.ReadOnly = False
    End Sub

    Private Sub BtnEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnEdit.ItemClick
        Dim ada As Boolean
        Dim jml As Integer

        ada = False
        jml = 0
        For i = 0 To ListDetailDO.Items.Count - 1
            If ListDetailDO.Items(i).Checked = True Then
                ada = True
                jml = jml + 1
            End If
        Next

        If ada = False Then
            MsgBox("Tidak ada data Detail DO yg di-EDIT !!..", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        If jml > 1 Then
            MsgBox(" Hanya 1(satu) data Detail DO yg dapat di-EDIT !!..", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If


        Select Case MsgBox(" YES --> untuk EDIT data, NO --> untuk HAPUS data ?...", MsgBoxStyle.YesNoCancel, "Question")
            Case vbYes
                Proses = "editPE"
                BtnEntry.Enabled = False
                AutoMaterialPE()
                BtnEntryS.Enabled = False
                BtnEdit.Enabled = False
                BtnEditS.Enabled = False
                BtnHitungPE.Enabled = True
                BtnKeluar.Caption = "BATAL"
                BtnSimpanPE.Visible = False
                CBarangPE.Enabled = True
                TMaterialPE.ReadOnly = False
                TPanjangPE.ReadOnly = False
                TLebarPE.ReadOnly = False
                TTinggiPE.ReadOnly = False
                TSisiPE.ReadOnly = False
                TJmlPE.ReadOnly = False
                THarga.ReadOnly = False
                THargaPE.ReadOnly = False
                TKeterangan.ReadOnly = False
            Case vbNo
                Proses = "hapusPE"
                BtnEntry.Enabled = False
                BtnEntryS.Enabled = False
                BtnEdit.Enabled = False
                BtnEditS.Enabled = False
                BtnHitungPE.Visible = False
                BtnSimpanPE.Visible = True
                BtnSimpanPE.Enabled = True
                BtnSimpanPE.Text = "HAPUS DETAIL"
                BtnKeluar.Caption = "BATAL"
                BtnSimpanPE.Focus()
        End Select
    End Sub

    Private Sub ListDist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDist.SelectedIndexChanged
        Dim brs As Integer
        Me.Cursor = Cursors.WaitCursor
        With Me.ListDist

            For Each item As ListViewItem In ListDist.SelectedItems
                item.Checked = True
                brs = item.Index
            Next
        End With
        TIdKirim.Text = ListDist.Items(brs).SubItems(9).Text
        TDist.Text = ListDist.Items(brs).SubItems(1).Text
        TToko.Text = ListDist.Items(brs).SubItems(2).Text
        TBarangPRD.Text = ListDist.Items(brs).SubItems(0).Text
        TIdBarangPRD.Text = ListDist.Items(brs).SubItems(10).Text
        TMaterialPRD.Text = ListDist.Items(brs).SubItems(8).Text
        TIdMaterialPRD.Text = ListDist.Items(brs).SubItems(11).Text
        TPanjangPRD.Text = ListDist.Items(brs).SubItems(4).Text
        TTinggiPRD.Text = ListDist.Items(brs).SubItems(5).Text
        TLebarPRD.Text = ListDist.Items(brs).SubItems(6).Text
        TSisiPRD.Text = ListDist.Items(brs).SubItems(7).Text
        TQty2.Text = ListDist.Items(brs).SubItems(14).Text
        TIdTrans.Text = ListDist.Items(brs).SubItems(12).Text
        TKet2.Text = ListDist.Items(brs).SubItems(13).Text
        Me.Cursor = Cursors.Default
        BtnEditS.Enabled = True
        BtnKeluar.Caption = "BATAL"
    End Sub

    Private Sub ListDetailDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDetailDO.SelectedIndexChanged
        Dim brs As Integer

        Me.Cursor = Cursors.WaitCursor
        With Me.ListDetailDO

            For Each item As ListViewItem In ListDetailDO.SelectedItems
                brs = item.Index
            Next

        End With

        TBarangPE.Text = ListDetailDO.Items(brs).SubItems(0).Text
        THarga.Text = ListDetailDO.Items(brs).SubItems(3).Text
        TPanjangPE.Text = ListDetailDO.Items(brs).SubItems(4).Text
        TTinggiPE.Text = ListDetailDO.Items(brs).SubItems(5).Text
        TLebarPE.Text = ListDetailDO.Items(brs).SubItems(6).Text
        TSizePE.Text = ListDetailDO.Items(brs).SubItems(7).Text
        TSisiPE.Text = ListDetailDO.Items(brs).SubItems(8).Text
        TMeasurePE.Text = ListDetailDO.Items(brs).SubItems(9).Text
        TJmlPE.Text = ListDetailDO.Items(brs).SubItems(10).Text
        THargaPE.Text = ListDetailDO.Items(brs).SubItems(11).Text
        TMaterialPE.Text = ListDetailDO.Items(brs).SubItems(12).Text
        TKeterangan.Text = ListDetailDO.Items(brs).SubItems(13).Text
        TIdBarangPE.Text = ListDetailDO.Items(brs).SubItems(15).Text
        TJmlTK.Text = ListDetailDO.Items(brs).SubItems(14).Text
        TIDMaterialPE.Text = ListDetailDO.Items(brs).SubItems(16).Text
        TIdDetailPE.Text = ListDetailDO.Items(brs).SubItems(17).Text
        Me.Cursor = Cursors.Default
        TampilKirim()
        'BarangPE.Checked = True
        'TBarangPE.ReadOnly = True
        BtnEdit.Enabled = True
        BtnKeluar.Caption = "BATAL"
    End Sub
End Class
