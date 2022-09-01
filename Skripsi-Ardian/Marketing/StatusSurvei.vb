Imports System.Data.Odbc

Public Class StatusSurvei
    Public Sub New()
        AddHandler DetailDataOrder.GetDataOrder, AddressOf SetLabelText
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub SetLabelText(ByVal idDO As String)
        TIDDtOrder.Text = idDO
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
        Dim tbl As New DataTable

        ListDetailDO.Items.Clear()
        'ListDist.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        GGVM_conn()
        s = ""
        s = s & " select * from view_detaildo2"
        s = s & " where iddtorder='" & TIDDtOrder.Text & "' "
        s = s & " GROUP BY iddetailpe "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListDetailDO
                .Items.Add(tbl.Rows(i)("barang"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("toko"))
                    .Add(tbl.Rows(i)("kota"))
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
                    .Add(tbl.Rows(i)("idbarang"))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("idmaterial")), "", tbl.Rows(i)("idmaterial")))
                    .Add(tbl.Rows(i)("iddetailpe"))
                    .Add(tbl.Rows(i)("SATUAN"))
                End With
            End With
        Next
        GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TampilKirim()
        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable

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
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            With ListDist
                .Items.Add(tbl.Rows(i)("barangprd"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(IIf(IsDBNull(tbl.Rows(i)("distributor")), "", tbl.Rows(i)("distributor")))
                    .Add(tbl.Rows(i)("toko"))
                    .Add(tbl.Rows(i)("kota"))
                    .Add(tbl.Rows(i)("panjang_prd"))
                    .Add(tbl.Rows(i)("tinggi_prd"))
                    .Add(tbl.Rows(i)("lebar_prd"))
                    .Add(tbl.Rows(i)("sisi_prd"))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("material")), "", tbl.Rows(i)("material")))
                    .Add(tbl.Rows(i)("idkirim"))
                    .Add(tbl.Rows(i)("idbarang_prd"))
                    .Add(IIf(IsDBNull(tbl.Rows(i)("idmaterial")), "", tbl.Rows(i)("idmaterial")))
                    .Add(tbl.Rows(i)("idtrans"))
                    .Add(tbl.Rows(i)("keterangan"))
                    .Add(tbl.Rows(i)("qty_prd"))
                End With
            End With
        Next

        'GGVM_conn_close()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TampilDO()

        Dim s, nmproyek As String
        Dim tbl As New DataTable
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
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        LabelControl2.Text = tbl.Rows(0)("noorder")
        LabelControl3.Text = tbl.Rows(0)("nmklien")
        LabelControl5.Text = tbl.Rows(0)("brand")
        nmproyek = replaceNewLine(tbl.Rows(0)("namaorder"), False)
        LabelControl7.Text = tbl.Rows(0)("namaorder")
        TIDDtOrder.Text = tbl.Rows(0)("iddtorder")
        TIdKlien.Text = tbl.Rows(0)("idklien")

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
End Class
