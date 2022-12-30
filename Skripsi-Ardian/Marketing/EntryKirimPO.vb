Public Class EntryKirimPO
    Dim po As New DataOrder
  

    Private Sub EntryKirimPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTDeadlineDsn.Format = DateTimePickerFormat.Custom
        DTDeadlineDsn.CustomFormat = "dd/MM/yyyy"
        DTDeadline.Format = DateTimePickerFormat.Custom
        DTDeadline.CustomFormat = "dd/MM/yyyy"
        DTDeadlinePrd.Format = DateTimePickerFormat.Custom
        DTDeadlinePrd.CustomFormat = "dd/MM/yyyy"
        DTDeadlinePrt.Format = DateTimePickerFormat.Custom
        DTDeadlinePrt.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class
