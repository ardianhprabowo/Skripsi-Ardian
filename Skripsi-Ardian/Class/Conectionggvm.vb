Imports System.Data.Odbc
'Imports MySql.Data.MySqlClient
Imports System.Net

Module Conectionggvm
    Public conn As OdbcConnection
    'Public cnn As MySqlConnection
    Public da As OdbcDataAdapter
    Public dr As OdbcDataReader
    Public cmd As OdbcCommand
    Public dt As DataTable
    Public ds As DataSet
    Public str As String
    Public sql As String
    Public connectionString As String
    Public userid, UserMinta, Divisi As String
    Public CetakIDDtOrder As String
    Public tampilsurver, tampilSPGMaju, tampilALLMaju, tampilLPJ, TampilIdCost, ProsesDetail As String
    Public ProsesCetak, tampilIdMajuAll, tampilIdMajuSPG, CetakIdLPJ, TampilIdLPJ, tampilIdMajuPRD, cetakIdPE, cetakIdKirim As String
    Public TampilIdPE, Usermenu, Fullname As String
    Public Proses As String
    Public LevelUser, DivUser, DivMinta, LevelMinta As Integer
    Public MutasiKas As Byte

    Public Sub GGVM_conn()
        'str = "Dsn=ggvmconn;uid=root;database=geogiven_VM;port=3306"
        'str = "Dsn=ggvmconn_local;;uid=root;database=geogiven_vm;port=3306"
        str = "Driver={MySQL ODBC 5.2 UNICODE Driver};Server=127.0.0.1;Database=p2p_db; User=root;Password=toorGGVM;Option=3;port=3306;"
        'str = "Driver={MySQL ODBC 5.3 UNICODE Driver};Server=127.0.0.1;Database=geogiven_vm; User=root;Password=toorGGVM;Option=3;port=3306;"
        'str = "Driver={MySQL ODBC 5.3 UNICODE Driver};Server=192.168.0.10;Database=geogiven_vm; User=root;Password=toorGGVM;Option=3;port=3306;"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Public Sub GGVM_conn_close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn = Nothing
        End If
    End Sub

    'Public Function ConnWAS() As MySqlConnection

    '    'Dim cnn As MySqlConnection
    '    connectionString = " server=182.253.40.25;port=15503;user id=wasmod;" & _
    '                            "password=yMmt*2+fp@P85vp#;database=absensi_inhouse_db"
    '    cnn = New MySqlConnection(connectionString)
    '    Try

    '        cnn.Open()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        cnn.Close()
    '    End Try
    '    Return cnn
    'End Function

    'Public Function ConnProject() As MySqlConnection
    '    connectionString = " server=182.253.40.25;port=15502;user id=ggvmit;" & _
    '                            "password=ASDzxc123qwe!!!;database=project_ggvm"
    '    cnn = New MySqlConnection(connectionString)
    '    Try
    '        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
    '        cnn.Open()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        cnn.Close()
    '    End Try
    '    Return cnn
    'End Function
End Module
