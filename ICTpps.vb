Public Class ICTpps

    Private Sub ICTpps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ICT_projectors_printers_speakersDataSet.ICT_pps' table. You can move, or remove it, as needed.
        Me.ICT_ppsTableAdapter.Fill(Me.ICT_projectors_printers_speakersDataSet.ICT_pps)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)



        Me.ReportViewer1.RefreshReport()
    End Sub
End Class