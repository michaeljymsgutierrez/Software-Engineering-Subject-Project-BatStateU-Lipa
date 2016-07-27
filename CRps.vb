Public Class CRps

    Private Sub CRps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk' table. You can move, or remove it, as needed.
        Me.CashierandReg_prt_spkTableAdapter.Fill(Me.Cashier_Registrar_printers_speakersDataSet.CashierandReg_prt_spk)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class