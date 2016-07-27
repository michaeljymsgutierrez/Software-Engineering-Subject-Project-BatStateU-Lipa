Public Class CRsu

    Private Sub CRsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cashier_Registrar_systemunitsDataSet.CashierandReg_su' table. You can move, or remove it, as needed.
        Me.CashierandReg_suTableAdapter.Fill(Me.Cashier_Registrar_systemunitsDataSet.CashierandReg_su)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class