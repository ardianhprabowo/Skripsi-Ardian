Imports System.Data.Odbc

Public Class SimulasiOrder
    Dim brs As Integer
#Region "ListView"
    Private Sub ListHeaderDO()
        ListDO.FullRowSelect = True
        ListDO.MultiSelect = True
        ListDO.View = View.Details
        ListDO.CheckBoxes = True
        ListDO.Columns.Clear()
        ListDO.Items.Clear()
        ListDO.Columns.Add("NO.ORDER", 120, HorizontalAlignment.Left)
        ListDO.Columns.Add("TANGGAL", 125, HorizontalAlignment.Left)
        ListDO.Columns.Add("KLIEN", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("BRAND", 100, HorizontalAlignment.Left)
        ListDO.Columns.Add("NAMA PROYEK", 250, HorizontalAlignment.Left)
        ListDO.Columns.Add("PROPINSI", 130, HorizontalAlignment.Left)
        ListDO.Columns.Add("KOTA", 130, HorizontalAlignment.Left)
        ListDO.Columns.Add("DEADLINE", 150, HorizontalAlignment.Left)
        ListDO.Columns.Add("iddtorder", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idklien", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idbrand", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idpropinsi", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("idkota", 0, HorizontalAlignment.Left)
        ListDO.Columns.Add("STATUS", 150, HorizontalAlignment.Left)
    End Sub
    Private Sub TampilDO()
        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable
        GGVM_conn()
        ListDO.Items.Clear()
        s = "select * from view_simulasidesign "
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        For i = 0 To tbl.Rows.Count - 1
            Dim statussimulasi As String = ""
            If tbl.Rows(i)("idstatus_proyek") = "6" Then
                statussimulasi = "Belum di-KIRIM"
            ElseIf tbl.Rows(i)("idstatus_proyek") = "8" Then
                statussimulasi = "Simulasi di-Kirim"
            ElseIf tbl.Rows(i)("idstatus_proyek") = "9" Then
                statussimulasi = "Simulasi di-Setujui"
            End If
            With ListDO
                .Items.Add(tbl.Rows(i)("noorder"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("tglorder"))
                    .Add(tbl.Rows(i)("nmklien"))
                    .Add(tbl.Rows(i)("brand"))
                    .Add(tbl.Rows(i)("namaorder"))
                    .Add(tbl.Rows(i)("propinsi"))
                    .Add(tbl.Rows(i)("kt"))
                    .Add(tbl.Rows(i)("deadline_ki"))
                    .Add(tbl.Rows(i)("iddtorder"))
                    .Add(tbl.Rows(i)("idklien"))
                    .Add(tbl.Rows(i)("idbrand"))
                    .Add(tbl.Rows(i)("idpropinsi"))
                    .Add(tbl.Rows(i)("idkota"))
                    .Add(statussimulasi)
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub
    Private Sub ListHeaderdoDetail()
        ListDetailDO.FullRowSelect = True
        ListDetailDO.MultiSelect = True
        ListDetailDO.View = View.Details
        ListDetailDO.CheckBoxes = True
        ListDetailDO.Columns.Clear()
        ListDetailDO.Items.Clear()
        ListDetailDO.Columns.Add("TOKO", 150, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("KOTA", 100, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("BARANG", 140, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("PROVINSI", 130, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("iddtorder", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("idklien", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("idbrand", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("idpropinsi", 1, HorizontalAlignment.Left)
        ListDetailDO.Columns.Add("idkota", 1, HorizontalAlignment.Left)
    End Sub
    Private Sub TampilDetailDO()
        Dim s As String
        Dim i As Integer
        Dim tbl As New DataTable
        GGVM_conn()
        ListDetailDO.Items.Clear()
        s = "select * from view_detailsimulasidesign where iddtorder = '" & ListDO.Items(brs).SubItems(8).Text & "'"
        da = New OdbcDataAdapter(s, conn)
        'ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        For i = 0 To tbl.Rows.Count - 1
            With ListDetailDO
                .Items.Add(tbl.Rows(i)("toko"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(tbl.Rows(i)("kota"))
                    .Add(tbl.Rows(i)("barang"))
                    .Add(tbl.Rows(i)("propinsi"))
                    .Add(tbl.Rows(i)("iddtorder"))
                    .Add(tbl.Rows(i)("idklien"))
                    .Add(tbl.Rows(i)("idbrand"))
                    .Add(tbl.Rows(i)("idpropinsi"))
                    .Add(tbl.Rows(i)("idkota"))
                End With
            End With
        Next
        GGVM_conn_close()
    End Sub
#End Region

    Private Sub SimulasiOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListHeaderDO()
        ListHeaderdoDetail()
        TampilDO()
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Caption = "REFRESH" Then
            TampilDO()
        ElseIf e.Button.Properties.Caption = "APPROVAL SIMULASI" Then
            Dim ada As Boolean
            Dim brs, jmldt As Integer
            Dim c As String

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
                MsgBox("Tidak ada data yang akan di-Approval, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
                ListDO.Focus()
                Exit Sub
            End If
            If jmldt > 1 Then
                MsgBox("Hanya 1(satu) data yg bisa di-Approval !!...", MsgBoxStyle.Information, "Information")
                ListDO.Focus()
                Exit Sub
            End If

            If MsgBox("Apakah anda yakin untuk Approval Data Order ?..", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                For i = 0 To ListDO.Items.Count - 1
                    If ListDO.Items(i).Checked = True Then
                        'prd terima do dr mkt
                        GGVM_conn()
                        c = ""
                        c = c & " update prd_dataorder set"
                        c = c & " idstatus_proyek = '9' "
                        c = c & " where iddtorder = '" & ListDO.Items(brs).SubItems(8).Text & "'"
                        cmd = New OdbcCommand(c, conn)
                        cmd.ExecuteNonQuery()

                        c = ""
                        c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid) values "
                        c = c & " ('" & ListDO.Items(brs).SubItems(8).Text & "','9',now(),'" & userid & "')"
                        cmd = New OdbcCommand(c, conn)
                        cmd.ExecuteNonQuery()
                        GGVM_conn_close()
                    End If
                    ListDetailDO.Items.Clear()
                Next
            End If
            TampilDO()
        ElseIf e.Button.Properties.Caption = "KIRIM SIMULASI" Then
            Dim ada As Boolean
            Dim brs, jmldt As Integer
            Dim c As String

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
                MsgBox("Tidak ada data yang akan di-KIRIM, Pilih dulu datanya!!...", MsgBoxStyle.Information, "Information")
                ListDO.Focus()
                Exit Sub
            End If
            If jmldt > 1 Then
                MsgBox("Hanya 1(satu) data yg bisa di-KIRIM !!...", MsgBoxStyle.Information, "Information")
                ListDO.Focus()
                Exit Sub
            End If

            If MsgBox("Apakah anda yakin untuk KIRIM Data Order ?..", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                For i = 0 To ListDO.Items.Count - 1
                    If ListDO.Items(i).Checked = True Then
                        'prd terima do dr mkt
                        GGVM_conn()
                        c = ""
                        c = c & " update prd_dataorder set"
                        c = c & " idstatus_proyek = '8' "
                        c = c & " where iddtorder = '" & ListDO.Items(brs).SubItems(8).Text & "'"
                        cmd = New OdbcCommand(c, conn)
                        cmd.ExecuteNonQuery()

                        c = ""
                        c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid) values "
                        c = c & " ('" & ListDO.Items(brs).SubItems(8).Text & "','8',now(),'" & userid & "')"
                        cmd = New OdbcCommand(c, conn)
                        cmd.ExecuteNonQuery()
                        GGVM_conn_close()
                    End If
                    ListDetailDO.Items.Clear()
                Next
            End If
            TampilDO()
        ElseIf e.Button.Properties.Caption = "KELUAR" Then
            Me.Dispose()
            Exit Sub
        Else
        End If
    End Sub

    Private Sub ListDO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDO.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        With Me.ListDO
            For Each check As ListViewItem In ListDO.CheckedItems
                check.Checked = False
            Next

            For Each item As ListViewItem In ListDO.SelectedItems
                item.Checked = True
                brs = item.Index
            Next
            If ListDO.Items(brs).SubItems(13).Text = "Belum di-Terima" Then
                WindowsUIButtonPanel1.Buttons.Item(1).Properties.Caption = "KIRIM SIMULASI"
            ElseIf ListDO.Items(brs).SubItems(13).Text = "Simulasi di-Kirim" Then
                WindowsUIButtonPanel1.Buttons.Item(1).Properties.Caption = "APPROVAL SIMULASI"
            ElseIf ListDO.Items(brs).SubItems(13).Text = "Simulasi di-Setujui" Then
                WindowsUIButtonPanel1.Buttons.Item(1).Properties.Caption = "SIMULASI SELESAI"
            End If
            TampilDetailDO()

        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub WindowsUIButtonPanel1_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel1.Click

    End Sub
End Class
