Public Class ICT_IGP_Print

    Private Sub ICT_IGP_Print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ICT_systemunitsDataSet.ICT_systemunits' table. You can move, or remove it, as needed.
        Me.ICT_systemunitsTableAdapter.Fill(Me.ICT_systemunitsDataSet.ICT_systemunits)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class