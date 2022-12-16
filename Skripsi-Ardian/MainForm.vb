Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Navigation

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AccordAccount.Text = userid
        OverlayFormShow.Instance.ShowFormOverlay(FrmLogin)
        Dim frm As FrmLogin = New FrmLogin()
        frm.ShowDialog()
    End Sub
    Private Sub AccordionControl1_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
        If e.Element.Style = ElementStyle.Group Then
            e.DrawImage()
            e.DrawText()
            e.DrawContextButtons()
            e.Cache.DrawLine(e.Cache.GetPen(e.Appearance.ForeColor),
                New Point(e.ObjectInfo.HeaderBounds.Left, e.ObjectInfo.HeaderBounds.Bottom),
                New Point(e.ObjectInfo.HeaderBounds.Right, e.ObjectInfo.HeaderBounds.Bottom))
            e.Handled = True
        End If
    End Sub

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs) Handles AccordionControlElement1.Click
        Application.ExitThread()
    End Sub

   
    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs) Handles User_logout.Click

        AccordAccount.Text = "Belum Login"
        FluentDesignFormContainer1.Controls.Add(Nothing)
        OverlayFormShow.Instance.ShowFormOverlay(FrmLogin)
        Dim frm As FrmLogin = New FrmLogin()
        frm.ShowDialog()

    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles User_viewProfil.Click
        FluentDesignFormContainer1.Controls.Add(New UserRegistration)

    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles Marketing_DataOrder.Click
        Me.FluentDesignFormContainer1.Controls.Add(New DataOrder() With {
       .Dock = DockStyle.Fill
        })
    End Sub

    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles Desain_InternalPO.Click
        Me.FluentDesignFormContainer1.Controls.Add(New POInternalDesign() With {
        .Dock = DockStyle.Fill
         })
    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs) Handles Printing_InternalPO.Click
        Me.FluentDesignFormContainer1.Controls.Add(New POInternalPrinting() With {
       .Dock = DockStyle.Fill
        })
    End Sub

    Private Sub Produksi_AlokasiManpower_Click(sender As Object, e As EventArgs) Handles Produksi_AlokasiManpower.Click

    End Sub

    Private Sub Produksi_InternalPO_Click(sender As Object, e As EventArgs) Handles Produksi_InternalPO.Click
        Me.FluentDesignFormContainer1.Controls.Add(New POProduksi() With {
      .Dock = DockStyle.Fill
       })
    End Sub

    Private Sub Produksi_ListPOSelesai_Click(sender As Object, e As EventArgs) Handles Produksi_ListPOSelesai.Click
        Me.FluentDesignFormContainer1.Controls.Add(New POSelesai() With {
    .Dock = DockStyle.Fill
     })
    End Sub

    Private Sub Marketing_DetailDO_Click(sender As Object, e As EventArgs) Handles Marketing_DetailDO.Click
        Me.FluentDesignFormContainer1.Controls.Add(New DetailDataOrder() With {
    .Dock = DockStyle.Fill
     })
    End Sub

    Private Sub Marketing_Penawaran_Click(sender As Object, e As EventArgs) Handles Marketing_Penawaran.Click
        Me.FluentDesignFormContainer1.Controls.Add(New PenawaranP2P() With {
   .Dock = DockStyle.Fill
    })
    End Sub

    Private Sub Marketing_POInternal_Click(sender As Object, e As EventArgs) Handles Marketing_POInternal.Click
        Me.FluentDesignFormContainer1.Controls.Add(New KirimPOInt() With {
   .Dock = DockStyle.Fill
    })
    End Sub
End Class
