Imports System.Data.Odbc

Public Class UserRegistration

    Dim oMD5 As New CMD5
    Private Sub Clear()
        Sby.Checked = False
        TFullname.Text = ""
        TUsername.Text = ""
        TPassword.Text = ""
        THandphone.Text = ""
        TEmail.Text = ""
        BtnSimpan.Enabled = False
    End Sub
    Private Sub FrmUserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Dim s As String
        Dim pass As String
        Dim tbl As New DataTable
        Dim iddiv As String

        'TextBox1.Text = md5.Encrypt(TPassword.Text)
        ' TextBox1.Text = oMD5.computeHash(TPassword.Text)
        iddiv = ""
        If RB01.Checked = True Then
            iddiv = 1
        End If
        If RB02.Checked = True Then
            iddiv = 2
        End If
        If RB03.Checked = True Then
            iddiv = 3
        End If
        If RB04.Checked = True Then
            iddiv = 4
        End If
        If RB05.Checked = True Then
            iddiv = 5
        End If
        If RB06.Checked = True Then
            iddiv = 6
        End If
        If RB07.Checked = True Then
            iddiv = 7
        End If
        If RB08.Checked = True Then
            iddiv = 8
        End If
        If RB09.Checked = True Then
            iddiv = 9
        End If
        If RB00.Checked = True Then
            iddiv = 0
        End If
        s = ""
        s = s & " select count(*)as ada from user"
        s = s & " where username = '" & Trim(TUsername.Text) & "'"
        s = s & " and iddivisi = '" & iddiv & "'"
        da = New OdbcDataAdapter(s, conn)
        ds.Clear()
        tbl = New DataTable
        tbl.Clear()
        da.Fill(tbl)
        If tbl.Rows(0)("ada") = "1" Then
            oMD5 = New CMD5
            pass = oMD5.computeHash(TPassword.Text)
            ' pass = md5.Encrypt(TPassword.Text)
            TextBox1.Text = pass

            s = ""
            s = s & " select count(*)as ada from user"
            s = s & " where username = '" & Trim(TUsername.Text) & "'"
            s = s & " and password = '" & pass & "'"
            s = s & " and iddivisi = '" & iddiv & "'"
            da = New System.Data.Odbc.OdbcDataAdapter(s, conn)
            ds.Clear()
            tbl = New DataTable
            tbl.Clear()
            da.Fill(tbl)
            If tbl.Rows(0)("ada") = "1" Then
                userid = TUsername.Text
                MsgBox("Password Benar...coba lagi !!!")
            Else
                MsgBox("Password Salah...coba lagi !!!")
            End If
        Else
            MsgBox("Username Salah...coba lagi !!!")
            TUsername.Focus()
        End If

    End Sub

    Private Sub Sby_CheckedChanged(sender As Object, e As EventArgs) Handles Sby.CheckedChanged
        If Sby.Checked = True Then
            TKota.Text = "Surabaya"
            TFullname.Focus()
        Else
            TKota.Text = ""
        End If
    End Sub

    Private Sub TUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TUsername.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            TPassword.Focus()
        End If
    End Sub

    Private Sub TPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPassword.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            BtnOK.Focus()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim s As String
        Dim iddiv As String
        Dim cmd As New OdbcCommand

        iddiv = ""
        If RB01.Checked = True Then
            iddiv = 1
        End If
        If RB02.Checked = True Then
            iddiv = 2
        End If
        If RB03.Checked = True Then
            iddiv = 3
        End If
        If RB04.Checked = True Then
            iddiv = 4
        End If
        If RB05.Checked = True Then
            iddiv = 5
        End If
        If RB06.Checked = True Then
            iddiv = 6
        End If
        If RB07.Checked = True Then
            iddiv = 7
        End If
        If RB08.Checked = True Then
            iddiv = 8
        End If
        If RB09.Checked = True Then
            iddiv = 9
        End If
        If RB00.Checked = True Then
            iddiv = 0
        End If
        If RB10.Checked = True Then
            iddiv = 10
        End If
        If RB11.Checked = True Then
            iddiv = 11
        End If
        If RB12.Checked = True Then
            iddiv = 12
        End If
        If RB13.Checked = True Then
            iddiv = 13
        End If
        Dim oMD5 As md5ku = New md5ku
        Dim Pass As String = oMD5.Encrypt(TPassword.Text)
        If TUsername.Text = "" Then
            MsgBox("Username belum diisi!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            TUsername.Focus()
            Exit Sub
        ElseIf TPassword.Text = "" Then
            MsgBox("Password belum diisi!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            TPassword.Focus()
            Exit Sub
        ElseIf TEmail.Text = "" Then
            MsgBox("Email belum diisi!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            TEmail.Focus()
            Exit Sub
        ElseIf TKota.Text = "" Then
            MsgBox("Kota belum diisi!!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")
            TKota.Focus()
            Exit Sub
        ElseIf TFullname.Text = "" Then
            TFullname.Text = TUsername.Text
        Else
            GGVM_conn()
            s = ""
            s = s & "select COUNT(*) AS ADA from user"
            s = s & " where iddivisi = '" & iddiv & "'"
            s = s & " and username='" & Trim(TUsername.Text) & "'"
            cmd = New OdbcCommand(s, conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = 0 Then
                MessageBox.Show("Data sudah ada!!...", "Geo Given System: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TUsername.Focus()
            Else
                s = ""
                s = s & " insert into user( iddivisi,kota,fullname,username,password,level,email,hp) values "
                s = s & " ('" & iddiv & "','" & TKota.Text & "','" & TFullname.Text & "','" & TUsername.Text & "','" & Pass & "','1','" & TEmail.Text & "','" & THandphone.Text & "') "
                cmd = New OdbcCommand(s, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data sudah diSIMPAN !!..", vbInformation, "Information")
            End If
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Sby.Checked = True
        TUsername.Text = ""
        TFullname.Text = ""
        TPassword.Text = ""
        TEmail.Text = ""
        THandphone.Text = ""
    End Sub
End Class
