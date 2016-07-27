Public Class GAsu

    Private Sub GAsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits' table. You can move, or remove it, as needed.
        Me.Guidance_admission_systemunitsTableAdapter.Fill(Me.Guidance_Admission_systemunitsDataSet.Guidance_admission_systemunits)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class