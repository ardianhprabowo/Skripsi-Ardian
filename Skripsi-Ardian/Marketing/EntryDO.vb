Imports System.Data.Odbc
Imports DevExpress.XtraEditors

Public Class EntryDO
    Dim DataOrder As New DataOrder

    Private Sub TampilKlien()
        GGVM_conn()
        Dim s As String
        s = ""
        s = s & " select y.* from ( select nama,id from klien"
        s = s & " where status='1'"
        s = s & " and nama like '%" & TKlien.Text & "%'"
        s = s & " order by nama ) y "
        da = New OdbcDataAdapter(s, conn)
        ds = New DataSet
        da.Fill(ds)
        Dim Klien As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Klien.Add(ds.Tables(0).Rows(i)("nama").ToString())
        Next
        With TKlien
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = Klien
            .AutoCompleteMode = AutoCompleteMode.Suggest
        End With
        GGVM_conn_close()
    End Sub
    Private Sub TampilBrand()
        GGVM_conn()
        Dim s As String
        s = ""
        s = s & " select y.* from (select brand,idbrand from brand"
        s = s & " where status='1'"
        ' s = s & " and idklien ='" & TIDKlien.Text & "'"
        s = s & " and brand like '%" & TBrand.Text & "%'"
        s = s & " order by brand ) y"
        da = New OdbcDataAdapter(s, conn)
        ds = New DataSet
        da.Fill(ds)
        Dim Brand As New AutoCompleteStringCollection
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Brand.Add(ds.Tables(0).Rows(i)("brand").ToString())
        Next
        With TBrand
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = Brand
            .AutoCompleteMode = AutoCompleteMode.Suggest
        End With
        GGVM_conn_close()
    End Sub
    Public Sub ClearInput()
        BtnSimpan.Enabled = True
        BtnSimpanToko.Enabled = True
        BtnHapusPenerima.Enabled = True
        TNoDo.Text = ""
        TidDtOrder.Text = ""
        TIDKlien.Text = ""
        TKlien.Text = ""
        TIDBrand.Text = ""
        TBrand.Text = ""
        TPenerima.Text = ""
        TProyek.Text = ""
        DTDeadlineKI.Enabled = True
        DTDeadlineKI.Format = DateTimePickerFormat.Custom
        DTDeadlineKI.CustomFormat = "dd/MM/yyyy"
        DTTanggal.Enabled = True
        DTTanggal.Format = DateTimePickerFormat.Custom
        DTTanggal.CustomFormat = "dd/MM/yyyy"
        SURVEI.Checked = False
        RadioGroup1.Enabled = True
        TProyek.Enabled = True
        SURVEI.Enabled = True
        TKlien.Enabled = True
        TBrand.Enabled = True
        CDist.Enabled = True
        CToko.Enabled = True
        TProyek.ReadOnly = False
        BtnSimpan.Enabled = True
        TPenerima.ReadOnly = True

    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim thndo, urutdo, nmProyek As String
        Dim count As Integer
        Dim tbl As DataTable
        Dim s, c As String
        Dim cmd As New OdbcCommand

        Me.Cursor = Cursors.WaitCursor
        nmProyek = replaceNewLine(TProyek.Text, True)
        Select Case Proses
            Case "entry"
                If MsgBox("Apakah anda yakin untuk menyimpan Data Order ?..", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
                    If TIDDivisi.Text = "" Then
                        Me.Cursor = Cursors.Default
                        MsgBox(" Pilih dulu DIVISI nya !!...", MsgBoxStyle.Information, "Information")
                        Exit Sub
                    End If
                    If SURVEI.Checked = True Then
                        If IDSurvei.Text = "" Then
                            Me.Cursor = Cursors.Default
                            MsgBox("Pilih dulu yang Survei....Produksi atau Marketing !!...", MsgBoxStyle.Information, "Information")
                            Exit Sub
                        End If
                    End If
                End If

                GGVM_conn()

                sql = "select nodo,tahundo from counter "
                cmd = New OdbcCommand(sql, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                thndo = Microsoft.VisualBasic.Right(DTTanggal.Text, 4)

                If thndo = dr.GetString(1) Then
                    count = dr.Item("nodo")
                Else
                    count = 0
                End If
                count = count + 1
                urutdo = Microsoft.VisualBasic.Right("00000" & count, 5)
                TNoDo.Text = urutdo

                c = ""
                If count = 1 Then
                    c = c & " update counter set nodo = '" & count & "',"
                    c = c & " tahundo = '" & Microsoft.VisualBasic.Right(DTTanggal.Text, 4) & "'"
                Else
                    c = c & " update counter set nodo = '" & count & "'"
                End If
                cmd = New OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
                c = ""
                c = c & " insert prd_dataorder (iddivisi,noorder,tglorder,idklien,"
                If TIDBrand.Text <> "" Then
                    c = c & "idbrand,"
                End If
                c = c & " namaorder,"
                If SURVEI.Checked = True Then
                    c = c & " survei, iddivisi_survei, "
                End If
                c = c & " deadline_ki,"
                c = c & " idstatus_proyek,user_input,time_input) values"
                c = c & " ('" & TIDDivisi.Text & "','" & urutdo & "','" & Format(DTTanggal.Value, "yyyy/MM/dd") & "','" & TIDKlien.Text & "',"
                If TIDBrand.Text <> "" Then
                    c = c & "'" & TIDBrand.Text & "',"
                End If
                c = c & "'" & nmProyek & "',"
                If SURVEI.Checked = True Then
                    c = c & " 'Y',"
                    c = c & " '" & IDSurvei.Text & "',"
                End If
                c = c & "'" & Format(DTDeadlineKI.Value, "yyyy/MM/dd") & "',"
                c = c & "'1','" & userid & "',now())"
                cmd = New System.Data.Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                s = ""
                s = s & " select max(iddtorder)as id from prd_dataorder "
                da = New System.Data.Odbc.OdbcDataAdapter(s, conn)
                tbl = New DataTable
                tbl.Clear()
                da.Fill(tbl)
                TidDtOrder.Text = tbl.Rows(0)("id")

                c = ""
                c = c & " insert prd_history_dataorder (iddtorder,idstatusproyek,waktu,userid) values "
                c = c & " ('" & TidDtOrder.Text & "','1',now(),'" & userid & "')"
                cmd = New System.Data.Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                GGVM_conn_close()
                Me.Cursor = Cursors.Default
                MsgBox("Data sudah diSIMPAN !!...", MsgBoxStyle.Information, "Information")
                BtnSimpan.Enabled = False

                MsgBox("Masukkan Daftar Toko !!...", MsgBoxStyle.Information, "Information")
                CDist.Enabled = True
                CToko.Enabled = True
                BtnSimpanToko.Enabled = True
                BtnHapusPenerima.Enabled = True
                'BtnEntryToko.Enabled = True

            Case "edit"

                GGVM_conn()
                c = ""
                c = c & " update prd_dataorder set "
                c = c & " iddivisi = '" & TIDDivisi.Text & "',"
                c = c & " idklien = '" & TIDKlien.Text & "',"
                If TIDBrand.Text <> "" Then
                    c = c & "idbrand = '" & TIDBrand.Text & "',"
                End If
                c = c & " namaorder = '" & nmProyek & "',"
                If SURVEI.Checked = True Then
                    c = c & " survei = 'Y',"
                    c = c & " iddivisi_survei='" & IDSurvei.Text & "',"
                End If
                c = c & " deadline_ki ='" & Format(DTDeadlineKI.Value, "yyyy/MM/dd") & "', "
                c = c & " user_koreksi ='" & userid & "',time_koreksi=now()"
                c = c & " where iddtorder = '" & TidDtOrder.Text & "'"
                cmd = New System.Data.Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
                GGVM_conn_close()
                Me.Cursor = Cursors.Default
                MsgBox("Data sudah diUPDATE !!...", MsgBoxStyle.Information, "Information")

        End Select
        'TampilDO()
        'TokoDistributor1.Enabled = True
        'ListDO.Enabled = False
        DataOrder.FlyoutPanelControl1.Controls.Clear()
        DataOrder.FlyoutPanel1.HidePopup()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs)

        Dim DataO As New DataOrder
        DataO.FlyoutPanel1.HidePopup()
        'DataO.GroupEntry.Dispose()
        Me.Dispose()

    End Sub

    Private Sub EntryDO_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed
        Me.Dispose()
    End Sub

    Private Sub EntryDO_Load(sender As Object, e As EventArgs) Handles Me.Load
        ClearInput()
        TampilKlien()
        TampilBrand()
        DTDeadlineKI.Format = DateTimePickerFormat.Custom
        DTDeadlineKI.CustomFormat = "dd/MM/yyyy"
        DTDeadlineKI.Value = DateTime.Now
    End Sub

    Private Sub TKlien_TextChanged(sender As Object, e As EventArgs) Handles TKlien.TextChanged
        Dim s As String
        GGVM_conn()
        s = "select id from klien where nama= '" & TKlien.Text & "'"
        cmd = New OdbcCommand(s, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TIDKlien.Text = ""
        Else
            TIDKlien.Text = dr.Item("id")
        End If
        GGVM_conn_close()
    End Sub

    Private Sub TBrand_TextChanged(sender As Object, e As EventArgs) Handles TBrand.TextChanged
        Dim s As String
        GGVM_conn()
        s = "select idbrand from brand where brand= '" & TBrand.Text & "'"
        cmd = New OdbcCommand(s, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            TIDBrand.Text = ""
        Else
            TIDBrand.Text = dr.Item("idbrand")
        End If
        GGVM_conn_close()
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Dim radioGroup = TryCast(sender, RadioGroup)
        If radioGroup.SelectedIndex = 0 Then
            IDSurvei.Text = "1"
        End If
        If radioGroup.SelectedIndex = 1 Then
            IDSurvei.Text = "5"
        End If
        If radioGroup.SelectedIndex = 2 Then
            IDSurvei.Text = "V"
        End If
    End Sub

    Private Sub SURVEI_CheckedChanged(sender As Object, e As EventArgs) Handles SURVEI.CheckedChanged
        If SURVEI.Checked = True Then
            RadioGroup1.Enabled = True
        Else
            RadioGroup1.Enabled = False
            RadioGroup1.EditValue = ""
            IDSurvei.Text = ""
        End If
    End Sub

    Private Sub BtnSimpanToko_Click(sender As Object, e As EventArgs) Handles BtnSimpanToko.Click
        Select Case Proses
            Case "entry"
                If TextBox1.Text = "" Then
                    MsgBox(" Simpan dulu Data Ordernya !!..", MsgBoxStyle.Information, "Information")
                    Exit Sub
                End If
                Try
                    GGVM_conn()
                    For Each item As ListViewItem In ListKota.Items
                        Dim sql As String = " INSERT INTO prd_kirim_dataorder (iddtorder,iddist,idtoko) VALUES (?, ?, ?)"
                        cmd = New OdbcCommand
                        With cmd
                            .CommandText = (sql)
                            .Parameters.Add("@iddtorder", OdbcType.VarChar).Value = TextBox1.Text
                            .Parameters.Add("@iddist", OdbcType.Double).Value = Convert.ToDouble(item.SubItems(2).Text)
                            .Parameters.Add("@idtoko", OdbcType.VarChar).Value = Convert.ToInt32(item.SubItems(3).Text)
                            .Connection = conn
                        End With
                        dr = cmd.ExecuteReader
                        Console.WriteLine(cmd.CommandText.ToString)
                        While dr.Read
                            Console.WriteLine(dr(0))
                            Console.WriteLine()
                        End While
                        Console.ReadLine()
                        ' conn.Close()
                        dr = Nothing
                        cmd = Nothing
                    Next
                    MsgBox(" Data Toko Berhasil Disimpan!..", MsgBoxStyle.Information, "Information")
                    BtnSimpanToko.Enabled = False
                    BtnHapusPenerima.Enabled = False
                    ListKota.Enabled = False
                    TPenerima.Enabled = False
                    CDist.Enabled = False
                    CToko.Enabled = False
                    'BtnEntryToko.Enabled = True
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    GGVM_conn_close()
                End Try
                'ListKota.Items.Clear()
                ClearInput()
                GridPanel.DataSource = Nothing
                BtnEntry.Enabled = True
                'BtnEdit.Enabled = True
                'BtnCetak.Enabled = True
                'TampilDO()
                BtnSimpan.Enabled = False


                TNoDo.Text = ""
                TidDtOrder.Text = ""
                TIDKlien.Text = ""
                TKlien.Text = ""
                TIDBrand.Text = ""
                TBrand.Text = ""
                TPenerima.Text = ""
                TProyek.Text = ""
                DTDeadlineKI.Format = DateTimePickerFormat.Custom
                DTDeadlineKI.CustomFormat = "dd/MM/yyyy"
                DTTanggal.Format = DateTimePickerFormat.Custom
                DTTanggal.CustomFormat = "dd/MM/yyyy"
                SURVEI.Checked = False
                TProyek.Enabled = False
                SURVEI.Enabled = False
            Case "edit"
                'ListKota.Items.Clear()
                ClearInput()
                GridPanel.DataSource = Nothing
                BtnEntry.Enabled = True
                'BtnEdit.Enabled = True
                'BtnCetak.Enabled = True
                'TampilDO()
                BtnSimpan.Enabled = False


                TNoDo.Text = ""
                TidDtOrder.Text = ""
                TIDKlien.Text = ""
                TKlien.Text = ""
                TIDBrand.Text = ""
                TBrand.Text = ""
                TPenerima.Text = ""
                TProyek.Text = ""
                DTDeadlineKI.Format = DateTimePickerFormat.Custom
                DTDeadlineKI.CustomFormat = "dd/MM/yyyy"
                DTTanggal.Format = DateTimePickerFormat.Custom
                DTTanggal.CustomFormat = "dd/MM/yyyy"
                SURVEI.Checked = False
                TProyek.Enabled = False
                SURVEI.Enabled = False


                MsgBox(" Data Toko Berhasil Disimpan!..", MsgBoxStyle.Information, "Information")
        End Select
    End Sub
End Class
