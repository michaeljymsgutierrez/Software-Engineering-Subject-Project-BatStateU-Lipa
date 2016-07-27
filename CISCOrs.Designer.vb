<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CISCOrs
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CISCOlab_routers_switchesDataSet = New BSUEquipments.CISCOlab_routers_switchesDataSet()
        Me.CISCOlab_routers_switchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CISCOlab_routers_switchesTableAdapter = New BSUEquipments.CISCOlab_routers_switchesDataSetTableAdapters.CISCOlab_routers_switchesTableAdapter()
        CType(Me.CISCOlab_routers_switchesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CISCOlab_routers_switchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CISCOlab_routers_switchesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSUEquipments.CISCOrs.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(860, 407)
        Me.ReportViewer1.TabIndex = 0
        '
        'CISCOlab_routers_switchesDataSet
        '
        Me.CISCOlab_routers_switchesDataSet.DataSetName = "CISCOlab_routers_switchesDataSet"
        Me.CISCOlab_routers_switchesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CISCOlab_routers_switchesBindingSource
        '
        Me.CISCOlab_routers_switchesBindingSource.DataMember = "CISCOlab_routers_switches"
        Me.CISCOlab_routers_switchesBindingSource.DataSource = Me.CISCOlab_routers_switchesDataSet
        '
        'CISCOlab_routers_switchesTableAdapter
        '
        Me.CISCOlab_routers_switchesTableAdapter.ClearBeforeFill = True
        '
        'CISCOrs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 407)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CISCOrs"
        Me.Text = "CISCO Laboratory Print Report"
        CType(Me.CISCOlab_routers_switchesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CISCOlab_routers_switchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CISCOlab_routers_switchesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CISCOlab_routers_switchesDataSet As BSUEquipments.CISCOlab_routers_switchesDataSet
    Friend WithEvents CISCOlab_routers_switchesTableAdapter As BSUEquipments.CISCOlab_routers_switchesDataSetTableAdapters.CISCOlab_routers_switchesTableAdapter
End Class
