<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRps))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Cashier_Registrar_printers_speakersDataSet = New BSUEquipments.Cashier_Registrar_printers_speakersDataSet()
        Me.CashierandReg_prt_spkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CashierandReg_prt_spkTableAdapter = New BSUEquipments.Cashier_Registrar_printers_speakersDataSetTableAdapters.CashierandReg_prt_spkTableAdapter()
        CType(Me.Cashier_Registrar_printers_speakersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashierandReg_prt_spkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CashierandReg_prt_spkBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BSUEquipments.CRps.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(841, 404)
        Me.ReportViewer1.TabIndex = 0
        '
        'Cashier_Registrar_printers_speakersDataSet
        '
        Me.Cashier_Registrar_printers_speakersDataSet.DataSetName = "Cashier_Registrar_printers_speakersDataSet"
        Me.Cashier_Registrar_printers_speakersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CashierandReg_prt_spkBindingSource
        '
        Me.CashierandReg_prt_spkBindingSource.DataMember = "CashierandReg_prt_spk"
        Me.CashierandReg_prt_spkBindingSource.DataSource = Me.Cashier_Registrar_printers_speakersDataSet
        '
        'CashierandReg_prt_spkTableAdapter
        '
        Me.CashierandReg_prt_spkTableAdapter.ClearBeforeFill = True
        '
        'CRps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 404)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CRps"
        Me.Text = "Cashier / Registrar Print Report"
        CType(Me.Cashier_Registrar_printers_speakersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashierandReg_prt_spkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CashierandReg_prt_spkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cashier_Registrar_printers_speakersDataSet As BSUEquipments.Cashier_Registrar_printers_speakersDataSet
    Friend WithEvents CashierandReg_prt_spkTableAdapter As BSUEquipments.Cashier_Registrar_printers_speakersDataSetTableAdapters.CashierandReg_prt_spkTableAdapter
End Class
