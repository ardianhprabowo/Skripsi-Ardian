﻿Public Class POSelesai

    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill the SqlDataSource asynchronously
        SqlDataSource1.FillAsync()
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        If e.Button.Properties.Caption = "CETAK" Then
            GridControl1.ShowRibbonPrintPreview()
        ElseIf e.Button.Properties.Caption = "EXIT" Then
            Me.Dispose()
        ElseIf e.Button.Properties.Caption = "REFRESH" Then
            SqlDataSource1.FillAsync()
        End If
    End Sub
End Class
