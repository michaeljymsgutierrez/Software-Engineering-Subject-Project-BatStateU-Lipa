<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ciscolabsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ciscolabsu))
        Me.CISCOlabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CISCOlab_systemunitsDataSet = New BSUEquipments.CISCOlab_systemunitsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CISCOlabTableAdapter = New BSUEquipments.CISCOlab_systemunitsDataSetTableAdapters.CISCOlabTableAdapter()
        CType(Me.CISCOlabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CISCOlab_systemunitsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CISCOlabBindingSource
        '
        Me.CISCOlabBindingSource.DataMember = "CISCOlab"
        Me.CISCOlabBindingSource.DataSource = Me.CISCOlab_systemunitsDataSet
        '
        'CISCOlab_systemunitsDataSet
        '
        Me.CISCOlab_systemunitsDataSet.DataSetName = "CISCOlab_systemunitsDataSet"
        Me.CISCOlab_systemunitsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CISCOlabBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSUEquipments.Ciscolabsu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(827, 403)
        Me.ReportViewer1.TabIndex = 0
        '
        'CISCOlabTableAdapter
        '
        Me.CISCOlabTableAdapter.ClearBeforeFill = True
        '
        'Ciscolabsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 403)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ciscolabsu"
        Me.Text = "CISCO Laboratory Print Report"
        CType(Me.CISCOlabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CISCOlab_systemunitsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CISCOlabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CISCOlab_systemunitsDataSet As BSUEquipments.CISCOlab_systemunitsDataSet
    Friend WithEvents CISCOlabTableAdapter As BSUEquipments.CISCOlab_systemunitsDataSetTableAdapters.CISCOlabTableAdapter
End Class
