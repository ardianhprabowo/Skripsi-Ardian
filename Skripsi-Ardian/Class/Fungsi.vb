Imports System.Data.Odbc
Module Fungsi

    Public Sub HitungSaldoAllGdg(idnew As Double, idbarang As Double, idgdg As Integer, status As Char, jumlah As Integer)
        Dim c, s As String
        Dim tbl, tblM, tblA As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim masuk As Double
        Dim keluar As Double
        Dim IDLama As Double

        'AMBIL ID AWAL
        s = ""
        Select Case idgdg
            Case "11"
                'ATK
                s = s & " select if (max(idtrans_gdg) is null,'0',max(idtrans_gdg))as idOld "
                s = s & " from gudang_atk"
                s = s & " where idtrans_gdg < '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "12"
                'EVEN
                s = s & " select if (max(idtrans_gdg) is null,'0',max(idtrans_gdg))as idOld "
                s = s & " from gudang_even"
                s = s & " where idtrans_gdg < '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "13"
                'PRODUKSI
                s = s & " select if (max(idtrans_gdg) is null,'0',max(idtrans_gdg))as idOld "
                s = s & " from gudang_produksi"
                s = s & " where idtrans_gdg < '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "14"
                'SPG
                s = s & " select if (max(idtrans_gdg) is null,'0',max(idtrans_gdg))as idOld "
                s = s & " from gudang_spg"
                s = s & " where idtrans_gdg < '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "15"
                'IT
                s = s & " select if (max(idtrans_gdg) is null,'0',max(idtrans_gdg))as idOld "
                s = s & " from gudang_spg"
                s = s & " where idtrans_gdg < '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        IDLama = tbl.Rows(0)("idold")

        'AMBIL SALDO AWAL
        s = ""
        Select Case idgdg
            Case "11"
                'ATK
                s = s & " select if (saldo is null,'0',saldo)as saldoOld"
                s = s & " from gudang_atk"
                s = s & " where idtrans_gdg = '" & tbl.Rows(0)("idOld") & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "12"
                'EVEN
                s = s & " select if (saldo is null,'0',saldo)as saldoOld"
                s = s & " from gudang_even"
                s = s & " where idtrans_gdg = '" & tbl.Rows(0)("idOld") & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "13"
                'PRODUKSI
                s = s & " select if (saldo is null,'0',saldo)as saldoOld"
                s = s & " from gudang_produksi"
                s = s & " where idtrans_gdg = '" & tbl.Rows(0)("idOld") & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "14"
                'SPG
                s = s & " select if (saldo is null,'0',saldo)as saldoOld"
                s = s & " from gudang_spg"
                s = s & " where idtrans_gdg = '" & tbl.Rows(0)("idOld") & "'"
                s = s & " and idbarang='" & idbarang & "'"
            Case "15"
                'IT
                s = s & " select if (saldo is null,'0',saldo)as saldoOld"
                s = s & " from gudang_it"
                s = s & " where idtrans_gdg = '" & tbl.Rows(0)("idOld") & "'"
                s = s & " and idbarang='" & idbarang & "'"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tblA = New DataTable
        tblA.Clear()
        da.Fill(tblA)
        If IDLama = 0 Then
            saldoawal = 0
        Else
            saldoawal = tblA.Rows(0)("saldoOld")
        End If

        'HITUNG SALDO
        s = ""
        Select Case idgdg
            Case "11"
                'ATK
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar, count(*)as ada"
                s = s & " from gudang_atk"
                s = s & " where idtrans_gdg >= '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
                s = s & " GROUP BY idtrans_gdg,jumlah_masuk,jumlah_keluar order by tanggal,idtrans_gdg "
            Case "12"
                'EVEN
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar, count(*)as ada"
                s = s & " from gudang_even"
                s = s & " where idtrans_gdg >= '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
                s = s & " GROUP BY idtrans_gdg,jumlah_masuk,jumlah_keluar order by tanggal,idtrans_gdg "
            Case "13"
                'PRODUKSI
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar, count(*)as ada"
                s = s & " from gudang_produksi"
                s = s & " where idtrans_gdg >= '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
                s = s & " GROUP BY idtrans_gdg,jumlah_masuk,jumlah_keluar order by tanggal,idtrans_gdg "
            Case "14"
                'SPG
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar, count(*)as ada"
                s = s & " from gudang_spg"
                s = s & " where idtrans_gdg >= '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
                s = s & " GROUP BY idtrans_gdg,jumlah_masuk,jumlah_keluar order by tanggal,idtrans_gdg "
            Case "15"
                'IT
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar, count(*)as ada"
                s = s & " from gudang_it"
                s = s & " where idtrans_gdg >= '" & idnew & "'"
                s = s & " and idbarang='" & idbarang & "'"
                s = s & " GROUP BY idtrans_gdg,jumlah_masuk,jumlah_keluar order by tanggal,idtrans_gdg "
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            masuk = tbl.Rows(i)("masuk")
            keluar = tbl.Rows(i)("keluar")
            saldonow = saldoawal + masuk - keluar

            c = ""
            Select Case idgdg
                Case "11"
                    'GUDANG ATK
                    c = c & " update gudang_atk"
                    c = c & " set saldo = '" & saldonow & "'"
                    c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                Case "12"
                    'GUDANG EVEN
                    c = c & " update gudang_even"
                    c = c & " set saldo = '" & saldonow & "'"
                    c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                Case "13"
                    'GUDANG PRODUKSI
                    c = c & " update gudang_produksi"
                    c = c & " set saldo = '" & saldonow & "'"
                    c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                Case "14"
                    'GUDANG SPG
                    c = c & " update gudang_spg"
                    c = c & " set saldo = '" & saldonow & "'"
                    c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                Case "15"
                    'GUDANG IT
                    c = c & " update gudang_it"
                    c = c & " set saldo = '" & saldonow & "'"
                    c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
            End Select
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
            saldoawal = saldonow
        Next

        'update MASTER
        s = ""
        Select Case idgdg
            Case "11"
                'ATK
                s = s & " select total_masuk,total_keluar from master_barang_atk "
                s = s & " where idbarang='" & idbarang & "'"
            Case "12"
                'EVEN
                s = s & " select total_masuk,total_keluar from master_barang_even "
                s = s & " where idbarang='" & idbarang & "'"
            Case "13"
                'PRODUKSI
                s = s & " select total_masuk,total_keluar from master_barang_produksi "
                s = s & " where idbarang='" & idbarang & "'"
            Case "14"
                'SPG
                s = s & " select total_masuk,total_keluar from master_barang_spg "
                s = s & " where idbarang='" & idbarang & "'"
            Case "15"
                'IT
                s = s & " select total_masuk,total_keluar from master_barang_it "
                s = s & " where idbarang='" & idbarang & "'"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tblM = New DataTable
        tblM.Clear()
        da.Fill(tblM)

        Dim ttlM, ttlK, ttlS As Integer
        ttlM = tblM.Rows(0)("total_masuk")
        ttlK = tblM.Rows(0)("total_keluar")
        If status = "0" Then
            ttlK = ttlK + jumlah
        Else
            ttlM = ttlM + jumlah
        End If
        ttlS = ttlM - ttlK

        c = ""
        Select Case idgdg
            Case "11"
                'GUDANG ATK
                c = c & " update master_barang_atk"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "12"
                'GUDANG EVEN
                c = c & " update master_barang_even"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "13"
                'GUDANG PRODUKSI
                c = c & " update master_barang_produksi"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "14"
                'GUDANG SPG
                c = c & " update master_barang_spg"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "15"
                'GUDANG IT
                c = c & " update master_barang_it"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
        End Select
        cmd = New Odbc.OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()


    End Sub
    Public Sub HitungSaldoTrans(idnew As Double, idbarang As Double, idgdg As Integer, status As Char, jumlah As Integer, tglT As Date)
        Dim c, s As String
        Dim tbl, tblM, tblA As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim masuk As Double
        Dim keluar As Double
        ' Dim IDLama As Double

        'AMBIL SALDO AWAL
        's = ""
        'Select Case idgdg
        '    Case "11"
        '        'ATK
        '        s = s & " select if (saldo is null,'0',saldo)as saldoOld"
        '        s = s & " from gudang_atk"
        '        s = s & " where idtrans_gdg = '" & idnew & "'"
        '        s = s & " and idbarang='" & idbarang & "'"
        '    Case "12"
        '        'EVEN
        '        s = s & " select if (saldo is null,'0',saldo)as saldoOld"
        '        s = s & " from gudang_even"
        '        s = s & " where idtrans_gdg = '" & idnew & "'"
        '        s = s & " and idbarang='" & idbarang & "'"
        '    Case "13"
        '        'PRODUKSI
        '        s = s & " select if (saldo is null,'0',saldo)as saldoOld"
        '        s = s & " from gudang_produksi"
        '        s = s & " where idtrans_gdg = '" & idnew & "'"
        '        s = s & " and idbarang='" & idbarang & "'"
        '    Case "14"
        '        'SPG
        '        s = s & " select if (saldo is null,'0',saldo)as saldoOld"
        '        s = s & " from gudang_spg"
        '        s = s & " where idtrans_gdg = '" & idnew & "'"
        '        s = s & " and idbarang='" & idbarang & "'"
        '    Case "15"
        '        'IT
        '        s = s & " select if (saldo is null,'0',saldo)as saldoOld"
        '        s = s & " from gudang_it"
        '        s = s & " where idtrans_gdg = '" & idnew & "'"
        '        s = s & " and idbarang='" & idbarang & "'"
        'End Select
        'da = New Odbc.OdbcDataAdapter(s, conn)
        'ds.Clear()
        'tblA = New DataTable
        'tblA.Clear()
        'da.Fill(tblA)

        'saldoawal = tblA.Rows(0)("saldoOld")

        'HITUNG SALDO
        s = ""
        Select Case idgdg
            Case "11"
                'ATK
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar,saldo"
                s = s & " from gudang_atk"
                s = s & " where idbarang = '" & idbarang & "'"
                s = s & " and tanggal >= '" & Format(tglT, "yyyy/MM/dd") & "' "
                's = s & " and idtrans_gdg >= '" & idnew & "'"
                s = s & " order by tanggal,idtrans_gdg"
            Case "12"
                'EVEN
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar,saldo"
                s = s & " from gudang_even"
                s = s & " where idbarang = '" & idbarang & "'"
                s = s & " and tanggal >= '" & Format(tglT, "yyyy/MM/dd") & "' "
                ' s = s & " and idtrans_gdg >= '" & idnew & "'"
                s = s & " order by tanggal,idtrans_gdg"
            Case "13"
                'PRODUKSI
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar,saldo"
                s = s & " from gudang_produksi"
                s = s & " where idbarang = '" & idbarang & "'"
                s = s & " and tanggal >= '" & Format(tglT, "yyyy/MM/dd") & "' "
                's = s & " and idtrans_gdg >= '" & idnew & "'"
                s = s & " order by tanggal,idtrans_gdg"
            Case "14"
                'SPG
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar,saldo"
                s = s & " from gudang_spg"
                s = s & " where idbarang = '" & idbarang & "'"
                s = s & " and tanggal >= '" & Format(tglT, "yyyy/MM/dd") & "' "
                's = s & " and idtrans_gdg >= '" & idnew & "'"
                s = s & " order by tanggal,idtrans_gdg"
            Case "15"
                'IT
                s = s & " select idtrans_gdg,if (jumlah_masuk is null,'0',jumlah_masuk)as masuk,"
                s = s & " if(jumlah_keluar is null,'0',jumlah_keluar)as keluar,saldo"
                s = s & " from gudang_it"
                s = s & " where idbarang = '" & idbarang & "'"
                s = s & " and tanggal >= '" & Format(tglT, "yyyy/MM/dd") & "' "
                's = s & " and idtrans_gdg >= '" & idnew & "'"
                s = s & " order by tanggal,idtrans_gdg"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            If i = 0 Then
                saldoawal = tbl.Rows(0)("saldo")
            Else
                masuk = tbl.Rows(i)("masuk")
                keluar = tbl.Rows(i)("keluar")
                saldonow = saldoawal + masuk - keluar

                c = ""
                Select Case idgdg
                    Case "11"
                        'GUDANG ATK
                        c = c & " update gudang_atk"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                    Case "12"
                        'GUDANG EVEN
                        c = c & " update gudang_even"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                    Case "13"
                        'GUDANG PRODUKSI
                        c = c & " update gudang_produksi"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                    Case "14"
                        'GUDANG SPG
                        c = c & " update gudang_spg"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                    Case "15"
                        'GUDANG IT
                        c = c & " update gudang_it"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idtrans_gdg = '" & tbl.Rows(i)("idtrans_gdg") & "'"
                End Select
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()
                saldoawal = saldonow
            End If
        Next

        'update MASTER
        s = ""
        Select Case idgdg
            Case "11"
                'ATK
                s = s & " select total_masuk,total_keluar from master_barang_atk "
                s = s & " where idbarang='" & idbarang & "'"
            Case "12"
                'EVEN
                s = s & " select total_masuk,total_keluar from master_barang_even "
                s = s & " where idbarang='" & idbarang & "'"
            Case "13"
                'PRODUKSI
                s = s & " select total_masuk,total_keluar from master_barang_produksi "
                s = s & " where idbarang='" & idbarang & "'"
            Case "14"
                'SPG
                s = s & " select total_masuk,total_keluar from master_barang_spg "
                s = s & " where idbarang='" & idbarang & "'"
            Case "15"
                'IT
                s = s & " select total_masuk,total_keluar from master_barang_it "
                s = s & " where idbarang='" & idbarang & "'"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tblM = New DataTable
        tblM.Clear()
        da.Fill(tblM)

        Dim ttlM, ttlK, ttlS As Integer
        ttlM = tblM.Rows(0)("total_masuk")
        ttlK = tblM.Rows(0)("total_keluar")
        If status = "0" Then
            ttlK = ttlK + jumlah
        Else
            ttlM = ttlM + jumlah
        End If
        ttlS = ttlM - ttlK

        c = ""
        Select Case idgdg
            Case "11"
                'GUDANG ATK
                c = c & " update master_barang_atk"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "12"
                'GUDANG EVEN
                c = c & " update master_barang_even"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "13"
                'GUDANG PRODUKSI
                c = c & " update master_barang_produksi"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "14"
                'GUDANG SPG
                c = c & " update master_barang_spg"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
            Case "15"
                'GUDANG IT
                c = c & " update master_barang_it"
                c = c & " set saldo = '" & ttlS & "',"
                c = c & " total_masuk = '" & ttlM & "',"
                c = c & " total_keluar = '" & ttlK & "'"
                c = c & " where idbarang = '" & idbarang & "'"
        End Select
        cmd = New Odbc.OdbcCommand(c, conn)
        cmd.ExecuteNonQuery()


    End Sub
    Public Function bulan(tgl As String)
        Dim bln, romawi As String

        bln = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(tgl, 5), 2)
        romawi = ""
        Select Case bln
            Case "01"
                romawi = "I"
            Case "02"
                romawi = "II"
            Case "03"
                romawi = "III"
            Case "04"
                romawi = "IV"
            Case "05"
                romawi = "V"
            Case "06"
                romawi = "VI"
            Case "07"
                romawi = "VII"
            Case "08"
                romawi = "VIII"
            Case "09"
                romawi = "IX"
            Case "10"
                romawi = "X"
            Case "11"
                romawi = "XI"
            Case "12"
                romawi = "XII"
        End Select
        Return romawi
    End Function
    Public Function bulanInd(tgl As String)
        Dim bln, nmbln As String

        bln = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(tgl, 5), 2)
        nmbln = ""
        Select Case bln
            Case "01"
                nmbln = "JANUARI"
            Case "02"
                nmbln = "FEBRUARI"
            Case "03"
                nmbln = "MARET"
            Case "04"
                nmbln = "APRIL"
            Case "05"
                nmbln = "MEI"
            Case "06"
                nmbln = "JUNI"
            Case "07"
                nmbln = "JULI"
            Case "08"
                nmbln = "AGUSTUS"
            Case "09"
                nmbln = "SEPTEMBER"
            Case "10"
                nmbln = "OKTOBER"
            Case "11"
                nmbln = "NOVEMBER"
            Case "12"
                nmbln = "DESEMBER"
        End Select
        Return nmbln
    End Function

    Public Function replaceNewLine(ByVal selContent As String, ByVal isReplacingNewLineWithChar As Boolean,
                                    Optional ByVal selNewLineStringToUse As String = ".:.myCooLvbNewLine.:.") As String
        If isReplacingNewLineWithChar Then : Return selContent.Replace(vbNewLine, selNewLineStringToUse)
        Else : Return selContent.Replace(selNewLineStringToUse, vbNewLine)
        End If
    End Function

    Public Sub HitungSaldoDeposit(idMax As Double, tglIn As Date)
        Dim c, s As String
        Dim tbl As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim masuk As Double
        Dim keluar As Double

        'ambil saldo awal
        's = ""
        's = s & " select saldo"
        's = s & " from hrd_bank_deposit"
        's = s & " where idbank = '" & idMax & "'"
        'da = New Odbc.OdbcDataAdapter(s, conn)
        'ds.Clear()
        'tbl = New DataTable
        'tbl.Clear()
        'da.Fill(tbl)
        'saldoawal = tbl.Rows(0)("saldo")

        s = ""
        s = s & " select idbank as id,masuk,keluar,saldo"
        s = s & " from hrd_bank_deposit"
        ' s = s & " where idbank >= '" & idMax & "'"
        s = s & " where tanggal >= '" & Format(tglIn, "yyyy/MM/dd") & "'"
        s = s & " order by tanggal,idbank"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            If i = 0 Then
                saldoawal = tbl.Rows(i)("saldo")
            Else
                masuk = tbl.Rows(i)("masuk")
                keluar = tbl.Rows(i)("keluar")
                saldonow = saldoawal + masuk - keluar

                c = ""
                c = c & " update hrd_bank_deposit"
                c = c & " set saldo = '" & saldonow & "'"
                c = c & " where idbank = '" & tbl.Rows(i)("id") & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                saldoawal = saldonow
            End If
        Next
    End Sub


    Public Function Terbilang(ByVal nilai As Long) As String

        Dim bilangan As String() = {" ", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas"}

        If nilai < 12 Then

            Return " " & bilangan(nilai)

        ElseIf nilai < 20 Then

            Return Terbilang(nilai - 10) & " Belas"

        ElseIf nilai < 100 Then

            Return (Terbilang(CInt((nilai \ 10))) & " Puluh") + Terbilang(nilai Mod 10)

        ElseIf nilai < 200 Then

            Return " Seratus" & Terbilang(nilai - 100)

        ElseIf nilai < 1000 Then

            Return (Terbilang(CInt((nilai \ 100))) & " Ratus") + Terbilang(nilai Mod 100)

        ElseIf nilai < 2000 Then

            Return " Seribu" & Terbilang(nilai - 1000)

        ElseIf nilai < 1000000 Then

            Return (Terbilang(CInt((nilai \ 1000))) & " Ribu") + Terbilang(nilai Mod 1000)

        ElseIf nilai < 1000000000 Then

            Return (Terbilang(CInt((nilai \ 1000000))) & " Juta") + Terbilang(nilai Mod 1000000)

        ElseIf nilai < 1000000000000 Then

            Return (Terbilang(CInt((nilai \ 1000000000))) & " Milyar") + Terbilang(nilai Mod 1000000000)

        ElseIf nilai < 1000000000000000 Then

            Return (Terbilang(CInt((nilai \ 1000000000000))) & " Trilyun") + Terbilang(nilai Mod 1000000000000)

        Else

            Return ""

        End If

    End Function
    Public Sub HitungSaldoAll_TglMKB(idbank As Integer, tgl As Date)
        Dim c, s As String
        Dim tbl As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim debit As Double
        Dim kredit As Double

        s = ""
        Select Case idbank
            Case "31"
                s = s & " select idbank31 as id,debit,kredit,saldo"
                s = s & " from bank31"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank31"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            If i = 0 Then
                saldoawal = tbl.Rows(i)("saldo")
            Else
                debit = tbl.Rows(i)("debit")
                kredit = tbl.Rows(i)("kredit")
                saldonow = saldoawal - debit + kredit

                c = ""
                Select Case idbank
                    Case "31"
                        c = c & " update bank31"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank31 = '" & tbl.Rows(i)("id") & "'"
                End Select
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                c = ""
                c = c & " update bank set saldo = '" & saldonow & "'"
                c = c & " where idbank='" & idbank & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                saldoawal = saldonow
            End If
        Next
    End Sub
    Public Sub HitungSaldoAll_TglBIG(idbank As Integer, tgl As Date)
        Dim c, s As String
        Dim tbl As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim debit As Double
        Dim kredit As Double

        s = ""
        Select Case idbank
            Case "16"
                s = s & " select idbank16 as id,debit,kredit,saldo"
                s = s & " from bank16"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank16"
            Case "17"
                s = s & " select idbank17 as id,debit,kredit,saldo"
                s = s & " from bank17"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank17"
            Case "18"
                s = s & " select idbank18 as id,debit,kredit,saldo"
                s = s & " from bank18"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank18"
            Case "19"
                s = s & " select idbank19 as id,debit,kredit,saldo"
                s = s & " from bank19"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank19"
            Case "20"
                s = s & " select idbank20 as id,debit,kredit,saldo"
                s = s & " from bank20"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank20"
            Case "21"
                s = s & " select idbank21 as id,debit,kredit,saldo"
                s = s & " from bank21"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank21"
            Case "22"
                s = s & " select idbank22 as id,debit,kredit,saldo"
                s = s & " from bank22"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank22"
            Case "23"
                s = s & " select idbank23 as id,debit,kredit,saldo"
                s = s & " from bank23"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank23"
            Case "24"
                s = s & " select idbank24 as id ,debit,kredit,saldo"
                s = s & " from bank24"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank24"
            Case "25"
                s = s & " select idbank25 as id,debit,kredit,saldo"
                s = s & " from bank25"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank25"
            Case "26"
                s = s & " select idbank26 as id,debit,kredit,saldo"
                s = s & " from bank26"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank26"
            Case "27"
                s = s & " select idbank27 as id,debit,kredit,saldo"
                s = s & " from bank27"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank27"
            Case "28"
                s = s & " select idbank28 as id,debit,kredit,saldo"
                s = s & " from bank28"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank28"
            Case "29"
                s = s & " select idbank29 as id,debit,kredit,saldo"
                s = s & " from bank29"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank29"
            Case "30"
                s = s & " select idbank30 as id,debit,kredit,saldo"
                s = s & " from bank30"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank30"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            If i = 0 Then
                saldoawal = tbl.Rows(i)("saldo")
            Else
                debit = tbl.Rows(i)("debit")
                kredit = tbl.Rows(i)("kredit")
                saldonow = saldoawal - debit + kredit

                c = ""
                Select Case idbank
                    Case "16"
                        c = c & " update bank16"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank16 = '" & tbl.Rows(i)("id") & "'"
                    Case "17"
                        c = c & " update bank17"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank17 = '" & tbl.Rows(i)("id") & "'"
                    Case "18"
                        c = c & " update bank18"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank18 = '" & tbl.Rows(i)("id") & "'"
                    Case "19"
                        c = c & " update bank19"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank19 = '" & tbl.Rows(i)("id") & "'"
                    Case "20"
                        c = c & " update bank20"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank20 = '" & tbl.Rows(i)("id") & "'"
                    Case "21"
                        c = c & " update bank21"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank21 = '" & tbl.Rows(i)("id") & "'"
                    Case "22"
                        c = c & " update bank22"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank22 = '" & tbl.Rows(i)("id") & "'"
                    Case "23"
                        c = c & " update bank23"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank23 = '" & tbl.Rows(i)("id") & "'"
                    Case "24"
                        c = c & " update bank24"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank24 = '" & tbl.Rows(i)("id") & "'"
                    Case "25"
                        c = c & " update bank25"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank25 = '" & tbl.Rows(i)("id") & "'"
                    Case "26"
                        c = c & " update bank26"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank26 = '" & tbl.Rows(i)("id") & "'"
                    Case "27"
                        c = c & " update bank27"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank27 = '" & tbl.Rows(i)("id") & "'"
                    Case "28"
                        c = c & " update bank28"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank28 = '" & tbl.Rows(i)("id") & "'"
                    Case "29"
                        c = c & " update bank29"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank29 = '" & tbl.Rows(i)("id") & "'"
                    Case "30"
                        c = c & " update bank30"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank30 = '" & tbl.Rows(i)("id") & "'"
                End Select
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                c = ""
                c = c & " update bank set saldo = '" & saldonow & "'"
                c = c & " where idbank='" & idbank & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                saldoawal = saldonow
            End If
        Next
    End Sub
    Public Sub HitungSaldoAll_Tgl(idbank As Integer, tgl As Date)
        Dim c, s As String
        Dim tbl As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim debit As Double
        Dim kredit As Double

        s = ""
        Select Case idbank
            Case "1"
                s = s & " select idkastunai as id,debit,kredit,saldo"
                s = s & " from kas_tunai"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idkastunai"
            Case "2"
                s = s & " select idkastransf as id,debit,kredit,saldo"
                s = s & " from kas_transfer"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idkastransf"
            Case "3"
                s = s & " select idbank03 as id,debit,kredit,saldo"
                s = s & " from bank03"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank03"
            Case "4"
                s = s & " select idbank04 as id,debit,kredit,saldo"
                s = s & " from bank04"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank04"
            Case "5"
                s = s & " select idbank05 as id,debit,kredit,saldo"
                s = s & " from bank05"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank05"
            Case "6"
                s = s & " select idbank06 as id,debit,kredit,saldo"
                s = s & " from bank06"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank06"
            Case "7"
                s = s & " select idbank07 as id,debit,kredit,saldo"
                s = s & " from bank07"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank07"
            Case "8"
                s = s & " select idbank08 as id,debit,kredit,saldo"
                s = s & " from bank08"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank08"
            Case "9"
                s = s & " select idbank09 as id ,debit,kredit,saldo"
                s = s & " from bank09"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank09"
            Case "10"
                s = s & " select idbank10 as id,debit,kredit,saldo"
                s = s & " from bank10"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank10"
            Case "11"
                s = s & " select idbank11 as id,debit,kredit,saldo"
                s = s & " from bank11"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank11"
            Case "12"
                s = s & " select idbank12 as id,debit,kredit,saldo"
                s = s & " from bank12"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank12"
            Case "13"
                s = s & " select idbank13 as id,debit,kredit,saldo"
                s = s & " from bank13"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank13"
            Case "14"
                s = s & " select idbank14 as id,debit,kredit,saldo"
                s = s & " from bank14"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank14"
            Case "15"
                s = s & " select idbank15 as id,debit,kredit,saldo"
                s = s & " from bank15"
                s = s & " where tanggal >= '" & Format(tgl, "yyyy/MM/dd") & "'"
                s = s & " order by tanggal,idbank15"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            If i = 0 Then
                saldoawal = tbl.Rows(i)("saldo")
            Else
                debit = tbl.Rows(i)("debit")
                kredit = tbl.Rows(i)("kredit")
                saldonow = saldoawal - debit + kredit

                c = ""
                Select Case idbank
                    Case "1"
                        c = c & " update kas_tunai"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idkastunai = '" & tbl.Rows(i)("id") & "'"
                    Case "2"
                        c = c & " update kas_transfer"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idkastransf = '" & tbl.Rows(i)("id") & "'"
                    Case "3"
                        c = c & " update bank03"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank03 = '" & tbl.Rows(i)("id") & "'"
                    Case "4"
                        c = c & " update bank04"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank04 = '" & tbl.Rows(i)("id") & "'"
                    Case "5"
                        c = c & " update bank05"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank05 = '" & tbl.Rows(i)("id") & "'"
                    Case "6"
                        c = c & " update bank06"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank06 = '" & tbl.Rows(i)("id") & "'"
                    Case "7"
                        c = c & " update bank07"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank07 = '" & tbl.Rows(i)("id") & "'"
                    Case "8"
                        c = c & " update bank08"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank08 = '" & tbl.Rows(i)("id") & "'"
                    Case "9"
                        c = c & " update bank09"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank09 = '" & tbl.Rows(i)("id") & "'"
                    Case "10"
                        c = c & " update bank10"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank10 = '" & tbl.Rows(i)("id") & "'"
                    Case "11"
                        c = c & " update bank11"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank11 = '" & tbl.Rows(i)("id") & "'"
                    Case "12"
                        c = c & " update bank12"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank12 = '" & tbl.Rows(i)("id") & "'"
                    Case "13"
                        c = c & " update bank13"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank13 = '" & tbl.Rows(i)("id") & "'"
                    Case "14"
                        c = c & " update bank14"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank14 = '" & tbl.Rows(i)("id") & "'"
                    Case "15"
                        c = c & " update bank15"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank15 = '" & tbl.Rows(i)("id") & "'"
                End Select
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                c = ""
                c = c & " update bank set saldo = '" & saldonow & "'"
                c = c & " where idbank='" & idbank & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                saldoawal = saldonow
            End If
        Next
    End Sub
    Public Sub HitungSaldoAll(idbank As Integer, idold As Double)
        Dim c, s As String
        Dim tbl As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand
        Dim i As Integer
        Dim debit As Double
        Dim kredit As Double

        s = ""
        Select Case idbank
            Case "1"
                s = s & " select idkastunai as id,debit,kredit,saldo"
                s = s & " from kas_tunai"
                s = s & " where idkastunai >= '" & idold & "'"
                s = s & " order by tanggal,idkastunai"
            Case "2"
                s = s & " select idkastransf as id,debit,kredit,saldo"
                s = s & " from kas_transfer"
                s = s & " where idkastransf >= '" & idold & "'"
                s = s & " order by tanggal,idkastransf"
            Case "3"
                s = s & " select idbank03 as id,debit,kredit,saldo"
                s = s & " from bank03"
                s = s & " where idbank03 >= '" & idold & "'"
                s = s & " order by tanggal,idbank03"
            Case "4"
                s = s & " select idbank04 as id,debit,kredit,saldo"
                s = s & " from bank04"
                s = s & " where idbank04 >= '" & idold & "'"
                s = s & " order by tanggal,idbank04"
            Case "5"
                s = s & " select idbank05 as id,debit,kredit,saldo"
                s = s & " from bank05"
                s = s & " where idbank05 >= '" & idold & "'"
                s = s & " order by tanggal,idbank05"
            Case "6"
                s = s & " select idbank06 as id,debit,kredit,saldo"
                s = s & " from bank06"
                s = s & " where idbank06 >= '" & idold & "'"
                s = s & " order by tanggal,idbank06"
            Case "7"
                s = s & " select idbank07 as id,debit,kredit,saldo"
                s = s & " from bank07"
                s = s & " where idbank07 >= '" & idold & "'"
                s = s & " order by tanggal,idbank07"
            Case "8"
                s = s & " select idbank08 as id,debit,kredit,saldo"
                s = s & " from bank08"
                s = s & " where idbank08 >= '" & idold & "'"
                s = s & " order by tanggal,idbank08"
            Case "9"
                s = s & " select idbank09 as id ,debit,kredit,saldo"
                s = s & " from bank09"
                s = s & " where idbank09 >= '" & idold & "'"
                s = s & " order by tanggal,idbank09"
            Case "10"
                s = s & " select idbank10 as id,debit,kredit,saldo"
                s = s & " from bank10"
                s = s & " where idbank10 >= '" & idold & "'"
                s = s & " order by tanggal,idbank10"
            Case "11"
                s = s & " select idbank11 as id,debit,kredit,saldo"
                s = s & " from bank11"
                s = s & " where idbank11 >= '" & idold & "'"
                s = s & " order by tanggal,idbank11"
            Case "12"
                s = s & " select idbank12 as id,debit,kredit,saldo"
                s = s & " from bank12"
                s = s & " where idbank12 >= '" & idold & "'"
                s = s & " order by tanggal,idbank12"
        End Select
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)

        For i = 0 To tbl.Rows.Count - 1
            If i = 0 Then
                saldoawal = tbl.Rows(i)("saldo")
            Else
                debit = tbl.Rows(i)("debit")
                kredit = tbl.Rows(i)("kredit")
                saldonow = saldoawal - debit + kredit

                c = ""
                Select Case idbank
                    Case "1"
                        c = c & " update kas_tunai"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idkastunai = '" & tbl.Rows(i)("id") & "'"
                    Case "2"
                        c = c & " update kas_transfer"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idkastransf = '" & tbl.Rows(i)("id") & "'"
                    Case "3"
                        c = c & " update bank03"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank03 = '" & tbl.Rows(i)("id") & "'"
                    Case "4"
                        c = c & " update bank04"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank04 = '" & tbl.Rows(i)("id") & "'"
                    Case "5"
                        c = c & " update bank05"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank05 = '" & tbl.Rows(i)("id") & "'"
                    Case "6"
                        c = c & " update bank06"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank06 = '" & tbl.Rows(i)("id") & "'"
                    Case "7"
                        c = c & " update bank07"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank07 = '" & tbl.Rows(i)("id") & "'"
                    Case "8"
                        c = c & " update bank08"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank08 = '" & tbl.Rows(i)("id") & "'"
                    Case "9"
                        c = c & " update bank09"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank09 = '" & tbl.Rows(i)("id") & "'"
                    Case "10"
                        c = c & " update bank10"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank10 = '" & tbl.Rows(i)("id") & "'"
                    Case "11"
                        c = c & " update bank11"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank11 = '" & tbl.Rows(i)("id") & "'"
                    Case "12"
                        c = c & " update bank12"
                        c = c & " set saldo = '" & saldonow & "'"
                        c = c & " where idbank12 = '" & tbl.Rows(i)("id") & "'"
                End Select
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                c = ""
                c = c & " update bank set saldo = '" & saldonow & "'"
                c = c & " where idbank='" & idbank & "'"
                cmd = New Odbc.OdbcCommand(c, conn)
                cmd.ExecuteNonQuery()

                saldoawal = saldonow
            End If
        Next
    End Sub
    Public Sub HitungSaldo(idbank As Integer, debit As Double, kredit As Double, id As Double, idold As Double)
        Dim c, s As String
        Dim tbl As New DataTable
        Dim saldoawal As Double
        Dim saldonow As Double
        Dim cmd As New OdbcCommand

        If idbank = 1 Then
            'Kas Tunai
            s = ""
            s = s & " select saldo from kas_tunai where idkastunai = '" & idold & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tbl = New DataTable
            tbl.Clear()
            da.Fill(tbl)
            saldoawal = tbl.Rows(0)("saldo")
            saldonow = saldoawal - debit + kredit

            c = ""
            c = c & " update kas_tunai set saldo = '" & saldonow & "'"
            c = c & " where idkastunai='" & id & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " update bank set saldo = '" & saldonow & "'"
            c = c & " where idbank='" & idbank & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

        End If

        If idbank = 2 Then
            'Kas Tunai
            s = ""
            s = s & " select saldo from kas_transfer where idkastransf = '" & idold & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tbl = New DataTable
            tbl.Clear()
            da.Fill(tbl)
            saldoawal = tbl.Rows(0)("saldo")
            saldonow = saldoawal - debit + kredit

            c = ""
            c = c & " update kas_transfer set saldo = '" & saldonow & "'"
            c = c & " where idkastransf='" & id & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " update bank set saldo = '" & saldonow & "'"
            c = c & " where idbank='" & idbank & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

        End If
    End Sub
    Public Sub HitungSaldoKartu(idmaster As Integer, idkartu As Double)
        Dim c, s As String
        Dim tbl, tblO As New DataTable
        Dim Xmasuk, Xqtymasuk, XKeluar, Xqtykeluar As Double
        Dim Mmasuk, Mqtymasuk, MKeluar, Mqtykeluar As Double
        Dim SrpOld, SqtyOld, YSaldo_rp, YSaldo_qty As Double
        Dim cmd As New OdbcCommand
        Dim idOld As Double

        s = ""
        s = s & " select * from kartu_stok_pengajuan13"
        s = s & " where idmaster = '" & idmaster & "'"
        s = s & " and idkartu = '" & idkartu & "'"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        Xmasuk = tbl.Rows(0)("masuk")
        Xqtymasuk = tbl.Rows(0)("qty_masuk")
        XKeluar = tbl.Rows(0)("keluar")
        Xqtykeluar = tbl.Rows(0)("qty_keluar")

        s = ""
        s = s & " select if(max(idkartu) is null,0,max(idkartu))as MaxKartu from kartu_stok_pengajuan13"
        s = s & " where idmaster = '" & idmaster & "'"
        s = s & " and idkartu < '" & idkartu & "'"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If tbl.Rows(0)("maxkartu") = 0 Then
            c = ""
            c = c & " update kartu_stok_pengajuan13 set "
            c = c & " saldo ='" & Xmasuk & "',"
            c = c & " saldo_qty='" & Xqtymasuk & "'"
            c = c & " where idmaster = '" & idmaster & "'"
            c = c & " and idkartu = '" & idkartu & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " update kartu_stok_master set "
            c = c & " jml_masuk ='" & Xmasuk & "',"
            c = c & " jml_saldo ='" & Xmasuk & "',"
            c = c & " qty_masuk ='" & Xqtymasuk & "',"
            c = c & " saldo_qty='" & Xqtymasuk & "'"
            c = c & " where idmaster = '" & idmaster & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

        Else
            idOld = tbl.Rows(0)("maxkartu")
            s = ""
            s = s & " select * from kartu_stok_pengajuan13"
            s = s & " where idmaster = '" & idmaster & "'"
            s = s & " and idkartu = '" & idOld & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tblO = New DataTable
            tblO.Clear()
            da.Fill(tblO)
            SrpOld = tblO.Rows(0)("saldo")
            SqtyOld = tblO.Rows(0)("saldo_qty")
            YSaldo_rp = 0
            YSaldo_qty = 0
            YSaldo_rp = SrpOld + Xmasuk - XKeluar
            YSaldo_qty = SqtyOld + Xqtymasuk - Xqtykeluar

            c = ""
            c = c & " update kartu_stok_pengajuan13 set "
            c = c & " saldo ='" & YSaldo_rp & "',"
            c = c & " saldo_qty='" & YSaldo_qty & "'"
            c = c & " where idmaster = '" & idmaster & "'"
            c = c & " and idkartu = '" & idkartu & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            s = ""
            s = s & " select * from kartu_stok_master"
            s = s & " where idmaster = '" & idmaster & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tblO = New DataTable
            tblO.Clear()
            da.Fill(tblO)
            Mmasuk = tblO.Rows(0)("jml_masuk")
            MKeluar = tblO.Rows(0)("jml_keluar")
            Mqtymasuk = tblO.Rows(0)("qty_masuk")
            Mqtykeluar = tblO.Rows(0)("qty_keluar")

            Mmasuk = Mmasuk + Xmasuk
            MKeluar = MKeluar + XKeluar
            Mqtymasuk = Mqtymasuk + Xqtymasuk
            Mqtykeluar = Mqtykeluar + Xqtykeluar
            Dim Tqty, TRp As Double
            TRp = Mmasuk - MKeluar
            Tqty = Mqtymasuk - Mqtykeluar

            c = ""
            c = c & " update kartu_stok_master set "
            c = c & " jml_masuk='" & Mmasuk & "',jml_keluar='" & MKeluar & "',"
            c = c & " jml_saldo ='" & TRp & "',"
            c = c & " qty_masuk='" & Mqtymasuk & "', qty_keluar='" & Mqtykeluar & "',"
            c = c & " saldo_qty='" & Tqty & "'"
            c = c & " where idmaster = '" & idmaster & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
        End If


    End Sub
    Public Sub HitungSaldoCadangan(idcad As Integer, idkartu As Double)
        Dim c, s As String
        Dim tbl, tblO, tblD As New DataTable
        Dim Xmasuk, Xqtymasuk, XKeluar, Xqtykeluar As Double
        Dim Mmasuk, Mqtymasuk, MKeluar, Mqtykeluar As Double
        Dim SrpOld, YSaldo_rp As Double
        Dim cmd As New OdbcCommand
        Dim idOld As Double

        s = ""
        s = s & " select * from kartu_stok_cadangan_trans"
        s = s & " where idcadangan = '" & idcad & "'"
        s = s & " and idcadangan_trans = '" & idkartu & "'"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        Xmasuk = tbl.Rows(0)("rp_masuk")
        XKeluar = tbl.Rows(0)("rp_keluar")
        Xqtymasuk = tbl.Rows(0)("qty_masuk")

        s = ""
        s = s & " select if(max(idcadangan_trans) is null,0,max(idcadangan_trans))as MaxKartu from kartu_stok_cadangan_trans"
        s = s & " where idcadangan = '" & idcad & "'"
        s = s & " and idcadangan_trans < '" & idkartu & "'"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If tbl.Rows(0)("maxkartu") = 0 Then
            c = ""
            c = c & " update kartu_stok_cadangan_trans set "
            c = c & " rp_saldo ='" & Xmasuk & "'"
            c = c & " where idcadangan = '" & idcad & "'"
            c = c & " and idcadangan_trans = '" & idkartu & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " update kartu_stok_cadangan set "
            c = c & " rp_masuk ='" & Xmasuk & "',"
            c = c & " rp_saldo ='" & Xmasuk & "',"
            c = c & " qty_saldo ='" & Xqtymasuk & "'"
            c = c & " where idcadangan = '" & idcad & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

        Else
            idOld = tbl.Rows(0)("maxkartu")
            s = ""
            s = s & " select * from kartu_stok_cadangan_trans"
            s = s & " where idcadangan = '" & idcad & "'"
            s = s & " and idcadangan_trans = '" & idOld & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tblD = New DataTable
            tblD.Clear()
            da.Fill(tblD)
            SrpOld = tblD.Rows(0)("rp_saldo")
            YSaldo_rp = 0
            YSaldo_rp = SrpOld + Xmasuk - XKeluar


            c = ""
            c = c & " update kartu_stok_cadangan_trans set "
            c = c & " rp_saldo ='" & YSaldo_rp & "'"
            c = c & " where idcadangan = '" & idcad & "'"
            c = c & " and idcadangan_trans = '" & idkartu & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            s = ""
            s = s & " select * from kartu_stok_cadangan"
            s = s & " where idcadangan = '" & idcad & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tblO = New DataTable
            tblO.Clear()
            da.Fill(tblO)
            Mmasuk = tblO.Rows(0)("rp_masuk")
            MKeluar = tblO.Rows(0)("rp_keluar")
            Mqtymasuk = tblD.Rows(0)("qty_masuk")
            Mqtykeluar = 0

            Mmasuk = Mmasuk + Xmasuk
            MKeluar = MKeluar + XKeluar
            Mqtymasuk = Mqtymasuk + Xqtymasuk
            Mqtykeluar = Mqtykeluar + Xqtykeluar

            Dim Tqty, TRp As Double
            TRp = Mmasuk - MKeluar
            Tqty = Mqtymasuk - Mqtykeluar

            c = ""
            c = c & " update kartu_stok_cadangan set "
            c = c & " rp_masuk='" & Mmasuk & "',rp_keluar='" & MKeluar & "',"
            c = c & " rp_saldo ='" & TRp & "',"
            c = c & " qty_saldo='" & Tqty & "'"
            c = c & " where idcadangan = '" & idcad & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

        End If


    End Sub
    Public Sub HitungSaldoGudang(idgudang As Integer, idkartu As Double)
        Dim c, s As String
        Dim tbl, tblO As New DataTable
        Dim Xmasuk, Xqtymasuk, XKeluar, Xqtykeluar, XSin, XSout As Double
        Dim Mmasuk, Mqtymasuk, MKeluar, Mqtykeluar, MSin, MSout As Double
        Dim SrpOld, SqtyOld, SSetorOld, YSaldo_rp, YSaldo_qty, Ysetor As Double
        Dim cmd As New OdbcCommand
        Dim idOld As Double

        s = ""
        s = s & " select * from kartu_stok_gudang_trans"
        s = s & " where idgudang = '" & idgudang & "'"
        s = s & " and idgudang_trans = '" & idkartu & "'"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        Xmasuk = tbl.Rows(0)("rp_masuk")
        Xqtymasuk = tbl.Rows(0)("qty_masuk")
        XKeluar = tbl.Rows(0)("rp_keluar")
        Xqtykeluar = tbl.Rows(0)("qty_keluar")
        XSin = tbl.Rows(0)("setor_in")
        XSout = tbl.Rows(0)("setor_out")

        s = ""
        s = s & " select if(max(idgudang_trans) is null,0,max(idgudang_trans))as MaxKartu from kartu_stok_gudang_trans"
        s = s & " where idgudang = '" & idgudang & "'"
        s = s & " and idgudang_trans < '" & idkartu & "'"
        da = New Odbc.OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If tbl.Rows(0)("maxkartu") = 0 Then
            c = ""
            c = c & " update kartu_stok_gudang_trans set "
            c = c & " rp_saldo ='" & Xmasuk & "',"
            c = c & " saldo_qty='" & Xqtymasuk & "',"
            c = c & " saldo_setor='" & XSin & "'"
            c = c & " where idgudang = '" & idgudang & "'"
            c = c & " and idgudang_trans = '" & idkartu & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            c = ""
            c = c & " update kartu_stok_gudang set "
            c = c & " jml_masuk ='" & Xmasuk & "',"
            c = c & " jml_saldo ='" & Xmasuk & "',"
            c = c & " qty_masuk ='" & Xqtymasuk & "',"
            c = c & " saldo_qty='" & Xqtymasuk & "',"
            c = c & " setor_in='" & XSin & "',"
            c = c & " saldo_setor='" & XSin & "'"
            c = c & " where idgudang = '" & idgudang & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

        Else
            idOld = tbl.Rows(0)("maxkartu")
            s = ""
            s = s & " select * from kartu_stok_gudang_trans"
            s = s & " where idgudang = '" & idgudang & "'"
            s = s & " and idgudang_trans = '" & idOld & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tblO = New DataTable
            tblO.Clear()
            da.Fill(tblO)
            SrpOld = tblO.Rows(0)("rp_saldo")
            SqtyOld = tblO.Rows(0)("saldo_qty")
            SSetorOld = tblO.Rows(0)("saldo_setor")
            YSaldo_rp = 0
            YSaldo_qty = 0
            Ysetor = 0
            YSaldo_rp = SrpOld + Xmasuk - XKeluar
            YSaldo_qty = SqtyOld + Xqtymasuk - Xqtykeluar
            Ysetor = SSetorOld + XSin - XSout

            c = ""
            c = c & " update kartu_stok_gudang_trans set "
            c = c & " rp_saldo ='" & YSaldo_rp & "',"
            c = c & " saldo_qty='" & YSaldo_qty & "',"
            c = c & " saldo_setor='" & Ysetor & "'"
            c = c & " where idgudang = '" & idgudang & "'"
            c = c & " and idgudang_trans = '" & idkartu & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()

            s = ""
            s = s & " select * from kartu_stok_gudang"
            s = s & " where idgudang = '" & idgudang & "'"
            da = New Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tblO = New DataTable
            tblO.Clear()
            da.Fill(tblO)
            Mmasuk = tblO.Rows(0)("jml_masuk")
            MKeluar = tblO.Rows(0)("jml_keluar")
            Mqtymasuk = tblO.Rows(0)("qty_masuk")
            Mqtykeluar = tblO.Rows(0)("qty_keluar")
            MSin = tblO.Rows(0)("setor_in")
            MSout = tblO.Rows(0)("setor_out")

            Mmasuk = Mmasuk + Xmasuk
            MKeluar = MKeluar + XKeluar
            Mqtymasuk = Mqtymasuk + Xqtymasuk
            Mqtykeluar = Mqtykeluar + Xqtykeluar
            MSin = MSin + XSin
            MSout = MSout + XSout

            Dim Tqty, TRp, TSetor As Double
            TRp = Mmasuk - MKeluar
            Tqty = Mqtymasuk - Mqtykeluar
            TSetor = MSin - MSout
            c = ""
            c = c & " update kartu_stok_gudang set "
            c = c & " jml_masuk='" & Mmasuk & "',jml_keluar='" & MKeluar & "',"
            c = c & " jml_saldo ='" & TRp & "',"
            c = c & " qty_masuk='" & Mqtymasuk & "', qty_keluar='" & Mqtykeluar & "',"
            c = c & " saldo_qty='" & Tqty & "',"
            c = c & " setor_in='" & MSin & "', setor_out='" & MSout & "',"
            c = c & " saldo_setor='" & TSetor & "'"
            c = c & " where idgudang = '" & idgudang & "'"
            cmd = New Odbc.OdbcCommand(c, conn)
            cmd.ExecuteNonQuery()
        End If


    End Sub
End Module

