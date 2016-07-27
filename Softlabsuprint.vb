Public Class Softlabsuprint

    Private Sub Softlabsuprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SoftLAB_systemunitsDataSet.SoftLAB_systemunits' table. You can move, or remove it, as needed.
        Me.SoftLAB_systemunitsTableAdapter.Fill(Me.SoftLAB_systemunitsDataSet.SoftLAB_systemunits)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class