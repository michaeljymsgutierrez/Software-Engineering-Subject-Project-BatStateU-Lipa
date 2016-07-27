Public Class Ciscolabsu

    Private Sub Ciscolabsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CISCOlab_systemunitsDataSet.CISCOlab' table. You can move, or remove it, as needed.
        Me.CISCOlabTableAdapter.Fill(Me.CISCOlab_systemunitsDataSet.CISCOlab)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class