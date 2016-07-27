<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Softlabsuprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Softlabsuprint))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SoftLAB_systemunitsDataSet = New BSUEquipments.SoftLAB_systemunitsDataSet()
        Me.SoftLAB_systemunitsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftLAB_systemunitsTableAdapter = New BSUEquipments.SoftLAB_systemunitsDataSetTableAdapters.SoftLAB_systemunitsTableAdapter()
        CType(Me.SoftLAB_systemunitsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftLAB_systemunitsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SoftLAB_systemunitsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSUEquipments.Softlabsuprint.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(840, 393)
        Me.ReportViewer1.TabIndex = 0
        '
        'SoftLAB_systemunitsDataSet
        '
        Me.SoftLAB_systemunitsDataSet.DataSetName = "SoftLAB_systemunitsDataSet"
        Me.SoftLAB_systemunitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoftLAB_systemunitsBindingSource
        '
        Me.SoftLAB_systemunitsBindingSource.DataMember = "SoftLAB_systemunits"
        Me.SoftLAB_systemunitsBindingSource.DataSource = Me.SoftLAB_systemunitsDataSet
        '
        'SoftLAB_systemunitsTableAdapter
        '
        Me.SoftLAB_systemunitsTableAdapter.ClearBeforeFill = True
        '
        'Softlabsuprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 393)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Softlabsuprint"
        Me.Text = "Software Laboratory  Print Report"
        CType(Me.SoftLAB_systemunitsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftLAB_systemunitsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SoftLAB_systemunitsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoftLAB_systemunitsDataSet As BSUEquipments.SoftLAB_systemunitsDataSet
    Friend WithEvents SoftLAB_systemunitsTableAdapter As BSUEquipments.SoftLAB_systemunitsDataSetTableAdapters.SoftLAB_systemunitsTableAdapter
End Class
