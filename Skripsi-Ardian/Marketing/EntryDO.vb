Imports System.Data.Odbc

Public Class EntryDO
    Dim DataOrder As New DataOrder
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
    End Sub

    Private Sub EntryDO_ParentChanged(sender As Object, e As EventArgs) Handles Me.ParentChanged

    End Sub
End Class
