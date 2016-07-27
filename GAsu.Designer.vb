<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAsu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAsu))
        Me.Guidance_admission_systemunitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guidance_Admission_systemunitsDataSet = New BSUEquipments.Guidance_Admission_systemunitsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Guidance_admission_systemunitsTableAdapter = New BSUEquipments.Guidance_Admission_systemunitsDataSetTableAdapters.Guidance_admission_systemunitsTableAdapter()
        CType(Me.Guidance_admission_systemunitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guidance_Admission_systemunitsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guidance_admission_systemunitsBindingSource
        '
        Me.Guidance_admission_systemunitsBindingSource.DataMember = "Guidance_admission_systemunits"
        Me.Guidance_admission_systemunitsBindingSource.DataSource = Me.Guidance_Admission_systemunitsDataSet
        '
        'Guidance_Admission_systemunitsDataSet
        '
        Me.Guidance_Admission_systemunitsDataSet.DataSetName = "Guidance_Admission_systemunitsDataSet"
        Me.Guidance_Admission_systemunitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Guidance_admission_systemunitsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSUEquipments.GAsu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(839, 401)
        Me.ReportViewer1.TabIndex = 0
        '
        'Guidance_admission_systemunitsTableAdapter
        '
        Me.Guidance_admission_systemunitsTableAdapter.ClearBeforeFill = True
        '
        'GAsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 401)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GAsu"
        Me.Text = "Guidance / Admission Office Print Report"
        CType(Me.Guidance_admission_systemunitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guidance_Admission_systemunitsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Guidance_admission_systemunitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Guidance_Admission_systemunitsDataSet As BSUEquipments.Guidance_Admission_systemunitsDataSet
    Friend WithEvents Guidance_admission_systemunitsTableAdapter As BSUEquipments.Guidance_Admission_systemunitsDataSetTableAdapters.Guidance_admission_systemunitsTableAdapter
End Class
