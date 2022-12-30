Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils.Drawing
Imports System.Drawing
Imports System.Data.Odbc

Public Class FrmLogin
    Sub New()
        InitializeComponent()

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim Query As String
        Dim oMD5 As CMD5 = New CMD5
        Dim MD5Hash As String = oMD5.computeHash(TPassword.Text)
        Try
            GGVM_conn()
        Catch myerror As OdbcException
            MessageBox.Show("Connection Error!: " & myerror.Message)
        End Try
        Query = ""
        Query &= " select if (fullname is null,'User',fullname) as fullname,level,iddivisi,if (menu is null,'',menu)as menu from user "
        Query = Query & " where username = '" & Trim(TUsername.Text) & "' and password = '" & MD5Hash & "'"
        cmd = New OdbcCommand(Query, conn)
        dr = cmd.ExecuteReader
        If dr.HasRows = 0 Then
            MessageBox.Show("Your login details are not a valid.", "Program P2P System: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            userid = TUsername.Text
            If dr.Item("fullname") Is "User" Then
                Fullname = userid
            Else
                Fullname = dr.Item("fullname")
            End If
            LevelUser = dr.Item("level")
            DivUser = dr.Item("iddivisi")
            Usermenu = dr.Item("menu")
            If DivUser = "1" Or DivUser = "5" Or DivUser = "9" Or DivUser = "10" Or DivUser = "0" Then
                MainForm.AccordAccount.Text = userid
                OverlayFormShow.Instance.CloseProgressPanel()
                Me.Close()
            Else
                MessageBox.Show("Your login details are valid. but not to use this Apps", "P2P System: Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            
        End If
        
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Application.[Exit]()
    End Sub
End Class
