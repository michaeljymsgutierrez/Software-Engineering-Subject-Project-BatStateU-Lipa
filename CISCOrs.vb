Public Class CISCOrs

    Private Sub CISCOrs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches' table. You can move, or remove it, as needed.
        Me.CISCOlab_routers_switchesTableAdapter.Fill(Me.CISCOlab_routers_switchesDataSet.CISCOlab_routers_switches)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class